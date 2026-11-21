using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200018A RID: 394
	public class FlowerPollutionComponent : IComponentBase
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x0001FDE0 File Offset: 0x0001DFE0
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

		// Token: 0x060004F1 RID: 1265 RVA: 0x0001FE18 File Offset: 0x0001E018
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

		// Token: 0x060004F2 RID: 1266 RVA: 0x0001FE2B File Offset: 0x0001E02B
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

		// Token: 0x060004F3 RID: 1267 RVA: 0x0001FE40 File Offset: 0x0001E040
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

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x0001FEFA File Offset: 0x0001E0FA
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

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0001FF08 File Offset: 0x0001E108
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x0001FF32 File Offset: 0x0001E132
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

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0001FF40 File Offset: 0x0001E140
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x0001FFA1 File Offset: 0x0001E1A1
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

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0001FFB8 File Offset: 0x0001E1B8
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00020019 File Offset: 0x0001E219
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

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0002002E File Offset: 0x0001E22E
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00020055 File Offset: 0x0001E255
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

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00020063 File Offset: 0x0001E263
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x0002008A File Offset: 0x0001E28A
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

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00020098 File Offset: 0x0001E298
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x0002012B File Offset: 0x0001E32B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> OnEnterPollutionRangeActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().OnEnterPollutionRangeActions = value;
				this._OnEnterPollutionRangeActionsInited = false;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00020140 File Offset: 0x0001E340
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x000201D3 File Offset: 0x0001E3D3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> OnLeavePollutionRangeActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().OnLeavePollutionRangeActions = value;
				this._OnLeavePollutionRangeActionsInited = false;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000201E8 File Offset: 0x0001E3E8
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00020213 File Offset: 0x0001E413
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

		// Token: 0x04000767 RID: 1895
		[Nullable(2)]
		protected new FlowerPollutionComponent FbInstance;

		// Token: 0x04000768 RID: 1896
		[Nullable(2)]
		protected new FlowerPollutionComponent_SetValue PocoInterface;

		// Token: 0x04000769 RID: 1897
		private IFlowerPollutionSplineConfig _SplineConfigsCache;

		// Token: 0x0400076A RID: 1898
		private bool _SplineConfigsInited;

		// Token: 0x0400076B RID: 1899
		private IFlowerPollutionPointLightConfig _PointLightConfigCache;

		// Token: 0x0400076C RID: 1900
		private bool _PointLightConfigInited;

		// Token: 0x0400076D RID: 1901
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _OnEnterPollutionRangeActionsCache;

		// Token: 0x0400076E RID: 1902
		private bool _OnEnterPollutionRangeActionsInited;

		// Token: 0x0400076F RID: 1903
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _OnLeavePollutionRangeActionsCache;

		// Token: 0x04000770 RID: 1904
		private bool _OnLeavePollutionRangeActionsInited;
	}
}
