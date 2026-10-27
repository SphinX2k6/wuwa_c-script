using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D23 RID: 3363
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneTextGuideUiContent
	{
		// Token: 0x06004CC1 RID: 19649 RVA: 0x000BF0DB File Offset: 0x000BD2DB
		public static ISceneTextGuideUiContent Create(ISceneTextGuideUiContent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextGuideUiContent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06004CC2 RID: 19650 RVA: 0x000BF0FA File Offset: 0x000BD2FA
		public virtual string TidText
		{
			get
			{
				return this.Instance.TidText;
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06004CC3 RID: 19651 RVA: 0x000BF108 File Offset: 0x000BD308
		public virtual List<ISceneTextGuideUiActionMappingIcon> ActionMappingIconList
		{
			get
			{
				if (this._ActionMappingIconListInited)
				{
					return this._ActionMappingIconListCache;
				}
				this._ActionMappingIconListInited = true;
				int actionMappingIconListLength = this.Instance.ActionMappingIconListLength;
				this._ActionMappingIconListCache = new List<ISceneTextGuideUiActionMappingIcon>(actionMappingIconListLength);
				for (int i = 0; i < actionMappingIconListLength; i++)
				{
					this._ActionMappingIconListCache.Add(ISceneTextGuideUiActionMappingIcon.Create(this.Instance.ActionMappingIconList(i)));
				}
				return this._ActionMappingIconListCache;
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06004CC4 RID: 19652 RVA: 0x000BF174 File Offset: 0x000BD374
		public virtual List<string> MobileIconList
		{
			get
			{
				if (this._MobileIconListInited)
				{
					return this._MobileIconListCache;
				}
				this._MobileIconListInited = true;
				int mobileIconListLength = this.Instance.MobileIconListLength;
				this._MobileIconListCache = new List<string>(mobileIconListLength);
				for (int i = 0; i < mobileIconListLength; i++)
				{
					this._MobileIconListCache.Add(this.Instance.MobileIconList(i));
				}
				return this._MobileIconListCache;
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06004CC5 RID: 19653 RVA: 0x000BF1D8 File Offset: 0x000BD3D8
		public virtual string EdTidText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002BEA RID: 11242
		private ISceneTextGuideUiContent Instance;

		// Token: 0x04002BEB RID: 11243
		private List<ISceneTextGuideUiActionMappingIcon> _ActionMappingIconListCache;

		// Token: 0x04002BEC RID: 11244
		private bool _ActionMappingIconListInited;

		// Token: 0x04002BED RID: 11245
		private List<string> _MobileIconListCache;

		// Token: 0x04002BEE RID: 11246
		private bool _MobileIconListInited;
	}
}
