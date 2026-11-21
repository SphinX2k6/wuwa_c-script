using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017A5 RID: 6053
	public class EnableEntityLookAt : ActionParams
	{
		// Token: 0x06008311 RID: 33553 RVA: 0x00139D20 File Offset: 0x00137F20
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

		// Token: 0x06008312 RID: 33554 RVA: 0x00139D58 File Offset: 0x00137F58
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

		// Token: 0x06008313 RID: 33555 RVA: 0x00139D6B File Offset: 0x00137F6B
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

		// Token: 0x06008314 RID: 33556 RVA: 0x00139D7E File Offset: 0x00137F7E
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

		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x06008315 RID: 33557 RVA: 0x00139DB5 File Offset: 0x00137FB5
		// (set) Token: 0x06008316 RID: 33558 RVA: 0x00139DE0 File Offset: 0x00137FE0
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

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x06008317 RID: 33559 RVA: 0x00139DEE File Offset: 0x00137FEE
		// (set) Token: 0x06008318 RID: 33560 RVA: 0x00139E15 File Offset: 0x00138015
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

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x06008319 RID: 33561 RVA: 0x00139E24 File Offset: 0x00138024
		// (set) Token: 0x0600831A RID: 33562 RVA: 0x00139E85 File Offset: 0x00138085
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

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x0600831B RID: 33563 RVA: 0x00139E9A File Offset: 0x0013809A
		// (set) Token: 0x0600831C RID: 33564 RVA: 0x00139EC1 File Offset: 0x001380C1
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

		// Token: 0x04005044 RID: 20548
		[Nullable(2)]
		protected new EnableEntityLookAt FbInstance;

		// Token: 0x04005045 RID: 20549
		[Nullable(2)]
		protected EnableEntityLookAt_SetValue PocoInterface;

		// Token: 0x04005046 RID: 20550
		private ICheckFlowLookAt _OverrideLookAtTypeCache;

		// Token: 0x04005047 RID: 20551
		private bool _OverrideLookAtTypeInited;
	}
}
