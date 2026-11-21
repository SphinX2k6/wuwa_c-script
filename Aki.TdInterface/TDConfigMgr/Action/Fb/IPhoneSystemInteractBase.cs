using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DB6 RID: 11702
	public class IPhoneSystemInteractBase
	{
		// Token: 0x0600FEE9 RID: 65257 RVA: 0x0024C01A File Offset: 0x0024A21A
		public static IPhoneSystemInteractBase Create(IPhoneSystemInteractBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneSystemInteractBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700502B RID: 20523
		// (get) Token: 0x0600FEEA RID: 65258 RVA: 0x0024C039 File Offset: 0x0024A239
		public virtual EPhoneSystemInteractType Type
		{
			get
			{
				return (EPhoneSystemInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04008B22 RID: 35618
		private IPhoneSystemInteractBase Instance;
	}
}
