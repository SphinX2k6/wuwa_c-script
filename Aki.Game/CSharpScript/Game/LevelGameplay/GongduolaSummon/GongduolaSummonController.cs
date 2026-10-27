using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.SummonGongduola;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.GongduolaSummon
{
	// Token: 0x02006E1F RID: 28191
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class GongduolaSummonController : ControllerBase
	{
		// Token: 0x06044BAA RID: 281514 RVA: 0x010F6C30 File Offset: 0x010F4E30
		[NullableContext(1)]
		public void PlaySummonAnim(Entity entity)
		{
			GongduolaSummonModel.Instance.SummonedActorComp = entity.GetComponent<BaseActorComponent>();
			TTimerAction <>9__1;
			ResourceSystem.Instance.LoadAsync<UAnimMontage>(GongduolaSummonModel.Instance.SummonAmPath, delegate([Nullable(2)] UAnimMontage am, string _)
			{
				if (am == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Item;
					ELogAuthor author = ELogAuthor.CH;
					string message = "[GongduolaSummonController.PlaySummonAnim] 加载召唤动画失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", GongduolaSummonModel.Instance.SummonAmPath);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.StartLookAtGongduola();
				this.CacheSummonAm = am;
				this.CacheVehicleAnimationComponent = entity.GetComponent<VehicleAnimationComponent>();
				if (this.CacheVehicleAnimationComponent == null)
				{
					Log.Instance.Error(ELogModule.Item, ELogAuthor.CH, "[GongduolaSummonController.PlaySummonAnim] 未找到VehicleAnimationComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.CacheVehicleMoveComponent = entity.GetComponent<VehicleMoveComponent>();
				if (this.CacheVehicleMoveComponent == null)
				{
					Log.Instance.Error(ELogModule.Item, ELogAuthor.CH, "[GongduolaSummonController.PlaySummonAnim] 未找到VehicleMoveComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.CacheUeSkeletalTickManagerComp = entity.GetComponent<UeSkeletalTickManageComponent>();
				if (this.CacheUeSkeletalTickManagerComp == null)
				{
					Log.Instance.Error(ELogModule.Item, ELogAuthor.CH, "[GongduolaSummonController.PlaySummonAnim] 未找到UeSkeletalTickManageComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.CacheVehicleTagComp = entity.GetComponent<BaseTagComponent>();
				if (this.CacheVehicleTagComp == null)
				{
					Log.Instance.Error(ELogModule.Item, ELogAuthor.CH, "[GongduolaSummonController.PlaySummonAnim] 未找到BaseTagComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.CacheVehicleAnimationComponent.StartForceDisableAnimOptimization(EForceDisableAnimOptimization.SpecialAction, false);
				this.CacheUeSkeletalTickManagerComp.StartForceDisableAnimDelay(EForceDisableAnimDelayReason.GongduolaSummon);
				this.CacheVehicleAnimationComponent.Play(this.CacheSummonAm, new Action<UAnimMontage, bool>(this.OnSummonAnimEnd));
				Log.Instance.Info(ELogModule.SummonGongduola, ELogAuthor.CH, "[CHTest] PlaySummonAnim", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (!this.CacheVehicleTagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.贡多拉.逻辑.禁止交互"]))
				{
					this.CacheVehicleTagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.贡多拉.逻辑.禁止交互"]));
				}
				TimerSystemInstance instance2 = TimerSystem.Instance;
				TTimerAction action;
				if ((action = <>9__1) == null)
				{
					action = (<>9__1 = delegate(float _)
					{
						CreatureController.Instance.SetEntityEnable(entity, true, "GongduolaSummonController.PlaySummonAnim", true);
						this.CacheVehicleMoveComponent.IsSummoningPerform = true;
						VehicleMoveComponent cacheVehicleMoveComponent = this.CacheVehicleMoveComponent;
						if (cacheVehicleMoveComponent == null)
						{
							return;
						}
						cacheVehicleMoveComponent.EnableUeMovementTick("GongduolaSummonController.PlaySummonAnim");
					});
				}
				instance2.Delay(action, 100f, null, null, true, 1f);
			}, 100, "js_undefined");
		}

		// Token: 0x06044BAB RID: 281515 RVA: 0x010F6C90 File Offset: 0x010F4E90
		[NullableContext(1)]
		public void PlayCancelSummonAnim(Entity entity, Vector newLoc, Rotator newRot, Vector newGravityDir)
		{
			ResourceSystem.Instance.LoadAsync<UAnimMontage>(GongduolaSummonModel.Instance.CancelSummonAmPath, delegate([Nullable(2)] UAnimMontage am, string _)
			{
				if (am == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Item;
					ELogAuthor author = ELogAuthor.CH;
					string message = "[GongduolaSummonController.PlaySummonAnim] 加载召唤动画失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", GongduolaSummonModel.Instance.SummonAmPath);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.CacheCancelSummonAm = am;
				GongduolaSummonModel.Instance.SummonLocation = newLoc;
				GongduolaSummonModel.Instance.SummonRotation = newRot;
				GongduolaSummonModel.Instance.SummonGravityDir = newGravityDir;
				this.CacheVehicleAnimationComponent = entity.GetComponent<VehicleAnimationComponent>();
				if (this.CacheVehicleAnimationComponent == null)
				{
					Log.Instance.Error(ELogModule.Item, ELogAuthor.CH, "[GongduolaSummonController.PlaySummonAnim] 未找到VehicleAnimationComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.CacheVehicleMoveComponent = entity.GetComponent<VehicleMoveComponent>();
				if (this.CacheVehicleMoveComponent == null)
				{
					Log.Instance.Error(ELogModule.Item, ELogAuthor.CH, "[GongduolaSummonController.PlaySummonAnim] 未找到VehicleMoveComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.CacheActorComponent = entity.GetComponent<BaseActorComponent>();
				if (this.CacheActorComponent == null)
				{
					Log.Instance.Error(ELogModule.Item, ELogAuthor.CH, "[GongduolaSummonController.PlaySummonAnim] 未找到BaseActorComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.CacheUeSkeletalTickManagerComp = entity.GetComponent<UeSkeletalTickManageComponent>();
				if (this.CacheUeSkeletalTickManagerComp == null)
				{
					Log.Instance.Error(ELogModule.Item, ELogAuthor.CH, "[GongduolaSummonController.PlaySummonAnim] 未找到UeSkeletalTickManageComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.CacheVehicleTagComp = entity.GetComponent<BaseTagComponent>();
				if (this.CacheVehicleTagComp == null)
				{
					Log.Instance.Error(ELogModule.Item, ELogAuthor.CH, "[GongduolaSummonController.PlaySummonAnim] 未找到BaseTagComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.CacheVehicleMoveComponent.IsSummoningPerform = true;
				this.CacheUeSkeletalTickManagerComp.StartForceDisableAnimDelay(EForceDisableAnimDelayReason.GongduolaSummon);
				this.CacheVehicleAnimationComponent.StartForceDisableAnimOptimization(EForceDisableAnimOptimization.SpecialAction, false);
				VehicleMoveComponent cacheVehicleMoveComponent = this.CacheVehicleMoveComponent;
				if (cacheVehicleMoveComponent != null)
				{
					cacheVehicleMoveComponent.EnableUeMovementTick("GongduolaSummonController.PlaySummonAnim");
				}
				this.CacheVehicleAnimationComponent.Play(this.CacheCancelSummonAm, new Action<UAnimMontage, bool>(this.OnCancelSummonAnimEnd));
				if (!this.CacheVehicleTagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.贡多拉.逻辑.禁止交互"]))
				{
					this.CacheVehicleTagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.贡多拉.逻辑.禁止交互"]));
				}
				Log.Instance.Info(ELogModule.SummonGongduola, ELogAuthor.CH, "[CHTest] PlayCancelSummonAnim", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, 100, "js_undefined");
		}

		// Token: 0x06044BAC RID: 281516 RVA: 0x010F6CF0 File Offset: 0x010F4EF0
		[NullableContext(1)]
		public void StopCancelSummonAnim(Entity entity)
		{
			VehicleAnimationComponent component = entity.GetComponent<VehicleAnimationComponent>();
			if (component == null)
			{
				Log.Instance.Error(ELogModule.Item, ELogAuthor.CH, "[GongduolaSummonController.PlaySummonAnim] 未找到VehicleAnimationComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			component.StopMontage(0f);
			component.StopModelBuffer();
		}

		// Token: 0x06044BAD RID: 281517 RVA: 0x010F6D38 File Offset: 0x010F4F38
		private unsafe void OnSummonAnimEnd(UAnimMontage montage, bool interrupted)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[ChTest]OnSummonAnimEnd";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Montage", montage);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("interrupted", interrupted);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (montage != this.CacheSummonAm)
			{
				return;
			}
			this.CacheVehicleAnimationComponent.RemoveOnMontageEnded(new Action<UAnimMontage, bool>(this.OnSummonAnimEnd));
			BaseTagComponent cacheVehicleTagComp = this.CacheVehicleTagComp;
			if (cacheVehicleTagComp != null && cacheVehicleTagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.贡多拉.逻辑.禁止交互"]))
			{
				BaseTagComponent cacheVehicleTagComp2 = this.CacheVehicleTagComp;
				if (cacheVehicleTagComp2 != null)
				{
					cacheVehicleTagComp2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.贡多拉.逻辑.禁止交互"]));
				}
			}
			this.OnAnimEnd();
		}

		// Token: 0x06044BAE RID: 281518 RVA: 0x010F6E0C File Offset: 0x010F500C
		private unsafe void OnCancelSummonAnimEnd(UAnimMontage montage, bool interrupted)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[ChTest]OnCancelSummonAnimEnd";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Montage", montage);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("interrupted", interrupted);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (montage != this.CacheCancelSummonAm)
			{
				return;
			}
			this.CacheVehicleAnimationComponent.RemoveOnMontageEnded(new Action<UAnimMontage, bool>(this.OnCancelSummonAnimEnd));
			this.OnAnimEnd();
		}

		// Token: 0x06044BAF RID: 281519 RVA: 0x010F6E97 File Offset: 0x010F5097
		private void OnAnimEnd()
		{
			this.CacheVehicleMoveComponent.IsSummoningPerform = false;
			UeSkeletalTickManageComponent cacheUeSkeletalTickManagerComp = this.CacheUeSkeletalTickManagerComp;
			if (cacheUeSkeletalTickManagerComp != null)
			{
				cacheUeSkeletalTickManagerComp.CancelForceDisableAnimDelay(EForceDisableAnimDelayReason.GongduolaSummon);
			}
			VehicleAnimationComponent cacheVehicleAnimationComponent = this.CacheVehicleAnimationComponent;
			if (cacheVehicleAnimationComponent == null)
			{
				return;
			}
			cacheVehicleAnimationComponent.CancelForceDisableAnimOptimization(EForceDisableAnimOptimization.SpecialAction);
		}

		// Token: 0x06044BB0 RID: 281520 RVA: 0x010F6EC8 File Offset: 0x010F50C8
		private void StartLookAtGongduola()
		{
			BP_SummonGongduolaConfig_C config = GongduolaSummonModel.Instance.SummonConfig;
			if (config == null)
			{
				Log.Instance.Error(ELogModule.SummonGongduola, ELogAuthor.CH, "[GongduolaSummonController.StartLookAtGongduola] 未找到召唤配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			BaseActorComponent summonedActorComp = GongduolaSummonModel.Instance.SummonedActorComp;
			if (summonedActorComp == null || !summonedActorComp.Valid)
			{
				Log.Instance.Error(ELogModule.SummonGongduola, ELogAuthor.CH, "[GongduolaSummonController.StartLookAtGongduola] 未找到GongduolaActorComp", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (config.BanInput)
			{
				GeneralLogicTreeModel.Instance.DisableInput = true;
				EventSystem.Instance.Emit<string>(EEventName.ForceReleaseInput, GongduolaSummonModel.Instance.BanInputReason);
				InputDistributeController.Instance.RefreshInputTag();
				Log.Instance.Info(ELogModule.SummonGongduola, ELogAuthor.CH, "[StartLookAtGongduola] StartLookAtGongduola BanInput", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			Vector vector = Vector.Create(summonedActorComp.ActorLocationProxy);
			vector.Set(vector.X, vector.Y, vector.Z + (double)config.OffsetZ);
			CameraController.Instance.MainModel.FightCamera.LogicComponent.ApplyCameraGuide(vector, config.FadeInTime, config.StayTime, config.FadeOutTime, config.LockCamera, null, null, false, false, 0f, false, null, false);
			float num = config.FadeInTime + config.StayTime + config.FadeOutTime;
			TimerSystem.Instance.Delay(delegate(float _)
			{
				if (config.BanInput)
				{
					GeneralLogicTreeModel.Instance.DisableInput = false;
					InputDistributeController.Instance.RefreshInputTag();
					Log.Instance.Info(ELogModule.SummonGongduola, ELogAuthor.CH, "[StartLookAtGongduola] StartLookAtGongduola StopBanInput", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}, (float)((int)(num * 1000f)), null, null, true, 1f);
		}

		// Token: 0x170099FD RID: 39421
		// (get) Token: 0x06044BB1 RID: 281521 RVA: 0x010F707F File Offset: 0x010F527F
		[Nullable(1)]
		public static GongduolaSummonController Instance
		{
			[NullableContext(1)]
			get
			{
				return GongduolaSummonController._Instance;
			}
		}

		// Token: 0x06044BB2 RID: 281522 RVA: 0x010F7086 File Offset: 0x010F5286
		[NullableContext(1)]
		public static GongduolaSummonController GetOrCreateInstance()
		{
			if (GongduolaSummonController._Instance == null)
			{
				GongduolaSummonController.CreateInstance();
			}
			return GongduolaSummonController._Instance;
		}

		// Token: 0x06044BB3 RID: 281523 RVA: 0x010F709A File Offset: 0x010F529A
		public static bool CreateInstance()
		{
			if (GongduolaSummonController._Instance != null)
			{
				return true;
			}
			GongduolaSummonController._Instance = new GongduolaSummonController();
			return true;
		}

		// Token: 0x06044BB4 RID: 281524 RVA: 0x010F70B0 File Offset: 0x010F52B0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044BB5 RID: 281525 RVA: 0x010F70B2 File Offset: 0x010F52B2
		public static void ResetStaticDefaultValue()
		{
			GongduolaSummonController._Instance = null;
		}

		// Token: 0x06044BB6 RID: 281526 RVA: 0x010F70BA File Offset: 0x010F52BA
		static GongduolaSummonController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GongduolaSummonController.CreateStaticDefaultValue), new Action(GongduolaSummonController.ResetStaticDefaultValue));
		}

		// Token: 0x04023C04 RID: 146436
		private UAnimMontage CacheSummonAm;

		// Token: 0x04023C05 RID: 146437
		private UAnimMontage CacheCancelSummonAm;

		// Token: 0x04023C06 RID: 146438
		private BaseActorComponent CacheActorComponent;

		// Token: 0x04023C07 RID: 146439
		private VehicleAnimationComponent CacheVehicleAnimationComponent;

		// Token: 0x04023C08 RID: 146440
		private VehicleMoveComponent CacheVehicleMoveComponent;

		// Token: 0x04023C09 RID: 146441
		private UeSkeletalTickManageComponent CacheUeSkeletalTickManagerComp;

		// Token: 0x04023C0A RID: 146442
		private BaseTagComponent CacheVehicleTagComp;

		// Token: 0x04023C0B RID: 146443
		private static GongduolaSummonController _Instance;
	}
}
