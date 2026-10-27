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

// Token: 0x020022F5 RID: 8949
[NullableContext(1)]
[Nullable(0)]
public class OnlineSearchView : UiTickViewBase
{
	// Token: 0x06011A4F RID: 72271 RVA: 0x004552EA File Offset: 0x004534EA
	public OnlineSearchView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011A50 RID: 72272 RVA: 0x004552F4 File Offset: 0x004534F4
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

	// Token: 0x06011A51 RID: 72273 RVA: 0x00455420 File Offset: 0x00453620
	protected override void OnStart()
	{
		this.FunctionButtonItem = new ButtonAndSpriteItem(base.GetItem(1));
		this.FunctionButtonItem.BindCallback(new Action(this.OnClickClearSearchInputBtn));
		UUIItem item = base.GetItem(4);
		this.ResultList = new LoopScrollView<OnlineHallItem, OnlineHallData>(base.GetLoopScrollViewComponent(3), item.GetOwner() as AUIBaseActor, new Func<OnlineHallItem>(this.ProxyCreateFunction), true);
		base.GetInputText(0).OnTextChange.Bind(new Action<string>(this.SetClearOrPaste));
		this.RefreshShow();
	}

	// Token: 0x06011A52 RID: 72274 RVA: 0x004554AB File Offset: 0x004536AB
	protected override void OnBeforeDestroy()
	{
		OnlineModel.Instance.CleanSearchResultList();
		base.GetInputText(0).OnTextChange.Unbind();
	}

	// Token: 0x06011A53 RID: 72275 RVA: 0x004554C8 File Offset: 0x004536C8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnSearchWorld, new Action<int>(this.CallBackSearchWorld));
	}

	// Token: 0x06011A54 RID: 72276 RVA: 0x004554E6 File Offset: 0x004536E6
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSearchWorld, new Action<int>(this.CallBackSearchWorld));
	}

	// Token: 0x06011A55 RID: 72277 RVA: 0x00455504 File Offset: 0x00453704
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

	// Token: 0x06011A56 RID: 72278 RVA: 0x0045552F File Offset: 0x0045372F
	private void RefreshUiComponents()
	{
		this.SetClearOrPaste(null);
		base.GetItem(5).SetUIActive(OnlineModel.Instance.SearchResult.Count <= 0);
	}

	// Token: 0x06011A57 RID: 72279 RVA: 0x00455559 File Offset: 0x00453759
	private void CallBackSearchWorld(int i)
	{
		this.RefreshShow();
	}

	// Token: 0x06011A58 RID: 72280 RVA: 0x00455561 File Offset: 0x00453761
	private OnlineHallItem ProxyCreateFunction()
	{
		return new OnlineHallItem(this.ViewInfo.Name);
	}

	// Token: 0x06011A59 RID: 72281 RVA: 0x00455574 File Offset: 0x00453774
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

	// Token: 0x06011A5A RID: 72282 RVA: 0x00455621 File Offset: 0x00453821
	private void SetClearOrPaste(string _)
	{
		if (base.GetInputText(0).GetText() == "")
		{
			this.FunctionButtonItem.RefreshSprite("SP_Paste");
			return;
		}
		this.FunctionButtonItem.RefreshSprite("SP_Clear");
	}

	// Token: 0x06011A5B RID: 72283 RVA: 0x0045565C File Offset: 0x0045385C
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

	// Token: 0x040085DF RID: 34271
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<OnlineHallItem, OnlineHallData> ResultList;

	// Token: 0x040085E0 RID: 34272
	[Nullable(2)]
	private ButtonAndSpriteItem FunctionButtonItem;

	// Token: 0x02008876 RID: 34934
	[NullableContext(0)]
	private enum EOnlineSearchViewComponents
	{
		// Token: 0x0402C59D RID: 181661
		SearchUIDTextInput,
		// Token: 0x0402C59E RID: 181662
		UIDClearOrPasteBtn,
		// Token: 0x0402C59F RID: 181663
		SearchConfirmBtn,
		// Token: 0x0402C5A0 RID: 181664
		ResultListLoopScrollView,
		// Token: 0x0402C5A1 RID: 181665
		ResultModelItem,
		// Token: 0x0402C5A2 RID: 181666
		ResultEmptyText
	}
}
