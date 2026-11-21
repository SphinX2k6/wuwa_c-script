using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02001B6D RID: 7021
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewNodeNormalItem : QuestReviewNodeItemBase
{
	// Token: 0x0601181F RID: 71711 RVA: 0x00529149 File Offset: 0x00527349
	public QuestReviewNodeNormalItem(UUIItem redDot)
	{
		this.RedDot = redDot;
	}

	// Token: 0x06011820 RID: 71712 RVA: 0x00529158 File Offset: 0x00527358
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(13, new Action<EToggleState>(this.OnToggleNodeClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011821 RID: 71713 RVA: 0x005293B3 File Offset: 0x005275B3
	protected override void OnStart()
	{
		EventSystem.Instance.Add<int>(EEventName.OnOpenQuestReviewDetail, new Action<int>(this.OnOpenQuestReviewDetail));
	}

	// Token: 0x06011822 RID: 71714 RVA: 0x005293D1 File Offset: 0x005275D1
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnOpenQuestReviewDetail, new Action<int>(this.OnOpenQuestReviewDetail));
	}

	// Token: 0x06011823 RID: 71715 RVA: 0x005293F0 File Offset: 0x005275F0
	public override void Refresh(IQuestReviewNodeParam param)
	{
		this.Data = param.Data;
		base.GetRootItem().SetAlpha(1f);
		this.SpriteLineHorizontal.SetAlpha(0.5f);
		this.SpriteLineVertical.SetAlpha(0.5f);
		base.SetTextureByPath(this.Data.ImageSmall, base.GetTexture(0), null, null);
		base.SetTextureByPath(this.Data.ImageSmall, base.GetTexture(14), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.Data.TitleId, Array.Empty<object>());
		base.GetItem(8).SetUIActive(this.Data.LineType == EQuestReviewNodeLineType.Dotted);
		base.GetItem(9).SetUIActive(this.Data.LineType == EQuestReviewNodeLineType.Solid);
		int num = this.Data.IsBranching ? 320 : 50;
		this.SpriteLineVertical.SetHeight((float)num);
		this.SpriteLineVertical.SetUIActive(this.Data.IsBranching);
		base.GetSprite(4).SetUIActive(!param.IsLastSlotEmpty);
		this.SetSpriteByPath(param.RoundIcon, base.GetSprite(4), false, null, null);
		this.RefreshLineColor(param);
		QuestReviewLineData questReviewLineDataById = QuestReviewModel.Instance.GetQuestReviewLineDataById(param.LineId);
		this.RedDot.SetUIActive(param.Data.HasRedDot && !questReviewLineDataById.IsDestroy);
	}

	// Token: 0x06011824 RID: 71716 RVA: 0x0052957D File Offset: 0x0052777D
	public void SetToggleInteractive(bool interactive)
	{
		base.GetExtendToggle(13).SetSelfInteractive(interactive);
	}

	// Token: 0x17001A2E RID: 6702
	// (get) Token: 0x06011825 RID: 71717 RVA: 0x0052958D File Offset: 0x0052778D
	private UUISprite SpriteLineVertical
	{
		get
		{
			if (this.Data.LineType == EQuestReviewNodeLineType.Solid)
			{
				return base.GetSprite(2);
			}
			return base.GetSprite(12);
		}
	}

	// Token: 0x17001A2F RID: 6703
	// (get) Token: 0x06011826 RID: 71718 RVA: 0x005295AC File Offset: 0x005277AC
	private UUISprite SpriteLineHorizontal
	{
		get
		{
			if (this.Data.LineType == EQuestReviewNodeLineType.Solid)
			{
				return base.GetSprite(1);
			}
			return base.GetSprite(10);
		}
	}

	// Token: 0x17001A30 RID: 6704
	// (get) Token: 0x06011827 RID: 71719 RVA: 0x005295CB File Offset: 0x005277CB
	private UUISprite SpriteLineRound
	{
		get
		{
			if (this.Data.LineType == EQuestReviewNodeLineType.Solid)
			{
				return base.GetSprite(6);
			}
			return base.GetSprite(11);
		}
	}

	// Token: 0x06011828 RID: 71720 RVA: 0x005295EC File Offset: 0x005277EC
	private void RefreshLineColor(IQuestReviewNodeParam param)
	{
		this.SpriteLineVertical.SetColor(FColor.FromHex(param.LineColorHex));
		this.SpriteLineHorizontal.SetColor(FColor.FromHex(param.LineColorHex));
		this.SpriteLineRound.SetColor(FColor.FromHex(param.LineColorHex));
	}

	// Token: 0x06011829 RID: 71721 RVA: 0x0052963C File Offset: 0x0052783C
	private void OnToggleNodeClick(EToggleState toggleState)
	{
		QuestReviewController.Instance.OpenQuestNodeDetail(this.Data.Id);
		base.GetExtendToggle(13).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.Data.HasRedDot = false;
		this.RedDot.SetUIActive(false);
	}

	// Token: 0x0601182A RID: 71722 RVA: 0x00529688 File Offset: 0x00527888
	private void OnOpenQuestReviewDetail(int nodeId)
	{
		QuestReviewNodeData data = this.Data;
		if (data != null && data.Id == nodeId)
		{
			this.RedDot.SetUIActive(false);
		}
	}

	// Token: 0x04009966 RID: 39270
	private QuestReviewNodeData Data;

	// Token: 0x04009967 RID: 39271
	private UUIItem RedDot;

	// Token: 0x02007E5C RID: 32348
	[NullableContext(0)]
	private class ENodeNormalComponentDefine
	{
		// Token: 0x04028E3C RID: 167484
		public const int TextureQuest = 0;

		// Token: 0x04028E3D RID: 167485
		public const int SpriteLineHorizontalSolid = 1;

		// Token: 0x04028E3E RID: 167486
		public const int SpriteLineVerticalSolid = 2;

		// Token: 0x04028E3F RID: 167487
		public const int TextDesc = 3;

		// Token: 0x04028E40 RID: 167488
		public const int SpriteStartPoint = 4;

		// Token: 0x04028E41 RID: 167489
		public const int SpriteEndPoint = 5;

		// Token: 0x04028E42 RID: 167490
		public const int SpriteLineRoundSolid = 6;

		// Token: 0x04028E43 RID: 167491
		public const int SpriteDescLabel = 7;

		// Token: 0x04028E44 RID: 167492
		public const int ItemLineDotted = 8;

		// Token: 0x04028E45 RID: 167493
		public const int ItemLineSolid = 9;

		// Token: 0x04028E46 RID: 167494
		public const int SpriteLineHorizontalDotted = 10;

		// Token: 0x04028E47 RID: 167495
		public const int SpriteLineRoundDotted = 11;

		// Token: 0x04028E48 RID: 167496
		public const int SpriteLineVerticalDotted = 12;

		// Token: 0x04028E49 RID: 167497
		public const int ToggleNode = 13;

		// Token: 0x04028E4A RID: 167498
		public const int TextureSeq = 14;
	}
}
