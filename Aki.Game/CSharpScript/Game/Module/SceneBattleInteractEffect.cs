using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using AkiClient.Game.Aki.UI.Manager;
using CSharpScript.Game.Render;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Module
{
	// Token: 0x02003623 RID: 13859
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneBattleInteractEffect
	{
		// Token: 0x06023FC4 RID: 147396 RVA: 0x00A3271C File Offset: 0x00A3091C
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

		// Token: 0x06023FC5 RID: 147397 RVA: 0x00A327BD File Offset: 0x00A309BD
		public void SetDispatchWeaponEventEnable(bool enable)
		{
			BP_SceneBattleInteract_C dataAsset = this.DataAsset;
			if (dataAsset != null && dataAsset.SendWeaponEvent)
			{
				return;
			}
			this.WeaponEventEnable = enable;
		}

		// Token: 0x06023FC6 RID: 147398 RVA: 0x00A327DB File Offset: 0x00A309DB
		public void BindEntityId(int entityId)
		{
			this.EntityId = entityId;
		}

		// Token: 0x06023FC7 RID: 147399 RVA: 0x00A327E4 File Offset: 0x00A309E4
		public void SetUpdateLocationFunc(Action<Vector, FVectorDouble?> updateLocationFunc)
		{
			this.LocationUpdateType = ESceneBattleInteractLocation.Default;
			this.UpdateLocationFunc = updateLocationFunc;
		}

		// Token: 0x06023FC8 RID: 147400 RVA: 0x00A327F4 File Offset: 0x00A309F4
		public void SetUpdateLocationActor(AActor actor)
		{
			this.LocationUpdateType = ESceneBattleInteractLocation.Actor;
			this.Actor = actor;
		}

		// Token: 0x06023FC9 RID: 147401 RVA: 0x00A32804 File Offset: 0x00A30A04
		public void SetUpdateLocationSocket(UMeshComponent meshComp, FName socketName)
		{
			this.LocationUpdateType = ESceneBattleInteractLocation.Socket;
			this.MeshComp = meshComp;
			this.SocketName = socketName;
		}

		// Token: 0x06023FCA RID: 147402 RVA: 0x00A3281B File Offset: 0x00A30A1B
		public void SetDownVector(Vector downVector)
		{
			this.DownVector.FromUeVector(downVector);
		}

		// Token: 0x06023FCB RID: 147403 RVA: 0x00A32829 File Offset: 0x00A30A29
		public void SetIsCommonWeapon(bool isCommonWeapon)
		{
			this.IsCommonWeapon = isCommonWeapon;
		}

		// Token: 0x06023FCC RID: 147404 RVA: 0x00A32834 File Offset: 0x00A30A34
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

		// Token: 0x06023FCD RID: 147405 RVA: 0x00A32940 File Offset: 0x00A30B40
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

		// Token: 0x06023FCE RID: 147406 RVA: 0x00A32CD4 File Offset: 0x00A30ED4
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

		// Token: 0x06023FCF RID: 147407 RVA: 0x00A32E3C File Offset: 0x00A3103C
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

		// Token: 0x06023FD0 RID: 147408 RVA: 0x00A32F5A File Offset: 0x00A3115A
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

		// Token: 0x06023FD1 RID: 147409 RVA: 0x00A32F7F File Offset: 0x00A3117F
		public void SetIgnoreCommonWeapon(bool ignoreCommonWeapon)
		{
			if (this.IgnoreCommonWeapon == ignoreCommonWeapon)
			{
				return;
			}
			this.IgnoreCommonWeapon = ignoreCommonWeapon;
			SceneBattleInteractModel.Instance.RefreshIgnoreCommonWeapon(ignoreCommonWeapon);
		}

		// Token: 0x06023FD2 RID: 147410 RVA: 0x00A32F9D File Offset: 0x00A3119D
		public bool GetIgnoreCommonWeapon()
		{
			return this.IgnoreCommonWeapon;
		}

		// Token: 0x06023FD3 RID: 147411 RVA: 0x00A32FA8 File Offset: 0x00A311A8
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

		// Token: 0x06023FD4 RID: 147412 RVA: 0x00A33053 File Offset: 0x00A31253
		private void DrawDebugPoint(Vector point, FLinearColor color)
		{
			if (SceneBattleInteractModel.Instance.Debug <= 0)
			{
				return;
			}
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.GameInstance, point.ToUeVector(false), 5f, 12, new FLinearColor?(color), 1f, 0f);
		}

		// Token: 0x06023FD5 RID: 147413 RVA: 0x00A3308C File Offset: 0x00A3128C
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

		// Token: 0x04014133 RID: 82227
		public int Id;

		// Token: 0x04014134 RID: 82228
		private bool Enable;

		// Token: 0x04014135 RID: 82229
		private int EntityId;

		// Token: 0x04014136 RID: 82230
		private float EnableLimitTime;

		// Token: 0x04014137 RID: 82231
		private float NextTickTime = -1f;

		// Token: 0x04014138 RID: 82232
		private int TickInterval;

		// Token: 0x04014139 RID: 82233
		private bool WeaponEventEnable;

		// Token: 0x0401413A RID: 82234
		[Nullable(2)]
		private BP_SceneBattleInteract_C DataAsset;

		// Token: 0x0401413B RID: 82235
		private float Radius;

		// Token: 0x0401413C RID: 82236
		private float HalfHeight;

		// Token: 0x0401413D RID: 82237
		private ESceneBattleInteractLocation LocationUpdateType;

		// Token: 0x0401413E RID: 82238
		[Nullable(2)]
		private AActor Actor;

		// Token: 0x0401413F RID: 82239
		[Nullable(2)]
		private UMeshComponent MeshComp;

		// Token: 0x04014140 RID: 82240
		private FName SocketName = FNameUtil.EMPTY;

		// Token: 0x04014141 RID: 82241
		[Nullable(2)]
		private UTraceBaseElement TraceElement;

		// Token: 0x04014142 RID: 82242
		private SceneBattleInteractEffect.EShapeType ShapeType;

		// Token: 0x04014143 RID: 82243
		private bool ZeroOffset = true;

		// Token: 0x04014144 RID: 82244
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04014145 RID: 82245
		private readonly Vector DownVector = Vector.Create(0.0, 0.0, -1.0);

		// Token: 0x04014146 RID: 82246
		private bool IsFinish;

		// Token: 0x04014147 RID: 82247
		private readonly Vector CurLocation = Vector.Create();

		// Token: 0x04014148 RID: 82248
		private readonly Vector LastLocation = Vector.Create();

		// Token: 0x04014149 RID: 82249
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<Vector, FVectorDouble?> UpdateLocationFunc;

		// Token: 0x0401414A RID: 82250
		private bool NeedTrace;

		// Token: 0x0401414B RID: 82251
		private bool TraceNeedLastLocation;

		// Token: 0x0401414C RID: 82252
		private double TraceFrame;

		// Token: 0x0401414D RID: 82253
		private double TraceIndex;

		// Token: 0x0401414E RID: 82254
		[Nullable(2)]
		private FAsyncTraceDelegate TraceDelegate;

		// Token: 0x0401414F RID: 82255
		private bool IgnoreCommonWeapon;

		// Token: 0x04014150 RID: 82256
		private bool IsCommonWeapon;

		// Token: 0x04014151 RID: 82257
		private const string PROFILE_BATLLE_INTERACT_WATER_TRACE = "BattleInteractWaterTrace";

		// Token: 0x02009306 RID: 37638
		[NullableContext(0)]
		private enum EShapeType
		{
			// Token: 0x0402E026 RID: 188454
			None = -1,
			// Token: 0x0402E027 RID: 188455
			Sphere,
			// Token: 0x0402E028 RID: 188456
			Capsule,
			// Token: 0x0402E029 RID: 188457
			LineDown
		}
	}
}
