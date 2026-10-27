using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021AF RID: 8623
	[NullableContext(1)]
	[Nullable(0)]
	public class SetEntityClientVisibleSave : ActionParams
	{
		// Token: 0x0600BD58 RID: 48472 RVA: 0x001B405C File Offset: 0x001B225C
		private SetEntityClientVisibleSave_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetEntityClientVisibleSave 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetEntityClientVisibleSave_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetEntityClientVisibleSave_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD59 RID: 48473 RVA: 0x001B4094 File Offset: 0x001B2294
		public static SetEntityClientVisibleSave Create([Nullable(2)] SetEntityClientVisibleSave instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetEntityClientVisibleSave
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD5A RID: 48474 RVA: 0x001B40A7 File Offset: 0x001B22A7
		public static SetEntityClientVisibleSave CreateFromSetValue([Nullable(2)] SetEntityClientVisibleSave_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetEntityClientVisibleSave
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD5B RID: 48475 RVA: 0x001B40BA File Offset: 0x001B22BA
		public SetEntityClientVisibleSave_SetValue ToSetValue()
		{
			return new SetEntityClientVisibleSave_SetValue
			{
				EntityIds = this.EntityIds,
				Visible = this.Visible
			};
		}

		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x0600BD5C RID: 48476 RVA: 0x001B40D9 File Offset: 0x001B22D9
		// (set) Token: 0x0600BD5D RID: 48477 RVA: 0x001B4100 File Offset: 0x001B2300
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				SetEntityClientVisibleSave_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x0600BD5E RID: 48478 RVA: 0x001B410E File Offset: 0x001B230E
		// (set) Token: 0x0600BD5F RID: 48479 RVA: 0x001B4139 File Offset: 0x001B2339
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

		// Token: 0x040070F7 RID: 28919
		[Nullable(2)]
		protected new SetEntityClientVisibleSave FbInstance;

		// Token: 0x040070F8 RID: 28920
		[Nullable(2)]
		protected SetEntityClientVisibleSave_SetValue PocoInterface;
	}
}
