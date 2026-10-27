using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002931 RID: 10545
	public class EnableFunction : ActionParams
	{
		// Token: 0x0600E9F4 RID: 59892 RVA: 0x00224653 File Offset: 0x00222853
		[NullableContext(1)]
		public static EnableFunction Create(IEnableFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004954 RID: 18772
		// (get) Token: 0x0600E9F5 RID: 59893 RVA: 0x00224672 File Offset: 0x00222872
		public virtual EEnableFunctionType Type
		{
			get
			{
				return (EEnableFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x0400810B RID: 33035
		private IEnableFunction Instance;
	}
}
