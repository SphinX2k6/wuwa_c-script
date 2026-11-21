using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003DC RID: 988
[NullableContext(1)]
[Nullable(0)]
public class AchievementGroupSmallItem : UiPanelBase, IDynamicScrollItem<AchievementGroupData>
{
	// Token: 0x060035CD RID: 13773 RVA: 0x0013B9C4 File Offset: 0x00139BC4
	public UniTask Init(UUIItem actor)
	{
		AchievementGroupSmallItem.<Init>d__2 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementGroupSmallItem.<Init>d__2>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060035CE RID: 13774 RVA: 0x0013BA0F File Offset: 0x00139C0F
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x060035CF RID: 13775 RVA: 0x0013BA18 File Offset: 0x00139C18
	public AUIBaseActor GetUsingItem(AchievementGroupData data)
	{
		return (AUIBaseActor)base.GetRootItem().GetOwner();
	}

	// Token: 0x060035D0 RID: 13776 RVA: 0x0013BA2A File Offset: 0x00139C2A
	public void Update(AchievementGroupData data, int index)
	{
		this.AchievementGroupData = data;
		this.RefreshDesc(data);
		this.RefreshRedPointState(data);
		this.RefreshToggleState();
		this.RefreshProgress();
	}

	// Token: 0x060035D1 RID: 13777 RVA: 0x0013BA50 File Offset: 0x00139C50
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060035D2 RID: 13778 RVA: 0x0013BB7A File Offset: 0x00139D7A
	protected override void OnStart()
	{
		this.AddEventListener();
	}

	// Token: 0x060035D3 RID: 13779 RVA: 0x0013BB84 File Offset: 0x00139D84
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAchievementGroupChange, new Action(this.OnAchievementGroupChange));
		EventSystem.Instance.Add<int>(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
		EventSystem.Instance.Add<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x060035D4 RID: 13780 RVA: 0x0013BBE8 File Offset: 0x00139DE8
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementGroupChange, new Action(this.OnAchievementGroupChange));
		EventSystem.Instance.Remove(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
		EventSystem.Instance.Remove(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x060035D5 RID: 13781 RVA: 0x0013BC4C File Offset: 0x00139E4C
	private void OnAchievementDataWithIdNotify(int dataId)
	{
		int groupId = AchievementModel.Instance.GetAchievementData(dataId).GetGroupId();
		AchievementGroupData achievementGroupData = this.AchievementGroupData;
		int? num = (achievementGroupData != null) ? new int?(achievementGroupData.GetId()) : null;
		if (groupId == num.GetValueOrDefault() & num != null)
		{
			this.RefreshProgress();
			this.RefreshRedPointState(this.AchievementGroupData);
		}
	}

	// Token: 0x060035D6 RID: 13782 RVA: 0x0013BCAE File Offset: 0x00139EAE
	private void OnAchievementGroupDataNotify(int groupId)
	{
		AchievementGroupData achievementGroupData = this.AchievementGroupData;
		if (achievementGroupData != null && achievementGroupData.GetId() == groupId)
		{
			this.RefreshProgress();
			this.RefreshRedPointState(this.AchievementGroupData);
		}
	}

	// Token: 0x060035D7 RID: 13783 RVA: 0x0013BCD9 File Offset: 0x00139ED9
	private void OnAchievementGroupChange()
	{
		this.RefreshToggleState();
	}

	// Token: 0x060035D8 RID: 13784 RVA: 0x0013BCE1 File Offset: 0x00139EE1
	private void OnClickToggle(EToggleState state)
	{
		AchievementModel.Instance.CurrentSelectGroup = this.AchievementGroupData;
		EventSystem.Instance.Emit(EEventName.OnAchievementGroupChange);
	}

	// Token: 0x060035D9 RID: 13785 RVA: 0x0013BD04 File Offset: 0x00139F04
	private void RefreshToggleState()
	{
		if (this.AchievementGroupData == null)
		{
			return;
		}
		if (base.GetRootItem() == null)
		{
			return;
		}
		EToggleState etoggleState = (AchievementModel.Instance.CurrentSelectGroup == this.AchievementGroupData) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (base.GetExtendToggle(1).ToggleState != etoggleState)
		{
			base.GetExtendToggle(1).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x060035DA RID: 13786 RVA: 0x0013BD5C File Offset: 0x00139F5C
	private void RefreshProgress()
	{
		string achievementGroupProgress = this.AchievementGroupData.GetAchievementGroupProgress();
		base.GetText(3).SetText(achievementGroupProgress, true);
	}

	// Token: 0x060035DB RID: 13787 RVA: 0x0013BD84 File Offset: 0x00139F84
	private void RefreshDesc(AchievementGroupData data)
	{
		base.GetText(0).SetText(data.GetTitle(), true);
		UUITexture texture = base.GetTexture(2);
		base.SetTextureByPath(data.GetSmallIcon(), texture, null, null);
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data.GetRewards().Count > 0);
	}

	// Token: 0x060035DC RID: 13788 RVA: 0x0013BDE2 File Offset: 0x00139FE2
	private void RefreshRedPointState(AchievementGroupData data)
	{
		base.GetItem(4).SetUIActive(data.SmallItemRedPoint());
	}

	// Token: 0x060035DD RID: 13789 RVA: 0x0013BDF6 File Offset: 0x00139FF6
	protected override void OnBeforeDestroy()
	{
		if (this.AchievementGroupData != null)
		{
			this.AchievementGroupData = null;
		}
		if (this.ItemSizeVector != null)
		{
			this.ItemSizeVector = null;
		}
		this.RemoveEventListener();
	}

	// Token: 0x04002D36 RID: 11574
	[Nullable(2)]
	private AchievementGroupData AchievementGroupData;

	// Token: 0x04002D37 RID: 11575
	[Nullable(2)]
	private Vector2D ItemSizeVector;
}
