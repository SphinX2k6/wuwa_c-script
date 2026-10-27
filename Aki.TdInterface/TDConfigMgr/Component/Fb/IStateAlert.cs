using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C9E RID: 3230
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateAlert
	{
		// Token: 0x060049DC RID: 18908 RVA: 0x000B9225 File Offset: 0x000B7425
		public static IStateAlert Create(IStateAlert? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateAlert
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x060049DD RID: 18909 RVA: 0x000B9244 File Offset: 0x000B7444
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x060049DE RID: 18910 RVA: 0x000B9251 File Offset: 0x000B7451
		public virtual int Alert
		{
			get
			{
				return this.Instance.Alert;
			}
		}

		// Token: 0x04002A31 RID: 10801
		private IStateAlert Instance;
	}
}
