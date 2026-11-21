using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.SubPanel
{
	// Token: 0x020044A8 RID: 17576
	public class PhantomArenaMapNpcUi : UiPanelBase
	{
		// Token: 0x0602C5C7 RID: 181703 RVA: 0x00C792B0 File Offset: 0x00C774B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602C5C8 RID: 181704 RVA: 0x00C7939D File Offset: 0x00C7759D
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new UiSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequence));
		}

		// Token: 0x0602C5C9 RID: 181705 RVA: 0x00C793C8 File Offset: 0x00C775C8
		[NullableContext(1)]
		private void OnEndSequence(string sequenceName)
		{
			if (sequenceName == "Start" && this.IsNeedUnlockEffect)
			{
				UiSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlaySequence("Unlock", false, null);
				}
				this.IsNeedUnlockEffect = false;
			}
		}

		// Token: 0x0602C5CA RID: 181706 RVA: 0x00C79414 File Offset: 0x00C77614
		protected override void OnAfterShow()
		{
			UiSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequence("Start", false, null);
		}

		// Token: 0x0602C5CB RID: 181707 RVA: 0x00C79440 File Offset: 0x00C77640
		public void SetData(int markId)
		{
			if (this.MarkId == markId)
			{
				return;
			}
			this.MarkId = markId;
			PhantomArenaConfig instance = PhantomArenaConfig.Instance;
			PhantomBattleChallenge? phantomBattleChallenge = (instance != null) ? instance.GetPhantomBattleChallengeByMarkId(markId) : null;
			if (phantomBattleChallenge == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.CB;
				string message = "PhantomArenaMapNpcUi找不到对应的挑战数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", markId);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			PhantomArenaModel instance3 = PhantomArenaModel.Instance;
			EChallengeState? echallengeState = (instance3 != null) ? new EChallengeState?(instance3.GetPermanentChallengeStateById(phantomBattleChallenge.Value.Id)) : null;
			UUITexture texture = base.GetTexture(6);
			if (texture != null)
			{
				texture.SetUIActive(echallengeState.GetValueOrDefault() == EChallengeState.Finish);
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(echallengeState.GetValueOrDefault() == EChallengeState.Finish);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				EChallengeState? echallengeState2 = echallengeState;
				EChallengeState echallengeState3 = EChallengeState.Lock;
				item2.SetUIActive(echallengeState2.GetValueOrDefault() == echallengeState3 & echallengeState2 != null);
			}
			PhantomArenaModel instance4 = PhantomArenaModel.Instance;
			bool? flag;
			if (instance4 == null)
			{
				flag = null;
			}
			else
			{
				PhantomBattleChallengeInfo permanentChallengeData = instance4.GetPermanentChallengeData(phantomBattleChallenge.Value.Id);
				flag = ((permanentChallengeData != null) ? new bool?(permanentChallengeData.IsUncover) : null);
			}
			bool? flag2 = flag;
			string path = flag2.GetValueOrDefault(true) ? phantomBattleChallenge.Value.NpcMapHead : UiResourceConfig.Instance.GetResourcePath("MysteryNpcHead");
			base.TrySetTextureByPath(path, base.GetTexture(2), null, null);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(phantomBattleChallenge.Value.NpcNumber, true);
			}
			PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
			HashSet<int> hashSet = (permanentPhantomArenaActivityData != null) ? permanentPhantomArenaActivityData.GetCurrentUnlockChallengeIds() : null;
			if (hashSet != null && hashSet.Contains(phantomBattleChallenge.Value.Id))
			{
				this.IsNeedUnlockEffect = true;
				hashSet.Remove(phantomBattleChallenge.Value.Id);
			}
		}

		// Token: 0x0602C5CC RID: 181708 RVA: 0x00C79644 File Offset: 0x00C77844
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x04017E03 RID: 97795
		[Nullable(2)]
		private UiSequencePlayer LevelSequencePlayer;

		// Token: 0x04017E04 RID: 97796
		private bool IsNeedUnlockEffect;

		// Token: 0x04017E05 RID: 97797
		private int MarkId;

		// Token: 0x0200A171 RID: 41329
		public static class EComponents
		{
			// Token: 0x0403221C RID: 205340
			public const int SelfItem = 0;

			// Token: 0x0403221D RID: 205341
			public const int TextNum = 1;

			// Token: 0x0403221E RID: 205342
			public const int TexNpc = 2;

			// Token: 0x0403221F RID: 205343
			public const int PnlLock = 3;

			// Token: 0x04032220 RID: 205344
			public const int PnlDone = 4;

			// Token: 0x04032221 RID: 205345
			public const int TexBg = 5;

			// Token: 0x04032222 RID: 205346
			public const int TexDoneBg = 6;
		}
	}
}
