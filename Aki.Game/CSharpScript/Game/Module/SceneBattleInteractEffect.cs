using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using AkiClient.Game.Aki.UI.Manager;
using CSharpScript.Game.Render;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Module
{
	// Token: 0x020046F3 RID: 18163
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneBattleInteractEffect
	{
		// Token: 0x0602F7FE RID: 194558 RVA: 0x00B02A4C File Offset: 0x00B00C4C
		public void Init(BP_SceneBattleInteract_C dataAsset, float radius = 0f, float halfHeight = 0f)
		{
			this.DataAsset = dataAsset;
			this.Radius = ((this.DataAsset.CollisionRadius > 0f) ? this.DataAsset.CollisionRadius : radius);
			this.HalfHeight = ((this.DataAsset.CollisionHalfHeight > 0f) ? this.DataAsset.CollisionHalfHeight : halfHeight);
			this.ZeroOffset = this.DataAsset.CollisionOffset.IsZero();
			this.TickInterval = this.DataAsset.Interval;
			this.WeaponEventEnable = this.DataAsset.SendWeaponEvent;
			this.InitTraceInfo();
		}

		// Token: 0x0602F7FF RID: 194559 RVA: 0x00B02AED File Offset: 0x00B00CED
		public void SetDispatchWeaponEventEnable(bool enable)
		{
			BP_SceneBattleInteract_C dataAsset = this.DataAsset;
			if (dataAsset != null && dataAsset.SendWeaponEvent)
			{
				return;
			}
			this.WeaponEventEnable = enable;
		}

		// Token: 0x0602F800 RID: 194560 RVA: 0x00B02B0B File Offset: 0x00B00D0B
		public void BindEntityId(int entityId)
		{
			this.EntityId = entityId;
		}

		// Token: 0x0602F801 RID: 194561 RVA: 0x00B02B14 File Offset: 0x00B00D14
		public void SetUpdateLocationFunc(Action<Vector, FVectorDouble?> updateLocationFunc)
		{
			this.LocationUpdateType = ESceneBattleInteractLocation.Default;
			this.UpdateLocationFunc = updateLocationFunc;
		}

		// Token: 0x0602F802 RID: 194562 RVA: 0x00B02B24 File Offset: 0x00B00D24
		public void SetUpdateLocationActor(AActor actor)
		{
			this.LocationUpdateType = ESceneBattleInteractLocation.Actor;
			this.Actor = actor;
		}

		// Token: 0x0602F803 RID: 194563 RVA: 0x00B02B34 File Offset: 0x00B00D34
		public void SetUpdateLocationSocket(UMeshComponent meshComp, FName socketName)
		{
			this.LocationUpdateType = ESceneBattleInteractLocation.Socket;
			this.MeshComp = meshComp;
			this.SocketName = socketName;
		}

		// Token: 0x0602F804 RID: 194564 RVA: 0x00B02B4B File Offset: 0x00B00D4B
		public void SetDownVector(Vector downVector)
		{
			this.DownVector.FromUeVector(downVector);
		}

		// Token: 0x0602F805 RID: 194565 RVA: 0x00B02B59 File Offset: 0x00B00D59
		public void SetIsCommonWeapon(bool isCommonWeapon)
		{
			this.IsCommonWeapon = isCommonWeapon;
		}

		// Token: 0x0602F806 RID: 194566 RVA: 0x00B02B64 File Offset: 0x00B00D64
		private void InitTraceInfo()
		{
			this.ShapeType = (SceneBattleInteractEffect.EShapeType)this.DataAsset.ShapeType;
			this.NeedTrace = true;
			this.TraceNeedLastLocation = true;
			switch (this.ShapeType)
			{
			case SceneBattleInteractEffect.EShapeType.Sphere:
				this.TraceElement = SceneBattleInteractPool.GetTraceSphereElement(KuroTraceTypeQuery.Water);
				((UTraceSphereElement)this.TraceElement).Radius = this.Radius;
				break;
			case SceneBattleInteractEffect.EShapeType.Capsule:
				this.TraceElement = SceneBattleInteractPool.GetTraceCapsuleElement(KuroTraceTypeQuery.Water);
				((UTraceCapsuleElement)this.TraceElement).Radius = this.Radius;
				((UTraceCapsuleElement)this.TraceElement).HalfHeight = this.HalfHeight;
				break;
			case SceneBattleInteractEffect.EShapeType.LineDown:
				this.TraceElement = SceneBattleInteractPool.GetTraceLineElement(KuroTraceTypeQuery.Water);
				this.TraceNeedLastLocation = false;
				break;
			default:
				this.NeedTrace = false;
				this.TraceNeedLastLocation = false;
				break;
			}
			if (this.NeedTrace)
			{
				this.TraceDelegate = DelegateUtils.ToManualReleaseDelegate<FAsyncTraceDelegate>(new Action<bool, UTraceBaseElement, double, double>(this.TraceHitResultHandle));
				this.SetDebug(SceneBattleInteractModel.Instance.Debug);
			}
		}

		// Token: 0x0602F807 RID: 194567 RVA: 0x00B02C70 File Offset: 0x00B00E70
		public void OnTick(float delta)
		{
			if (this.IsFinish || !this.Enable)
			{
				return;
			}
			if (this.IsCommonWeapon && SceneBattleInteractModel.Instance.IgnoreCommonWeapon)
			{
				return;
			}
			if (this.EntityId > 0)
			{
				int entityId = this.EntityId;
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				int? num = (baseCharacter != null) ? new int?(baseCharacter.GetEntityIdNoBlueprint()) : null;
				if (!(entityId == num.GetValueOrDefault() & num != null))
				{
					return;
				}
			}
			if (this.EnableLimitTime > 0f)
			{
				this.EnableLimitTime -= delta;
				if (this.EnableLimitTime <= 0f)
				{
					this.Enable = false;
					return;
				}
			}
			this.GetLocation(this.CurLocation);
			if (this.NextTickTime == -1f)
			{
				this.LastLocation.FromUeVector(this.CurLocation);
				this.NextTickTime = 0f;
				if (this.TraceNeedLastLocation)
				{
					return;
				}
			}
			this.NextTickTime -= delta;
			if (this.NextTickTime > 0f)
			{
				return;
			}
			this.NextTickTime = 0f;
			if (this.WeaponEventEnable)
			{
				BP_EventManager_C bpEventManager = GlobalData.BpEventManager;
				if (bpEventManager != null)
				{
					bpEventManager.武器交互场景时.Broadcast(this.CurLocation.ToUeVector(false), this.DataAsset, this.Id);
				}
			}
			if (!this.NeedTrace)
			{
				if (this.LastLocation.Equals(this.CurLocation, 9.999999747378752E-05))
				{
					return;
				}
				BP_EventManager_C bpEventManager2 = GlobalData.BpEventManager;
				if (bpEventManager2 != null)
				{
					bpEventManager2.子弹撞到水面时.Broadcast(Vector.ZeroVectorDouble, this.DataAsset, this.CurLocation.ToUeVector(false), this.Id);
				}
				this.DrawDebugPoint(this.CurLocation, ColorUtils.LinearRed);
				this.NextTickTime = (float)this.TickInterval;
				this.LastLocation.FromUeVector(this.CurLocation);
				return;
			}
			else
			{
				if (this.TraceDelegate == null || this.TraceElement == null)
				{
					return;
				}
				switch (this.ShapeType)
				{
				case SceneBattleInteractEffect.EShapeType.Sphere:
					TraceElementCommon.Instance.SetStartLocation(this.TraceElement, this.LastLocation);
					TraceElementCommon.Instance.SetEndLocation(this.TraceElement, this.CurLocation);
					TraceElementCommon.Instance.AsyncSphereTrace((UTraceSphereElement)this.TraceElement, "BattleInteractWaterTrace", this.TraceDelegate);
					break;
				case SceneBattleInteractEffect.EShapeType.Capsule:
					TraceElementCommon.Instance.SetStartLocation(this.TraceElement, this.LastLocation);
					TraceElementCommon.Instance.SetEndLocation(this.TraceElement, this.CurLocation);
					TraceElementCommon.Instance.AsyncCapsuleTrace((UTraceCapsuleElement)this.TraceElement, "BattleInteractWaterTrace", this.TraceDelegate);
					break;
				case SceneBattleInteractEffect.EShapeType.LineDown:
					this.CurLocation.Z += (double)this.HalfHeight;
					this.TempVector.X = this.CurLocation.X + this.DownVector.X * (double)this.Radius;
					this.TempVector.Y = this.CurLocation.Y + this.DownVector.Y * (double)this.Radius;
					this.TempVector.Z = this.CurLocation.Z + this.DownVector.Z * (double)this.Radius;
					TraceElementCommon.Instance.SetStartLocation(this.TraceElement, this.CurLocation);
					TraceElementCommon.Instance.SetEndLocation(this.TraceElement, this.TempVector);
					TraceElementCommon.Instance.AsyncLineTrace((UTraceLineElement)this.TraceElement, "BattleInteractWaterTrace", this.TraceDelegate);
					break;
				}
				this.LastLocation.FromUeVector(this.CurLocation);
				return;
			}
		}

		// Token: 0x0602F808 RID: 194568 RVA: 0x00B03004 File Offset: 0x00B01204
		private void TraceHitResultHandle(bool result, UTraceBaseElement element, double frame, double index)
		{
			if (this.DataAsset == null)
			{
				return;
			}
			if (frame < this.TraceFrame)
			{
				return;
			}
			if (frame == this.TraceFrame && index < this.TraceIndex)
			{
				return;
			}
			if (this.NextTickTime != 0f || this.IsFinish)
			{
				return;
			}
			if (!result)
			{
				return;
			}
			UKuroHitResult hitResult = element.HitResult;
			bool flag = false;
			Vector tempVector = this.TempVector;
			if (hitResult != null && hitResult.bBlockingHit)
			{
				int hitCount = hitResult.GetHitCount();
				TArray<int> itemArray = hitResult.ItemArray;
				for (int i = 0; i < hitCount; i++)
				{
					TWeakObjectPtr<UPrimitiveComponent> weak = hitResult.Components.Get(i);
					int instanceIndex = itemArray.Get(i);
					FName collisionProfileName = UKuroCollisionLibrary.GetCollisionProfileName(weak, instanceIndex);
					if (RenderConfig.WaterCollisionProfileName == collisionProfileName)
					{
						tempVector.X = (double)hitResult.ImpactPointX_Array.Get(i);
						tempVector.Y = (double)hitResult.ImpactPointY_Array.Get(i);
						tempVector.Z = (double)hitResult.ImpactPointZ_Array.Get(i);
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				this.TraceFrame = frame;
				this.TraceIndex = index;
				BP_EventManager_C bpEventManager = GlobalData.BpEventManager;
				if (bpEventManager != null)
				{
					bpEventManager.子弹撞到水面时.Broadcast(tempVector.ToUeVector(false), this.DataAsset, this.LastLocation.ToUeVector(false), this.Id);
				}
				if (this.TickInterval <= 0)
				{
					this.IsFinish = true;
					return;
				}
				this.NextTickTime = (float)this.TickInterval;
			}
		}

		// Token: 0x0602F809 RID: 194569 RVA: 0x00B0316C File Offset: 0x00B0136C
		private void GetLocation(Vector @out)
		{
			switch (this.LocationUpdateType)
			{
			case ESceneBattleInteractLocation.Default:
				if (this.ZeroOffset)
				{
					Action<Vector, FVectorDouble?> updateLocationFunc = this.UpdateLocationFunc;
					if (updateLocationFunc == null)
					{
						return;
					}
					updateLocationFunc(@out, null);
					return;
				}
				else
				{
					Action<Vector, FVectorDouble?> updateLocationFunc2 = this.UpdateLocationFunc;
					if (updateLocationFunc2 == null)
					{
						return;
					}
					updateLocationFunc2(@out, new FVectorDouble?(this.DataAsset.CollisionOffset));
					return;
				}
				break;
			case ESceneBattleInteractLocation.Actor:
				if (this.Actor != null)
				{
					FVectorDouble fvectorDouble;
					if (this.ZeroOffset)
					{
						fvectorDouble = this.Actor.D_K2_GetActorLocation();
						@out.FromUeVector(fvectorDouble);
						return;
					}
					FTransformDouble ftransformDouble = this.Actor.D_GetTransform();
					fvectorDouble = this.DataAsset.CollisionOffset;
					FVectorDouble fvectorDouble2 = ftransformDouble.TransformPosition(fvectorDouble);
					@out.FromUeVector(fvectorDouble2);
					return;
				}
				break;
			case ESceneBattleInteractLocation.Socket:
				if (this.MeshComp != null)
				{
					FVectorDouble fvectorDouble;
					if (this.ZeroOffset)
					{
						fvectorDouble = this.MeshComp.D_GetSocketLocation(this.SocketName);
						@out.FromUeVector(fvectorDouble);
						return;
					}
					FTransformDouble ftransformDouble2 = this.MeshComp.D_GetSocketTransform(this.SocketName, ERelativeTransformSpace.RTS_World);
					fvectorDouble = this.DataAsset.CollisionOffset;
					FVectorDouble fvectorDouble2 = ftransformDouble2.TransformPosition(fvectorDouble);
					@out.FromUeVector(fvectorDouble2);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0602F80A RID: 194570 RVA: 0x00B0328A File Offset: 0x00B0148A
		public void SetEnable(bool enable, float limitTime = 0f)
		{
			this.EnableLimitTime = limitTime;
			if (this.Enable == enable)
			{
				return;
			}
			this.Enable = enable;
			this.NextTickTime = -1f;
		}

		// Token: 0x0602F80B RID: 194571 RVA: 0x00B032AF File Offset: 0x00B014AF
		public void SetIgnoreCommonWeapon(bool ignoreCommonWeapon)
		{
			if (this.IgnoreCommonWeapon == ignoreCommonWeapon)
			{
				return;
			}
			this.IgnoreCommonWeapon = ignoreCommonWeapon;
			SceneBattleInteractModel.Instance.RefreshIgnoreCommonWeapon(ignoreCommonWeapon);
		}

		// Token: 0x0602F80C RID: 194572 RVA: 0x00B032CD File Offset: 0x00B014CD
		public bool GetIgnoreCommonWeapon()
		{
			return this.IgnoreCommonWeapon;
		}

		// Token: 0x0602F80D RID: 194573 RVA: 0x00B032D8 File Offset: 0x00B014D8
		public void SetDebug(int debugMode)
		{
			if (this.TraceElement == null)
			{
				return;
			}
			if (debugMode == 0)
			{
				this.TraceElement.SetDrawDebugTrace(EDrawDebugTrace.None);
				return;
			}
			if (debugMode == 1)
			{
				TraceElementCommon.Instance.SetTraceColor(this.TraceElement, ColorUtils.LinearGreen);
				TraceElementCommon.Instance.SetTraceHitColor(this.TraceElement, ColorUtils.LinearRed);
				this.TraceElement.SetDrawDebugTrace(EDrawDebugTrace.ForOneFrame);
				return;
			}
			if (debugMode == 2)
			{
				this.TraceElement.DrawTime = 3f;
				TraceElementCommon.Instance.SetTraceColor(this.TraceElement, ColorUtils.LinearGreen);
				TraceElementCommon.Instance.SetTraceHitColor(this.TraceElement, ColorUtils.LinearRed);
				this.TraceElement.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
			}
		}

		// Token: 0x0602F80E RID: 194574 RVA: 0x00B03383 File Offset: 0x00B01583
		private void DrawDebugPoint(Vector point, FLinearColor color)
		{
			if (SceneBattleInteractModel.Instance.Debug <= 0)
			{
				return;
			}
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.GameInstance, point.ToUeVector(false), 5f, 12, new FLinearColor?(color), 1f, 0f);
		}

		// Token: 0x0602F80F RID: 194575 RVA: 0x00B033BC File Offset: 0x00B015BC
		public void Destroy()
		{
			this.SetIgnoreCommonWeapon(false);
			this.DataAsset = null;
			this.UpdateLocationFunc = null;
			this.Actor = null;
			this.MeshComp = null;
			if (this.TraceDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool, UTraceBaseElement, double, double>(this.TraceHitResultHandle));
				this.TraceDelegate = null;
			}
			if (this.TraceElement != null)
			{
				switch (this.ShapeType)
				{
				case SceneBattleInteractEffect.EShapeType.Sphere:
					SceneBattleInteractPool.RecycleTraceSphereElement((UTraceSphereElement)this.TraceElement);
					break;
				case SceneBattleInteractEffect.EShapeType.Capsule:
					SceneBattleInteractPool.RecycleTraceCapsuleElement((UTraceCapsuleElement)this.TraceElement);
					break;
				case SceneBattleInteractEffect.EShapeType.LineDown:
					SceneBattleInteractPool.RecycleTraceLineElement((UTraceLineElement)this.TraceElement);
					break;
				}
				this.TraceElement = null;
			}
		}

		// Token: 0x04019A84 RID: 105092
		public int Id;

		// Token: 0x04019A85 RID: 105093
		private bool Enable;

		// Token: 0x04019A86 RID: 105094
		private int EntityId;

		// Token: 0x04019A87 RID: 105095
		private float EnableLimitTime;

		// Token: 0x04019A88 RID: 105096
		private float NextTickTime = -1f;

		// Token: 0x04019A89 RID: 105097
		private int TickInterval;

		// Token: 0x04019A8A RID: 105098
		private bool WeaponEventEnable;

		// Token: 0x04019A8B RID: 105099
		[Nullable(2)]
		private BP_SceneBattleInteract_C DataAsset;

		// Token: 0x04019A8C RID: 105100
		private float Radius;

		// Token: 0x04019A8D RID: 105101
		private float HalfHeight;

		// Token: 0x04019A8E RID: 105102
		private ESceneBattleInteractLocation LocationUpdateType;

		// Token: 0x04019A8F RID: 105103
		[Nullable(2)]
		private AActor Actor;

		// Token: 0x04019A90 RID: 105104
		[Nullable(2)]
		private UMeshComponent MeshComp;

		// Token: 0x04019A91 RID: 105105
		private FName SocketName = FNameUtil.EMPTY;

		// Token: 0x04019A92 RID: 105106
		[Nullable(2)]
		private UTraceBaseElement TraceElement;

		// Token: 0x04019A93 RID: 105107
		private SceneBattleInteractEffect.EShapeType ShapeType;

		// Token: 0x04019A94 RID: 105108
		private bool ZeroOffset = true;

		// Token: 0x04019A95 RID: 105109
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04019A96 RID: 105110
		private readonly Vector DownVector = Vector.Create(0.0, 0.0, -1.0);

		// Token: 0x04019A97 RID: 105111
		private bool IsFinish;

		// Token: 0x04019A98 RID: 105112
		private readonly Vector CurLocation = Vector.Create();

		// Token: 0x04019A99 RID: 105113
		private readonly Vector LastLocation = Vector.Create();

		// Token: 0x04019A9A RID: 105114
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<Vector, FVectorDouble?> UpdateLocationFunc;

		// Token: 0x04019A9B RID: 105115
		private bool NeedTrace;

		// Token: 0x04019A9C RID: 105116
		private bool TraceNeedLastLocation;

		// Token: 0x04019A9D RID: 105117
		private double TraceFrame;

		// Token: 0x04019A9E RID: 105118
		private double TraceIndex;

		// Token: 0x04019A9F RID: 105119
		[Nullable(2)]
		private FAsyncTraceDelegate TraceDelegate;

		// Token: 0x04019AA0 RID: 105120
		private bool IgnoreCommonWeapon;

		// Token: 0x04019AA1 RID: 105121
		private bool IsCommonWeapon;

		// Token: 0x04019AA2 RID: 105122
		private const string PROFILE_BATLLE_INTERACT_WATER_TRACE = "BattleInteractWaterTrace";

		// Token: 0x0200A94B RID: 43339
		[NullableContext(0)]
		private enum EShapeType
		{
			// Token: 0x04033893 RID: 211091
			None = -1,
			// Token: 0x04033894 RID: 211092
			Sphere,
			// Token: 0x04033895 RID: 211093
			Capsule,
			// Token: 0x04033896 RID: 211094
			LineDown
		}
	}
}
