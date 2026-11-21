using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x020028D9 RID: 10457
public class RedDotBattleViewGachaButton : RedDotBase
{
	// Token: 0x0601A71C RID: 108316 RVA: 0x0082BED4 File Offset: 0x0082A0D4
	protected override bool OnCheck(int uId = 0)
	{
		bool flag = GachaModel.Instance.CheckNewGachaPool();
		bool flag2 = this.CheckNeedShowWeaponSelectRedDot();
		bool flag3 = this.CheckGachaAccumulateRedDot();
		return flag || flag2 || flag3;
	}

	// Token: 0x0601A71D RID: 108317 RVA: 0x0082BF00 File Offset: 0x0082A100
	private bool CheckNeedShowWeaponSelectRedDot()
	{
		ProtoGachaInfo[] gachaInfoArray = GachaModel.Instance.GachaInfoArray;
		if (gachaInfoArray == null)
		{
			return false;
		}
		foreach (ProtoGachaInfo protoGachaInfo in gachaInfoArray)
		{
			ProtoGachaPoolInfo firstValidPool = protoGachaInfo.GetFirstValidPool();
			if (firstValidPool != null && firstValidPool.UiType == 5)
			{
				bool flag = protoGachaInfo.UsePoolId == 0;
				bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.FirstOpenCommonWeaponSelect, false);
				if (flag && !player)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0601A71E RID: 108318 RVA: 0x0082BF68 File Offset: 0x0082A168
	private bool CheckGachaAccumulateRedDot()
	{
		ProtoGachaInfo[] gachaInfoArray = GachaModel.Instance.GachaInfoArray;
		if (gachaInfoArray == null)
		{
			return false;
		}
		foreach (ProtoGachaInfo protoGachaInfo in gachaInfoArray)
		{
			if (protoGachaInfo.GachaAccumulateId > 0)
			{
				GachaAccumulateData accumulateData = GachaAccumulateModel.Instance.GetAccumulateData(protoGachaInfo.GachaAccumulateId);
				if (accumulateData != null && accumulateData.GetUnTakeRewardNum() > 0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0601A71F RID: 108319 RVA: 0x0082BFC8 File Offset: 0x0082A1C8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnOpenGachaChanged, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnOpenCommonWeaponSelect, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.GachaAccumulateRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A720 RID: 108320 RVA: 0x0082C02C File Offset: 0x0082A22C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnOpenGachaChanged, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnOpenCommonWeaponSelect, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.GachaAccumulateRedDot, new Action(base.EventCheck));
	}
}
