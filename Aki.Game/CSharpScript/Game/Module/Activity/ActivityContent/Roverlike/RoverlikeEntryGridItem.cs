using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050B5 RID: 20661
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeEntryGridItem : MediumItemGrid, ISyncGridProxy<RoverlikeGainEntry>, ISyncGridProxy
	{
		// Token: 0x170064F7 RID: 25847
		// (get) Token: 0x06033B67 RID: 211815 RVA: 0x00E7953E File Offset: 0x00E7773E
		// (set) Token: 0x06033B68 RID: 211816 RVA: 0x00E79546 File Offset: 0x00E77746
		public int GridIndex { get; set; }

		// Token: 0x06033B69 RID: 211817 RVA: 0x00E7954F File Offset: 0x00E7774F
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
			base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleStateChanged));
			base.SetUseFixedAsync(true);
		}

		// Token: 0x06033B6A RID: 211818 RVA: 0x00E79578 File Offset: 0x00E77778
		public void Refresh(RoverlikeGainEntry data)
		{
			this.CollectData = data;
			if (this.IsEmptyEntry(data))
			{
				PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
				{
					Data = data,
					IsQualityHidden = new bool?(true)
				};
				this.FillEmptyGridParams(propMediumItemGrid);
				base.Apply<PropMediumItemGrid>(propMediumItemGrid);
			}
			else
			{
				PropMediumItemGrid propMediumItemGrid2 = new PropMediumItemGrid
				{
					Data = data
				};
				this.FillGridParams(propMediumItemGrid2, data);
				base.Apply<PropMediumItemGrid>(propMediumItemGrid2);
			}
			Func<RoverlikeGainEntry, int, bool> isGridSelected = this.IsGridSelected;
			bool toggleStateInternal = isGridSelected != null && isGridSelected(data, this.GridIndex);
			this.SetToggleStateInternal(toggleStateInternal);
		}

		// Token: 0x06033B6B RID: 211819 RVA: 0x00E795FB File Offset: 0x00E777FB
		void ISyncGridProxy.Refresh(object data)
		{
			this.Refresh((RoverlikeGainEntry)data);
		}

		// Token: 0x06033B6C RID: 211820 RVA: 0x00E79609 File Offset: 0x00E77809
		void ISyncGridProxy.CreateByActor(AActor actor)
		{
			base.CreateByActor(actor, null);
		}

		// Token: 0x06033B6D RID: 211821 RVA: 0x00E79613 File Offset: 0x00E77813
		void ISyncGridProxy.CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x06033B6E RID: 211822 RVA: 0x00E7961D File Offset: 0x00E7781D
		public void Clear()
		{
			this.CollectData = null;
		}

		// Token: 0x06033B6F RID: 211823 RVA: 0x00E79628 File Offset: 0x00E77828
		public void SetToggleStateInternal(bool selected)
		{
			EToggleState state = selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.GetItemGridExtendToggle().SetToggleState(state, false, false, false);
		}

		// Token: 0x06033B70 RID: 211824 RVA: 0x00E7964D File Offset: 0x00E7784D
		private bool IsEmptyEntry(RoverlikeGainEntry data)
		{
			return data.ConfigId <= 0;
		}

		// Token: 0x06033B71 RID: 211825 RVA: 0x00E7965C File Offset: 0x00E7785C
		private void FillEmptyGridParams(PropMediumItemGrid params_)
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverRogueActivity? roverRogueActivity;
			if (instance == null)
			{
				roverRogueActivity = null;
			}
			else
			{
				RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
				roverRogueActivity = ((currentActivityData != null) ? currentActivityData.GetParamConfig() : null);
			}
			RoverRogueActivity? roverRogueActivity2 = roverRogueActivity;
			if (roverRogueActivity2 == null)
			{
				return;
			}
			RoverRogueActivity value = roverRogueActivity2.Value;
			Func<int, int> getSlotId = this.GetSlotId;
			int num = (getSlotId != null) ? getSlotId(this.GridIndex) : 0;
			if (num == 0)
			{
				return;
			}
			string slotName = this.GetSlotName(value, num);
			if (!string.IsNullOrEmpty(slotName))
			{
				params_.BottomTextId = slotName;
			}
			string slotEmptyIconPath = this.GetSlotEmptyIconPath(value, num);
			if (string.IsNullOrEmpty(slotEmptyIconPath))
			{
				return;
			}
			if (slotEmptyIconPath.Contains("Atlas"))
			{
				params_.SpriteIconPath = slotEmptyIconPath;
				return;
			}
			params_.IconPath = slotEmptyIconPath;
		}

		// Token: 0x06033B72 RID: 211826 RVA: 0x00E79714 File Offset: 0x00E77914
		[NullableContext(2)]
		private string GetSlotName(RoverRogueActivity activityConfig, int slotId)
		{
			for (int i = 0; i < activityConfig.SlotNameLength; i++)
			{
				DicIntString? dicIntString = activityConfig.SlotName(i);
				if (dicIntString != null && dicIntString.GetValueOrDefault().Key == slotId)
				{
					return dicIntString.Value.Value;
				}
			}
			return null;
		}

		// Token: 0x06033B73 RID: 211827 RVA: 0x00E79770 File Offset: 0x00E77970
		[NullableContext(2)]
		private string GetSlotEmptyIconPath(RoverRogueActivity activityConfig, int slotId)
		{
			for (int i = 0; i < activityConfig.SlotEmptyIconLength; i++)
			{
				DicIntString? dicIntString = activityConfig.SlotEmptyIcon(i);
				if (dicIntString != null && dicIntString.GetValueOrDefault().Key == slotId)
				{
					return dicIntString.Value.Value;
				}
			}
			return null;
		}

		// Token: 0x06033B74 RID: 211828 RVA: 0x00E797CC File Offset: 0x00E779CC
		private void FillGridParams(PropMediumItemGrid params_, RoverlikeGainEntry data)
		{
			switch (data.Type)
			{
			case RoverRogueGainDataType.RoverRogueGainBless:
			{
				RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(data.ConfigId);
				if (blessConfig != null)
				{
					RoverRogueQuality? qualityConfig = RoverlikeConfig.Instance.GetQualityConfig(blessConfig.Value.Quality);
					if (qualityConfig != null)
					{
						params_.SpriteIconPath = blessConfig.Value.Icon;
						params_.BottomTextId = blessConfig.Value.Name;
						params_.QualityIcon = qualityConfig.Value.ItemGridSprite;
						return;
					}
				}
				break;
			}
			case RoverRogueGainDataType.RoverRogueGainRoleEnhance:
			{
				RoverRogueRoleEnhance? roleEnhanceConfig = RoverlikeConfig.Instance.GetRoleEnhanceConfig(data.ConfigId);
				if (roleEnhanceConfig != null)
				{
					params_.SpriteIconPath = roleEnhanceConfig.Value.Icon;
					params_.BottomTextId = roleEnhanceConfig.Value.Name;
					params_.IsQualityHidden = new bool?(true);
					return;
				}
				break;
			}
			case RoverRogueGainDataType.RoverRogueGainLootItem:
				break;
			case RoverRogueGainDataType.RoverRogueGainItem:
			{
				RoverRogueItem? itemConfig = RoverlikeConfig.Instance.GetItemConfig(data.ConfigId);
				if (itemConfig != null)
				{
					RoverRogueQuality? qualityConfig2 = RoverlikeConfig.Instance.GetQualityConfig(itemConfig.Value.Quality);
					if (qualityConfig2 != null)
					{
						params_.BottomTextId = itemConfig.Value.Name;
						params_.IconPath = itemConfig.Value.Icon;
						params_.QualityIcon = qualityConfig2.Value.ItemGridSprite;
						params_.RoundCount = new int?(data.ItemRemainingRooms);
						params_.IsDisable = new bool?(data.ItemRemainingRooms == 0);
					}
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06033B75 RID: 211829 RVA: 0x00E7997E File Offset: 0x00E77B7E
		private void OnToggleStateChanged(MediumItemGridExtendCallback parameters)
		{
			if (this.CollectData != null)
			{
				Action<RoverlikeGainEntry, int> onClickCb = this.OnClickCb;
				if (onClickCb == null)
				{
					return;
				}
				onClickCb(this.CollectData, this.GridIndex);
			}
		}

		// Token: 0x0401B6B4 RID: 112308
		[Nullable(2)]
		public RoverlikeGainEntry CollectData;

		// Token: 0x0401B6B5 RID: 112309
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoverlikeGainEntry, int> OnClickCb;

		// Token: 0x0401B6B6 RID: 112310
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> IsGridSelected;

		// Token: 0x0401B6B7 RID: 112311
		[Nullable(2)]
		public Func<int, int> GetSlotId;
	}
}
