using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A3C RID: 10812
[NullableContext(1)]
[Nullable(0)]
public static class SpecialItemSummonUiModelUtil
{
	// Token: 0x06016841 RID: 92225 RVA: 0x005B5919 File Offset: 0x005B3B19
	public static void CreateSummon()
	{
		UiSceneManager.Instance.InitSpecialItemSummonSkeletalHandle();
	}

	// Token: 0x06016842 RID: 92226 RVA: 0x005B5925 File Offset: 0x005B3B25
	public static void DestroySummon()
	{
		UiSceneManager.Instance.DestroySpecialItemSummonSkeletalHandle();
	}

	// Token: 0x06016843 RID: 92227 RVA: 0x005B5931 File Offset: 0x005B3B31
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

	// Token: 0x06016844 RID: 92228 RVA: 0x005B5948 File Offset: 0x005B3B48
	public static void ShowSummon(bool isShow)
	{
		UiModelBase summonModel = SpecialItemSummonUiModelUtil.GetSummonModel();
		if (summonModel == null)
		{
			return;
		}
		UiModelUtil.Instance.SetVisible(summonModel, isShow);
	}

	// Token: 0x06016845 RID: 92229 RVA: 0x005B596C File Offset: 0x005B3B6C
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

	// Token: 0x06016846 RID: 92230 RVA: 0x005B5994 File Offset: 0x005B3B94
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

	// Token: 0x06016847 RID: 92231 RVA: 0x005B5A40 File Offset: 0x005B3C40
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

	// Token: 0x06016848 RID: 92232 RVA: 0x005B5A84 File Offset: 0x005B3C84
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

	// Token: 0x06016849 RID: 92233 RVA: 0x005B5AB5 File Offset: 0x005B3CB5
	[return: Nullable(2)]
	public static UAnimMontage GetLoadedMontage(string montagePath)
	{
		UiModelBase summonModel = SpecialItemSummonUiModelUtil.GetSummonModel();
		UiModelLoadComponent uiModelLoadComponent = (summonModel != null) ? summonModel.CheckGetComponent<UiModelLoadComponent>() : null;
		return ((uiModelLoadComponent != null) ? uiModelLoadComponent.GetLoadedResource(montagePath) : null) as UAnimMontage;
	}

	// Token: 0x0601684A RID: 92234 RVA: 0x005B5ADA File Offset: 0x005B3CDA
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

	// Token: 0x0601684B RID: 92235 RVA: 0x005B5AFC File Offset: 0x005B3CFC
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
