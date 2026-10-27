using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020015C0 RID: 5568
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	2
})]
public class WheelTowerNewTeamItem : GridProxyAbstract<TeamChallengeInfo>
{
	// Token: 0x17000D7D RID: 3453
	// (get) Token: 0x06009DE7 RID: 40423 RVA: 0x00225077 File Offset: 0x00223277
	// (set) Token: 0x06009DE8 RID: 40424 RVA: 0x0022507F File Offset: 0x0022327F
	public Action<int> OnToggleCallback { get; set; }

	// Token: 0x06009DE9 RID: 40425 RVA: 0x00225088 File Offset: 0x00223288
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

	// Token: 0x06009DEA RID: 40426 RVA: 0x002252C0 File Offset: 0x002234C0
	protected override void OnStart()
	{
		base.GetExtendToggle(7).bLockStateOnSelect = true;
		this.RoleIconLayout = new GenericLayout<WheelTowerRoleItem, RoleDataWithBranch>(base.GetHorizontalLayout(1), new Func<WheelTowerRoleItem>(this.CreateRoleItem), null, false, true);
	}

	// Token: 0x06009DEB RID: 40427 RVA: 0x002252F0 File Offset: 0x002234F0
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

	// Token: 0x06009DEC RID: 40428 RVA: 0x00225638 File Offset: 0x00223838
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(7).SetToggleState(state2, false, false, false);
	}

	// Token: 0x06009DED RID: 40429 RVA: 0x00225660 File Offset: 0x00223860
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

	// Token: 0x06009DEE RID: 40430 RVA: 0x002256B0 File Offset: 0x002238B0
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

	// Token: 0x06009DEF RID: 40431 RVA: 0x0022575F File Offset: 0x0022395F
	private void OnToggleClick(EToggleState state)
	{
		Action<int> onToggleCallback = this.OnToggleCallback;
		if (onToggleCallback == null)
		{
			return;
		}
		onToggleCallback(this.Round);
	}

	// Token: 0x06009DF0 RID: 40432 RVA: 0x00225777 File Offset: 0x00223977
	[NullableContext(1)]
	private WheelTowerRoleItem CreateRoleItem()
	{
		return new WheelTowerRoleItem
		{
			IsOnlyShowIcon = true,
			CanClick = false
		};
	}

	// Token: 0x040045F0 RID: 17904
	private int Round;

	// Token: 0x040045F1 RID: 17905
	private int NumberFirst;

	// Token: 0x040045F2 RID: 17906
	private int NumberSecond;

	// Token: 0x040045F3 RID: 17907
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRoleItem, RoleDataWithBranch> RoleIconLayout;
}
