using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001513 RID: 5395
	[NullableContext(1)]
	[Nullable(0)]
	public class Collect : ActionParams
	{
		// Token: 0x06007A94 RID: 31380 RVA: 0x0012496C File Offset: 0x00122B6C
		private Collect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("Collect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			Collect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new Collect_SetValue());
			}
			return result;
		}

		// Token: 0x06007A95 RID: 31381 RVA: 0x001249A4 File Offset: 0x00122BA4
		public static Collect Create([Nullable(2)] Collect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Collect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007A96 RID: 31382 RVA: 0x001249B7 File Offset: 0x00122BB7
		public static Collect CreateFromSetValue([Nullable(2)] Collect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new Collect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007A97 RID: 31383 RVA: 0x001249CA File Offset: 0x00122BCA
		public Collect_SetValue ToSetValue()
		{
			return new Collect_SetValue
			{
				TargetEntity = this.TargetEntity
			};
		}

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x06007A98 RID: 31384 RVA: 0x001249E0 File Offset: 0x00122BE0
		// (set) Token: 0x06007A99 RID: 31385 RVA: 0x00124A1A File Offset: 0x00122C1A
		public virtual int? TargetEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntity;
				}
				Collect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetEntity;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntity = value;
			}
		}

		// Token: 0x040046FD RID: 18173
		[Nullable(2)]
		protected new Collect FbInstance;

		// Token: 0x040046FE RID: 18174
		[Nullable(2)]
		protected Collect_SetValue PocoInterface;
	}
}
