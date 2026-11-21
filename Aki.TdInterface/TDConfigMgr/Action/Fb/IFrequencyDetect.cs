using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B3B RID: 11067
	public class IFrequencyDetect : IUiGame
	{
		// Token: 0x0600F364 RID: 62308 RVA: 0x00238586 File Offset: 0x00236786
		public static IFrequencyDetect Create(IFrequencyDetect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyDetect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700499C RID: 18844
		// (get) Token: 0x0600F365 RID: 62309 RVA: 0x002385A5 File Offset: 0x002367A5
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700499D RID: 18845
		// (get) Token: 0x0600F366 RID: 62310 RVA: 0x002385B2 File Offset: 0x002367B2
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04008587 RID: 34183
		private IFrequencyDetect Instance;
	}
}
