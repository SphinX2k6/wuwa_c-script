using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000751 RID: 1873
	public class ISceneTextGuideUiContent
	{
		// Token: 0x060027D0 RID: 10192 RVA: 0x0006A440 File Offset: 0x00068640
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

		// Token: 0x060027D1 RID: 10193 RVA: 0x0006A478 File Offset: 0x00068678
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

		// Token: 0x060027D2 RID: 10194 RVA: 0x0006A48B File Offset: 0x0006868B
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

		// Token: 0x060027D3 RID: 10195 RVA: 0x0006A49E File Offset: 0x0006869E
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

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x0006A4D5 File Offset: 0x000686D5
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x0006A500 File Offset: 0x00068700
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

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x0006A510 File Offset: 0x00068710
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x0006A5A3 File Offset: 0x000687A3
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

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x0006A5B8 File Offset: 0x000687B8
		// (set) Token: 0x060027D9 RID: 10201 RVA: 0x0006A5DF File Offset: 0x000687DF
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

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x0006A5ED File Offset: 0x000687ED
		// (set) Token: 0x060027DB RID: 10203 RVA: 0x0006A604 File Offset: 0x00068804
		[Nullable(2)]
		public virtual string EdTidText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidText = value;
			}
		}

		// Token: 0x04001B28 RID: 6952
		[Nullable(2)]
		protected ISceneTextGuideUiContent FbInstance;

		// Token: 0x04001B29 RID: 6953
		[Nullable(2)]
		protected ISceneTextGuideUiContent_SetValue PocoInterface;

		// Token: 0x04001B2A RID: 6954
		private List<ISceneTextGuideUiActionMappingIcon> _ActionMappingIconListCache;

		// Token: 0x04001B2B RID: 6955
		private bool _ActionMappingIconListInited;
	}
}
