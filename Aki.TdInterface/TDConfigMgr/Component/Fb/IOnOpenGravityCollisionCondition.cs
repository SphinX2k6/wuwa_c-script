using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3D RID: 2877
	public class IOnOpenGravityCollisionCondition : IBulletCreateCondition
	{
		// Token: 0x0600425E RID: 16990 RVA: 0x000A9D87 File Offset: 0x000A7F87
		[NullableContext(1)]
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

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x0600425F RID: 16991 RVA: 0x000A9DA6 File Offset: 0x000A7FA6
		public override EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06004260 RID: 16992 RVA: 0x000A9DB3 File Offset: 0x000A7FB3
		public override long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x04002568 RID: 9576
		private IOnOpenGravityCollisionCondition Instance;
	}
}
