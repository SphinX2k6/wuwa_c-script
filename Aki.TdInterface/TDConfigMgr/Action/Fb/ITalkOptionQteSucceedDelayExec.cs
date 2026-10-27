using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002514 RID: 9492
	public class ITalkOptionQteSucceedDelayExec : ITalkOptionParamType
	{
		// Token: 0x0600D3B6 RID: 54198 RVA: 0x001F5DE0 File Offset: 0x001F3FE0
		[NullableContext(1)]
		public static ITalkOptionQteSucceedDelayExec Create(ITalkOptionQteSucceedDelayExec? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteSucceedDelayExec
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x0600D3B7 RID: 54199 RVA: 0x001F5DFF File Offset: 0x001F3FFF
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007406 RID: 29702
		private ITalkOptionQteSucceedDelayExec Instance;
	}
}
