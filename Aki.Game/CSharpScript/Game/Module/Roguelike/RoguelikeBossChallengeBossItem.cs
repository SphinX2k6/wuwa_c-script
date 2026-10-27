using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DC2 RID: 19906
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeBossChallengeBossItem : GridProxyAbstract<RoguelikeBossChallengeBossData>
	{
		// Token: 0x06033630 RID: 210480 RVA: 0x00BFF424 File Offset: 0x00BFD624
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

		// Token: 0x06033631 RID: 210481 RVA: 0x00BFF5B9 File Offset: 0x00BFD7B9
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06033632 RID: 210482 RVA: 0x00BFF5CC File Offset: 0x00BFD7CC
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

		// Token: 0x06033633 RID: 210483 RVA: 0x00BFF624 File Offset: 0x00BFD824
		public void SetArrowVisible(bool visible)
		{
			base.GetSprite(6).SetUIActive(visible);
		}

		// Token: 0x06033634 RID: 210484 RVA: 0x00BFF633 File Offset: 0x00BFD833
		public bool IsCurrentBoss(int bossId)
		{
			RoguelikeBossChallengeBossData currentData = this.CurrentData;
			return currentData != null && currentData.Id == bossId;
		}

		// Token: 0x06033635 RID: 210485 RVA: 0x00BFF64C File Offset: 0x00BFD84C
		public void PlaySwitchSequence()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06033636 RID: 210486 RVA: 0x00BFF678 File Offset: 0x00BFD878
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

		// Token: 0x06033637 RID: 210487 RVA: 0x00BFF699 File Offset: 0x00BFD899
		private void RefreshSpecialState(bool isSpecial)
		{
			base.GetItem(7).SetUIActive(!isSpecial);
			base.GetItem(8).SetUIActive(isSpecial);
		}

		// Token: 0x06033638 RID: 210488 RVA: 0x00BFF6B8 File Offset: 0x00BFD8B8
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

		// Token: 0x06033639 RID: 210489 RVA: 0x00BFF720 File Offset: 0x00BFD920
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

		// Token: 0x0603363A RID: 210490 RVA: 0x00BFF788 File Offset: 0x00BFD988
		private void RefreshCurrentArrow(ERoguelikeBossChallengeBossState state, bool isSpecial)
		{
			bool flag = state == ERoguelikeBossChallengeBossState.Processing;
			base.GetTexture(4).SetUIActive(this.ShowCurrentArrow && !isSpecial && flag);
			base.GetTexture(10).SetUIActive(this.ShowCurrentArrow && isSpecial && flag);
		}

		// Token: 0x0603363B RID: 210491 RVA: 0x00BFF7D0 File Offset: 0x00BFD9D0
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

		// Token: 0x0603363C RID: 210492 RVA: 0x00BFF818 File Offset: 0x00BFDA18
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

		// Token: 0x0603363D RID: 210493 RVA: 0x00BFF88C File Offset: 0x00BFDA8C
		[NullableContext(1)]
		private string GetBossChallengeIndexResourceId(int gridIndex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
			defaultInterpolatedStringHandler.AppendLiteral("SP_RoguelikeBossChallengeIndex");
			defaultInterpolatedStringHandler.AppendFormatted<int>(gridIndex);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0401B497 RID: 111767
		public bool ShowCurrentArrow;

		// Token: 0x0401B498 RID: 111768
		protected RoguelikeBossChallengeBossData CurrentData;

		// Token: 0x0401B499 RID: 111769
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200AF38 RID: 44856
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035350 RID: 217936
			public const int PnlUnlock = 0;

			// Token: 0x04035351 RID: 217937
			public const int TexIcon = 1;

			// Token: 0x04035352 RID: 217938
			public const int PnlFinished = 2;

			// Token: 0x04035353 RID: 217939
			public const int TexBossAvatar = 3;

			// Token: 0x04035354 RID: 217940
			public const int TexCurrArrow = 4;

			// Token: 0x04035355 RID: 217941
			public const int SprSerialNum = 5;

			// Token: 0x04035356 RID: 217942
			public const int SprArrow = 6;

			// Token: 0x04035357 RID: 217943
			public const int PnlNorState = 7;

			// Token: 0x04035358 RID: 217944
			public const int PnlRedState = 8;

			// Token: 0x04035359 RID: 217945
			public const int TexEmptyIconRed = 9;

			// Token: 0x0403535A RID: 217946
			public const int TexCurrArrowRed = 10;
		}
	}
}
