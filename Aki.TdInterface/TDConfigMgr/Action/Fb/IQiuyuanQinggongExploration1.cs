using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACA RID: 10954
	public class IQiuyuanQinggongExploration1 : ILeisureInteractType
	{
		// Token: 0x0600F154 RID: 61780 RVA: 0x00234FDE File Offset: 0x002331DE
		public static IQiuyuanQinggongExploration1 Create(IQiuyuanQinggongExploration1? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration1
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700486E RID: 18542
		// (get) Token: 0x0600F155 RID: 61781 RVA: 0x00234FFD File Offset: 0x002331FD
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008498 RID: 33944
		private IQiuyuanQinggongExploration1 Instance;
	}
}
