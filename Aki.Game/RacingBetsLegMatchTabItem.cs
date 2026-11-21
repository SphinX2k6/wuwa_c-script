using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C04 RID: 7172
public class RacingBetsLegMatchTabItem : UiPanelBase
{
	// Token: 0x06011D15 RID: 72981 RVA: 0x0053D095 File Offset: 0x0053B295
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06011D16 RID: 72982 RVA: 0x0053D0D0 File Offset: 0x0053B2D0
	[NullableContext(2)]
	public void RefreshUi(RacingBetsLegMatchData legMatchData)
	{
		if (legMatchData == null)
		{
			this.SetActive(false);
			return;
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.ShowTextNew(legMatchData.Name);
		}
		DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)legMatchData.MatchStartTime).DateTime;
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(TimeUtil.Instance.DateFormat3(dateTime), true);
	}

	// Token: 0x02007EF7 RID: 32503
	private enum EComponent
	{
		// Token: 0x04029157 RID: 168279
		MatchNameText,
		// Token: 0x04029158 RID: 168280
		TimeIntervalText
	}
}
