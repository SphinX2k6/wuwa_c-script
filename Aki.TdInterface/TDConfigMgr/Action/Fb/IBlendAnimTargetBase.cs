using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DDE RID: 11742
	public class IBlendAnimTargetBase
	{
		// Token: 0x0600FF7B RID: 65403 RVA: 0x0024CF7A File Offset: 0x0024B17A
		public static IBlendAnimTargetBase Create(IBlendAnimTargetBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlendAnimTargetBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700506D RID: 20589
		// (get) Token: 0x0600FF7C RID: 65404 RVA: 0x0024CF99 File Offset: 0x0024B199
		public virtual EBlendAnimTarget Type
		{
			get
			{
				return (EBlendAnimTarget)this.Instance.Type;
			}
		}

		// Token: 0x04008B7A RID: 35706
		private IBlendAnimTargetBase Instance;
	}
}
