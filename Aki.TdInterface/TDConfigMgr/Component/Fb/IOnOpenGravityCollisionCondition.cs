using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C0B RID: 3083
	public class IOnOpenGravityCollisionCondition : IBulletCreateCondition
	{
		// Token: 0x060046B7 RID: 18103 RVA: 0x000B3E4B File Offset: 0x000B204B
		public static IOnOpenGravityCollisionCondition Create(IOnOpenGravityCollisionCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnOpenGravityCollisionCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x000B3E6A File Offset: 0x000B206A
		public override EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x060046B9 RID: 18105 RVA: 0x000B3E77 File Offset: 0x000B2077
		public override long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x040027B0 RID: 10160
		private IOnOpenGravityCollisionCondition Instance;
	}
}
