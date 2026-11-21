using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B6A RID: 11114
	public class SwitchDataLayers : ActionParams
	{
		// Token: 0x0600F440 RID: 62528 RVA: 0x00239F52 File Offset: 0x00238152
		public static SwitchDataLayers Create(ISwitchDataLayers? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SwitchDataLayers
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A1A RID: 18970
		// (get) Token: 0x0600F441 RID: 62529 RVA: 0x00239F74 File Offset: 0x00238174
		public virtual List<int> LoadDataLayers
		{
			get
			{
				if (this._LoadDataLayersInited)
				{
					return this._LoadDataLayersCache;
				}
				this._LoadDataLayersInited = true;
				int loadDataLayersLength = this.Instance.LoadDataLayersLength;
				this._LoadDataLayersCache = new List<int>(loadDataLayersLength);
				for (int i = 0; i < loadDataLayersLength; i++)
				{
					this._LoadDataLayersCache.Add(this.Instance.LoadDataLayers(i));
				}
				return this._LoadDataLayersCache;
			}
		}

		// Token: 0x17004A1B RID: 18971
		// (get) Token: 0x0600F442 RID: 62530 RVA: 0x00239FD8 File Offset: 0x002381D8
		public virtual List<int> UnloadDataLayers
		{
			get
			{
				if (this._UnloadDataLayersInited)
				{
					return this._UnloadDataLayersCache;
				}
				this._UnloadDataLayersInited = true;
				int unloadDataLayersLength = this.Instance.UnloadDataLayersLength;
				this._UnloadDataLayersCache = new List<int>(unloadDataLayersLength);
				for (int i = 0; i < unloadDataLayersLength; i++)
				{
					this._UnloadDataLayersCache.Add(this.Instance.UnloadDataLayers(i));
				}
				return this._UnloadDataLayersCache;
			}
		}

		// Token: 0x17004A1C RID: 18972
		// (get) Token: 0x0600F443 RID: 62531 RVA: 0x0023A03C File Offset: 0x0023823C
		[Nullable(2)]
		public virtual ISwitchDataLayersTransitionWithSequence TransitionOption
		{
			[NullableContext(2)]
			get
			{
				if (this._TransitionOptionInited)
				{
					return this._TransitionOptionCache;
				}
				this._TransitionOptionInited = true;
				this._TransitionOptionCache = ISwitchDataLayersTransitionWithSequence.Create(this.Instance.TransitionOption);
				return this._TransitionOptionCache;
			}
		}

		// Token: 0x17004A1D RID: 18973
		// (get) Token: 0x0600F444 RID: 62532 RVA: 0x0023A070 File Offset: 0x00238270
		[Nullable(2)]
		public virtual string MaterialDataForLoadedLayers
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.MaterialDataForLoadedLayers;
			}
		}

		// Token: 0x17004A1E RID: 18974
		// (get) Token: 0x0600F445 RID: 62533 RVA: 0x0023A07D File Offset: 0x0023827D
		[Nullable(2)]
		public virtual string MaterialDataForUnloadLayers
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.MaterialDataForUnloadLayers;
			}
		}

		// Token: 0x040085EE RID: 34286
		private ISwitchDataLayers Instance;

		// Token: 0x040085EF RID: 34287
		private List<int> _LoadDataLayersCache;

		// Token: 0x040085F0 RID: 34288
		private bool _LoadDataLayersInited;

		// Token: 0x040085F1 RID: 34289
		private List<int> _UnloadDataLayersCache;

		// Token: 0x040085F2 RID: 34290
		private bool _UnloadDataLayersInited;

		// Token: 0x040085F3 RID: 34291
		[Nullable(2)]
		private ISwitchDataLayersTransitionWithSequence _TransitionOptionCache;

		// Token: 0x040085F4 RID: 34292
		private bool _TransitionOptionInited;
	}
}
