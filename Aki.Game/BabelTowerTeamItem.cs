using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200118B RID: 4491
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerTeamItem : UiPanelBase
{
	// Token: 0x060076D8 RID: 30424 RVA: 0x0018C130 File Offset: 0x0018A330
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060076D9 RID: 30425 RVA: 0x0018C27C File Offset: 0x0018A47C
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerTeamItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerTeamItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060076DA RID: 30426 RVA: 0x0018C2BF File Offset: 0x0018A4BF
	private void OnClickButton()
	{
		Action onClickBtnCallBack = this.OnClickBtnCallBack;
		if (onClickBtnCallBack == null)
		{
			return;
		}
		onClickBtnCallBack();
	}

	// Token: 0x060076DB RID: 30427 RVA: 0x0018C2D1 File Offset: 0x0018A4D1
	private BabelTowerTeamRoleItem CreateTeamRoleItem()
	{
		return new BabelTowerTeamRoleItem();
	}

	// Token: 0x060076DC RID: 30428 RVA: 0x0018C2D8 File Offset: 0x0018A4D8
	public void RefreshItem(List<int> roleList, int instanceId)
	{
		GenericLayout<BabelTowerTeamRoleItem, int> teamLayout = this.TeamLayout;
		if (teamLayout != null)
		{
			teamLayout.RefreshByData(roleList, null, false);
		}
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		foreach (CommonElementItem commonElementItem in this.ElementItemArray)
		{
			commonElementItem.SetActive(false);
		}
		if (config != null)
		{
			InstanceDungeon valueOrDefault = config.GetValueOrDefault();
			for (int i = 0; i < valueOrDefault.RecommendElementLength; i++)
			{
				int num = valueOrDefault.RecommendElement(i);
				if (num != 0)
				{
					this.ElementItemArray[i].SetActive(true);
					this.ElementItemArray[i].Refresh(num, false, i);
				}
			}
		}
		int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(instanceId, WorldLevelModel.Instance.CurWorldLevel);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BossRushRecommendLevel", new <>z__ReadOnlySingleElementList<object>(recommendLevel));
	}

	// Token: 0x060076DD RID: 30429 RVA: 0x0018C3E0 File Offset: 0x0018A5E0
	public void RefreshSkillBranchIcon()
	{
		if (this.TeamLayout == null)
		{
			return;
		}
		foreach (BabelTowerTeamRoleItem babelTowerTeamRoleItem in this.TeamLayout.GetLayoutItemList())
		{
			babelTowerTeamRoleItem.RefreshSkillBranchIcon();
		}
	}

	// Token: 0x04003681 RID: 13953
	[Nullable(2)]
	private CommonElementItem ElementItem1;

	// Token: 0x04003682 RID: 13954
	[Nullable(2)]
	private CommonElementItem ElementItem2;

	// Token: 0x04003683 RID: 13955
	private readonly List<CommonElementItem> ElementItemArray = new List<CommonElementItem>();

	// Token: 0x04003684 RID: 13956
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<BabelTowerTeamRoleItem, int> TeamLayout;

	// Token: 0x04003685 RID: 13957
	[Nullable(2)]
	public Action OnClickBtnCallBack;

	// Token: 0x0200776E RID: 30574
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04027657 RID: 161367
		public const int Button = 0;

		// Token: 0x04027658 RID: 161368
		public const int RecommendLevelText = 1;

		// Token: 0x04027659 RID: 161369
		public const int RecommendElementText = 2;

		// Token: 0x0402765A RID: 161370
		public const int RecommendElementItem1 = 3;

		// Token: 0x0402765B RID: 161371
		public const int RecommendElementItem2 = 4;

		// Token: 0x0402765C RID: 161372
		public const int TeamHorizontalScrollView = 5;

		// Token: 0x0402765D RID: 161373
		public const int TeamItem = 6;
	}
}
