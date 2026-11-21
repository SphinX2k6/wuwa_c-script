using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B59 RID: 2905
	public class IInitStateDigital : IInitState
	{
		// Token: 0x0600425D RID: 16989 RVA: 0x000A8B12 File Offset: 0x000A6D12
		public static IInitStateDigital Create(IInitStateDigital? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateDigital
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x000A8B31 File Offset: 0x000A6D31
		public override EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x040024C4 RID: 9412
		private IInitStateDigital Instance;
	}
}
