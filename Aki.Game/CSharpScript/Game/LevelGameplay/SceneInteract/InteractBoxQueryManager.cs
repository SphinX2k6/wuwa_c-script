using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BCB RID: 23499
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractBoxQueryManager : Singleton
	{
		// Token: 0x06039C15 RID: 236565 RVA: 0x01038D64 File Offset: 0x01036F64
		public List<int> RegisterSnapshot(Vector baseLocation, Quat baseRotation, IEnumerable<IBoxDesc> boxes)
		{
			List<int> list = new List<int>();
			foreach (IBoxDesc desc in boxes)
			{
				SolidBox solidBox = new SolidBox();
				this.RefreshBox(solidBox, baseLocation, baseRotation, desc);
				solidBox.RefCount = 1;
				int nextId = this.NextId;
				this.NextId = nextId + 1;
				int num = nextId;
				this.Boxes[num] = solidBox;
				list.Add(num);
			}
			return list;
		}

		// Token: 0x06039C16 RID: 236566 RVA: 0x01038DF0 File Offset: 0x01036FF0
		public void AddRef(int id)
		{
			SolidBox solidBox;
			if (this.Boxes.TryGetValue(id, out solidBox) && solidBox != null)
			{
				solidBox.RefCount++;
			}
		}

		// Token: 0x06039C17 RID: 236567 RVA: 0x01038E20 File Offset: 0x01037020
		public void Release(int id)
		{
			SolidBox solidBox;
			if (!this.Boxes.TryGetValue(id, out solidBox) || solidBox == null)
			{
				return;
			}
			solidBox.RefCount--;
			if (solidBox.RefCount <= 0)
			{
				this.Boxes.Remove(id);
			}
		}

		// Token: 0x06039C18 RID: 236568 RVA: 0x01038E68 File Offset: 0x01037068
		public void QueryAll(Vector point, HashSet<int> outResult)
		{
			foreach (KeyValuePair<int, SolidBox> keyValuePair in this.Boxes)
			{
				int num;
				SolidBox solidBox;
				keyValuePair.Deconstruct(out num, out solidBox);
				int item = num;
				SolidBox box = solidBox;
				if (this.ContainsInBox(box, point))
				{
					outResult.Add(item);
				}
			}
		}

		// Token: 0x06039C19 RID: 236569 RVA: 0x01038ED8 File Offset: 0x010370D8
		[NullableContext(2)]
		public IBoxSnapshot GetBoxSnapshot(int id)
		{
			return this.Boxes.GetValueOrDefault(id);
		}

		// Token: 0x06039C1A RID: 236570 RVA: 0x01038EE6 File Offset: 0x010370E6
		public void Clear()
		{
			this.Boxes.Clear();
			this.NextId = 1;
		}

		// Token: 0x06039C1B RID: 236571 RVA: 0x01038EFC File Offset: 0x010370FC
		private void RefreshBox(SolidBox box, Vector baseLocation, Quat baseRotation, IBoxDesc desc)
		{
			box.Position.DeepCopy(baseLocation);
			box.Rotation.DeepCopy(baseRotation);
			box.LocationOffset.DeepCopy(desc.LocationOffset);
			box.HalfExtent.DeepCopy(desc.HalfExtent);
			Vector tempVector = this.TempVector1;
			box.Rotation.RotateVector(box.LocationOffset, tempVector);
			box.Position.Addition(tempVector, box.WorldPosition);
			Vector tempVector2 = this.TempVector1;
			Vector tempVector3 = this.TempVector2;
			Vector tempVector4 = this.TempVector3;
			box.Rotation.GetAxisX(tempVector2);
			box.Rotation.GetAxisY(tempVector3);
			box.Rotation.GetAxisZ(tempVector4);
			Vector vector = tempVector2;
			Vector vector2 = tempVector3;
			Vector vector3 = tempVector4;
			Vector halfExtent = box.HalfExtent;
			double num = Math.Abs(vector.X) * halfExtent.X + Math.Abs(vector2.X) * halfExtent.Y + Math.Abs(vector3.X) * halfExtent.Z;
			double num2 = Math.Abs(vector.Y) * halfExtent.X + Math.Abs(vector2.Y) * halfExtent.Y + Math.Abs(vector3.Y) * halfExtent.Z;
			double num3 = Math.Abs(vector.Z) * halfExtent.X + Math.Abs(vector2.Z) * halfExtent.Y + Math.Abs(vector3.Z) * halfExtent.Z;
			Vector worldPosition = box.WorldPosition;
			Vector worldAabbMin = box.WorldAabbMin;
			Vector worldAabbMax = box.WorldAabbMax;
			worldAabbMin.X = worldPosition.X - num;
			worldAabbMin.Y = worldPosition.Y - num2;
			worldAabbMin.Z = worldPosition.Z - num3;
			worldAabbMax.X = worldPosition.X + num;
			worldAabbMax.Y = worldPosition.Y + num2;
			worldAabbMax.Z = worldPosition.Z + num3;
		}

		// Token: 0x06039C1C RID: 236572 RVA: 0x010390F0 File Offset: 0x010372F0
		private bool ContainsInBox(SolidBox box, Vector point)
		{
			Vector worldAabbMin = box.WorldAabbMin;
			Vector worldAabbMax = box.WorldAabbMax;
			if (point.X < worldAabbMin.X || point.X > worldAabbMax.X || point.Y < worldAabbMin.Y || point.Y > worldAabbMax.Y || point.Z < worldAabbMin.Z || point.Z > worldAabbMax.Z)
			{
				return false;
			}
			Vector tempVector = this.TempVector1;
			point.Subtraction(box.WorldPosition, tempVector);
			Vector tempVector2 = this.TempVector2;
			box.Rotation.UnRotateVector(tempVector, tempVector2);
			Vector vector = tempVector2;
			double num = Math.Abs(vector.X);
			double num2 = Math.Abs(vector.Y);
			double num3 = Math.Abs(vector.Z);
			Vector halfExtent = box.HalfExtent;
			return num <= halfExtent.X && num2 <= halfExtent.Y && num3 <= halfExtent.Z;
		}

		// Token: 0x17006E14 RID: 28180
		// (get) Token: 0x06039C1D RID: 236573 RVA: 0x010391E4 File Offset: 0x010373E4
		public static InteractBoxQueryManager Instance
		{
			get
			{
				if (InteractBoxQueryManager._instance == null)
				{
					InteractBoxQueryManager._instance = new InteractBoxQueryManager();
					InteractBoxQueryManager._instance.OnInit();
				}
				return InteractBoxQueryManager._instance;
			}
		}

		// Token: 0x06039C1E RID: 236574 RVA: 0x01039207 File Offset: 0x01037407
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039C1F RID: 236575 RVA: 0x01039209 File Offset: 0x01037409
		public static void ResetStaticDefaultValue()
		{
			InteractBoxQueryManager instance = InteractBoxQueryManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InteractBoxQueryManager._instance = null;
		}

		// Token: 0x06039C20 RID: 236576 RVA: 0x01039222 File Offset: 0x01037422
		static InteractBoxQueryManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InteractBoxQueryManager.CreateStaticDefaultValue), new Action(InteractBoxQueryManager.ResetStaticDefaultValue));
		}

		// Token: 0x0401E829 RID: 124969
		private int NextId = 1;

		// Token: 0x0401E82A RID: 124970
		private readonly Dictionary<int, SolidBox> Boxes = new Dictionary<int, SolidBox>();

		// Token: 0x0401E82B RID: 124971
		private readonly Vector TempVector1 = Vector.Create();

		// Token: 0x0401E82C RID: 124972
		private readonly Vector TempVector2 = Vector.Create();

		// Token: 0x0401E82D RID: 124973
		private readonly Vector TempVector3 = Vector.Create();

		// Token: 0x0401E82E RID: 124974
		[Nullable(2)]
		private static InteractBoxQueryManager _instance;
	}
}
