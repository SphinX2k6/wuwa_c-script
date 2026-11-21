using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200204D RID: 8269
	public class ISetBehaviorPaused
	{
		// Token: 0x0600AF7F RID: 44927 RVA: 0x0018B51C File Offset: 0x0018971C
		private ISetBehaviorPaused_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetBehaviorPaused 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetBehaviorPaused_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetBehaviorPaused_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF80 RID: 44928 RVA: 0x0018B554 File Offset: 0x00189754
		public static ISetBehaviorPaused Create([Nullable(2)] ISetBehaviorPaused instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBehaviorPaused
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF81 RID: 44929 RVA: 0x0018B567 File Offset: 0x00189767
		public static ISetBehaviorPaused CreateFromSetValue([Nullable(2)] ISetBehaviorPaused_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetBehaviorPaused
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF82 RID: 44930 RVA: 0x0018B57A File Offset: 0x0018977A
		public ISetBehaviorPaused_SetValue ToSetValue()
		{
			return new ISetBehaviorPaused_SetValue
			{
				IsPaused = this.IsPaused
			};
		}

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0600AF83 RID: 44931 RVA: 0x0018B58D File Offset: 0x0018978D
		// (set) Token: 0x0600AF84 RID: 44932 RVA: 0x0018B5B8 File Offset: 0x001897B8
		public virtual bool IsPaused
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPaused;
				}
				return this.PocoInterface != null && this.PocoInterface.IsPaused;
			}
			set
			{
				this.GetOrCreatePoco().IsPaused = value;
			}
		}

		// Token: 0x0400687F RID: 26751
		[Nullable(2)]
		protected ISetBehaviorPaused FbInstance;

		// Token: 0x04006880 RID: 26752
		[Nullable(2)]
		protected ISetBehaviorPaused_SetValue PocoInterface;
	}
}
