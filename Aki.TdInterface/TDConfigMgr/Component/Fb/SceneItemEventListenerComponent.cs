using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EA7 RID: 3751
	public class SceneItemEventListenerComponent : IComponentBase
	{
		// Token: 0x060054A4 RID: 21668 RVA: 0x000D0612 File Offset: 0x000CE812
		public static SceneItemEventListenerComponent Create(ISceneItemEventListenerComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneItemEventListenerComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x060054A5 RID: 21669 RVA: 0x000D0634 File Offset: 0x000CE834
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x000D066C File Offset: 0x000CE86C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x060054A7 RID: 21671 RVA: 0x000D0684 File Offset: 0x000CE884
		public virtual List<ISceneItemEventConfig> Events
		{
			get
			{
				if (this._EventsInited)
				{
					return this._EventsCache;
				}
				this._EventsInited = true;
				int eventsLength = this.Instance.EventsLength;
				this._EventsCache = new List<ISceneItemEventConfig>(eventsLength);
				for (int i = 0; i < eventsLength; i++)
				{
					this._EventsCache.Add(ISceneItemEventConfig.Create(this.Instance.Events(i)));
				}
				return this._EventsCache;
			}
		}

		// Token: 0x04003064 RID: 12388
		private ISceneItemEventListenerComponent Instance;

		// Token: 0x04003065 RID: 12389
		private List<ISceneItemEventConfig> _EventsCache;

		// Token: 0x04003066 RID: 12390
		private bool _EventsInited;
	}
}
