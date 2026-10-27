using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x020034A7 RID: 13479
[NullableContext(1)]
[Nullable(0)]
public class UiModel : Singleton
{
	// Token: 0x0601D586 RID: 120198 RVA: 0x0082DECC File Offset: 0x0082C0CC
	[NullableContext(2)]
	public UiViewBase GetTopView(ELayerType layer)
	{
		if (layer <= ELayerType.Pop)
		{
			switch (layer)
			{
			case ELayerType.HUD:
				if (this.HudMap.Count <= 0)
				{
					return null;
				}
				return this.HudMap.Values.Last<UiViewBase>();
			case ELayerType.Normal:
				return this.NormalStack.Peek();
			case ELayerType.HUD | ELayerType.Normal:
				break;
			case ELayerType.Plot:
				return this.PlotNormalStack.Peek();
			default:
				if (layer == ELayerType.Pop)
				{
					if (this.PopList.Count <= 0)
					{
						return null;
					}
					return this.PopList[this.PopList.Count - 1];
				}
				break;
			}
		}
		else if (layer != ELayerType.Guide)
		{
			if (layer != ELayerType.Loading)
			{
				if (layer == ELayerType.NetWork)
				{
					if (this.NetWorkList.Count <= 0)
					{
						return null;
					}
					return this.NetWorkList[this.NetWorkList.Count - 1];
				}
			}
			else
			{
				if (this.LoadingMap.Count <= 0)
				{
					return null;
				}
				return this.LoadingMap.Values.ToArray<UiViewBase>()[this.LoadingMap.Count - 1];
			}
		}
		else
		{
			if (this.GuideList.Count <= 0)
			{
				return null;
			}
			return this.GuideList[this.GuideList.Count - 1];
		}
		return null;
	}

	// Token: 0x0601D587 RID: 120199 RVA: 0x0082E007 File Offset: 0x0082C207
	public void AddNpcIconViewUnit(UiPanelBase npcIconView)
	{
		if (this.NpcIconViewUnitList.Contains(npcIconView))
		{
			return;
		}
		this.NpcIconViewUnitList.Add(npcIconView);
	}

	// Token: 0x0601D588 RID: 120200 RVA: 0x0082E025 File Offset: 0x0082C225
	public void RemoveNpcIconViewUnit(UiPanelBase npcIconView)
	{
		if (!this.NpcIconViewUnitList.Contains(npcIconView))
		{
			return;
		}
		this.NpcIconViewUnitList.Remove(npcIconView);
	}

	// Token: 0x0601D589 RID: 120201 RVA: 0x0082E044 File Offset: 0x0082C244
	public void SetNpcIconViewListShowState(bool visible)
	{
		foreach (UiPanelBase uiPanelBase in this.NpcIconViewUnitList)
		{
			uiPanelBase.GetRootItem().SetUIActive(visible);
		}
	}

	// Token: 0x0601D58A RID: 120202 RVA: 0x0082E09C File Offset: 0x0082C29C
	[NullableContext(2)]
	public UiViewBase GetFloatView(EUiViewName name)
	{
		UiFloatConfig? uiFloatConfig = UiViewConfig.Instance.GetUiFloatConfig(name);
		if (uiFloatConfig == null)
		{
			return null;
		}
		string key = StringUtils.IsEmpty(uiFloatConfig.Value.Area) ? name : uiFloatConfig.Value.Area;
		return this.ShowViewMap.GetValueOrDefault(key);
	}

	// Token: 0x0601D58B RID: 120203 RVA: 0x0082E0FC File Offset: 0x0082C2FC
	[NullableContext(2)]
	public UiViewBase PeekNormalView(int offsetFromTop = 0)
	{
		if (this.NormalStack.Size <= offsetFromTop)
		{
			return null;
		}
		int num = this.NormalStack.Size - 1 - offsetFromTop;
		int num2 = 0;
		foreach (UiViewBase result in this.NormalStack)
		{
			if (num2 == num)
			{
				return result;
			}
			num2++;
		}
		return null;
	}

	// Token: 0x170028B9 RID: 10425
	// (get) Token: 0x0601D58C RID: 120204 RVA: 0x0082E178 File Offset: 0x0082C378
	public static UiModel Instance
	{
		get
		{
			if (UiModel._instance == null)
			{
				UiModel._instance = new UiModel();
				UiModel._instance.OnInit();
			}
			return UiModel._instance;
		}
	}

