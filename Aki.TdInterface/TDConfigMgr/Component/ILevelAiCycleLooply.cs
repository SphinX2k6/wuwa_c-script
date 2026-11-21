using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200050D RID: 1293
	public class ILevelAiCycleLooply : ILevelAiCycleModeType
	{
		// Token: 0x060019E8 RID: 6632 RVA: 0x0004CA3C File Offset: 0x0004AC3C
		private ILevelAiCycleLooply_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelAiCycleLooply 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelAiCycleLooply_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelAiCycleLooply_SetValue());
			}
			return result;
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0004CA74 File Offset: 0x0004AC74
		public static ILevelAiCycleLooply Create([Nullable(2)] ILevelAiCycleLooply instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelAiCycleLooply
			{
				FbInstance = instance
			};
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0004CA87 File Offset: 0x0004AC87
		public static ILevelAiCycleLooply CreateFromSetValue([Nullable(2)] ILevelAiCycleLooply_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelAiCycleLooply
			{
				PocoInterface = value
			};
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0004CA9A File Offset: 0x0004AC9A
		public new ILevelAiCycleLooply_SetValue ToSetValue()
		{
			return new ILevelAiCycleLooply_SetValue
			{
				Type = this.Type,
				IsCircle = this.IsCircle
			};
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x0004CAB9 File Offset: 0x0004ACB9
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x0004CAE4 File Offset: 0x0004ACE4
		public override ELevelAiCycleMode Type
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

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x0004CAF2 File Offset: 0x0004ACF2
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x0004CB1D File Offset: 0x0004AD1D
		public virtual bool IsCircle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsCircle;
				}
				return this.PocoInterface != null && this.PocoInterface.IsCircle;
			}
			set
			{
				this.GetOrCreatePoco().IsCircle = value;
			}
		}

		// Token: 0x0400132C RID: 4908
		[Nullable(2)]
		protected new ILevelAiCycleLooply FbInstance;

		// Token: 0x0400132D RID: 4909
		[Nullable(2)]
		protected new ILevelAiCycleLooply_SetValue PocoInterface;
	}
}
