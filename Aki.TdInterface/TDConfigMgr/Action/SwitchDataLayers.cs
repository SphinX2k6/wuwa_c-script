using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002228 RID: 8744
	[NullableContext(1)]
	[Nullable(0)]
	public class SwitchDataLayers : ActionParams
	{
		// Token: 0x0600BFEA RID: 49130 RVA: 0x001B911C File Offset: 0x001B731C
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

		// Token: 0x0600BFEB RID: 49131 RVA: 0x001B9154 File Offset: 0x001B7354
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

		// Token: 0x0600BFEC RID: 49132 RVA: 0x001B9167 File Offset: 0x001B7367
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

		// Token: 0x0600BFED RID: 49133 RVA: 0x001B917C File Offset: 0x001B737C
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

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x0600BFEE RID: 49134 RVA: 0x001B91CA File Offset: 0x001B73CA
		// (set) Token: 0x0600BFEF RID: 49135 RVA: 0x001B91F1 File Offset: 0x001B73F1
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

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x0600BFF0 RID: 49136 RVA: 0x001B91FF File Offset: 0x001B73FF
		// (set) Token: 0x0600BFF1 RID: 49137 RVA: 0x001B9226 File Offset: 0x001B7426
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

		// Token: 0x17003A20 RID: 14880
		// (get) Token: 0x0600BFF2 RID: 49138 RVA: 0x001B9234 File Offset: 0x001B7434
		// (set) Token: 0x0600BFF3 RID: 49139 RVA: 0x001B9295 File Offset: 0x001B7495
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

		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x0600BFF4 RID: 49140 RVA: 0x001B92AA File Offset: 0x001B74AA
		// (set) Token: 0x0600BFF5 RID: 49141 RVA: 0x001B92D1 File Offset: 0x001B74D1
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

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x0600BFF6 RID: 49142 RVA: 0x001B92DF File Offset: 0x001B74DF
		// (set) Token: 0x0600BFF7 RID: 49143 RVA: 0x001B9306 File Offset: 0x001B7506
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

		// Token: 0x0400726E RID: 29294
		[Nullable(2)]
		protected new SwitchDataLayers FbInstance;

		// Token: 0x0400726F RID: 29295
		[Nullable(2)]
		protected SwitchDataLayers_SetValue PocoInterface;

		// Token: 0x04007270 RID: 29296
		private ISwitchDataLayersTransitionWithSequence _TransitionOptionCache;

		// Token: 0x04007271 RID: 29297
		private bool _TransitionOptionInited;
	}
}
