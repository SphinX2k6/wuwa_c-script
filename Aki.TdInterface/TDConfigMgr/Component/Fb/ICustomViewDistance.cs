using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF2 RID: 3570
	public class ICustomViewDistance : IViewDistanceMode
	{
		// Token: 0x060050E9 RID: 20713 RVA: 0x000C8988 File Offset: 0x000C6B88
		public static ICustomViewDistance Create(ICustomViewDistance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomViewDistance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x060050EA RID: 20714 RVA: 0x000C89A7 File Offset: 0x000C6BA7
		public override EViewDistanceType Type
		{
			get
			{
				return (EViewDistanceType)this.Instance.Type;
			}
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x060050EB RID: 20715 RVA: 0x000C89B4 File Offset: 0x000C6BB4
		public virtual int Distance
		{
			get
			{
				return this.Instance.Distance;
			}
		}

		// Token: 0x04002E17 RID: 11799
		private ICustomViewDistance Instance;
	}
}
