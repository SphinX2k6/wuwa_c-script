using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3E RID: 10814
	public class IClientEventTarget
	{
		// Token: 0x0600EE21 RID: 60961 RVA: 0x0022AF2D File Offset: 0x0022912D
		[NullableContext(1)]
		public static IClientEventTarget Create(IClientEventTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B67 RID: 19303
		// (get) Token: 0x0600EE22 RID: 60962 RVA: 0x0022AF4C File Offset: 0x0022914C
		public virtual EClientEventTarget Type
		{
			get
			{
				return (EClientEventTarget)this.Instance.Type;
			}
		}

		// Token: 0x0400830C RID: 33548
		private IClientEventTarget Instance;
	}
}
