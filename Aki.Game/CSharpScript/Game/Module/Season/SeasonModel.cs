using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Core;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02003C34 RID: 15412
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SeasonModel : ModelBase
	{
		// Token: 0x17005091 RID: 20625
		// (get) Token: 0x06027795 RID: 161685 RVA: 0x00B11D2B File Offset: 0x00B0FF2B
		public bool IsMaterialReady
		{
			get
			{
				UMaterialParameterCollection materialAssetInternal = this.MaterialAssetInternal;
				return materialAssetInternal != null && materialAssetInternal.IsValid();
			}
		}

		// Token: 0x17005092 RID: 20626
		// (get) Token: 0x06027796 RID: 161686 RVA: 0x00B11D3E File Offset: 0x00B0FF3E
		[Nullable(2)]
		public UMaterialParameterCollection MaterialAsset
		{
			[NullableContext(2)]
			get
			{
				return this.MaterialAssetInternal;
			}
		}

		// Token: 0x17005093 RID: 20627
		// (get) Token: 0x06027797 RID: 161687 RVA: 0x00B11D46 File Offset: 0x00B0FF46
		// (set) Token: 0x06027798 RID: 161688 RVA: 0x00B11D4E File Offset: 0x00B0FF4E
		public FName? TimelineParamName { get; private set; }

		// Token: 0x17005094 RID: 20628
		// (get) Token: 0x06027799 RID: 161689 RVA: 0x00B11D57 File Offset: 0x00B0FF57
		// (set) Token: 0x0602779A RID: 161690 RVA: 0x00B11D5F File Offset: 0x00B0FF5F
		public double CurrentValue { get; set; }

		// Token: 0x17005095 RID: 20629
		// (get) Token: 0x0602779B RID: 161691 RVA: 0x00B11D68 File Offset: 0x00B0FF68
		// (set) Token: 0x0602779C RID: 161692 RVA: 0x00B11D70 File Offset: 0x00B0FF70
		public double? LastWrittenValue { get; set; }

		// Token: 0x17005096 RID: 20630
		// (get) Token: 0x0602779D RID: 161693 RVA: 0x00B11D79 File Offset: 0x00B0FF79
		// (set) Token: 0x0602779E RID: 161694 RVA: 0x00B11D81 File Offset: 0x00B0FF81
		public ESeason? LastReportedSeason { get; set; }

		// Token: 0x17005097 RID: 20631
		// (get) Token: 0x0602779F RID: 161695 RVA: 0x00B11D8A File Offset: 0x00B0FF8A
		// (set) Token: 0x060277A0 RID: 161696 RVA: 0x00B11D92 File Offset: 0x00B0FF92
		public ESeasonDriverPhase DriverPhase { get; set; }

		// Token: 0x17005098 RID: 20632
		// (get) Token: 0x060277A1 RID: 161697 RVA: 0x00B11D9B File Offset: 0x00B0FF9B
		// (set) Token: 0x060277A2 RID: 161698 RVA: 0x00B11DA4 File Offset: 0x00B0FFA4
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

		// Token: 0x17005099 RID: 20633
		// (get) Token: 0x060277A3 RID: 161699 RVA: 0x00B11DF5 File Offset: 0x00B0FFF5
		// (set) Token: 0x060277A4 RID: 161700 RVA: 0x00B11DFD File Offset: 0x00B0FFFD
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

		// Token: 0x1700509A RID: 20634
		// (get) Token: 0x060277A5 RID: 161701 RVA: 0x00B11E06 File Offset: 0x00B10006
		// (set) Token: 0x060277A6 RID: 161702 RVA: 0x00B11E0E File Offset: 0x00B1000E
		[Nullable(2)]
		public ISeasonLoopState LoopState { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700509B RID: 20635
		// (get) Token: 0x060277A7 RID: 161703 RVA: 0x00B11E17 File Offset: 0x00B10017
		public List<ISeasonSwitchJob> SwitchQueue { get; } = new List<ISeasonSwitchJob>();

		// Token: 0x1700509C RID: 20636
		// (get) Token: 0x060277A8 RID: 161704 RVA: 0x00B11E1F File Offset: 0x00B1001F
		public HashSet<int> ActiveAreaIds { get; } = new HashSet<int>();

		// Token: 0x060277A9 RID: 161705 RVA: 0x00B11E28 File Offset: 0x00B10028
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

		// Token: 0x060277AA RID: 161706 RVA: 0x00B11E90 File Offset: 0x00B10090
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

		// Token: 0x060277AB RID: 161707 RVA: 0x00B11EC9 File Offset: 0x00B100C9
		public bool IsAreaActive(int areaId)
		{
			return this.ActiveAreaIds.Contains(areaId);
		}

		// Token: 0x060277AC RID: 161708 RVA: 0x00B11ED7 File Offset: 0x00B100D7
		public void ActivateArea(int areaId)
		{
			if (areaId == 0)
			{
				return;
			}
			this.ActiveAreaIds.Add(areaId);
		}

		// Token: 0x060277AD RID: 161709 RVA: 0x00B11EEA File Offset: 0x00B100EA
		public void DeactivateArea(int areaId)
		{
			if (areaId == 0)
			{
				return;
			}
			this.ActiveAreaIds.Remove(areaId);
		}

		// Token: 0x060277AE RID: 161710 RVA: 0x00B11EFD File Offset: 0x00B100FD
		public void MarkPlayerInside(int areaId)
		{
			if (areaId == 0)
			{
				return;
			}
			this.PlayerInsideAreaIdsInternal.Add(areaId);
		}

		// Token: 0x060277AF RID: 161711 RVA: 0x00B11F10 File Offset: 0x00B10110
		public void MarkPlayerOutside(int areaId)
		{
			if (areaId == 0)
			{
				return;
			}
			this.PlayerInsideAreaIdsInternal.Remove(areaId);
		}

		// Token: 0x060277B0 RID: 161712 RVA: 0x00B11F23 File Offset: 0x00B10123
		public bool IsPlayerInside(int areaId)
		{
			return this.PlayerInsideAreaIdsInternal.Contains(areaId);
		}

		// Token: 0x060277B1 RID: 161713 RVA: 0x00B11F34 File Offset: 0x00B10134
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

		// Token: 0x060277B2 RID: 161714 RVA: 0x00B11F80 File Offset: 0x00B10180
		[NullableContext(2)]
		public ISeasonSwitchJob PeekSwitchHead()
		{
			if (this.SwitchQueue.Count <= 0)
			{
				return null;
			}
			return this.SwitchQueue[0];
		}

		// Token: 0x060277B3 RID: 161715 RVA: 0x00B11F9E File Offset: 0x00B1019E
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

		// Token: 0x060277B4 RID: 161716 RVA: 0x00B11FC8 File Offset: 0x00B101C8
		public void ClearSwitchQueue()
		{
			this.FlushPendingCallbacks(false);
			this.SwitchQueue.Clear();
		}

		// Token: 0x060277B5 RID: 161717 RVA: 0x00B11FDC File Offset: 0x00B101DC
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

		// Token: 0x060277B6 RID: 161718 RVA: 0x00B12038 File Offset: 0x00B10238
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

		// Token: 0x060277B7 RID: 161719 RVA: 0x00B120E0 File Offset: 0x00B102E0
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

		// Token: 0x060277B8 RID: 161720 RVA: 0x00B12106 File Offset: 0x00B10306
		protected override bool OnLeaveLevel()
		{
			this.ResetRuntime();
			return true;
		}

		// Token: 0x060277B9 RID: 161721 RVA: 0x00B12110 File Offset: 0x00B10310
		protected override bool OnClear()
		{
			this.ResetRuntime();
			this.MaterialAssetInternal = null;
			this.TimelineParamName = null;
			return true;
		}

		// Token: 0x1700509D RID: 20637
		// (get) Token: 0x060277BA RID: 161722 RVA: 0x00B1213A File Offset: 0x00B1033A
		public static SeasonModel Instance
		{
			get
			{
				return SeasonModel._Instance;
			}
		}

		// Token: 0x060277BB RID: 161723 RVA: 0x00B12141 File Offset: 0x00B10341
		public static SeasonModel GetOrCreateInstance()
		{
			if (SeasonModel._Instance == null)
			{
				SeasonModel.CreateInstance();
			}
			return SeasonModel._Instance;
		}

		// Token: 0x060277BC RID: 161724 RVA: 0x00B12155 File Offset: 0x00B10355
		public static bool CreateInstance()
		{
			if (SeasonModel._Instance != null)
			{
				return true;
			}
			SeasonModel._Instance = new SeasonModel();
			return true;
		}

		// Token: 0x060277BD RID: 161725 RVA: 0x00B1216B File Offset: 0x00B1036B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060277BE RID: 161726 RVA: 0x00B1216D File Offset: 0x00B1036D
		public static void ResetStaticDefaultValue()
		{
			SeasonModel._Instance = null;
		}

		// Token: 0x060277BF RID: 161727 RVA: 0x00B12175 File Offset: 0x00B10375
		static SeasonModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SeasonModel.CreateStaticDefaultValue), new Action(SeasonModel.ResetStaticDefaultValue));
		}

		// Token: 0x04015836 RID: 88118
		[Nullable(2)]
		private UMaterialParameterCollection MaterialAssetInternal;

		// Token: 0x04015837 RID: 88119
		[Nullable(2)]
		private ILoopSeasonChange LoopConfigInternal;

		// Token: 0x04015838 RID: 88120
		private readonly Dictionary<int, TsTriggerVolume> RegisteredVolumesByAreaIdInternal = new Dictionary<int, TsTriggerVolume>();

		// Token: 0x04015839 RID: 88121
		private readonly HashSet<int> PlayerInsideAreaIdsInternal = new HashSet<int>();

		// Token: 0x04015843 RID: 88131
		[Nullable(2)]
		private static SeasonModel _Instance;
	}
}
