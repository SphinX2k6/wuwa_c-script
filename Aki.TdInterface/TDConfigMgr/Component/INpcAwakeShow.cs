using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005BD RID: 1469
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcAwakeShow
	{
		// Token: 0x06001DF0 RID: 7664 RVA: 0x000553C4 File Offset: 0x000535C4
		[NullableContext(0)]
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

		// Token: 0x06001DF1 RID: 7665 RVA: 0x000553FC File Offset: 0x000535FC
		[NullableContext(0)]
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

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0005540F File Offset: 0x0005360F
		[NullableContext(0)]
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

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00055422 File Offset: 0x00053622
		[NullableContext(0)]
		public INpcAwakeShow_SetValue ToSetValue()
		{
			return new INpcAwakeShow_SetValue
			{
				RegisteredMontageId = this.RegisteredMontageId,
				MaterialDa = this.MaterialDa
			};
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x00055444 File Offset: 0x00053644
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x000554A5 File Offset: 0x000536A5
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

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x000554BA File Offset: 0x000536BA
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x000554E1 File Offset: 0x000536E1
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

		// Token: 0x04001572 RID: 5490
		protected INpcAwakeShow FbInstance;

		// Token: 0x04001573 RID: 5491
		protected INpcAwakeShow_SetValue PocoInterface;

		// Token: 0x04001574 RID: 5492
		[Nullable(0)]
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x04001575 RID: 5493
		private bool _RegisteredMontageIdInited;
	}
}
