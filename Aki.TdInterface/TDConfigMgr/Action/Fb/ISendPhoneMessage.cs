using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DB7 RID: 11703
	public class ISendPhoneMessage : IPhoneSystemInteractBase
	{
		// Token: 0x0600FEEC RID: 65260 RVA: 0x0024C04E File Offset: 0x0024A24E
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

		// Token: 0x1700502C RID: 20524
		// (get) Token: 0x0600FEED RID: 65261 RVA: 0x0024C06D File Offset: 0x0024A26D
		public override EPhoneSystemInteractType Type
		{
			get
			{
				return (EPhoneSystemInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700502D RID: 20525
		// (get) Token: 0x0600FEEE RID: 65262 RVA: 0x0024C07A File Offset: 0x0024A27A
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

		// Token: 0x04008B23 RID: 35619
		private ISendPhoneMessage Instance;

		// Token: 0x04008B24 RID: 35620
		[Nullable(2)]
		private IPhoneRecordActionConfig _PhoneRecordActionConfigCache;

		// Token: 0x04008B25 RID: 35621
		private bool _PhoneRecordActionConfigInited;
	}
}
