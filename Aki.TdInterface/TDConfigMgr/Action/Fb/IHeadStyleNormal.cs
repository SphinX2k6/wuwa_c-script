using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002503 RID: 9475
	public class IHeadStyleNormal : IHeadStyle
	{
		// Token: 0x0600D373 RID: 54131 RVA: 0x001F583C File Offset: 0x001F3A3C
		[NullableContext(1)]
		public static IHeadStyleNormal Create(IHeadStyleNormal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleNormal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x0600D374 RID: 54132 RVA: 0x001F585B File Offset: 0x001F3A5B
		public override EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x0600D375 RID: 54133 RVA: 0x001F5868 File Offset: 0x001F3A68
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x040073ED RID: 29677
		private IHeadStyleNormal Instance;
	}
}
