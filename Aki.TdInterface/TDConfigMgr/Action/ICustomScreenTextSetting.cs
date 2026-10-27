using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001954 RID: 6484
	[NullableContext(2)]
	[Nullable(0)]
	public class ICustomScreenTextSetting
	{
		// Token: 0x06008AE9 RID: 35561 RVA: 0x00146E08 File Offset: 0x00145008
		[NullableContext(1)]
		private ICustomScreenTextSetting_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomScreenTextSetting 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomScreenTextSetting_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomScreenTextSetting_SetValue());
			}
			return result;
		}

		// Token: 0x06008AEA RID: 35562 RVA: 0x00146E40 File Offset: 0x00145040
		[NullableContext(1)]
		public static ICustomScreenTextSetting Create([Nullable(2)] ICustomScreenTextSetting instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenTextSetting
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008AEB RID: 35563 RVA: 0x00146E53 File Offset: 0x00145053
		[NullableContext(1)]
		public static ICustomScreenTextSetting CreateFromSetValue([Nullable(2)] ICustomScreenTextSetting_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomScreenTextSetting
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008AEC RID: 35564 RVA: 0x00146E66 File Offset: 0x00145066
		[NullableContext(1)]
		public ICustomScreenTextSetting_SetValue ToSetValue()
		{
			return new ICustomScreenTextSetting_SetValue
			{
				IsShowTextInfo = this.IsShowTextInfo,
				TidTextContent = this.TidTextContent,
				EdTidTextContent = this.EdTidTextContent
			};
		}

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x06008AED RID: 35565 RVA: 0x00146E94 File Offset: 0x00145094
		// (set) Token: 0x06008AEE RID: 35566 RVA: 0x00146ECE File Offset: 0x001450CE
		public virtual bool? IsShowTextInfo
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsShowTextInfo;
				}
				ICustomScreenTextSetting_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsShowTextInfo;
			}
			set
			{
				this.GetOrCreatePoco().IsShowTextInfo = value;
			}
		}

		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x06008AEF RID: 35567 RVA: 0x00146EDC File Offset: 0x001450DC
		// (set) Token: 0x06008AF0 RID: 35568 RVA: 0x00146F03 File Offset: 0x00145103
		public virtual string TidTextContent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTextContent;
				}
				ICustomScreenTextSetting_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidTextContent;
			}
			set
			{
				this.GetOrCreatePoco().TidTextContent = value;
			}
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x06008AF1 RID: 35569 RVA: 0x00146F11 File Offset: 0x00145111
		// (set) Token: 0x06008AF2 RID: 35570 RVA: 0x00146F28 File Offset: 0x00145128
		public virtual string EdTidTextContent
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTextContent;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidTextContent = value;
			}
		}

		// Token: 0x040056BC RID: 22204
		protected ICustomScreenTextSetting FbInstance;

		// Token: 0x040056BD RID: 22205
		protected ICustomScreenTextSetting_SetValue PocoInterface;
	}
}
