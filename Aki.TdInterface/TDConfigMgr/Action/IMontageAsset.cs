using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BFE RID: 7166
	[NullableContext(1)]
	[Nullable(0)]
	public class IMontageAsset : IMontageConfig
	{
		// Token: 0x06009975 RID: 39285 RVA: 0x001611CC File Offset: 0x0015F3CC
		private IMontageAsset_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMontageAsset 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMontageAsset_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMontageAsset_SetValue());
			}
			return result;
		}

		// Token: 0x06009976 RID: 39286 RVA: 0x00161204 File Offset: 0x0015F404
		public static IMontageAsset Create([Nullable(2)] IMontageAsset instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageAsset
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009977 RID: 39287 RVA: 0x00161217 File Offset: 0x0015F417
		public static IMontageAsset CreateFromSetValue([Nullable(2)] IMontageAsset_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMontageAsset
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009978 RID: 39288 RVA: 0x0016122A File Offset: 0x0015F42A
		public new IMontageAsset_SetValue ToSetValue()
		{
			return new IMontageAsset_SetValue
			{
				Type = this.Type,
				Asset = this.Asset
			};
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x06009979 RID: 39289 RVA: 0x00161249 File Offset: 0x0015F449
		// (set) Token: 0x0600997A RID: 39290 RVA: 0x00161274 File Offset: 0x0015F474
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

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x0600997B RID: 39291 RVA: 0x00161282 File Offset: 0x0015F482
		// (set) Token: 0x0600997C RID: 39292 RVA: 0x001612AD File Offset: 0x0015F4AD
		public virtual string Asset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Asset;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Asset;
			}
			set
			{
				this.GetOrCreatePoco().Asset = value;
			}
		}

		// Token: 0x04005D6B RID: 23915
		[Nullable(2)]
		protected new IMontageAsset FbInstance;

		// Token: 0x04005D6C RID: 23916
		[Nullable(2)]
		protected new IMontageAsset_SetValue PocoInterface;
	}
}
