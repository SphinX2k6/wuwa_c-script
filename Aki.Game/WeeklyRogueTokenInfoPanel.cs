using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D47 RID: 11591
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueTokenInfoPanel : UiPanelBase
{
	// Token: 0x060185B0 RID: 99760 RVA: 0x00633538 File Offset: 0x00631738
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

	// Token: 0x060185B1 RID: 99761 RVA: 0x00633618 File Offset: 0x00631818
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueTokenInfoPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueTokenInfoPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060185B2 RID: 99762 RVA: 0x0063365B File Offset: 0x0063185B
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

	// Token: 0x060185B3 RID: 99763 RVA: 0x00633680 File Offset: 0x00631880
	private void OnTokenSelectedChange(int tokenId, bool selectOn)
	{
		if (!selectOn)
		{
			return;
		}
		this.RefreshSelectOn(tokenId);
	}

	// Token: 0x060185B4 RID: 99764 RVA: 0x0063368D File Offset: 0x0063188D
	[NullableContext(1)]
	private bool OnCanExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		return (int)data > 0;
	}

	// Token: 0x060185B5 RID: 99765 RVA: 0x00633698 File Offset: 0x00631898
	[NullableContext(1)]
	private WeeklyRogueTokenInfoGrid CreateTokenItem()
	{
		WeeklyRogueTokenInfoGrid weeklyRogueTokenInfoGrid = new WeeklyRogueTokenInfoGrid();
		weeklyRogueTokenInfoGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanExecuteChange));
		weeklyRogueTokenInfoGrid.OnSelectedChange = new Action<int, bool>(this.OnTokenSelectedChange);
		return weeklyRogueTokenInfoGrid;
	}

	// Token: 0x060185B6 RID: 99766 RVA: 0x006336C4 File Offset: 0x006318C4
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

	// Token: 0x060185B7 RID: 99767 RVA: 0x00633818 File Offset: 0x00631A18
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

	// Token: 0x060185B8 RID: 99768 RVA: 0x00633844 File Offset: 0x00631A44
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

	// Token: 0x060185B9 RID: 99769 RVA: 0x00633900 File Offset: 0x00631B00
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

	// Token: 0x0400B4C5 RID: 46277
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<WeeklyRogueTokenInfoGrid, int> CoreTokenLayout;

	// Token: 0x0400B4C6 RID: 46278
	protected WeeklyRogueArtifactGrid ArtifactGrid;

	// Token: 0x0400B4C7 RID: 46279
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<WeeklyRogueTokenInfoGrid, int> TokenLayout;

	// Token: 0x0400B4C8 RID: 46280
	protected WeeklyRogueTokenItem TokenItem;

	// Token: 0x0400B4C9 RID: 46281
	protected WeeklyRogueArtifactItem ArtifactItem;

	// Token: 0x0400B4CA RID: 46282
	protected int SelectOnTokenId = -1;

	// Token: 0x020092D7 RID: 37591
	[NullableContext(0)]
	private enum EWeeklyRogueTokenInfoPanelDefine
	{
		// Token: 0x0402F75D RID: 194397
		ItemArtifact,
		// Token: 0x0402F75E RID: 194398
		TxtCoreToken,
		// Token: 0x0402F75F RID: 194399
		CoreTokenLayout,
		// Token: 0x0402F760 RID: 194400
		CoreTokenItem,
		// Token: 0x0402F761 RID: 194401
		TokenLayout,
		// Token: 0x0402F762 RID: 194402
		TokenItem,
		// Token: 0x0402F763 RID: 194403
		EmptyItem,
		// Token: 0x0402F764 RID: 194404
		TokenTips,
		// Token: 0x0402F765 RID: 194405
		ArtifactTips
	}
}
