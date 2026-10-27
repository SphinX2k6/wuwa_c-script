using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C70 RID: 3184
	public class ITrafficBulletLogic : ICustomBulletLogic
	{
		// Token: 0x060048FA RID: 18682 RVA: 0x000B741D File Offset: 0x000B561D
		[NullableContext(1)]
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

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x060048FB RID: 18683 RVA: 0x000B743C File Offset: 0x000B563C
		public override ECustomBulletLogic Type
		{
			get
			{
				return (ECustomBulletLogic)this.Instance.Type;
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x060048FC RID: 18684 RVA: 0x000B7449 File Offset: 0x000B5649
		public virtual float MinSpeed
		{
			get
			{
				return this.Instance.MinSpeed;
			}
		}

		// Token: 0x040029A3 RID: 10659
		private ITrafficBulletLogic Instance;
	}
}
