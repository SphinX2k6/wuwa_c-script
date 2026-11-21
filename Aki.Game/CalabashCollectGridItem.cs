using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000BF9 RID: 3065
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CalabashCollectGridItem : GridProxyAbstract<CalabashDevelopRewardData>
{
	// Token: 0x0600801C RID: 32796 RVA: 0x00273D24 File Offset: 0x00271F24
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

	// Token: 0x0600801D RID: 32797 RVA: 0x00273DD0 File Offset: 0x00271FD0
	protected override UniTask OnBeforeStartAsync()
	{
		CalabashCollectGridItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CalabashCollectGridItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600801E RID: 32798 RVA: 0x00273E13 File Offset: 0x00272013
	[NullableContext(1)]
	private CalabashCollectStarItem CreateStarItem()
	{
		return new CalabashCollectStarItem();
	}

	// Token: 0x0600801F RID: 32799 RVA: 0x00273E1C File Offset: 0x0027201C
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

	// Token: 0x06008020 RID: 32800 RVA: 0x00273F58 File Offset: 0x00272158
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

	// Token: 0x06008021 RID: 32801 RVA: 0x00273FAA File Offset: 0x002721AA
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06008022 RID: 32802 RVA: 0x00273FC4 File Offset: 0x002721C4
	public void RefreshNewItem()
	{
		this.NewState = (this.Data.UnlockData && !CalabashModel.Instance.CheckMonsterIdInRecord(this.Data.DevelopRewardData.MonsterId));
		base.GetItem(3).SetUIActive(this.NewState);
	}

	// Token: 0x04004EC6 RID: 20166
	private CalabashDevelopRewardData Data;

	// Token: 0x04004EC7 RID: 20167
	private VisionDetailMonsterItem MonsterItem;

	// Token: 0x04004EC8 RID: 20168
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CalabashCollectStarItem, bool> StarLayout;

	// Token: 0x04004EC9 RID: 20169
	private bool NewState;

	// Token: 0x04004ECA RID: 20170
	public Func<int, bool> CanToggleChange;

	// Token: 0x04004ECB RID: 20171
	public Action<int> OnToggleClick;

	// Token: 0x02006EAE RID: 28334
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040242FA RID: 148218
		Toggle,
		// Token: 0x040242FB RID: 148219
		MonsterItem,
		// Token: 0x040242FC RID: 148220
		NameText,
		// Token: 0x040242FD RID: 148221
		NewItem,
		// Token: 0x040242FE RID: 148222
		StarLayout
	}
}
