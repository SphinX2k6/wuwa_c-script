using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000617 RID: 1559
	public class IOnMatchingCondition : IBulletCreateCondition
	{
		// Token: 0x060020B8 RID: 8376 RVA: 0x0005BAC8 File Offset: 0x00059CC8
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

		// Token: 0x060020B9 RID: 8377 RVA: 0x0005BB00 File Offset: 0x00059D00
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

		// Token: 0x060020BA RID: 8378 RVA: 0x0005BB13 File Offset: 0x00059D13
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

		// Token: 0x060020BB RID: 8379 RVA: 0x0005BB26 File Offset: 0x00059D26
		public new IOnMatchingCondition_SetValue ToSetValue()
		{
			return new IOnMatchingCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId
			};
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x0005BB45 File Offset: 0x00059D45
		// (set) Token: 0x060020BD RID: 8381 RVA: 0x0005BB70 File Offset: 0x00059D70
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

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x0005BB7E File Offset: 0x00059D7E
		// (set) Token: 0x060020BF RID: 8383 RVA: 0x0005BBAA File Offset: 0x00059DAA
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

		// Token: 0x04001745 RID: 5957
		[Nullable(2)]
		protected new IOnMatchingCondition FbInstance;

		// Token: 0x04001746 RID: 5958
		[Nullable(2)]
		protected new IOnMatchingCondition_SetValue PocoInterface;
	}
}
