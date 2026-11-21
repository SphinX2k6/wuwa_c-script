using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E6A RID: 15978
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleShopGrid : LoopScrollMediumItemGrid<RogueResGainData>
	{
		// Token: 0x1700528D RID: 21133
		// (get) Token: 0x06028A12 RID: 166418 RVA: 0x00B67A41 File Offset: 0x00B65C41
		public new RogueResGainData Data
		{
			get
			{
				return this.Data as RogueResGainData;
			}
		}

		// Token: 0x06028A13 RID: 166419 RVA: 0x00B67A50 File Offset: 0x00B65C50
		[NullableContext(1)]
		protected override void OnRefresh(RogueResGainData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			RogueResShopToken rogueResShopToken = data.RogueResShopToken;
			if (rogueResShopToken == null)
			{
				return;
			}
			RogueResBuffPool? rogueResBuffPoolById = RogueBattleConfig.Instance.GetRogueResBuffPoolById(rogueResShopToken.ConfigId);
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
				IsDisable = new bool?(rogueResShopToken.IsSell)
			};
			base.Apply<PropMediumItemGrid>(parameters);
			ItemGridComponent component = base.RefreshComponent(typeof(RogueBattleDiscountTagComponent), new bool?(true), data);
			bool bVisible = rogueResShopToken.CurPrice != rogueResShopToken.SourcePrice;
			base.SetComponentVisible(component, bVisible);
			ItemGridComponent component2 = base.RefreshComponent(typeof(RogueBattleShopDiscount), new bool?(true), data);
			base.SetComponentVisible(component2, true);
			ItemGridComponent component3 = base.RefreshComponent(typeof(RogueBattleGridElementComponent), new bool?(true), data);
			base.SetComponentVisible(component3, true);
		}

		// Token: 0x06028A14 RID: 166420 RVA: 0x00B67B64 File Offset: 0x00B65D64
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.OnSelected(true);
			}
		}

		// Token: 0x06028A15 RID: 166421 RVA: 0x00B67B74 File Offset: 0x00B65D74
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
			RogueBattleModel.Instance.SelectGainData = this.Data;
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

		// Token: 0x06028A16 RID: 166422 RVA: 0x00B67BC0 File Offset: 0x00B65DC0
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
			RogueBattleModel.Instance.SelectGainData = null;
		}

		// Token: 0x0401617C RID: 90492
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, RogueResGainData> SelectCallback;
	}
}
