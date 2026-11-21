using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BB RID: 10171
	public class ITalkOptionQteFailedDelayExec : ITalkOptionParamType
	{
		// Token: 0x0600E115 RID: 57621 RVA: 0x0021180C File Offset: 0x0020FA0C
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

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x0600E116 RID: 57622 RVA: 0x0021182B File Offset: 0x0020FA2B
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007A59 RID: 31321
		private ITalkOptionQteFailedDelayExec Instance;
	}
}
