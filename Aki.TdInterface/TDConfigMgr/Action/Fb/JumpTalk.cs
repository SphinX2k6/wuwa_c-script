using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A7 RID: 10151
	public class JumpTalk : ActionParams
	{
		// Token: 0x0600E0C9 RID: 57545 RVA: 0x002111CC File Offset: 0x0020F3CC
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

		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x0600E0CA RID: 57546 RVA: 0x002111EB File Offset: 0x0020F3EB
		public virtual int TalkId
		{
			get
			{
				return this.Instance.TalkId;
			}
		}

		// Token: 0x04007A3D RID: 31293
		private IJumpTalk Instance;
	}
}
