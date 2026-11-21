using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200142C RID: 5164
	public class ILinkSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060074FE RID: 29950 RVA: 0x001192D9 File Offset: 0x001174D9
		public static ILinkSystemConfig Create(ILinkSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILinkSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x060074FF RID: 29951 RVA: 0x001192F8 File Offset: 0x001174F8
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x06007500 RID: 29952 RVA: 0x00119305 File Offset: 0x00117505
		public virtual int LinkDataId
		{
			get
			{
				return this.Instance.LinkDataId;
			}
		}

		// Token: 0x040042BE RID: 17086
		private ILinkSystemConfig Instance;
	}
}
