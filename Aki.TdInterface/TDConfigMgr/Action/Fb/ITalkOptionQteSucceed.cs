using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B8 RID: 10168
	public class ITalkOptionQteSucceed : ITalkOptionParamType
	{
		// Token: 0x0600E10C RID: 57612 RVA: 0x00211770 File Offset: 0x0020F970
		public static ITalkOptionQteSucceed Create(ITalkOptionQteSucceed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteSucceed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x0600E10D RID: 57613 RVA: 0x0021178F File Offset: 0x0020F98F
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007A56 RID: 31318
		private ITalkOptionQteSucceed Instance;
	}
}
