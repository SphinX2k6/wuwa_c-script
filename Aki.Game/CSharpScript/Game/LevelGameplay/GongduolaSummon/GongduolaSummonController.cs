using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.SummonGongduola;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.GongduolaSummon
{
	// Token: 0x02005F9F RID: 24479
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class GongduolaSummonController : ControllerBase
	{
		// Token: 0x0603AD13 RID: 240915 RVA: 0x010A116C File Offset: 0x0109F36C
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

		// Token: 0x0603AD14 RID: 240916 RVA: 0x010A11CC File Offset: 0x0109F3CC
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

		// Token: 0x0603AD15 RID: 240917 RVA: 0x010A122C File Offset: 0x0109F42C
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

		// Token: 0x0603AD16 RID: 240918 RVA: 0x010A1274 File Offset: 0x0109F474
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

		// Token: 0x0603AD17 RID: 240919 RVA: 0x010A1348 File Offset: 0x0109F548
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

		// Token: 0x0603AD18 RID: 240920 RVA: 0x010A13D3 File Offset: 0x0109F5D3
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

		// Token: 0x0603AD19 RID: 240921 RVA: 0x010A1404 File Offset: 0x0109F604
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

		// Token: 0x17006F00 RID: 28416
		// (get) Token: 0x0603AD1A RID: 240922 RVA: 0x010A15BB File Offset: 0x0109F7BB
		[Nullable(1)]
		public static GongduolaSummonController Instance
		{
			[NullableContext(1)]
			get
			{
				return GongduolaSummonController._Instance;
			}
		}

		// Token: 0x0603AD1B RID: 240923 RVA: 0x010A15C2 File Offset: 0x0109F7C2
		[NullableContext(1)]
		public static GongduolaSummonController GetOrCreateInstance()
		{
			if (GongduolaSummonController._Instance == null)
			{
				GongduolaSummonController.CreateInstance();
			}
			return GongduolaSummonController._Instance;
		}

		// Token: 0x0603AD1C RID: 240924 RVA: 0x010A15D6 File Offset: 0x0109F7D6
		public static bool CreateInstance()
		{
			if (GongduolaSummonController._Instance != null)
			{
				return true;
			}
			GongduolaSummonController._Instance = new GongduolaSummonController();
			return true;
		}

		// Token: 0x0603AD1D RID: 240925 RVA: 0x010A15EC File Offset: 0x0109F7EC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AD1E RID: 240926 RVA: 0x010A15EE File Offset: 0x0109F7EE
		public static void ResetStaticDefaultValue()
		{
			GongduolaSummonController._Instance = null;
		}

		// Token: 0x0603AD1F RID: 240927 RVA: 0x010A15F6 File Offset: 0x0109F7F6
		static GongduolaSummonController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GongduolaSummonController.CreateStaticDefaultValue), new Action(GongduolaSummonController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EEA7 RID: 126631
		private UAnimMontage CacheSummonAm;

		// Token: 0x0401EEA8 RID: 126632
		private UAnimMontage CacheCancelSummonAm;

		// Token: 0x0401EEA9 RID: 126633
		private BaseActorComponent CacheActorComponent;

		// Token: 0x0401EEAA RID: 126634
		private VehicleAnimationComponent CacheVehicleAnimationComponent;

		// Token: 0x0401EEAB RID: 126635
		private VehicleMoveComponent CacheVehicleMoveComponent;

		// Token: 0x0401EEAC RID: 126636
		private UeSkeletalTickManageComponent CacheUeSkeletalTickManagerComp;

		// Token: 0x0401EEAD RID: 126637
		private BaseTagComponent CacheVehicleTagComp;

		// Token: 0x0401EEAE RID: 126638
		private static GongduolaSummonController _Instance;
	}
}
