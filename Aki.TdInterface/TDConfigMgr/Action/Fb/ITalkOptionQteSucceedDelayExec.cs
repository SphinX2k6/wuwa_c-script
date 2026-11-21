using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BA RID: 10170
	public class ITalkOptionQteSucceedDelayExec : ITalkOptionParamType
	{
		// Token: 0x0600E112 RID: 57618 RVA: 0x002117D8 File Offset: 0x0020F9D8
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

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x0600E113 RID: 57619 RVA: 0x002117F7 File Offset: 0x0020F9F7
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007A58 RID: 31320
		private ITalkOptionQteSucceedDelayExec Instance;
	}
}
