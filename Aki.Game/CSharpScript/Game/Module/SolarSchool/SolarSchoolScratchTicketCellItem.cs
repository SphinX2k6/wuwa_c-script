using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200593C RID: 22844
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolScratchTicketCellItem : GridProxyAbstract<SolarSchoolScratchTicketCellData>
	{
		// Token: 0x060384C4 RID: 230596 RVA: 0x00FBDAAC File Offset: 0x00FBBCAC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRewardButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060384C5 RID: 230597 RVA: 0x00FBDB94 File Offset: 0x00FBBD94
		protected override void OnBeforeCreate()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x060384C6 RID: 230598 RVA: 0x00FBDBB0 File Offset: 0x00FBBDB0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolScratchTicketCellItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolScratchTicketCellItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060384C7 RID: 230599 RVA: 0x00FBDBF3 File Offset: 0x00FBBDF3
		protected override void OnBeforeShow()
		{
			this.UiLevelSequence.AddSequenceFinishEvent("RevaelA", new Action<string>(this.OnRevealAnimationFinish), false);
		}

		// Token: 0x060384C8 RID: 230600 RVA: 0x00FBDC12 File Offset: 0x00FBBE12
		public override void Refresh(SolarSchoolScratchTicketCellData data, bool isSelected, int gridIndex)
		{
			this.RefreshUi(data);
		}

		// Token: 0x060384C9 RID: 230601 RVA: 0x00FBDC1B File Offset: 0x00FBBE1B
		public void RefreshByResultData(SolarSchoolScratchTicketCellData cellData, ScratchTicketRewardResult resultData)
		{
			this.CellData = cellData;
			if (resultData.SequenceType != ECellSequenceType.Warning && resultData.SequenceType != ECellSequenceType.Reveal)
			{
				this.RefreshUi(this.CellData);
			}
			this.PlaySequence(resultData.SequenceType);
		}

		// Token: 0x060384CA RID: 230602 RVA: 0x00FBDC50 File Offset: 0x00FBBE50
		private void RefreshUi(SolarSchoolScratchTicketCellData data)
		{
			this.CellData = data;
			SolarSchoolReward? solarSchoolReward = data.IsRevealed ? data.PlacedReward : null;
			if (solarSchoolReward == null)
			{
				base.GetItem(2).SetUIActive(false);
				base.GetItem(3).SetUIActive(false);
				base.GetSprite(1).SetUIActive(false);
				return;
			}
			base.GetItem(2).SetUIActive(true);
			base.GetItem(3).SetUIActive(true);
			base.GetSprite(1).SetUIActive(true);
			SolarSchoolReward value = solarSchoolReward.Value;
			string rewardIconPath = SolarSchoolConfig.Instance.GetRewardIconPath(value);
			if (!string.IsNullOrEmpty(rewardIconPath))
			{
				this.ItemGrid.SetIconByPath(rewardIconPath);
			}
			this.ItemGrid.SetBottomText(value.Value.ToString());
			this.ItemGrid.SetBottomTextVisible(true);
		}

		// Token: 0x060384CB RID: 230603 RVA: 0x00FBDD28 File Offset: 0x00FBBF28
		private void PlaySequence(ECellSequenceType sequenceType)
		{
			switch (sequenceType)
			{
			case ECellSequenceType.Center:
			case ECellSequenceType.Last:
				this.UiLevelSequence.PlaySequence("Strike", false, null);
				return;
			case ECellSequenceType.Left:
				this.UiLevelSequence.PlaySequence("StrikeL", false, null);
				return;
			case ECellSequenceType.Right:
				this.UiLevelSequence.PlaySequence("StrikeR", false, null);
				return;
			case ECellSequenceType.Top:
				this.UiLevelSequence.PlaySequence("StrikeA", false, null);
				return;
			case ECellSequenceType.Bottom:
				this.UiLevelSequence.PlaySequence("StrikeB", false, null);
				return;
			case ECellSequenceType.Warning:
				this.UiLevelSequence.PlaySequence("Warning", false, null);
				return;
			case ECellSequenceType.Reveal:
				this.UiLevelSequence.PlaySequence("RevaelA", false, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060384CC RID: 230604 RVA: 0x00FBDE18 File Offset: 0x00FBC018
		protected override void OnBeforeHide()
		{
			this.UiLevelSequence.RemoveSequenceFinishEvent("RevaelA", new Action<string>(this.OnRevealAnimationFinish));
		}

		// Token: 0x060384CD RID: 230605 RVA: 0x00FBDE38 File Offset: 0x00FBC038
		private void OnRevealAnimationFinish(string _)
		{
			this.RefreshUi(this.CellData);
			this.UiLevelSequence.PlaySequence("RevaelB", false, null);
		}

		// Token: 0x060384CE RID: 230606 RVA: 0x00FBDE6B File Offset: 0x00FBC06B
		private void OnClickRewardButton()
		{
			Action<SolarSchoolScratchTicketCellData> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack(this.CellData);
		}

		// Token: 0x060384CF RID: 230607 RVA: 0x00FBDE83 File Offset: 0x00FBC083
		public void SetClickCallback(Action<SolarSchoolScratchTicketCellData> callback)
		{
			this.ClickCallBack = callback;
		}

		// Token: 0x060384D0 RID: 230608 RVA: 0x00FBDE8C File Offset: 0x00FBC08C
		[NullableContext(2)]
		private bool CanRewardItemChangeToggle(object data, bool isForcedSelect, EToggleState toggleState)
		{
			return false;
		}

		// Token: 0x0401DA4E RID: 121422
		[Nullable(2)]
		private SolarSchoolScratchTicketCellData CellData;

		// Token: 0x0401DA4F RID: 121423
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<SolarSchoolScratchTicketCellData> ClickCallBack;

		// Token: 0x0401DA50 RID: 121424
		[Nullable(2)]
		public UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x0401DA51 RID: 121425
		[Nullable(2)]
		private SmallItemGrid ItemGrid;

		// Token: 0x0401DA52 RID: 121426
		private readonly Action<MediumItemGridExtendCallback> OnRewardItemClick = delegate(MediumItemGridExtendCallback callbackParameter)
		{
		};

		// Token: 0x0200B4F8 RID: 46328
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04037F51 RID: 229201
			public const int RewardButton = 0;

			// Token: 0x04037F52 RID: 229202
			public const int BgIcon = 1;

			// Token: 0x04037F53 RID: 229203
			public const int RewardRoot = 2;

			// Token: 0x04037F54 RID: 229204
			public const int ReceivedItem = 3;
		}
	}
}
