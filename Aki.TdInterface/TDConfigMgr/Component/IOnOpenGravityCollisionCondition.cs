using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005B0 RID: 1456
	[NullableContext(1)]
	[Nullable(0)]
	public class IOnOpenGravityCollisionCondition : IBulletCreateCondition
	{
		// Token: 0x06001EBC RID: 7868 RVA: 0x00056C9C File Offset: 0x00054E9C
		private IOnOpenGravityCollisionCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnOpenGravityCollisionCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnOpenGravityCollisionCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnOpenGravityCollisionCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00056CD4 File Offset: 0x00054ED4
		public static IOnOpenGravityCollisionCondition Create([Nullable(2)] IOnOpenGravityCollisionCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnOpenGravityCollisionCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00056CE7 File Offset: 0x00054EE7
		public static IOnOpenGravityCollisionCondition CreateFromSetValue([Nullable(2)] IOnOpenGravityCollisionCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnOpenGravityCollisionCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00056CFA File Offset: 0x00054EFA
		public new IOnOpenGravityCollisionCondition_SetValue ToSetValue()
		{
			return new IOnOpenGravityCollisionCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId
			};
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x00056D19 File Offset: 0x00054F19
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x00056D44 File Offset: 0x00054F44
		public override EBulletCreateCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBulletCreateCondition.OnHit;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x00056D52 File Offset: 0x00054F52
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x00056D7E File Offset: 0x00054F7E
		public override long BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x040015D9 RID: 5593
		[Nullable(2)]
		protected new IOnOpenGravityCollisionCondition FbInstance;

		// Token: 0x040015DA RID: 5594
		[Nullable(2)]
		protected new IOnOpenGravityCollisionCondition_SetValue PocoInterface;
	}
}
