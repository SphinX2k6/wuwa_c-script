using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DAB RID: 3499
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemEventListenerComponent : IComponentBase
	{
		// Token: 0x06004F7F RID: 20351 RVA: 0x000C4DC2 File Offset: 0x000C2FC2
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

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x06004F80 RID: 20352 RVA: 0x000C4DE4 File Offset: 0x000C2FE4
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

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x06004F81 RID: 20353 RVA: 0x000C4E1C File Offset: 0x000C301C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x06004F82 RID: 20354 RVA: 0x000C4E34 File Offset: 0x000C3034
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

		// Token: 0x04002D9E RID: 11678
		private ISceneItemEventListenerComponent Instance;

		// Token: 0x04002D9F RID: 11679
		private List<ISceneItemEventConfig> _EventsCache;

		// Token: 0x04002DA0 RID: 11680
		private bool _EventsInited;
	}
}
