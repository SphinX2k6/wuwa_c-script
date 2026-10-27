using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D66 RID: 3430
	[NullableContext(1)]
	[Nullable(0)]
	public class IInhaledChangeSelfState : IInhaledPerResultType
	{
		// Token: 0x06004E13 RID: 19987 RVA: 0x000C1E89 File Offset: 0x000C0089
		public static IInhaledChangeSelfState Create(IInhaledChangeSelfState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledChangeSelfState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x06004E14 RID: 19988 RVA: 0x000C1EA8 File Offset: 0x000C00A8
		public override EInhaledPerResultType Type
		{
			get
			{
				return (EInhaledPerResultType)this.Instance.Type;
			}
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x06004E15 RID: 19989 RVA: 0x000C1EB5 File Offset: 0x000C00B5
		public virtual string ChangeSelfState
		{
			get
			{
				return this.Instance.ChangeSelfState;
			}
		}

		// Token: 0x04002CC1 RID: 11457
		private IInhaledChangeSelfState Instance;
	}
}
