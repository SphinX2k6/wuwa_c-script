using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200269A RID: 9882
	[NullableContext(2)]
	[Nullable(0)]
	public class ICustomShowUi
	{
		// Token: 0x0600DD33 RID: 56627 RVA: 0x0020DEB2 File Offset: 0x0020C0B2
		[NullableContext(1)]
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

		// Token: 0x170041C1 RID: 16833
		// (get) Token: 0x0600DD34 RID: 56628 RVA: 0x0020DED1 File Offset: 0x0020C0D1
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

		// Token: 0x170041C2 RID: 16834
		// (get) Token: 0x0600DD35 RID: 56629 RVA: 0x0020DF08 File Offset: 0x0020C108
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

		// Token: 0x04007ADC RID: 31452
		private ICustomShowUi Instance;

		// Token: 0x04007ADD RID: 31453
		private ICustomScreenTextSetting _TextSettingCache;

		// Token: 0x04007ADE RID: 31454
		private bool _TextSettingInited;
	}
}
