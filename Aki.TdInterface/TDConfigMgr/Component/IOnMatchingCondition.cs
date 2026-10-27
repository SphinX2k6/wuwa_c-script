using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005AC RID: 1452
	[NullableContext(1)]
	[Nullable(0)]
	public class IOnMatchingCondition : IBulletCreateCondition
	{
		// Token: 0x06001EA8 RID: 7848 RVA: 0x00056A9C File Offset: 0x00054C9C
		private IOnMatchingCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnMatchingCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnMatchingCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnMatchingCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00056AD4 File Offset: 0x00054CD4
		public static IOnMatchingCondition Create([Nullable(2)] IOnMatchingCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnMatchingCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00056AE7 File Offset: 0x00054CE7
		public static IOnMatchingCondition CreateFromSetValue([Nullable(2)] IOnMatchingCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnMatchingCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00056AFA File Offset: 0x00054CFA
		public new IOnMatchingCondition_SetValue ToSetValue()
		{
			return new IOnMatchingCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId
			};
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x00056B19 File Offset: 0x00054D19
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x00056B44 File Offset: 0x00054D44
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

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x00056B52 File Offset: 0x00054D52
		// (set) Token: 0x06001EAF RID: 7855 RVA: 0x00056B7E File Offset: 0x00054D7E
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

		// Token: 0x040015D1 RID: 5585
		[Nullable(2)]
		protected new IOnMatchingCondition FbInstance;

		// Token: 0x040015D2 RID: 5586
		[Nullable(2)]
		protected new IOnMatchingCondition_SetValue PocoInterface;
	}
}
