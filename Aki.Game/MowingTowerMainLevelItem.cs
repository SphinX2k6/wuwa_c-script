using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000836 RID: 2102
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MowingTowerMainLevelItem : GridProxyAbstract<MowingTowerLevelDetailInfo>
{
	// Token: 0x06005F81 RID: 24449 RVA: 0x001E7C8C File Offset: 0x001E5E8C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton))
		};
	}

	// Token: 0x06005F82 RID: 24450 RVA: 0x001E7DD2 File Offset: 0x001E5FD2
	public override void Refresh(MowingTowerLevelDetailInfo data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.RefreshLockState(data);
		this.RefreshScore(data);
		this.RefreshUnlockTime(data);
		this.RefreshTexture(data);
		this.RefreshLevelDesc(data);
	}

	// Token: 0x06005F83 RID: 24451 RVA: 0x001E7E00 File Offset: 0x001E6000
	private void RefreshTexture(MowingTowerLevelDetailInfo data)
	{
		bool unLockState = data.GetUnLockState();
		UUITexture texture = base.GetTexture(2);
		if (texture != null)
		{
			texture.SetUIActive(unLockState);
		}
		base.SetTextureByPath(data.GetNormalTexturePath(), texture, null, null);
		UUITexture texture2 = base.GetTexture(3);
		texture2.SetUIActive(!unLockState);
		base.SetTextureByPath(data.GetLockTexturePath(), texture2, null, null);
		bool isInfinite = data.GetIsInfinite();
		if (data.GetId() % 2 == 0 || isInfinite)
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
		}
		else
		{
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			UUIItem item4 = base.GetItem(5);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
		}
		if (!unLockState)
		{
			UUIItem item5 = base.GetItem(1);
			if (item5 != null)
			{
				item5.SetColor(MowingTowerColors.bgLockMowingTowerColor.Value);
			}
			UUIText text = base.GetText(6);
			if (text != null)
			{
				text.SetColor(MowingTowerColors.lockMowingTowerColor.Value);
			}
			UUIItem item6 = base.GetItem(5);
			if (item6 != null)
			{
				item6.SetColor(MowingTowerColors.lockMowingTowerColor.Value);
			}
			UUIItem item7 = base.GetItem(4);
			if (item7 == null)
			{
				return;
			}
			item7.SetColor(MowingTowerColors.lockMowingTowerColor.Value);
			return;
		}
		else if (isInfinite)
		{
			UUIItem item8 = base.GetItem(1);
			if (item8 != null)
			{
				item8.SetColor(MowingTowerColors.bgInfiniteMowingTowerColor.Value);
			}
			UUIText text2 = base.GetText(6);
			if (text2 != null)
			{
				text2.SetColor(MowingTowerColors.infiniteMowingTowerColor.Value);
			}
			UUIItem item9 = base.GetItem(4);
			if (item9 != null)
			{
				item9.SetColor(MowingTowerColors.infiniteMowingTowerColor.Value);
			}
			UUIItem item10 = base.GetItem(5);
			if (item10 == null)
			{
				return;
			}
			item10.SetColor(MowingTowerColors.infiniteMowingTowerColor.Value);
			return;
		}
		else
		{
			UUIItem item11 = base.GetItem(1);
			if (item11 != null)
			{
				item11.SetColor(MowingTowerColors.bgNormalMowingTowerColor.Value);
			}
			UUIText text3 = base.GetText(6);
			if (text3 != null)
			{
				text3.SetColor(MowingTowerColors.normalMowingTowerColor.Value);
			}
			UUIItem item12 = base.GetItem(4);
			if (item12 != null)
			{
				item12.SetColor(MowingTowerColors.normalMowingTowerColor.Value);
			}
			UUIItem item13 = base.GetItem(5);
			if (item13 == null)
			{
				return;
			}
			item13.SetColor(MowingTowerColors.normalMowingTowerColor.Value);
			return;
		}
	}

	// Token: 0x06005F84 RID: 24452 RVA: 0x001E8024 File Offset: 0x001E6224
	private void RefreshLockState(MowingTowerLevelDetailInfo data)
	{
		bool unLockState = data.GetUnLockState();
		base.GetItem(10).SetUIActive(!unLockState);
		base.GetItem(7).SetUIActive(unLockState);
	}

	// Token: 0x06005F85 RID: 24453 RVA: 0x001E8058 File Offset: 0x001E6258
	private void RefreshScore(MowingTowerLevelDetailInfo data)
	{
		if (data.GetUnLockState())
		{
			int score = data.GetScore();
			bool flag = score > 0;
			UUIText text = base.GetText(8);
			text.SetUIActive(flag);
			text.SetText(score.ToString(), true);
			base.GetItem(9).SetUIActive(!flag);
			base.GetItem(7).SetUIActive(flag);
		}
	}

	// Token: 0x06005F86 RID: 24454 RVA: 0x001E80B4 File Offset: 0x001E62B4
	private void RefreshUnlockTime(MowingTowerLevelDetailInfo data)
	{
		if (!data.GetUnLockState())
		{
			if (TimeUtil.Instance.GetServerTime() < data.GetUnLockTime())
			{
				base.GetText(11).SetText(data.GetUnlockTimeText(), true);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "MowingTowerUnlockCondition", new <>z__ReadOnlySingleElementList<object>(data.GetConfig().Value.PassScore));
		}
	}

	// Token: 0x06005F87 RID: 24455 RVA: 0x001E8127 File Offset: 0x001E6327
	private void RefreshLevelDesc(MowingTowerLevelDetailInfo data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.GetLevelDesc(), Array.Empty<object>());
	}

	// Token: 0x06005F88 RID: 24456 RVA: 0x001E8148 File Offset: 0x001E6348
	private void OnClickButton()
	{
		if (this.CurrentData == null || !this.CurrentData.GetUnLockState())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BossRushLevelLock", Array.Empty<object>());
			return;
		}
		MowingTowerModel.Instance.CurrentSelectLevelDetailData = this.CurrentData;
		MowingTowerModel.Instance.CurrentTeamInfo = this.CurrentData.ConvertToTeamInfo();
		EventSystem.Instance.Emit<int>(EEventName.ChangeMowingTowerMainView, 1);
	}

	// Token: 0x06005F89 RID: 24457 RVA: 0x001E81B5 File Offset: 0x001E63B5
	public bool GetCurrentIsFinish()
	{
		return this.CurrentData != null && this.CurrentData.GetScore() > 0;
	}

	// Token: 0x04003EA0 RID: 16032
	[Nullable(2)]
	private MowingTowerLevelDetailInfo CurrentData;

	// Token: 0x02006B80 RID: 27520
	[NullableContext(0)]
	private static class EComponent
	{
		// Token: 0x0402355D RID: 144733
		public const int Button = 0;

		// Token: 0x0402355E RID: 144734
		public const int BgItem = 1;

		// Token: 0x0402355F RID: 144735
		public const int NormalTexture = 2;

		// Token: 0x04023560 RID: 144736
		public const int LockTexture = 3;

		// Token: 0x04023561 RID: 144737
		public const int SingleItem = 4;

		// Token: 0x04023562 RID: 144738
		public const int DoubleItem = 5;

		// Token: 0x04023563 RID: 144739
		public const int LevelText = 6;

		// Token: 0x04023564 RID: 144740
		public const int ScoreItem = 7;

		// Token: 0x04023565 RID: 144741
		public const int ScoreText = 8;

		// Token: 0x04023566 RID: 144742
		public const int NoneScoreItem = 9;

		// Token: 0x04023567 RID: 144743
		public const int LockScoreItem = 10;

		// Token: 0x04023568 RID: 144744
		public const int LockScoreText = 11;
	}
}
