using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200207E RID: 8318
[NullableContext(1)]
[Nullable(0)]
public class LoadingView : LoadingViewBase
{
	// Token: 0x06010610 RID: 67088 RVA: 0x003FE6EE File Offset: 0x003FC8EE
	public LoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010611 RID: 67089 RVA: 0x003FE6F8 File Offset: 0x003FC8F8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(base.ChangeShowTips));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06010612 RID: 67090 RVA: 0x003FE8A8 File Offset: 0x003FCAA8
	protected override void OnStart()
	{
		this.FillWidth = base.GetItem(9).Width;
		base.OnStart();
		base.GetButton(4).RootUIComp.Get().SetUIActive(this.ShowData.GetTipCount() > 1);
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetAlpha(1f);
	}

	// Token: 0x06010613 RID: 67091 RVA: 0x003FE90A File Offset: 0x003FCB0A
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		this.InitContent();
	}

	// Token: 0x06010614 RID: 67092 RVA: 0x003FE918 File Offset: 0x003FCB18
	private void InitContent()
	{
		UUILayoutBase layout = base.GetLayoutBase(7);
		UUILayoutBase layout5 = layout;
		if (layout5 != null)
		{
			UUIItem rootComponent = layout5.GetRootComponent();
			if (rootComponent != null)
			{
				rootComponent.SetAlpha(0f);
			}
		}
		UUILayoutBase layout2 = layout;
		if (layout2 == null)
		{
			return;
		}
		layout2.OnLateUpdate.Bind(delegate(float _)
		{
			UUILayoutBase layout3 = layout;
			if (layout3 != null)
			{
				layout3.OnLateUpdate.Unbind();
			}
			UUILayoutBase layout4 = layout;
			if (layout4 == null)
			{
				return;
			}
			UUIItem rootComponent2 = layout4.GetRootComponent();
			if (rootComponent2 == null)
			{
				return;
			}
			rootComponent2.SetAlpha(1f);
		});
	}

	// Token: 0x06010615 RID: 67093 RVA: 0x003FE97A File Offset: 0x003FCB7A
	protected override void UpdateShowTipsUi(string title, string tips)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), tips, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), title, Array.Empty<object>());
	}

	// Token: 0x06010616 RID: 67094 RVA: 0x003FE9AC File Offset: 0x003FCBAC
	protected override void UpdateProgressRate(float rate)
	{
		base.SetTextureProgressRate(0, rate);
		float anchorOffsetX = this.FillWidth * rate;
		UUIItem item = base.GetItem(8);
		if (item == null)
		{
			return;
		}
		item.SetAnchorOffsetX(anchorOffsetX);
	}

	// Token: 0x06010617 RID: 67095 RVA: 0x003FE9DC File Offset: 0x003FCBDC
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(5, value, "");
	}

	// Token: 0x06010618 RID: 67096 RVA: 0x003FE9EB File Offset: 0x003FCBEB
	protected override void UpdateBgUi(string path)
	{
		base.SetTextureByPath(path, base.GetTexture(3), new EUiViewName?(this.ViewInfo.Name), null);
	}

	// Token: 0x040078FA RID: 30970
	private float FillWidth;

	// Token: 0x02008666 RID: 34406
	[NullableContext(0)]
	[StaticVariableRuleIgnore]
	public static class EChildType
	{
		// Token: 0x0402BBA0 RID: 179104
		public const int Progress = 0;

		// Token: 0x0402BBA1 RID: 179105
		public const int Tips = 1;

		// Token: 0x0402BBA2 RID: 179106
		public const int Title = 2;

		// Token: 0x0402BBA3 RID: 179107
		public const int BgTexture = 3;

		// Token: 0x0402BBA4 RID: 179108
		public const int NextButton = 4;

		// Token: 0x0402BBA5 RID: 179109
		public const int ProgressText = 5;

		// Token: 0x0402BBA6 RID: 179110
		public const int TypeSprite = 6;

		// Token: 0x0402BBA7 RID: 179111
		public const int Layout = 7;

		// Token: 0x0402BBA8 RID: 179112
		public const int MoveHandle = 8;

		// Token: 0x0402BBA9 RID: 179113
		public const int MoveHandleFollowTarget = 9;
	}
}
