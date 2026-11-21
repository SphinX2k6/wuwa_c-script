using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020004C9 RID: 1225
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingCodePanel : UiPanelBase
{
	// Token: 0x06003D33 RID: 15667 RVA: 0x0015A092 File Offset: 0x00158292
	public GolemHackingCodePanel(GolemHackingGameProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x06003D34 RID: 15668 RVA: 0x0015A0A8 File Offset: 0x001582A8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickedHelp));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickedReset));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06003D35 RID: 15669 RVA: 0x0015A2C1 File Offset: 0x001584C1
	protected override void OnStart()
	{
		this.InitLayout();
		this.InitGamePlay();
		this.InitInfo();
	}

	// Token: 0x06003D36 RID: 15670 RVA: 0x0015A2D8 File Offset: 0x001584D8
	protected void InitLayout()
	{
		this.CodeLayout = new GenericLayout<GolemHackingCodeKeyListItem, List<GolemHackingCodeGridInfo>>(base.GetVerticalLayout(0), new Func<GolemHackingCodeKeyListItem>(this.CreateCodePanelItem), null, false, true);
		this.IconLayout = new GenericLayout<GolemHackingCodeIconItem, EGolemHackingBarState>(base.GetVerticalLayout(3), new Func<GolemHackingCodeIconItem>(this.CreateIconItem), null, false, true);
		this.BarLayout = new GenericLayout<GolemHackingCodeKeyBarItem, EGolemHackingBarState>(base.GetVerticalLayout(5), new Func<GolemHackingCodeKeyBarItem>(this.CreateBarItem), null, false, true);
		this.InputLayout = new GenericLayout<GolemHackingCodeInputItem, GolemHackingInputInfo>(base.GetHorizontalLayout(8), new Func<GolemHackingCodeInputItem>(this.CreateInputItem), null, false, true);
	}

	// Token: 0x06003D37 RID: 15671 RVA: 0x0015A36C File Offset: 0x0015856C
	protected void InitGamePlay()
	{
		this.Proxy.ResetCodeCallback = new Action(this.OnResetCallBack);
		this.Proxy.HoverMatrixCallback = new Action<int, string>(this.OnMatrixHoverCallBack);
		this.Proxy.UnHoverMatrixCallback = new Action(this.OnMatrixUnHoverCallBack);
		this.Proxy.EnterCodeCallback = new Action<List<string>, List<GolemHackingCodeEnterResult>>(this.OnMatrixEnterCallBack);
	}

	// Token: 0x06003D38 RID: 15672 RVA: 0x0015A3D8 File Offset: 0x001585D8
	protected void InitInfo()
	{
		UUIButtonComponent button = base.GetButton(10);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(this.Proxy.NeedHelpBtn());
		}
		this.Proxy.InitCodePanelInfo();
	}

	// Token: 0x06003D39 RID: 15673 RVA: 0x0015A41C File Offset: 0x0015861C
	protected void RefreshEnterPanel(List<string> inputList, List<GolemHackingCodeEnterResult> codeParam)
	{
		int maxLength = this.Proxy.GetMaxLength();
		UUIText text = base.GetText(7);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(inputList.Count);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(maxLength);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		int num = Math.Min(inputList.Count, maxLength - 1);
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetAnchorOffsetX((float)(9 + num * 133));
		}
		List<GolemHackingInputInfo> inputDataList = this.GetInputDataList(inputList, codeParam);
		foreach (GolemHackingCodeKeyListItem golemHackingCodeKeyListItem in this.CodeLayout.GetLayoutItemList())
		{
			golemHackingCodeKeyListItem.OnMatrixUnHover();
		}
		this.InputLayout.RefreshByData(inputDataList, null, false);
	}

	// Token: 0x06003D3A RID: 15674 RVA: 0x0015A508 File Offset: 0x00158708
	protected List<GolemHackingInputInfo> GetInputDataList(List<string> inputList, List<GolemHackingCodeEnterResult> codeParam)
	{
		int maxLength = this.Proxy.GetMaxLength();
		List<GolemHackingInputInfo> list = new List<GolemHackingInputInfo>();
		bool isReset = this.Proxy.IsRestart && inputList.Count == 0;
		bool isFail = false;
		int num = 0;
		foreach (GolemHackingCodeEnterResult golemHackingCodeEnterResult in codeParam)
		{
			if (golemHackingCodeEnterResult.State == EGolemHackingBarState.Success)
			{
				num++;
			}
			else if (golemHackingCodeEnterResult.State == EGolemHackingBarState.Fail)
			{
				isFail = true;
				break;
			}
		}
		bool isSuccess = num == codeParam.Count;
		int animCount = 0;
		Action<GolemHackingInputInfo, int> action = delegate(GolemHackingInputInfo data, int index)
		{
			if (isSuccess | isFail | isReset)
			{
				data.AnimIndex = index + 1;
				if (isReset)
				{
					data.AnimName = "Reset";
					return;
				}
				int animCount;
				if (isSuccess)
				{
					animCount = animCount;
					animCount++;
					data.AnimName = "Success";
					return;
				}
				if (isFail)
				{
					animCount = animCount;
					animCount++;
					data.AnimName = "Fail";
				}
			}
		};
		for (int i = 0; i < 9; i++)
		{
			GolemHackingInputInfo golemHackingInputInfo = new GolemHackingInputInfo
			{
				Code = "",
				State = EGolemHackingInputState.Block,
				AnimIndex = 0,
				AnimName = ""
			};
			if (i < inputList.Count)
			{
				golemHackingInputInfo.Code = inputList[i];
				golemHackingInputInfo.State = EGolemHackingInputState.Occupy;
				action(golemHackingInputInfo, i);
			}
			else if (i == inputList.Count && i < maxLength)
			{
				golemHackingInputInfo.State = EGolemHackingInputState.Enterring;
				action(golemHackingInputInfo, i);
			}
			else if (i < maxLength)
			{
				golemHackingInputInfo.State = EGolemHackingInputState.Empty;
				action(golemHackingInputInfo, i);
			}
			list.Add(golemHackingInputInfo);
		}
		if (animCount > 0)
		{
			this.BarAnimCount = animCount;
		}
		return list;
	}

	// Token: 0x06003D3B RID: 15675 RVA: 0x0015A6A4 File Offset: 0x001588A4
	protected void RefreshCodePanel(List<GolemHackingCodeEnterResult> codeParam, bool needAnim)
	{
		List<EGolemHackingBarState> list = new List<EGolemHackingBarState>();
		List<List<GolemHackingCodeGridInfo>> list2 = new List<List<GolemHackingCodeGridInfo>>();
		int num = 0;
		int num2 = 0;
		foreach (GolemHackingCodeEnterResult golemHackingCodeEnterResult in codeParam)
		{
			list.Add(golemHackingCodeEnterResult.State);
			if (golemHackingCodeEnterResult.State != EGolemHackingBarState.Default)
			{
				num++;
			}
			if (golemHackingCodeEnterResult.State == EGolemHackingBarState.Fail)
			{
				num2++;
			}
			if (needAnim)
			{
				for (int i = 0; i < golemHackingCodeEnterResult.Code.Count; i++)
				{
					golemHackingCodeEnterResult.Code[i].AnimIndex = i + 1;
				}
			}
			list2.Add(golemHackingCodeEnterResult.Code);
		}
		if (num == codeParam.Count || num2 > 0)
		{
			if (this.BarAnimCount == -1)
			{
				this.BarAnimCount = 0;
			}
			this.BarAnimCount += ((num2 > 0) ? num2 : num);
			if (num2 > 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("IntrusionProtocol_InsufficientBufferTips", Array.Empty<object>());
			}
			UiLayer.Instance.SetShowNormalMaskLayer(true, "");
		}
		else
		{
			this.BarAnimCount = -1;
		}
		this.CodeLayout.RefreshByData(list2, null, false);
		this.BarLayout.RefreshByData(list, null, false);
		this.IconLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06003D3C RID: 15676 RVA: 0x0015A7F4 File Offset: 0x001589F4
	private void OnClickedHelp()
	{
		List<GolemHackingTipsGirdInfo> helpTipsInfo = this.Proxy.GetHelpTipsInfo();
		UiManager.Instance.OpenView(EUiViewName.GolemHackingGameTipsPopView, helpTipsInfo, null);
	}

	// Token: 0x06003D3D RID: 15677 RVA: 0x0015A820 File Offset: 0x00158A20
	private void OnClickedReset()
	{
		double now = Time.Instance.Now;
		if (now - this.ResetTimeRecord < 400.0)
		{
			return;
		}
		this.ResetTimeRecord = now;
		this.Proxy.Reset();
	}

	// Token: 0x06003D3E RID: 15678 RVA: 0x0015A860 File Offset: 0x00158A60
	private void OnMatrixHoverCallBack(int curIndex, string code)
	{
		foreach (GolemHackingCodeKeyListItem golemHackingCodeKeyListItem in this.CodeLayout.GetLayoutItemList())
		{
			golemHackingCodeKeyListItem.OnMatrixHover(curIndex, code);
		}
		GolemHackingCodeInputItem layoutItemByIndex = this.InputLayout.GetLayoutItemByIndex(curIndex);
		if (layoutItemByIndex == null)
		{
			return;
		}
		layoutItemByIndex.EnterInputCode(code);
	}

	// Token: 0x06003D3F RID: 15679 RVA: 0x0015A8D0 File Offset: 0x00158AD0
	private void OnMatrixUnHoverCallBack()
	{
		foreach (GolemHackingCodeKeyListItem golemHackingCodeKeyListItem in this.CodeLayout.GetLayoutItemList())
		{
			golemHackingCodeKeyListItem.OnMatrixUnHover();
		}
		foreach (GolemHackingCodeInputItem golemHackingCodeInputItem in this.InputLayout.GetLayoutItemList())
		{
			golemHackingCodeInputItem.ClearInputCode();
		}
	}

	// Token: 0x06003D40 RID: 15680 RVA: 0x0015A96C File Offset: 0x00158B6C
	private void OnMatrixEnterCallBack(List<string> curEnter, List<GolemHackingCodeEnterResult> codeParam)
	{
		this.RefreshEnterPanel(curEnter, codeParam);
		this.RefreshCodePanel(codeParam, curEnter.Count == 0);
	}

	// Token: 0x06003D41 RID: 15681 RVA: 0x0015A988 File Offset: 0x00158B88
	private void OnResetCallBack()
	{
		UUIButtonComponent button = base.GetButton(10);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(this.Proxy.NeedHelpBtn());
		}
		this.Proxy.InitCodePanelInfo();
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetAnchorOffsetX(9f);
		}
		foreach (GolemHackingCodeKeyListItem golemHackingCodeKeyListItem in this.CodeLayout.GetLayoutItemList())
		{
			golemHackingCodeKeyListItem.OnMatrixUnHover();
		}
	}

	// Token: 0x06003D42 RID: 15682 RVA: 0x0015AA2C File Offset: 0x00158C2C
	private void OnBarAnimEnd()
	{
		if (this.BarAnimCount == -1)
		{
			return;
		}
		this.BarAnimCount--;
		if (this.BarAnimCount == 0)
		{
			this.Proxy.OnOneTurnEndAfterAnim();
			UiLayer.Instance.SetShowNormalMaskLayer(false, "");
			this.BarAnimCount = -1;
		}
	}

	// Token: 0x06003D43 RID: 15683 RVA: 0x0015AA7B File Offset: 0x00158C7B
	private GolemHackingCodeKeyListItem CreateCodePanelItem()
	{
		return new GolemHackingCodeKeyListItem(this.Proxy);
	}

	// Token: 0x06003D44 RID: 15684 RVA: 0x0015AA88 File Offset: 0x00158C88
	private GolemHackingCodeIconItem CreateIconItem()
	{
		return new GolemHackingCodeIconItem();
	}

	// Token: 0x06003D45 RID: 15685 RVA: 0x0015AA8F File Offset: 0x00158C8F
	private GolemHackingCodeKeyBarItem CreateBarItem()
	{
		return new GolemHackingCodeKeyBarItem
		{
			OnAnimEndCallback = new Action(this.OnBarAnimEnd)
		};
	}

	// Token: 0x06003D46 RID: 15686 RVA: 0x0015AAA8 File Offset: 0x00158CA8
	private GolemHackingCodeInputItem CreateInputItem()
	{
		return new GolemHackingCodeInputItem
		{
			OnBarAnimEnd = new Action(this.OnBarAnimEnd)
		};
	}

	// Token: 0x06003D47 RID: 15687 RVA: 0x0015AAC1 File Offset: 0x00158CC1
	[NullableContext(2)]
	public GolemHackingCodeKeyListItem GetHorizontalPanelByIndex(int index)
	{
		if (this.CodeLayout.IsLock)
		{
			return null;
		}
		return this.CodeLayout.GetLayoutItemByIndex(index);
	}

	// Token: 0x0400314D RID: 12621
	private const int SCAN_INTERNAL = 133;

	// Token: 0x0400314E RID: 12622
	private const int SCAN_START = 9;

	// Token: 0x0400314F RID: 12623
	private const int RESET_COOLDOWN = 400;

	// Token: 0x04003150 RID: 12624
	protected GenericLayout<GolemHackingCodeKeyListItem, List<GolemHackingCodeGridInfo>> CodeLayout;

	// Token: 0x04003151 RID: 12625
	protected GenericLayout<GolemHackingCodeIconItem, EGolemHackingBarState> IconLayout;

	// Token: 0x04003152 RID: 12626
	protected GenericLayout<GolemHackingCodeKeyBarItem, EGolemHackingBarState> BarLayout;

	// Token: 0x04003153 RID: 12627
	protected GenericLayout<GolemHackingCodeInputItem, GolemHackingInputInfo> InputLayout;

	// Token: 0x04003154 RID: 12628
	protected int BarAnimCount = -1;

	// Token: 0x04003155 RID: 12629
	private double ResetTimeRecord;

	// Token: 0x04003156 RID: 12630
	protected GolemHackingGameProxy Proxy;

	// Token: 0x020067A2 RID: 26530
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04022346 RID: 140102
		PanelKeyList,
		// Token: 0x04022347 RID: 140103
		TexBgSelectFrame,
		// Token: 0x04022348 RID: 140104
		PanelHackingKeyGroup,
		// Token: 0x04022349 RID: 140105
		PanelLevelIcon,
		// Token: 0x0402234A RID: 140106
		SpriteLevel,
		// Token: 0x0402234B RID: 140107
		PanelStateList,
		// Token: 0x0402234C RID: 140108
		PanelStateBar,
		// Token: 0x0402234D RID: 140109
		TxtKeyCount,
		// Token: 0x0402234E RID: 140110
		PanelCodeGrid,
		// Token: 0x0402234F RID: 140111
		CodeItem,
		// Token: 0x04022350 RID: 140112
		BtnHelp,
		// Token: 0x04022351 RID: 140113
		BtnReset
	}
}
