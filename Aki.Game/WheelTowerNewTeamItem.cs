using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000A78 RID: 2680
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	2
})]
public class WheelTowerNewTeamItem : GridProxyAbstract<TeamChallengeInfo>
{
	// Token: 0x17000D9E RID: 3486
	// (get) Token: 0x060071C5 RID: 29125 RVA: 0x0022EE27 File Offset: 0x0022D027
	// (set) Token: 0x060071C6 RID: 29126 RVA: 0x0022EE2F File Offset: 0x0022D02F
	public Action<int> OnToggleCallback { get; set; }

	// Token: 0x060071C7 RID: 29127 RVA: 0x0022EE38 File Offset: 0x0022D038
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060071C8 RID: 29128 RVA: 0x0022F070 File Offset: 0x0022D270
	protected override void OnStart()
	{
		base.GetExtendToggle(7).bLockStateOnSelect = true;
		this.RoleIconLayout = new GenericLayout<WheelTowerRoleItem, RoleDataWithBranch>(base.GetHorizontalLayout(1), new Func<WheelTowerRoleItem>(this.CreateRoleItem), null, false, true);
	}

	// Token: 0x060071C9 RID: 29129 RVA: 0x0022F0A0 File Offset: 0x0022D2A0
	public override void Refresh(TeamChallengeInfo data, bool isSelected, int gridIndex)
	{
		this.Round = gridIndex;
		int num = gridIndex + 1;
		this.NumberFirst = num / 10;
		this.NumberSecond = num % 10;
		if (this.NumberFirst == 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "WheelTower_Team_Number", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.NumberFirst,
				this.NumberSecond
			}));
		}
		else
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#ffffff>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberFirst);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberSecond);
				defaultInterpolatedStringHandler.AppendLiteral("</color>");
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}
		bool flag = data != null;
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUIItem item2 = base.GetItem(11);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		UUIItem item3 = base.GetItem(12);
		if (item3 != null)
		{
			item3.SetUIActive(!flag);
		}
		UUIItem item4 = base.GetItem(13);
		if (item4 != null)
		{
			item4.SetUIActive(flag);
		}
		UUIItem item5 = base.GetItem(8);
		if (item5 != null)
		{
			item5.SetUIActive(!flag);
		}
		UUIItem item6 = base.GetItem(9);
		if (item6 != null)
		{
			item6.SetUIActive(flag);
		}
		List<RoleDataWithBranch> list = new List<RoleDataWithBranch>();
		if (data != null)
		{
			bool endlessMode = WheelTowerModel.Instance.EndlessMode;
			UUIText text2 = base.GetText(4);
			if (text2 != null)
			{
				text2.SetUIActive(endlessMode);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "WheelTower_BossProgress_Endless", new <>z__ReadOnlySingleElementList<object>(data.LastMonsterInfoPreview.Round));
			ValueTuple<int, int> bossProgress = WheelTowerModel.Instance.GetBossProgress(this.Round, null);
			UUIText text3 = base.GetText(5);
			if (text3 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#ffffff>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(bossProgress.Item1);
				defaultInterpolatedStringHandler.AppendLiteral("</color>/<color=#a0a0a0>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(bossProgress.Item2);
				defaultInterpolatedStringHandler.AppendLiteral("</color>");
				text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			if (data.BuffIds.Count > 0)
			{
				NewTowerBuff? buffConfigById = WheelTowerConfig.Instance.GetBuffConfigById(data.BuffIds[0]);
				if (buffConfigById != null)
				{
					base.SetTextureByPath(buffConfigById.Value.Icon, base.GetTexture(3), null, null);
				}
			}
			UUIText text4 = base.GetText(6);
			if (text4 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.TeamScore);
				text4.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			foreach (RoleSaveInfo roleSaveInfo in data.RoleSaveInfos)
			{
				list.Add(new RoleDataWithBranch(roleSaveInfo.RoleId, roleSaveInfo.SkillBranchId));
			}
		}
		int teamMaxRoleCount = WheelTowerModel.Instance.GetTeamMaxRoleCount();
		while (list.Count < teamMaxRoleCount)
		{
			list.Add(new RoleDataWithBranch(0, 0));
		}
		GenericLayout<WheelTowerRoleItem, RoleDataWithBranch> roleIconLayout = this.RoleIconLayout;
		if (roleIconLayout == null)
		{
			return;
		}
		roleIconLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060071CA RID: 29130 RVA: 0x0022F3E8 File Offset: 0x0022D5E8
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(7).SetToggleState(state2, false, false, false);
	}

	// Token: 0x060071CB RID: 29131 RVA: 0x0022F410 File Offset: 0x0022D610
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberFirst);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberSecond);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060071CC RID: 29132 RVA: 0x0022F460 File Offset: 0x0022D660
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
		if (this.NumberFirst == 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "WheelTower_Team_Number", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.NumberFirst,
				this.NumberSecond
			}));
			return;
		}
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
		defaultInterpolatedStringHandler.AppendLiteral("<color=#ffffff>");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberFirst);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberSecond);
		defaultInterpolatedStringHandler.AppendLiteral("</color>");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060071CD RID: 29133 RVA: 0x0022F50F File Offset: 0x0022D70F
	private void OnToggleClick(EToggleState state)
	{
		Action<int> onToggleCallback = this.OnToggleCallback;
		if (onToggleCallback == null)
		{
			return;
		}
		onToggleCallback(this.Round);
	}

	// Token: 0x060071CE RID: 29134 RVA: 0x0022F527 File Offset: 0x0022D727
	[NullableContext(1)]
	private WheelTowerRoleItem CreateRoleItem()
	{
		return new WheelTowerRoleItem
		{
			IsOnlyShowIcon = true,
			CanClick = false
		};
	}

	// Token: 0x04004696 RID: 18070
	private int Round;

	// Token: 0x04004697 RID: 18071
	private int NumberFirst;

	// Token: 0x04004698 RID: 18072
	private int NumberSecond;

	// Token: 0x04004699 RID: 18073
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRoleItem, RoleDataWithBranch> RoleIconLayout;
}
