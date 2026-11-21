using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200035F RID: 863
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleHeadStateManager
{
	// Token: 0x06003048 RID: 12360 RVA: 0x00118A48 File Offset: 0x00116C48
	public void Init()
	{
		string stringConfig = ConfigCommonParamById.GetStringConfig("HeadStateScaleCurvePath");
		this.HeadStateScaleCurve = ResourceSystem.Instance.Load<UCurveFloat>(stringConfig, "js_undefined");
	}

	// Token: 0x06003049 RID: 12361 RVA: 0x00118A78 File Offset: 0x00116C78
	public void Clear()
	{
		foreach (PinballBattleHeadStateUiBase pinballBattleHeadStateUiBase in this.HeadStateMap.Values)
		{
			pinballBattleHeadStateUiBase.DestroyAsync().Forget<bool>();
		}
		this.HeadStateMap.Clear();
	}

	// Token: 0x0600304A RID: 12362 RVA: 0x00118AE0 File Offset: 0x00116CE0
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

	// Token: 0x0600304B RID: 12363 RVA: 0x00118B0C File Offset: 0x00116D0C
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

	// Token: 0x0600304C RID: 12364 RVA: 0x00118B54 File Offset: 0x00116D54
	private void HandleRemove(FKSC_HeadHpContext headContext)
	{
		PinballBattleHeadStateUiBase pinballBattleHeadStateUiBase;
		if (this.HeadStateMap.TryGetValue(headContext.EntityId, out pinballBattleHeadStateUiBase))
		{
			pinballBattleHeadStateUiBase.DestroyAsync().Forget<bool>();
			this.HeadStateMap.Remove(headContext.EntityId);
		}
	}

	// Token: 0x0600304D RID: 12365 RVA: 0x00118B94 File Offset: 0x00116D94
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

	// Token: 0x04002AE2 RID: 10978
	private readonly Dictionary<int, PinballBattleHeadStateUiBase> HeadStateMap = new Dictionary<int, PinballBattleHeadStateUiBase>();

	// Token: 0x04002AE3 RID: 10979
	[Nullable(2)]
	private UCurveFloat HeadStateScaleCurve;
}
