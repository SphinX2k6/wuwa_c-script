using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D9D RID: 7581
	public class ILoopRange
	{
		// Token: 0x0600A0E9 RID: 41193 RVA: 0x00170EB8 File Offset: 0x0016F0B8
		private ILoopRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILoopRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILoopRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILoopRange_SetValue());
			}
			return result;
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x00170EF0 File Offset: 0x0016F0F0
		public static ILoopRange Create([Nullable(2)] ILoopRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILoopRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x00170F03 File Offset: 0x0016F103
		public static ILoopRange CreateFromSetValue([Nullable(2)] ILoopRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILoopRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A0EC RID: 41196 RVA: 0x00170F16 File Offset: 0x0016F116
		public ILoopRange_SetValue ToSetValue()
		{
			return new ILoopRange_SetValue
			{
				LeftMark = this.LeftMark,
				RightMark = this.RightMark
			};
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600A0ED RID: 41197 RVA: 0x00170F35 File Offset: 0x0016F135
		// (set) Token: 0x0600A0EE RID: 41198 RVA: 0x00170F60 File Offset: 0x0016F160
		public virtual string LeftMark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeftMark;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.LeftMark;
			}
			set
			{
				this.GetOrCreatePoco().LeftMark = value;
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600A0EF RID: 41199 RVA: 0x00170F6E File Offset: 0x0016F16E
		// (set) Token: 0x0600A0F0 RID: 41200 RVA: 0x00170F99 File Offset: 0x0016F199
		public virtual string RightMark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RightMark;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.RightMark;
			}
			set
			{
				this.GetOrCreatePoco().RightMark = value;
			}
		}

		// Token: 0x040061C4 RID: 25028
		[Nullable(2)]
		protected ILoopRange FbInstance;

		// Token: 0x040061C5 RID: 25029
		[Nullable(2)]
		protected ILoopRange_SetValue PocoInterface;
	}
}
