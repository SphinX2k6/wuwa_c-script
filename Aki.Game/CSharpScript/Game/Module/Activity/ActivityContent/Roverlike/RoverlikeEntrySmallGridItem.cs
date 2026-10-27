using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006139 RID: 24889
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeEntrySmallGridItem : LoopScrollSmallItemGrid<IRoverlikeEntrySmallGridData>
	{
		// Token: 0x0603EEBE RID: 257726 RVA: 0x00F32B23 File Offset: 0x00F30D23
		public void BindOnItemClick(Action<IRoverlikeEntrySmallGridData, int> callback)
		{
			this.OnItemClick = callback;
		}

		// Token: 0x0603EEBF RID: 257727 RVA: 0x00F32B2C File Offset: 0x00F30D2C
		protected override void OnStart()
		{
		}

		// Token: 0x0603EEC0 RID: 257728 RVA: 0x00F32B30 File Offset: 0x00F30D30
		protected override void OnRefresh(IRoverlikeEntrySmallGridData data, bool isSelected, int gridIndex)
		{
			PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid
			{
				Data = data
			};
			this.FillGridParams(propSmallItemGrid, data);
			base.Apply<PropSmallItemGrid>(propSmallItemGrid);
		}

		// Token: 0x0603EEC1 RID: 257729 RVA: 0x00F32B5C File Offset: 0x00F30D5C
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

		// Token: 0x0603EEC2 RID: 257730 RVA: 0x00F32B8F File Offset: 0x00F30D8F
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, true);
		}

		// Token: 0x0603EEC3 RID: 257731 RVA: 0x00F32B99 File Offset: 0x00F30D99
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, true);
		}

		// Token: 0x0603EEC4 RID: 257732 RVA: 0x00F32BA4 File Offset: 0x00F30DA4
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

		// Token: 0x04020D90 RID: 134544
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeEntrySmallGridData, int> OnItemClick;
	}
}
