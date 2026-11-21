using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D27 RID: 11559
	public class ISpecificScanEffect
	{
		// Token: 0x0600FCAB RID: 64683 RVA: 0x002487D5 File Offset: 0x002469D5
		public static ISpecificScanEffect Create(ISpecificScanEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecificScanEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F0B RID: 20235
		// (get) Token: 0x0600FCAC RID: 64684 RVA: 0x002487F4 File Offset: 0x002469F4
		public virtual ESpecificScanType Type
		{
			get
			{
				return (ESpecificScanType)this.Instance.Type;
			}
		}

		// Token: 0x040089F9 RID: 35321
		private ISpecificScanEffect Instance;
	}
}
