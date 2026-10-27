using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BFB RID: 11259
public class TowerGuideView : UiViewBase
{
	// Token: 0x0601762C RID: 95788 RVA: 0x005F356E File Offset: 0x005F176E
	[NullableContext(1)]
	public TowerGuideView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601762D RID: 95789 RVA: 0x005F3578 File Offset: 0x005F1778
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

	// Token: 0x0601762E RID: 95790 RVA: 0x005F37D2 File Offset: 0x005F19D2
	private void OnClickedCloseButton()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, true);
		}
		base.CloseMe(null);
	}

	// Token: 0x0601762F RID: 95791 RVA: 0x005F37F0 File Offset: 0x005F19F0
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

	// Token: 0x06017630 RID: 95792 RVA: 0x005F38B2 File Offset: 0x005F1AB2
	protected override void OnAfterDestroy()
	{
		EventSystem.Instance.Emit(EEventName.OnTowerGuideClose);
	}

	// Token: 0x0400AEF8 RID: 44792
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020091BF RID: 37311
	private enum EChildType
	{
		// Token: 0x0402F274 RID: 193140
		SpriteIcon,
		// Token: 0x0402F275 RID: 193141
		TxtTitle,
		// Token: 0x0402F276 RID: 193142
		BtnBack,
		// Token: 0x0402F277 RID: 193143
		ItemMid,
		// Token: 0x0402F278 RID: 193144
		ItemBottom,
		// Token: 0x0402F279 RID: 193145
		LayoutPages,
		// Token: 0x0402F27A RID: 193146
		UiItemPagesDot,
		// Token: 0x0402F27B RID: 193147
		BtnArrowL,
		// Token: 0x0402F27C RID: 193148
		BtnArrowR,
		// Token: 0x0402F27D RID: 193149
		ItemTutorialsTips,
		// Token: 0x0402F27E RID: 193150
		UiItemLayerBg,
		// Token: 0x0402F27F RID: 193151
		UiItemLayerUi,
		// Token: 0x0402F280 RID: 193152
		PageParent,
		// Token: 0x0402F281 RID: 193153
		BtnBg,
		// Token: 0x0402F282 RID: 193154
		DescItem
	}
}
