using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A2 RID: 10146
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreen : IScreenType
	{
		// Token: 0x0600E1C3 RID: 57795 RVA: 0x00215A95 File Offset: 0x00213C95
		public static ISubScreen Create(ISubScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004441 RID: 17473
		// (get) Token: 0x0600E1C4 RID: 57796 RVA: 0x00215AB4 File Offset: 0x00213CB4
		public override EScreenType Type
		{
			get
			{
				return (EScreenType)this.Instance.Type;
			}
		}

		// Token: 0x17004442 RID: 17474
		// (get) Token: 0x0600E1C5 RID: 57797 RVA: 0x00215AC1 File Offset: 0x00213CC1
		public virtual string SubScreenKey
		{
			get
			{
				return this.Instance.SubScreenKey;
			}
		}

		// Token: 0x04007D2E RID: 32046
		private ISubScreen Instance;
	}
}
