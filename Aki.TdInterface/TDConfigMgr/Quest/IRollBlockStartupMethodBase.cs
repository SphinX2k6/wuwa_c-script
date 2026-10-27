using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200111E RID: 4382
	[NullableContext(1)]
	[Nullable(0)]
	public class IRollBlockStartupMethodBase
	{
		// Token: 0x060062EA RID: 25322 RVA: 0x000EDD70 File Offset: 0x000EBF70
		private IRollBlockStartupMethodBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRollBlockStartupMethodBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRollBlockStartupMethodBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRollBlockStartupMethodBase_SetValue());
			}
			return result;
		}

		// Token: 0x060062EB RID: 25323 RVA: 0x000EDDA8 File Offset: 0x000EBFA8
		public static IRollBlockStartupMethodBase Create([Nullable(2)] IRollBlockStartupMethodBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRollBlockStartupMethodBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x000EDDBB File Offset: 0x000EBFBB
		public static IRollBlockStartupMethodBase CreateFromSetValue([Nullable(2)] IRollBlockStartupMethodBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRollBlockStartupMethodBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x000EDDCE File Offset: 0x000EBFCE
		public IRollBlockStartupMethodBase_SetValue ToSetValue()
		{
			return new IRollBlockStartupMethodBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x060062EE RID: 25326 RVA: 0x000EDDE1 File Offset: 0x000EBFE1
		// (set) Token: 0x060062EF RID: 25327 RVA: 0x000EDE0C File Offset: 0x000EC00C
		public virtual ERollBlockLaunchMethod Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERollBlockLaunchMethod.Interact;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003B4F RID: 15183
		[Nullable(2)]
		protected IRollBlockStartupMethodBase FbInstance;

		// Token: 0x04003B50 RID: 15184
		[Nullable(2)]
		protected IRollBlockStartupMethodBase_SetValue PocoInterface;
	}
}
