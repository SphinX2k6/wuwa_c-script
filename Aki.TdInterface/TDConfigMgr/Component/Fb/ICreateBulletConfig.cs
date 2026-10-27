using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE6 RID: 3046
	public class ICreateBulletConfig
	{
		// Token: 0x060045F3 RID: 17907 RVA: 0x000B0D5E File Offset: 0x000AEF5E
		[NullableContext(1)]
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

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x000B0D7D File Offset: 0x000AEF7D
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x000B0D8A File Offset: 0x000AEF8A
		public virtual float Delay
		{
			get
			{
				return this.Instance.Delay;
			}
		}

		// Token: 0x040027D1 RID: 10193
		private ICreateBulletConfig Instance;
	}
}
