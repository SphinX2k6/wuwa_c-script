using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x020037EC RID: 14316
	internal class ChatItem : UiPanelBase
	{
		// Token: 0x060253D9 RID: 152537 RVA: 0x00A80C18 File Offset: 0x00A7EE18
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x060253DA RID: 152538 RVA: 0x00A80C51 File Offset: 0x00A7EE51
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060253DB RID: 152539 RVA: 0x00A80C64 File Offset: 0x00A7EE64
		[NullableContext(1)]
		public void Refresh(IVillageInfrChat data)
		{
			base.SetTextureByPath(data.HeadTexture, base.GetTexture(0), null, null);
			base.GetText(1).ShowTextNew(data.Chat);
		}

		// Token: 0x060253DC RID: 152540 RVA: 0x00A80CA0 File Offset: 0x00A7EEA0
		public void SetShow(bool visible, bool needAnimation = true)
		{
			this.RootItem.SetUIActive(visible);
			if (needAnimation)
			{
				LevelSequencePlayer seqPlayer = this.SeqPlayer;
				if (seqPlayer != null)
				{
					seqPlayer.StopCurrentSequence(false, false);
				}
				if (visible)
				{
					LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
					if (seqPlayer2 == null)
					{
						return;
					}
					seqPlayer2.PlayLevelSequenceByName("Start", false, null, false);
					return;
				}
				else
				{
					LevelSequencePlayer seqPlayer3 = this.SeqPlayer;
					if (seqPlayer3 == null)
					{
						return;
					}
					seqPlayer3.PlayLevelSequenceByName("Close", false, null, false);
				}
			}
		}

		// Token: 0x040149A5 RID: 84389
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;
	}
}
