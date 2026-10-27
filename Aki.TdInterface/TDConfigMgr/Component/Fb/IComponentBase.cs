using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A51 RID: 2641
	public class IComponentBase
	{
		// Token: 0x06003CD6 RID: 15574 RVA: 0x0009C8A7 File Offset: 0x0009AAA7
		[NullableContext(1)]
		public static IComponentBase Create(IComponentBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IComponentBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06003CD7 RID: 15575 RVA: 0x0009C8C8 File Offset: 0x0009AAC8
		public virtual bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x0009C900 File Offset: 0x0009AB00
		public virtual bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040021EC RID: 8684
		private IComponentBase Instance;
	}
}
