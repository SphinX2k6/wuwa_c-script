using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013B2 RID: 5042
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewNewPlayerSupportActivityV2 : ActivitySubViewBase
{
	// Token: 0x06008DE6 RID: 36326 RVA: 0x001E973B File Offset: 0x001E793B
	protected override void OnSetData()
	{
		this.ActivityData = (this.ActivityBaseData as ActivityNewPlayerSupportActivityV2Data);
	}

	// Token: 0x06008DE7 RID: 36327 RVA: 0x001E9750 File Offset: 0x001E7950
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 5;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickRole));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickAdventureView));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickShopEntrance));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickGachaEntrance));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickTrial));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008DE8 RID: 36328 RVA: 0x001E9A14 File Offset: 0x001E7C14
	protected override void OnStart()
	{
		this.RemainTimeText = (ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null) ?? string.Empty);
		UUIText text = base.GetText(0);
		if (text != null)
		{
			ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
			text.SetText(((activityData != null) ? activityData.GetTitle() : null) ?? string.Empty, true);
		}
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.RefreshViewState();
	}

	// Token: 0x06008DE9 RID: 36329 RVA: 0x001E9A83 File Offset: 0x001E7C83
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenChanged));
	}

	// Token: 0x06008DEA RID: 36330 RVA: 0x001E9ABD File Offset: 0x001E7CBD
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenChanged));
	}

	// Token: 0x06008DEB RID: 36331 RVA: 0x001E9AF7 File Offset: 0x001E7CF7
	protected override void OnTimer(float gap)
	{
		this.RefreshRemainTime();
	}

	// Token: 0x06008DEC RID: 36332 RVA: 0x001E9AFF File Offset: 0x001E7CFF
	protected override void OnRefreshView()
	{
		this.RefreshViewState();
	}

	// Token: 0x06008DED RID: 36333 RVA: 0x001E9B07 File Offset: 0x001E7D07
	private void RefreshViewState()
	{
		this.RefreshRemainTime();
		this.RefreshTrialRoleDisplay();
		this.RefreshGachaEntrance2Visual();
		this.RefreshRoleEntranceCompositeVisual();
		this.RefreshEntranceRedDot();
	}

	// Token: 0x06008DEE RID: 36334 RVA: 0x001E9B28 File Offset: 0x001E7D28
	private void RefreshRemainTime()
	{
		if (this.ActivityData == null)
		{
			return;
		}
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		long displayRemainEndTime = this.ActivityData.GetDisplayRemainEndTime();
		if (displayRemainEndTime <= 0L || !this.ActivityData.CheckIfInShowTime())
		{
			text.SetUIActive(false);
			return;
		}
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(displayRemainEndTime, this.RemainTimeText);
		text.SetUIActive(true);
		text.SetText(remainTimeText ?? string.Empty, true);
	}

	// Token: 0x06008DEF RID: 36335 RVA: 0x001E9B9C File Offset: 0x001E7D9C
	private void OnRefreshRedDot(int activityId)
	{
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		int? num = (activityData != null) ? new int?(activityData.Id) : null;
		if (!(activityId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.RefreshViewState();
	}

	// Token: 0x06008DF0 RID: 36336 RVA: 0x001E9BE4 File Offset: 0x001E7DE4
	private void OnFunctionOpenChanged(EFunctionType functionType, bool isOpen)
	{
		if (functionType == EFunctionType.DailyActivity)
		{
			this.RefreshViewState();
		}
	}

	// Token: 0x06008DF1 RID: 36337 RVA: 0x001E9BF4 File Offset: 0x001E7DF4
	private void OnClickRole()
	{
		ActivityNewPlayerSupportActivityV2Controller.ReportEntranceClick(ENewPlayerSupportEntrance.Liveness);
		if (!ActivitySubViewNewPlayerSupportActivityV2.IsExperienceBonusLivenessEntranceUnlocked())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("NewPlayer_Experience_002", Array.Empty<object>());
			return;
		}
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		if (activityData != null)
		{
			activityData.MarkLivenessEntranceClicked();
		}
		AdventureGuideViewOpenData param = new AdventureGuideViewOpenData
		{
			OpenTabViewName = new EUiTabViewName?(EUiTabViewName.DailyActivityTabView),
			SkipAdventureManualRequest = true
		};
		UiManager.Instance.OpenView(EUiViewName.AdventureGuideView, param, null);
	}

	// Token: 0x06008DF2 RID: 36338 RVA: 0x001E9C62 File Offset: 0x001E7E62
	private void OnClickAdventureView()
	{
		ActivityNewPlayerSupportActivityV2Controller.ReportEntranceClick(ENewPlayerSupportEntrance.GiftPack);
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		if (activityData != null)
		{
			activityData.MarkGiftPackEntranceClicked();
		}
		ActivityNewPlayerSupportActivityV2Controller controller = this.GetController();
		if (controller == null)
		{
			return;
		}
		controller.OpenAdventureV2View();
	}

	// Token: 0x06008DF3 RID: 36339 RVA: 0x001E9C8B File Offset: 0x001E7E8B
	private void OnClickShopEntrance()
	{
		ActivityNewPlayerSupportActivityV2Controller.ReportEntranceClick(ENewPlayerSupportEntrance.WeekCard);
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		if (activityData != null)
		{
			activityData.MarkWeekCardEntranceClicked();
		}
		PayShopController instance = PayShopController.Instance;
		Func<PayShopJumpParam> tabResolver;
		if ((tabResolver = ActivitySubViewNewPlayerSupportActivityV2.<>O.<0>__ResolveWeekCardShopJumpParam) == null)
		{
			tabResolver = (ActivitySubViewNewPlayerSupportActivityV2.<>O.<0>__ResolveWeekCardShopJumpParam = new Func<PayShopJumpParam>(ActivityNewPlayerSupportActivityV2Controller.ResolveWeekCardShopJumpParam));
		}
		instance.OpenPayShopViewWithTabResolver(tabResolver);
	}

	// Token: 0x06008DF4 RID: 36340 RVA: 0x001E9CCC File Offset: 0x001E7ECC
	private void OnClickGachaEntrance()
	{
		ActivityNewPlayerSupportActivityV2Controller.ReportEntranceClick(ENewPlayerSupportEntrance.Gacha);
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		if (activityData != null)
		{
			activityData.MarkGachaEntranceClicked();
		}
		ActivityNewPlayerSupportActivityV2Data activityData2 = this.ActivityData;
		int? num = (activityData2 != null) ? activityData2.GetGachaOpenTabIdOrDefault() : null;
		GachaController.Instance.OpenGachaView(num.GetValueOrDefault());
	}

	// Token: 0x06008DF5 RID: 36341 RVA: 0x001E9D1C File Offset: 0x001E7F1C
	private void OnClickTrial()
	{
		ActivityNewPlayerSupportActivityV2Controller controller = this.GetController();
		if (controller == null)
		{
			return;
		}
		controller.OpenTrialRoleView(null);
	}

	// Token: 0x06008DF6 RID: 36342 RVA: 0x001E9D42 File Offset: 0x001E7F42
	[NullableContext(2)]
	private ActivityNewPlayerSupportActivityV2Controller GetController()
	{
		if (this.ActivityData == null || this.ActivityData.Type == ActivityType.Parkour)
		{
			return null;
		}
		return ActivityManager.GetActivityController(this.ActivityData.Type) as ActivityNewPlayerSupportActivityV2Controller;
	}

	// Token: 0x06008DF7 RID: 36343 RVA: 0x001E9D70 File Offset: 0x001E7F70
	private void RefreshTrialRoleDisplay()
	{
		ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
		int? num;
		if (activityData == null)
		{
			num = null;
		}
		else
		{
			TrialRoleGroupData curUseTrialRoleData = activityData.CurUseTrialRoleData;
			num = ((curUseTrialRoleData != null) ? new int?(curUseTrialRoleData.RealRoleId) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		bool flag = valueOrDefault > 0;
		bool isRover = flag && RoleModel.Instance.IsMainRole(valueOrDefault);
		RoleInfo? roleConfig = flag ? RoleConfig.Instance.GetRoleConfig(valueOrDefault) : null;
		ActivityNewPlayerSupportActivityV2Data activityData2 = this.ActivityData;
		ValueTuple<string, string>? valueTuple = (activityData2 != null) ? activityData2.GetCurrentTrialRoleDisplayResourceIds() : null;
		this.RefreshRoleRelatedPanels(flag);
		string text;
		if ((text = this.ResolveTexturePath((valueTuple != null) ? valueTuple.GetValueOrDefault().Item2 : null)) == null)
		{
			text = (((roleConfig != null) ? roleConfig.GetValueOrDefault().Card : null) ?? string.Empty);
		}
		string bgPath = text;
		string text2;
		if (!flag)
		{
			text2 = this.GetSilhouetteTexturePathByGender();
		}
		else if ((text2 = this.ResolveTexturePath((valueTuple != null) ? valueTuple.GetValueOrDefault().Item1 : null)) == null)
		{
			text2 = (((roleConfig != null) ? roleConfig.GetValueOrDefault().FormationRoleCard : null) ?? string.Empty);
		}
		string rolePath = text2;
		this.RefreshBgTexture(flag, isRover, bgPath);
		this.RefreshRoleTexture(flag, rolePath);
		this.RefreshTrialButtonText(flag, roleConfig);
	}

	// Token: 0x06008DF8 RID: 36344 RVA: 0x001E9ECC File Offset: 0x001E80CC
	private void RefreshTrialButtonText(bool hasRole, RoleInfo? roleConfig)
	{
		UUIText text = base.GetText(12);
		if (text == null)
		{
			return;
		}
		text.SetGameRichText(true);
		text.SetRichText(true);
		if (hasRole && roleConfig != null)
		{
			string text2 = ConfigMultiTextLang.GetLocalTextNew(roleConfig.Value.Name, null) ?? string.Empty;
			LguiUtil.Instance.SetLocalTextNew(text, "NewPlayer_Trial_002", new string[]
			{
				text2
			});
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, "NewPlayer_Trial_001", Array.Empty<object>());
	}

	// Token: 0x06008DF9 RID: 36345 RVA: 0x001E9F4F File Offset: 0x001E814F
	private void RefreshRoleRelatedPanels(bool hasRole)
	{
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(hasRole);
		}
		UUIItem item2 = base.GetItem(8);
		if (item2 != null)
		{
			item2.SetUIActive(hasRole);
		}
		UUIItem item3 = base.GetItem(11);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(!hasRole);
	}

	// Token: 0x06008DFA RID: 36346 RVA: 0x001E9F90 File Offset: 0x001E8190
	private void RefreshBgTexture(bool hasRole, bool isRover, string bgPath)
	{
		UUITexture texture = base.GetTexture(9);
		if (texture == null)
		{
			return;
		}
		bool flag = hasRole && !isRover && !string.IsNullOrEmpty(bgPath);
		texture.SetUIActive(flag);
		if (flag)
		{
			base.SetTextureByPath(bgPath, texture, null, null);
		}
	}

	// Token: 0x06008DFB RID: 36347 RVA: 0x001E9FDC File Offset: 0x001E81DC
	private void RefreshRoleTexture(bool hasRole, string rolePath)
	{
		UUITexture texture = base.GetTexture(10);
		if (texture == null)
		{
			return;
		}
		bool flag = !string.IsNullOrEmpty(rolePath);
		texture.SetUIActive(flag);
		if (flag)
		{
			base.SetTextureByPath(rolePath, texture, null, null);
		}
	}

	// Token: 0x06008DFC RID: 36348 RVA: 0x001EA01C File Offset: 0x001E821C
	private string GetSilhouetteTexturePathByGender()
	{
		string resourceIdOrPath = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? "T_PrivilegeRoleRoverMale" : "T_PrivilegeRoleRoverFemale";
		return this.ResolveTexturePath(resourceIdOrPath) ?? string.Empty;
	}

	// Token: 0x06008DFD RID: 36349 RVA: 0x001EA054 File Offset: 0x001E8254
	[NullableContext(2)]
	private string ResolveTexturePath(string resourceIdOrPath)
	{
		if (string.IsNullOrWhiteSpace(resourceIdOrPath))
		{
			return null;
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceIdOrPath.Trim());
		if (!string.IsNullOrWhiteSpace(resourcePath))
		{
			return resourcePath;
		}
		return null;
	}

	// Token: 0x06008DFE RID: 36350 RVA: 0x001EA088 File Offset: 0x001E8288
	private void RefreshEntranceRedDot()
	{
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			ActivityNewPlayerSupportActivityV2Data activityData = this.ActivityData;
			item.SetUIActive(activityData != null && activityData.GetTrialRoleEntranceRedDotState());
		}
		int componentType = 2;
		ActivityNewPlayerSupportActivityV2Data activityData2 = this.ActivityData;
		this.SetEntranceButtonRedDotVisible(componentType, activityData2 != null && activityData2.GetLivenessEntranceRedDotState());
		int componentType2 = 3;
		ActivityNewPlayerSupportActivityV2Data activityData3 = this.ActivityData;
		this.SetEntranceButtonRedDotVisible(componentType2, activityData3 != null && activityData3.GetGiftPackEntranceRedDotState());
		int componentType3 = 4;
		ActivityNewPlayerSupportActivityV2Data activityData4 = this.ActivityData;
		this.SetEntranceButtonRedDotVisible(componentType3, activityData4 != null && activityData4.GetWeekCardEntranceRedDotState());
		int componentType4 = 5;
		ActivityNewPlayerSupportActivityV2Data activityData5 = this.ActivityData;
		this.SetEntranceButtonRedDotVisible(componentType4, activityData5 != null && activityData5.GetGachaEntranceRedDotState());
	}

	// Token: 0x06008DFF RID: 36351 RVA: 0x001EA120 File Offset: 0x001E8320
	private void RefreshGachaEntrance2Visual()
	{
		UUIItem uuiitem = this.TryGetNestedUiItem(5, 1);
		UUIItem uuiitem2 = this.TryGetNestedUiItem(5, 2);
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(true);
		}
		if (uuiitem2 != null)
		{
			uuiitem2.SetUIActive(false);
		}
	}

	// Token: 0x06008E00 RID: 36352 RVA: 0x001EA154 File Offset: 0x001E8354
	private void RefreshRoleEntranceCompositeVisual()
	{
		bool flag = ActivitySubViewNewPlayerSupportActivityV2.IsExperienceBonusLivenessEntranceUnlocked();
		UUIItem uuiitem = this.TryGetNestedUiItem(2, 1);
		UUIItem uuiitem2 = this.TryGetNestedUiItem(2, 2);
		UUIText uuitext = this.TryGetNestedText(2, 3);
		if (uuiitem != null || uuiitem2 != null)
		{
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(flag);
			}
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(!flag);
			}
		}
		if (uuitext != null)
		{
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(uuitext, "NewPlayer_Experience_004", Array.Empty<object>());
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(uuitext, "NewPlayer_Experience_003", Array.Empty<object>());
			}
		}
		this.ApplyExperienceBonusRoleButtonLockExtension(!flag);
	}

	// Token: 0x06008E01 RID: 36353 RVA: 0x001EA1DB File Offset: 0x001E83DB
	private static bool IsExperienceBonusLivenessEntranceUnlocked()
	{
		return FunctionModel.Instance.IsOpen(10023005);
	}

	// Token: 0x06008E02 RID: 36354 RVA: 0x001EA1EC File Offset: 0x001E83EC
	private void ApplyExperienceBonusRoleButtonLockExtension(bool showLockVisual)
	{
		UUIButtonComponent button = base.GetButton(2);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(true);
		button.SetEnable(true);
		ActivitySubViewNewPlayerSupportActivityV2.InvokeOptionalButtonMethod(button, "SetLivenessLock", showLockVisual);
		ActivitySubViewNewPlayerSupportActivityV2.InvokeOptionalButtonMethod(button, "RefreshLivenessLock", showLockVisual);
		ActivitySubViewNewPlayerSupportActivityV2.InvokeOptionalButtonMethod(button, "SetShowLock", showLockVisual);
	}

	// Token: 0x06008E03 RID: 36355 RVA: 0x001EA238 File Offset: 0x001E8438
	private static void InvokeOptionalButtonMethod(UUIButtonComponent button, string methodName, bool arg)
	{
		MethodInfo method = button.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);
		ParameterInfo[] array = (method != null) ? method.GetParameters() : null;
		if (array != null && array.Length == 1 && array[0].ParameterType == typeof(bool))
		{
			method.Invoke(button, new object[]
			{
				arg
			});
		}
	}

	// Token: 0x06008E04 RID: 36356 RVA: 0x001EA29C File Offset: 0x001E849C
	[NullableContext(2)]
	private ULGUIComponentsRegistry GetNestedRegistryForButton(int buttonType)
	{
		UUIButtonComponent button = base.GetButton(buttonType);
		AUIBaseActor auibaseActor = ((button != null) ? button.GetOwner() : null) as AUIBaseActor;
		if (auibaseActor == null || !auibaseActor.IsValid())
		{
			return null;
		}
		ULGUIComponentsRegistry ulguicomponentsRegistry = LguiUtil.Instance.GetComponentsRegistry(auibaseActor);
		if (ulguicomponentsRegistry == null || !ulguicomponentsRegistry.IsValid())
		{
			AUIBaseActor auibaseActor2 = LguiUtil.Instance.GetChildActorByHierarchyIndex(auibaseActor, 0);
			ulguicomponentsRegistry = ((auibaseActor2 != null) ? LguiUtil.Instance.GetComponentsRegistry(auibaseActor2) : null);
			if (ulguicomponentsRegistry == null || !ulguicomponentsRegistry.IsValid())
			{
				auibaseActor2 = ((auibaseActor2 != null) ? LguiUtil.Instance.GetChildActorByHierarchyIndex(auibaseActor2, 0) : null);
				ulguicomponentsRegistry = ((auibaseActor2 != null) ? LguiUtil.Instance.GetComponentsRegistry(auibaseActor2) : null);
			}
		}
		if (ulguicomponentsRegistry == null || !ulguicomponentsRegistry.IsValid())
		{
			return null;
		}
		return ulguicomponentsRegistry;
	}

	// Token: 0x06008E05 RID: 36357 RVA: 0x001EA348 File Offset: 0x001E8548
	[NullableContext(2)]
	private UUIItem TryGetNestedUiItem(int buttonType, int index)
	{
		ULGUIComponentsRegistry nestedRegistryForButton = this.GetNestedRegistryForButton(buttonType);
		if (nestedRegistryForButton == null || index >= nestedRegistryForButton.Components.Num())
		{
			return null;
		}
		AActor aactor = nestedRegistryForButton.Components.Get(index);
		return ((aactor != null) ? aactor.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
	}

	// Token: 0x06008E06 RID: 36358 RVA: 0x001EA398 File Offset: 0x001E8598
	[NullableContext(2)]
	private UUIText TryGetNestedText(int buttonType, int index)
	{
		ULGUIComponentsRegistry nestedRegistryForButton = this.GetNestedRegistryForButton(buttonType);
		if (nestedRegistryForButton == null || index >= nestedRegistryForButton.Components.Num())
		{
			return null;
		}
		AActor aactor = nestedRegistryForButton.Components.Get(index);
		return ((aactor != null) ? aactor.GetComponentByClass(UUIText.StaticClass()) : null) as UUIText;
	}

	// Token: 0x06008E07 RID: 36359 RVA: 0x001EA3E8 File Offset: 0x001E85E8
	private void SetEntranceButtonRedDotVisible(int componentType, bool visible)
	{
		UUIItem uuiitem = this.TryGetNestedUiItem(componentType, 4);
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(visible);
			return;
		}
		UUIButtonComponent button = base.GetButton(componentType);
		MethodInfo methodInfo = (button != null) ? button.GetType().GetMethod("SetRedDotVisible", new Type[]
		{
			typeof(bool)
		}) : null;
		if (methodInfo == null)
		{
			return;
		}
		methodInfo.Invoke(button, new object[]
		{
			visible
		});
	}

	// Token: 0x06008E08 RID: 36360 RVA: 0x001EA458 File Offset: 0x001E8658
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "TrialRoleBtn"))
		{
			return null;
		}
		UUIButtonComponent button = base.GetButton(6);
		UUIItem uuiitem = (button != null) ? button.RootUIComp.Get() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x04003EEF RID: 16111
	private const string NewPlayerSupportV2MaleSilhouetteResourceId = "T_PrivilegeRoleRoverMale";

	// Token: 0x04003EF0 RID: 16112
	private const string NewPlayerSupportV2FemaleSilhouetteResourceId = "T_PrivilegeRoleRoverFemale";

	// Token: 0x04003EF1 RID: 16113
	[Nullable(2)]
	private ActivityNewPlayerSupportActivityV2Data ActivityData;

	// Token: 0x04003EF2 RID: 16114
	private string RemainTimeText = string.Empty;

	// Token: 0x02007A26 RID: 31270
	[NullableContext(0)]
	private class EComponentType
	{
		// Token: 0x04028353 RID: 164691
		public const int TxtTitle = 0;

		// Token: 0x04028354 RID: 164692
		public const int TxtRestTime = 1;

		// Token: 0x04028355 RID: 164693
		public const int BtnRole = 2;

		// Token: 0x04028356 RID: 164694
		public const int BtnGift = 3;

		// Token: 0x04028357 RID: 164695
		public const int BtnLuckDraw = 4;

		// Token: 0x04028358 RID: 164696
		public const int BtnEntrance2 = 5;

		// Token: 0x04028359 RID: 164697
		public const int BtnTrial = 6;

		// Token: 0x0402835A RID: 164698
		public const int TrialRoleStarLayout = 7;

		// Token: 0x0402835B RID: 164699
		public const int Star = 8;

		// Token: 0x0402835C RID: 164700
		public const int TexBg = 9;

		// Token: 0x0402835D RID: 164701
		public const int TexRole = 10;

		// Token: 0x0402835E RID: 164702
		public const int RoverDecoration = 11;

		// Token: 0x0402835F RID: 164703
		public const int TxtBtnTrialName = 12;

		// Token: 0x04028360 RID: 164704
		public const int TrialBtnRedDot = 13;
	}

	// Token: 0x02007A27 RID: 31271
	[NullableContext(0)]
	private static class ECompositeEntranceNested
	{
		// Token: 0x04028361 RID: 164705
		public const int PnlIconNor = 1;

		// Token: 0x04028362 RID: 164706
		public const int IconLock = 2;

		// Token: 0x04028363 RID: 164707
		public const int TxtDescription = 3;

		// Token: 0x04028364 RID: 164708
		public const int RedDot = 4;
	}

	// Token: 0x02007A28 RID: 31272
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04028365 RID: 164709
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<PayShopJumpParam> <0>__ResolveWeekCardShopJumpParam;
	}
}
