using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002682 RID: 9858
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewNodeNormalItem : QuestReviewNodeItemBase
{
	// Token: 0x0601433D RID: 82749 RVA: 0x0051A411 File Offset: 0x00518611
	public QuestReviewNodeNormalItem(UUIItem redDot)
	{
		this.RedDot = redDot;
	}

	// Token: 0x0601433E RID: 82750 RVA: 0x0051A420 File Offset: 0x00518620
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

	// Token: 0x0601433F RID: 82751 RVA: 0x0051A67B File Offset: 0x0051887B
	protected override void OnStart()
	{
		EventSystem.Instance.Add<int>(EEventName.OnOpenQuestReviewDetail, new Action<int>(this.OnOpenQuestReviewDetail));
	}

	// Token: 0x06014340 RID: 82752 RVA: 0x0051A699 File Offset: 0x00518899
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnOpenQuestReviewDetail, new Action<int>(this.OnOpenQuestReviewDetail));
	}

	// Token: 0x06014341 RID: 82753 RVA: 0x0051A6B8 File Offset: 0x005188B8
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

	// Token: 0x06014342 RID: 82754 RVA: 0x0051A845 File Offset: 0x00518A45
	public void SetToggleInteractive(bool interactive)
	{
		base.GetExtendToggle(13).SetSelfInteractive(interactive);
	}

	// Token: 0x170019F6 RID: 6646
	// (get) Token: 0x06014343 RID: 82755 RVA: 0x0051A855 File Offset: 0x00518A55
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

	// Token: 0x170019F7 RID: 6647
	// (get) Token: 0x06014344 RID: 82756 RVA: 0x0051A874 File Offset: 0x00518A74
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

	// Token: 0x170019F8 RID: 6648
	// (get) Token: 0x06014345 RID: 82757 RVA: 0x0051A893 File Offset: 0x00518A93
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

	// Token: 0x06014346 RID: 82758 RVA: 0x0051A8B4 File Offset: 0x00518AB4
	private void RefreshLineColor(IQuestReviewNodeParam param)
	{
		this.SpriteLineVertical.SetColor(FColor.FromHex(param.LineColorHex));
		this.SpriteLineHorizontal.SetColor(FColor.FromHex(param.LineColorHex));
		this.SpriteLineRound.SetColor(FColor.FromHex(param.LineColorHex));
	}

	// Token: 0x06014347 RID: 82759 RVA: 0x0051A904 File Offset: 0x00518B04
	private void OnToggleNodeClick(EToggleState toggleState)
	{
		QuestReviewController.Instance.OpenQuestNodeDetail(this.Data.Id);
		base.GetExtendToggle(13).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.Data.HasRedDot = false;
		this.RedDot.SetUIActive(false);
	}

	// Token: 0x06014348 RID: 82760 RVA: 0x0051A950 File Offset: 0x00518B50
	private void OnOpenQuestReviewDetail(int nodeId)
	{
		QuestReviewNodeData data = this.Data;
		if (data != null && data.Id == nodeId)
		{
			this.RedDot.SetUIActive(false);
		}
	}

	// Token: 0x0400980E RID: 38926
	private QuestReviewNodeData Data;

	// Token: 0x0400980F RID: 38927
	private UUIItem RedDot;

	// Token: 0x02008CD3 RID: 36051
	[NullableContext(0)]
	private class ENodeNormalComponentDefine
	{
		// Token: 0x0402DB25 RID: 187173
		public const int TextureQuest = 0;

		// Token: 0x0402DB26 RID: 187174
		public const int SpriteLineHorizontalSolid = 1;

		// Token: 0x0402DB27 RID: 187175
		public const int SpriteLineVerticalSolid = 2;

		// Token: 0x0402DB28 RID: 187176
		public const int TextDesc = 3;

		// Token: 0x0402DB29 RID: 187177
		public const int SpriteStartPoint = 4;

		// Token: 0x0402DB2A RID: 187178
		public const int SpriteEndPoint = 5;

		// Token: 0x0402DB2B RID: 187179
		public const int SpriteLineRoundSolid = 6;

		// Token: 0x0402DB2C RID: 187180
		public const int SpriteDescLabel = 7;

		// Token: 0x0402DB2D RID: 187181
		public const int ItemLineDotted = 8;

		// Token: 0x0402DB2E RID: 187182
		public const int ItemLineSolid = 9;

		// Token: 0x0402DB2F RID: 187183
		public const int SpriteLineHorizontalDotted = 10;

		// Token: 0x0402DB30 RID: 187184
		public const int SpriteLineRoundDotted = 11;

		// Token: 0x0402DB31 RID: 187185
		public const int SpriteLineVerticalDotted = 12;

		// Token: 0x0402DB32 RID: 187186
		public const int ToggleNode = 13;

		// Token: 0x0402DB33 RID: 187187
		public const int TextureSeq = 14;
	}
}
