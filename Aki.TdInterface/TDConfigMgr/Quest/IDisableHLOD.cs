using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F3E RID: 3902
	[NullableContext(1)]
	[Nullable(0)]
	public class IDisableHLOD : IOperation
	{
		// Token: 0x060056B8 RID: 22200 RVA: 0x000D469C File Offset: 0x000D289C
		private IDisableHLOD_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableHLOD 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableHLOD_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableHLOD_SetValue());
			}
			return result;
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x000D46D4 File Offset: 0x000D28D4
		public static IDisableHLOD Create([Nullable(2)] IDisableHLOD instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableHLOD
			{
				FbInstance = instance
			};
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x000D46E7 File Offset: 0x000D28E7
		public static IDisableHLOD CreateFromSetValue([Nullable(2)] IDisableHLOD_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableHLOD
			{
				PocoInterface = value
			};
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x000D46FA File Offset: 0x000D28FA
		public new IDisableHLOD_SetValue ToSetValue()
		{
			return new IDisableHLOD_SetValue
			{
				Type = this.Type,
				IsDisable = this.IsDisable
			};
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x060056BC RID: 22204 RVA: 0x000D4719 File Offset: 0x000D2919
		// (set) Token: 0x060056BD RID: 22205 RVA: 0x000D4744 File Offset: 0x000D2944
		public override EOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOperation.DisableHLOD;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x060056BE RID: 22206 RVA: 0x000D4752 File Offset: 0x000D2952
		// (set) Token: 0x060056BF RID: 22207 RVA: 0x000D477D File Offset: 0x000D297D
		public virtual bool IsDisable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDisable;
				}
				return this.PocoInterface != null && this.PocoInterface.IsDisable;
			}
			set
			{
				this.GetOrCreatePoco().IsDisable = value;
			}
		}

		// Token: 0x0400348D RID: 13453
		[Nullable(2)]
		protected new IDisableHLOD FbInstance;

		// Token: 0x0400348E RID: 13454
		[Nullable(2)]
		protected new IDisableHLOD_SetValue PocoInterface;
	}
}
