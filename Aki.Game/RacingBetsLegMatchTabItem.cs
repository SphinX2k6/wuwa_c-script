using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002719 RID: 10009
public class RacingBetsLegMatchTabItem : UiPanelBase
{
	// Token: 0x06014833 RID: 84019 RVA: 0x0052E379 File Offset: 0x0052C579
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06014834 RID: 84020 RVA: 0x0052E3B4 File Offset: 0x0052C5B4
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

	// Token: 0x02008D6E RID: 36206
	private enum EComponent
	{
		// Token: 0x0402DE40 RID: 187968
		MatchNameText,
		// Token: 0x0402DE41 RID: 187969
		TimeIntervalText
	}
}
