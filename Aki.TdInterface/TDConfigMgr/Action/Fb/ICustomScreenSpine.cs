using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295F RID: 10591
	public class ICustomScreenSpine : ICustomScreenTypeBase
	{
		// Token: 0x0600EB11 RID: 60177 RVA: 0x0022A71A File Offset: 0x0022891A
		public static ICustomScreenSpine Create(ICustomScreenSpine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenSpine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004501 RID: 17665
		// (get) Token: 0x0600EB12 RID: 60178 RVA: 0x0022A739 File Offset: 0x00228939
		public override ECustomScreenType Type
		{
			get
			{
				return (ECustomScreenType)this.Instance.Type;
			}
		}

		// Token: 0x17004502 RID: 17666
		// (get) Token: 0x0600EB13 RID: 60179 RVA: 0x0022A746 File Offset: 0x00228946
		public virtual int SpineId
		{
			get
			{
				return this.Instance.SpineId;
			}
		}

		// Token: 0x0400817D RID: 33149
		private ICustomScreenSpine Instance;
	}
}
