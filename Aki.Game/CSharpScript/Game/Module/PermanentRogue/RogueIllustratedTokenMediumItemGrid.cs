using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042EF RID: 17135
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueIllustratedTokenMediumItemGrid : LoopScrollMediumItemGrid<RogueTokenViewData>
	{
		// Token: 0x0602B5AB RID: 177579 RVA: 0x00C2EEDC File Offset: 0x00C2D0DC
		protected override void OnRefresh(RogueTokenViewData data, bool isSelected, int gridIndex)
		{
			this.TokenViewData = data;
			RogueResBuffPool? config = ConfigRogueResBuffPoolById.GetConfig(data.GetConfigId(), true);
			RogueResCollection? config2 = ConfigRogueResCollectionByIdKey.GetConfig(data.GetCollectionIndex(), true);
			SignState collectItemState = ActivityPermanentRogueModel.Instance.GetCollectItemState(config2.Value.IdKey);
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				QualityId = ((config != null) ? new int?(config.GetValueOrDefault().Quality) : null),
				QualityType = new CommonDefine.EQualityIconType?(CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath),
				BottomTextId = ((config != null) ? config.GetValueOrDefault().BuffName : null),
				IsLockVisible = new bool?(collectItemState == SignState.Lock),
				IsRedDotVisible = new bool?(collectItemState == SignState.Unlock),
				IconPath = ((config != null) ? config.GetValueOrDefault().BuffIcon : null),
				IsDisable = new bool?(collectItemState == SignState.Lock)
			};
			base.Apply<PropMediumItemGrid>(parameters);
			this.SetSelected(isSelected, false);
		}

		// Token: 0x0602B5AC RID: 177580 RVA: 0x00C2EFEE File Offset: 0x00C2D1EE
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x0602B5AD RID: 177581 RVA: 0x00C2EFF8 File Offset: 0x00C2D1F8
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0602B5AE RID: 177582 RVA: 0x00C2F002 File Offset: 0x00C2D202
		public void BindOnItemButtonClickedCallback(Action<RogueTokenViewData> onItemButtonClicked)
		{
			this.OnItemButtonClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0602B5AF RID: 177583 RVA: 0x00C2F00B File Offset: 0x00C2D20B
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (this.OnItemButtonClickedCallback != null)
			{
				this.OnItemButtonClickedCallback(this.TokenViewData);
			}
		}

		// Token: 0x04017672 RID: 95858
		[Nullable(2)]
		private RogueTokenViewData TokenViewData;

		// Token: 0x04017673 RID: 95859
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<RogueTokenViewData> OnItemButtonClickedCallback;
	}
}
