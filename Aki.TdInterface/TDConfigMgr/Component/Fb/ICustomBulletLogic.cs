using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D4E RID: 3406
	public class ICustomBulletLogic
	{
		// Token: 0x06004D96 RID: 19862 RVA: 0x000C1BED File Offset: 0x000BFDED
		public static ICustomBulletLogic Create(ICustomBulletLogic? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomBulletLogic
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06004D97 RID: 19863 RVA: 0x000C1C0C File Offset: 0x000BFE0C
		public virtual ECustomBulletLogic Type
		{
			get
			{
				return (ECustomBulletLogic)this.Instance.Type;
			}
		}

		// Token: 0x04002C0F RID: 11279
		private ICustomBulletLogic Instance;
	}
}
