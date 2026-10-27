using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002515 RID: 9493
	public class ITalkOptionQteFailedDelayExec : ITalkOptionParamType
	{
		// Token: 0x0600D3B9 RID: 54201 RVA: 0x001F5E14 File Offset: 0x001F4014
		[NullableContext(1)]
		public static ITalkOptionQteFailedDelayExec Create(ITalkOptionQteFailedDelayExec? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteFailedDelayExec
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x0600D3BA RID: 54202 RVA: 0x001F5E33 File Offset: 0x001F4033
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007407 RID: 29703
		private ITalkOptionQteFailedDelayExec Instance;
	}
}
