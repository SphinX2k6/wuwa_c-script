using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C07 RID: 3079
	public class IOnHitCondition : IBulletCreateCondition
	{
		// Token: 0x060046A6 RID: 18086 RVA: 0x000B3D13 File Offset: 0x000B1F13
		public static IOnHitCondition Create(IOnHitCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnHitCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x000B3D32 File Offset: 0x000B1F32
		public override EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x000B3D3F File Offset: 0x000B1F3F
		public override long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x040027AA RID: 10154
		private IOnHitCondition Instance;
	}
}
