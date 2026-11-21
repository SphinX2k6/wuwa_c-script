using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB9 RID: 7609
	public class IMechStuntClimbFly : IMechStuntConfigType
	{
		// Token: 0x0600A19F RID: 41375 RVA: 0x001725A8 File Offset: 0x001707A8
		private IMechStuntClimbFly_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntClimbFly 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntClimbFly_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntClimbFly_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x001725E0 File Offset: 0x001707E0
		public static IMechStuntClimbFly Create([Nullable(2)] IMechStuntClimbFly instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntClimbFly
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x001725F3 File Offset: 0x001707F3
		public static IMechStuntClimbFly CreateFromSetValue([Nullable(2)] IMechStuntClimbFly_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntClimbFly
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x00172606 File Offset: 0x00170806
		public new IMechStuntClimbFly_SetValue ToSetValue()
		{
			return new IMechStuntClimbFly_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600A1A3 RID: 41379 RVA: 0x00172619 File Offset: 0x00170819
		// (set) Token: 0x0600A1A4 RID: 41380 RVA: 0x00172644 File Offset: 0x00170844
		public override EMechStuntType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechStuntType.Dive;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006223 RID: 25123
		[Nullable(2)]
		protected new IMechStuntClimbFly FbInstance;

		// Token: 0x04006224 RID: 25124
		[Nullable(2)]
		protected new IMechStuntClimbFly_SetValue PocoInterface;
	}
}
