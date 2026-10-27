using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A6E RID: 27246
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractBoxQueryManager : Singleton
	{
		// Token: 0x06043BC7 RID: 277447 RVA: 0x01094530 File Offset: 0x01092730
		public List<int> RegisterSnapshot(Vector baseLocation, Quat baseRotation, List<IBoxDesc> boxes)
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

		// Token: 0x06043BC8 RID: 277448 RVA: 0x010945C4 File Offset: 0x010927C4
		public void AddRef(int id)
		{
			SolidBox solidBox;
			if (this.Boxes.TryGetValue(id, out solidBox) && solidBox != null)
			{
				solidBox.RefCount++;
			}
		}

		// Token: 0x06043BC9 RID: 277449 RVA: 0x010945F4 File Offset: 0x010927F4
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

		// Token: 0x06043BCA RID: 277450 RVA: 0x0109463C File Offset: 0x0109283C
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

		// Token: 0x06043BCB RID: 277451 RVA: 0x010946AC File Offset: 0x010928AC
		[NullableContext(2)]
		public IBoxSnapshot GetBoxSnapshot(int id)
		{
			return this.Boxes.GetValueOrDefault(id);
		}

		// Token: 0x06043BCC RID: 277452 RVA: 0x010946BA File Offset: 0x010928BA
		public void Clear()
		{
			this.Boxes.Clear();
			this.NextId = 1;
		}

		// Token: 0x06043BCD RID: 277453 RVA: 0x010946D0 File Offset: 0x010928D0
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

		// Token: 0x06043BCE RID: 277454 RVA: 0x010948C4 File Offset: 0x01092AC4
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

		// Token: 0x1700992F RID: 39215
		// (get) Token: 0x06043BCF RID: 277455 RVA: 0x010949B8 File Offset: 0x01092BB8
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

		// Token: 0x06043BD0 RID: 277456 RVA: 0x010949DB File Offset: 0x01092BDB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043BD1 RID: 277457 RVA: 0x010949DD File Offset: 0x01092BDD
		public static void ResetStaticDefaultValue()
		{
			InteractBoxQueryManager instance = InteractBoxQueryManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InteractBoxQueryManager._instance = null;
		}

		// Token: 0x06043BD2 RID: 277458 RVA: 0x010949F6 File Offset: 0x01092BF6
		static InteractBoxQueryManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InteractBoxQueryManager.CreateStaticDefaultValue), new Action(InteractBoxQueryManager.ResetStaticDefaultValue));
		}

		// Token: 0x04023637 RID: 144951
		private int NextId = 1;

		// Token: 0x04023638 RID: 144952
		private readonly Dictionary<int, SolidBox> Boxes = new Dictionary<int, SolidBox>();

		// Token: 0x04023639 RID: 144953
		private readonly Vector TempVector1 = Vector.Create();

		// Token: 0x0402363A RID: 144954
		private readonly Vector TempVector2 = Vector.Create();

		// Token: 0x0402363B RID: 144955
		private readonly Vector TempVector3 = Vector.Create();

		// Token: 0x0402363C RID: 144956
		[Nullable(2)]
		private static InteractBoxQueryManager _instance;
	}
}
