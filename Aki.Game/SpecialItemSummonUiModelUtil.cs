using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001FB7 RID: 8119
[NullableContext(1)]
[Nullable(0)]
public static class SpecialItemSummonUiModelUtil
{
	// Token: 0x06014262 RID: 82530 RVA: 0x005E1A81 File Offset: 0x005DFC81
	public static void CreateSummon()
	{
		UiSceneManager.Instance.InitSpecialItemSummonSkeletalHandle();
	}

	// Token: 0x06014263 RID: 82531 RVA: 0x005E1A8D File Offset: 0x005DFC8D
	public static void DestroySummon()
	{
		UiSceneManager.Instance.DestroySpecialItemSummonSkeletalHandle();
	}

	// Token: 0x06014264 RID: 82532 RVA: 0x005E1A99 File Offset: 0x005DFC99
	[NullableContext(2)]
	public static UiModelBase GetSummonModel()
	{
		SkeletalObserverHandle specialItemSummonSkeletalHandle = UiSceneManager.Instance.GetSpecialItemSummonSkeletalHandle();
		if (specialItemSummonSkeletalHandle == null)
		{
			return null;
		}
		return specialItemSummonSkeletalHandle.Model;
	}

	// Token: 0x06014265 RID: 82533 RVA: 0x005E1AB0 File Offset: 0x005DFCB0
	public static void ShowSummon(bool isShow)
	{
		UiModelBase summonModel = SpecialItemSummonUiModelUtil.GetSummonModel();
		if (summonModel == null)
		{
			return;
		}
		UiModelUtil.Instance.SetVisible(summonModel, isShow);
	}

	// Token: 0x06014266 RID: 82534 RVA: 0x005E1AD4 File Offset: 0x005DFCD4
	public static void SetTransform(string caseTag)
	{
		UiModelBase summonModel = SpecialItemSummonUiModelUtil.GetSummonModel();
		if (summonModel == null)
		{
			return;
		}
		UiModelActorComponent uiModelActorComponent = summonModel.CheckGetComponent<UiModelActorComponent>();
		if (uiModelActorComponent == null)
		{
			return;
		}
		uiModelActorComponent.SetTransformByTag(caseTag);
	}

	// Token: 0x06014267 RID: 82535 RVA: 0x005E1AFC File Offset: 0x005DFCFC
	public static void PlayDisplayMontage(string montagePath, string sectionName)
	{
		UiModelBase summonModel = SpecialItemSummonUiModelUtil.GetSummonModel();
		if (summonModel == null)
		{
			Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.TZJ, "[SpecialItemSummon] PlayDisplayMontage model为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UiModelAnimationComponent uiModelAnimationComponent = summonModel.CheckGetComponent<UiModelAnimationComponent>();
		if (uiModelAnimationComponent == null)
		{
			Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.TZJ, "[SpecialItemSummon] PlayDisplayMontage 动画组件为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UAnimMontage loadedMontage = SpecialItemSummonUiModelUtil.GetLoadedMontage(montagePath);
		if (loadedMontage == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCommon;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "[SpecialItemSummon] 展示蒙太奇未预加载";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("montagePath", montagePath);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		uiModelAnimationComponent.PlayMontage(loadedMontage);
		uiModelAnimationComponent.JumpToSection(FNameUtil.GetDynamicFName(sectionName).Value, loadedMontage);
	}

	// Token: 0x06014268 RID: 82536 RVA: 0x005E1BA8 File Offset: 0x005DFDA8
	public static void JumpToDisplaySection(string montagePath, string sectionName)
	{
		UiModelBase summonModel = SpecialItemSummonUiModelUtil.GetSummonModel();
		UiModelAnimationComponent uiModelAnimationComponent = (summonModel != null) ? summonModel.CheckGetComponent<UiModelAnimationComponent>() : null;
		UAnimMontage loadedMontage = SpecialItemSummonUiModelUtil.GetLoadedMontage(montagePath);
		if (uiModelAnimationComponent == null || loadedMontage == null)
		{
			return;
		}
		uiModelAnimationComponent.JumpToSection(FNameUtil.GetDynamicFName(sectionName).Value, loadedMontage);
	}

	// Token: 0x06014269 RID: 82537 RVA: 0x005E1BEC File Offset: 0x005DFDEC
	public static FName? GetCurrentDisplaySection()
	{
		UiModelBase summonModel = SpecialItemSummonUiModelUtil.GetSummonModel();
		UiModelAnimationComponent uiModelAnimationComponent = (summonModel != null) ? summonModel.CheckGetComponent<UiModelAnimationComponent>() : null;
		if (uiModelAnimationComponent == null)
		{
			return null;
		}
		return uiModelAnimationComponent.GetCurrentSection();
	}

	// Token: 0x0601426A RID: 82538 RVA: 0x005E1C1D File Offset: 0x005DFE1D
	[return: Nullable(2)]
	public static UAnimMontage GetLoadedMontage(string montagePath)
	{
		UiModelBase summonModel = SpecialItemSummonUiModelUtil.GetSummonModel();
		UiModelLoadComponent uiModelLoadComponent = (summonModel != null) ? summonModel.CheckGetComponent<UiModelLoadComponent>() : null;
		return ((uiModelLoadComponent != null) ? uiModelLoadComponent.GetLoadedResource(montagePath) : null) as UAnimMontage;
	}

	// Token: 0x0601426B RID: 82539 RVA: 0x005E1C42 File Offset: 0x005DFE42
	public static void StopDisplayMontage()
	{
		UiModelBase summonModel = SpecialItemSummonUiModelUtil.GetSummonModel();
		UiModelAnimationComponent uiModelAnimationComponent = (summonModel != null) ? summonModel.CheckGetComponent<UiModelAnimationComponent>() : null;
		if (uiModelAnimationComponent == null)
		{
			return;
		}
		uiModelAnimationComponent.StopMontage(0f);
	}

	// Token: 0x0601426C RID: 82540 RVA: 0x005E1C64 File Offset: 0x005DFE64
	public static void LoadSummon(int modelId, string displayMontagePath = "", [Nullable(2)] Action onLoadFinished = null)
	{
		SpecialItemSummonUiModelUtil.<>c__DisplayClass10_0 CS$<>8__locals1 = new SpecialItemSummonUiModelUtil.<>c__DisplayClass10_0();
		CS$<>8__locals1.onLoadFinished = onLoadFinished;
		UiModelBase summonModel = SpecialItemSummonUiModelUtil.GetSummonModel();
		if (summonModel == null)
		{
			Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.TZJ, "[SpecialItemSummon] LoadSummon model为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UiModelLoadComponent uiModelLoadComponent = summonModel.CheckGetComponent<UiModelLoadComponent>();
		List<string> list = new List<string>();
		if (displayMontagePath != "")
		{
			list.Add(displayMontagePath);
		}
		uiModelLoadComponent.LoadModelByModelId(modelId, true, new Action(CS$<>8__locals1.<LoadSummon>g__FinishCallBack|0), list);
	}
}
