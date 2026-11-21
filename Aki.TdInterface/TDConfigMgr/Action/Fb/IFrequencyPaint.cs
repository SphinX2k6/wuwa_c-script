using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B3A RID: 11066
	public class IFrequencyPaint : IUiGame
	{
		// Token: 0x0600F361 RID: 62305 RVA: 0x00238552 File Offset: 0x00236752
		public static IFrequencyPaint Create(IFrequencyPaint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700499B RID: 18843
		// (get) Token: 0x0600F362 RID: 62306 RVA: 0x00238571 File Offset: 0x00236771
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04008586 RID: 34182
		private IFrequencyPaint Instance;
	}
}
