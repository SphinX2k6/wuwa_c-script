using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x02003367 RID: 13159
public class RedDotBattleViewGachaButton : RedDotBase
{
	// Token: 0x0601CA24 RID: 117284 RVA: 0x00805910 File Offset: 0x00803B10
	protected override bool OnCheck(int uId = 0)
	{
		bool flag = GachaModel.Instance.CheckNewGachaPool();
		bool flag2 = this.CheckNeedShowWeaponSelectRedDot();
		bool flag3 = this.CheckGachaAccumulateRedDot();
		return flag || flag2 || flag3;
	}

	// Token: 0x0601CA25 RID: 117285 RVA: 0x0080593C File Offset: 0x00803B3C
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

	// Token: 0x0601CA26 RID: 117286 RVA: 0x008059A4 File Offset: 0x00803BA4
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

	// Token: 0x0601CA27 RID: 117287 RVA: 0x00805A04 File Offset: 0x00803C04
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnOpenGachaChanged, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnOpenCommonWeaponSelect, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.GachaAccumulateRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CA28 RID: 117288 RVA: 0x00805A68 File Offset: 0x00803C68
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnOpenGachaChanged, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnOpenCommonWeaponSelect, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.GachaAccumulateRedDot, new Action(base.EventCheck));
	}
}
