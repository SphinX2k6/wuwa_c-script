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

// Token: 0x02000F27 RID: 3879
[NullableContext(1)]
[Nullable(0)]
public class AchievementGroupSmallItem : UiPanelBase, IDynamicScrollItem<AchievementGroupData>
{
	// Token: 0x06006235 RID: 25141 RVA: 0x0013309C File Offset: 0x0013129C
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

	// Token: 0x06006236 RID: 25142 RVA: 0x001330E7 File Offset: 0x001312E7
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x06006237 RID: 25143 RVA: 0x001330F0 File Offset: 0x001312F0
	public AUIBaseActor GetUsingItem(AchievementGroupData data)
	{
		return (AUIBaseActor)base.GetRootItem().GetOwner();
	}

	// Token: 0x06006238 RID: 25144 RVA: 0x00133102 File Offset: 0x00131302
	public void Update(AchievementGroupData data, int index)
	{
		this.AchievementGroupData = data;
		this.RefreshDesc(data);
		this.RefreshRedPointState(data);
		this.RefreshToggleState();
		this.RefreshProgress();
	}

	// Token: 0x06006239 RID: 25145 RVA: 0x00133128 File Offset: 0x00131328
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

	// Token: 0x0600623A RID: 25146 RVA: 0x00133252 File Offset: 0x00131452
	protected override void OnStart()
	{
		this.AddEventListener();
	}

	// Token: 0x0600623B RID: 25147 RVA: 0x0013325C File Offset: 0x0013145C
	protected void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAchievementGroupChange, new Action(this.OnAchievementGroupChange));
		EventSystem.Instance.Add<int>(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
		EventSystem.Instance.Add<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x0600623C RID: 25148 RVA: 0x001332C0 File Offset: 0x001314C0
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementGroupChange, new Action(this.OnAchievementGroupChange));
		EventSystem.Instance.Remove(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
		EventSystem.Instance.Remove(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x0600623D RID: 25149 RVA: 0x00133324 File Offset: 0x00131524
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

	// Token: 0x0600623E RID: 25150 RVA: 0x00133386 File Offset: 0x00131586
	private void OnAchievementGroupDataNotify(int groupId)
	{
		AchievementGroupData achievementGroupData = this.AchievementGroupData;
		if (achievementGroupData != null && achievementGroupData.GetId() == groupId)
		{
			this.RefreshProgress();
			this.RefreshRedPointState(this.AchievementGroupData);
		}
	}

	// Token: 0x0600623F RID: 25151 RVA: 0x001333B1 File Offset: 0x001315B1
	private void OnAchievementGroupChange()
	{
		this.RefreshToggleState();
	}

	// Token: 0x06006240 RID: 25152 RVA: 0x001333B9 File Offset: 0x001315B9
	private void OnClickToggle(EToggleState state)
	{
		AchievementModel.Instance.CurrentSelectGroup = this.AchievementGroupData;
		EventSystem.Instance.Emit(EEventName.OnAchievementGroupChange);
	}

	// Token: 0x06006241 RID: 25153 RVA: 0x001333DC File Offset: 0x001315DC
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

	// Token: 0x06006242 RID: 25154 RVA: 0x00133434 File Offset: 0x00131634
	private void RefreshProgress()
	{
		string achievementGroupProgress = this.AchievementGroupData.GetAchievementGroupProgress();
		base.GetText(3).SetText(achievementGroupProgress, true);
	}

	// Token: 0x06006243 RID: 25155 RVA: 0x0013345C File Offset: 0x0013165C
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

	// Token: 0x06006244 RID: 25156 RVA: 0x001334BA File Offset: 0x001316BA
	private void RefreshRedPointState(AchievementGroupData data)
	{
		base.GetItem(4).SetUIActive(data.SmallItemRedPoint());
	}

	// Token: 0x06006245 RID: 25157 RVA: 0x001334CE File Offset: 0x001316CE
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

	// Token: 0x04002C9D RID: 11421
	[Nullable(2)]
	private AchievementGroupData AchievementGroupData;

	// Token: 0x04002C9E RID: 11422
	[Nullable(2)]
	private Vector2D ItemSizeVector;
}
