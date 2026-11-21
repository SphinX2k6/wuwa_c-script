using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002336 RID: 9014
	public class ModifyEntityDecoration : ActionParams
	{
		// Token: 0x0600C438 RID: 50232 RVA: 0x001C23FC File Offset: 0x001C05FC
		private ModifyEntityDecoration_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ModifyEntityDecoration 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ModifyEntityDecoration_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ModifyEntityDecoration_SetValue());
			}
			return result;
		}

		// Token: 0x0600C439 RID: 50233 RVA: 0x001C2434 File Offset: 0x001C0634
		public static ModifyEntityDecoration Create([Nullable(2)] ModifyEntityDecoration instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ModifyEntityDecoration
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C43A RID: 50234 RVA: 0x001C2447 File Offset: 0x001C0647
		public static ModifyEntityDecoration CreateFromSetValue([Nullable(2)] ModifyEntityDecoration_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ModifyEntityDecoration
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C43B RID: 50235 RVA: 0x001C245A File Offset: 0x001C065A
		public ModifyEntityDecoration_SetValue ToSetValue()
		{
			return new ModifyEntityDecoration_SetValue
			{
				EntityId = this.EntityId,
				Config = this.Config
			};
		}

		// Token: 0x17003B5B RID: 15195
		// (get) Token: 0x0600C43C RID: 50236 RVA: 0x001C2479 File Offset: 0x001C0679
		// (set) Token: 0x0600C43D RID: 50237 RVA: 0x001C24A4 File Offset: 0x001C06A4
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x0600C43E RID: 50238 RVA: 0x001C24B2 File Offset: 0x001C06B2
		// (set) Token: 0x0600C43F RID: 50239 RVA: 0x001C24D9 File Offset: 0x001C06D9
		public virtual IEntityDecorationConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				ModifyEntityDecoration_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x040074D8 RID: 29912
		[Nullable(2)]
		protected new ModifyEntityDecoration FbInstance;

		// Token: 0x040074D9 RID: 29913
		[Nullable(2)]
		protected ModifyEntityDecoration_SetValue PocoInterface;
	}
}
