using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005AA RID: 1450
	[NullableContext(1)]
	[Nullable(0)]
	public class IOnHitCondition : IBulletCreateCondition
	{
		// Token: 0x06001E9E RID: 7838 RVA: 0x0005699C File Offset: 0x00054B9C
		private IOnHitCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnHitCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnHitCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnHitCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x000569D4 File Offset: 0x00054BD4
		public static IOnHitCondition Create([Nullable(2)] IOnHitCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnHitCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000569E7 File Offset: 0x00054BE7
		public static IOnHitCondition CreateFromSetValue([Nullable(2)] IOnHitCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnHitCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000569FA File Offset: 0x00054BFA
		public new IOnHitCondition_SetValue ToSetValue()
		{
			return new IOnHitCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId
			};
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x00056A19 File Offset: 0x00054C19
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00056A44 File Offset: 0x00054C44
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

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00056A52 File Offset: 0x00054C52
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x00056A7E File Offset: 0x00054C7E
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

		// Token: 0x040015CD RID: 5581
		[Nullable(2)]
		protected new IOnHitCondition FbInstance;

		// Token: 0x040015CE RID: 5582
		[Nullable(2)]
		protected new IOnHitCondition_SetValue PocoInterface;
	}
}
