using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002418 RID: 9240
	public class SetEntityClientVisible : ActionParams
	{
		// Token: 0x0600C908 RID: 51464 RVA: 0x001CB598 File Offset: 0x001C9798
		private SetEntityClientVisible_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetEntityClientVisible 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetEntityClientVisible_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetEntityClientVisible_SetValue());
			}
			return result;
		}

		// Token: 0x0600C909 RID: 51465 RVA: 0x001CB5D0 File Offset: 0x001C97D0
		public static SetEntityClientVisible Create([Nullable(2)] SetEntityClientVisible instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetEntityClientVisible
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C90A RID: 51466 RVA: 0x001CB5E3 File Offset: 0x001C97E3
		public static SetEntityClientVisible CreateFromSetValue([Nullable(2)] SetEntityClientVisible_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetEntityClientVisible
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C90B RID: 51467 RVA: 0x001CB5F6 File Offset: 0x001C97F6
		public SetEntityClientVisible_SetValue ToSetValue()
		{
			return new SetEntityClientVisible_SetValue
			{
				EntityIds = this.EntityIds,
				Visible = this.Visible
			};
		}

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x0600C90C RID: 51468 RVA: 0x001CB615 File Offset: 0x001C9815
		// (set) Token: 0x0600C90D RID: 51469 RVA: 0x001CB63C File Offset: 0x001C983C
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				SetEntityClientVisible_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x0600C90E RID: 51470 RVA: 0x001CB64A File Offset: 0x001C984A
		// (set) Token: 0x0600C90F RID: 51471 RVA: 0x001CB675 File Offset: 0x001C9875
		public virtual bool Visible
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Visible;
				}
				return this.PocoInterface != null && this.PocoInterface.Visible;
			}
			set
			{
				this.GetOrCreatePoco().Visible = value;
			}
		}

		// Token: 0x0400773B RID: 30523
		[Nullable(2)]
		protected new SetEntityClientVisible FbInstance;

		// Token: 0x0400773C RID: 30524
		[Nullable(2)]
		protected SetEntityClientVisible_SetValue PocoInterface;
	}
}
