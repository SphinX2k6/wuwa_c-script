using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02002A1B RID: 10779
[NullableContext(1)]
[Nullable(0)]
public class UiModel : Singleton
{
	// Token: 0x0601B283 RID: 111235 RVA: 0x00855078 File Offset: 0x00853278
	[NullableContext(2)]
	public UiViewBase GetTopView(ELayerType layer)
	{
		if (layer <= ELayerType.Pop)
		{
			switch (layer)
			{
			case ELayerType.HUD:
			{
				UiViewBase result = null;
				if (this.HudMap.Count > 0)
				{
					using (Dictionary<EUiViewName, UiViewBase>.ValueCollection.Enumerator enumerator = this.HudMap.Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							result = enumerator.Current;
						}
					}
				}
				return result;
			}
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
			if (layer == ELayerType.Loading)
			{
				UiViewBase result2 = null;
				if (this.LoadingMap.Count > 0)
				{
					using (Dictionary<EUiViewName, UiViewBase>.ValueCollection.Enumerator enumerator = this.LoadingMap.Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							result2 = enumerator.Current;
						}
					}
				}
				return result2;
			}
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
			if (this.GuideList.Count <= 0)
			{
				return null;
			}
			return this.GuideList[this.GuideList.Count - 1];
		}
		return null;
	}

	// Token: 0x0601B284 RID: 111236 RVA: 0x00855210 File Offset: 0x00853410
	public void AddNpcIconViewUnit(UiPanelBase npcIconView)
	{
		if (this.NpcIconViewUnitList.Contains(npcIconView))
		{
			return;
		}
		this.NpcIconViewUnitList.Add(npcIconView);
	}

	// Token: 0x0601B285 RID: 111237 RVA: 0x0085522E File Offset: 0x0085342E
	public void RemoveNpcIconViewUnit(UiPanelBase npcIconView)
	{
		if (!this.NpcIconViewUnitList.Contains(npcIconView))
		{
			return;
		}
		this.NpcIconViewUnitList.Remove(npcIconView);
	}

	// Token: 0x0601B286 RID: 111238 RVA: 0x0085524C File Offset: 0x0085344C
	public void SetNpcIconViewListShowState(bool visible)
	{
		foreach (UiPanelBase uiPanelBase in this.NpcIconViewUnitList)
		{
			uiPanelBase.GetRootItem().SetUIActive(visible);
		}
	}

	// Token: 0x0601B287 RID: 111239 RVA: 0x008552A4 File Offset: 0x008534A4
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

	// Token: 0x0601B288 RID: 111240 RVA: 0x00855304 File Offset: 0x00853504
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

	// Token: 0x17002C51 RID: 11345
	// (get) Token: 0x0601B289 RID: 111241 RVA: 0x00855380 File Offset: 0x00853580
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

	// Token: 0x0601B28A RID: 111242 RVA: 0x008553A3 File Offset: 0x008535A3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B28B RID: 111243 RVA: 0x008553A5 File Offset: 0x008535A5
	public static void ResetStaticDefaultValue()
	{
		UiModel instance = UiModel._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiModel._instance = null;
	}

	// Token: 0x0601B28C RID: 111244 RVA: 0x008553BE File Offset: 0x008535BE
	static UiModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModel.CreateStaticDefaultValue), new Action(UiModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EBEC RID: 60396
	public readonly Dictionary<EUiViewName, UiViewBase> HudMap = new Dictionary<EUiViewName, UiViewBase>();

	// Token: 0x0400EBED RID: 60397
	public readonly global::Stack<UiViewBase> NormalStack = new global::Stack<UiViewBase>();

	// Token: 0x0400EBEE RID: 60398
	public readonly global::Stack<UiViewBase> PlotNormalStack = new global::Stack<UiViewBase>();

	// Token: 0x0400EBEF RID: 60399
	public readonly List<UiViewBase> PopList = new List<UiViewBase>();

	// Token: 0x0400EBF0 RID: 60400
	public readonly Dictionary<string, FloatViewQueue> FloatQueueMap = new Dictionary<string, FloatViewQueue>();

	// Token: 0x0400EBF1 RID: 60401
	public readonly Dictionary<string, UiViewBase> ShowViewMap = new Dictionary<string, UiViewBase>();

	// Token: 0x0400EBF2 RID: 60402
	public readonly Dictionary<string, UiViewBase> HideViewMap = new Dictionary<string, UiViewBase>();

	// Token: 0x0400EBF3 RID: 60403
	public readonly List<UiViewBase> GuideList = new List<UiViewBase>();

	// Token: 0x0400EBF4 RID: 60404
	public readonly Dictionary<EUiViewName, UiViewBase> LoadingMap = new Dictionary<EUiViewName, UiViewBase>();

	// Token: 0x0400EBF5 RID: 60405
	public readonly Dictionary<EUiViewName, UiViewBase> DebugMap = new Dictionary<EUiViewName, UiViewBase>();

	// Token: 0x0400EBF6 RID: 60406
	public readonly List<UiViewBase> NetWorkList = new List<UiViewBase>();

	// Token: 0x0400EBF7 RID: 60407
	private readonly HashSet<UiPanelBase> NpcIconViewUnitList = new HashSet<UiPanelBase>();

	// Token: 0x0400EBF8 RID: 60408
	public readonly HashSet<EUiViewName> ResetToViewWhiteSet = new HashSet<EUiViewName>
	{
		EUiViewName.ReviveView
	};

	// Token: 0x0400EBF9 RID: 60409
	public bool IsInMainView;

	// Token: 0x0400EBFA RID: 60410
	public bool InNormalQueue;

	// Token: 0x0400EBFB RID: 60411
	public readonly HashSet<EUiViewName> SeamlessStackWhileList = new HashSet<EUiViewName>
	{
		EUiViewName.BattleView
	};

	// Token: 0x0400EBFC RID: 60412
	public EUiViewName MainViewName = EUiViewName.BattleView;

	// Token: 0x0400EBFD RID: 60413
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

	// Token: 0x0400EBFE RID: 60414
	public HashSet<EUiViewName> NormalStackBottomWhiteSet = new HashSet<EUiViewName>
	{
		EUiViewName.LoginView,
		EUiViewName.LoginDebugView,
		EUiViewName.CreateCharacterView,
		EUiViewName.MobileSwitchInputView
	};

	// Token: 0x0400EBFF RID: 60415
	[Nullable(2)]
	private static UiModel _instance;
}
