using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ADF RID: 6879
	[NullableContext(2)]
	[Nullable(0)]
	public class ICustomScreenTextSetting
	{
		// Token: 0x0600921D RID: 37405 RVA: 0x00156804 File Offset: 0x00154A04
		[NullableContext(0)]
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

		// Token: 0x0600921E RID: 37406 RVA: 0x0015683C File Offset: 0x00154A3C
		[NullableContext(0)]
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

		// Token: 0x0600921F RID: 37407 RVA: 0x0015684F File Offset: 0x00154A4F
		[NullableContext(0)]
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

		// Token: 0x06009220 RID: 37408 RVA: 0x00156862 File Offset: 0x00154A62
		[NullableContext(0)]
		public ICustomScreenTextSetting_SetValue ToSetValue()
		{
			return new ICustomScreenTextSetting_SetValue
			{
				IsShowTextInfo = this.IsShowTextInfo,
				TidTextContent = this.TidTextContent,
				EdTidTextContent = this.EdTidTextContent
			};
		}

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x06009221 RID: 37409 RVA: 0x00156890 File Offset: 0x00154A90
		// (set) Token: 0x06009222 RID: 37410 RVA: 0x001568CA File Offset: 0x00154ACA
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

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x06009223 RID: 37411 RVA: 0x001568D8 File Offset: 0x00154AD8
		// (set) Token: 0x06009224 RID: 37412 RVA: 0x001568FF File Offset: 0x00154AFF
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

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x06009225 RID: 37413 RVA: 0x0015690D File Offset: 0x00154B0D
		// (set) Token: 0x06009226 RID: 37414 RVA: 0x00156924 File Offset: 0x00154B24
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

		// Token: 0x04005B0F RID: 23311
		protected ICustomScreenTextSetting FbInstance;

		// Token: 0x04005B10 RID: 23312
		protected ICustomScreenTextSetting_SetValue PocoInterface;
	}
}
