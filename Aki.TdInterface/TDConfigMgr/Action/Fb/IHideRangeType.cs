using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A5B RID: 10843
	public class IHideRangeType
	{
		// Token: 0x0600EF79 RID: 61305 RVA: 0x00231ABF File Offset: 0x0022FCBF
		public static IHideRangeType Create(IHideRangeType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideRangeType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004771 RID: 18289
		// (get) Token: 0x0600EF7A RID: 61306 RVA: 0x00231ADE File Offset: 0x0022FCDE
		public virtual EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x040083A3 RID: 33699
		private IHideRangeType Instance;
	}
}
