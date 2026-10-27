using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FE4 RID: 8164
	[NullableContext(1)]
	[Nullable(0)]
	public class ITransitionPopupConfig
	{
		// Token: 0x0600B39A RID: 45978 RVA: 0x001A2148 File Offset: 0x001A0348
		private ITransitionPopupConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITransitionPopupConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITransitionPopupConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITransitionPopupConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B39B RID: 45979 RVA: 0x001A2180 File Offset: 0x001A0380
		public static ITransitionPopupConfig Create([Nullable(2)] ITransitionPopupConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B39C RID: 45980 RVA: 0x001A2193 File Offset: 0x001A0393
		public static ITransitionPopupConfig CreateFromSetValue([Nullable(2)] ITransitionPopupConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITransitionPopupConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B39D RID: 45981 RVA: 0x001A21A6 File Offset: 0x001A03A6
		public ITransitionPopupConfig_SetValue ToSetValue()
		{
			return new ITransitionPopupConfig_SetValue
			{
				Duration = this.Duration,
				PopupStyle = this.PopupStyle
			};
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x0600B39E RID: 45982 RVA: 0x001A21C8 File Offset: 0x001A03C8
		// (set) Token: 0x0600B39F RID: 45983 RVA: 0x001A2202 File Offset: 0x001A0402
		public virtual float? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				ITransitionPopupConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x0600B3A0 RID: 45984 RVA: 0x001A2210 File Offset: 0x001A0410
		// (set) Token: 0x0600B3A1 RID: 45985 RVA: 0x001A2237 File Offset: 0x001A0437
		public virtual ITransitionPopupStyle PopupStyle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PopupStyle;
				}
				ITransitionPopupConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PopupStyle;
			}
			set
			{
				this.GetOrCreatePoco().PopupStyle = value;
			}
		}

		// Token: 0x04006C5A RID: 27738
		[Nullable(2)]
		protected ITransitionPopupConfig FbInstance;

		// Token: 0x04006C5B RID: 27739
		[Nullable(2)]
		protected ITransitionPopupConfig_SetValue PocoInterface;
	}
}
