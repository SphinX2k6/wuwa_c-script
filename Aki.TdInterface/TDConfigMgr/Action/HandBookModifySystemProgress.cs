using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018BF RID: 6335
	public class HandBookModifySystemProgress : ActionParams
	{
		// Token: 0x060084D9 RID: 34009 RVA: 0x0013CEA4 File Offset: 0x0013B0A4
		private HandBookModifySystemProgress_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HandBookModifySystemProgress 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HandBookModifySystemProgress_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HandBookModifySystemProgress_SetValue());
			}
			return result;
		}

		// Token: 0x060084DA RID: 34010 RVA: 0x0013CEDC File Offset: 0x0013B0DC
		public static HandBookModifySystemProgress Create([Nullable(2)] HandBookModifySystemProgress instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HandBookModifySystemProgress
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x0013CEEF File Offset: 0x0013B0EF
		public static HandBookModifySystemProgress CreateFromSetValue([Nullable(2)] HandBookModifySystemProgress_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HandBookModifySystemProgress
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x0013CF02 File Offset: 0x0013B102
		public HandBookModifySystemProgress_SetValue ToSetValue()
		{
			return new HandBookModifySystemProgress_SetValue
			{
				Operation = this.Operation
			};
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x060084DD RID: 34013 RVA: 0x0013CF15 File Offset: 0x0013B115
		// (set) Token: 0x060084DE RID: 34014 RVA: 0x0013CF3C File Offset: 0x0013B13C
		public virtual IHandBookProgressOption Operation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Operation;
				}
				HandBookModifySystemProgress_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Operation;
			}
			set
			{
				this.GetOrCreatePoco().Operation = value;
			}
		}

		// Token: 0x0400547C RID: 21628
		[Nullable(2)]
		protected new HandBookModifySystemProgress FbInstance;

		// Token: 0x0400547D RID: 21629
		[Nullable(2)]
		protected HandBookModifySystemProgress_SetValue PocoInterface;
	}
}
