using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002658 RID: 9816
	[NullableContext(2)]
	[Nullable(0)]
	public class IUiAnimConfig
	{
		// Token: 0x0600DC10 RID: 56336 RVA: 0x0020BFFA File Offset: 0x0020A1FA
		[NullableContext(1)]
		public static IUiAnimConfig Create(IUiAnimConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiAnimConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004122 RID: 16674
		// (get) Token: 0x0600DC11 RID: 56337 RVA: 0x0020C019 File Offset: 0x0020A219
		public virtual string UiStartAnimName
		{
			get
			{
				return this.Instance.UiStartAnimName;
			}
		}

		// Token: 0x17004123 RID: 16675
		// (get) Token: 0x0600DC12 RID: 56338 RVA: 0x0020C026 File Offset: 0x0020A226
		public virtual string UiEndAnimName
		{
			get
			{
				return this.Instance.UiEndAnimName;
			}
		}

		// Token: 0x04007A54 RID: 31316
		private IUiAnimConfig Instance;
	}
}
