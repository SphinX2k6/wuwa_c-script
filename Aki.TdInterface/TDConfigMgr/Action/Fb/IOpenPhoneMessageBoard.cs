using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DBC RID: 11708
	public class IOpenPhoneMessageBoard : IPhoneSystemInteractBase
	{
		// Token: 0x0600FEFE RID: 65278 RVA: 0x0024C21E File Offset: 0x0024A41E
		public static IOpenPhoneMessageBoard Create(IOpenPhoneMessageBoard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenPhoneMessageBoard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005034 RID: 20532
		// (get) Token: 0x0600FEFF RID: 65279 RVA: 0x0024C23D File Offset: 0x0024A43D
		public override EPhoneSystemInteractType Type
		{
			get
			{
				return (EPhoneSystemInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17005035 RID: 20533
		// (get) Token: 0x0600FF00 RID: 65280 RVA: 0x0024C24A File Offset: 0x0024A44A
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

		// Token: 0x04008B2C RID: 35628
		private IOpenPhoneMessageBoard Instance;

		// Token: 0x04008B2D RID: 35629
		[Nullable(2)]
		private IMessageBoard _PhoneBoardTypeCache;

		// Token: 0x04008B2E RID: 35630
		private bool _PhoneBoardTypeInited;
	}
}
