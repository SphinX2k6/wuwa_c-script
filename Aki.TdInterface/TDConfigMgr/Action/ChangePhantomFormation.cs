using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200163B RID: 5691
	public class ChangePhantomFormation : ActionParams
	{
		// Token: 0x06008079 RID: 32889 RVA: 0x00131D38 File Offset: 0x0012FF38
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

		// Token: 0x0600807A RID: 32890 RVA: 0x00131D70 File Offset: 0x0012FF70
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

		// Token: 0x0600807B RID: 32891 RVA: 0x00131D83 File Offset: 0x0012FF83
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

		// Token: 0x0600807C RID: 32892 RVA: 0x00131D96 File Offset: 0x0012FF96
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

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x0600807D RID: 32893 RVA: 0x00131DCD File Offset: 0x0012FFCD
		// (set) Token: 0x0600807E RID: 32894 RVA: 0x00131DF8 File Offset: 0x0012FFF8
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

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x0600807F RID: 32895 RVA: 0x00131E08 File Offset: 0x00130008
		// (set) Token: 0x06008080 RID: 32896 RVA: 0x00131E42 File Offset: 0x00130042
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

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x06008081 RID: 32897 RVA: 0x00131E50 File Offset: 0x00130050
		// (set) Token: 0x06008082 RID: 32898 RVA: 0x00131E8A File Offset: 0x0013008A
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

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x06008083 RID: 32899 RVA: 0x00131E98 File Offset: 0x00130098
		// (set) Token: 0x06008084 RID: 32900 RVA: 0x00131EBF File Offset: 0x001300BF
		[Nullable(2)]
		public virtual List<long> AppendBuffIds
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AppendBuffIds = value;
			}
		}

		// Token: 0x04004A2F RID: 18991
		[Nullable(2)]
		protected new ChangePhantomFormation FbInstance;

		// Token: 0x04004A30 RID: 18992
		[Nullable(2)]
		protected ChangePhantomFormation_SetValue PocoInterface;
	}
}
