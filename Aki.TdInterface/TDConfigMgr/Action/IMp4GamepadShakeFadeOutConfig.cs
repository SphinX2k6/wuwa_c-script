using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E45 RID: 7749
	public class IMp4GamepadShakeFadeOutConfig
	{
		// Token: 0x0600A4CB RID: 42187 RVA: 0x00178460 File Offset: 0x00176660
		private IMp4GamepadShakeFadeOutConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMp4GamepadShakeFadeOutConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMp4GamepadShakeFadeOutConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMp4GamepadShakeFadeOutConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4CC RID: 42188 RVA: 0x00178498 File Offset: 0x00176698
		public static IMp4GamepadShakeFadeOutConfig Create([Nullable(2)] IMp4GamepadShakeFadeOutConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4GamepadShakeFadeOutConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4CD RID: 42189 RVA: 0x001784AB File Offset: 0x001766AB
		public static IMp4GamepadShakeFadeOutConfig CreateFromSetValue([Nullable(2)] IMp4GamepadShakeFadeOutConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMp4GamepadShakeFadeOutConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4CE RID: 42190 RVA: 0x001784BE File Offset: 0x001766BE
		public IMp4GamepadShakeFadeOutConfig_SetValue ToSetValue()
		{
			return new IMp4GamepadShakeFadeOutConfig_SetValue
			{
				FadeOutTime = this.FadeOutTime,
				FadeOutCurve = this.FadeOutCurve
			};
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600A4CF RID: 42191 RVA: 0x001784E0 File Offset: 0x001766E0
		// (set) Token: 0x0600A4D0 RID: 42192 RVA: 0x0017851A File Offset: 0x0017671A
		public virtual float? FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				IMp4GamepadShakeFadeOutConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600A4D1 RID: 42193 RVA: 0x00178528 File Offset: 0x00176728
		// (set) Token: 0x0600A4D2 RID: 42194 RVA: 0x00178562 File Offset: 0x00176762
		public virtual EMp4GamepadShakeCurve? FadeOutCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutCurve;
				}
				IMp4GamepadShakeFadeOutConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeOutCurve;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutCurve = value;
			}
		}

		// Token: 0x040063A3 RID: 25507
		[Nullable(2)]
		protected IMp4GamepadShakeFadeOutConfig FbInstance;

		// Token: 0x040063A4 RID: 25508
		[Nullable(2)]
		protected IMp4GamepadShakeFadeOutConfig_SetValue PocoInterface;
	}
}
