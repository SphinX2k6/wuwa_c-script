using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200561C RID: 22044
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGridSelectBase : UiPanelBase
	{
		// Token: 0x06038139 RID: 229689 RVA: 0x00D48515 File Offset: 0x00D46715
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603813A RID: 229690 RVA: 0x00D4854E File Offset: 0x00D4674E
		protected override void OnStart()
		{
			this.InteractAnimationPlayer = new LevelSequencePlayer(this.RootItem);
			this.StateAnimationPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603813B RID: 229691 RVA: 0x00D48572 File Offset: 0x00D46772
		public void SetSelected(bool isSelectOn)
		{
			this.IsSelectOn = isSelectOn;
		}

		// Token: 0x0603813C RID: 229692 RVA: 0x00D4857B File Offset: 0x00D4677B
		public void SetState(bool groupEnable)
		{
			base.GetItem(0).SetUIActive(groupEnable);
			base.GetItem(1).SetUIActive(!groupEnable);
		}

		// Token: 0x0603813D RID: 229693 RVA: 0x00D4859A File Offset: 0x00D4679A
		public void SetSequenceToStart(string seqDefine)
		{
			this.JumpToFirstFrame(this.RootItem.GetOwner() as AUIBaseActor, seqDefine);
		}

		// Token: 0x0603813E RID: 229694 RVA: 0x00D485B4 File Offset: 0x00D467B4
		public void ResetAllSequence()
		{
			this.SetSequenceToStart("Float");
			string currentSequence = this.InteractAnimationPlayer.GetCurrentSequence();
			if (currentSequence != null)
			{
				this.JumpToFirstFrame(this.RootItem.GetOwner() as AUIBaseActor, currentSequence);
				this.InteractAnimationPlayer.StopPlayingSequence(false, true);
			}
			this.StateAnimationPlayer.PlayLevelSequenceByName("UnSle", false, null, false);
			this.StateAnimationPlayer.StopSequenceByKey("UnSle", false, true);
		}

		// Token: 0x0603813F RID: 229695 RVA: 0x00D4862C File Offset: 0x00D4682C
		public void PlaySequence(string seqDefine, bool notDistribute = false)
		{
			if (!(seqDefine == "Float") && !(seqDefine == "Move") && !(seqDefine == "Pre") && !(seqDefine == "PreUp"))
			{
				if (!(seqDefine == "Sle") && !(seqDefine == "UnSle"))
				{
					return;
				}
				string currentSequence = this.StateAnimationPlayer.GetCurrentSequence();
				if (currentSequence != null)
				{
					if (notDistribute && seqDefine == currentSequence)
					{
						return;
					}
					this.JumpToFirstFrame(this.RootItem.GetOwner() as AUIBaseActor, currentSequence);
					this.StateAnimationPlayer.StopPlayingSequence(false, true);
				}
				this.StateAnimationPlayer.PlayLevelSequenceByName(seqDefine, false, null, false);
				return;
			}
			else
			{
				string currentSequence2 = this.InteractAnimationPlayer.GetCurrentSequence();
				if (currentSequence2 != null)
				{
					this.JumpToFirstFrame(this.RootItem.GetOwner() as AUIBaseActor, currentSequence2);
					this.InteractAnimationPlayer.StopPlayingSequence(false, true);
				}
				if (this.IsSelectOn)
				{
					return;
				}
				this.InteractAnimationPlayer.PlayLevelSequenceByName(seqDefine, false, null, false);
				return;
			}
		}

		// Token: 0x06038140 RID: 229696 RVA: 0x00D48734 File Offset: 0x00D46934
		private void JumpToFirstFrame(AUIBaseActor actor, string sequenceName)
		{
			FFrameTime fframeTime = new FFrameTime();
			actor.SequenceJumpToSecondByKey(sequenceName, fframeTime);
		}

		// Token: 0x0401D7D5 RID: 120789
		[Nullable(2)]
		protected LevelSequencePlayer InteractAnimationPlayer;

		// Token: 0x0401D7D6 RID: 120790
		[Nullable(2)]
		protected LevelSequencePlayer StateAnimationPlayer;

		// Token: 0x0401D7D7 RID: 120791
		private bool IsSelectOn;
	}
}
