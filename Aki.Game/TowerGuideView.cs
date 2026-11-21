using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002176 RID: 8566
public class TowerGuideView : UiViewBase
{
	// Token: 0x0601505D RID: 86109 RVA: 0x006200A5 File Offset: 0x0061E2A5
	[NullableContext(1)]
	public TowerGuideView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601505E RID: 86110 RVA: 0x006200B0 File Offset: 0x0061E2B0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickedCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601505F RID: 86111 RVA: 0x0062030A File Offset: 0x0061E50A
	private void OnClickedCloseButton()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, true);
		}
		base.CloseMe(null);
	}

	// Token: 0x06015060 RID: 86112 RVA: 0x00620328 File Offset: 0x0061E528
	protected override void OnStart()
	{
		base.GetItem(14).SetUIActive(false);
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		new TowerGuidePanel().CreateThenShowByActorAsync(base.GetItem(3).GetOwner(), null, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "TowerGuideTitle", Array.Empty<object>());
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, true);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.PlayLevelSequenceByName("StartAtOnce", false, null, false);
		}
		base.GetButton(13).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06015061 RID: 86113 RVA: 0x006203EA File Offset: 0x0061E5EA
	protected override void OnAfterDestroy()
	{
		EventSystem.Instance.Emit(EEventName.OnTowerGuideClose);
	}

	// Token: 0x0400B2FD RID: 45821
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008402 RID: 33794
	private enum EChildType
	{
		// Token: 0x0402A975 RID: 174453
		SpriteIcon,
		// Token: 0x0402A976 RID: 174454
		TxtTitle,
		// Token: 0x0402A977 RID: 174455
		BtnBack,
		// Token: 0x0402A978 RID: 174456
		ItemMid,
		// Token: 0x0402A979 RID: 174457
		ItemBottom,
		// Token: 0x0402A97A RID: 174458
		LayoutPages,
		// Token: 0x0402A97B RID: 174459
		UiItemPagesDot,
		// Token: 0x0402A97C RID: 174460
		BtnArrowL,
		// Token: 0x0402A97D RID: 174461
		BtnArrowR,
		// Token: 0x0402A97E RID: 174462
		ItemTutorialsTips,
		// Token: 0x0402A97F RID: 174463
		UiItemLayerBg,
		// Token: 0x0402A980 RID: 174464
		UiItemLayerUi,
		// Token: 0x0402A981 RID: 174465
		PageParent,
		// Token: 0x0402A982 RID: 174466
		BtnBg,
		// Token: 0x0402A983 RID: 174467
		DescItem
	}
}
