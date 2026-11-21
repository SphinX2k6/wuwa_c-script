using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200179F RID: 6047
	public class EnableAI : ActionParams
	{
		// Token: 0x060082F7 RID: 33527 RVA: 0x00139AAC File Offset: 0x00137CAC
		private EnableAI_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableAI 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableAI_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableAI_SetValue());
			}
			return result;
		}

		// Token: 0x060082F8 RID: 33528 RVA: 0x00139AE4 File Offset: 0x00137CE4
		public static EnableAI Create([Nullable(2)] EnableAI instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableAI
			{
				FbInstance = instance
			};
		}

		// Token: 0x060082F9 RID: 33529 RVA: 0x00139AF7 File Offset: 0x00137CF7
		public static EnableAI CreateFromSetValue([Nullable(2)] EnableAI_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableAI
			{
				PocoInterface = value
			};
		}

		// Token: 0x060082FA RID: 33530 RVA: 0x00139B0A File Offset: 0x00137D0A
		public EnableAI_SetValue ToSetValue()
		{
			return new EnableAI_SetValue
			{
				EntityIds = this.EntityIds,
				IsEnable = this.IsEnable
			};
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x060082FB RID: 33531 RVA: 0x00139B29 File Offset: 0x00137D29
		// (set) Token: 0x060082FC RID: 33532 RVA: 0x00139B50 File Offset: 0x00137D50
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				EnableAI_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x060082FD RID: 33533 RVA: 0x00139B5E File Offset: 0x00137D5E
		// (set) Token: 0x060082FE RID: 33534 RVA: 0x00139B89 File Offset: 0x00137D89
		public virtual bool IsEnable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnable;
				}
				return this.PocoInterface != null && this.PocoInterface.IsEnable;
			}
			set
			{
				this.GetOrCreatePoco().IsEnable = value;
			}
		}

		// Token: 0x0400503A RID: 20538
		[Nullable(2)]
		protected new EnableAI FbInstance;

		// Token: 0x0400503B RID: 20539
		[Nullable(2)]
		protected EnableAI_SetValue PocoInterface;
	}
}
