using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B57 RID: 2903
	public class IInitStateWuYinQu : IInitState
	{
		// Token: 0x06004257 RID: 16983 RVA: 0x000A8AAA File Offset: 0x000A6CAA
		public static IInitStateWuYinQu Create(IInitStateWuYinQu? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateWuYinQu
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06004258 RID: 16984 RVA: 0x000A8AC9 File Offset: 0x000A6CC9
		public override EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x040024C2 RID: 9410
		private IInitStateWuYinQu Instance;
	}
}
