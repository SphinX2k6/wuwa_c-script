using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045F2 RID: 17906
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGridSelectBase : UiPanelBase
	{
		// Token: 0x0602D037 RID: 184375 RVA: 0x00C9625D File Offset: 0x00C9445D
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602D038 RID: 184376 RVA: 0x00C96296 File Offset: 0x00C94496
		protected override void OnStart()
		{
			this.InteractAnimationPlayer = new LevelSequencePlayer(this.RootItem);
			this.StateAnimationPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602D039 RID: 184377 RVA: 0x00C962BA File Offset: 0x00C944BA
		public void SetSelected(bool isSelectOn)
		{
			this.IsSelectOn = isSelectOn;
		}

		// Token: 0x0602D03A RID: 184378 RVA: 0x00C962C3 File Offset: 0x00C944C3
		public void SetState(bool groupEnable)
		{
			base.GetItem(0).SetUIActive(groupEnable);
			base.GetItem(1).SetUIActive(!groupEnable);
		}

		// Token: 0x0602D03B RID: 184379 RVA: 0x00C962E2 File Offset: 0x00C944E2
		public void SetSequenceToStart(string seqDefine)
		{
			this.JumpToFirstFrame(this.RootItem.GetOwner() as AUIBaseActor, seqDefine);
		}

		// Token: 0x0602D03C RID: 184380 RVA: 0x00C962FC File Offset: 0x00C944FC
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

		// Token: 0x0602D03D RID: 184381 RVA: 0x00C96374 File Offset: 0x00C94574
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

		// Token: 0x0602D03E RID: 184382 RVA: 0x00C9647C File Offset: 0x00C9467C
		private void JumpToFirstFrame(AUIBaseActor actor, string sequenceName)
		{
			FFrameTime fframeTime = new FFrameTime();
			actor.SequenceJumpToSecondByKey(sequenceName, fframeTime);
		}

		// Token: 0x04018260 RID: 98912
		[Nullable(2)]
		protected LevelSequencePlayer InteractAnimationPlayer;

		// Token: 0x04018261 RID: 98913
		[Nullable(2)]
		protected LevelSequencePlayer StateAnimationPlayer;

		// Token: 0x04018262 RID: 98914
		private bool IsSelectOn;
	}
}
