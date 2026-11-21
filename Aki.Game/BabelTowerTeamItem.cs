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

// Token: 0x0200063F RID: 1599
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerTeamItem : UiPanelBase
{
	// Token: 0x06004A6F RID: 19055 RVA: 0x00194CE0 File Offset: 0x00192EE0
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

	// Token: 0x06004A70 RID: 19056 RVA: 0x00194E2C File Offset: 0x0019302C
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerTeamItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerTeamItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004A71 RID: 19057 RVA: 0x00194E6F File Offset: 0x0019306F
	private void OnClickButton()
	{
		Action onClickBtnCallBack = this.OnClickBtnCallBack;
		if (onClickBtnCallBack == null)
		{
			return;
		}
		onClickBtnCallBack();
	}

	// Token: 0x06004A72 RID: 19058 RVA: 0x00194E81 File Offset: 0x00193081
	private BabelTowerTeamRoleItem CreateTeamRoleItem()
	{
		return new BabelTowerTeamRoleItem();
	}

	// Token: 0x06004A73 RID: 19059 RVA: 0x00194E88 File Offset: 0x00193088
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

	// Token: 0x06004A74 RID: 19060 RVA: 0x00194F90 File Offset: 0x00193190
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

	// Token: 0x0400371A RID: 14106
	[Nullable(2)]
	private CommonElementItem ElementItem1;

	// Token: 0x0400371B RID: 14107
	[Nullable(2)]
	private CommonElementItem ElementItem2;

	// Token: 0x0400371C RID: 14108
	private readonly List<CommonElementItem> ElementItemArray = new List<CommonElementItem>();

	// Token: 0x0400371D RID: 14109
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<BabelTowerTeamRoleItem, int> TeamLayout;

	// Token: 0x0400371E RID: 14110
	[Nullable(2)]
	public Action OnClickBtnCallBack;

	// Token: 0x020068FB RID: 26875
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04022990 RID: 141712
		public const int Button = 0;

		// Token: 0x04022991 RID: 141713
		public const int RecommendLevelText = 1;

		// Token: 0x04022992 RID: 141714
		public const int RecommendElementText = 2;

		// Token: 0x04022993 RID: 141715
		public const int RecommendElementItem1 = 3;

		// Token: 0x04022994 RID: 141716
		public const int RecommendElementItem2 = 4;

		// Token: 0x04022995 RID: 141717
		public const int TeamHorizontalScrollView = 5;

		// Token: 0x04022996 RID: 141718
		public const int TeamItem = 6;
	}
}
