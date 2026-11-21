using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050A0 RID: 20640
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeOutsideEntryGridItem : MediumItemGrid, ISyncGridProxy<RoverlikeGainEntry>, ISyncGridProxy
	{
		// Token: 0x170064ED RID: 25837
		// (get) Token: 0x06033AAD RID: 211629 RVA: 0x00E75F92 File Offset: 0x00E74192
		// (set) Token: 0x06033AAE RID: 211630 RVA: 0x00E75F9A File Offset: 0x00E7419A
		public int GridIndex { get; set; }

		// Token: 0x06033AAF RID: 211631 RVA: 0x00E75FA3 File Offset: 0x00E741A3
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
			base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleStateChanged));
			base.SetUseFixedAsync(true);
		}

		// Token: 0x06033AB0 RID: 211632 RVA: 0x00E75FCC File Offset: 0x00E741CC
		public void Refresh(RoverlikeGainEntry data)
		{
			this.CollectData = data;
			Func<RoverlikeGainEntry, int, bool> getLockState = this.GetLockState;
			bool value = getLockState != null && getLockState(data, this.GridIndex);
			PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
			{
				Data = data,
				IsLockVisible = new bool?(value),
				IsDisable = new bool?(value)
			};
			this.FillGridParams(propMediumItemGrid, data);
			base.Apply<PropMediumItemGrid>(propMediumItemGrid);
			Func<RoverlikeGainEntry, int, bool> isGridSelected = this.IsGridSelected;
			bool toggleStateInternal = isGridSelected != null && isGridSelected(data, this.GridIndex);
			this.SetToggleStateInternal(toggleStateInternal);
		}

		// Token: 0x06033AB1 RID: 211633 RVA: 0x00E7604F File Offset: 0x00E7424F
		void ISyncGridProxy.Refresh(object data)
		{
			this.Refresh((RoverlikeGainEntry)data);
		}

		// Token: 0x06033AB2 RID: 211634 RVA: 0x00E7605D File Offset: 0x00E7425D
		void ISyncGridProxy.CreateByActor(AActor actor)
		{
			base.CreateByActor(actor, null);
		}

		// Token: 0x06033AB3 RID: 211635 RVA: 0x00E76067 File Offset: 0x00E74267
		void ISyncGridProxy.CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x06033AB4 RID: 211636 RVA: 0x00E76071 File Offset: 0x00E74271
		public void Clear()
		{
			this.CollectData = null;
		}

		// Token: 0x06033AB5 RID: 211637 RVA: 0x00E7607C File Offset: 0x00E7427C
		public void SetToggleStateInternal(bool selected)
		{
			EToggleState state = selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.GetItemGridExtendToggle().SetToggleState(state, false, false, false);
		}

		// Token: 0x06033AB6 RID: 211638 RVA: 0x00E760A4 File Offset: 0x00E742A4
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
					}
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06033AB7 RID: 211639 RVA: 0x00E7622E File Offset: 0x00E7442E
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

		// Token: 0x0401B664 RID: 112228
		[Nullable(2)]
		public RoverlikeGainEntry CollectData;

		// Token: 0x0401B665 RID: 112229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoverlikeGainEntry, int> OnClickCb;

		// Token: 0x0401B666 RID: 112230
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> IsGridSelected;

		// Token: 0x0401B667 RID: 112231
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> GetLockState;
	}
}
