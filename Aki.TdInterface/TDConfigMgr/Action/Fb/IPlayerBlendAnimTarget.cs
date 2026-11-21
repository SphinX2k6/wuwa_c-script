using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DDF RID: 11743
	public class IPlayerBlendAnimTarget : IBlendAnimTargetBase
	{
		// Token: 0x0600FF7E RID: 65406 RVA: 0x0024CFAE File Offset: 0x0024B1AE
		public static IPlayerBlendAnimTarget Create(IPlayerBlendAnimTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerBlendAnimTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700506E RID: 20590
		// (get) Token: 0x0600FF7F RID: 65407 RVA: 0x0024CFCD File Offset: 0x0024B1CD
		public override EBlendAnimTarget Type
		{
			get
			{
				return (EBlendAnimTarget)this.Instance.Type;
			}
		}

		// Token: 0x04008B7B RID: 35707
		private IPlayerBlendAnimTarget Instance;
	}
}
