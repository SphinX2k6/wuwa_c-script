using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B65 RID: 2917
	public class IPullingFoundationType
	{
		// Token: 0x0600432A RID: 17194 RVA: 0x000AB3D5 File Offset: 0x000A95D5
		[NullableContext(1)]
		public static IPullingFoundationType Create(IPullingFoundationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPullingFoundationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x0600432B RID: 17195 RVA: 0x000AB3F4 File Offset: 0x000A95F4
		public virtual EPullingFoundation Type
		{
			get
			{
				return (EPullingFoundation)this.Instance.Type;
			}
		}

		// Token: 0x040025EE RID: 9710
		private IPullingFoundationType Instance;
	}
}
