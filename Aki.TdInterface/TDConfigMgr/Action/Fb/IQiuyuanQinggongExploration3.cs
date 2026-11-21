using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACC RID: 10956
	public class IQiuyuanQinggongExploration3 : ILeisureInteractType
	{
		// Token: 0x0600F15A RID: 61786 RVA: 0x00235046 File Offset: 0x00233246
		public static IQiuyuanQinggongExploration3 Create(IQiuyuanQinggongExploration3? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration3
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004870 RID: 18544
		// (get) Token: 0x0600F15B RID: 61787 RVA: 0x00235065 File Offset: 0x00233265
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400849A RID: 33946
		private IQiuyuanQinggongExploration3 Instance;
	}
}
