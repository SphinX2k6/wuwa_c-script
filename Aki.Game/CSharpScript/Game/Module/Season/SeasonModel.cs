using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Core;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02004C83 RID: 19587
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SeasonModel : ModelBase
	{
		// Token: 0x17007CE7 RID: 31975
		// (get) Token: 0x060329E2 RID: 207330 RVA: 0x00BCD0C7 File Offset: 0x00BCB2C7
		public bool IsMaterialReady
		{
			get
			{
				UMaterialParameterCollection materialAssetInternal = this.MaterialAssetInternal;
				return materialAssetInternal != null && materialAssetInternal.IsValid();
			}
		}

		// Token: 0x17007CE8 RID: 31976
		// (get) Token: 0x060329E3 RID: 207331 RVA: 0x00BCD0DA File Offset: 0x00BCB2DA
		[Nullable(2)]
		public UMaterialParameterCollection MaterialAsset
		{
			[NullableContext(2)]
			get
			{
				return this.MaterialAssetInternal;
			}
		}

		// Token: 0x17007CE9 RID: 31977
		// (get) Token: 0x060329E4 RID: 207332 RVA: 0x00BCD0E2 File Offset: 0x00BCB2E2
		// (set) Token: 0x060329E5 RID: 207333 RVA: 0x00BCD0EA File Offset: 0x00BCB2EA
		public FName? TimelineParamName { get; private set; }

		// Token: 0x17007CEA RID: 31978
		// (get) Token: 0x060329E6 RID: 207334 RVA: 0x00BCD0F3 File Offset: 0x00BCB2F3
		// (set) Token: 0x060329E7 RID: 207335 RVA: 0x00BCD0FB File Offset: 0x00BCB2FB
		public double CurrentValue { get; set; }

		// Token: 0x17007CEB RID: 31979
		// (get) Token: 0x060329E8 RID: 207336 RVA: 0x00BCD104 File Offset: 0x00BCB304
		// (set) Token: 0x060329E9 RID: 207337 RVA: 0x00BCD10C File Offset: 0x00BCB30C
		public double? LastWrittenValue { get; set; }

		// Token: 0x17007CEC RID: 31980
		// (get) Token: 0x060329EA RID: 207338 RVA: 0x00BCD115 File Offset: 0x00BCB315
		// (set) Token: 0x060329EB RID: 207339 RVA: 0x00BCD11D File Offset: 0x00BCB31D
		public ESeason? LastReportedSeason { get; set; }

		// Token: 0x17007CED RID: 31981
		// (get) Token: 0x060329EC RID: 207340 RVA: 0x00BCD126 File Offset: 0x00BCB326
		// (set) Token: 0x060329ED RID: 207341 RVA: 0x00BCD12E File Offset: 0x00BCB32E
		public ESeasonDriverPhase DriverPhase { get; set; }

		// Token: 0x17007CEE RID: 31982
		// (get) Token: 0x060329EE RID: 207342 RVA: 0x00BCD137 File Offset: 0x00BCB337
		// (set) Token: 0x060329EF RID: 207343 RVA: 0x00BCD140 File Offset: 0x00BCB340
		[Nullable(2)]
		public ILoopSeasonChange LoopConfig
		{
			[NullableContext(2)]
			get
			{
				return this.LoopConfigInternal;
			}
			[NullableContext(2)]
			set
			{
				this.LoopConfigInternal = value;
				if (value != null)
				{
					this.LoopConfigByIndex = new ISeasonLoopConfig[]
					{
						value.SpringConfig,
						value.SummerConfig,
						value.AutumnConfig,
						value.WinterConfig
					};
					return;
				}
				this.LoopConfigByIndex = null;
			}
		}

		// Token: 0x17007CEF RID: 31983
		// (get) Token: 0x060329F0 RID: 207344 RVA: 0x00BCD191 File Offset: 0x00BCB391
		// (set) Token: 0x060329F1 RID: 207345 RVA: 0x00BCD199 File Offset: 0x00BCB399
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<ISeasonLoopConfig> LoopConfigByIndex { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] private set; }

		// Token: 0x17007CF0 RID: 31984
		// (get) Token: 0x060329F2 RID: 207346 RVA: 0x00BCD1A2 File Offset: 0x00BCB3A2
		// (set) Token: 0x060329F3 RID: 207347 RVA: 0x00BCD1AA File Offset: 0x00BCB3AA
		[Nullable(2)]
		public ISeasonLoopState LoopState { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007CF1 RID: 31985
		// (get) Token: 0x060329F4 RID: 207348 RVA: 0x00BCD1B3 File Offset: 0x00BCB3B3
		public List<ISeasonSwitchJob> SwitchQueue { get; } = new List<ISeasonSwitchJob>();

		// Token: 0x17007CF2 RID: 31986
		// (get) Token: 0x060329F5 RID: 207349 RVA: 0x00BCD1BB File Offset: 0x00BCB3BB
		public HashSet<int> ActiveAreaIds { get; } = new HashSet<int>();

		// Token: 0x060329F6 RID: 207350 RVA: 0x00BCD1C4 File Offset: 0x00BCB3C4
		public void RegisterVolume(TsTriggerVolume volume)
		{
			int seasonAreaId = volume.SeasonAreaId;
			if (seasonAreaId == 0)
			{
				return;
			}
			TsTriggerVolume tsTriggerVolume;
			if (this.RegisteredVolumesByAreaIdInternal.TryGetValue(seasonAreaId, out tsTriggerVolume) && tsTriggerVolume != volume)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Season;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "同一 SeasonAreaId 配到多个 volume";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("areaId", seasonAreaId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.RegisteredVolumesByAreaIdInternal[seasonAreaId] = volume;
		}

		// Token: 0x060329F7 RID: 207351 RVA: 0x00BCD22C File Offset: 0x00BCB42C
		public void UnregisterVolume(TsTriggerVolume volume)
		{
			int seasonAreaId = volume.SeasonAreaId;
			if (seasonAreaId == 0)
			{
				return;
			}
			TsTriggerVolume tsTriggerVolume;
			if (this.RegisteredVolumesByAreaIdInternal.TryGetValue(seasonAreaId, out tsTriggerVolume) && tsTriggerVolume == volume)
			{
				this.RegisteredVolumesByAreaIdInternal.Remove(seasonAreaId);
			}
		}

		// Token: 0x060329F8 RID: 207352 RVA: 0x00BCD265 File Offset: 0x00BCB465
		public bool IsAreaActive(int areaId)
		{
			return this.ActiveAreaIds.Contains(areaId);
		}

		// Token: 0x060329F9 RID: 207353 RVA: 0x00BCD273 File Offset: 0x00BCB473
		public void ActivateArea(int areaId)
		{
			if (areaId == 0)
			{
				return;
			}
			this.ActiveAreaIds.Add(areaId);
		}

		// Token: 0x060329FA RID: 207354 RVA: 0x00BCD286 File Offset: 0x00BCB486
		public void DeactivateArea(int areaId)
		{
			if (areaId == 0)
			{
				return;
			}
			this.ActiveAreaIds.Remove(areaId);
		}

		// Token: 0x060329FB RID: 207355 RVA: 0x00BCD299 File Offset: 0x00BCB499
		public void MarkPlayerInside(int areaId)
		{
			if (areaId == 0)
			{
				return;
			}
			this.PlayerInsideAreaIdsInternal.Add(areaId);
		}

		// Token: 0x060329FC RID: 207356 RVA: 0x00BCD2AC File Offset: 0x00BCB4AC
		public void MarkPlayerOutside(int areaId)
		{
			if (areaId == 0)
			{
				return;
			}
			this.PlayerInsideAreaIdsInternal.Remove(areaId);
		}

		// Token: 0x060329FD RID: 207357 RVA: 0x00BCD2BF File Offset: 0x00BCB4BF
		public bool IsPlayerInside(int areaId)
		{
			return this.PlayerInsideAreaIdsInternal.Contains(areaId);
		}

		// Token: 0x060329FE RID: 207358 RVA: 0x00BCD2D0 File Offset: 0x00BCB4D0
		public void PushSwitchJob(ISwitchSeason job, double targetValue, double forwardDistance, [Nullable(2)] TSeasonSwitchCallback onComplete = null)
		{
			this.SwitchQueue.Add(new SeasonSwitchJob
			{
				TargetSeason = job.Season,
				TargetValue = targetValue,
				Speed = (double)job.TransitionSpeed,
				RemainDistance = forwardDistance,
				OnComplete = onComplete
			});
		}

		// Token: 0x060329FF RID: 207359 RVA: 0x00BCD31C File Offset: 0x00BCB51C
		[NullableContext(2)]
		public ISeasonSwitchJob PeekSwitchHead()
		{
			if (this.SwitchQueue.Count <= 0)
			{
				return null;
			}
			return this.SwitchQueue[0];
		}

		// Token: 0x06032A00 RID: 207360 RVA: 0x00BCD33A File Offset: 0x00BCB53A
		[NullableContext(2)]
		public ISeasonSwitchJob PopSwitchHead()
		{
			if (this.SwitchQueue.Count > 0)
			{
				ISeasonSwitchJob result = this.SwitchQueue[0];
				this.SwitchQueue.RemoveAt(0);
				return result;
			}
			return null;
		}

		// Token: 0x06032A01 RID: 207361 RVA: 0x00BCD364 File Offset: 0x00BCB564
		public void ClearSwitchQueue()
		{
			this.FlushPendingCallbacks(false);
			this.SwitchQueue.Clear();
		}

		// Token: 0x06032A02 RID: 207362 RVA: 0x00BCD378 File Offset: 0x00BCB578
		public void ResetRuntime()
		{
			this.FlushPendingCallbacks(false);
			this.DriverPhase = ESeasonDriverPhase.Idle;
			this.LoopConfigInternal = null;
			this.LoopConfigByIndex = null;
			this.LoopState = null;
			this.SwitchQueue.Clear();
			this.RegisteredVolumesByAreaIdInternal.Clear();
			this.ActiveAreaIds.Clear();
			this.PlayerInsideAreaIdsInternal.Clear();
		}

		// Token: 0x06032A03 RID: 207363 RVA: 0x00BCD3D4 File Offset: 0x00BCB5D4
		private void FlushPendingCallbacks(bool success)
		{
			foreach (ISeasonSwitchJob seasonSwitchJob in this.SwitchQueue)
			{
				TSeasonSwitchCallback onComplete = seasonSwitchJob.OnComplete;
				if (onComplete != null)
				{
					seasonSwitchJob.OnComplete = null;
					try
					{
						onComplete(success);
					}
					catch (Exception ex)
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.Season;
						ELogAuthor author = ELogAuthor.YSQ;
						string message = "切换回调抛异常";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}
			}
		}

		// Token: 0x06032A04 RID: 207364 RVA: 0x00BCD47C File Offset: 0x00BCB67C
		protected override bool OnInit()
		{
			ResourceSystem.Instance.LoadAsync<UMaterialParameterCollection>("/Game/Aki/Render/Shaders/Scene/Interaction/MPC_SceneInteraction.MPC_SceneInteraction", delegate([Nullable(2)] UMaterialParameterCollection result, string _)
			{
				if (result == null || !result.IsValid())
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Season;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "MPC加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", "/Game/Aki/Render/Shaders/Scene/Interaction/MPC_SceneInteraction.MPC_SceneInteraction");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.MaterialAssetInternal = result;
				this.TimelineParamName = FNameUtil.GetDynamicFName("SeasonTransitionTimeLine");
				BP_MainGameInstance_C gameInstance = GlobalData.GameInstance;
				UWorld uworld = (gameInstance != null) ? gameInstance.GetWorld() : null;
				if (uworld == null)
				{
					return;
				}
				if (this.TimelineParamName != null)
				{
					this.CurrentValue = (double)UKismetMaterialLibrary.GetScalarParameterValue(uworld, this.MaterialAssetInternal, this.TimelineParamName.Value);
				}
				this.LastWrittenValue = new double?(this.CurrentValue);
			}, 100, "js_undefined");
			return true;
		}

		// Token: 0x06032A05 RID: 207365 RVA: 0x00BCD4A2 File Offset: 0x00BCB6A2
		protected override bool OnLeaveLevel()
		{
			this.ResetRuntime();
			return true;
		}

		// Token: 0x06032A06 RID: 207366 RVA: 0x00BCD4AC File Offset: 0x00BCB6AC
		protected override bool OnClear()
		{
			this.ResetRuntime();
			this.MaterialAssetInternal = null;
			this.TimelineParamName = null;
			return true;
		}

		// Token: 0x17007CF3 RID: 31987
		// (get) Token: 0x06032A07 RID: 207367 RVA: 0x00BCD4D6 File Offset: 0x00BCB6D6
		public static SeasonModel Instance
		{
			get
			{
				return SeasonModel._Instance;
			}
		}

		// Token: 0x06032A08 RID: 207368 RVA: 0x00BCD4DD File Offset: 0x00BCB6DD
		public static SeasonModel GetOrCreateInstance()
		{
			if (SeasonModel._Instance == null)
			{
				SeasonModel.CreateInstance();
			}
			return SeasonModel._Instance;
		}

		// Token: 0x06032A09 RID: 207369 RVA: 0x00BCD4F1 File Offset: 0x00BCB6F1
		public static bool CreateInstance()
		{
			if (SeasonModel._Instance != null)
			{
				return true;
			}
			SeasonModel._Instance = new SeasonModel();
			return true;
		}

		// Token: 0x06032A0A RID: 207370 RVA: 0x00BCD507 File Offset: 0x00BCB707
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032A0B RID: 207371 RVA: 0x00BCD509 File Offset: 0x00BCB709
		public static void ResetStaticDefaultValue()
		{
			SeasonModel._Instance = null;
		}

		// Token: 0x06032A0C RID: 207372 RVA: 0x00BCD511 File Offset: 0x00BCB711
		static SeasonModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SeasonModel.CreateStaticDefaultValue), new Action(SeasonModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401AED9 RID: 110297
		[Nullable(2)]
		private UMaterialParameterCollection MaterialAssetInternal;

		// Token: 0x0401AEDA RID: 110298
		[Nullable(2)]
		private ILoopSeasonChange LoopConfigInternal;

		// Token: 0x0401AEDB RID: 110299
		private readonly Dictionary<int, TsTriggerVolume> RegisteredVolumesByAreaIdInternal = new Dictionary<int, TsTriggerVolume>();

		// Token: 0x0401AEDC RID: 110300
		private readonly HashSet<int> PlayerInsideAreaIdsInternal = new HashSet<int>();

		// Token: 0x0401AEE6 RID: 110310
		[Nullable(2)]
		private static SeasonModel _Instance;
	}
}
