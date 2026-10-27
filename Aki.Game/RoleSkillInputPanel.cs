using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020028B9 RID: 10425
public class RoleSkillInputPanel : UiPanelBase
{
	// Token: 0x060157F7 RID: 88055 RVA: 0x0056BE60 File Offset: 0x0056A060
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickTrailBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060157F8 RID: 88056 RVA: 0x0056C099 File Offset: 0x0056A299
	protected override void OnStart()
	{
		this.FeatureDescLayout = new GenericLayout<RoleSkillInputDescItem, string>(base.GetVerticalLayout(1), new Func<RoleSkillInputDescItem>(this.InitSkillDescItem), null, false, true);
		this.BaseEmptyHeight = base.GetItem(13).Height;
	}

	// Token: 0x060157F9 RID: 88057 RVA: 0x0056C0CF File Offset: 0x0056A2CF
	[NullableContext(1)]
	private RoleSkillInputDescItem InitSkillDescItem()
	{
		return new RoleSkillInputDescItem();
	}

	// Token: 0x060157FA RID: 88058 RVA: 0x0056C0D8 File Offset: 0x0056A2D8
	private void OnClickTrailBtn()
	{
		if (GameModeController.Instance.IsInInstance())
		{
			GenericPromptController.Instance.ShowPromptByCode("RoleGuideNotice01", Array.Empty<object>());
			return;
		}
		if (FormationDataController.Instance.GlobalIsInFight)
		{
			GenericPromptController.Instance.ShowPromptByCode("RoleGuideNotice06", Array.Empty<object>());
			return;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			GenericPromptController.Instance.ShowPromptByCode("RoleGuideNotice05", Array.Empty<object>());
			return;
		}
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(this.RoleId).Value;
		string roleName = RoleConfig.Instance.GetRoleName(value.Name);
		int dungeonId = value.RoleGuide;
		if (dungeonId == 0)
		{
			GenericPromptController.Instance.ShowPromptByCode("RoleGuideNotice02", new object[]
			{
				roleName
			});
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleTeachTip);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			roleName
		});
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			int fightFormationId = InstanceDungeonConfig.Instance.GetConfig(dungeonId).Value.FightFormationId;
			Aki.Config.FightFormation? fightFormation;
			int[] array = (FormationConfig.Instance.GetFightFormationConfig(fightFormationId) != null) ? fightFormation.GetValueOrDefault().AutoRole() : null;
			if (((array != null) ? array.Length : 0) > 0)
			{
				List<int> list = new List<int>();
				foreach (int id in array)
				{
					list.Add(RoleConfig.Instance.GetTrialRoleIdConfigByGroupId(id));
				}
				RoleTeachEnterCtx roleTeachEnterCtx = RoleTeachEnterCtx.Create();
				roleTeachEnterCtx.RoleId = this.RoleId;
				InstanceDungeonModel.Instance.InstanceEnterContentText.RoleTeachCtx = roleTeachEnterCtx;
				InstanceDungeonController.Instance.PrewarTeamFightRequest(dungeonId, list, 0, 0, null, null).Forget<bool>();
				return;
			}
			Log.Instance.Error(ELogModule.Role, ELogAuthor.LZK, "未配置出战人物", default(ReadOnlySpan<ValueTuple<string, object>>));
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060157FB RID: 88059 RVA: 0x0056C1EC File Offset: 0x0056A3EC
	public void Refresh(int roleId, bool isTrial, bool showSkipButton = false)
	{
		RoleSkillInputPanel.<>c__DisplayClass9_0 CS$<>8__locals1 = new RoleSkillInputPanel.<>c__DisplayClass9_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.roleId = roleId;
		CS$<>8__locals1.isTrial = isTrial;
		CS$<>8__locals1.showSkipButton = showSkipButton;
		UiAsyncTask task = new UiAsyncTask("Refresh", delegate()
		{
			RoleSkillInputPanel.<>c__DisplayClass9_0.<<Refresh>b__0>d <<Refresh>b__0>d;
			<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
			<<Refresh>b__0>d.<>1__state = -1;
			<<Refresh>b__0>d.<>t__builder.Start<RoleSkillInputPanel.<>c__DisplayClass9_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
			return <<Refresh>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060157FC RID: 88060 RVA: 0x0056C23C File Offset: 0x0056A43C
	public UniTask RefreshUiAsync(int roleId, bool isTrial, bool showSkipButton = false)
	{
		RoleSkillInputPanel.<RefreshUiAsync>d__10 <RefreshUiAsync>d__;
		<RefreshUiAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshUiAsync>d__.<>4__this = this;
		<RefreshUiAsync>d__.roleId = roleId;
		<RefreshUiAsync>d__.isTrial = isTrial;
		<RefreshUiAsync>d__.showSkipButton = showSkipButton;
		<RefreshUiAsync>d__.<>1__state = -1;
		<RefreshUiAsync>d__.<>t__builder.Start<RoleSkillInputPanel.<RefreshUiAsync>d__10>(ref <RefreshUiAsync>d__);
		return <RefreshUiAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060157FD RID: 88061 RVA: 0x0056C297 File Offset: 0x0056A497
	public void SetFeatureActive(bool isShow)
	{
		base.GetItem(0).SetUIActive(isShow);
		base.GetItem(10).SetUIActive(isShow);
	}

	// Token: 0x060157FE RID: 88062 RVA: 0x0056C2B4 File Offset: 0x0056A4B4
	public void SetTrickActive(bool isShow)
	{
		base.GetItem(12).SetUIActive(isShow);
		base.GetVerticalLayout(2).RootUIComp.Get().SetUIActive(isShow);
	}

	// Token: 0x060157FF RID: 88063 RVA: 0x0056C2E9 File Offset: 0x0056A4E9
	public void SetEmptyActive(bool isShow)
	{
		if (isShow)
		{
			this.FeatureDescLayout.BindLateUpdate(delegate(float _)
			{
				float height = base.GetRootItem().Height;
				float height2 = base.GetItem(0).Height;
				float height3 = base.GetVerticalLayout(1).RootUIComp.Get().Height;
				float num = height - height2 - height3;
				if (num < this.BaseEmptyHeight)
				{
					base.GetItem(13).SetUIActive(false);
					return;
				}
				base.GetItem(13).SetHeight(num);
				this.FeatureDescLayout.UnBindLateUpdate();
			});
		}
		base.GetItem(13).SetUIActive(isShow);
	}

	// Token: 0x0400A039 RID: 41017
	private int RoleId;

	// Token: 0x0400A03A RID: 41018
	private float BaseEmptyHeight;

	// Token: 0x0400A03B RID: 41019
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleSkillInputDescItem, string> FeatureDescLayout;

	// Token: 0x0400A03C RID: 41020
	private bool HasRefresh;

	// Token: 0x02008EB9 RID: 36537
	private enum EComponent
	{
		// Token: 0x0402E474 RID: 189556
		FeatureTitleItem,
		// Token: 0x0402E475 RID: 189557
		FeatureDescLayout,
		// Token: 0x0402E476 RID: 189558
		TrickLayout,
		// Token: 0x0402E477 RID: 189559
		TrickSmallTitleItem,
		// Token: 0x0402E478 RID: 189560
		TrickSkillTexItem,
		// Token: 0x0402E479 RID: 189561
		TrickSkillDescItem,
		// Token: 0x0402E47A RID: 189562
		TrickSkillInputItem,
		// Token: 0x0402E47B RID: 189563
		TrickLineItem,
		// Token: 0x0402E47C RID: 189564
		TrailItem,
		// Token: 0x0402E47D RID: 189565
		TrailBtn,
		// Token: 0x0402E47E RID: 189566
		FeatureDescItem,
		// Token: 0x0402E47F RID: 189567
		TrickItem,
		// Token: 0x0402E480 RID: 189568
		TrickTitleItem,
		// Token: 0x0402E481 RID: 189569
		EmptyItem
	}
}
