using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002501 RID: 9473
	public class JumpTalk : ActionParams
	{
		// Token: 0x0600D36D RID: 54125 RVA: 0x001F57D4 File Offset: 0x001F39D4
		[NullableContext(1)]
		public static JumpTalk Create(IJumpTalk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new JumpTalk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x0600D36E RID: 54126 RVA: 0x001F57F3 File Offset: 0x001F39F3
		public virtual int TalkId
		{
			get
			{
				return this.Instance.TalkId;
			}
		}

		// Token: 0x040073EB RID: 29675
		private IJumpTalk Instance;
	}
}
