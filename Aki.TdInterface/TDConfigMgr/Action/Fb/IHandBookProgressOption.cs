using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E07 RID: 11783
	public class IHandBookProgressOption
	{
		// Token: 0x06010017 RID: 65559 RVA: 0x0024DCDE File Offset: 0x0024BEDE
		public static IHandBookProgressOption Create(IHandBookProgressOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandBookProgressOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050B7 RID: 20663
		// (get) Token: 0x06010018 RID: 65560 RVA: 0x0024DCFD File Offset: 0x0024BEFD
		public virtual EHandBookProgressType Type
		{
			get
			{
				return (EHandBookProgressType)this.Instance.Type;
			}
		}

		// Token: 0x04008BC1 RID: 35777
		private IHandBookProgressOption Instance;
	}
}
