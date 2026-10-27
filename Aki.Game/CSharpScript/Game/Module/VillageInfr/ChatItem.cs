using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004875 RID: 18549
	internal class ChatItem : UiPanelBase
	{
		// Token: 0x060308AD RID: 198829 RVA: 0x00B45E7C File Offset: 0x00B4407C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x060308AE RID: 198830 RVA: 0x00B45EB5 File Offset: 0x00B440B5
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060308AF RID: 198831 RVA: 0x00B45EC8 File Offset: 0x00B440C8
		[NullableContext(1)]
		public void Refresh(IVillageInfrChat data)
		{
			base.SetTextureByPath(data.HeadTexture, base.GetTexture(0), null, null);
			base.GetText(1).ShowTextNew(data.Chat);
		}

		// Token: 0x060308B0 RID: 198832 RVA: 0x00B45F04 File Offset: 0x00B44104
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

		// Token: 0x0401A132 RID: 106802
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;
	}
}
