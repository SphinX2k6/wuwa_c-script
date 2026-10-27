using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B3B RID: 6971
	[NullableContext(2)]
	[Nullable(0)]
	public class IInstrumentKeyAttribute
	{
		// Token: 0x0600952C RID: 38188 RVA: 0x00158EE4 File Offset: 0x001570E4
		[NullableContext(1)]
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

		// Token: 0x0600952D RID: 38189 RVA: 0x00158F1C File Offset: 0x0015711C
		[NullableContext(1)]
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

		// Token: 0x0600952E RID: 38190 RVA: 0x00158F2F File Offset: 0x0015712F
		[NullableContext(1)]
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

		// Token: 0x0600952F RID: 38191 RVA: 0x00158F42 File Offset: 0x00157142
		[NullableContext(1)]
		public IInstrumentKeyAttribute_SetValue ToSetValue()
		{
			return new IInstrumentKeyAttribute_SetValue
			{
				FundamentalToneAssetPath = this.FundamentalToneAssetPath,
				OverToneAssetPath = this.OverToneAssetPath,
				TextureAssetPath = this.TextureAssetPath
			};
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x06009530 RID: 38192 RVA: 0x00158F6D File Offset: 0x0015716D
		// (set) Token: 0x06009531 RID: 38193 RVA: 0x00158F94 File Offset: 0x00157194
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

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x06009532 RID: 38194 RVA: 0x00158FA2 File Offset: 0x001571A2
		// (set) Token: 0x06009533 RID: 38195 RVA: 0x00158FC9 File Offset: 0x001571C9
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

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x06009534 RID: 38196 RVA: 0x00158FD7 File Offset: 0x001571D7
		// (set) Token: 0x06009535 RID: 38197 RVA: 0x00158FFE File Offset: 0x001571FE
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

		// Token: 0x04005B4E RID: 23374
		protected IInstrumentKeyAttribute FbInstance;

		// Token: 0x04005B4F RID: 23375
		protected IInstrumentKeyAttribute_SetValue PocoInterface;
	}
}
