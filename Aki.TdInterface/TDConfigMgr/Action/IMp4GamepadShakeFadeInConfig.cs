using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C4C RID: 7244
	[NullableContext(1)]
	[Nullable(0)]
	public class IMp4GamepadShakeFadeInConfig
	{
		// Token: 0x06009B69 RID: 39785 RVA: 0x00165000 File Offset: 0x00163200
		private IMp4GamepadShakeFadeInConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMp4GamepadShakeFadeInConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMp4GamepadShakeFadeInConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMp4GamepadShakeFadeInConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009B6A RID: 39786 RVA: 0x00165038 File Offset: 0x00163238
		public static IMp4GamepadShakeFadeInConfig Create([Nullable(2)] IMp4GamepadShakeFadeInConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4GamepadShakeFadeInConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B6B RID: 39787 RVA: 0x0016504B File Offset: 0x0016324B
		public static IMp4GamepadShakeFadeInConfig CreateFromSetValue([Nullable(2)] IMp4GamepadShakeFadeInConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMp4GamepadShakeFadeInConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B6C RID: 39788 RVA: 0x0016505E File Offset: 0x0016325E
		public IMp4GamepadShakeFadeInConfig_SetValue ToSetValue()
		{
			return new IMp4GamepadShakeFadeInConfig_SetValue
			{
				FadeInTime = this.FadeInTime,
				FadeInCurve = this.FadeInCurve
			};
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x06009B6D RID: 39789 RVA: 0x00165080 File Offset: 0x00163280
		// (set) Token: 0x06009B6E RID: 39790 RVA: 0x001650BA File Offset: 0x001632BA
		public virtual float? FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				IMp4GamepadShakeFadeInConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x06009B6F RID: 39791 RVA: 0x001650C8 File Offset: 0x001632C8
		// (set) Token: 0x06009B70 RID: 39792 RVA: 0x00165102 File Offset: 0x00163302
		public virtual EMp4GamepadShakeCurve? FadeInCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInCurve;
				}
				IMp4GamepadShakeFadeInConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeInCurve;
			}
			set
			{
				this.GetOrCreatePoco().FadeInCurve = value;
			}
		}

		// Token: 0x04005E68 RID: 24168
		[Nullable(2)]
		protected IMp4GamepadShakeFadeInConfig FbInstance;

		// Token: 0x04005E69 RID: 24169
		[Nullable(2)]
		protected IMp4GamepadShakeFadeInConfig_SetValue PocoInterface;
	}
}
