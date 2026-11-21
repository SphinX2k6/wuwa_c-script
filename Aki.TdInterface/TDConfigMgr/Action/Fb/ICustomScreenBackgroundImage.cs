using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002960 RID: 10592
	public class ICustomScreenBackgroundImage : ICustomScreenTypeBase
	{
		// Token: 0x0600EB15 RID: 60181 RVA: 0x0022A75B File Offset: 0x0022895B
		public static ICustomScreenBackgroundImage Create(ICustomScreenBackgroundImage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenBackgroundImage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004503 RID: 17667
		// (get) Token: 0x0600EB16 RID: 60182 RVA: 0x0022A77A File Offset: 0x0022897A
		public override ECustomScreenType Type
		{
			get
			{
				return (ECustomScreenType)this.Instance.Type;
			}
		}

		// Token: 0x17004504 RID: 17668
		// (get) Token: 0x0600EB17 RID: 60183 RVA: 0x0022A787 File Offset: 0x00228987
		public virtual string BackgroundImagePath
		{
			get
			{
				return this.Instance.BackgroundImagePath;
			}
		}

		// Token: 0x0400817E RID: 33150
		private ICustomScreenBackgroundImage Instance;
	}
}
