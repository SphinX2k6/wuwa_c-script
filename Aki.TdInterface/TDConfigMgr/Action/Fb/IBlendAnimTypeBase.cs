using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DE0 RID: 11744
	public class IBlendAnimTypeBase
	{
		// Token: 0x0600FF81 RID: 65409 RVA: 0x0024CFE2 File Offset: 0x0024B1E2
		public static IBlendAnimTypeBase Create(IBlendAnimTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlendAnimTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700506F RID: 20591
		// (get) Token: 0x0600FF82 RID: 65410 RVA: 0x0024D001 File Offset: 0x0024B201
		public virtual EBlendAnimType Type
		{
			get
			{
				return (EBlendAnimType)this.Instance.Type;
			}
		}

		// Token: 0x04008B7C RID: 35708
		private IBlendAnimTypeBase Instance;
	}
}
