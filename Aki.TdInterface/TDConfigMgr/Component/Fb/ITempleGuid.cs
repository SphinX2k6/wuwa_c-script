using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B25 RID: 2853
	public class ITempleGuid
	{
		// Token: 0x06004133 RID: 16691 RVA: 0x000A6551 File Offset: 0x000A4751
		public static ITempleGuid Create(ITempleGuid? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITempleGuid
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06004134 RID: 16692 RVA: 0x000A6570 File Offset: 0x000A4770
		public virtual int TempleGuid
		{
			get
			{
				return this.Instance.TempleGuid;
			}
		}

		// Token: 0x0400241E RID: 9246
		private ITempleGuid Instance;
	}
}
