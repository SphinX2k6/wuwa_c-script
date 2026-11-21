using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF5 RID: 7669
	public class IMontageId
	{
		// Token: 0x0600A2F1 RID: 41713 RVA: 0x00174C98 File Offset: 0x00172E98
		private IMontageId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMontageId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMontageId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMontageId_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x00174CD0 File Offset: 0x00172ED0
		public static IMontageId Create([Nullable(2)] IMontageId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageId
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2F3 RID: 41715 RVA: 0x00174CE3 File Offset: 0x00172EE3
		public static IMontageId CreateFromSetValue([Nullable(2)] IMontageId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMontageId
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x00174CF6 File Offset: 0x00172EF6
		public IMontageId_SetValue ToSetValue()
		{
			return new IMontageId_SetValue
			{
				MontageId = this.MontageId,
				IsAbp = this.IsAbp
			};
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600A2F5 RID: 41717 RVA: 0x00174D15 File Offset: 0x00172F15
		// (set) Token: 0x0600A2F6 RID: 41718 RVA: 0x00174D40 File Offset: 0x00172F40
		public virtual int MontageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MontageId;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600A2F7 RID: 41719 RVA: 0x00174D50 File Offset: 0x00172F50
		// (set) Token: 0x0600A2F8 RID: 41720 RVA: 0x00174D8A File Offset: 0x00172F8A
		public virtual bool? IsAbp
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAbp;
				}
				IMontageId_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAbp;
			}
			set
			{
				this.GetOrCreatePoco().IsAbp = value;
			}
		}

		// Token: 0x040062BE RID: 25278
		[Nullable(2)]
		protected IMontageId FbInstance;

		// Token: 0x040062BF RID: 25279
		[Nullable(2)]
		protected IMontageId_SetValue PocoInterface;
	}
}
