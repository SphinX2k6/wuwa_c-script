using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F0 RID: 10736
	public class INewSplineMoveTarget
	{
		// Token: 0x0600ED7A RID: 60794 RVA: 0x0022E9AB File Offset: 0x0022CBAB
		public static INewSplineMoveTarget Create(INewSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004648 RID: 17992
		// (get) Token: 0x0600ED7B RID: 60795 RVA: 0x0022E9CA File Offset: 0x0022CBCA
		public virtual ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x040082B8 RID: 33464
		private INewSplineMoveTarget Instance;
	}
}
