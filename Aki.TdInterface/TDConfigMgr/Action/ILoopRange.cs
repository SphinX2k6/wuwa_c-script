using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB6 RID: 7094
	[NullableContext(1)]
	[Nullable(0)]
	public class ILoopRange
	{
		// Token: 0x060097E5 RID: 38885 RVA: 0x0015E3F8 File Offset: 0x0015C5F8
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

		// Token: 0x060097E6 RID: 38886 RVA: 0x0015E430 File Offset: 0x0015C630
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

		// Token: 0x060097E7 RID: 38887 RVA: 0x0015E443 File Offset: 0x0015C643
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

		// Token: 0x060097E8 RID: 38888 RVA: 0x0015E456 File Offset: 0x0015C656
		public ILoopRange_SetValue ToSetValue()
		{
			return new ILoopRange_SetValue
			{
				LeftMark = this.LeftMark,
				RightMark = this.RightMark
			};
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x060097E9 RID: 38889 RVA: 0x0015E475 File Offset: 0x0015C675
		// (set) Token: 0x060097EA RID: 38890 RVA: 0x0015E4A0 File Offset: 0x0015C6A0
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

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x060097EB RID: 38891 RVA: 0x0015E4AE File Offset: 0x0015C6AE
		// (set) Token: 0x060097EC RID: 38892 RVA: 0x0015E4D9 File Offset: 0x0015C6D9
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

		// Token: 0x04005CAF RID: 23727
		[Nullable(2)]
		protected ILoopRange FbInstance;

		// Token: 0x04005CB0 RID: 23728
		[Nullable(2)]
		protected ILoopRange_SetValue PocoInterface;
	}
}
