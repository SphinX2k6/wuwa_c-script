using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006B0 RID: 1712
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneTextGuideUiContent
	{
		// Token: 0x060024B4 RID: 9396 RVA: 0x00063478 File Offset: 0x00061678
		private ISceneTextGuideUiContent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneTextGuideUiContent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneTextGuideUiContent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneTextGuideUiContent_SetValue());
			}
			return result;
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x000634B0 File Offset: 0x000616B0
		public static ISceneTextGuideUiContent Create([Nullable(2)] ISceneTextGuideUiContent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextGuideUiContent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x000634C3 File Offset: 0x000616C3
		public static ISceneTextGuideUiContent CreateFromSetValue([Nullable(2)] ISceneTextGuideUiContent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneTextGuideUiContent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x000634D6 File Offset: 0x000616D6
		public ISceneTextGuideUiContent_SetValue ToSetValue()
		{
			return new ISceneTextGuideUiContent_SetValue
			{
				TidText = this.TidText,
				ActionMappingIconList = this.ActionMappingIconList,
				MobileIconList = this.MobileIconList,
				EdTidText = this.EdTidText
			};
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x0006350D File Offset: 0x0006170D
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x00063538 File Offset: 0x00061738
		public virtual string TidText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidText;
			}
			set
			{
				this.GetOrCreatePoco().TidText = value;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x00063548 File Offset: 0x00061748
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x000635DB File Offset: 0x000617DB
		public virtual List<ISceneTextGuideUiActionMappingIcon> ActionMappingIconList
		{
			get
			{
				if (this._ActionMappingIconListInited)
				{
					return this._ActionMappingIconListCache;
				}
				this._ActionMappingIconListInited = true;
				if (this.FbInstance != null)
				{
					List<ISceneTextGuideUiActionMappingIcon> actionMappingIconList = this.FbInstance.ActionMappingIconList;
					if (actionMappingIconList != null)
					{
						this._ActionMappingIconListCache = new List<ISceneTextGuideUiActionMappingIcon>(actionMappingIconList.Count);
						for (int i = 0; i < actionMappingIconList.Count; i++)
						{
							this._ActionMappingIconListCache.Add(ISceneTextGuideUiActionMappingIcon.Create(actionMappingIconList[i]));
						}
					}
				}
				else
				{
					ISceneTextGuideUiContent_SetValue pocoInterface = this.PocoInterface;
					this._ActionMappingIconListCache = ((pocoInterface != null) ? pocoInterface.ActionMappingIconList : null);
				}
				return this._ActionMappingIconListCache;
			}
			set
			{
				this.GetOrCreatePoco().ActionMappingIconList = value;
				this._ActionMappingIconListInited = false;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x000635F0 File Offset: 0x000617F0
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x00063617 File Offset: 0x00061817
		public virtual List<string> MobileIconList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MobileIconList;
				}
				ISceneTextGuideUiContent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MobileIconList;
			}
			set
			{
				this.GetOrCreatePoco().MobileIconList = value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x00063625 File Offset: 0x00061825
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x0006363C File Offset: 0x0006183C
		public virtual string EdTidText
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidText;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidText = value;
			}
		}

		// Token: 0x0400192B RID: 6443
		[Nullable(2)]
		protected ISceneTextGuideUiContent FbInstance;

		// Token: 0x0400192C RID: 6444
		[Nullable(2)]
		protected ISceneTextGuideUiContent_SetValue PocoInterface;

		// Token: 0x0400192D RID: 6445
		private List<ISceneTextGuideUiActionMappingIcon> _ActionMappingIconListCache;

		// Token: 0x0400192E RID: 6446
		private bool _ActionMappingIconListInited;
	}
}
