using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B9D RID: 2973
	public class IStateConfig
	{
		// Token: 0x060043FF RID: 17407 RVA: 0x000AC946 File Offset: 0x000AAB46
		public static IStateConfig Create(IStateConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06004400 RID: 17408 RVA: 0x000AC965 File Offset: 0x000AAB65
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06004401 RID: 17409 RVA: 0x000AC972 File Offset: 0x000AAB72
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x040025A6 RID: 9638
		private IStateConfig Instance;
	}
}
