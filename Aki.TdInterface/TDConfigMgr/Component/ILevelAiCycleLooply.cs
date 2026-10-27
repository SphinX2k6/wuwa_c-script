using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004B4 RID: 1204
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelAiCycleLooply : ILevelAiCycleModeType
	{
		// Token: 0x0600184E RID: 6222 RVA: 0x00048CF4 File Offset: 0x00046EF4
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

		// Token: 0x0600184F RID: 6223 RVA: 0x00048D2C File Offset: 0x00046F2C
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

		// Token: 0x06001850 RID: 6224 RVA: 0x00048D3F File Offset: 0x00046F3F
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

		// Token: 0x06001851 RID: 6225 RVA: 0x00048D52 File Offset: 0x00046F52
		public new ILevelAiCycleLooply_SetValue ToSetValue()
		{
			return new ILevelAiCycleLooply_SetValue
			{
				Type = this.Type,
				IsCircle = this.IsCircle
			};
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x00048D71 File Offset: 0x00046F71
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x00048D9C File Offset: 0x00046F9C
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

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x00048DAA File Offset: 0x00046FAA
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x00048DD5 File Offset: 0x00046FD5
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

		// Token: 0x0400120A RID: 4618
		[Nullable(2)]
		protected new ILevelAiCycleLooply FbInstance;

		// Token: 0x0400120B RID: 4619
		[Nullable(2)]
		protected new ILevelAiCycleLooply_SetValue PocoInterface;
	}
}
