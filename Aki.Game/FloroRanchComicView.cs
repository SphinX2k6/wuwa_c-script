using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B5C RID: 7004
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchComicView : UiViewBase
{
	// Token: 0x0600CFDC RID: 53212 RVA: 0x002F5D80 File Offset: 0x002F3F80
	public FloroRanchComicView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600CFDD RID: 53213 RVA: 0x002F5DE0 File Offset: 0x002F3FE0
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

	// Token: 0x0600CFDE RID: 53214 RVA: 0x002F5F10 File Offset: 0x002F4110
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

	// Token: 0x0600CFDF RID: 53215 RVA: 0x002F5F64 File Offset: 0x002F4164
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

	// Token: 0x0600CFE0 RID: 53216 RVA: 0x002F5FD0 File Offset: 0x002F41D0
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

	// Token: 0x0600CFE1 RID: 53217 RVA: 0x002F604C File Offset: 0x002F424C
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

	// Token: 0x0600CFE2 RID: 53218 RVA: 0x002F6088 File Offset: 0x002F4288
	protected void OnCloseBtnClick()
	{
		UiManager.Instance.CloseAndOpenView(this.ViewInfo.Name, EUiViewName.FloroRanchMainView, null, null, true);
	}

	// Token: 0x04005F88 RID: 24456
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

	// Token: 0x04005F89 RID: 24457
	protected TimerHandle TimerHandle;

	// Token: 0x020080AF RID: 32943
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04029F8E RID: 171918
		public const int BtnNext = 0;

		// Token: 0x04029F8F RID: 171919
		public const int BtnSkip = 1;

		// Token: 0x04029F90 RID: 171920
		public const int BtnClose = 2;

		// Token: 0x04029F91 RID: 171921
		public const int ItemNextPanel = 3;
	}
}
