using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F5 RID: 10741
	public class INewSplineMoveType
	{
		// Token: 0x0600ED8E RID: 60814 RVA: 0x0022EB6A File Offset: 0x0022CD6A
		public static INewSplineMoveType Create(INewSplineMoveType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewSplineMoveType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004652 RID: 18002
		// (get) Token: 0x0600ED8F RID: 60815 RVA: 0x0022EB89 File Offset: 0x0022CD89
		public virtual ENewSplineMoveType Type
		{
			get
			{
				return (ENewSplineMoveType)this.Instance.Type;
			}
		}

		// Token: 0x040082BF RID: 33471
		private INewSplineMoveType Instance;
	}
}
