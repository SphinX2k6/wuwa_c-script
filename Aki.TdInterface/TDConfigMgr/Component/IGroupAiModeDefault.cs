using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003F2 RID: 1010
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiModeDefault : IGroupAiMode
	{
		// Token: 0x06001455 RID: 5205 RVA: 0x00041120 File Offset: 0x0003F320
		private IGroupAiModeDefault_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiModeDefault 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiModeDefault_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiModeDefault_SetValue());
			}
			return result;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00041158 File Offset: 0x0003F358
		public static IGroupAiModeDefault Create([Nullable(2)] IGroupAiModeDefault instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiModeDefault
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0004116B File Offset: 0x0003F36B
		public static IGroupAiModeDefault CreateFromSetValue([Nullable(2)] IGroupAiModeDefault_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiModeDefault
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0004117E File Offset: 0x0003F37E
		public new IGroupAiModeDefault_SetValue ToSetValue()
		{
			return new IGroupAiModeDefault_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x00041191 File Offset: 0x0003F391
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x000411BC File Offset: 0x0003F3BC
		public override EGroupAiMode Type
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

		// Token: 0x04001002 RID: 4098
		[Nullable(2)]
		protected new IGroupAiModeDefault FbInstance;

		// Token: 0x04001003 RID: 4099
		[Nullable(2)]
		protected new IGroupAiModeDefault_SetValue PocoInterface;
	}
}
