using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace Kuro.Game.Module.Audio
{
	// Token: 0x020044CE RID: 17614
	[NullableContext(1)]
	[Nullable(0)]
	public class WeaponEnvInteractionAudioController : ControllerBase
	{
		// Token: 0x0602D632 RID: 185906 RVA: 0x00A3DD14 File Offset: 0x00A3BF14
		protected override bool OnInit()
		{
			if (!this.Enabled)
			{
				return true;
			}
			if (!WeaponEnvInteractionAudioController.IsWindows)
			{
				return true;
			}
			this.InteractionEffectSystem = (UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroInteractionEffectSystem.StaticClass()) as UKuroInteractionEffectSystem);
			if (this.InteractionEffectSystem == null)
			{
				Log.Instance.Warn(ELogModule.Audio, ELogAuthor.CH, "武器交互场景时: 获取 InteractionEffectSystem 失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			GlobalConfigFromCsv? config = ConfigGlobalConfigFromCsvByName.GetConfig("GrassCutAudioCd", true);
			float num;
			if (config != null && float.TryParse(config.Value.Value, out num))
			{
				this.PlayAudioCd = num / 1000f;
			}
			else
			{
				this.PlayAudioCd = 0.3f;
			}
			GlobalConfigFromCsv? config2 = ConfigGlobalConfigFromCsvByName.GetConfig("GrassCutAudioThreshold", true);
			float playAudioThreshold;
			if (config2 != null && float.TryParse(config2.Value.Value, out playAudioThreshold))
			{
				this.PlayAudioThreshold = playAudioThreshold;
			}
			else
			{
				this.PlayAudioThreshold = 0.9f;
			}
			return true;
		}

		// Token: 0x0602D633 RID: 185907 RVA: 0x00A3DE04 File Offset: 0x00A3C004
		protected override bool OnLeaveLevel()
		{
			if (!WeaponEnvInteractionAudioController.IsWindows)
			{
				return true;
			}
			this.InteractionEffectSystem = (UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroInteractionEffectSystem.StaticClass()) as UKuroInteractionEffectSystem);
			if (this.InteractionEffectSystem == null)
			{
				Log.Instance.Warn(ELogModule.Audio, ELogAuthor.CH, "武器交互场景时: 获取 InteractionEffectSystem 失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.ClearComponentCache();
			return true;
		}

		// Token: 0x0602D634 RID: 185908 RVA: 0x00A3DE64 File Offset: 0x00A3C064
		protected override bool OnClear()
		{
			if (!WeaponEnvInteractionAudioController.IsWindows)
			{
				return true;
			}
			this.InteractionEffectSystem = null;
			this.ClearComponentCache();
			return true;
		}

		// Token: 0x0602D635 RID: 185909 RVA: 0x00A3DE80 File Offset: 0x00A3C080
		private UKuroEnviInteractionComponent GetOrCacheEnviInteractionComponent()
		{
			WeaponEnvInteractionAudioController.<>c__DisplayClass11_0 CS$<>8__locals1 = new WeaponEnvInteractionAudioController.<>c__DisplayClass11_0();
			CS$<>8__locals1.<>4__this = this;
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			if (worldEntity == null)
			{
				Log.Instance.Warn(ELogModule.Audio, ELogAuthor.CH, "获取交互组件失败: 当前实体不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			CS$<>8__locals1.entityId = worldEntity.Id;
			UKuroEnviInteractionComponent ukuroEnviInteractionComponent;
			if (this.ComponentCache.TryGetValue(CS$<>8__locals1.entityId, out ukuroEnviInteractionComponent))
			{
				if (ukuroEnviInteractionComponent != null && ukuroEnviInteractionComponent.IsValid())
				{
					return ukuroEnviInteractionComponent;
				}
				this.ComponentCache.Remove(CS$<>8__locals1.entityId);
			}
			BaseActorComponent component = worldEntity.GetComponent<BaseActorComponent>();
			if (((component != null) ? component.Owner : null) == null || !component.Owner.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.CH;
				string message = "获取交互组件失败: 实体不包含 ActorComponent";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", CS$<>8__locals1.entityId.ToString());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			UKuroEnviInteractionComponent ukuroEnviInteractionComponent2 = component.Owner.GetComponentByClass(UKuroEnviInteractionComponent.StaticClass()) as UKuroEnviInteractionComponent;
			if (ukuroEnviInteractionComponent2 == null || !ukuroEnviInteractionComponent2.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Audio;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "获取交互组件失败: 实体不包含 KuroEnviInteractionComponent";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", CS$<>8__locals1.entityId.ToString());
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			this.ComponentCache[CS$<>8__locals1.entityId] = ukuroEnviInteractionComponent2;
			EventSystem.Instance.AddWithTarget(worldEntity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(CS$<>8__locals1.<GetOrCacheEnviInteractionComponent>g__EntityRemoveHandler|0));
			return ukuroEnviInteractionComponent2;
		}

		// Token: 0x0602D636 RID: 185910 RVA: 0x00A3DFF6 File Offset: 0x00A3C1F6
		private void ClearComponentCache()
		{
			if (this.ComponentCache.Count > 0)
			{
				this.ComponentCache.Clear();
			}
		}

		// Token: 0x0602D637 RID: 185911 RVA: 0x00A3E014 File Offset: 0x00A3C214
		public unsafe void OnWeaponInteraction(FVector originPoint, float timeInterval)
		{
			if (Time.Instance.PlayerTime - this.LastPlayAudioTime < (double)this.PlayAudioCd)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.CH;
				string message = "武器交互场景时: 播放音频时间间隔不足";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("timeInterval", (Time.Instance.PlayerTime - this.LastPlayAudioTime).ToString("F2"));
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.InteractionEffectSystem == null || !this.InteractionEffectSystem.IsValid())
			{
				Log.Instance.Warn(ELogModule.Audio, ELogAuthor.CH, "武器交互场景时: InteractionEffectSystem 无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.InteractionEffectSystem = (UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroInteractionEffectSystem.StaticClass()) as UKuroInteractionEffectSystem);
			}
			if (this.InteractionEffectSystem.GrassCutReadBack <= this.PlayAudioThreshold)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Audio;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "武器交互场景时: 不满足播放音频条件";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("RtValue", this.InteractionEffectSystem.GrassCutReadBack.ToString("F2"));
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			UKuroEnviInteractionComponent orCacheEnviInteractionComponent = this.GetOrCacheEnviInteractionComponent();
			string text = null;
			foreach (InteractionItemInfo interactionItemInfo in InteractionItemInfos.Items)
			{
				if (interactionItemInfo.Foliages != null && interactionItemInfo.Foliages.Count > 0)
				{
					TArray<string> tarray = new TArray<string>();
					foreach (string value in interactionItemInfo.Foliages)
					{
						tarray.Add(value);
					}
					TArray<int> tarray2 = this.InteractionEffectSystem.SearchInteractionFoliageArray(tarray);
					float num = 0f;
					for (int i = 0; i < tarray2.Count; i++)
					{
						num += (float)tarray2[i];
					}
					if (num > 0f)
					{
						text = interactionItemInfo.AudioKey;
						break;
					}
				}
				if (interactionItemInfo.StaticMeshes != null && interactionItemInfo.StaticMeshes.Count > 0)
				{
					TWeakObjectPtr<AActor>? tweakObjectPtr = (orCacheEnviInteractionComponent != null) ? new TWeakObjectPtr<AActor>?(orCacheEnviInteractionComponent.GetEnviInteractionData().HitBushActor) : null;
					UStaticMeshComponent ustaticMeshComponent = ((tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault().Get().GetComponentByClass(UStaticMeshComponent.StaticClass()) : null) as UStaticMeshComponent;
					if (ustaticMeshComponent != null && ustaticMeshComponent.IsValid())
					{
						string pathName = UKismetSystemLibrary.GetPathName(ustaticMeshComponent.StaticMesh);
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.Audio;
						ELogAuthor author3 = ELogAuthor.CH;
						string message3 = "武器交互场景时";
						ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("pathName", pathName);
						instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
						if (interactionItemInfo.StaticMeshes.Contains(pathName))
						{
							text = interactionItemInfo.AudioKey;
							break;
						}
					}
				}
			}
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Audio;
			ELogAuthor author4 = ELogAuthor.CH;
			string message4 = "武器交互场景时";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("GrassCutReadBack", this.InteractionEffectSystem.GrassCutReadBack.ToString("F2"));
			instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			if (!string.IsNullOrEmpty(text))
			{
				this.LastPlayAudioTime = Time.Instance.PlayerTime;
				AudioSystem instance5 = AudioSystem.Instance;
				string @event = text;
				FVectorDouble fvectorDouble = originPoint;
				instance5.PostEvent(@event, new FTransformDouble?(new FTransformDouble(ref fvectorDouble)), null);
				Log instance6 = Log.Instance;
				ELogModule module5 = ELogModule.Audio;
				ELogAuthor author5 = ELogAuthor.CH;
				string message5 = "武器交互场景时: 播放割草音频";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("originPoint", originPoint.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("audioKey", text);
				instance6.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x0602D638 RID: 185912 RVA: 0x00A3E3FC File Offset: 0x00A3C5FC
		public bool IsEnabled()
		{
			return this.Enabled;
		}

		// Token: 0x0602D639 RID: 185913 RVA: 0x00A3E404 File Offset: 0x00A3C604
		public void SetEnabled(bool enabled)
		{
			if (this.Enabled == enabled)
			{
				return;
			}
			this.Enabled = enabled;
			if (enabled)
			{
				this.OnInit();
				return;
			}
			this.OnClear();
		}

		// Token: 0x170073A1 RID: 29601
		// (get) Token: 0x0602D63A RID: 185914 RVA: 0x00A3E429 File Offset: 0x00A3C629
		private static bool IsWindows
		{
			get
			{
				return Info.Instance.PlatformType == ESourcePlatformType.Windows;
			}
		}

		// Token: 0x170073A2 RID: 29602
		// (get) Token: 0x0602D63B RID: 185915 RVA: 0x00A3E438 File Offset: 0x00A3C638
		public static WeaponEnvInteractionAudioController Instance
		{
			get
			{
				return WeaponEnvInteractionAudioController._Instance;
			}
		}

		// Token: 0x0602D63C RID: 185916 RVA: 0x00A3E43F File Offset: 0x00A3C63F
		public static WeaponEnvInteractionAudioController GetOrCreateInstance()
		{
			if (WeaponEnvInteractionAudioController._Instance == null)
			{
				WeaponEnvInteractionAudioController.CreateInstance();
			}
			return WeaponEnvInteractionAudioController._Instance;
		}

		// Token: 0x0602D63D RID: 185917 RVA: 0x00A3E453 File Offset: 0x00A3C653
		public static bool CreateInstance()
		{
			if (WeaponEnvInteractionAudioController._Instance != null)
			{
				return true;
			}
			WeaponEnvInteractionAudioController._Instance = new WeaponEnvInteractionAudioController();
			return true;
		}

		// Token: 0x0602D63E RID: 185918 RVA: 0x00A3E469 File Offset: 0x00A3C669
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D63F RID: 185919 RVA: 0x00A3E46B File Offset: 0x00A3C66B
		public static void ResetStaticDefaultValue()
		{
			WeaponEnvInteractionAudioController._Instance = null;
		}

		// Token: 0x0602D640 RID: 185920 RVA: 0x00A3E473 File Offset: 0x00A3C673
		static WeaponEnvInteractionAudioController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WeaponEnvInteractionAudioController.CreateStaticDefaultValue), new Action(WeaponEnvInteractionAudioController.ResetStaticDefaultValue));
		}

		// Token: 0x04018469 RID: 99433
		private const float DEFAULT_PLAY_AUDIO_CD = 0.3f;

		// Token: 0x0401846A RID: 99434
		private const float PLAY_AUDIO_THRESHOLD = 0.9f;

		// Token: 0x0401846B RID: 99435
		private bool Enabled;

		// Token: 0x0401846C RID: 99436
		private UKuroInteractionEffectSystem InteractionEffectSystem;

		// Token: 0x0401846D RID: 99437
		private double LastPlayAudioTime;

		// Token: 0x0401846E RID: 99438
		private float PlayAudioCd;

		// Token: 0x0401846F RID: 99439
		private float PlayAudioThreshold;

		// Token: 0x04018470 RID: 99440
		private readonly Dictionary<int, UKuroEnviInteractionComponent> ComponentCache = new Dictionary<int, UKuroEnviInteractionComponent>();

		// Token: 0x04018471 RID: 99441
		[Nullable(2)]
		private static WeaponEnvInteractionAudioController _Instance;
	}
}
