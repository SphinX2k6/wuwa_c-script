using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024F4 RID: 9460
	public class SendNpcMail : ActionParams
	{
		// Token: 0x0600D33C RID: 54076 RVA: 0x001F5342 File Offset: 0x001F3542
		[NullableContext(1)]
		public static SendNpcMail Create(ISendNpcMail? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SendNpcMail
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x0600D33D RID: 54077 RVA: 0x001F5361 File Offset: 0x001F3561
		public virtual int MailId
		{
			get
			{
				return this.Instance.MailId;
			}
		}

		// Token: 0x040073D2 RID: 29650
		private ISendNpcMail Instance;
	}
}
