using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200222B RID: 8747
	public class ITransitionPopupConfig
	{
		// Token: 0x0600BEB0 RID: 48816 RVA: 0x001B86B4 File Offset: 0x001B68B4
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

		// Token: 0x0600BEB1 RID: 48817 RVA: 0x001B86EC File Offset: 0x001B68EC
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

		// Token: 0x0600BEB2 RID: 48818 RVA: 0x001B86FF File Offset: 0x001B68FF
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

		// Token: 0x0600BEB3 RID: 48819 RVA: 0x001B8712 File Offset: 0x001B6912
		public ITransitionPopupConfig_SetValue ToSetValue()
		{
			return new ITransitionPopupConfig_SetValue
			{
				Duration = this.Duration,
				PopupStyle = this.PopupStyle
			};
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x0600BEB4 RID: 48820 RVA: 0x001B8734 File Offset: 0x001B6934
		// (set) Token: 0x0600BEB5 RID: 48821 RVA: 0x001B876E File Offset: 0x001B696E
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

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x0600BEB6 RID: 48822 RVA: 0x001B877C File Offset: 0x001B697C
		// (set) Token: 0x0600BEB7 RID: 48823 RVA: 0x001B87A3 File Offset: 0x001B69A3
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

		// Token: 0x0400725C RID: 29276
		[Nullable(2)]
		protected ITransitionPopupConfig FbInstance;

		// Token: 0x0400725D RID: 29277
		[Nullable(2)]
		protected ITransitionPopupConfig_SetValue PocoInterface;
	}
}
