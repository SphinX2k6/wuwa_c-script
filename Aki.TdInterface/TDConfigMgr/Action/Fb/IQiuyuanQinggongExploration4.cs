using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACD RID: 10957
	public class IQiuyuanQinggongExploration4 : ILeisureInteractType
	{
		// Token: 0x0600F15D RID: 61789 RVA: 0x0023507A File Offset: 0x0023327A
		public static IQiuyuanQinggongExploration4 Create(IQiuyuanQinggongExploration4? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration4
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004871 RID: 18545
		// (get) Token: 0x0600F15E RID: 61790 RVA: 0x00235099 File Offset: 0x00233299
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400849B RID: 33947
		private IQiuyuanQinggongExploration4 Instance;
	}
}
