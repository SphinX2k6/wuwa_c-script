using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DB8 RID: 11704
	public class IDeletePhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x0600FEF0 RID: 65264 RVA: 0x0024C0B6 File Offset: 0x0024A2B6
		public static IDeletePhoneMessage Create(IDeletePhoneMessage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeletePhoneMessage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700502E RID: 20526
		// (get) Token: 0x0600FEF1 RID: 65265 RVA: 0x0024C0D5 File Offset: 0x0024A2D5
		public override EPhoneSystemInteractType Type
		{
			get
			{
				return (EPhoneSystemInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700502F RID: 20527
		// (get) Token: 0x0600FEF2 RID: 65266 RVA: 0x0024C0E4 File Offset: 0x0024A2E4
		public virtual int? PhoneMessageId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PhoneMessageId);
			}
		}

		// Token: 0x04008B26 RID: 35622
		private IDeletePhoneMessage Instance;
	}
}
