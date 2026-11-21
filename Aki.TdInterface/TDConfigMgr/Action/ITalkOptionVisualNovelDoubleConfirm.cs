using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C3 RID: 8643
	public class ITalkOptionVisualNovelDoubleConfirm
	{
		// Token: 0x0600BC6C RID: 48236 RVA: 0x001B4490 File Offset: 0x001B2690
		private ITalkOptionVisualNovelDoubleConfirm_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionVisualNovelDoubleConfirm 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionVisualNovelDoubleConfirm_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionVisualNovelDoubleConfirm_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC6D RID: 48237 RVA: 0x001B44C8 File Offset: 0x001B26C8
		public static ITalkOptionVisualNovelDoubleConfirm Create([Nullable(2)] ITalkOptionVisualNovelDoubleConfirm instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionVisualNovelDoubleConfirm
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC6E RID: 48238 RVA: 0x001B44DB File Offset: 0x001B26DB
		public static ITalkOptionVisualNovelDoubleConfirm CreateFromSetValue([Nullable(2)] ITalkOptionVisualNovelDoubleConfirm_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionVisualNovelDoubleConfirm
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC6F RID: 48239 RVA: 0x001B44EE File Offset: 0x001B26EE
		public ITalkOptionVisualNovelDoubleConfirm_SetValue ToSetValue()
		{
			return new ITalkOptionVisualNovelDoubleConfirm_SetValue
			{
				ConfirmBoxId = this.ConfirmBoxId
			};
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0600BC70 RID: 48240 RVA: 0x001B4501 File Offset: 0x001B2701
		// (set) Token: 0x0600BC71 RID: 48241 RVA: 0x001B452C File Offset: 0x001B272C
		public virtual int ConfirmBoxId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConfirmBoxId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ConfirmBoxId;
			}
			set
			{
				this.GetOrCreatePoco().ConfirmBoxId = value;
			}
		}

		// Token: 0x04007146 RID: 28998
		[Nullable(2)]
		protected ITalkOptionVisualNovelDoubleConfirm FbInstance;

		// Token: 0x04007147 RID: 28999
		[Nullable(2)]
		protected ITalkOptionVisualNovelDoubleConfirm_SetValue PocoInterface;
	}
}
