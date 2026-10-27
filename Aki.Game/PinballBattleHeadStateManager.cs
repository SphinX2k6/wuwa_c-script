using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000EAA RID: 3754
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleHeadStateManager
{
	// Token: 0x06005CB1 RID: 23729 RVA: 0x00110DAC File Offset: 0x0010EFAC
	public void Init()
	{
		string stringConfig = ConfigCommonParamById.GetStringConfig("HeadStateScaleCurvePath");
		this.HeadStateScaleCurve = ResourceSystem.Instance.Load<UCurveFloat>(stringConfig, "js_undefined");
	}

	// Token: 0x06005CB2 RID: 23730 RVA: 0x00110DDC File Offset: 0x0010EFDC
	public void Clear()
	{
		foreach (PinballBattleHeadStateUiBase pinballBattleHeadStateUiBase in this.HeadStateMap.Values)
		{
			pinballBattleHeadStateUiBase.DestroyAsync().Forget<bool>();
		}
		this.HeadStateMap.Clear();
	}

	// Token: 0x06005CB3 RID: 23731 RVA: 0x00110E44 File Offset: 0x0010F044
	public void UpdateHeadState(FKSC_HeadHpContext headContext)
	{
		EKSC_HeadHpContextType actionType = headContext.ActionType;
		if (actionType <= EKSC_HeadHpContextType.Update)
		{
			this.HandleAddOrUpdate(headContext);
			return;
		}
		if (actionType != EKSC_HeadHpContextType.Remove)
		{
			return;
		}
		this.HandleRemove(headContext);
	}

	// Token: 0x06005CB4 RID: 23732 RVA: 0x00110E70 File Offset: 0x0010F070
	private void HandleAddOrUpdate(FKSC_HeadHpContext headContext)
	{
		PinballBattleHeadStateUiBase pinballBattleHeadStateUiBase;
		if (!this.HeadStateMap.TryGetValue(headContext.EntityId, out pinballBattleHeadStateUiBase))
		{
			pinballBattleHeadStateUiBase = this.CreateHeadUiItem(headContext);
			if (pinballBattleHeadStateUiBase == null)
			{
				return;
			}
			this.HeadStateMap[headContext.EntityId] = pinballBattleHeadStateUiBase;
		}
		pinballBattleHeadStateUiBase.UpdateByHeadInfo(headContext);
	}

	// Token: 0x06005CB5 RID: 23733 RVA: 0x00110EB8 File Offset: 0x0010F0B8
	private void HandleRemove(FKSC_HeadHpContext headContext)
	{
		PinballBattleHeadStateUiBase pinballBattleHeadStateUiBase;
		if (this.HeadStateMap.TryGetValue(headContext.EntityId, out pinballBattleHeadStateUiBase))
		{
			pinballBattleHeadStateUiBase.DestroyAsync().Forget<bool>();
			this.HeadStateMap.Remove(headContext.EntityId);
		}
	}

	// Token: 0x06005CB6 RID: 23734 RVA: 0x00110EF8 File Offset: 0x0010F0F8
	[return: Nullable(2)]
	private PinballBattleHeadStateUiBase CreateHeadUiItem(FKSC_HeadHpContext headContext)
	{
		PinballBattleHeadStateUiBase pinballBattleHeadStateUiBase = null;
		string text = null;
		if (headContext.HeadUiType == EKSC_HeadUiType.Marble)
		{
			pinballBattleHeadStateUiBase = new PinballBattlePlayerHpBar();
			text = "UiItem_FlipperHP";
		}
		if (pinballBattleHeadStateUiBase == null || text == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PinballBattle;
			ELogAuthor author = ELogAuthor.LJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
			defaultInterpolatedStringHandler.AppendLiteral("未注册的头部状态UI类型！EntityId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(headContext.EntityId);
			defaultInterpolatedStringHandler.AppendLiteral(" HeadUiType: ");
			defaultInterpolatedStringHandler.AppendFormatted<EKSC_HeadUiType>(headContext.HeadUiType);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		pinballBattleHeadStateUiBase.InitScaleCurve(this.HeadStateScaleCurve);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
		pinballBattleHeadStateUiBase.CreateThenShowByPathAsync(resourcePath, UiLayer.Instance.WorldSpaceUiRootItem, true).Forget();
		return pinballBattleHeadStateUiBase;
	}

	// Token: 0x04002A47 RID: 10823
	private readonly Dictionary<int, PinballBattleHeadStateUiBase> HeadStateMap = new Dictionary<int, PinballBattleHeadStateUiBase>();

	// Token: 0x04002A48 RID: 10824
	[Nullable(2)]
	private UCurveFloat HeadStateScaleCurve;
}
