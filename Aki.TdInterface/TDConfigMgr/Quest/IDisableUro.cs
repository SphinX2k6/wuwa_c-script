using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F42 RID: 3906
	[NullableContext(1)]
	[Nullable(0)]
	public class IDisableUro : ILogicProgramSpecialProcessOperation
	{
		// Token: 0x060056CA RID: 22218 RVA: 0x000D4898 File Offset: 0x000D2A98
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

		// Token: 0x060056CB RID: 22219 RVA: 0x000D48D0 File Offset: 0x000D2AD0
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

		// Token: 0x060056CC RID: 22220 RVA: 0x000D48E3 File Offset: 0x000D2AE3
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

		// Token: 0x060056CD RID: 22221 RVA: 0x000D48F6 File Offset: 0x000D2AF6
		public new IDisableUro_SetValue ToSetValue()
		{
			return new IDisableUro_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x060056CE RID: 22222 RVA: 0x000D4915 File Offset: 0x000D2B15
		// (set) Token: 0x060056CF RID: 22223 RVA: 0x000D4940 File Offset: 0x000D2B40
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

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x060056D0 RID: 22224 RVA: 0x000D494E File Offset: 0x000D2B4E
		// (set) Token: 0x060056D1 RID: 22225 RVA: 0x000D4975 File Offset: 0x000D2B75
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

		// Token: 0x04003496 RID: 13462
		[Nullable(2)]
		protected new IDisableUro FbInstance;

		// Token: 0x04003497 RID: 13463
		[Nullable(2)]
		protected new IDisableUro_SetValue PocoInterface;
	}
}
