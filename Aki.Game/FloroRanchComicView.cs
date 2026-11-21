using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200101B RID: 4123
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchComicView : UiViewBase
{
	// Token: 0x0600A3ED RID: 41965 RVA: 0x00300E58 File Offset: 0x002FF058
	public FloroRanchComicView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A3EE RID: 41966 RVA: 0x00300EB8 File Offset: 0x002FF0B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnNextBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnSkipBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnCloseBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A3EF RID: 41967 RVA: 0x00300FE8 File Offset: 0x002FF1E8
	protected override void OnStart()
	{
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		UUIButtonComponent button2 = base.GetButton(0);
		if (button2 != null)
		{
			button2.SetSelfInteractive(false);
		}
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600A3F0 RID: 41968 RVA: 0x0030103C File Offset: 0x002FF23C
	protected override void OnAfterShow()
	{
		if (this.ViewInfo.Name == EUiViewName.FloroRanchComicView4)
		{
			FloroRanchController.Instance.RequestComicRead();
		}
		int comicIntervalTime = FloroRanchModel.Instance.GetActivityData(EFloroRanchActivityDataType.Normal, true).GetFloroRanchParamConfig().ComicIntervalTime;
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(true);
			}
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
		}, (float)comicIntervalTime, null, null, true, 1f);
	}

	// Token: 0x0600A3F1 RID: 41969 RVA: 0x003010A8 File Offset: 0x002FF2A8
	protected void OnNextBtnClick()
	{
		EUiViewName openViewName;
		if (this.NextViewMap.TryGetValue(this.ViewInfo.Name, out openViewName))
		{
			UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, openViewName, null, null, true);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanch;
		ELogAuthor author = ELogAuthor.CXJ;
		string message = "弗洛洛漫画缺少下一个界面的声明";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", this.ViewInfo.Name);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600A3F2 RID: 41970 RVA: 0x00301124 File Offset: 0x002FF324
	protected void OnSkipBtnClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FloroRanchSkipComic);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			FloroRanchController.Instance.RequestComicRead();
			this.OnCloseBtnClick();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600A3F3 RID: 41971 RVA: 0x00301160 File Offset: 0x002FF360
	protected void OnCloseBtnClick()
	{
		UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, EUiViewName.FloroRanchMainView, null, null, true);
	}

	// Token: 0x04006057 RID: 24663
	private readonly Dictionary<EUiViewName, EUiViewName> NextViewMap = new Dictionary<EUiViewName, EUiViewName>
	{
		{
			EUiViewName.FloroRanchComicView,
			EUiViewName.FloroRanchComicView2
		},
		{
			EUiViewName.FloroRanchComicView2,
			EUiViewName.FloroRanchComicView3
		},
		{
			EUiViewName.FloroRanchComicView3,
			EUiViewName.FloroRanchComicView4
		},
		{
			EUiViewName.FloroRanchComicView4,
			EUiViewName.FloroRanchMainView
		}
	};

	// Token: 0x04006058 RID: 24664
	protected TimerHandle TimerHandle;

	// Token: 0x0200723D RID: 29245
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040252C2 RID: 152258
		public const int BtnNext = 0;

		// Token: 0x040252C3 RID: 152259
		public const int BtnSkip = 1;

		// Token: 0x040252C4 RID: 152260
		public const int BtnClose = 2;

		// Token: 0x040252C5 RID: 152261
		public const int ItemNextPanel = 3;
	}
}
