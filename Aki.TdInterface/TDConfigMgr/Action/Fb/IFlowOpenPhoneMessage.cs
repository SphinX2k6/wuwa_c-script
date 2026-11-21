using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DBD RID: 11709
	public class IFlowOpenPhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x0600FF02 RID: 65282 RVA: 0x0024C286 File Offset: 0x0024A486
		public static IFlowOpenPhoneMessage Create(IFlowOpenPhoneMessage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowOpenPhoneMessage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005036 RID: 20534
		// (get) Token: 0x0600FF03 RID: 65283 RVA: 0x0024C2A5 File Offset: 0x0024A4A5
		public override EPhoneSystemInteractType Type
		{
			get
			{
				return (EPhoneSystemInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17005037 RID: 20535
		// (get) Token: 0x0600FF04 RID: 65284 RVA: 0x0024C2B2 File Offset: 0x0024A4B2
		public virtual IMessageBoard PhoneBoardType
		{
			get
			{
				if (this._PhoneBoardTypeInited)
				{
					return this._PhoneBoardTypeCache;
				}
				this._PhoneBoardTypeInited = true;
				this._PhoneBoardTypeCache = IMessageBoard.Create(this.Instance.PhoneBoardType);
				return this._PhoneBoardTypeCache;
			}
		}

		// Token: 0x04008B2F RID: 35631
		private IFlowOpenPhoneMessage Instance;

		// Token: 0x04008B30 RID: 35632
		[Nullable(2)]
		private IMessageBoard _PhoneBoardTypeCache;

		// Token: 0x04008B31 RID: 35633
		private bool _PhoneBoardTypeInited;
	}
}
