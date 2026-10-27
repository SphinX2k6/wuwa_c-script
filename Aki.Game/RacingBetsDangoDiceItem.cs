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

// Token: 0x0200270F RID: 9999
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsDangoDiceItem : GridProxyAbstract<DangoIdToDiceNum>
{
	// Token: 0x060147EE RID: 83950 RVA: 0x0052D1B8 File Offset: 0x0052B3B8
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

	// Token: 0x060147EF RID: 83951 RVA: 0x0052D23E File Offset: 0x0052B43E
	protected override void OnBeforeCreateImplement()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x060147F0 RID: 83952 RVA: 0x0052D258 File Offset: 0x0052B458
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRacingBetsDangoRoundStart, new Action<int>(this.OnRacingBetsDangoRoundStart));
		EventSystem.Instance.Add<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(EEventName.OnRacingBetsDangoOrderRefresh, new Action<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(this.OnRacingBetsDangoOrderRefresh));
	}

	// Token: 0x060147F1 RID: 83953 RVA: 0x0052D294 File Offset: 0x0052B494
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

	// Token: 0x060147F2 RID: 83954 RVA: 0x0052D34D File Offset: 0x0052B54D
	protected override void OnAfterHide()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDangoRoundStart, new Action<int>(this.OnRacingBetsDangoRoundStart));
		EventSystem.Instance.Remove<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(EEventName.OnRacingBetsDangoOrderRefresh, new Action<int, IReadOnlyList<DangoIdToDiceNum>, CustomPromise>(this.OnRacingBetsDangoOrderRefresh));
	}

	// Token: 0x060147F3 RID: 83955 RVA: 0x0052D388 File Offset: 0x0052B588
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

	// Token: 0x060147F4 RID: 83956 RVA: 0x0052D3FB File Offset: 0x0052B5FB
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

	// Token: 0x04009A35 RID: 39477
	private DangoIdToDiceNum DiceInfo;

	// Token: 0x04009A36 RID: 39478
	[Nullable(2)]
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x02008D5D RID: 36189
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402DDF4 RID: 187892
		DiceTexture,
		// Token: 0x0402DDF5 RID: 187893
		DiceNumTexture,
		// Token: 0x0402DDF6 RID: 187894
		DangoBgTexture,
		// Token: 0x0402DDF7 RID: 187895
		DangoTexture,
		// Token: 0x0402DDF8 RID: 187896
		ArrowItem
	}
}
