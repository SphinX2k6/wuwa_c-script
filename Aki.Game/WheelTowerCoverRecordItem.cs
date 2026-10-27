using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200157B RID: 5499
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerCoverRecordItem : UiPanelBase
{
	// Token: 0x06009D36 RID: 40246 RVA: 0x00220DE4 File Offset: 0x0021EFE4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009D37 RID: 40247 RVA: 0x00220ED1 File Offset: 0x0021F0D1
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<WheelTowerCoverRecordRoleGridItem, int>(base.GetHorizontalLayout(0), new Func<WheelTowerCoverRecordRoleGridItem>(this.CreateRoleItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06009D38 RID: 40248 RVA: 0x00220F04 File Offset: 0x0021F104
	private WheelTowerCoverRecordRoleGridItem CreateRoleItem()
	{
		return new WheelTowerCoverRecordRoleGridItem();
	}

	// Token: 0x06009D39 RID: 40249 RVA: 0x00220F0C File Offset: 0x0021F10C
	public void Refresh(IWheelTowerCoverRecordData data)
	{
		GenericLayout<WheelTowerCoverRecordRoleGridItem, int> roleLayout = this.RoleLayout;
		if (roleLayout != null)
		{
			roleLayout.RefreshByData(data.TeamRoleIdList, null, false);
		}
		NewTowerBuff? buffConfigById = WheelTowerConfig.Instance.GetBuffConfigById(data.BuffId);
		if (buffConfigById != null)
		{
			base.SetTextureByPath(buffConfigById.Value.Icon, base.GetTexture(2), null, null);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "WheelTower_RoundSelectTab", new <>z__ReadOnlySingleElementList<object>(data.BossRound));
		UUIText text = base.GetText(4);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.BossWave);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.NeedChallengeBossWaveNum);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		string text2 = data.TeamScore.ToString();
		if (data.AddTeamScore > 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			defaultInterpolatedStringHandler.AppendLiteral("(+");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.AddTeamScore);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			text2 = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		UUIText text3 = base.GetText(5);
		if (text3 == null)
		{
			return;
		}
		text3.SetText(text2, true);
	}

	// Token: 0x040044FF RID: 17663
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WheelTowerCoverRecordRoleGridItem, int> RoleLayout;
}
