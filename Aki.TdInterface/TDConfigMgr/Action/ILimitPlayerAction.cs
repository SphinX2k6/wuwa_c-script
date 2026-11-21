using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D37 RID: 7479
	public class ILimitPlayerAction : ILimitPlayerOption
	{
		// Token: 0x06009EDB RID: 40667 RVA: 0x0016D31C File Offset: 0x0016B51C
		private ILimitPlayerAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerAction_SetValue());
			}
			return result;
		}

		// Token: 0x06009EDC RID: 40668 RVA: 0x0016D354 File Offset: 0x0016B554
		public static ILimitPlayerAction Create([Nullable(2)] ILimitPlayerAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EDD RID: 40669 RVA: 0x0016D367 File Offset: 0x0016B567
		public static ILimitPlayerAction CreateFromSetValue([Nullable(2)] ILimitPlayerAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EDE RID: 40670 RVA: 0x0016D37A File Offset: 0x0016B57A
		public new ILimitPlayerAction_SetValue ToSetValue()
		{
			return new ILimitPlayerAction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x06009EDF RID: 40671 RVA: 0x0016D38D File Offset: 0x0016B58D
		// (set) Token: 0x06009EE0 RID: 40672 RVA: 0x0016D3B8 File Offset: 0x0016B5B8
		public override ELimitPlayOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040060D2 RID: 24786
		[Nullable(2)]
		protected new ILimitPlayerAction FbInstance;

		// Token: 0x040060D3 RID: 24787
		[Nullable(2)]
		protected new ILimitPlayerAction_SetValue PocoInterface;
	}
}
