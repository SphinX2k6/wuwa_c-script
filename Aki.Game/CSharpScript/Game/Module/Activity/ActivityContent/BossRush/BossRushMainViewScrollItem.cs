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
	// Token: 0x0200585E RID: 22622
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class BossRushMainViewScrollItem : GridProxyAbstract<BossRushLevelDetailInfo>
	{
		// Token: 0x06037C52 RID: 228434 RVA: 0x00F98338 File Offset: 0x00F96538
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

		// Token: 0x06037C53 RID: 228435 RVA: 0x00F984A4 File Offset: 0x00F966A4
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

		// Token: 0x06037C54 RID: 228436 RVA: 0x00F9853C File Offset: 0x00F9673C
		public override void Refresh(BossRushLevelDetailInfo data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			this.RefreshLockState(data);
			this.RefreshScore(data);
			this.RefreshUnlockTime(data);
			this.RefreshMonsterTexture(data);
		}

		// Token: 0x06037C55 RID: 228437 RVA: 0x00F98564 File Offset: 0x00F96764
		private void RefreshMonsterTexture(BossRushLevelDetailInfo data)
		{
			base.SetTextureByPath(data.GetMonsterTexturePath(), base.GetTexture(0), null, null);
			UUITexture texture = base.GetTexture(6);
			texture.SetUIActive(!data.GetUnLockState());
			base.SetTextureByPath(data.GetMonsterTexturePath(), texture, null, null);
		}

		// Token: 0x06037C56 RID: 228438 RVA: 0x00F985BC File Offset: 0x00F967BC
		private void RefreshLockState(BossRushLevelDetailInfo data)
		{
			bool unLockState = data.GetUnLockState();
			base.GetItem(1).SetUIActive(unLockState);
			base.GetItem(2).SetUIActive(!unLockState);
		}

		// Token: 0x06037C57 RID: 228439 RVA: 0x00F985F0 File Offset: 0x00F967F0
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

		// Token: 0x06037C58 RID: 228440 RVA: 0x00F9863C File Offset: 0x00F9683C
		private void RefreshUnlockTime(BossRushLevelDetailInfo data)
		{
			if (!data.GetUnLockState())
			{
				base.GetText(4).SetText(data.GetUnlockTimeText(), true);
			}
		}

		// Token: 0x06037C59 RID: 228441 RVA: 0x00F9865C File Offset: 0x00F9685C
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

		// Token: 0x0401D6E7 RID: 120551
		[Nullable(2)]
		private BossRushLevelDetailInfo CurrentData;

		// Token: 0x0200B485 RID: 46213
		[NullableContext(0)]
		private class EBossRushMainViewScrollItemComponent
		{
			// Token: 0x04037D37 RID: 228663
			public const int MonsterTexture = 0;

			// Token: 0x04037D38 RID: 228664
			public const int LockPanelItem = 1;

			// Token: 0x04037D39 RID: 228665
			public const int UnLockPanelItem = 2;

			// Token: 0x04037D3A RID: 228666
			public const int ScoreText = 3;

			// Token: 0x04037D3B RID: 228667
			public const int UnlockTime = 4;

			// Token: 0x04037D3C RID: 228668
			public const int Button = 5;

			// Token: 0x04037D3D RID: 228669
			public const int LockTexture = 6;

			// Token: 0x04037D3E RID: 228670
			public const int UnFinishItem = 7;
		}
	}
}
