using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.Module.Map;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063EF RID: 25583
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MotorParkourMapModel : ModelBase
	{
		// Token: 0x06040595 RID: 263573 RVA: 0x00F905D4 File Offset: 0x00F8E7D4
		public void InitSplinePoints(int splineId, float scale, Vector2D centerOffset, int startIndex, int endIndex)
		{
			this.Scale = scale;
			this.CenterOffset = centerOffset;
			if (Global.BaseCharacter == null)
			{
				Log.Instance.Error(ELogModule.MotorParkour, ELogAuthor.CXJ, "当前角色实体不存在，样条线组件无法绑定角色实体", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.SplineComponent = GameSplineModel.Instance.LoadAndGetSplineComponent(splineId, Global.BaseCharacter.EntityId, EIdType.EntityId);
			if (this.SplineComponent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorParkour;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "摩托车跑酷spline获取失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SplineId", splineId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.StartDist = this.SplineComponent.GetDistanceAlongSplineAtSplinePoint(0);
			this.StartDist = this.SplineComponent.GetDistanceAlongSplineAtSplinePoint(startIndex);
			float distanceAlongSplineAtSplinePoint = this.SplineComponent.GetDistanceAlongSplineAtSplinePoint(endIndex);
			this.GetSplinePoints(distanceAlongSplineAtSplinePoint, this.SplinePoints, this.StartDist == distanceAlongSplineAtSplinePoint);
			FVector2D fvector2D = this.SplinePoints.Get(this.SplinePoints.Num() - 1);
			this.EndPointOffset.Set((double)fvector2D.X, (double)fvector2D.Y);
			FVectorDouble fvectorDouble = this.SplineComponent.D_GetArriveTangentAtSplinePoint(endIndex, ESplineCoordinateSpace.World);
			this.EndPointRotator.Yaw = -(float)(Math.Atan2(fvectorDouble.Y, fvectorDouble.X) * 57.295780181884766 + 90.0);
		}

		// Token: 0x06040596 RID: 263574 RVA: 0x00F90728 File Offset: 0x00F8E928
		public TArray<FVector2D> GetPathTakenSplinePoints()
		{
			if (this.SplineComponent == null)
			{
				return this.PathTakenSplinePoints;
			}
			Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
			if (playerLocation == null)
			{
				return this.PathTakenSplinePoints;
			}
			USplineComponent splineComponent = this.SplineComponent;
			FVectorDouble fvectorDouble = playerLocation.ToUeVector(false);
			float inKey = splineComponent.D_FindInputKeyClosestToWorldLocation(fvectorDouble);
			float distanceAlongSplineAtSplineInputKey = this.SplineComponent.GetDistanceAlongSplineAtSplineInputKey(inKey);
			this.GetSplinePoints(distanceAlongSplineAtSplineInputKey, this.PathTakenSplinePoints, false);
			return this.PathTakenSplinePoints;
		}

		// Token: 0x06040597 RID: 263575 RVA: 0x00F90790 File Offset: 0x00F8E990
		public void GetSplinePoints(float endDistance, TArray<FVector2D> array, bool forcePassSplineStartPoint = false)
		{
			if (this.SplineComponent == null)
			{
				Log.Instance.Error(ELogModule.MotorParkour, ELogAuthor.CXJ, "样条线组件不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			array.Empty(true);
			float splineLength = this.SplineComponent.GetSplineLength();
			bool flag = endDistance < this.StartDist;
			if (forcePassSplineStartPoint || flag)
			{
				this.AddPoints(this.StartDist, splineLength, array);
				this.AddPoints(0f, endDistance, array);
				return;
			}
			this.AddPoints(this.StartDist, endDistance, array);
		}

		// Token: 0x06040598 RID: 263576 RVA: 0x00F90814 File Offset: 0x00F8EA14
		public void AddPoints(float startDist, float endDist, TArray<FVector2D> array)
		{
			if (this.SplineComponent == null)
			{
				Log.Instance.Error(ELogModule.MotorParkour, ELogAuthor.CXJ, "样条线组件不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			for (float num = startDist; num != endDist; num = Math.Min(num + 1000f, endDist))
			{
				FVectorDouble fvectorDouble = this.SplineComponent.D_GetLocationAtDistanceAlongSpline(num, ESplineCoordinateSpace.World);
				this.TmpVector2D.Set(fvectorDouble.X, fvectorDouble.Y);
				MapUtil.WorldPosition2UiPosition2D(this.TmpVector2D, null).Multiply((double)this.Scale, this.SplinePoint2D).Subtraction(this.CenterOffset, this.SplinePoint2D);
				array.Add(this.SplinePoint2D.ToUeVector2D(false));
			}
		}

		// Token: 0x1700942F RID: 37935
		// (get) Token: 0x06040599 RID: 263577 RVA: 0x00F908C6 File Offset: 0x00F8EAC6
		public static MotorParkourMapModel Instance
		{
			get
			{
				return MotorParkourMapModel._Instance;
			}
		}

		// Token: 0x0604059A RID: 263578 RVA: 0x00F908CD File Offset: 0x00F8EACD
		public static MotorParkourMapModel GetOrCreateInstance()
		{
			if (MotorParkourMapModel._Instance == null)
			{
				MotorParkourMapModel.CreateInstance();
			}
			return MotorParkourMapModel._Instance;
		}

		// Token: 0x0604059B RID: 263579 RVA: 0x00F908E1 File Offset: 0x00F8EAE1
		public static bool CreateInstance()
		{
			if (MotorParkourMapModel._Instance != null)
			{
				return true;
			}
			MotorParkourMapModel._Instance = new MotorParkourMapModel();
			return true;
		}

		// Token: 0x0604059C RID: 263580 RVA: 0x00F908F7 File Offset: 0x00F8EAF7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604059D RID: 263581 RVA: 0x00F908F9 File Offset: 0x00F8EAF9
		public static void ResetStaticDefaultValue()
		{
			MotorParkourMapModel._Instance = null;
		}

		// Token: 0x0604059E RID: 263582 RVA: 0x00F90901 File Offset: 0x00F8EB01
		static MotorParkourMapModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorParkourMapModel.CreateStaticDefaultValue), new Action(MotorParkourMapModel.ResetStaticDefaultValue));
		}

		// Token: 0x04021789 RID: 137097
		[Nullable(2)]
		private USplineComponent SplineComponent;

		// Token: 0x0402178A RID: 137098
		private float Scale = 1f;

		// Token: 0x0402178B RID: 137099
		private Vector2D CenterOffset = Vector2D.Create();

		// Token: 0x0402178C RID: 137100
		private float StartDist;

		// Token: 0x0402178D RID: 137101
		private readonly Vector2D SplinePoint2D = Vector2D.Create();

		// Token: 0x0402178E RID: 137102
		private readonly Vector2D TmpVector2D = Vector2D.Create();

		// Token: 0x0402178F RID: 137103
		public readonly Vector2D EndPointOffset = Vector2D.Create();

		// Token: 0x04021790 RID: 137104
		public FRotator EndPointRotator = new FRotator();

		// Token: 0x04021791 RID: 137105
		public readonly TArray<FVector2D> SplinePoints = new TArray<FVector2D>();

		// Token: 0x04021792 RID: 137106
		public readonly TArray<FVector2D> PathTakenSplinePoints = new TArray<FVector2D>();

		// Token: 0x04021793 RID: 137107
		[Nullable(2)]
		private static MotorParkourMapModel _Instance;
	}
}
