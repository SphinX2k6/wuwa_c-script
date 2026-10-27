using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200531F RID: 21279
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueIllustratedTokenMediumItemGrid : LoopScrollMediumItemGrid<RogueTokenViewData>
	{
		// Token: 0x060366AF RID: 222895 RVA: 0x00CE150C File Offset: 0x00CDF70C
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

		// Token: 0x060366B0 RID: 222896 RVA: 0x00CE161E File Offset: 0x00CDF81E
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x060366B1 RID: 222897 RVA: 0x00CE1628 File Offset: 0x00CDF828
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x060366B2 RID: 222898 RVA: 0x00CE1632 File Offset: 0x00CDF832
		public void BindOnItemButtonClickedCallback(Action<RogueTokenViewData> onItemButtonClicked)
		{
			this.OnItemButtonClickedCallback = onItemButtonClicked;
		}

		// Token: 0x060366B3 RID: 222899 RVA: 0x00CE163B File Offset: 0x00CDF83B
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (this.OnItemButtonClickedCallback != null)
			{
				this.OnItemButtonClickedCallback(this.TokenViewData);
			}
		}

		// Token: 0x0401CC3C RID: 117820
		[Nullable(2)]
		private RogueTokenViewData TokenViewData;

		// Token: 0x0401CC3D RID: 117821
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<RogueTokenViewData> OnItemButtonClickedCallback;
	}
}
