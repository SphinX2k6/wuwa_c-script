using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC3 RID: 10947
	[NullableContext(1)]
	[Nullable(0)]
	public class ISendPhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x0600F036 RID: 61494 RVA: 0x0022E342 File Offset: 0x0022C542
		public static ISendPhoneMessage Create(ISendPhoneMessage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendPhoneMessage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C72 RID: 19570
		// (get) Token: 0x0600F037 RID: 61495 RVA: 0x0022E361 File Offset: 0x0022C561
		public override EPhoneSystemInteractType Type
		{
			get
			{
				return (EPhoneSystemInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17004C73 RID: 19571
		// (get) Token: 0x0600F038 RID: 61496 RVA: 0x0022E36E File Offset: 0x0022C56E
		public virtual IPhoneRecordActionConfig PhoneRecordActionConfig
		{
			get
			{
				if (this._PhoneRecordActionConfigInited)
				{
					return this._PhoneRecordActionConfigCache;
				}
				this._PhoneRecordActionConfigInited = true;
				this._PhoneRecordActionConfigCache = IPhoneRecordActionConfig.Create(this.Instance.PhoneRecordActionConfig);
				return this._PhoneRecordActionConfigCache;
			}
		}

		// Token: 0x0400841F RID: 33823
		private ISendPhoneMessage Instance;

		// Token: 0x04008420 RID: 33824
		[Nullable(2)]
		private IPhoneRecordActionConfig _PhoneRecordActionConfigCache;

		// Token: 0x04008421 RID: 33825
		private bool _PhoneRecordActionConfigInited;
	}
}
