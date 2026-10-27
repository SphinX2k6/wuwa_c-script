using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000556 RID: 1366
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcAwakeShow
	{
		// Token: 0x06001BF4 RID: 7156 RVA: 0x00050608 File Offset: 0x0004E808
		[NullableContext(1)]
		private INpcAwakeShow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcAwakeShow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcAwakeShow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcAwakeShow_SetValue());
			}
			return result;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00050640 File Offset: 0x0004E840
		[NullableContext(1)]
		public static INpcAwakeShow Create([Nullable(2)] INpcAwakeShow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcAwakeShow
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00050653 File Offset: 0x0004E853
		[NullableContext(1)]
		public static INpcAwakeShow CreateFromSetValue([Nullable(2)] INpcAwakeShow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcAwakeShow
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00050666 File Offset: 0x0004E866
		[NullableContext(1)]
		public INpcAwakeShow_SetValue ToSetValue()
		{
			return new INpcAwakeShow_SetValue
			{
				RegisteredMontageId = this.RegisteredMontageId,
				MaterialDa = this.MaterialDa
			};
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x00050688 File Offset: 0x0004E888
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x000506E9 File Offset: 0x0004E8E9
		public virtual IMontageId RegisteredMontageId
		{
			get
			{
				if (this._RegisteredMontageIdInited)
				{
					return this._RegisteredMontageIdCache;
				}
				this._RegisteredMontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._RegisteredMontageIdCache = IMontageId.Create(this.FbInstance.RegisteredMontageId);
				}
				else
				{
					INpcAwakeShow_SetValue pocoInterface = this.PocoInterface;
					this._RegisteredMontageIdCache = ((pocoInterface != null) ? pocoInterface.RegisteredMontageId : null);
				}
				return this._RegisteredMontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().RegisteredMontageId = value;
				this._RegisteredMontageIdInited = false;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x000506FE File Offset: 0x0004E8FE
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x00050725 File Offset: 0x0004E925
		public virtual string MaterialDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaterialDa;
				}
				INpcAwakeShow_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaterialDa;
			}
			set
			{
				this.GetOrCreatePoco().MaterialDa = value;
			}
		}

		// Token: 0x04001408 RID: 5128
		protected INpcAwakeShow FbInstance;

		// Token: 0x04001409 RID: 5129
		protected INpcAwakeShow_SetValue PocoInterface;

		// Token: 0x0400140A RID: 5130
		[Nullable(1)]
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x0400140B RID: 5131
		private bool _RegisteredMontageIdInited;
	}
}
