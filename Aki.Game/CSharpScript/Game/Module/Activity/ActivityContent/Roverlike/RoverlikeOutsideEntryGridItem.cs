using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006122 RID: 24866
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeOutsideEntryGridItem : MediumItemGrid, ISyncGridProxy<RoverlikeGainEntry>, ISyncGridProxy
	{
		// Token: 0x1700918B RID: 37259
		// (get) Token: 0x0603EDEB RID: 257515 RVA: 0x00F2F17E File Offset: 0x00F2D37E
		// (set) Token: 0x0603EDEC RID: 257516 RVA: 0x00F2F186 File Offset: 0x00F2D386
		public int GridIndex { get; set; }

		// Token: 0x0603EDED RID: 257517 RVA: 0x00F2F18F File Offset: 0x00F2D38F
		protected override void OnStart()
		{
			this.GetItemGridExtendToggle().bLockStateOnSelect = true;
			base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleStateChanged));
			base.SetUseFixedAsync(true);
		}

		// Token: 0x0603EDEE RID: 257518 RVA: 0x00F2F1B8 File Offset: 0x00F2D3B8
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

		// Token: 0x0603EDEF RID: 257519 RVA: 0x00F2F23B File Offset: 0x00F2D43B
		void ISyncGridProxy.Refresh(object data)
		{
			this.Refresh((RoverlikeGainEntry)data);
		}

		// Token: 0x0603EDF0 RID: 257520 RVA: 0x00F2F249 File Offset: 0x00F2D449
		void ISyncGridProxy.CreateByActor(AActor actor)
		{
			base.CreateByActor(actor, null);
		}

		// Token: 0x0603EDF1 RID: 257521 RVA: 0x00F2F253 File Offset: 0x00F2D453
		void ISyncGridProxy.CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x0603EDF2 RID: 257522 RVA: 0x00F2F25D File Offset: 0x00F2D45D
		public void Clear()
		{
			this.CollectData = null;
		}

		// Token: 0x0603EDF3 RID: 257523 RVA: 0x00F2F268 File Offset: 0x00F2D468
		public void SetToggleStateInternal(bool selected)
		{
			EToggleState state = selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.GetItemGridExtendToggle().SetToggleState(state, false, false, false);
		}

		// Token: 0x0603EDF4 RID: 257524 RVA: 0x00F2F290 File Offset: 0x00F2D490
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

		// Token: 0x0603EDF5 RID: 257525 RVA: 0x00F2F41A File Offset: 0x00F2D61A
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

		// Token: 0x04020D37 RID: 134455
		[Nullable(2)]
		public RoverlikeGainEntry CollectData;

		// Token: 0x04020D38 RID: 134456
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RoverlikeGainEntry, int> OnClickCb;

		// Token: 0x04020D39 RID: 134457
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> IsGridSelected;

		// Token: 0x04020D3A RID: 134458
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeGainEntry, int, bool> GetLockState;
	}
}
