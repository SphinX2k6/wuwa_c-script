using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B56 RID: 2902
	public class IItemFoundationType
	{
		// Token: 0x060042D5 RID: 17109 RVA: 0x000AA8B5 File Offset: 0x000A8AB5
		[NullableContext(1)]
		public static IItemFoundationType Create(IItemFoundationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemFoundationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060042D6 RID: 17110 RVA: 0x000AA8D4 File Offset: 0x000A8AD4
		public virtual EItemFoundation Type
		{
			get
			{
				return (EItemFoundation)this.Instance.Type;
			}
		}

		// Token: 0x040025AB RID: 9643
		private IItemFoundationType Instance;
	}
}
