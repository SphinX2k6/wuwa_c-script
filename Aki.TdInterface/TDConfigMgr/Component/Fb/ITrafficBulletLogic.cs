using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D4F RID: 3407
	public class ITrafficBulletLogic : ICustomBulletLogic
	{
		// Token: 0x06004D99 RID: 19865 RVA: 0x000C1C21 File Offset: 0x000BFE21
		public static ITrafficBulletLogic Create(ITrafficBulletLogic? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrafficBulletLogic
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06004D9A RID: 19866 RVA: 0x000C1C40 File Offset: 0x000BFE40
		public override ECustomBulletLogic Type
		{
			get
			{
				return (ECustomBulletLogic)this.Instance.Type;
			}
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06004D9B RID: 19867 RVA: 0x000C1C4D File Offset: 0x000BFE4D
		public virtual float MinSpeed
		{
			get
			{
				return this.Instance.MinSpeed;
			}
		}

		// Token: 0x04002C10 RID: 11280
		private ITrafficBulletLogic Instance;
	}
}
