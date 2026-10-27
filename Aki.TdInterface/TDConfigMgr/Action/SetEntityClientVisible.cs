using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021AD RID: 8621
	[NullableContext(1)]
	[Nullable(0)]
	public class SetEntityClientVisible : ActionParams
	{
		// Token: 0x0600BD4E RID: 48462 RVA: 0x001B3F60 File Offset: 0x001B2160
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

		// Token: 0x0600BD4F RID: 48463 RVA: 0x001B3F98 File Offset: 0x001B2198
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

		// Token: 0x0600BD50 RID: 48464 RVA: 0x001B3FAB File Offset: 0x001B21AB
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

		// Token: 0x0600BD51 RID: 48465 RVA: 0x001B3FBE File Offset: 0x001B21BE
		public SetEntityClientVisible_SetValue ToSetValue()
		{
			return new SetEntityClientVisible_SetValue
			{
				EntityIds = this.EntityIds,
				Visible = this.Visible
			};
		}

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x0600BD52 RID: 48466 RVA: 0x001B3FDD File Offset: 0x001B21DD
		// (set) Token: 0x0600BD53 RID: 48467 RVA: 0x001B4004 File Offset: 0x001B2204
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

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x0600BD54 RID: 48468 RVA: 0x001B4012 File Offset: 0x001B2212
		// (set) Token: 0x0600BD55 RID: 48469 RVA: 0x001B403D File Offset: 0x001B223D
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

		// Token: 0x040070F3 RID: 28915
		[Nullable(2)]
		protected new SetEntityClientVisible FbInstance;

		// Token: 0x040070F4 RID: 28916
		[Nullable(2)]
		protected SetEntityClientVisible_SetValue PocoInterface;
	}
}
