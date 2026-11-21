using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Dialogue
{
	// Token: 0x02004A9E RID: 19102
	public readonly struct DialogueJump
	{
		// Token: 0x17005FF7 RID: 24567
		// (get) Token: 0x0602FCC6 RID: 195782 RVA: 0x00D55FD8 File Offset: 0x00D541D8
		public bool EndsDialogue { get; }

		// Token: 0x17005FF8 RID: 24568
		// (get) Token: 0x0602FCC7 RID: 195783 RVA: 0x00D55FE0 File Offset: 0x00D541E0
		public int TargetId { get; }

		// Token: 0x0602FCC8 RID: 195784 RVA: 0x00D55FE8 File Offset: 0x00D541E8
		private DialogueJump(bool endsDialogue, int targetId)
		{
			this.EndsDialogue = endsDialogue;
			this.TargetId = targetId;
		}

		// Token: 0x0602FCC9 RID: 195785 RVA: 0x00D55FF8 File Offset: 0x00D541F8
		public static DialogueJump? From([Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<ActionInfo> actions)
		{
			if (actions == null)
			{
				DialogueJump? result = null;
				return result;
			}
			int? num = null;
			foreach (ActionInfo actionInfo in actions)
			{
				if (actionInfo != null && !actionInfo.Disabled.GetValueOrDefault())
				{
					if (actionInfo.Name == EAction.FinishTalk)
					{
						return new DialogueJump?(new DialogueJump(true, 0));
					}
					if (num == null && actionInfo.Name == EAction.JumpTalk)
					{
						JumpTalk jumpTalk = actionInfo.Params as JumpTalk;
						if (jumpTalk != null)
						{
							num = new int?(jumpTalk.TalkId);
						}
					}
				}
			}
			if (num == null)
			{
				return null;
			}
			return new DialogueJump?(new DialogueJump(false, num.Value));
		}
	}
}
