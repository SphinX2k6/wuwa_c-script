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
	// Token: 0x02002F5B RID: 12123
	[NullableContext(1)]
	[Nullable(0)]
	public class WeaponEnvInteractionAudioController : ControllerBase
	{
		// Token: 0x0601CB70 RID: 117616 RVA: 0x008C3974 File Offset: 0x008C1B74
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

		// Token: 0x0601CB71 RID: 117617 RVA: 0x008C3A64 File Offset: 0x008C1C64
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

		// Token: 0x0601CB72 RID: 117618 RVA: 0x008C3AC4 File Offset: 0x008C1CC4
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

		// Token: 0x0601CB73 RID: 117619 RVA: 0x008C3AE0 File Offset: 0x008C1CE0
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

		// Token: 0x0601CB74 RID: 117620 RVA: 0x008C3C56 File Offset: 0x008C1E56
		private void ClearComponentCache()
		{
			if (this.ComponentCache.Count > 0)
			{
				this.ComponentCache.Clear();
			}
		}

		// Token: 0x0601CB75 RID: 117621 RVA: 0x008C3C74 File Offset: 0x008C1E74
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

		// Token: 0x0601CB76 RID: 117622 RVA: 0x008C405C File Offset: 0x008C225C
		public bool IsEnabled()
		{
			return this.Enabled;
		}

		// Token: 0x0601CB77 RID: 117623 RVA: 0x008C4064 File Offset: 0x008C2264
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

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x0601CB78 RID: 117624 RVA: 0x008C4089 File Offset: 0x008C2289
		private static bool IsWindows
		{
			get
			{
				return Info.Instance.PlatformType == ESourcePlatformType.Windows;
			}
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x0601CB79 RID: 117625 RVA: 0x008C4098 File Offset: 0x008C2298
		public static WeaponEnvInteractionAudioController Instance
		{
			get
			{
				return WeaponEnvInteractionAudioController._Instance;
			}
		}

		// Token: 0x0601CB7A RID: 117626 RVA: 0x008C409F File Offset: 0x008C229F
		public static WeaponEnvInteractionAudioController GetOrCreateInstance()
		{
			if (WeaponEnvInteractionAudioController._Instance == null)
			{
				WeaponEnvInteractionAudioController.CreateInstance();
			}
			return WeaponEnvInteractionAudioController._Instance;
		}

		// Token: 0x0601CB7B RID: 117627 RVA: 0x008C40B3 File Offset: 0x008C22B3
		public static bool CreateInstance()
		{
			if (WeaponEnvInteractionAudioController._Instance != null)
			{
				return true;
			}
			WeaponEnvInteractionAudioController._Instance = new WeaponEnvInteractionAudioController();
			return true;
		}

		// Token: 0x0601CB7C RID: 117628 RVA: 0x008C40C9 File Offset: 0x008C22C9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0601CB7D RID: 117629 RVA: 0x008C40CB File Offset: 0x008C22CB
		public static void ResetStaticDefaultValue()
		{
			WeaponEnvInteractionAudioController._Instance = null;
		}

		// Token: 0x0601CB7E RID: 117630 RVA: 0x008C40D3 File Offset: 0x008C22D3
		static WeaponEnvInteractionAudioController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WeaponEnvInteractionAudioController.CreateStaticDefaultValue), new Action(WeaponEnvInteractionAudioController.ResetStaticDefaultValue));
		}

		// Token: 0x0400F211 RID: 61969
		private const float DEFAULT_PLAY_AUDIO_CD = 0.3f;

		// Token: 0x0400F212 RID: 61970
		private const float PLAY_AUDIO_THRESHOLD = 0.9f;

		// Token: 0x0400F213 RID: 61971
		private bool Enabled;

		// Token: 0x0400F214 RID: 61972
		private UKuroInteractionEffectSystem InteractionEffectSystem;

		// Token: 0x0400F215 RID: 61973
		private double LastPlayAudioTime;

		// Token: 0x0400F216 RID: 61974
		private float PlayAudioCd;

		// Token: 0x0400F217 RID: 61975
		private float PlayAudioThreshold;

		// Token: 0x0400F218 RID: 61976
		private readonly Dictionary<int, UKuroEnviInteractionComponent> ComponentCache = new Dictionary<int, UKuroEnviInteractionComponent>();

		// Token: 0x0400F219 RID: 61977
		[Nullable(2)]
		private static WeaponEnvInteractionAudioController _Instance;
	}
}
