using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000932 RID: 2354
	public class SceneItemEventListenerComponent : IComponentBase
	{
		// Token: 0x06003417 RID: 13335 RVA: 0x00084F6C File Offset: 0x0008316C
		private SceneItemEventListenerComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SceneItemEventListenerComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SceneItemEventListenerComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SceneItemEventListenerComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00084FA4 File Offset: 0x000831A4
		public static SceneItemEventListenerComponent Create([Nullable(2)] SceneItemEventListenerComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneItemEventListenerComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00084FB7 File Offset: 0x000831B7
		public static SceneItemEventListenerComponent CreateFromSetValue([Nullable(2)] SceneItemEventListenerComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SceneItemEventListenerComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x00084FCA File Offset: 0x000831CA
		public new SceneItemEventListenerComponent_SetValue ToSetValue()
		{
			return new SceneItemEventListenerComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Events = this.Events
			};
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x0600341B RID: 13339 RVA: 0x00084FF8 File Offset: 0x000831F8
		// (set) Token: 0x0600341C RID: 13340 RVA: 0x00085032 File Offset: 0x00083232
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SceneItemEventListenerComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x0600341D RID: 13341 RVA: 0x00085040 File Offset: 0x00083240
		// (set) Token: 0x0600341E RID: 13342 RVA: 0x0008506A File Offset: 0x0008326A
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x0600341F RID: 13343 RVA: 0x00085078 File Offset: 0x00083278
		// (set) Token: 0x06003420 RID: 13344 RVA: 0x0008510B File Offset: 0x0008330B
		public virtual List<ISceneItemEventConfig> Events
		{
			get
			{
				if (this._EventsInited)
				{
					return this._EventsCache;
				}
				this._EventsInited = true;
				if (this.FbInstance != null)
				{
					List<ISceneItemEventConfig> events = this.FbInstance.Events;
					if (events != null)
					{
						this._EventsCache = new List<ISceneItemEventConfig>(events.Count);
						for (int i = 0; i < events.Count; i++)
						{
							this._EventsCache.Add(ISceneItemEventConfig.Create(events[i]));
						}
					}
				}
				else
				{
					SceneItemEventListenerComponent_SetValue pocoInterface = this.PocoInterface;
					this._EventsCache = ((pocoInterface != null) ? pocoInterface.Events : null);
				}
				return this._EventsCache;
			}
			set
			{
				this.GetOrCreatePoco().Events = value;
				this._EventsInited = false;
			}
		}

		// Token: 0x04002234 RID: 8756
		[Nullable(2)]
		protected new SceneItemEventListenerComponent FbInstance;

		// Token: 0x04002235 RID: 8757
		[Nullable(2)]
		protected new SceneItemEventListenerComponent_SetValue PocoInterface;

		// Token: 0x04002236 RID: 8758
		private List<ISceneItemEventConfig> _EventsCache;

		// Token: 0x04002237 RID: 8759
		private bool _EventsInited;
	}
}
