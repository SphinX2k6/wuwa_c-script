using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CEA RID: 7402
	[NullableContext(2)]
	[Nullable(0)]
	public class IInstrumentKeyAttribute
	{
		// Token: 0x06009D16 RID: 40214 RVA: 0x00169BC0 File Offset: 0x00167DC0
		[NullableContext(0)]
		private IInstrumentKeyAttribute_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInstrumentKeyAttribute 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInstrumentKeyAttribute_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInstrumentKeyAttribute_SetValue());
			}
			return result;
		}

		// Token: 0x06009D17 RID: 40215 RVA: 0x00169BF8 File Offset: 0x00167DF8
		[NullableContext(0)]
		public static IInstrumentKeyAttribute Create([Nullable(2)] IInstrumentKeyAttribute instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentKeyAttribute
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D18 RID: 40216 RVA: 0x00169C0B File Offset: 0x00167E0B
		[NullableContext(0)]
		public static IInstrumentKeyAttribute CreateFromSetValue([Nullable(2)] IInstrumentKeyAttribute_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInstrumentKeyAttribute
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D19 RID: 40217 RVA: 0x00169C1E File Offset: 0x00167E1E
		[NullableContext(0)]
		public IInstrumentKeyAttribute_SetValue ToSetValue()
		{
			return new IInstrumentKeyAttribute_SetValue
			{
				FundamentalToneAssetPath = this.FundamentalToneAssetPath,
				OverToneAssetPath = this.OverToneAssetPath,
				TextureAssetPath = this.TextureAssetPath
			};
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x06009D1A RID: 40218 RVA: 0x00169C49 File Offset: 0x00167E49
		// (set) Token: 0x06009D1B RID: 40219 RVA: 0x00169C70 File Offset: 0x00167E70
		public virtual string FundamentalToneAssetPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FundamentalToneAssetPath;
				}
				IInstrumentKeyAttribute_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FundamentalToneAssetPath;
			}
			set
			{
				this.GetOrCreatePoco().FundamentalToneAssetPath = value;
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x06009D1C RID: 40220 RVA: 0x00169C7E File Offset: 0x00167E7E
		// (set) Token: 0x06009D1D RID: 40221 RVA: 0x00169CA5 File Offset: 0x00167EA5
		public virtual string OverToneAssetPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OverToneAssetPath;
				}
				IInstrumentKeyAttribute_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OverToneAssetPath;
			}
			set
			{
				this.GetOrCreatePoco().OverToneAssetPath = value;
			}
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x06009D1E RID: 40222 RVA: 0x00169CB3 File Offset: 0x00167EB3
		// (set) Token: 0x06009D1F RID: 40223 RVA: 0x00169CDA File Offset: 0x00167EDA
		public virtual string TextureAssetPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextureAssetPath;
				}
				IInstrumentKeyAttribute_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TextureAssetPath;
			}
			set
			{
				this.GetOrCreatePoco().TextureAssetPath = value;
			}
		}

		// Token: 0x04005FEC RID: 24556
		protected IInstrumentKeyAttribute FbInstance;

		// Token: 0x04005FED RID: 24557
		protected IInstrumentKeyAttribute_SetValue PocoInterface;
	}
}
