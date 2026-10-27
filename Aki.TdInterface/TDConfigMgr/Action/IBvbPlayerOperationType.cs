using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200182E RID: 6190
	[NullableContext(1)]
	[Nullable(0)]
	public class IBvbPlayerOperationType
	{
		// Token: 0x060084D9 RID: 34009 RVA: 0x0013C3F8 File Offset: 0x0013A5F8
		private IBvbPlayerOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbPlayerOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbPlayerOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbPlayerOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x060084DA RID: 34010 RVA: 0x0013C430 File Offset: 0x0013A630
		public static IBvbPlayerOperationType Create([Nullable(2)] IBvbPlayerOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbPlayerOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x0013C443 File Offset: 0x0013A643
		public static IBvbPlayerOperationType CreateFromSetValue([Nullable(2)] IBvbPlayerOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbPlayerOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x0013C456 File Offset: 0x0013A656
		public IBvbPlayerOperationType_SetValue ToSetValue()
		{
			return new IBvbPlayerOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x060084DD RID: 34013 RVA: 0x0013C469 File Offset: 0x0013A669
		// (set) Token: 0x060084DE RID: 34014 RVA: 0x0013C494 File Offset: 0x0013A694
		public virtual EBvbPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005401 RID: 21505
		[Nullable(2)]
		protected IBvbPlayerOperationType FbInstance;

		// Token: 0x04005402 RID: 21506
		[Nullable(2)]
		protected IBvbPlayerOperationType_SetValue PocoInterface;
	}
}
