using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001382 RID: 4994
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MowingTowerMainLevelItem : GridProxyAbstract<MowingTowerLevelDetailInfo>
{
	// Token: 0x06008BE6 RID: 35814 RVA: 0x001DEE38 File Offset: 0x001DD038
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

	// Token: 0x06008BE7 RID: 35815 RVA: 0x001DEF7E File Offset: 0x001DD17E
	public override void Refresh(MowingTowerLevelDetailInfo data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.RefreshLockState(data);
		this.RefreshScore(data);
		this.RefreshUnlockTime(data);
		this.RefreshTexture(data);
		this.RefreshLevelDesc(data);
	}

	// Token: 0x06008BE8 RID: 35816 RVA: 0x001DEFAC File Offset: 0x001DD1AC
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

	// Token: 0x06008BE9 RID: 35817 RVA: 0x001DF1D0 File Offset: 0x001DD3D0
	private void RefreshLockState(MowingTowerLevelDetailInfo data)
	{
		bool unLockState = data.GetUnLockState();
		base.GetItem(10).SetUIActive(!unLockState);
		base.GetItem(7).SetUIActive(unLockState);
	}

	// Token: 0x06008BEA RID: 35818 RVA: 0x001DF204 File Offset: 0x001DD404
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

	// Token: 0x06008BEB RID: 35819 RVA: 0x001DF260 File Offset: 0x001DD460
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

	// Token: 0x06008BEC RID: 35820 RVA: 0x001DF2D3 File Offset: 0x001DD4D3
	private void RefreshLevelDesc(MowingTowerLevelDetailInfo data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.GetLevelDesc(), Array.Empty<object>());
	}

	// Token: 0x06008BED RID: 35821 RVA: 0x001DF2F4 File Offset: 0x001DD4F4
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

	// Token: 0x06008BEE RID: 35822 RVA: 0x001DF361 File Offset: 0x001DD561
	public bool GetCurrentIsFinish()
	{
		return this.CurrentData != null && this.CurrentData.GetScore() > 0;
	}

	// Token: 0x04003E08 RID: 15880
	[Nullable(2)]
	private MowingTowerLevelDetailInfo CurrentData;

	// Token: 0x020079F6 RID: 31222
	[NullableContext(0)]
	private static class EComponent
	{
		// Token: 0x04028230 RID: 164400
		public const int Button = 0;

		// Token: 0x04028231 RID: 164401
		public const int BgItem = 1;

		// Token: 0x04028232 RID: 164402
		public const int NormalTexture = 2;

		// Token: 0x04028233 RID: 164403
		public const int LockTexture = 3;

		// Token: 0x04028234 RID: 164404
		public const int SingleItem = 4;

		// Token: 0x04028235 RID: 164405
		public const int DoubleItem = 5;

		// Token: 0x04028236 RID: 164406
		public const int LevelText = 6;

		// Token: 0x04028237 RID: 164407
		public const int ScoreItem = 7;

		// Token: 0x04028238 RID: 164408
		public const int ScoreText = 8;

		// Token: 0x04028239 RID: 164409
		public const int NoneScoreItem = 9;

		// Token: 0x0402823A RID: 164410
		public const int LockScoreItem = 10;

		// Token: 0x0402823B RID: 164411
		public const int LockScoreText = 11;
	}
}
