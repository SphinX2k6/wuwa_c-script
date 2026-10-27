using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002895 RID: 10389
	[NullableContext(1)]
	[Nullable(0)]
	public class SwitchDataLayers : ActionParams
	{
		// Token: 0x0600E611 RID: 58897 RVA: 0x0021CFD2 File Offset: 0x0021B1D2
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

		// Token: 0x170046A9 RID: 18089
		// (get) Token: 0x0600E612 RID: 58898 RVA: 0x0021CFF4 File Offset: 0x0021B1F4
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

		// Token: 0x170046AA RID: 18090
		// (get) Token: 0x0600E613 RID: 58899 RVA: 0x0021D058 File Offset: 0x0021B258
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

		// Token: 0x170046AB RID: 18091
		// (get) Token: 0x0600E614 RID: 58900 RVA: 0x0021D0BC File Offset: 0x0021B2BC
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

		// Token: 0x170046AC RID: 18092
		// (get) Token: 0x0600E615 RID: 58901 RVA: 0x0021D0F0 File Offset: 0x0021B2F0
		[Nullable(2)]
		public virtual string MaterialDataForLoadedLayers
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.MaterialDataForLoadedLayers;
			}
		}

		// Token: 0x170046AD RID: 18093
		// (get) Token: 0x0600E616 RID: 58902 RVA: 0x0021D0FD File Offset: 0x0021B2FD
		[Nullable(2)]
		public virtual string MaterialDataForUnloadLayers
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.MaterialDataForUnloadLayers;
			}
		}

		// Token: 0x04007F2F RID: 32559
		private ISwitchDataLayers Instance;

		// Token: 0x04007F30 RID: 32560
		private List<int> _LoadDataLayersCache;

		// Token: 0x04007F31 RID: 32561
		private bool _LoadDataLayersInited;

		// Token: 0x04007F32 RID: 32562
		private List<int> _UnloadDataLayersCache;

		// Token: 0x04007F33 RID: 32563
		private bool _UnloadDataLayersInited;

		// Token: 0x04007F34 RID: 32564
		[Nullable(2)]
		private ISwitchDataLayersTransitionWithSequence _TransitionOptionCache;

		// Token: 0x04007F35 RID: 32565
		private bool _TransitionOptionInited;
	}
}
