using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C33 RID: 3123
	public class IPullingFoundationType
	{
		// Token: 0x06004783 RID: 18307 RVA: 0x000B5499 File Offset: 0x000B3699
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

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x000B54B8 File Offset: 0x000B36B8
		public virtual EPullingFoundation Type
		{
			get
			{
				return (EPullingFoundation)this.Instance.Type;
			}
		}

		// Token: 0x04002836 RID: 10294
		private IPullingFoundationType Instance;
	}
}
