using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001638 RID: 5688
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableEntityLookAt : ActionParams
	{
		// Token: 0x06007C33 RID: 31795 RVA: 0x0012AC74 File Offset: 0x00128E74
		private EnableEntityLookAt_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableEntityLookAt 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableEntityLookAt_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableEntityLookAt_SetValue());
			}
			return result;
		}

		// Token: 0x06007C34 RID: 31796 RVA: 0x0012ACAC File Offset: 0x00128EAC
		public static EnableEntityLookAt Create([Nullable(2)] EnableEntityLookAt instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableEntityLookAt
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007C35 RID: 31797 RVA: 0x0012ACBF File Offset: 0x00128EBF
		public static EnableEntityLookAt CreateFromSetValue([Nullable(2)] EnableEntityLookAt_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableEntityLookAt
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007C36 RID: 31798 RVA: 0x0012ACD2 File Offset: 0x00128ED2
		public EnableEntityLookAt_SetValue ToSetValue()
		{
			return new EnableEntityLookAt_SetValue
			{
				Key = this.Key,
				DefaultLookAtType = this.DefaultLookAtType,
				OverrideLookAtType = this.OverrideLookAtType,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x06007C37 RID: 31799 RVA: 0x0012AD09 File Offset: 0x00128F09
		// (set) Token: 0x06007C38 RID: 31800 RVA: 0x0012AD34 File Offset: 0x00128F34
		public virtual string Key
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Key;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Key;
			}
			set
			{
				this.GetOrCreatePoco().Key = value;
			}
		}

		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x06007C39 RID: 31801 RVA: 0x0012AD42 File Offset: 0x00128F42
		// (set) Token: 0x06007C3A RID: 31802 RVA: 0x0012AD69 File Offset: 0x00128F69
		public virtual IDefaultLookAtType DefaultLookAtType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultLookAtType;
				}
				EnableEntityLookAt_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DefaultLookAtType;
			}
			set
			{
				this.GetOrCreatePoco().DefaultLookAtType = value;
			}
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x06007C3B RID: 31803 RVA: 0x0012AD78 File Offset: 0x00128F78
		// (set) Token: 0x06007C3C RID: 31804 RVA: 0x0012ADD9 File Offset: 0x00128FD9
		[Nullable(2)]
		public virtual ICheckFlowLookAt OverrideLookAtType
		{
			[NullableContext(2)]
			get
			{
				if (this._OverrideLookAtTypeInited)
				{
					return this._OverrideLookAtTypeCache;
				}
				this._OverrideLookAtTypeInited = true;
				if (this.FbInstance != null)
				{
					this._OverrideLookAtTypeCache = ICheckFlowLookAt.Create(this.FbInstance.OverrideLookAtType);
				}
				else
				{
					EnableEntityLookAt_SetValue pocoInterface = this.PocoInterface;
					this._OverrideLookAtTypeCache = ((pocoInterface != null) ? pocoInterface.OverrideLookAtType : null);
				}
				return this._OverrideLookAtTypeCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().OverrideLookAtType = value;
				this._OverrideLookAtTypeInited = false;
			}
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x06007C3D RID: 31805 RVA: 0x0012ADEE File Offset: 0x00128FEE
		// (set) Token: 0x06007C3E RID: 31806 RVA: 0x0012AE15 File Offset: 0x00129015
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				EnableEntityLookAt_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04004C50 RID: 19536
		[Nullable(2)]
		protected new EnableEntityLookAt FbInstance;

		// Token: 0x04004C51 RID: 19537
		[Nullable(2)]
		protected EnableEntityLookAt_SetValue PocoInterface;

		// Token: 0x04004C52 RID: 19538
		private ICheckFlowLookAt _OverrideLookAtTypeCache;

		// Token: 0x04004C53 RID: 19539
		private bool _OverrideLookAtTypeInited;
	}
}
