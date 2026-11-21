using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D5B RID: 11611
	public class IDefaultLookAtType
	{
		// Token: 0x0600FD77 RID: 64887 RVA: 0x00249A1A File Offset: 0x00247C1A
		public static IDefaultLookAtType Create(IDefaultLookAtType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDefaultLookAtType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F6F RID: 20335
		// (get) Token: 0x0600FD78 RID: 64888 RVA: 0x00249A39 File Offset: 0x00247C39
		public virtual EDefaultLookAtType Type
		{
			get
			{
				return (EDefaultLookAtType)this.Instance.Type;
			}
		}

		// Token: 0x04008A5B RID: 35419
		private IDefaultLookAtType Instance;
	}
}
