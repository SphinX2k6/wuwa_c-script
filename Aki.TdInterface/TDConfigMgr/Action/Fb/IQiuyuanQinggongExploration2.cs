using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACB RID: 10955
	public class IQiuyuanQinggongExploration2 : ILeisureInteractType
	{
		// Token: 0x0600F157 RID: 61783 RVA: 0x00235012 File Offset: 0x00233212
		public static IQiuyuanQinggongExploration2 Create(IQiuyuanQinggongExploration2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700486F RID: 18543
		// (get) Token: 0x0600F158 RID: 61784 RVA: 0x00235031 File Offset: 0x00233231
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008499 RID: 33945
		private IQiuyuanQinggongExploration2 Instance;
	}
}
