using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021A1 RID: 8609
	[NullableContext(1)]
	[Nullable(0)]
	public class SetBehaviorIsPaused : ActionParams
	{
		// Token: 0x0600BD0E RID: 48398 RVA: 0x001B384C File Offset: 0x001B1A4C
		private SetBehaviorIsPaused_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetBehaviorIsPaused 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetBehaviorIsPaused_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetBehaviorIsPaused_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD0F RID: 48399 RVA: 0x001B3884 File Offset: 0x001B1A84
		public static SetBehaviorIsPaused Create([Nullable(2)] SetBehaviorIsPaused instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetBehaviorIsPaused
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD10 RID: 48400 RVA: 0x001B3897 File Offset: 0x001B1A97
		public static SetBehaviorIsPaused CreateFromSetValue([Nullable(2)] SetBehaviorIsPaused_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetBehaviorIsPaused
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD11 RID: 48401 RVA: 0x001B38AA File Offset: 0x001B1AAA
		public SetBehaviorIsPaused_SetValue ToSetValue()
		{
			return new SetBehaviorIsPaused_SetValue
			{
				IsPaused = this.IsPaused
			};
		}

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x0600BD12 RID: 48402 RVA: 0x001B38BD File Offset: 0x001B1ABD
		// (set) Token: 0x0600BD13 RID: 48403 RVA: 0x001B38E8 File Offset: 0x001B1AE8
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

		// Token: 0x040070D5 RID: 28885
		[Nullable(2)]
		protected new SetBehaviorIsPaused FbInstance;

		// Token: 0x040070D6 RID: 28886
		[Nullable(2)]
		protected SetBehaviorIsPaused_SetValue PocoInterface;
	}
}
