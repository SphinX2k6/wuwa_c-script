using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A8A RID: 2698
	[NullableContext(1)]
	[Nullable(0)]
	public class IInitStateBirth : IInitState
	{
		// Token: 0x06003E20 RID: 15904 RVA: 0x0009F2BA File Offset: 0x0009D4BA
		public static IInitStateBirth Create(IInitStateBirth? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateBirth
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06003E21 RID: 15905 RVA: 0x0009F2D9 File Offset: 0x0009D4D9
		public override EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x0009F2E6 File Offset: 0x0009D4E6
		public virtual string BirthTag
		{
			get
			{
				return this.Instance.BirthTag;
			}
		}

		// Token: 0x0400229D RID: 8861
		private IInitStateBirth Instance;
	}
}
