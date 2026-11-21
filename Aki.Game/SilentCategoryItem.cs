using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B71 RID: 2929
public class SilentCategoryItem : UiPanelBase
{
	// Token: 0x060079DB RID: 31195 RVA: 0x0025BE62 File Offset: 0x0025A062
	[NullableContext(1)]
	public SilentCategoryItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060079DC RID: 31196 RVA: 0x0025BE78 File Offset: 0x0025A078
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

	// Token: 0x060079DD RID: 31197 RVA: 0x0025BF60 File Offset: 0x0025A160
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

	// Token: 0x060079DE RID: 31198 RVA: 0x0025BFC2 File Offset: 0x0025A1C2
	protected override void OnBeforeDestroy()
	{
		this.UnbindRedDot();
		this.Data = null;
		this.ExtendToggle.OnPostAudioEvent.Unbind();
		this.ExtendToggle.OnPostAudioStateEvent.Unbind();
	}

	// Token: 0x060079DF RID: 31199 RVA: 0x0025BFF4 File Offset: 0x0025A1F4
	[NullableContext(1)]
	public void Update(ISilentAreaTitleData data, bool isShow)
	{
		this.Data = data;
		this.IsShowingSilentCategoryItem = isShow;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.Data.TitleName, Array.Empty<object>());
		base.GetExtendToggle(0).SetToggleState(this.IsShowingSilentCategoryItem ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		this.BindRedDot();
	}

	// Token: 0x060079E0 RID: 31200 RVA: 0x0025C052 File Offset: 0x0025A252
	private void BindRedDot()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.AdventureFirstAwardCategory, base.GetItem(3), null, this.Data.TypeDescription);
	}

	// Token: 0x060079E1 RID: 31201 RVA: 0x0025C073 File Offset: 0x0025A273
	private void UnbindRedDot()
	{
		if (this.Data == null)
		{
			return;
		}
		RedDotController.Instance.UnBindGivenUi(ERedDotName.AdventureFirstAwardCategory, base.GetItem(3), this.Data.TypeDescription);
	}

	// Token: 0x060079E2 RID: 31202 RVA: 0x0025C09C File Offset: 0x0025A29C
	public void RefreshRedDot(bool isShow)
	{
		base.GetItem(3).SetUIActive(isShow);
	}

	// Token: 0x060079E3 RID: 31203 RVA: 0x0025C0AB File Offset: 0x0025A2AB
	public void BindCategoryCallback([Nullable(new byte[]
	{
		2,
		1
	})] Action<int, UUIExtendToggle, bool> onCategoryCallback)
	{
		this.CategoryCallback = onCategoryCallback;
	}

	// Token: 0x060079E4 RID: 31204 RVA: 0x0025C0B4 File Offset: 0x0025A2B4
	public void OnClickExtendToggle(EToggleState state)
	{
		this.IsShowingSilentCategoryItem = !this.IsShowingSilentCategoryItem;
		if (this.CategoryCallback != null)
		{
			this.CategoryCallback(this.Data.TypeDescription, this.ExtendToggle, this.IsShowingSilentCategoryItem);
		}
	}

	// Token: 0x04004B9D RID: 19357
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x04004B9E RID: 19358
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle, bool> CategoryCallback;

	// Token: 0x04004B9F RID: 19359
	[Nullable(2)]
	private ISilentAreaTitleData Data;

	// Token: 0x04004BA0 RID: 19360
	private bool IsShowingSilentCategoryItem;

	// Token: 0x02006E12 RID: 28178
	private enum ESilentCategoryDefine
	{
		// Token: 0x040240FC RID: 147708
		ExtendToggle,
		// Token: 0x040240FD RID: 147709
		TitleText,
		// Token: 0x040240FE RID: 147710
		FlagSprite,
		// Token: 0x040240FF RID: 147711
		RedDotItem
	}
}
