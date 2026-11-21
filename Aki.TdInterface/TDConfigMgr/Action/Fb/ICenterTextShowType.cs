using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002990 RID: 10640
	public class ICenterTextShowType
	{
		// Token: 0x0600EBEA RID: 60394 RVA: 0x0022BDA6 File Offset: 0x00229FA6
		public static ICenterTextShowType Create(ICenterTextShowType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICenterTextShowType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004578 RID: 17784
		// (get) Token: 0x0600EBEB RID: 60395 RVA: 0x0022BDC5 File Offset: 0x00229FC5
		public virtual ECenterTextShowAnim Type
		{
			get
			{
				return (ECenterTextShowAnim)this.Instance.Type;
			}
		}

		// Token: 0x040081EA RID: 33258
		private ICenterTextShowType Instance;
	}
}
