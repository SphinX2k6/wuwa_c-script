using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200050F RID: 1295
	public class ILevelAiCycleModeType
	{
		// Token: 0x060019F2 RID: 6642 RVA: 0x0004CB3C File Offset: 0x0004AD3C
		private ILevelAiCycleModeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelAiCycleModeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelAiCycleModeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelAiCycleModeType_SetValue());
			}
			return result;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x0004CB74 File Offset: 0x0004AD74
		public static ILevelAiCycleModeType Create([Nullable(2)] ILevelAiCycleModeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelAiCycleModeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x0004CB87 File Offset: 0x0004AD87
		public static ILevelAiCycleModeType CreateFromSetValue([Nullable(2)] ILevelAiCycleModeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelAiCycleModeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0004CB9A File Offset: 0x0004AD9A
		public ILevelAiCycleModeType_SetValue ToSetValue()
		{
			return new ILevelAiCycleModeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x0004CBAD File Offset: 0x0004ADAD
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0004CBD8 File Offset: 0x0004ADD8
		public virtual ELevelAiCycleMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELevelAiCycleMode.Loop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001330 RID: 4912
		[Nullable(2)]
		protected ILevelAiCycleModeType FbInstance;

		// Token: 0x04001331 RID: 4913
		[Nullable(2)]
		protected ILevelAiCycleModeType_SetValue PocoInterface;
	}
}
