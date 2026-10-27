using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000175 RID: 373
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowerPollutionComponent : IComponentBase
	{
		// Token: 0x060004EC RID: 1260 RVA: 0x0001F46C File Offset: 0x0001D66C
		private FlowerPollutionComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FlowerPollutionComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FlowerPollutionComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FlowerPollutionComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001F4A4 File Offset: 0x0001D6A4
		public static FlowerPollutionComponent Create([Nullable(2)] FlowerPollutionComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FlowerPollutionComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0001F4B7 File Offset: 0x0001D6B7
		public static FlowerPollutionComponent CreateFromSetValue([Nullable(2)] FlowerPollutionComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FlowerPollutionComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0001F4CC File Offset: 0x0001D6CC
		public new FlowerPollutionComponent_SetValue ToSetValue()
		{
			return new FlowerPollutionComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				SplineConfigs = this.SplineConfigs,
				PointLightConfig = this.PointLightConfig,
				ObstacleEntityIds = this.ObstacleEntityIds,
				PollutionSourceEntityIds = this.PollutionSourceEntityIds,
				OnEnterPollutionRangeActions = this.OnEnterPollutionRangeActions,
				OnLeavePollutionRangeActions = this.OnLeavePollutionRangeActions,
				BakeData = this.BakeData
			};
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0001F54C File Offset: 0x0001D74C
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x0001F586 File Offset: 0x0001D786
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				FlowerPollutionComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0001F594 File Offset: 0x0001D794
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x0001F5BE File Offset: 0x0001D7BE
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

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0001F5CC File Offset: 0x0001D7CC
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x0001F62D File Offset: 0x0001D82D
		public virtual IFlowerPollutionSplineConfig SplineConfigs
		{
			get
			{
				if (this._SplineConfigsInited)
				{
					return this._SplineConfigsCache;
				}
				this._SplineConfigsInited = true;
				if (this.FbInstance != null)
				{
					this._SplineConfigsCache = IFlowerPollutionSplineConfig.Create(this.FbInstance.SplineConfigs);
				}
				else
				{
					FlowerPollutionComponent_SetValue pocoInterface = this.PocoInterface;
					this._SplineConfigsCache = ((pocoInterface != null) ? pocoInterface.SplineConfigs : null);
				}
				return this._SplineConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().SplineConfigs = value;
				this._SplineConfigsInited = false;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0001F644 File Offset: 0x0001D844
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x0001F6A5 File Offset: 0x0001D8A5
		public virtual IFlowerPollutionPointLightConfig PointLightConfig
		{
			get
			{
				if (this._PointLightConfigInited)
				{
					return this._PointLightConfigCache;
				}
				this._PointLightConfigInited = true;
				if (this.FbInstance != null)
				{
					this._PointLightConfigCache = IFlowerPollutionPointLightConfig.Create(this.FbInstance.PointLightConfig);
				}
				else
				{
					FlowerPollutionComponent_SetValue pocoInterface = this.PocoInterface;
					this._PointLightConfigCache = ((pocoInterface != null) ? pocoInterface.PointLightConfig : null);
				}
				return this._PointLightConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().PointLightConfig = value;
				this._PointLightConfigInited = false;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0001F6BA File Offset: 0x0001D8BA
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x0001F6E1 File Offset: 0x0001D8E1
		public virtual List<int> ObstacleEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ObstacleEntityIds;
				}
				FlowerPollutionComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ObstacleEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().ObstacleEntityIds = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0001F6EF File Offset: 0x0001D8EF
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x0001F716 File Offset: 0x0001D916
		public virtual List<int> PollutionSourceEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PollutionSourceEntityIds;
				}
				FlowerPollutionComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PollutionSourceEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().PollutionSourceEntityIds = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0001F724 File Offset: 0x0001D924
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x0001F7B7 File Offset: 0x0001D9B7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> OnEnterPollutionRangeActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._OnEnterPollutionRangeActionsInited)
				{
					return this._OnEnterPollutionRangeActionsCache;
				}
				this._OnEnterPollutionRangeActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> onEnterPollutionRangeActions = this.FbInstance.OnEnterPollutionRangeActions;
					if (onEnterPollutionRangeActions != null)
					{
						this._OnEnterPollutionRangeActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(onEnterPollutionRangeActions.Count);
						for (int i = 0; i < onEnterPollutionRangeActions.Count; i++)
						{
							this._OnEnterPollutionRangeActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(onEnterPollutionRangeActions[i]));
						}
					}
				}
				else
				{
					FlowerPollutionComponent_SetValue pocoInterface = this.PocoInterface;
					this._OnEnterPollutionRangeActionsCache = ((pocoInterface != null) ? pocoInterface.OnEnterPollutionRangeActions : null);
				}
				return this._OnEnterPollutionRangeActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().OnEnterPollutionRangeActions = value;
				this._OnEnterPollutionRangeActionsInited = false;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0001F7CC File Offset: 0x0001D9CC
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x0001F85F File Offset: 0x0001DA5F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> OnLeavePollutionRangeActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._OnLeavePollutionRangeActionsInited)
				{
					return this._OnLeavePollutionRangeActionsCache;
				}
				this._OnLeavePollutionRangeActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> onLeavePollutionRangeActions = this.FbInstance.OnLeavePollutionRangeActions;
					if (onLeavePollutionRangeActions != null)
					{
						this._OnLeavePollutionRangeActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(onLeavePollutionRangeActions.Count);
						for (int i = 0; i < onLeavePollutionRangeActions.Count; i++)
						{
							this._OnLeavePollutionRangeActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(onLeavePollutionRangeActions[i]));
						}
					}
				}
				else
				{
					FlowerPollutionComponent_SetValue pocoInterface = this.PocoInterface;
					this._OnLeavePollutionRangeActionsCache = ((pocoInterface != null) ? pocoInterface.OnLeavePollutionRangeActions : null);
				}
				return this._OnLeavePollutionRangeActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().OnLeavePollutionRangeActions = value;
				this._OnLeavePollutionRangeActionsInited = false;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x0001F874 File Offset: 0x0001DA74
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x0001F89F File Offset: 0x0001DA9F
		public virtual string BakeData
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BakeData;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.BakeData;
			}
			set
			{
				this.GetOrCreatePoco().BakeData = value;
			}
		}

		// Token: 0x0400071A RID: 1818
		[Nullable(2)]
		protected new FlowerPollutionComponent FbInstance;

		// Token: 0x0400071B RID: 1819
		[Nullable(2)]
		protected new FlowerPollutionComponent_SetValue PocoInterface;

		// Token: 0x0400071C RID: 1820
		private IFlowerPollutionSplineConfig _SplineConfigsCache;

		// Token: 0x0400071D RID: 1821
		private bool _SplineConfigsInited;

		// Token: 0x0400071E RID: 1822
		private IFlowerPollutionPointLightConfig _PointLightConfigCache;

		// Token: 0x0400071F RID: 1823
		private bool _PointLightConfigInited;

		// Token: 0x04000720 RID: 1824
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _OnEnterPollutionRangeActionsCache;

		// Token: 0x04000721 RID: 1825
		private bool _OnEnterPollutionRangeActionsInited;

		// Token: 0x04000722 RID: 1826
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _OnLeavePollutionRangeActionsCache;

		// Token: 0x04000723 RID: 1827
		private bool _OnLeavePollutionRangeActionsInited;
	}
}
