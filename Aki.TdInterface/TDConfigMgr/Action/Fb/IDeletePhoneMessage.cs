using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC4 RID: 10948
	public class IDeletePhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x0600F03A RID: 61498 RVA: 0x0022E3AA File Offset: 0x0022C5AA
		[NullableContext(1)]
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

		// Token: 0x17004C74 RID: 19572
		// (get) Token: 0x0600F03B RID: 61499 RVA: 0x0022E3C9 File Offset: 0x0022C5C9
		public override EPhoneSystemInteractType Type
		{
			get
			{
				return (EPhoneSystemInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17004C75 RID: 19573
		// (get) Token: 0x0600F03C RID: 61500 RVA: 0x0022E3D8 File Offset: 0x0022C5D8
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

		// Token: 0x04008422 RID: 33826
		private IDeletePhoneMessage Instance;
	}
}
