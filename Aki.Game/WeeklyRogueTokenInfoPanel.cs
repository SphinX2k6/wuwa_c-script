using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022A1 RID: 8865
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueTokenInfoPanel : UiPanelBase
{
	// Token: 0x06015E52 RID: 89682 RVA: 0x00659548 File Offset: 0x00657748
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
	}

	// Token: 0x06015E53 RID: 89683 RVA: 0x00659628 File Offset: 0x00657828
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueTokenInfoPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueTokenInfoPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015E54 RID: 89684 RVA: 0x0065966B File Offset: 0x0065786B
	protected override void OnStart()
	{
		this.RefreshArtifact();
		this.RefreshCoreBuff();
		this.RefreshBuff();
		WeeklyRogueArtifactGrid artifactGrid = this.ArtifactGrid;
		if (artifactGrid == null)
		{
			return;
		}
		artifactGrid.OnSelected(true);
	}

	// Token: 0x06015E55 RID: 89685 RVA: 0x00659690 File Offset: 0x00657890
	private void OnTokenSelectedChange(int tokenId, bool selectOn)
	{
		if (!selectOn)
		{
			return;
		}
		this.RefreshSelectOn(tokenId);
	}

	// Token: 0x06015E56 RID: 89686 RVA: 0x0065969D File Offset: 0x0065789D
	[NullableContext(1)]
	private bool OnCanExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		return (int)data > 0;
	}

	// Token: 0x06015E57 RID: 89687 RVA: 0x006596A8 File Offset: 0x006578A8
	[NullableContext(1)]
	private WeeklyRogueTokenInfoGrid CreateTokenItem()
	{
		WeeklyRogueTokenInfoGrid weeklyRogueTokenInfoGrid = new WeeklyRogueTokenInfoGrid();
		weeklyRogueTokenInfoGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanExecuteChange));
		weeklyRogueTokenInfoGrid.OnSelectedChange = new Action<int, bool>(this.OnTokenSelectedChange);
		return weeklyRogueTokenInfoGrid;
	}

	// Token: 0x06015E58 RID: 89688 RVA: 0x006596D4 File Offset: 0x006578D4
	private void RefreshSelectOn(int tokenId)
	{
		if (this.SelectOnTokenId > 0)
		{
			RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(this.SelectOnTokenId);
			if (rogueWeeklyBuffPool == null)
			{
				return;
			}
			int buffType = rogueWeeklyBuffPool.Value.BuffType;
			if (buffType != 1)
			{
				if (buffType != 2)
				{
					GenericLayout<WeeklyRogueTokenInfoGrid, int> tokenLayout = this.TokenLayout;
					if (tokenLayout != null)
					{
						WeeklyRogueTokenInfoGrid layoutItemByKey = tokenLayout.GetLayoutItemByKey(this.SelectOnTokenId);
						if (layoutItemByKey != null)
						{
							layoutItemByKey.OnDeselected(false);
						}
					}
				}
				else
				{
					GenericLayout<WeeklyRogueTokenInfoGrid, int> coreTokenLayout = this.CoreTokenLayout;
					if (coreTokenLayout != null)
					{
						WeeklyRogueTokenInfoGrid layoutItemByKey2 = coreTokenLayout.GetLayoutItemByKey(this.SelectOnTokenId);
						if (layoutItemByKey2 != null)
						{
							layoutItemByKey2.OnDeselected(false);
						}
					}
				}
			}
			else
			{
				WeeklyRogueArtifactGrid artifactGrid = this.ArtifactGrid;
				if (artifactGrid != null)
				{
					artifactGrid.OnDeselected(false);
				}
			}
		}
		RogueWeeklyBuffPool? rogueWeeklyBuffPool2 = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(tokenId);
		if (rogueWeeklyBuffPool2 == null)
		{
			return;
		}
		if (rogueWeeklyBuffPool2.Value.BuffType == 1)
		{
			WeeklyRogueTokenItem tokenItem = this.TokenItem;
			if (tokenItem != null)
			{
				tokenItem.SetActive(false);
			}
			WeeklyRogueArtifactItem artifactItem = this.ArtifactItem;
			if (artifactItem != null)
			{
				artifactItem.UpdateByConfigId(tokenId);
			}
			WeeklyRogueArtifactItem artifactItem2 = this.ArtifactItem;
			if (artifactItem2 != null)
			{
				artifactItem2.SetActive(true);
			}
		}
		else
		{
			WeeklyRogueArtifactItem artifactItem3 = this.ArtifactItem;
			if (artifactItem3 != null)
			{
				artifactItem3.SetActive(false);
			}
			WeeklyRogueTokenItem tokenItem2 = this.TokenItem;
			if (tokenItem2 != null)
			{
				tokenItem2.UpdateByConfigId(tokenId);
			}
			WeeklyRogueTokenItem tokenItem3 = this.TokenItem;
			if (tokenItem3 != null)
			{
				tokenItem3.SetActive(true);
			}
		}
		this.SelectOnTokenId = tokenId;
	}

	// Token: 0x06015E59 RID: 89689 RVA: 0x00659828 File Offset: 0x00657A28
	private void RefreshArtifact()
	{
		int artifactBuffId = WeeklyRogueModel.Instance.GetArtifactBuffId();
		WeeklyRogueArtifactGrid artifactGrid = this.ArtifactGrid;
		if (artifactGrid == null)
		{
			return;
		}
		artifactGrid.Refresh(artifactBuffId, true, 0);
	}

	// Token: 0x06015E5A RID: 89690 RVA: 0x00659854 File Offset: 0x00657A54
	private void RefreshCoreBuff()
	{
		int artifactBuffId = WeeklyRogueModel.Instance.GetArtifactBuffId();
		List<int> coreTokenIdListByArtifactId = WeeklyRogueModel.Instance.GetCoreTokenIdListByArtifactId(artifactBuffId);
		List<int> buffIdListByType = WeeklyRogueModel.Instance.GetBuffIdListByType(EWeeklyRogueBuffType.CoreToken);
		List<int> list = new List<int>();
		for (int i = 0; i < coreTokenIdListByArtifactId.Count; i++)
		{
			if (i < buffIdListByType.Count)
			{
				list.Add(buffIdListByType[i]);
			}
			else
			{
				list.Add(0);
			}
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "WeRogueOverviewCoreBuff", new <>z__ReadOnlyArray<object>(new object[]
		{
			buffIdListByType.Count,
			coreTokenIdListByArtifactId.Count
		}));
		GenericLayout<WeeklyRogueTokenInfoGrid, int> coreTokenLayout = this.CoreTokenLayout;
		if (coreTokenLayout == null)
		{
			return;
		}
		coreTokenLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06015E5B RID: 89691 RVA: 0x00659910 File Offset: 0x00657B10
	private void RefreshBuff()
	{
		List<int> buffIdListByType = WeeklyRogueModel.Instance.GetBuffIdListByType(EWeeklyRogueBuffType.Token);
		List<int> buffIdListByType2 = WeeklyRogueModel.Instance.GetBuffIdListByType(EWeeklyRogueBuffType.Modifier);
		buffIdListByType.AddRange(buffIdListByType2);
		GenericLayout<WeeklyRogueTokenInfoGrid, int> tokenLayout = this.TokenLayout;
		if (tokenLayout != null)
		{
			tokenLayout.SetActive(buffIdListByType.Count > 0);
		}
		if (buffIdListByType.Count > 0)
		{
			GenericLayout<WeeklyRogueTokenInfoGrid, int> tokenLayout2 = this.TokenLayout;
			if (tokenLayout2 != null)
			{
				tokenLayout2.RefreshByData(buffIdListByType, null, false);
			}
		}
		base.GetItem(6).SetUIActive(buffIdListByType.Count == 0);
	}

	// Token: 0x0400B83A RID: 47162
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<WeeklyRogueTokenInfoGrid, int> CoreTokenLayout;

	// Token: 0x0400B83B RID: 47163
	protected WeeklyRogueArtifactGrid ArtifactGrid;

	// Token: 0x0400B83C RID: 47164
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<WeeklyRogueTokenInfoGrid, int> TokenLayout;

	// Token: 0x0400B83D RID: 47165
	protected WeeklyRogueTokenItem TokenItem;

	// Token: 0x0400B83E RID: 47166
	protected WeeklyRogueArtifactItem ArtifactItem;

	// Token: 0x0400B83F RID: 47167
	protected int SelectOnTokenId = -1;

	// Token: 0x020084FE RID: 34046
	[NullableContext(0)]
	private enum EWeeklyRogueTokenInfoPanelDefine
	{
		// Token: 0x0402ADE5 RID: 175589
		ItemArtifact,
		// Token: 0x0402ADE6 RID: 175590
		TxtCoreToken,
		// Token: 0x0402ADE7 RID: 175591
		CoreTokenLayout,
		// Token: 0x0402ADE8 RID: 175592
		CoreTokenItem,
		// Token: 0x0402ADE9 RID: 175593
		TokenLayout,
		// Token: 0x0402ADEA RID: 175594
		TokenItem,
		// Token: 0x0402ADEB RID: 175595
		EmptyItem,
		// Token: 0x0402ADEC RID: 175596
		TokenTips,
		// Token: 0x0402ADED RID: 175597
		ArtifactTips
	}
}
