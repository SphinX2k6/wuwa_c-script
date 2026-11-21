using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E1D RID: 3613
	public class ISceneTextGuideUiContent
	{
		// Token: 0x060051DD RID: 20957 RVA: 0x000CA81F File Offset: 0x000C8A1F
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

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x060051DE RID: 20958 RVA: 0x000CA83E File Offset: 0x000C8A3E
		public virtual string TidText
		{
			get
			{
				return this.Instance.TidText;
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x060051DF RID: 20959 RVA: 0x000CA84C File Offset: 0x000C8A4C
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

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x060051E0 RID: 20960 RVA: 0x000CA8B8 File Offset: 0x000C8AB8
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

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x060051E1 RID: 20961 RVA: 0x000CA91C File Offset: 0x000C8B1C
		[Nullable(2)]
		public virtual string EdTidText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04002EAA RID: 11946
		private ISceneTextGuideUiContent Instance;

		// Token: 0x04002EAB RID: 11947
		private List<ISceneTextGuideUiActionMappingIcon> _ActionMappingIconListCache;

		// Token: 0x04002EAC RID: 11948
		private bool _ActionMappingIconListInited;

		// Token: 0x04002EAD RID: 11949
		private List<string> _MobileIconListCache;

		// Token: 0x04002EAE RID: 11950
		private bool _MobileIconListInited;
	}
}
