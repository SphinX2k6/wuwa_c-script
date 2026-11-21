using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001068 RID: 4200
	public class IDisableHLOD : IOperation
	{
		// Token: 0x06005C88 RID: 23688 RVA: 0x000E1060 File Offset: 0x000DF260
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

		// Token: 0x06005C89 RID: 23689 RVA: 0x000E1098 File Offset: 0x000DF298
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

		// Token: 0x06005C8A RID: 23690 RVA: 0x000E10AB File Offset: 0x000DF2AB
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

		// Token: 0x06005C8B RID: 23691 RVA: 0x000E10BE File Offset: 0x000DF2BE
		public new IDisableHLOD_SetValue ToSetValue()
		{
			return new IDisableHLOD_SetValue
			{
				Type = this.Type,
				IsDisable = this.IsDisable
			};
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x000E10DD File Offset: 0x000DF2DD
		// (set) Token: 0x06005C8D RID: 23693 RVA: 0x000E1108 File Offset: 0x000DF308
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

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x06005C8E RID: 23694 RVA: 0x000E1116 File Offset: 0x000DF316
		// (set) Token: 0x06005C8F RID: 23695 RVA: 0x000E1141 File Offset: 0x000DF341
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

		// Token: 0x040037BC RID: 14268
		[Nullable(2)]
		protected new IDisableHLOD FbInstance;

		// Token: 0x040037BD RID: 14269
		[Nullable(2)]
		protected new IDisableHLOD_SetValue PocoInterface;
	}
}
