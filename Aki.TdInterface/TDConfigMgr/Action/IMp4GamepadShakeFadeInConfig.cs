using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E43 RID: 7747
	public class IMp4GamepadShakeFadeInConfig
	{
		// Token: 0x0600A4C1 RID: 42177 RVA: 0x00178340 File Offset: 0x00176540
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

		// Token: 0x0600A4C2 RID: 42178 RVA: 0x00178378 File Offset: 0x00176578
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

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x0017838B File Offset: 0x0017658B
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

		// Token: 0x0600A4C4 RID: 42180 RVA: 0x0017839E File Offset: 0x0017659E
		public IMp4GamepadShakeFadeInConfig_SetValue ToSetValue()
		{
			return new IMp4GamepadShakeFadeInConfig_SetValue
			{
				FadeInTime = this.FadeInTime,
				FadeInCurve = this.FadeInCurve
			};
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600A4C5 RID: 42181 RVA: 0x001783C0 File Offset: 0x001765C0
		// (set) Token: 0x0600A4C6 RID: 42182 RVA: 0x001783FA File Offset: 0x001765FA
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

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600A4C7 RID: 42183 RVA: 0x00178408 File Offset: 0x00176608
		// (set) Token: 0x0600A4C8 RID: 42184 RVA: 0x00178442 File Offset: 0x00176642
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

		// Token: 0x0400639F RID: 25503
		[Nullable(2)]
		protected IMp4GamepadShakeFadeInConfig FbInstance;

		// Token: 0x040063A0 RID: 25504
		[Nullable(2)]
		protected IMp4GamepadShakeFadeInConfig_SetValue PocoInterface;
	}
}
