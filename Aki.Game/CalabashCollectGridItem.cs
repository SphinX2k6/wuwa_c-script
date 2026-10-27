using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001740 RID: 5952
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CalabashCollectGridItem : GridProxyAbstract<CalabashDevelopRewardData>
{
	// Token: 0x0600AC35 RID: 44085 RVA: 0x002698E8 File Offset: 0x00267AE8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout))
		};
		Action<EToggleState> item = delegate(EToggleState toggleState)
		{
			Action<int> onToggleClick = this.OnToggleClick;
			if (onToggleClick == null)
			{
				return;
			}
			onToggleClick(base.GridIndex);
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, item)
		};
	}

	// Token: 0x0600AC36 RID: 44086 RVA: 0x00269994 File Offset: 0x00267B94
	protected override UniTask OnBeforeStartAsync()
	{
		CalabashCollectGridItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CalabashCollectGridItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AC37 RID: 44087 RVA: 0x002699D7 File Offset: 0x00267BD7
	[NullableContext(1)]
	private CalabashCollectStarItem CreateStarItem()
	{
		return new CalabashCollectStarItem();
	}

	// Token: 0x0600AC38 RID: 44088 RVA: 0x002699E0 File Offset: 0x00267BE0
	[NullableContext(1)]
	public override void Refresh(CalabashDevelopRewardData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		int monsterId = data.DevelopRewardData.MonsterId;
		ICalabashDevelopRewardInfoData[] calabashDevelopRewardInfoData = CalabashModel.Instance.GetCalabashDevelopRewardInfoData(monsterId);
		List<bool> list = new List<bool>();
		int num = 0;
		ICalabashDevelopRewardInfoData[] array = calabashDevelopRewardInfoData;
		for (int i = 0; i < array.Length; i++)
		{
			bool isUnlock = array[i].IsUnlock;
			list.Add(isUnlock);
			if (isUnlock)
			{
				num++;
			}
		}
		if (data.UnlockData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.SkillName, Array.Empty<object>());
		}
		else
		{
			string monsterNumber = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(monsterId).Value.MonsterNumber;
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(monsterNumber + "???", true);
			}
		}
		this.MonsterItem.Refresh(new VisionDetailMonsterItemData(data.DevelopRewardData.MonsterId, num, 0), false, 0);
		GenericLayout<CalabashCollectStarItem, bool> starLayout = this.StarLayout;
		if (starLayout != null)
		{
			starLayout.RefreshByData(list, null, false);
		}
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(state, false, false, false);
		}
		if (isSelected)
		{
			CalabashModel instance = CalabashModel.Instance;
			if (instance != null)
			{
				instance.RecordMonsterId(monsterId);
			}
		}
		this.RefreshNewItem();
	}

	// Token: 0x0600AC39 RID: 44089 RVA: 0x00269B1C File Offset: 0x00267D1C
	public override void OnSelected(bool fireEvent)
	{
		int monsterId = this.Data.DevelopRewardData.MonsterId;
		if (this.NewState)
		{
			CalabashModel instance = CalabashModel.Instance;
			if (instance != null)
			{
				instance.RecordMonsterId(monsterId);
			}
			this.RefreshNewItem();
		}
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600AC3A RID: 44090 RVA: 0x00269B6E File Offset: 0x00267D6E
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600AC3B RID: 44091 RVA: 0x00269B88 File Offset: 0x00267D88
	public void RefreshNewItem()
	{
		this.NewState = (this.Data.UnlockData && !CalabashModel.Instance.CheckMonsterIdInRecord(this.Data.DevelopRewardData.MonsterId));
		base.GetItem(3).SetUIActive(this.NewState);
	}

	// Token: 0x04004E1D RID: 19997
	private CalabashDevelopRewardData Data;

	// Token: 0x04004E1E RID: 19998
	private VisionDetailMonsterItem MonsterItem;

	// Token: 0x04004E1F RID: 19999
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CalabashCollectStarItem, bool> StarLayout;

	// Token: 0x04004E20 RID: 20000
	private bool NewState;

	// Token: 0x04004E21 RID: 20001
	public Func<int, bool> CanToggleChange;

	// Token: 0x04004E22 RID: 20002
	public Action<int> OnToggleClick;

	// Token: 0x02007D28 RID: 32040
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028FD0 RID: 167888
		Toggle,
		// Token: 0x04028FD1 RID: 167889
		MonsterItem,
		// Token: 0x04028FD2 RID: 167890
		NameText,
		// Token: 0x04028FD3 RID: 167891
		NewItem,
		// Token: 0x04028FD4 RID: 167892
		StarLayout
	}
}
