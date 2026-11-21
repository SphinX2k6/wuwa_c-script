using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200279A RID: 10138
	public class SendNpcMail : ActionParams
	{
		// Token: 0x0600E098 RID: 57496 RVA: 0x00210D3A File Offset: 0x0020EF3A
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

		// Token: 0x17003E12 RID: 15890
		// (get) Token: 0x0600E099 RID: 57497 RVA: 0x00210D59 File Offset: 0x0020EF59
		public virtual int MailId
		{
			get
			{
				return this.Instance.MailId;
			}
		}

		// Token: 0x04007A24 RID: 31268
		private ISendNpcMail Instance;
	}
}
