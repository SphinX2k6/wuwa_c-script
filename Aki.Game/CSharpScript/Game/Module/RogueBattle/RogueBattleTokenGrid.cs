using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EB8 RID: 20152
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleTokenGrid : LoopScrollMediumItemGrid<RogueResGainData>
	{
		// Token: 0x17007EDE RID: 32478
		// (get) Token: 0x06033C00 RID: 211968 RVA: 0x00C1FEAE File Offset: 0x00C1E0AE
		public new RogueResGainData Data
		{
			get
			{
				return this.Data as RogueResGainData;
			}
		}

		// Token: 0x06033C01 RID: 211969 RVA: 0x00C1FEBC File Offset: 0x00C1E0BC
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

		// Token: 0x06033C02 RID: 211970 RVA: 0x00C1FF5A File Offset: 0x00C1E15A
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.OnSelected(true);
			}
		}

		// Token: 0x06033C03 RID: 211971 RVA: 0x00C1FF67 File Offset: 0x00C1E167
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

		// Token: 0x06033C04 RID: 211972 RVA: 0x00C1FF98 File Offset: 0x00C1E198
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0401B7F9 RID: 112633
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, RogueResGainData> SelectCallback;
	}
}
