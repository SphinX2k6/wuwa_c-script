using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EA1 RID: 20129
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleShopGrid : LoopScrollMediumItemGrid<RogueResGainData>
	{
		// Token: 0x17007EDD RID: 32477
		// (get) Token: 0x06033BA7 RID: 211879 RVA: 0x00C1E525 File Offset: 0x00C1C725
		public new RogueResGainData Data
		{
			get
			{
				return this.Data as RogueResGainData;
			}
		}

		// Token: 0x06033BA8 RID: 211880 RVA: 0x00C1E534 File Offset: 0x00C1C734
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

		// Token: 0x06033BA9 RID: 211881 RVA: 0x00C1E648 File Offset: 0x00C1C848
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.OnSelected(true);
			}
		}

		// Token: 0x06033BAA RID: 211882 RVA: 0x00C1E658 File Offset: 0x00C1C858
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

		// Token: 0x06033BAB RID: 211883 RVA: 0x00C1E6A4 File Offset: 0x00C1C8A4
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
			RogueBattleModel.Instance.SelectGainData = null;
		}

		// Token: 0x0401B7A9 RID: 112553
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, RogueResGainData> SelectCallback;
	}
}
