using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB5 RID: 3253
	public class ICreateBulletConfig
	{
		// Token: 0x06004A51 RID: 19025 RVA: 0x000BAEDA File Offset: 0x000B90DA
		public static ICreateBulletConfig Create(ICreateBulletConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreateBulletConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06004A52 RID: 19026 RVA: 0x000BAEF9 File Offset: 0x000B90F9
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06004A53 RID: 19027 RVA: 0x000BAF06 File Offset: 0x000B9106
		public virtual float Delay
		{
			get
			{
				return this.Instance.Delay;
			}
		}

		// Token: 0x04002A1C RID: 10780
		private ICreateBulletConfig Instance;
	}
}
