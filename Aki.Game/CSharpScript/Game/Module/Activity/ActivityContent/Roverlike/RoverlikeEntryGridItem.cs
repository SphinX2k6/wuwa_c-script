using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006137 RID: 24887
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeEntryGridItem : MediumItemGrid, ISyncGridProxy<RoverlikeGainEntry>, ISyncGridProxy
	{
		// Token: 0x17009195 RID: 37269
		// (get) Token: 0x0603EEA7 RID: 257703 RVA: 0x00F3265E File Offset: 0x00F3085E
		// (set) Token: 0x0603EEA8 RID: 257704 RVA: 0x00F32666 File Offset: 0x00F30866
		public int GridIndex { get; set; }

		// Token: 0x0603EEA9 RID: 257705 RVA: 0x00F3266F File Offset: 0x00F3086F
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
			base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleStateChanged));
			base.SetUseFixedAsync(true);
		}

		// Token: 0x0603EEAA RID: 257706 RVA: 0x00F32698 File Offset: 0x00F30898
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

		// Token: 0x0603EEAB RID: 257707 RVA: 0x00F3271B File Offset: 0x00F3091B
		void ISyncGridProxy.Refresh(object data)
		{
			this.Refresh((RoverlikeGainEntry)data);
		}

		// Token: 0x0603EEAC RID: 257708 RVA: 0x00F32729 File Offset: 0x00F30929
		void ISyncGridProxy.CreateByActor(AActor actor)
		{
			base.CreateByActor(actor, null);
		}

		// Token: 0x0603EEAD RID: 257709 RVA: 0x00F32733 File Offset: 0x00F30933
		void ISyncGridProxy.CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x0603EEAE RID: 257710 RVA: 0x00F3273D File Offset: 0x00F3093D
		public void Clear()
		{
			this.CollectData = null;
		}

		// Token: 0x0603EEAF RID: 257711 RVA: 0x00F32748 File Offset: 0x00F30948
		public void SetToggleStateInternal(bool selected)
		{
			EToggleState state = selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.GetItemGridExtendToggle().SetToggleState(state, false, false, false);
		}

		// Token: 0x0603EEB0 RID: 257712 RVA: 0x00F3276D File Offset: 0x00F3096D
		private bool IsEmptyEntry(RoverlikeGainEntry data)
		{
			return data.ConfigId <= 0;
		}

		// Token: 0x0603EEB1 RID: 257713 RVA: 0x00F3277C File Offset: 0x00F3097C
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

		// Token: 0x0603EEB2 RID: 257714 RVA: 0x00F32834 File Offset: 0x00F30A34
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

		// Token: 0x0603EEB3 RID: 257715 RVA: 0x00F32890 File Offset: 0x00F30A90
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

		// Token: 0x0603EEB4 RID: 257716 RVA: 0x00F328EC File Offset: 0x00F30AEC
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

		// Token: 0x0603EEB5 RID: 257717 RVA: 0x00F32A9E File Offset: 0x00F30C9E
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

		// Token: 0x04020D87 RID: 134535
		[Nullable(2)]
		public RoverlikeGainEntry CollectData;

		// Token: 0x04020D88 RID: 134536
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoverlikeGainEntry, int> OnClickCb;

		// Token: 0x04020D89 RID: 134537
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> IsGridSelected;

		// Token: 0x04020D8A RID: 134538
		[Nullable(2)]
		public Func<int, int> GetSlotId;
	}
}