	// Token: 0x0601D58D RID: 120205 RVA: 0x0082E19B File Offset: 0x0082C39B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D58E RID: 120206 RVA: 0x0082E19D File Offset: 0x0082C39D
	public static void ResetStaticDefaultValue()
	{
		UiModel instance = UiModel._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiModel._instance = null;
	}

	// Token: 0x0601D58F RID: 120207 RVA: 0x0082E1B6 File Offset: 0x0082C3B6
	static UiModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModel.CreateStaticDefaultValue), new Action(UiModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400E738 RID: 59192
	public readonly Dictionary<EUiViewName, UiViewBase> HudMap = new Dictionary<EUiViewName, UiViewBase>();

	// Token: 0x0400E739 RID: 59193
	public readonly global::Stack<UiViewBase> NormalStack = new global::Stack<UiViewBase>();

	// Token: 0x0400E73A RID: 59194
	public readonly global::Stack<UiViewBase> PlotNormalStack = new global::Stack<UiViewBase>();

	// Token: 0x0400E73B RID: 59195
	public readonly List<UiViewBase> PopList = new List<UiViewBase>();

	// Token: 0x0400E73C RID: 59196
	public readonly Dictionary<string, FloatViewQueue> FloatQueueMap = new Dictionary<string, FloatViewQueue>();

	// Token: 0x0400E73D RID: 59197
	public readonly Dictionary<string, UiViewBase> ShowViewMap = new Dictionary<string, UiViewBase>();

	// Token: 0x0400E73E RID: 59198
	public readonly Dictionary<string, UiViewBase> HideViewMap = new Dictionary<string, UiViewBase>();

	// Token: 0x0400E73F RID: 59199
	public readonly List<UiViewBase> GuideList = new List<UiViewBase>();

	// Token: 0x0400E740 RID: 59200
	public readonly Dictionary<EUiViewName, UiViewBase> LoadingMap = new Dictionary<EUiViewName, UiViewBase>();

	// Token: 0x0400E741 RID: 59201
	public readonly Dictionary<EUiViewName, UiViewBase> DebugMap = new Dictionary<EUiViewName, UiViewBase>();

	// Token: 0x0400E742 RID: 59202
	public readonly List<UiViewBase> NetWorkList = new List<UiViewBase>();

	// Token: 0x0400E743 RID: 59203
	private readonly HashSet<UiPanelBase> NpcIconViewUnitList = new HashSet<UiPanelBase>();

	// Token: 0x0400E744 RID: 59204
	public readonly HashSet<EUiViewName> ResetToViewWhiteSet = new HashSet<EUiViewName>
	{
		EUiViewName.ReviveView
	};

	// Token: 0x0400E745 RID: 59205
	public bool IsInMainView;

	// Token: 0x0400E746 RID: 59206
	public bool InNormalQueue;

	// Token: 0x0400E747 RID: 59207
	public readonly HashSet<EUiViewName> SeamlessStackWhileList = new HashSet<EUiViewName>
	{
		EUiViewName.BattleView
	};

	// Token: 0x0400E748 RID: 59208
	public EUiViewName MainViewName = EUiViewName.BattleView;

	// Token: 0x0400E749 RID: 59209
	public readonly HashSet<EUiViewName> CanShowPlotViewWhiteList = new HashSet<EUiViewName>
	{
		EUiViewName.BattleView,
		EUiViewName.CommonGameMainView,
		EUiViewName.DangoAbyssWorldView,
		EUiViewName.PhantomArenaBattleDetailsView,
		EUiViewName.HonamiStoryTechnologyView,
		EUiViewName.LaHaiLuoCollectView,
		EUiViewName.RiLingCollectView,
		EUiViewName.MengZhouCollectView,
		EUiViewName.DrinksSelectRoleView,
		EUiViewName.DrinksGameplayView,
		EUiViewName.DrinksShowView,
		EUiViewName.GuessJokerSelectRoleView,
		EUiViewName.TetrisGameView,
		EUiViewName.VillageInfrWorldBuildView
	};

	// Token: 0x0400E74A RID: 59210
	public HashSet<EUiViewName> NormalStackBottomWhiteSet = new HashSet<EUiViewName>
	{
		EUiViewName.LoginView,
		EUiViewName.LoginDebugView,
		EUiViewName.CreateCharacterView,
		EUiViewName.MobileSwitchInputView
	};

	// Token: 0x0400E74B RID: 59211
	[Nullable(2)]
	private static UiModel _instance;
}
