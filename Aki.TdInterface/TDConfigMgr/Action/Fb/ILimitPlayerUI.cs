using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA2 RID: 10914
	public class ILimitPlayerUI : ILimitPlayerOption
	{
		// Token: 0x0600F0B4 RID: 61620 RVA: 0x002341C6 File Offset: 0x002323C6
		public static ILimitPlayerUI Create(ILimitPlayerUI? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerUI
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700481E RID: 18462
		// (get) Token: 0x0600F0B5 RID: 61621 RVA: 0x002341E5 File Offset: 0x002323E5
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04008458 RID: 33880
		private ILimitPlayerUI Instance;
	}
}
