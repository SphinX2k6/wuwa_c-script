using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200240C RID: 9228
	public class SetBehaviorIsPaused : ActionParams
	{
		// Token: 0x0600C8C8 RID: 51400 RVA: 0x001CAE84 File Offset: 0x001C9084
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

		// Token: 0x0600C8C9 RID: 51401 RVA: 0x001CAEBC File Offset: 0x001C90BC
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

		// Token: 0x0600C8CA RID: 51402 RVA: 0x001CAECF File Offset: 0x001C90CF
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

		// Token: 0x0600C8CB RID: 51403 RVA: 0x001CAEE2 File Offset: 0x001C90E2
		public SetBehaviorIsPaused_SetValue ToSetValue()
		{
			return new SetBehaviorIsPaused_SetValue
			{
				IsPaused = this.IsPaused
			};
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x0600C8CC RID: 51404 RVA: 0x001CAEF5 File Offset: 0x001C90F5
		// (set) Token: 0x0600C8CD RID: 51405 RVA: 0x001CAF20 File Offset: 0x001C9120
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

		// Token: 0x0400771D RID: 30493
		[Nullable(2)]
		protected new SetBehaviorIsPaused FbInstance;

		// Token: 0x0400771E RID: 30494
		[Nullable(2)]
		protected SetBehaviorIsPaused_SetValue PocoInterface;
	}
}
