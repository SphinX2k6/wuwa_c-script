using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E81 RID: 16001
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleTokenGrid : LoopScrollMediumItemGrid<RogueResGainData>
	{
		// Token: 0x1700528E RID: 21134
		// (get) Token: 0x06028A6B RID: 166507 RVA: 0x00B693C6 File Offset: 0x00B675C6
		public new RogueResGainData Data
		{
			get
			{
				return this.Data as RogueResGainData;
			}
		}

		// Token: 0x06028A6C RID: 166508 RVA: 0x00B693D4 File Offset: 0x00B675D4
		[NullableContext(1)]
		protected override void OnRefresh(RogueResGainData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			RogueResToken rogueResToken = data.RogueResToken;
			if (rogueResToken == null)
			{
				return;
			}
			RogueResBuffPool? rogueResBuffPoolById = RogueBattleConfig.Instance.GetRogueResBuffPoolById(rogueResToken.ConfigId);
			if (rogueResBuffPoolById == null)
			{
				return;
			}
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				IconPath = rogueResBuffPoolById.Value.BuffIcon,
				QualityId = new int?(rogueResBuffPoolById.Value.Quality),
				QualityType = new CommonDefine.EQualityIconType?(CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath),
				BottomTextId = rogueResBuffPoolById.Value.BuffName
			};
			base.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x06028A6D RID: 166509 RVA: 0x00B69472 File Offset: 0x00B67672
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.OnSelected(true);
			}
		}

		// Token: 0x06028A6E RID: 166510 RVA: 0x00B6947F File Offset: 0x00B6767F
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
			if (fireEvent && this.Data != null)
			{
				Action<int, RogueResGainData> selectCallback = this.SelectCallback;
				if (selectCallback == null)
				{
					return;
				}
				selectCallback(base.GridIndex, this.Data);
			}
		}

		// Token: 0x06028A6F RID: 166511 RVA: 0x00B694B0 File Offset: 0x00B676B0
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x040161CC RID: 90572
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, RogueResGainData> SelectCallback;
	}
}
