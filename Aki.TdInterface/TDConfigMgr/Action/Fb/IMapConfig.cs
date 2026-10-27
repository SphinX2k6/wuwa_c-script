using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002656 RID: 9814
	public class IMapConfig
	{
		// Token: 0x0600DC0A RID: 56330 RVA: 0x0020BF67 File Offset: 0x0020A167
		[NullableContext(1)]
		public static IMapConfig Create(IMapConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMapConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004120 RID: 16672
		// (get) Token: 0x0600DC0B RID: 56331 RVA: 0x0020BF86 File Offset: 0x0020A186
		public virtual bool ExpandAreaTerminal
		{
			get
			{
				return this.Instance.ExpandAreaTerminal;
			}
		}

		// Token: 0x04007A52 RID: 31314
		private IMapConfig Instance;
	}
}
