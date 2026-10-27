using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200269D RID: 9885
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomScreenBackgroundImage : ICustomScreenTypeBase
	{
		// Token: 0x0600DD3E RID: 56638 RVA: 0x0020DFBB File Offset: 0x0020C1BB
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

		// Token: 0x170041C6 RID: 16838
		// (get) Token: 0x0600DD3F RID: 56639 RVA: 0x0020DFDA File Offset: 0x0020C1DA
		public override ECustomScreenType Type
		{
			get
			{
				return (ECustomScreenType)this.Instance.Type;
			}
		}

		// Token: 0x170041C7 RID: 16839
		// (get) Token: 0x0600DD40 RID: 56640 RVA: 0x0020DFE7 File Offset: 0x0020C1E7
		public virtual string BackgroundImagePath
		{
			get
			{
				return this.Instance.BackgroundImagePath;
			}
		}

		// Token: 0x04007AE1 RID: 31457
		private ICustomScreenBackgroundImage Instance;
	}
}
