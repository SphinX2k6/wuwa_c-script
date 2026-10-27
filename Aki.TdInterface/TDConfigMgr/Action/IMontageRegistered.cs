using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C0A RID: 7178
	[NullableContext(1)]
	[Nullable(0)]
	public class IMontageRegistered : IMontageConfig
	{
		// Token: 0x060099D9 RID: 39385 RVA: 0x00162054 File Offset: 0x00160254
		private IMontageRegistered_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMontageRegistered 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMontageRegistered_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMontageRegistered_SetValue());
			}
			return result;
		}

		// Token: 0x060099DA RID: 39386 RVA: 0x0016208C File Offset: 0x0016028C
		public static IMontageRegistered Create([Nullable(2)] IMontageRegistered instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageRegistered
			{
				FbInstance = instance
			};
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x0016209F File Offset: 0x0016029F
		public static IMontageRegistered CreateFromSetValue([Nullable(2)] IMontageRegistered_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMontageRegistered
			{
				PocoInterface = value
			};
		}

		// Token: 0x060099DC RID: 39388 RVA: 0x001620B2 File Offset: 0x001602B2
		public new IMontageRegistered_SetValue ToSetValue()
		{
			return new IMontageRegistered_SetValue
			{
				Type = this.Type,
				MontageId = this.MontageId
			};
		}

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x060099DD RID: 39389 RVA: 0x001620D1 File Offset: 0x001602D1
		// (set) Token: 0x060099DE RID: 39390 RVA: 0x001620FC File Offset: 0x001602FC
		public override EMontageConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMontageConfigType.Asset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x060099DF RID: 39391 RVA: 0x0016210C File Offset: 0x0016030C
		// (set) Token: 0x060099E0 RID: 39392 RVA: 0x0016216D File Offset: 0x0016036D
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._MontageIdCache = IMontageId.Create(this.FbInstance.MontageId);
				}
				else
				{
					IMontageRegistered_SetValue pocoInterface = this.PocoInterface;
					this._MontageIdCache = ((pocoInterface != null) ? pocoInterface.MontageId : null);
				}
				return this._MontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
				this._MontageIdInited = false;
			}
		}

		// Token: 0x04005DA3 RID: 23971
		[Nullable(2)]
		protected new IMontageRegistered FbInstance;

		// Token: 0x04005DA4 RID: 23972
		[Nullable(2)]
		protected new IMontageRegistered_SetValue PocoInterface;

		// Token: 0x04005DA5 RID: 23973
		private IMontageId _MontageIdCache;

		// Token: 0x04005DA6 RID: 23974
		private bool _MontageIdInited;
	}
}
