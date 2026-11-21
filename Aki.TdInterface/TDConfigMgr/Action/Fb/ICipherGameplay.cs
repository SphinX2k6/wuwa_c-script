using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B2B RID: 11051
	public class ICipherGameplay : IUiGame
	{
		// Token: 0x0600F31C RID: 62236 RVA: 0x00237E6E File Offset: 0x0023606E
		public static ICipherGameplay Create(ICipherGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICipherGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004974 RID: 18804
		// (get) Token: 0x0600F31D RID: 62237 RVA: 0x00237E8D File Offset: 0x0023608D
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004975 RID: 18805
		// (get) Token: 0x0600F31E RID: 62238 RVA: 0x00237E9A File Offset: 0x0023609A
		public virtual string CipherId
		{
			get
			{
				return this.Instance.CipherId;
			}
		}

		// Token: 0x04008569 RID: 34153
		private ICipherGameplay Instance;
	}
}
