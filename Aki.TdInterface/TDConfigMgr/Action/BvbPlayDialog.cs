using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001609 RID: 5641
	public class BvbPlayDialog : ActionParams
	{
		// Token: 0x06007F61 RID: 32609 RVA: 0x0012FD2C File Offset: 0x0012DF2C
		private BvbPlayDialog_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("BvbPlayDialog 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			BvbPlayDialog_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new BvbPlayDialog_SetValue());
			}
			return result;
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x0012FD64 File Offset: 0x0012DF64
		public static BvbPlayDialog Create([Nullable(2)] BvbPlayDialog instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BvbPlayDialog
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F63 RID: 32611 RVA: 0x0012FD77 File Offset: 0x0012DF77
		public static BvbPlayDialog CreateFromSetValue([Nullable(2)] BvbPlayDialog_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new BvbPlayDialog
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F64 RID: 32612 RVA: 0x0012FD8A File Offset: 0x0012DF8A
		public BvbPlayDialog_SetValue ToSetValue()
		{
			return new BvbPlayDialog_SetValue
			{
				DialogType = this.DialogType
			};
		}

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x06007F65 RID: 32613 RVA: 0x0012FD9D File Offset: 0x0012DF9D
		// (set) Token: 0x06007F66 RID: 32614 RVA: 0x0012FDC8 File Offset: 0x0012DFC8
		public virtual EBvbPlayDialogType DialogType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DialogType;
				}
				if (this.PocoInterface == null)
				{
					return EBvbPlayDialogType.DungeonBegin;
				}
				return this.PocoInterface.DialogType;
			}
			set
			{
				this.GetOrCreatePoco().DialogType = value;
			}
		}

		// Token: 0x040049AC RID: 18860
		[Nullable(2)]
		protected new BvbPlayDialog FbInstance;

		// Token: 0x040049AD RID: 18861
		[Nullable(2)]
		protected BvbPlayDialog_SetValue PocoInterface;
	}
}
