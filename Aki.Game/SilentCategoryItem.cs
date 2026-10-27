using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016B9 RID: 5817
public class SilentCategoryItem : UiPanelBase
{
	// Token: 0x0600A5FB RID: 42491 RVA: 0x00251A52 File Offset: 0x0024FC52
	[NullableContext(1)]
	public SilentCategoryItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A5FC RID: 42492 RVA: 0x00251A68 File Offset: 0x0024FC68
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickExtendToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A5FD RID: 42493 RVA: 0x00251B50 File Offset: 0x0024FD50
	protected override void OnStart()
	{
		this.ExtendToggle = base.GetExtendToggle(0);
		this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.ExtendToggle.OnPostAudioEvent.Bind(delegate(string eventPath)
		{
			if (!string.IsNullOrEmpty(eventPath))
			{
				base.PostClickAudioEvent(eventPath);
			}
		});
		this.ExtendToggle.OnPostAudioStateEvent.Bind(delegate(EToggleAudioTransitionState state, string eventPath)
		{
			if (!string.IsNullOrEmpty(eventPath))
			{
				base.PostClickAudioEvent(eventPath);
			}
		});
	}

	// Token: 0x0600A5FE RID: 42494 RVA: 0x00251BB2 File Offset: 0x0024FDB2
	protected override void OnBeforeDestroy()
	{
		this.UnbindRedDot();
		this.Data = null;
		this.ExtendToggle.OnPostAudioEvent.Unbind();
		this.ExtendToggle.OnPostAudioStateEvent.Unbind();
	}

	// Token: 0x0600A5FF RID: 42495 RVA: 0x00251BE4 File Offset: 0x0024FDE4
	[NullableContext(1)]
	public void Update(ISilentAreaTitleData data, bool isShow)
	{
		this.Data = data;
		this.IsShowingSilentCategoryItem = isShow;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.Data.TitleName, Array.Empty<object>());
		base.GetExtendToggle(0).SetToggleState(this.IsShowingSilentCategoryItem ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		this.BindRedDot();
	}

	// Token: 0x0600A600 RID: 42496 RVA: 0x00251C42 File Offset: 0x0024FE42
	private void BindRedDot()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.AdventureFirstAwardCategory, base.GetItem(3), null, this.Data.TypeDescription);
	}

	// Token: 0x0600A601 RID: 42497 RVA: 0x00251C63 File Offset: 0x0024FE63
	private void UnbindRedDot()
	{
		if (this.Data == null)
		{
			return;
		}
		RedDotController.Instance.UnBindGivenUi(ERedDotName.AdventureFirstAwardCategory, base.GetItem(3), this.Data.TypeDescription);
	}

	// Token: 0x0600A602 RID: 42498 RVA: 0x00251C8C File Offset: 0x0024FE8C
	public void RefreshRedDot(bool isShow)
	{
		base.GetItem(3).SetUIActive(isShow);
	}

	// Token: 0x0600A603 RID: 42499 RVA: 0x00251C9B File Offset: 0x0024FE9B
	public void BindCategoryCallback([Nullable(new byte[]
	{
		2,
		1
	})] Action<int, UUIExtendToggle, bool> onCategoryCallback)
	{
		this.CategoryCallback = onCategoryCallback;
	}

	// Token: 0x0600A604 RID: 42500 RVA: 0x00251CA4 File Offset: 0x0024FEA4
	public void OnClickExtendToggle(EToggleState state)
	{
		this.IsShowingSilentCategoryItem = !this.IsShowingSilentCategoryItem;
		if (this.CategoryCallback != null)
		{
			this.CategoryCallback(this.Data.TypeDescription, this.ExtendToggle, this.IsShowingSilentCategoryItem);
		}
	}

	// Token: 0x04004AF6 RID: 19190
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x04004AF7 RID: 19191
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle, bool> CategoryCallback;

	// Token: 0x04004AF8 RID: 19192
	[Nullable(2)]
	private ISilentAreaTitleData Data;

	// Token: 0x04004AF9 RID: 19193
	private bool IsShowingSilentCategoryItem;

	// Token: 0x02007C8D RID: 31885
	private enum ESilentCategoryDefine
	{
		// Token: 0x04028DD3 RID: 167379
		ExtendToggle,
		// Token: 0x04028DD4 RID: 167380
		TitleText,
		// Token: 0x04028DD5 RID: 167381
		FlagSprite,
		// Token: 0x04028DD6 RID: 167382
		RedDotItem
	}
}
