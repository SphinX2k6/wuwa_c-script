using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

// Token: 0x020017D9 RID: 6105
[NullableContext(1)]
[Nullable(0)]
public class OnlineSearchView : UiTickViewBase
{
	// Token: 0x0600EEE7 RID: 61159 RVA: 0x00461FB6 File Offset: 0x004601B6
	public OnlineSearchView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EEE8 RID: 61160 RVA: 0x00461FC0 File Offset: 0x004601C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITextInputComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickSearchConfirmBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600EEE9 RID: 61161 RVA: 0x004620EC File Offset: 0x004602EC
	protected override void OnStart()
	{
		this.FunctionButtonItem = new ButtonAndSpriteItem(base.GetItem(1));
		this.FunctionButtonItem.BindCallback(new Action(this.OnClickClearSearchInputBtn));
		UUIItem item = base.GetItem(4);
		this.ResultList = new LoopScrollView<OnlineHallItem, OnlineHallData>(base.GetLoopScrollViewComponent(3), item.GetOwner() as AUIBaseActor, new Func<OnlineHallItem>(this.ProxyCreateFunction), true);
		base.GetInputText(0).OnTextChange.Bind(new Action<string>(this.SetClearOrPaste));
		this.RefreshShow();
	}

	// Token: 0x0600EEEA RID: 61162 RVA: 0x00462177 File Offset: 0x00460377
	protected override void OnBeforeDestroy()
	{
		OnlineModel.Instance.CleanSearchResultList();
		base.GetInputText(0).OnTextChange.Unbind();
	}

	// Token: 0x0600EEEB RID: 61163 RVA: 0x00462194 File Offset: 0x00460394
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnSearchWorld, new Action<int>(this.CallBackSearchWorld));
	}

	// Token: 0x0600EEEC RID: 61164 RVA: 0x004621B2 File Offset: 0x004603B2
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSearchWorld, new Action<int>(this.CallBackSearchWorld));
	}

	// Token: 0x0600EEED RID: 61165 RVA: 0x004621D0 File Offset: 0x004603D0
	private void RefreshShow()
	{
		this.ResultList.RefreshByData(OnlineModel.Instance.SearchResult, false, delegate
		{
			OnlineHallItem onlineHallItem = this.ResultList.UnsafeGetGridProxy(0, false);
			if (onlineHallItem == null)
			{
				return;
			}
			Log.Instance.Info(ELogModule.UiComponent, ELogAuthor.LJQ, "OnlineSearchView_Item_Alpha:" + onlineHallItem.GetRootItem().GetAlpha().ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}, true);
		this.RefreshUiComponents();
	}

	// Token: 0x0600EEEE RID: 61166 RVA: 0x004621FB File Offset: 0x004603FB
	private void RefreshUiComponents()
	{
		this.SetClearOrPaste(null);
		base.GetItem(5).SetUIActive(OnlineModel.Instance.SearchResult.Count <= 0);
	}

	// Token: 0x0600EEEF RID: 61167 RVA: 0x00462225 File Offset: 0x00460425
	private void CallBackSearchWorld(int i)
	{
		this.RefreshShow();
	}

	// Token: 0x0600EEF0 RID: 61168 RVA: 0x0046222D File Offset: 0x0046042D
	private OnlineHallItem ProxyCreateFunction()
	{
		return new OnlineHallItem(this.ViewInfo.Name);
	}

	// Token: 0x0600EEF1 RID: 61169 RVA: 0x00462240 File Offset: 0x00460440
	private void OnClickClearSearchInputBtn()
	{
		UUITextInputComponent inputText = base.GetInputText(0);
		if (inputText.GetText() == "")
		{
			if (Platform.Instance.IsCloudGame())
			{
				string pasteTarget = "";
				UKuroCloudGameWrapper.ClipBoardPaste();
				TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					ULGUIBPLibrary.ClipBoardPaste(ref pasteTarget);
					inputText.SetText(pasteTarget, false);
				}, 200f, null, null, true, 1f);
			}
			else
			{
				string inText = "";
				ULGUIBPLibrary.ClipBoardPaste(ref inText);
				inputText.SetText(inText, false);
			}
		}
		else
		{
			inputText.SetText("", false);
		}
		this.SetClearOrPaste(null);
	}

	// Token: 0x0600EEF2 RID: 61170 RVA: 0x004622ED File Offset: 0x004604ED
	private void SetClearOrPaste(string _)
	{
		if (base.GetInputText(0).GetText() == "")
		{
			this.FunctionButtonItem.RefreshSprite("SP_Paste");
			return;
		}
		this.FunctionButtonItem.RefreshSprite("SP_Clear");
	}

	// Token: 0x0600EEF3 RID: 61171 RVA: 0x00462328 File Offset: 0x00460528
	private void OnClickSearchConfirmBtn()
	{
		string text = base.GetInputText(0).GetText();
		if (text.Length > 0)
		{
			OnlineController.Instance.LobbyQueryPlayersRequest(int.Parse(text));
			return;
		}
		GenericPromptController.Instance.ShowPromptByCode("OnlineInvalidUserId", Array.Empty<object>());
	}

	// Token: 0x0400871D RID: 34589
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<OnlineHallItem, OnlineHallData> ResultList;

	// Token: 0x0400871E RID: 34590
	[Nullable(2)]
	private ButtonAndSpriteItem FunctionButtonItem;

	// Token: 0x020079FA RID: 31226
	[NullableContext(0)]
	private enum EOnlineSearchViewComponents
	{
		// Token: 0x0402789F RID: 161951
		SearchUIDTextInput,
		// Token: 0x040278A0 RID: 161952
		UIDClearOrPasteBtn,
		// Token: 0x040278A1 RID: 161953
		SearchConfirmBtn,
		// Token: 0x040278A2 RID: 161954
		ResultListLoopScrollView,
		// Token: 0x040278A3 RID: 161955
		ResultModelItem,
		// Token: 0x040278A4 RID: 161956
		ResultEmptyText
	}
}
