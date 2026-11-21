using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200106C RID: 4204
	public class IDisableUro : ILogicProgramSpecialProcessOperation
	{
		// Token: 0x06005C9A RID: 23706 RVA: 0x000E125C File Offset: 0x000DF45C
		private IDisableUro_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableUro 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableUro_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableUro_SetValue());
			}
			return result;
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x000E1294 File Offset: 0x000DF494
		public static IDisableUro Create([Nullable(2)] IDisableUro instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableUro
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x000E12A7 File Offset: 0x000DF4A7
		public static IDisableUro CreateFromSetValue([Nullable(2)] IDisableUro_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableUro
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x000E12BA File Offset: 0x000DF4BA
		public new IDisableUro_SetValue ToSetValue()
		{
			return new IDisableUro_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x06005C9E RID: 23710 RVA: 0x000E12D9 File Offset: 0x000DF4D9
		// (set) Token: 0x06005C9F RID: 23711 RVA: 0x000E1304 File Offset: 0x000DF504
		public override ELogicProgramSpecialProcess Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELogicProgramSpecialProcess.DisableURO;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x06005CA0 RID: 23712 RVA: 0x000E1312 File Offset: 0x000DF512
		// (set) Token: 0x06005CA1 RID: 23713 RVA: 0x000E1339 File Offset: 0x000DF539
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IDisableUro_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x040037C5 RID: 14277
		[Nullable(2)]
		protected new IDisableUro FbInstance;

		// Token: 0x040037C6 RID: 14278
		[Nullable(2)]
		protected new IDisableUro_SetValue PocoInterface;
	}
}
