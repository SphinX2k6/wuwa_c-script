using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D22 RID: 11554
	public class SetupMoraleSystem : ActionParams
	{
		// Token: 0x0600FC9B RID: 64667 RVA: 0x0024867B File Offset: 0x0024687B
		public static SetupMoraleSystem Create(ISetupMoraleSystem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetupMoraleSystem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F05 RID: 20229
		// (get) Token: 0x0600FC9C RID: 64668 RVA: 0x0024869A File Offset: 0x0024689A
		public virtual int MoralePlayId
		{
			get
			{
				return this.Instance.MoralePlayId;
			}
		}

		// Token: 0x17004F06 RID: 20230
		// (get) Token: 0x0600FC9D RID: 64669 RVA: 0x002486A7 File Offset: 0x002468A7
		public virtual bool IsOn
		{
			get
			{
				return this.Instance.IsOn;
			}
		}

		// Token: 0x040089F0 RID: 35312
		private ISetupMoraleSystem Instance;
	}
}
