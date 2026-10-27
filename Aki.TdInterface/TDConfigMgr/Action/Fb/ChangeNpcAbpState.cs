using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A9B RID: 10907
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeNpcAbpState : ActionParams
	{
		// Token: 0x0600EF90 RID: 61328 RVA: 0x0022D2AB File Offset: 0x0022B4AB
		public static ChangeNpcAbpState Create(IChangeNpcAbpState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeNpcAbpState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C1C RID: 19484
		// (get) Token: 0x0600EF91 RID: 61329 RVA: 0x0022D2CA File Offset: 0x0022B4CA
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004C1D RID: 19485
		// (get) Token: 0x0600EF92 RID: 61330 RVA: 0x0022D2D7 File Offset: 0x0022B4D7
		public virtual string AbpState
		{
			get
			{
				return this.Instance.AbpState;
			}
		}

		// Token: 0x040083C7 RID: 33735
		private IChangeNpcAbpState Instance;
	}
}
