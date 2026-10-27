using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x0200690E RID: 26894
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class BossRushMainViewScrollItem : GridProxyAbstract<BossRushLevelDetailInfo>
	{
		// Token: 0x060430FA RID: 274682 RVA: 0x01056D0C File Offset: 0x01054F0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060430FB RID: 274683 RVA: 0x01056E78 File Offset: 0x01055078
		private void OnClickButton()
		{
			BossRushLevelDetailInfo currentData = this.CurrentData;
			if (currentData == null || !currentData.GetUnLockState())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("BossRushLevelLock", Array.Empty<object>());
				return;
			}
			BossRushTeamInfo bossRushTeamInfoByActivityId = BossRushModel.Instance.GetBossRushTeamInfoByActivityId(BossRushModel.Instance.CurrentSelectActivityId);
			bossRushTeamInfoByActivityId.Clear();
			bossRushTeamInfoByActivityId.SetCurrentSelectLevel(this.CurrentData);
			BossRushModel.Instance.CurrentSelectLevelDetailData = this.CurrentData;
			BossRushModel.Instance.CurrentTeamInfo = this.CurrentData.ConvertToTeamInfo();
			EventSystem.Instance.Emit<EUiTabViewName>(EEventName.RequestChangeBossRushView, EUiTabViewName.BossRushLevelDetailView);
		}

		// Token: 0x060430FC RID: 274684 RVA: 0x01056F10 File Offset: 0x01055110
		public override void Refresh(BossRushLevelDetailInfo data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			this.RefreshLockState(data);
			this.RefreshScore(data);
			this.RefreshUnlockTime(data);
			this.RefreshMonsterTexture(data);
		}

		// Token: 0x060430FD RID: 274685 RVA: 0x01056F38 File Offset: 0x01055138
		private void RefreshMonsterTexture(BossRushLevelDetailInfo data)
		{
			base.SetTextureByPath(data.GetMonsterTexturePath(), base.GetTexture(0), null, null);
			UUITexture texture = base.GetTexture(6);
			texture.SetUIActive(!data.GetUnLockState());
			base.SetTextureByPath(data.GetMonsterTexturePath(), texture, null, null);
		}

		// Token: 0x060430FE RID: 274686 RVA: 0x01056F90 File Offset: 0x01055190
		private void RefreshLockState(BossRushLevelDetailInfo data)
		{
			bool unLockState = data.GetUnLockState();
			base.GetItem(1).SetUIActive(unLockState);
			base.GetItem(2).SetUIActive(!unLockState);
		}

		// Token: 0x060430FF RID: 274687 RVA: 0x01056FC4 File Offset: 0x010551C4
		private void RefreshScore(BossRushLevelDetailInfo data)
		{
			if (data.GetUnLockState())
			{
				int score = data.GetScore();
				bool flag = score > 0;
				UUIText text = base.GetText(3);
				text.SetUIActive(flag);
				text.SetText(score.ToString(), true);
				base.GetItem(7).SetUIActive(!flag);
			}
		}

		// Token: 0x06043100 RID: 274688 RVA: 0x01057010 File Offset: 0x01055210
		private void RefreshUnlockTime(BossRushLevelDetailInfo data)
		{
			if (!data.GetUnLockState())
			{
				base.GetText(4).SetText(data.GetUnlockTimeText(), true);
			}
		}

		// Token: 0x06043101 RID: 274689 RVA: 0x01057030 File Offset: 0x01055230
		public UUIItem GetButtonItem()
		{
			UUIButtonComponent button = base.GetButton(5);
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
			if (tweakObjectPtr == null)
			{
				return null;
			}
			return tweakObjectPtr.GetValueOrDefault();
		}

		// Token: 0x04022E8B RID: 142987
		[Nullable(2)]
		private BossRushLevelDetailInfo CurrentData;

		// Token: 0x0200CABD RID: 51901
		[NullableContext(0)]
		private class EBossRushMainViewScrollItemComponent
		{
			// Token: 0x0403D45D RID: 250973
			public const int MonsterTexture = 0;

			// Token: 0x0403D45E RID: 250974
			public const int LockPanelItem = 1;

			// Token: 0x0403D45F RID: 250975
			public const int UnLockPanelItem = 2;

			// Token: 0x0403D460 RID: 250976
			public const int ScoreText = 3;

			// Token: 0x0403D461 RID: 250977
			public const int UnlockTime = 4;

			// Token: 0x0403D462 RID: 250978
			public const int Button = 5;

			// Token: 0x0403D463 RID: 250979
			public const int LockTexture = 6;

			// Token: 0x0403D464 RID: 250980
			public const int UnFinishItem = 7;
		}
	}
}
