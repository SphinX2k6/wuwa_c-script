using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002606 RID: 9734
	[NullableContext(1)]
	[Nullable(0)]
	public class CallFunction : ActionParams
	{
		// Token: 0x0600DAA2 RID: 55970 RVA: 0x00209379 File Offset: 0x00207579
		public static CallFunction Create(ICallFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CallFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004058 RID: 16472
		// (get) Token: 0x0600DAA3 RID: 55971 RVA: 0x00209398 File Offset: 0x00207598
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x04007972 RID: 31090
		private ICallFunction Instance;
	}
}
