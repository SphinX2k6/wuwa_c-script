using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BFA RID: 7162
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsDangoDiceItem : GridProxyAbstract<DangoIdToDiceNum>
{
	// Token: 0x06011CD0 RID: 72912 RVA: 0x0053BED4 File Offset: 0x0053A0D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06011CD1 RID: 72913 RVA: 0x0053BF5A File Offset: 0x0053A15A
	protected override void OnBeforeCreateImplement()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x06011CD2 RID: 72914 RVA: 0x0053BF74 File Offset: 0x0053A174
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRacingBetsDangoRoundStart, new Action<int>(this.OnRacingBetsDangoRoundStart));
		EventSystem.Instance.Add<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(EEventName.OnRacingBetsDangoOrderRefresh, new Action<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(this.OnRacingBetsDangoOrderRefresh));
	}

	// Token: 0x06011CD3 RID: 72915 RVA: 0x0053BFB0 File Offset: 0x0053A1B0
	public override void Refresh(DangoIdToDiceNum diceInfo, bool isSelected, int gridIndex)
	{
		this.DiceInfo = diceInfo;
		DangoData dangoData = DangoManager.Instance.GetDangoData(diceInfo.DangoId);
		base.SetTextureShowUntilLoaded(dangoData.DangoConfig.Value.IconSmall, base.GetTexture(3), null);
		RacingBetsDungeonDangoInfo dungeonDangoInfo = RacingBetsModel.Instance.GetDungeonDangoInfo(diceInfo.DangoId);
		if (dungeonDangoInfo == null)
		{
			return;
		}
		string diceIcon = dungeonDangoInfo.GetDiceIcon(diceInfo.Num);
		Dice? diceConfig = dungeonDangoInfo.GetDiceConfig();
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		base.SetTextureShowUntilLoaded(diceIcon, base.GetTexture(1), null);
		if (diceConfig != null)
		{
			base.SetTextureShowUntilLoaded(diceConfig.Value.DiceBackgroundIcon, base.GetTexture(0), null);
		}
	}

	// Token: 0x06011CD4 RID: 72916 RVA: 0x0053C069 File Offset: 0x0053A269
	protected override void OnAfterHide()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDangoRoundStart, new Action<int>(this.OnRacingBetsDangoRoundStart));
		EventSystem.Instance.Remove<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(EEventName.OnRacingBetsDangoOrderRefresh, new Action<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(this.OnRacingBetsDangoOrderRefresh));
	}

	// Token: 0x06011CD5 RID: 72917 RVA: 0x0053C0A4 File Offset: 0x0053A2A4
	private void OnRacingBetsDangoRoundStart(int dangoId)
	{
		if (this.DiceInfo.DangoId == dangoId)
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UiBehaviorLevelSequence uiLevelSequence = this.UiLevelSequence;
			if (uiLevelSequence == null)
			{
				return;
			}
			uiLevelSequence.PlaySequence("Select", false, null);
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UiBehaviorLevelSequence uiLevelSequence2 = this.UiLevelSequence;
			if (uiLevelSequence2 == null)
			{
				return;
			}
			uiLevelSequence2.StopPrevSequence(false, true);
			return;
		}
	}

	// Token: 0x06011CD6 RID: 72918 RVA: 0x0053C117 File Offset: 0x0053A317
	private void OnRacingBetsDangoOrderRefresh(int _1, IReadOnlyList<DangoIdToDiceNum> _2, CustomPromise _3)
	{
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UiBehaviorLevelSequence uiLevelSequence = this.UiLevelSequence;
		if (uiLevelSequence == null)
		{
			return;
		}
		uiLevelSequence.StopPrevSequence(false, true);
	}

	// Token: 0x04009B8D RID: 39821
	private DangoIdToDiceNum DiceInfo;

	// Token: 0x04009B8E RID: 39822
	[Nullable(2)]
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x02007EE6 RID: 32486
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402910B RID: 168203
		DiceTexture,
		// Token: 0x0402910C RID: 168204
		DiceNumTexture,
		// Token: 0x0402910D RID: 168205
		DangoBgTexture,
		// Token: 0x0402910E RID: 168206
		DangoTexture,
		// Token: 0x0402910F RID: 168207
		ArrowItem
	}
}
