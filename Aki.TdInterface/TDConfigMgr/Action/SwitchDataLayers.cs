using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002493 RID: 9363
	public class SwitchDataLayers : ActionParams
	{
		// Token: 0x0600CBA8 RID: 52136 RVA: 0x001D07E8 File Offset: 0x001CE9E8
		private SwitchDataLayers_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SwitchDataLayers 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SwitchDataLayers_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SwitchDataLayers_SetValue());
			}
			return result;
		}

		// Token: 0x0600CBA9 RID: 52137 RVA: 0x001D0820 File Offset: 0x001CEA20
		public static SwitchDataLayers Create([Nullable(2)] SwitchDataLayers instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SwitchDataLayers
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CBAA RID: 52138 RVA: 0x001D0833 File Offset: 0x001CEA33
		public static SwitchDataLayers CreateFromSetValue([Nullable(2)] SwitchDataLayers_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SwitchDataLayers
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CBAB RID: 52139 RVA: 0x001D0848 File Offset: 0x001CEA48
		public SwitchDataLayers_SetValue ToSetValue()
		{
			return new SwitchDataLayers_SetValue
			{
				LoadDataLayers = this.LoadDataLayers,
				UnloadDataLayers = this.UnloadDataLayers,
				TransitionOption = this.TransitionOption,
				MaterialDataForLoadedLayers = this.MaterialDataForLoadedLayers,
				MaterialDataForUnloadLayers = this.MaterialDataForUnloadLayers
			};
		}

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x0600CBAC RID: 52140 RVA: 0x001D0896 File Offset: 0x001CEA96
		// (set) Token: 0x0600CBAD RID: 52141 RVA: 0x001D08BD File Offset: 0x001CEABD
		public virtual List<int> LoadDataLayers
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoadDataLayers;
				}
				SwitchDataLayers_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LoadDataLayers;
			}
			set
			{
				this.GetOrCreatePoco().LoadDataLayers = value;
			}
		}

		// Token: 0x17003D15 RID: 15637
		// (get) Token: 0x0600CBAE RID: 52142 RVA: 0x001D08CB File Offset: 0x001CEACB
		// (set) Token: 0x0600CBAF RID: 52143 RVA: 0x001D08F2 File Offset: 0x001CEAF2
		public virtual List<int> UnloadDataLayers
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UnloadDataLayers;
				}
				SwitchDataLayers_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UnloadDataLayers;
			}
			set
			{
				this.GetOrCreatePoco().UnloadDataLayers = value;
			}
		}

		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x0600CBB0 RID: 52144 RVA: 0x001D0900 File Offset: 0x001CEB00
		// (set) Token: 0x0600CBB1 RID: 52145 RVA: 0x001D0961 File Offset: 0x001CEB61
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
				if (this.FbInstance != null)
				{
					this._TransitionOptionCache = ISwitchDataLayersTransitionWithSequence.Create(this.FbInstance.TransitionOption);
				}
				else
				{
					SwitchDataLayers_SetValue pocoInterface = this.PocoInterface;
					this._TransitionOptionCache = ((pocoInterface != null) ? pocoInterface.TransitionOption : null);
				}
				return this._TransitionOptionCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TransitionOption = value;
				this._TransitionOptionInited = false;
			}
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x0600CBB2 RID: 52146 RVA: 0x001D0976 File Offset: 0x001CEB76
		// (set) Token: 0x0600CBB3 RID: 52147 RVA: 0x001D099D File Offset: 0x001CEB9D
		[Nullable(2)]
		public virtual string MaterialDataForLoadedLayers
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaterialDataForLoadedLayers;
				}
				SwitchDataLayers_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaterialDataForLoadedLayers;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MaterialDataForLoadedLayers = value;
			}
		}

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x0600CBB4 RID: 52148 RVA: 0x001D09AB File Offset: 0x001CEBAB
		// (set) Token: 0x0600CBB5 RID: 52149 RVA: 0x001D09D2 File Offset: 0x001CEBD2
		[Nullable(2)]
		public virtual string MaterialDataForUnloadLayers
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaterialDataForUnloadLayers;
				}
				SwitchDataLayers_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaterialDataForUnloadLayers;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MaterialDataForUnloadLayers = value;
			}
		}

		// Token: 0x040078B8 RID: 30904
		[Nullable(2)]
		protected new SwitchDataLayers FbInstance;

		// Token: 0x040078B9 RID: 30905
		[Nullable(2)]
		protected SwitchDataLayers_SetValue PocoInterface;

		// Token: 0x040078BA RID: 30906
		private ISwitchDataLayersTransitionWithSequence _TransitionOptionCache;

		// Token: 0x040078BB RID: 30907
		private bool _TransitionOptionInited;
	}
}
