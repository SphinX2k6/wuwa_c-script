using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E60 RID: 3680
	public class IInhaledChangeSelfState : IInhaledPerResultType
	{
		// Token: 0x0600532F RID: 21295 RVA: 0x000CD5CD File Offset: 0x000CB7CD
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

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x06005330 RID: 21296 RVA: 0x000CD5EC File Offset: 0x000CB7EC
		public override EInhaledPerResultType Type
		{
			get
			{
				return (EInhaledPerResultType)this.Instance.Type;
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06005331 RID: 21297 RVA: 0x000CD5F9 File Offset: 0x000CB7F9
		public virtual string ChangeSelfState
		{
			get
			{
				return this.Instance.ChangeSelfState;
			}
		}

		// Token: 0x04002F81 RID: 12161
		private IInhaledChangeSelfState Instance;
	}
}
