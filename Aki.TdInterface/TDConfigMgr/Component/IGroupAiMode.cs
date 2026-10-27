using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003F0 RID: 1008
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiMode
	{
		// Token: 0x0600144D RID: 5197 RVA: 0x00041064 File Offset: 0x0003F264
		private IGroupAiMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0004109C File Offset: 0x0003F29C
		public static IGroupAiMode Create([Nullable(2)] IGroupAiMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000410AF File Offset: 0x0003F2AF
		public static IGroupAiMode CreateFromSetValue([Nullable(2)] IGroupAiMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x000410C2 File Offset: 0x0003F2C2
		public IGroupAiMode_SetValue ToSetValue()
		{
			return new IGroupAiMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x000410D5 File Offset: 0x0003F2D5
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x00041100 File Offset: 0x0003F300
		public virtual EGroupAiMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupAiMode.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000FFF RID: 4095
		[Nullable(2)]
		protected IGroupAiMode FbInstance;

		// Token: 0x04001000 RID: 4096
		[Nullable(2)]
		protected IGroupAiMode_SetValue PocoInterface;
	}
}
