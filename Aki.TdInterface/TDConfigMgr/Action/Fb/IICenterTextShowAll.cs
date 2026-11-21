using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002991 RID: 10641
	public class IICenterTextShowAll : ICenterTextShowType
	{
		// Token: 0x0600EBED RID: 60397 RVA: 0x0022BDDA File Offset: 0x00229FDA
		public static IICenterTextShowAll Create(IICenterTextShowAll? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IICenterTextShowAll
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004579 RID: 17785
		// (get) Token: 0x0600EBEE RID: 60398 RVA: 0x0022BDF9 File Offset: 0x00229FF9
		public override ECenterTextShowAnim Type
		{
			get
			{
				return (ECenterTextShowAnim)this.Instance.Type;
			}
		}

		// Token: 0x040081EB RID: 33259
		private IICenterTextShowAll Instance;
	}
}
