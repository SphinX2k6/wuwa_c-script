using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295D RID: 10589
	[NullableContext(2)]
	[Nullable(0)]
	public class ICustomShowUi
	{
		// Token: 0x0600EB0A RID: 60170 RVA: 0x0022A652 File Offset: 0x00228852
		[NullableContext(0)]
		public static ICustomShowUi Create(ICustomShowUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomShowUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044FE RID: 17662
		// (get) Token: 0x0600EB0B RID: 60171 RVA: 0x0022A671 File Offset: 0x00228871
		public virtual ICustomScreenTextSetting TextSetting
		{
			get
			{
				if (this._TextSettingInited)
				{
					return this._TextSettingCache;
				}
				this._TextSettingInited = true;
				this._TextSettingCache = ICustomScreenTextSetting.Create(this.Instance.TextSetting);
				return this._TextSettingCache;
			}
		}

		// Token: 0x170044FF RID: 17663
		// (get) Token: 0x0600EB0C RID: 60172 RVA: 0x0022A6A8 File Offset: 0x002288A8
		public virtual bool? IsHideCircle
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsHideCircle);
			}
		}

		// Token: 0x04008179 RID: 33145
		private ICustomShowUi Instance;

		// Token: 0x0400817A RID: 33146
		private ICustomScreenTextSetting _TextSettingCache;

		// Token: 0x0400817B RID: 33147
		private bool _TextSettingInited;
	}
}
