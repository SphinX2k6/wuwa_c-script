using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026CE RID: 9934
	public class IICenterTextFadeOut : ICenterTextShowType
	{
		// Token: 0x0600DE14 RID: 56852 RVA: 0x0020F5CE File Offset: 0x0020D7CE
		[NullableContext(1)]
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

		// Token: 0x1700423A RID: 16954
		// (get) Token: 0x0600DE15 RID: 56853 RVA: 0x0020F5ED File Offset: 0x0020D7ED
		public override ECenterTextShowAnim Type
		{
			get
			{
				return (ECenterTextShowAnim)this.Instance.Type;
			}
		}

		// Token: 0x1700423B RID: 16955
		// (get) Token: 0x0600DE16 RID: 56854 RVA: 0x0020F5FA File Offset: 0x0020D7FA
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x1700423C RID: 16956
		// (get) Token: 0x0600DE17 RID: 56855 RVA: 0x0020F607 File Offset: 0x0020D807
		public virtual float FadeOutTime
		{
			get
			{
				return this.Instance.FadeOutTime;
			}
		}

		// Token: 0x04007B4C RID: 31564
		private IICenterTextFadeOut Instance;
	}
}
