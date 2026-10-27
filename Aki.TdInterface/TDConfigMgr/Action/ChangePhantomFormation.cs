using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014E2 RID: 5346
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangePhantomFormation : ActionParams
	{
		// Token: 0x060079AC RID: 31148 RVA: 0x001230EC File Offset: 0x001212EC
		[NullableContext(1)]
		private ChangePhantomFormation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangePhantomFormation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangePhantomFormation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangePhantomFormation_SetValue());
			}
			return result;
		}

		// Token: 0x060079AD RID: 31149 RVA: 0x00123124 File Offset: 0x00121324
		[NullableContext(1)]
		public static ChangePhantomFormation Create([Nullable(2)] ChangePhantomFormation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangePhantomFormation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060079AE RID: 31150 RVA: 0x00123137 File Offset: 0x00121337
		[NullableContext(1)]
		public static ChangePhantomFormation CreateFromSetValue([Nullable(2)] ChangePhantomFormation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangePhantomFormation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060079AF RID: 31151 RVA: 0x0012314A File Offset: 0x0012134A
		[NullableContext(1)]
		public ChangePhantomFormation_SetValue ToSetValue()
		{
			return new ChangePhantomFormation_SetValue
			{
				FormationId = this.FormationId,
				RetainRole = this.RetainRole,
				TeleportEntityId = this.TeleportEntityId,
				AppendBuffIds = this.AppendBuffIds
			};
		}

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x060079B0 RID: 31152 RVA: 0x00123181 File Offset: 0x00121381
		// (set) Token: 0x060079B1 RID: 31153 RVA: 0x001231AC File Offset: 0x001213AC
		public virtual int FormationId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FormationId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FormationId;
			}
			set
			{
				this.GetOrCreatePoco().FormationId = value;
			}
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x060079B2 RID: 31154 RVA: 0x001231BC File Offset: 0x001213BC
		// (set) Token: 0x060079B3 RID: 31155 RVA: 0x001231F6 File Offset: 0x001213F6
		public virtual bool? RetainRole
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RetainRole;
				}
				ChangePhantomFormation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RetainRole;
			}
			set
			{
				this.GetOrCreatePoco().RetainRole = value;
			}
		}

		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x060079B4 RID: 31156 RVA: 0x00123204 File Offset: 0x00121404
		// (set) Token: 0x060079B5 RID: 31157 RVA: 0x0012323E File Offset: 0x0012143E
		public virtual int? TeleportEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeleportEntityId;
				}
				ChangePhantomFormation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TeleportEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TeleportEntityId = value;
			}
		}

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x060079B6 RID: 31158 RVA: 0x0012324C File Offset: 0x0012144C
		// (set) Token: 0x060079B7 RID: 31159 RVA: 0x00123273 File Offset: 0x00121473
		public virtual List<long> AppendBuffIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AppendBuffIds;
				}
				ChangePhantomFormation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AppendBuffIds;
			}
			set
			{
				this.GetOrCreatePoco().AppendBuffIds = value;
			}
		}

		// Token: 0x04004694 RID: 18068
		protected new ChangePhantomFormation FbInstance;

		// Token: 0x04004695 RID: 18069
		protected ChangePhantomFormation_SetValue PocoInterface;
	}
}
