using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000521 RID: 1313
	public class ILiftFloorSeqMark
	{
		// Token: 0x06001A76 RID: 6774 RVA: 0x0004DE90 File Offset: 0x0004C090
		private ILiftFloorSeqMark_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiftFloorSeqMark 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiftFloorSeqMark_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiftFloorSeqMark_SetValue());
			}
			return result;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0004DEC8 File Offset: 0x0004C0C8
		public static ILiftFloorSeqMark Create([Nullable(2)] ILiftFloorSeqMark instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftFloorSeqMark
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0004DEDB File Offset: 0x0004C0DB
		public static ILiftFloorSeqMark CreateFromSetValue([Nullable(2)] ILiftFloorSeqMark_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiftFloorSeqMark
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0004DEEE File Offset: 0x0004C0EE
		public ILiftFloorSeqMark_SetValue ToSetValue()
		{
			return new ILiftFloorSeqMark_SetValue
			{
				Floor = this.Floor,
				Mark = this.Mark
			};
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x0004DF0D File Offset: 0x0004C10D
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0004DF38 File Offset: 0x0004C138
		public virtual int Floor
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Floor;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Floor;
			}
			set
			{
				this.GetOrCreatePoco().Floor = value;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0004DF46 File Offset: 0x0004C146
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0004DF71 File Offset: 0x0004C171
		public virtual string Mark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mark;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mark;
			}
			set
			{
				this.GetOrCreatePoco().Mark = value;
			}
		}

		// Token: 0x04001383 RID: 4995
		[Nullable(2)]
		protected ILiftFloorSeqMark FbInstance;

		// Token: 0x04001384 RID: 4996
		[Nullable(2)]
		protected ILiftFloorSeqMark_SetValue PocoInterface;
	}
}
