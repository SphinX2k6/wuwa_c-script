using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002009 RID: 8201
	public class ISceneUiSubtitleLocalizationConfig
	{
		// Token: 0x0600AE2B RID: 44587 RVA: 0x00188D70 File Offset: 0x00186F70
		private ISceneUiSubtitleLocalizationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitleLocalizationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitleLocalizationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitleLocalizationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE2C RID: 44588 RVA: 0x00188DA8 File Offset: 0x00186FA8
		public static ISceneUiSubtitleLocalizationConfig Create([Nullable(2)] ISceneUiSubtitleLocalizationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleLocalizationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE2D RID: 44589 RVA: 0x00188DBB File Offset: 0x00186FBB
		public static ISceneUiSubtitleLocalizationConfig CreateFromSetValue([Nullable(2)] ISceneUiSubtitleLocalizationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitleLocalizationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE2E RID: 44590 RVA: 0x00188DCE File Offset: 0x00186FCE
		public ISceneUiSubtitleLocalizationConfig_SetValue ToSetValue()
		{
			return new ISceneUiSubtitleLocalizationConfig_SetValue
			{
				OverrideList = this.OverrideList
			};
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x0600AE2F RID: 44591 RVA: 0x00188DE4 File Offset: 0x00186FE4
		// (set) Token: 0x0600AE30 RID: 44592 RVA: 0x00188E77 File Offset: 0x00187077
		public virtual List<ISceneUiSubtitleLanguageOverride> OverrideList
		{
			get
			{
				if (this._OverrideListInited)
				{
					return this._OverrideListCache;
				}
				this._OverrideListInited = true;
				if (this.FbInstance != null)
				{
					List<ISceneUiSubtitleLanguageOverride> overrideList = this.FbInstance.OverrideList;
					if (overrideList != null)
					{
						this._OverrideListCache = new List<ISceneUiSubtitleLanguageOverride>(overrideList.Count);
						for (int i = 0; i < overrideList.Count; i++)
						{
							this._OverrideListCache.Add(ISceneUiSubtitleLanguageOverride.Create(overrideList[i]));
						}
					}
				}
				else
				{
					ISceneUiSubtitleLocalizationConfig_SetValue pocoInterface = this.PocoInterface;
					this._OverrideListCache = ((pocoInterface != null) ? pocoInterface.OverrideList : null);
				}
				return this._OverrideListCache;
			}
			set
			{
				this.GetOrCreatePoco().OverrideList = value;
				this._OverrideListInited = false;
			}
		}

		// Token: 0x040067DB RID: 26587
		[Nullable(2)]
		protected ISceneUiSubtitleLocalizationConfig FbInstance;

		// Token: 0x040067DC RID: 26588
		[Nullable(2)]
		protected ISceneUiSubtitleLocalizationConfig_SetValue PocoInterface;

		// Token: 0x040067DD RID: 26589
		private List<ISceneUiSubtitleLanguageOverride> _OverrideListCache;

		// Token: 0x040067DE RID: 26590
		private bool _OverrideListInited;
	}
}
