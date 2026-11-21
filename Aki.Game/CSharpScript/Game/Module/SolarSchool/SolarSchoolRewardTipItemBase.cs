using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059FA RID: 23034
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public abstract class SolarSchoolRewardTipItemBase : ItemHintItemBase<SolarSchoolRewardTipData>
	{
		// Token: 0x06038BA1 RID: 232353 RVA: 0x00FE017F File Offset: 0x00FDE37F
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinished), false);
		}

		// Token: 0x06038BA2 RID: 232354 RVA: 0x00FE01AA File Offset: 0x00FDE3AA
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06038BA3 RID: 232355 RVA: 0x00FE01C4 File Offset: 0x00FDE3C4
		protected override void PlayStart()
		{
			this.StartSequenceName = this.GetStartSequenceName();
			this.SequencePlayer.PlayLevelSequenceByName(this.StartSequenceName, false, null, false);
		}

		// Token: 0x06038BA4 RID: 232356 RVA: 0x00FE01F9 File Offset: 0x00FDE3F9
		protected virtual string GetStartSequenceName()
		{
			return "Start";
		}

		// Token: 0x06038BA5 RID: 232357 RVA: 0x00FE0200 File Offset: 0x00FDE400
		public override void PlayEnd()
		{
			this.SequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x06038BA6 RID: 232358 RVA: 0x00FE0228 File Offset: 0x00FDE428
		protected override void OnActiveStatusChange(bool active)
		{
			if (active)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.ResumeSequence();
				return;
			}
			else
			{
				LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 == null)
				{
					return;
				}
				sequencePlayer2.PauseSequence();
				return;
			}
		}

		// Token: 0x06038BA7 RID: 232359 RVA: 0x00FE0250 File Offset: 0x00FDE450
		protected static string FormatDelta(int delta)
		{
			if (delta <= 0)
			{
				return delta.ToString();
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted<int>(delta);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06038BA8 RID: 232360 RVA: 0x00FE028D File Offset: 0x00FDE48D
		private void OnSequenceFinished(string sequenceName)
		{
			if (sequenceName == this.StartSequenceName)
			{
				base.FinishPlayStart();
				return;
			}
			if (sequenceName == "Close")
			{
				base.FinishPlayEnd();
			}
		}

		// Token: 0x0401DDE7 RID: 122343
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401DDE8 RID: 122344
		private string StartSequenceName = "Start";
	}
}
