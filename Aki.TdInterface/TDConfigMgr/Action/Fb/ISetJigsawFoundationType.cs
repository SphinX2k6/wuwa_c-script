using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002971 RID: 10609
	public class ISetJigsawFoundationType
	{
		// Token: 0x0600EB1A RID: 60186 RVA: 0x00226742 File Offset: 0x00224942
		[NullableContext(1)]
		public static ISetJigsawFoundationType Create(ISetJigsawFoundationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetJigsawFoundationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049FA RID: 18938
		// (get) Token: 0x0600EB1B RID: 60187 RVA: 0x00226761 File Offset: 0x00224961
		public virtual ESetJigsawFoundationType Type
		{
			get
			{
				return (ESetJigsawFoundationType)this.Instance.Type;
			}
		}

		// Token: 0x04008185 RID: 33157
		private ISetJigsawFoundationType Instance;
	}
}
