using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACF RID: 10959
	public class IQiuyuanQinggongHovering : ILeisureInteractType
	{
		// Token: 0x0600F163 RID: 61795 RVA: 0x002350E2 File Offset: 0x002332E2
		public static IQiuyuanQinggongHovering Create(IQiuyuanQinggongHovering? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongHovering
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004873 RID: 18547
		// (get) Token: 0x0600F164 RID: 61796 RVA: 0x00235101 File Offset: 0x00233301
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400849D RID: 33949
		private IQiuyuanQinggongHovering Instance;
	}
}
