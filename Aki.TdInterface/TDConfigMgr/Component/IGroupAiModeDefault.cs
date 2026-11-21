using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200044B RID: 1099
	public class IGroupAiModeDefault : IGroupAiMode
	{
		// Token: 0x060015EF RID: 5615 RVA: 0x00044E68 File Offset: 0x00043068
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

		// Token: 0x060015F0 RID: 5616 RVA: 0x00044EA0 File Offset: 0x000430A0
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

		// Token: 0x060015F1 RID: 5617 RVA: 0x00044EB3 File Offset: 0x000430B3
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

		// Token: 0x060015F2 RID: 5618 RVA: 0x00044EC6 File Offset: 0x000430C6
		public new IGroupAiModeDefault_SetValue ToSetValue()
		{
			return new IGroupAiModeDefault_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x00044ED9 File Offset: 0x000430D9
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x00044F04 File Offset: 0x00043104
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

		// Token: 0x04001124 RID: 4388
		[Nullable(2)]
		protected new IGroupAiModeDefault FbInstance;

		// Token: 0x04001125 RID: 4389
		[Nullable(2)]
		protected new IGroupAiModeDefault_SetValue PocoInterface;
	}
}
