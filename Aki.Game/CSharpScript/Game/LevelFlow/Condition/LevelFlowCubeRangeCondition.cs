using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.LevelFlow.Condition
{
	// Token: 0x020060F6 RID: 24822
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowCubeRangeCondition : LevelFlowConditionBase
	{
		// Token: 0x0603B842 RID: 243778 RVA: 0x010DE5BC File Offset: 0x010DC7BC
		public LevelFlowCubeRangeCondition Init(Vector center, Vector extent, Rotator rotation)
		{
			if (Global.BaseCharacter == null)
			{
				Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "Invalid BaseCharacter", default(ReadOnlySpan<ValueTuple<string, object>>));
				return this;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(Global.BaseCharacter.EntityId);
			if (entityById == null || !entityById.Valid)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				string message = "Invalid EntityId";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("targetEntityId", Global.BaseCharacter.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return this;
			}
			this.TargetActorComponent = entityById.Entity.CheckGetComponent<BaseActorComponent>();
			if (this.TargetActorComponent == null)
			{
				return this;
			}
			this.Center = center;
			this.Extent = extent;
			this.Rotation = rotation;
			return this;
		}

		// Token: 0x0603B843 RID: 243779 RVA: 0x010DE67C File Offset: 0x010DC87C
		protected override void OnTick(float delta)
		{
			if (this.TargetActorComponent == null || !this.TargetActorComponent.Valid)
			{
				Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "TargetActorComponent is invalid", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			Vector actorLocationProxy = this.TargetActorComponent.ActorLocationProxy;
			if (this.PrePosition.Equals(Vector.ZeroVectorProxy, 9.999999747378752E-05))
			{
				this.WorldPositionToLocal(actorLocationProxy, this.PrePosition);
				if (this.CheckInside(this.PrePosition))
				{
					this.PrePosition.DeepCopy(Vector.ZeroVectorProxy);
					base.FinishExecute(true);
				}
			}
			else
			{
				this.WorldPositionToLocal(actorLocationProxy, this.TempVector);
				if (this.CheckSegmentInCube(this.PrePosition, this.TempVector))
				{
					this.PrePosition.DeepCopy(Vector.ZeroVectorProxy);
					base.FinishExecute(true);
				}
				else
				{
					this.PrePosition.DeepCopy(this.TempVector);
				}
			}
			if (LevelFlowModel.Instance.IsDebug)
			{
				UKismetSystemLibrary.D_DrawDebugBox(GlobalData.World, this.Center.ToUeVector(false), this.Extent.ToUeVector(false), ColorUtils.LinearRed, this.Rotation.ToUeRotator(), 1f, 10f);
			}
		}

		// Token: 0x0603B844 RID: 243780 RVA: 0x010DE7B4 File Offset: 0x010DC9B4
		private bool CheckInside(Vector position)
		{
			return Math.Abs(position.X) <= this.Extent.X && Math.Abs(position.Y) <= this.Extent.Y && Math.Abs(position.Z) <= this.Extent.Z;
		}

		// Token: 0x0603B845 RID: 243781 RVA: 0x010DE810 File Offset: 0x010DCA10
		private void WorldPositionToLocal(Vector worldPos, Vector localPos)
		{
			Vector inV = worldPos.Subtraction(this.Center, localPos);
			this.Rotation.Quaternion(this.TempQuat);
			this.TempQuat.Inverse(this.TempQuat);
			this.TempQuat.RotateVector(inV, localPos);
		}

		// Token: 0x0603B846 RID: 243782 RVA: 0x010DE85C File Offset: 0x010DCA5C
		private bool CheckSegmentInCube(Vector segmentStart, Vector segmentEnd)
		{
			segmentEnd.Subtraction(segmentStart, this.TempVector1);
			LevelFlowCubeRangeCondition.<>c__DisplayClass12_0 CS$<>8__locals1;
			CS$<>8__locals1.min = 0.0;
			CS$<>8__locals1.max = 1.0;
			return LevelFlowCubeRangeCondition.<CheckSegmentInCube>g__checkAxisInCube|12_0(segmentStart.X, this.TempVector1.X, -this.Extent.X, this.Extent.X, ref CS$<>8__locals1) && LevelFlowCubeRangeCondition.<CheckSegmentInCube>g__checkAxisInCube|12_0(segmentStart.Y, this.TempVector1.Y, -this.Extent.Y, this.Extent.Y, ref CS$<>8__locals1) && LevelFlowCubeRangeCondition.<CheckSegmentInCube>g__checkAxisInCube|12_0(segmentStart.Z, this.TempVector1.Z, -this.Extent.Z, this.Extent.Z, ref CS$<>8__locals1);
		}

		// Token: 0x0603B848 RID: 243784 RVA: 0x010DE9D4 File Offset: 0x010DCBD4
		[CompilerGenerated]
		internal static bool <CheckSegmentInCube>g__checkAxisInCube|12_0(double original, double delta, double minValue, double maxValue, ref LevelFlowCubeRangeCondition.<>c__DisplayClass12_0 A_4)
		{
			if (Math.Abs(delta) < 9.999999747378752E-05)
			{
				if (original < minValue || original > maxValue)
				{
					return false;
				}
			}
			else
			{
				double num = (minValue - original) / delta;
				double num2 = (maxValue - original) / delta;
				if (num > num2)
				{
					double num3 = num2;
					num2 = num;
					num = num3;
				}
				A_4.min = Math.Max(num, A_4.min);
				A_4.max = Math.Min(num2, A_4.max);
				if (A_4.min > A_4.max)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0401F63B RID: 128571
		private Vector Center = Vector.ZeroVectorProxy;

		// Token: 0x0401F63C RID: 128572
		private Vector Extent = Vector.ZeroVectorProxy;

		// Token: 0x0401F63D RID: 128573
		private Rotator Rotation = Rotator.Create();

		// Token: 0x0401F63E RID: 128574
		[Nullable(2)]
		private BaseActorComponent TargetActorComponent;

		// Token: 0x0401F63F RID: 128575
		private readonly Vector PrePosition = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x0401F640 RID: 128576
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0401F641 RID: 128577
		private readonly Vector TempVector1 = Vector.Create();

		// Token: 0x0401F642 RID: 128578
		private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}
}
