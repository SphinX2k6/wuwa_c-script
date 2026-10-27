using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200088F RID: 2191
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemEventListenerComponent : IComponentBase
	{
		// Token: 0x060030DB RID: 12507 RVA: 0x0007DA84 File Offset: 0x0007BC84
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

		// Token: 0x060030DC RID: 12508 RVA: 0x0007DABC File Offset: 0x0007BCBC
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

		// Token: 0x060030DD RID: 12509 RVA: 0x0007DACF File Offset: 0x0007BCCF
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

		// Token: 0x060030DE RID: 12510 RVA: 0x0007DAE2 File Offset: 0x0007BCE2
		public new SceneItemEventListenerComponent_SetValue ToSetValue()
		{
			return new SceneItemEventListenerComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Events = this.Events
			};
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060030DF RID: 12511 RVA: 0x0007DB10 File Offset: 0x0007BD10
		// (set) Token: 0x060030E0 RID: 12512 RVA: 0x0007DB4A File Offset: 0x0007BD4A
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

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x0007DB58 File Offset: 0x0007BD58
		// (set) Token: 0x060030E2 RID: 12514 RVA: 0x0007DB82 File Offset: 0x0007BD82
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

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060030E3 RID: 12515 RVA: 0x0007DB90 File Offset: 0x0007BD90
		// (set) Token: 0x060030E4 RID: 12516 RVA: 0x0007DC23 File Offset: 0x0007BE23
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

		// Token: 0x04002022 RID: 8226
		[Nullable(2)]
		protected new SceneItemEventListenerComponent FbInstance;

		// Token: 0x04002023 RID: 8227
		[Nullable(2)]
		protected new SceneItemEventListenerComponent_SetValue PocoInterface;

		// Token: 0x04002024 RID: 8228
		private List<ISceneItemEventConfig> _EventsCache;

		// Token: 0x04002025 RID: 8229
		private bool _EventsInited;
	}
}
