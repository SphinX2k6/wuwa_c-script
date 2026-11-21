using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.Module.Map;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x0200536D RID: 21357
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MotorParkourMapModel : ModelBase
	{
		// Token: 0x06035256 RID: 217686 RVA: 0x00ED75BC File Offset: 0x00ED57BC
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

		// Token: 0x06035257 RID: 217687 RVA: 0x00ED7710 File Offset: 0x00ED5910
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

		// Token: 0x06035258 RID: 217688 RVA: 0x00ED7778 File Offset: 0x00ED5978
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

		// Token: 0x06035259 RID: 217689 RVA: 0x00ED77FC File Offset: 0x00ED59FC
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

		// Token: 0x17006791 RID: 26513
		// (get) Token: 0x0603525A RID: 217690 RVA: 0x00ED78AE File Offset: 0x00ED5AAE
		public static MotorParkourMapModel Instance
		{
			get
			{
				return MotorParkourMapModel._Instance;
			}
		}

		// Token: 0x0603525B RID: 217691 RVA: 0x00ED78B5 File Offset: 0x00ED5AB5
		public static MotorParkourMapModel GetOrCreateInstance()
		{
			if (MotorParkourMapModel._Instance == null)
			{
				MotorParkourMapModel.CreateInstance();
			}
			return MotorParkourMapModel._Instance;
		}

		// Token: 0x0603525C RID: 217692 RVA: 0x00ED78C9 File Offset: 0x00ED5AC9
		public static bool CreateInstance()
		{
			if (MotorParkourMapModel._Instance != null)
			{
				return true;
			}
			MotorParkourMapModel._Instance = new MotorParkourMapModel();
			return true;
		}

		// Token: 0x0603525D RID: 217693 RVA: 0x00ED78DF File Offset: 0x00ED5ADF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603525E RID: 217694 RVA: 0x00ED78E1 File Offset: 0x00ED5AE1
		public static void ResetStaticDefaultValue()
		{
			MotorParkourMapModel._Instance = null;
		}

		// Token: 0x0603525F RID: 217695 RVA: 0x00ED78E9 File Offset: 0x00ED5AE9
		static MotorParkourMapModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorParkourMapModel.CreateStaticDefaultValue), new Action(MotorParkourMapModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401C0B8 RID: 114872
		[Nullable(2)]
		private USplineComponent SplineComponent;

		// Token: 0x0401C0B9 RID: 114873
		private float Scale = 1f;

		// Token: 0x0401C0BA RID: 114874
		private Vector2D CenterOffset = Vector2D.Create();

		// Token: 0x0401C0BB RID: 114875
		private float StartDist;

		// Token: 0x0401C0BC RID: 114876
		private readonly Vector2D SplinePoint2D = Vector2D.Create();

		// Token: 0x0401C0BD RID: 114877
		private readonly Vector2D TmpVector2D = Vector2D.Create();

		// Token: 0x0401C0BE RID: 114878
		public readonly Vector2D EndPointOffset = Vector2D.Create();

		// Token: 0x0401C0BF RID: 114879
		public FRotator EndPointRotator = new FRotator();

		// Token: 0x0401C0C0 RID: 114880
		public readonly TArray<FVector2D> SplinePoints = new TArray<FVector2D>();

		// Token: 0x0401C0C1 RID: 114881
		public readonly TArray<FVector2D> PathTakenSplinePoints = new TArray<FVector2D>();

		// Token: 0x0401C0C2 RID: 114882
		[Nullable(2)]
		private static MotorParkourMapModel _Instance;
	}
}
