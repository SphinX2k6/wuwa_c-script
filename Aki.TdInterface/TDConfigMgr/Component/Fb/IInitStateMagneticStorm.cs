using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B56 RID: 2902
	public class IInitStateMagneticStorm : IInitState
	{
		// Token: 0x06004254 RID: 16980 RVA: 0x000A8A76 File Offset: 0x000A6C76
		public static IInitStateMagneticStorm Create(IInitStateMagneticStorm? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateMagneticStorm
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06004255 RID: 16981 RVA: 0x000A8A95 File Offset: 0x000A6C95
		public override EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x040024C1 RID: 9409
		private IInitStateMagneticStorm Instance;
	}
}
