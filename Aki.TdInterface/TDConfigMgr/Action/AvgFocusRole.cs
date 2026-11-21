using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015FA RID: 5626
	public class AvgFocusRole : ActionParams
	{
		// Token: 0x06007F0F RID: 32527 RVA: 0x0012F2E0 File Offset: 0x0012D4E0
		private AvgFocusRole_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AvgFocusRole 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AvgFocusRole_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AvgFocusRole_SetValue());
			}
			return result;
		}

		// Token: 0x06007F10 RID: 32528 RVA: 0x0012F318 File Offset: 0x0012D518
		public static AvgFocusRole Create([Nullable(2)] AvgFocusRole instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AvgFocusRole
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F11 RID: 32529 RVA: 0x0012F32B File Offset: 0x0012D52B
		public static AvgFocusRole CreateFromSetValue([Nullable(2)] AvgFocusRole_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AvgFocusRole
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F12 RID: 32530 RVA: 0x0012F33E File Offset: 0x0012D53E
		public AvgFocusRole_SetValue ToSetValue()
		{
			return new AvgFocusRole_SetValue
			{
				IsFocus = this.IsFocus
			};
		}

		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x06007F13 RID: 32531 RVA: 0x0012F351 File Offset: 0x0012D551
		// (set) Token: 0x06007F14 RID: 32532 RVA: 0x0012F37C File Offset: 0x0012D57C
		public virtual bool IsFocus
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFocus;
				}
				return this.PocoInterface != null && this.PocoInterface.IsFocus;
			}
			set
			{
				this.GetOrCreatePoco().IsFocus = value;
			}
		}

		// Token: 0x04004982 RID: 18818
		[Nullable(2)]
		protected new AvgFocusRole FbInstance;

		// Token: 0x04004983 RID: 18819
		[Nullable(2)]
		protected AvgFocusRole_SetValue PocoInterface;
	}
}
