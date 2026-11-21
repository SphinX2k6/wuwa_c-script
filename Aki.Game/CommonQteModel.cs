using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AF4 RID: 6900
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class CommonQteModel : ModelBase
{
	// Token: 0x0601126E RID: 70254 RVA: 0x00509AF4 File Offset: 0x00507CF4
	protected override bool OnLeaveLevel()
	{
		this.ClearPreloadCache(null);
		Dictionary<int, CommonQteContextBase> contexts = this.Contexts;
		if (contexts != null)
		{
			contexts.Clear();
		}
		this.CommonQteDt = null;
		this.CommonQteGroupDt = null;
		return true;
	}

	// Token: 0x0601126F RID: 70255 RVA: 0x00509B30 File Offset: 0x00507D30
	public CommonQteContextBase CreateQteContext(int qteId, TCommonQteCallback onSuccess = null, TCommonQteCallback onFail = null, EQteSource source = EQteSource.Battle, IQteExtraParams extraParams = null)
	{
		SCommonQte commonQteConfig = this.GetCommonQteConfig(qteId);
		if (commonQteConfig == null)
		{
			return null;
		}
		CommonQteContextBase commonQteContextBase;
		switch (commonQteConfig.BaseConfig.QteType)
		{
		case 0:
			commonQteContextBase = new CommonQteSingleClickContext();
			break;
		case 1:
			commonQteContextBase = new CommonQteContinuousClickContext();
			break;
		case 2:
			commonQteContextBase = new CommonQteDragContext();
			break;
		case 3:
			commonQteContextBase = new CommonQteLongPressContext();
			break;
		case 4:
			commonQteContextBase = new CommonQteSelectOptionContext();
			break;
		default:
			return null;
		}
		commonQteContextBase.QteId = qteId;
		commonQteContextBase.Source = new EQteSource?(source);
		CommonQteContextBase commonQteContextBase2 = commonQteContextBase;
		int handleIdCounter = this.HandleIdCounter;
		this.HandleIdCounter = handleIdCounter + 1;
		commonQteContextBase2.HandleId = handleIdCounter;
		commonQteContextBase.SetConfig(commonQteConfig);
		commonQteContextBase.SuccessCallback = onSuccess;
		commonQteContextBase.FailCallback = onFail;
		commonQteContextBase.ExtraParams = extraParams;
		return commonQteContextBase;
	}

	// Token: 0x06011270 RID: 70256 RVA: 0x00509BF4 File Offset: 0x00507DF4
	public CommonQteGroupContext CreateQteGroupContext(int qteGroupId, TCommonQteCallback onSuccess = null, TCommonQteCallback onFail = null, EQteSource source = EQteSource.Battle, IQteExtraParams extraParams = null)
	{
		SCommonQteGroup commonQteGroupConfig = this.GetCommonQteGroupConfig(qteGroupId);
		if (commonQteGroupConfig == null)
		{
			return null;
		}
		CommonQteGroupContext commonQteGroupContext = new CommonQteGroupContext();
		commonQteGroupContext.QteGroupId = qteGroupId;
		commonQteGroupContext.Source = new EQteSource?(source);
		CommonQteContextBase commonQteContextBase = commonQteGroupContext;
		int handleIdCounter = this.HandleIdCounter;
		this.HandleIdCounter = handleIdCounter + 1;
		commonQteContextBase.HandleId = handleIdCounter;
		commonQteGroupContext.SetGroupConfig(commonQteGroupConfig);
		commonQteGroupContext.SuccessCallback = onSuccess;
		commonQteGroupContext.FailCallback = onFail;
		commonQteGroupContext.ExtraParams = extraParams;
		for (int i = 0; i < commonQteGroupConfig.CommonQteIdSet.Num(); i++)
		{
			int element = commonQteGroupConfig.CommonQteIdSet.GetElement(i);
			CommonQteContextBase commonQteContextBase2 = this.CreateQteContext(element, null, new TCommonQteCallback(commonQteGroupContext.OnContextFail), source, extraParams);
			if (commonQteContextBase2 != null)
			{
				commonQteContextBase2.QteGroupId = qteGroupId;
				commonQteContextBase2.GroupHandleId = commonQteGroupContext.HandleId;
				commonQteContextBase2.GroupContext = commonQteGroupContext;
				commonQteContextBase2.SetGroupConfig(commonQteGroupConfig);
				commonQteGroupContext.AddContext(element, commonQteContextBase2, element == commonQteGroupConfig.MainQteId);
			}
		}
		return commonQteGroupContext;
	}

	// Token: 0x06011271 RID: 70257 RVA: 0x00509CDF File Offset: 0x00507EDF
	[NullableContext(1)]
	public void SetCurrentCommonQte(CommonQteContextBase context)
	{
		this.HandleId = context.HandleId;
		if (this.Contexts == null)
		{
			this.Contexts = new Dictionary<int, CommonQteContextBase>();
		}
		this.Contexts[context.HandleId] = context;
	}

	// Token: 0x06011272 RID: 70258 RVA: 0x00509D14 File Offset: 0x00507F14
	public SCommonQte GetCommonQteConfig(int commonQteId)
	{
		SCommonQte result;
		if (this.QteConfigCache != null && this.QteConfigCache.TryGetValue(commonQteId, out result))
		{
			return result;
		}
		if (this.CommonQteDt == null)
		{
			UDataTable loadedAsset = ResourceSystem.Instance.GetLoadedAsset<UDataTable>("/Game/Aki/Data/Qte/DT_CommonQte.DT_CommonQte");
			if (loadedAsset == null || !loadedAsset.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CommonQte;
				ELogAuthor author = ELogAuthor.WWJ;
				string message = "通用QTE配置加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", "/Game/Aki/Data/Qte/DT_CommonQte.DT_CommonQte");
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			this.CommonQteDt = loadedAsset;
		}
		SCommonQte dataTableRow = DataTableUtil.GetDataTableRow<SCommonQte>(this.CommonQteDt, commonQteId.ToString());
		if (dataTableRow != null)
		{
			if (this.QteConfigCache == null)
			{
				this.QteConfigCache = new Dictionary<int, SCommonQte>();
			}
			this.QteConfigCache[commonQteId] = dataTableRow;
		}
		else
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CommonQte;
			ELogAuthor author2 = ELogAuthor.WWJ;
			string message2 = "找不到通用QTE配置";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("QteId", commonQteId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		return dataTableRow;
	}

	// Token: 0x06011273 RID: 70259 RVA: 0x00509E08 File Offset: 0x00508008
	public SCommonQteGroup GetCommonQteGroupConfig(int commonQteGroupId)
	{
		if (this.CommonQteGroupDt == null)
		{
			UDataTable udataTable = ResourceSystem.Instance.Load<UDataTable>("/Game/Aki/Data/Qte/DT_CommonQteGroup.DT_CommonQteGroup", "js_undefined");
			if (udataTable == null || !udataTable.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CommonQte;
				ELogAuthor author = ELogAuthor.WWJ;
				string message = "通用QTE配置加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", "/Game/Aki/Data/Qte/DT_CommonQteGroup.DT_CommonQteGroup");
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			this.CommonQteGroupDt = udataTable;
		}
		SCommonQteGroup dataTableRow = DataTableUtil.GetDataTableRow<SCommonQteGroup>(this.CommonQteGroupDt, commonQteGroupId.ToString());
		if (dataTableRow == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.CommonQte;
			ELogAuthor author2 = ELogAuthor.WWJ;
			string message2 = "找不到通用QTE组配置";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("QteGroupId", commonQteGroupId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		return dataTableRow;
	}

	// Token: 0x06011274 RID: 70260 RVA: 0x00509EC0 File Offset: 0x005080C0
	public EUiViewName? GetCommonQteViewName(int commonQteId)
	{
		SCommonQte commonQteConfig = this.GetCommonQteConfig(commonQteId);
		if (commonQteConfig == null)
		{
			return null;
		}
		if (commonQteConfig.BaseConfig.QteType == ECommonQteType.单按钮点击型)
		{
			SCommonQte_SingleClick singleClickConfig = commonQteConfig.BaseConfig.SingleClickConfig;
			if (singleClickConfig.ViewType == ECommonQteViewType_SingleButton.单按钮通用界面)
			{
				return new EUiViewName?(EUiViewName.CommonQteView);
			}
			if (singleClickConfig.ViewType == ECommonQteViewType_SingleButton.单按钮无图标快启动界面)
			{
				return new EUiViewName?(EUiViewName.CommonQteNoIconView);
			}
		}
		else if (commonQteConfig.BaseConfig.QteType == ECommonQteType.单按钮连击型)
		{
			SCommonQte_ContinuousClick continuousClickConfig = commonQteConfig.BaseConfig.ContinuousClickConfig;
			if (continuousClickConfig.ViewType == ECommonQteViewType_SingleButtonContinuousClick.单按钮连击通用界面 || continuousClickConfig.ViewType == ECommonQteViewType_SingleButtonContinuousClick.单按钮连击快启动界面)
			{
				return new EUiViewName?(EUiViewName.CommonQteContinuousClickView);
			}
		}
		else if (commonQteConfig.BaseConfig.QteType == ECommonQteType.单按钮长按型)
		{
			SCommonQte_LongPress longPressConfig = commonQteConfig.BaseConfig.LongPressConfig;
			if (longPressConfig.ViewType == ECommonQteViewType_SingleButtonLongPress.单按钮长按通用界面)
			{
				return new EUiViewName?(EUiViewName.CommonQteLongPressView);
			}
			if (longPressConfig.ViewType == ECommonQteViewType_SingleButtonLongPress.单按钮长按无图标快启动界面)
			{
				return new EUiViewName?(EUiViewName.CommonQteNoIconLongPressView);
			}
		}
		else if (commonQteConfig.BaseConfig.QteType == ECommonQteType.单按钮滑动型 && commonQteConfig.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.锚定仪界面)
		{
			return new EUiViewName?(EUiViewName.AnchorGameplayView);
		}
		return null;
	}

	// Token: 0x06011275 RID: 70261 RVA: 0x0050A050 File Offset: 0x00508250
	public string GetCommonQteItemName(int commonQteId)
	{
		SCommonQte commonQteConfig = this.GetCommonQteConfig(commonQteId);
		if (commonQteConfig == null)
		{
			return null;
		}
		if (commonQteConfig.BaseConfig.QteType == ECommonQteType.单按钮点击型)
		{
			if (commonQteConfig.BaseConfig.SingleClickConfig.ViewType == ECommonQteViewType_SingleButton.单按钮点击3D界面)
			{
				return EQteItem.SingleClickItem.ToEnumString();
			}
			if (commonQteConfig.BaseConfig.SingleClickConfig.ViewType == ECommonQteViewType_SingleButton.聚焦点击按钮)
			{
				return EQteItem.FocusSingleButtonItem.ToEnumString();
			}
			if (commonQteConfig.BaseConfig.SingleClickConfig.ViewType == 4)
			{
				return EQteItem.RingTapItem.ToEnumString();
			}
			if (commonQteConfig.BaseConfig.SingleClickConfig.ViewType == 5)
			{
				return EQteItem.RingMatchTapItem.ToEnumString();
			}
		}
		else
		{
			if (commonQteConfig.BaseConfig.QteType == ECommonQteType.单按钮连击型)
			{
				return EQteItem.ContinuousClickItem.ToEnumString();
			}
			if (commonQteConfig.BaseConfig.QteType == ECommonQteType.单按钮长按型)
			{
				if (commonQteConfig.BaseConfig.LongPressConfig.ViewType == ECommonQteViewType_SingleButtonLongPress.单按钮长按3D界面)
				{
					return EQteItem.LongPressItem.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.LongPressConfig.ViewType == ECommonQteViewType_SingleButtonLongPress.单按钮全屏长按界面)
				{
					return EQteItem.FullScreenLongPressItem.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.LongPressConfig.ViewType == ECommonQteViewType_SingleButtonLongPress.沙盘圆盘长按按钮)
				{
					return EQteItem.SingleTap37Item.ToEnumString();
				}
			}
			else if (commonQteConfig.BaseConfig.QteType == ECommonQteType.单按钮滑动型)
			{
				if (commonQteConfig.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.滑动通用界面)
				{
					return EQteItem.DragItem.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.全屏上拉界面)
				{
					return EQteItem.PullUpItem.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.全屏下拉界面)
				{
					return EQteItem.PullDownItem.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.莉莉左滑界面)
				{
					return EQteItem.PullLeftItem.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.罗盘旋转界面)
				{
					return EQteItem.CompassRotateItem.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.右半屏拖动界面)
				{
					return EQteItem.RightScreenDragItem.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.穗穗左右滑界面)
				{
					return EQteItem.SuisuiSlideItem.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.穗穗右滑界面)
				{
					return EQteItem.SuisuiRight.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.穗穗下滑界面)
				{
					return EQteItem.SuisuiDown.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.沙盘滑动界面)
				{
					return EQteItem.PlotQteDragItem.ToEnumString();
				}
			}
			else if (commonQteConfig.BaseConfig.QteType == ECommonQteType.多按钮选项型)
			{
				if (commonQteConfig.BaseConfig.SelectOptionConfig.ViewType == ECommonQteViewType_SelectOption.一体式单选界面)
				{
					return EQteItem.SelectOptionItem.ToEnumString();
				}
				if (commonQteConfig.BaseConfig.SelectOptionConfig.ViewType == ECommonQteViewType_SelectOption.分体式单选界面)
				{
					return EQteItem.CustomOptionItem.ToEnumString();
				}
			}
		}
		return null;
	}

	// Token: 0x06011276 RID: 70262 RVA: 0x0050A3AC File Offset: 0x005085AC
	[NullableContext(1)]
	[return: Nullable(2)]
	public CommonQteItemBase CreateCommonQteItem(string itemName)
	{
		if (itemName == EQteItem.SingleClickItem.ToEnumString())
		{
			return new CommonQteSingleClickItem();
		}
		if (itemName == EQteItem.ContinuousClickItem.ToEnumString())
		{
			return new CommonQteContinuousClickItem();
		}
		if (itemName == EQteItem.DragItem.ToEnumString())
		{
			return new CommonQteDragItem();
		}
		if (itemName == EQteItem.LongPressItem.ToEnumString())
		{
			return new CommonQteLongPressItem();
		}
		if (itemName == EQteItem.SelectOptionItem.ToEnumString())
		{
			return new CommonQteSelectOptionPanel();
		}
		if (itemName == EQteItem.CustomOptionItem.ToEnumString())
		{
			return new CommonQteCustomOptionPanel();
		}
		if (itemName == EQteItem.PullUpItem.ToEnumString())
		{
			return new CommonQteFullScreenPullItem();
		}
		if (itemName == EQteItem.PullDownItem.ToEnumString())
		{
			return new CommonQteFullScreenPullItem();
		}
		if (itemName == EQteItem.PullLeftItem.ToEnumString())
		{
			return new CommonQteFullScreenPullItem();
		}
		if (itemName == EQteItem.SuisuiRight.ToEnumString())
		{
			return new CommonQteFullScreenPullItem();
		}
		if (itemName == EQteItem.SuisuiDown.ToEnumString())
		{
			return new CommonQteFullScreenPullItem();
		}
		if (itemName == EQteItem.FocusSingleButtonItem.ToEnumString())
		{
			return new CommonQteFocusSingleButton();
		}
		if (itemName == EQteItem.RingTapItem.ToEnumString())
		{
			return new CommonQteRingTapItem();
		}
		if (itemName == EQteItem.RingMatchTapItem.ToEnumString())
		{
			return new CommonQteRingMatchTapItem();
		}
		if (itemName == EQteItem.CompassRotateItem.ToEnumString())
		{
			return new CommonQteCompassRotateItem();
		}
		if (itemName == EQteItem.FullScreenLongPressItem.ToEnumString())
		{
			return new CommonQteFullScreenLongPress();
		}
		if (itemName == EQteItem.SingleTap37Item.ToEnumString())
		{
			return new CommonQteSingleTap37View();
		}
		if (itemName == EQteItem.RightScreenDragItem.ToEnumString())
		{
			return new CommonQteRightScreenDragItem();
		}
		if (itemName == EQteItem.SuisuiSlideItem.ToEnumString())
		{
			return new CommonQteSuisuiSlideItem();
		}
		if (itemName == EQteItem.PlotQteDragItem.ToEnumString())
		{
			return new CommonQteCenterDragItem();
		}
		return null;
	}

	// Token: 0x06011277 RID: 70263 RVA: 0x0050A555 File Offset: 0x00508755
	public int GetQteHandleId()
	{
		return this.HandleId;
	}

	// Token: 0x06011278 RID: 70264 RVA: 0x0050A560 File Offset: 0x00508760
	public void ClearQteHandleId(int? qteHandleId = null)
	{
		int key = qteHandleId ?? this.HandleId;
		CommonQteContextBase commonQteContextBase = null;
		CommonQteContextBase commonQteContextBase2;
		if (this.Contexts != null && this.Contexts.TryGetValue(key, out commonQteContextBase2))
		{
			commonQteContextBase = commonQteContextBase2;
		}
		int num = (commonQteContextBase != null) ? commonQteContextBase.QteId : 0;
		if (num != 0)
		{
			Dictionary<int, SCommonQte> qteConfigCache = this.QteConfigCache;
			if (qteConfigCache != null)
			{
				qteConfigCache.Remove(num);
			}
			Dictionary<int, IQteResource> qteResources = this.QteResources;
			if (qteResources != null)
			{
				qteResources.Remove(num);
			}
		}
		this.HandleId = -1;
	}

	// Token: 0x06011279 RID: 70265 RVA: 0x0050A5E4 File Offset: 0x005087E4
	public CommonQteContextBase GetQteContext(int qteHandleId)
	{
		CommonQteContextBase result;
		if (this.Contexts != null && this.Contexts.TryGetValue(qteHandleId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0601127A RID: 70266 RVA: 0x0050A60C File Offset: 0x0050880C
	public IQteResource GetQteResource(int qteId, bool init = false)
	{
		if (init)
		{
			if (this.QteResources == null)
			{
				this.QteResources = new Dictionary<int, IQteResource>();
			}
			IQteResource qteResource;
			if (!this.QteResources.TryGetValue(qteId, out qteResource))
			{
				qteResource = new QteResource();
				this.QteResources[qteId] = qteResource;
			}
			return qteResource;
		}
		IQteResource result;
		if (this.QteResources != null && this.QteResources.TryGetValue(qteId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0601127B RID: 70267 RVA: 0x0050A670 File Offset: 0x00508870
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	public List<UniTask<bool>> LoadQteResource(int qteId)
	{
		if (this.QteResources != null && this.QteResources.ContainsKey(qteId))
		{
			return new List<UniTask<bool>>();
		}
		List<UniTask<bool>> list = new List<UniTask<bool>>();
		string qteIconPath = this.GetQteIconPath(qteId);
		if (!string.IsNullOrEmpty(qteIconPath))
		{
			list.Add(this.LoadQteIcon(qteId, qteIconPath));
		}
		string qteScreenEffectPath = this.GetQteScreenEffectPath(qteId, EQteScreenEffectType.Type1);
		if (!string.IsNullOrEmpty(qteScreenEffectPath))
		{
			list.Add(this.LoadQteScreenEffectType1(qteId, qteScreenEffectPath));
		}
		qteScreenEffectPath = this.GetQteScreenEffectPath(qteId, EQteScreenEffectType.Type2);
		if (!string.IsNullOrEmpty(qteScreenEffectPath))
		{
			list.Add(this.LoadQteScreenEffectType2(qteId, qteScreenEffectPath));
		}
		string qteCameraShakePath = this.GetQteCameraShakePath(qteId);
		if (!string.IsNullOrEmpty(qteCameraShakePath))
		{
			list.Add(this.LoadQteCameraShake(qteId, qteCameraShakePath));
		}
		string qteGamepadShakePath = this.GetQteGamepadShakePath(qteId);
		if (!string.IsNullOrEmpty(qteGamepadShakePath))
		{
			list.Add(this.LoadQteGamepadShake(qteId, qteGamepadShakePath));
		}
		string qteScaleCurvePath = this.GetQteScaleCurvePath(qteId);
		if (!string.IsNullOrEmpty(qteScaleCurvePath))
		{
			list.Add(this.LoadQteScaleCurve(qteId, qteScaleCurvePath));
		}
		return list;
	}

	// Token: 0x0601127C RID: 70268 RVA: 0x0050A75C File Offset: 0x0050895C
	public string GetQteIconPath(int qteId)
	{
		SCommonQte commonQteConfig = this.GetCommonQteConfig(qteId);
		if (commonQteConfig == null)
		{
			return null;
		}
		FName a = FName.NAME_None;
		if (commonQteConfig.BaseConfig.QteType == ECommonQteType.单按钮点击型)
		{
			a = commonQteConfig.BaseConfig.SingleClickConfig.UIConfig.Icon.GetAssetPathName();
		}
		else if (commonQteConfig.BaseConfig.QteType == ECommonQteType.单按钮连击型)
		{
			a = ConfigCommonParamById.GetStringConfig("ContinuousClickQTEIcon");
		}
		else if (commonQteConfig.BaseConfig.QteType == ECommonQteType.单按钮长按型)
		{
			a = commonQteConfig.BaseConfig.LongPressConfig.UIConfig.Icon.GetAssetPathName();
		}
		if (a != FName.NAME_None)
		{
			string text = a.ToString();
			if (text.Contains("UIEditor"))
			{
				text = text.Replace("UIEditor", "UIResources");
			}
			return text;
		}
		return null;
	}

	// Token: 0x0601127D RID: 70269 RVA: 0x0050A850 File Offset: 0x00508A50
	public string GetQteScreenEffectPath(int qteId, EQteScreenEffectType effectType)
	{
		SCommonQte commonQteConfig = this.GetCommonQteConfig(qteId);
		if (commonQteConfig == null)
		{
			return null;
		}
		FName a = (effectType == EQteScreenEffectType.Type1) ? commonQteConfig.ExtraConfig.ScreenEffectType1.GetAssetPathName() : commonQteConfig.ExtraConfig.ScreenEffectType2.GetAssetPathName();
		if (a != FName.NAME_None)
		{
			return a.ToString();
		}
		return null;
	}

	// Token: 0x0601127E RID: 70270 RVA: 0x0050A8B4 File Offset: 0x00508AB4
	public string GetQteCameraShakePath(int qteId)
	{
		SCommonQte commonQteConfig = this.GetCommonQteConfig(qteId);
		if (commonQteConfig == null)
		{
			return null;
		}
		FName assetPathName = commonQteConfig.ExtraConfig.CameraShake.GetAssetPathName();
		if (assetPathName != FName.NAME_None)
		{
			return assetPathName.ToString();
		}
		return null;
	}

	// Token: 0x0601127F RID: 70271 RVA: 0x0050A904 File Offset: 0x00508B04
	public string GetQteGamepadShakePath(int qteId)
	{
		SCommonQte commonQteConfig = this.GetCommonQteConfig(qteId);
		if (commonQteConfig == null)
		{
			return null;
		}
		FName assetPathName = commonQteConfig.ExtraConfig.GamepadShake.GetAssetPathName();
		if (assetPathName != FName.NAME_None)
		{
			return assetPathName.ToString();
		}
		return null;
	}

	// Token: 0x06011280 RID: 70272 RVA: 0x0050A954 File Offset: 0x00508B54
	public string GetQteScaleCurvePath(int qteId)
	{
		SCommonQte commonQteConfig = this.GetCommonQteConfig(qteId);
		if (commonQteConfig == null)
		{
			return null;
		}
		FName assetPathName = commonQteConfig.ExtraConfig.UiScaleCurve.GetAssetPathName();
		if (assetPathName != FName.NAME_None)
		{
			return assetPathName.ToString();
		}
		return null;
	}

	// Token: 0x06011281 RID: 70273 RVA: 0x0050A9A4 File Offset: 0x00508BA4
	[NullableContext(0)]
	private UniTask<bool> LoadQteIcon(int qteId, [Nullable(1)] string iconPath)
	{
		CommonQteModel.<LoadQteIcon>d__33 <LoadQteIcon>d__;
		<LoadQteIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadQteIcon>d__.<>4__this = this;
		<LoadQteIcon>d__.qteId = qteId;
		<LoadQteIcon>d__.iconPath = iconPath;
		<LoadQteIcon>d__.<>1__state = -1;
		<LoadQteIcon>d__.<>t__builder.Start<CommonQteModel.<LoadQteIcon>d__33>(ref <LoadQteIcon>d__);
		return <LoadQteIcon>d__.<>t__builder.Task;
	}

	// Token: 0x06011282 RID: 70274 RVA: 0x0050A9F8 File Offset: 0x00508BF8
	[NullableContext(0)]
	private UniTask<bool> LoadQteScreenEffectType1(int qteId, [Nullable(1)] string path)
	{
		CommonQteModel.<LoadQteScreenEffectType1>d__34 <LoadQteScreenEffectType1>d__;
		<LoadQteScreenEffectType1>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadQteScreenEffectType1>d__.<>4__this = this;
		<LoadQteScreenEffectType1>d__.qteId = qteId;
		<LoadQteScreenEffectType1>d__.path = path;
		<LoadQteScreenEffectType1>d__.<>1__state = -1;
		<LoadQteScreenEffectType1>d__.<>t__builder.Start<CommonQteModel.<LoadQteScreenEffectType1>d__34>(ref <LoadQteScreenEffectType1>d__);
		return <LoadQteScreenEffectType1>d__.<>t__builder.Task;
	}

	// Token: 0x06011283 RID: 70275 RVA: 0x0050AA4C File Offset: 0x00508C4C
	[NullableContext(0)]
	private UniTask<bool> LoadQteScreenEffectType2(int qteId, [Nullable(1)] string path)
	{
		CommonQteModel.<LoadQteScreenEffectType2>d__35 <LoadQteScreenEffectType2>d__;
		<LoadQteScreenEffectType2>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadQteScreenEffectType2>d__.<>4__this = this;
		<LoadQteScreenEffectType2>d__.qteId = qteId;
		<LoadQteScreenEffectType2>d__.path = path;
		<LoadQteScreenEffectType2>d__.<>1__state = -1;
		<LoadQteScreenEffectType2>d__.<>t__builder.Start<CommonQteModel.<LoadQteScreenEffectType2>d__35>(ref <LoadQteScreenEffectType2>d__);
		return <LoadQteScreenEffectType2>d__.<>t__builder.Task;
	}

	// Token: 0x06011284 RID: 70276 RVA: 0x0050AAA0 File Offset: 0x00508CA0
	[NullableContext(0)]
	private UniTask<bool> LoadQteCameraShake(int qteId, [Nullable(1)] string path)
	{
		CommonQteModel.<LoadQteCameraShake>d__36 <LoadQteCameraShake>d__;
		<LoadQteCameraShake>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadQteCameraShake>d__.<>4__this = this;
		<LoadQteCameraShake>d__.qteId = qteId;
		<LoadQteCameraShake>d__.path = path;
		<LoadQteCameraShake>d__.<>1__state = -1;
		<LoadQteCameraShake>d__.<>t__builder.Start<CommonQteModel.<LoadQteCameraShake>d__36>(ref <LoadQteCameraShake>d__);
		return <LoadQteCameraShake>d__.<>t__builder.Task;
	}

	// Token: 0x06011285 RID: 70277 RVA: 0x0050AAF4 File Offset: 0x00508CF4
	[NullableContext(0)]
	private UniTask<bool> LoadQteGamepadShake(int qteId, [Nullable(1)] string path)
	{
		CommonQteModel.<LoadQteGamepadShake>d__37 <LoadQteGamepadShake>d__;
		<LoadQteGamepadShake>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadQteGamepadShake>d__.<>4__this = this;
		<LoadQteGamepadShake>d__.qteId = qteId;
		<LoadQteGamepadShake>d__.path = path;
		<LoadQteGamepadShake>d__.<>1__state = -1;
		<LoadQteGamepadShake>d__.<>t__builder.Start<CommonQteModel.<LoadQteGamepadShake>d__37>(ref <LoadQteGamepadShake>d__);
		return <LoadQteGamepadShake>d__.<>t__builder.Task;
	}

	// Token: 0x06011286 RID: 70278 RVA: 0x0050AB48 File Offset: 0x00508D48
	[NullableContext(0)]
	private UniTask<bool> LoadQteScaleCurve(int qteId, [Nullable(1)] string path)
	{
		CommonQteModel.<LoadQteScaleCurve>d__38 <LoadQteScaleCurve>d__;
		<LoadQteScaleCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadQteScaleCurve>d__.<>4__this = this;
		<LoadQteScaleCurve>d__.qteId = qteId;
		<LoadQteScaleCurve>d__.path = path;
		<LoadQteScaleCurve>d__.<>1__state = -1;
		<LoadQteScaleCurve>d__.<>t__builder.Start<CommonQteModel.<LoadQteScaleCurve>d__38>(ref <LoadQteScaleCurve>d__);
		return <LoadQteScaleCurve>d__.<>t__builder.Task;
	}

	// Token: 0x06011287 RID: 70279 RVA: 0x0050AB9C File Offset: 0x00508D9C
	public void ClearPreloadCache(int? qteId = null)
	{
		if (qteId != null)
		{
			Dictionary<int, SCommonQte> qteConfigCache = this.QteConfigCache;
			if (qteConfigCache != null)
			{
				qteConfigCache.Remove(qteId.Value);
			}
			Dictionary<int, IQteResource> qteResources = this.QteResources;
			if (qteResources == null)
			{
				return;
			}
			qteResources.Remove(qteId.Value);
			return;
		}
		else
		{
			Dictionary<int, SCommonQte> qteConfigCache2 = this.QteConfigCache;
			if (qteConfigCache2 != null)
			{
				qteConfigCache2.Clear();
			}
			Dictionary<int, IQteResource> qteResources2 = this.QteResources;
			if (qteResources2 == null)
			{
				return;
			}
			qteResources2.Clear();
			return;
		}
	}

	// Token: 0x17001997 RID: 6551
	// (get) Token: 0x06011288 RID: 70280 RVA: 0x0050AC05 File Offset: 0x00508E05
	[Nullable(1)]
	public static CommonQteModel Instance
	{
		[NullableContext(1)]
		get
		{
			return CommonQteModel._Instance;
		}
	}

	// Token: 0x06011289 RID: 70281 RVA: 0x0050AC0C File Offset: 0x00508E0C
	[NullableContext(1)]
	public static CommonQteModel GetOrCreateInstance()
	{
		if (CommonQteModel._Instance == null)
		{
			CommonQteModel.CreateInstance();
		}
		return CommonQteModel._Instance;
	}

	// Token: 0x0601128A RID: 70282 RVA: 0x0050AC20 File Offset: 0x00508E20
	public static bool CreateInstance()
	{
		if (CommonQteModel._Instance != null)
		{
			return true;
		}
		CommonQteModel._Instance = new CommonQteModel();
		return true;
	}

	// Token: 0x0601128B RID: 70283 RVA: 0x0050AC36 File Offset: 0x00508E36
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601128C RID: 70284 RVA: 0x0050AC38 File Offset: 0x00508E38
	public static void ResetStaticDefaultValue()
	{
		CommonQteModel._Instance = null;
	}

	// Token: 0x0601128D RID: 70285 RVA: 0x0050AC40 File Offset: 0x00508E40
	static CommonQteModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CommonQteModel.CreateStaticDefaultValue), new Action(CommonQteModel.ResetStaticDefaultValue));
	}

	// Token: 0x040096E0 RID: 38624
	[Nullable(1)]
	private const string DT_COMMON_QTE_PATH = "/Game/Aki/Data/Qte/DT_CommonQte.DT_CommonQte";

	// Token: 0x040096E1 RID: 38625
	[Nullable(1)]
	private const string DT_COMMON_QTE_GROUP_PATH = "/Game/Aki/Data/Qte/DT_CommonQteGroup.DT_CommonQteGroup";

	// Token: 0x040096E2 RID: 38626
	[Nullable(1)]
	private const string UI_EDITOR_PATH = "UIEditor";

	// Token: 0x040096E3 RID: 38627
	[Nullable(1)]
	private const string UI_RESOURCES_PATH = "UIResources";

	// Token: 0x040096E4 RID: 38628
	private const byte RING_TAP_SINGLE_BUTTON_VIEW_TYPE = 4;

	// Token: 0x040096E5 RID: 38629
	private const byte RING_MATCH_TAP_SINGLE_BUTTON_VIEW_TYPE = 5;

	// Token: 0x040096E6 RID: 38630
	private int HandleId = -1;

	// Token: 0x040096E7 RID: 38631
	private int HandleIdCounter;

	// Token: 0x040096E8 RID: 38632
	private UDataTable CommonQteDt;

	// Token: 0x040096E9 RID: 38633
	private UDataTable CommonQteGroupDt;

	// Token: 0x040096EA RID: 38634
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, CommonQteContextBase> Contexts;

	// Token: 0x040096EB RID: 38635
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, IQteResource> QteResources;

	// Token: 0x040096EC RID: 38636
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, SCommonQte> QteConfigCache;

	// Token: 0x040096ED RID: 38637
	public bool IsRefreshMode;

	// Token: 0x040096EE RID: 38638
	private static CommonQteModel _Instance;
}
