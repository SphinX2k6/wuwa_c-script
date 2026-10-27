using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200266C RID: 9836
	public class OpenSystemFunction : ActionParams
	{
		// Token: 0x0600DC7C RID: 56444 RVA: 0x0020CD4D File Offset: 0x0020AF4D
		[NullableContext(1)]
		public static OpenSystemFunction Create(IOpenSystemFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenSystemFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004166 RID: 16742
		// (get) Token: 0x0600DC7D RID: 56445 RVA: 0x0020CD6C File Offset: 0x0020AF6C
		public virtual int FunctionId
		{
			get
			{
				return this.Instance.FunctionId;
			}
		}

		// Token: 0x04007A94 RID: 31380
		private IOpenSystemFunction Instance;
	}
}
