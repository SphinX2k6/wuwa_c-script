using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A9F RID: 10911
	public class ILimitPlayerCamera : ILimitPlayerOption
	{
		// Token: 0x0600F0A7 RID: 61607 RVA: 0x002340F6 File Offset: 0x002322F6
		public static ILimitPlayerCamera Create(ILimitPlayerCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004817 RID: 18455
		// (get) Token: 0x0600F0A8 RID: 61608 RVA: 0x00234115 File Offset: 0x00232315
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04008455 RID: 33877
		private ILimitPlayerCamera Instance;
	}
}
