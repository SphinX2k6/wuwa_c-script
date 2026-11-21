using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050B7 RID: 20663
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeEntrySmallGridItem : LoopScrollSmallItemGrid<IRoverlikeEntrySmallGridData>
	{
		// Token: 0x06033B7E RID: 211838 RVA: 0x00E79A03 File Offset: 0x00E77C03
		public void BindOnItemClick(Action<IRoverlikeEntrySmallGridData, int> callback)
		{
			this.OnItemClick = callback;
		}

		// Token: 0x06033B7F RID: 211839 RVA: 0x00E79A0C File Offset: 0x00E77C0C
		protected override void OnStart()
		{
		}

		// Token: 0x06033B80 RID: 211840 RVA: 0x00E79A10 File Offset: 0x00E77C10
		protected override void OnRefresh(IRoverlikeEntrySmallGridData data, bool isSelected, int gridIndex)
		{
			PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid
			{
				Data = data
			};
			this.FillGridParams(propSmallItemGrid, data);
			base.Apply<PropSmallItemGrid>(propSmallItemGrid);
		}

		// Token: 0x06033B81 RID: 211841 RVA: 0x00E79A3C File Offset: 0x00E77C3C
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			IRoverlikeEntrySmallGridData roverlikeEntrySmallGridData = this.Data as IRoverlikeEntrySmallGridData;
			if (roverlikeEntrySmallGridData != null)
			{
				Action<IRoverlikeEntrySmallGridData, int> onItemClick = this.OnItemClick;
				if (onItemClick == null)
				{
					return;
				}
				onItemClick(roverlikeEntrySmallGridData, base.GridIndex);
			}
		}

		// Token: 0x06033B82 RID: 211842 RVA: 0x00E79A6F File Offset: 0x00E77C6F
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, true);
		}

		// Token: 0x06033B83 RID: 211843 RVA: 0x00E79A79 File Offset: 0x00E77C79
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}

		// Token: 0x06033B84 RID: 211844 RVA: 0x00E79A84 File Offset: 0x00E77C84
		private void FillGridParams(PropSmallItemGrid params_, IRoverlikeEntrySmallGridData data)
		{
			RoverRogueGainDataType type = data.Type;
			if (type != RoverRogueGainDataType.RoverRogueGainRoleEnhance)
			{
				if (type == RoverRogueGainDataType.RoverRogueGainItem)
				{
					RoverRogueItem? itemConfig = RoverlikeConfig.Instance.GetItemConfig(data.ConfigId);
					if (itemConfig != null)
					{
						RoverRogueQuality? qualityConfig = RoverlikeConfig.Instance.GetQualityConfig(itemConfig.Value.Quality);
						if (qualityConfig != null)
						{
							params_.IconPath = itemConfig.Value.Icon;
							params_.QualityIcon = qualityConfig.Value.ItemGridSprite;
							return;
						}
					}
				}
			}
			else
			{
				RoverRogueRoleEnhance? roleEnhanceConfig = RoverlikeConfig.Instance.GetRoleEnhanceConfig(data.ConfigId);
				if (roleEnhanceConfig != null)
				{
					params_.SpriteIconPath = roleEnhanceConfig.Value.Icon;
					params_.IsQualityHidden = new bool?(true);
				}
			}
		}

		// Token: 0x0401B6BD RID: 112317
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeEntrySmallGridData, int> OnItemClick;
	}
}
