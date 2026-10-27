using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A77 RID: 10871
	[NullableContext(1)]
	[Nullable(0)]
	public class DisableEntityLookAt : ActionParams
	{
		// Token: 0x0600EF01 RID: 61185 RVA: 0x0022C434 File Offset: 0x0022A634
		public static DisableEntityLookAt Create(IDisableEntityLookAt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DisableEntityLookAt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BD5 RID: 19413
		// (get) Token: 0x0600EF02 RID: 61186 RVA: 0x0022C453 File Offset: 0x0022A653
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x04008381 RID: 33665
		private IDisableEntityLookAt Instance;
	}
}
