using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D8B RID: 15755
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeBossChallengeBossItem : GridProxyAbstract<RoguelikeBossChallengeBossData>
	{
		// Token: 0x0602849D RID: 165021 RVA: 0x00B48964 File Offset: 0x00B46B64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602849E RID: 165022 RVA: 0x00B48AF9 File Offset: 0x00B46CF9
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602849F RID: 165023 RVA: 0x00B48B0C File Offset: 0x00B46D0C
		[NullableContext(1)]
		public override void Refresh(RoguelikeBossChallengeBossData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			this.RefreshSpecialState(data.IsSpecial);
			this.RefreshState(data.State, data.IsSpecial);
			this.RefreshBossAvatar(data.Id, gridIndex);
			this.RefreshCurrentArrow(data.State, data.IsSpecial);
			this.RefreshSerialNum(gridIndex);
		}

		// Token: 0x060284A0 RID: 165024 RVA: 0x00B48B64 File Offset: 0x00B46D64
		public void SetArrowVisible(bool visible)
		{
			base.GetSprite(6).SetUIActive(visible);
		}

		// Token: 0x060284A1 RID: 165025 RVA: 0x00B48B73 File Offset: 0x00B46D73
		public bool IsCurrentBoss(int bossId)
		{
			RoguelikeBossChallengeBossData currentData = this.CurrentData;
			return currentData != null && currentData.Id == bossId;
		}

		// Token: 0x060284A2 RID: 165026 RVA: 0x00B48B8C File Offset: 0x00B46D8C
		public void PlaySwitchSequence()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x060284A3 RID: 165027 RVA: 0x00B48BB8 File Offset: 0x00B46DB8
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.CurrentData = null;
		}

		// Token: 0x060284A4 RID: 165028 RVA: 0x00B48BD9 File Offset: 0x00B46DD9
		private void RefreshSpecialState(bool isSpecial)
		{
			base.GetItem(7).SetUIActive(!isSpecial);
			base.GetItem(8).SetUIActive(isSpecial);
		}

		// Token: 0x060284A5 RID: 165029 RVA: 0x00B48BF8 File Offset: 0x00B46DF8
		private void RefreshState(ERoguelikeBossChallengeBossState state, bool isSpecial)
		{
			BossChallengeStateVisibility stateVisibility = this.GetStateVisibility(state);
			if (stateVisibility == null)
			{
				return;
			}
			base.GetItem(0).SetUIActive(stateVisibility.ShowUnlock);
			base.GetItem(2).SetUIActive(stateVisibility.ShowFinished);
			if (isSpecial)
			{
				base.GetTexture(9).SetUIActive(stateVisibility.ShowEmptyIcon);
				return;
			}
			base.GetTexture(1).SetUIActive(stateVisibility.ShowEmptyIcon);
		}

		// Token: 0x060284A6 RID: 165030 RVA: 0x00B48C60 File Offset: 0x00B46E60
		private void RefreshBossAvatar(int bossId, int gridIndex)
		{
			if (bossId == 0)
			{
				base.GetTexture(3).SetUIActive(false);
				return;
			}
			RogueTower? rogueTowerConfig = RoguelikeConfig.Instance.GetRogueTowerConfig(bossId);
			if (rogueTowerConfig == null || string.IsNullOrEmpty(rogueTowerConfig.Value.PreviewIcon))
			{
				return;
			}
			base.SetTextureShowUntilLoaded(rogueTowerConfig.Value.PreviewIcon, base.GetTexture(3), null);
		}

		// Token: 0x060284A7 RID: 165031 RVA: 0x00B48CC8 File Offset: 0x00B46EC8
		private void RefreshCurrentArrow(ERoguelikeBossChallengeBossState state, bool isSpecial)
		{
			bool flag = state == ERoguelikeBossChallengeBossState.Processing;
			base.GetTexture(4).SetUIActive(this.ShowCurrentArrow && !isSpecial && flag);
			base.GetTexture(10).SetUIActive(this.ShowCurrentArrow && isSpecial && flag);
		}

		// Token: 0x060284A8 RID: 165032 RVA: 0x00B48D10 File Offset: 0x00B46F10
		private void RefreshSerialNum(int gridIndex)
		{
			if (gridIndex < 0)
			{
				return;
			}
			string bossChallengeIndexResourceId = this.GetBossChallengeIndexResourceId(gridIndex);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(bossChallengeIndexResourceId);
			if (string.IsNullOrEmpty(resourcePath))
			{
				return;
			}
			this.SetSpriteByPath(resourcePath, base.GetSprite(5), false, null, null);
		}

		// Token: 0x060284A9 RID: 165033 RVA: 0x00B48D58 File Offset: 0x00B46F58
		private BossChallengeStateVisibility GetStateVisibility(ERoguelikeBossChallengeBossState state)
		{
			switch (state)
			{
			case ERoguelikeBossChallengeBossState.Finished:
				return new BossChallengeStateVisibility
				{
					ShowUnlock = true,
					ShowEmptyIcon = false,
					ShowFinished = true
				};
			case ERoguelikeBossChallengeBossState.Processing:
				return new BossChallengeStateVisibility
				{
					ShowUnlock = true,
					ShowEmptyIcon = false,
					ShowFinished = false
				};
			case ERoguelikeBossChallengeBossState.Locked:
				return new BossChallengeStateVisibility
				{
					ShowUnlock = false,
					ShowEmptyIcon = true,
					ShowFinished = false
				};
			default:
				return null;
			}
		}

		// Token: 0x060284AA RID: 165034 RVA: 0x00B48DCC File Offset: 0x00B46FCC
		[NullableContext(1)]
		private string GetBossChallengeIndexResourceId(int gridIndex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
			defaultInterpolatedStringHandler.AppendLiteral("SP_RoguelikeBossChallengeIndex");
			defaultInterpolatedStringHandler.AppendFormatted<int>(gridIndex);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x04015E6A RID: 89706
		public bool ShowCurrentArrow;

		// Token: 0x04015E6B RID: 89707
		protected RoguelikeBossChallengeBossData CurrentData;

		// Token: 0x04015E6C RID: 89708
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200996D RID: 39277
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402FD85 RID: 195973
			public const int PnlUnlock = 0;

			// Token: 0x0402FD86 RID: 195974
			public const int TexIcon = 1;

			// Token: 0x0402FD87 RID: 195975
			public const int PnlFinished = 2;

			// Token: 0x0402FD88 RID: 195976
			public const int TexBossAvatar = 3;

			// Token: 0x0402FD89 RID: 195977
			public const int TexCurrArrow = 4;

			// Token: 0x0402FD8A RID: 195978
			public const int SprSerialNum = 5;

			// Token: 0x0402FD8B RID: 195979
			public const int SprArrow = 6;

			// Token: 0x0402FD8C RID: 195980
			public const int PnlNorState = 7;

			// Token: 0x0402FD8D RID: 195981
			public const int PnlRedState = 8;

			// Token: 0x0402FD8E RID: 195982
			public const int TexEmptyIconRed = 9;

			// Token: 0x0402FD8F RID: 195983
			public const int TexCurrArrowRed = 10;
		}
	}
}
