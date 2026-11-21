using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002992 RID: 10642
	public class IICenterTextFadeOut : ICenterTextShowType
	{
		// Token: 0x0600EBF0 RID: 60400 RVA: 0x0022BE0E File Offset: 0x0022A00E
		public static IICenterTextFadeOut Create(IICenterTextFadeOut? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IICenterTextFadeOut
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700457A RID: 17786
		// (get) Token: 0x0600EBF1 RID: 60401 RVA: 0x0022BE2D File Offset: 0x0022A02D
		public override ECenterTextShowAnim Type
		{
			get
			{
				return (ECenterTextShowAnim)this.Instance.Type;
			}
		}

		// Token: 0x1700457B RID: 17787
		// (get) Token: 0x0600EBF2 RID: 60402 RVA: 0x0022BE3A File Offset: 0x0022A03A
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x1700457C RID: 17788
		// (get) Token: 0x0600EBF3 RID: 60403 RVA: 0x0022BE47 File Offset: 0x0022A047
		public virtual float FadeOutTime
		{
			get
			{
				return this.Instance.FadeOutTime;
			}
		}

		// Token: 0x040081EC RID: 33260
		private IICenterTextFadeOut Instance;
	}
}
