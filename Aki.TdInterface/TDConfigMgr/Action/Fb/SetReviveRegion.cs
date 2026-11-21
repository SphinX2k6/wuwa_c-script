using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002970 RID: 10608
	public class SetReviveRegion : ActionParams
	{
		// Token: 0x0600EB63 RID: 60259 RVA: 0x0022AFB6 File Offset: 0x002291B6
		public static SetReviveRegion Create(ISetReviveRegion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetReviveRegion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004531 RID: 17713
		// (get) Token: 0x0600EB64 RID: 60260 RVA: 0x0022AFD5 File Offset: 0x002291D5
		public virtual ESetReviveType SetReviveType
		{
			get
			{
				return (ESetReviveType)this.Instance.SetReviveType;
			}
		}

		// Token: 0x17004532 RID: 17714
		// (get) Token: 0x0600EB65 RID: 60261 RVA: 0x0022AFE2 File Offset: 0x002291E2
		public virtual int ReviveId
		{
			get
			{
				return this.Instance.ReviveId;
			}
		}

		// Token: 0x040081A2 RID: 33186
		private ISetReviveRegion Instance;
	}
}
