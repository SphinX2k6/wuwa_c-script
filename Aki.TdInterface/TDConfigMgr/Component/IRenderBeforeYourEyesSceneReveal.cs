using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000713 RID: 1811
	public class IRenderBeforeYourEyesSceneReveal : IRenderSpecifiedRangeType
	{
		// Token: 0x06002662 RID: 9826 RVA: 0x000676BC File Offset: 0x000658BC
		private IRenderBeforeYourEyesSceneReveal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRenderBeforeYourEyesSceneReveal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRenderBeforeYourEyesSceneReveal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRenderBeforeYourEyesSceneReveal_SetValue());
			}
			return result;
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000676F4 File Offset: 0x000658F4
		public static IRenderBeforeYourEyesSceneReveal Create([Nullable(2)] IRenderBeforeYourEyesSceneReveal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderBeforeYourEyesSceneReveal
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x00067707 File Offset: 0x00065907
		public static IRenderBeforeYourEyesSceneReveal CreateFromSetValue([Nullable(2)] IRenderBeforeYourEyesSceneReveal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRenderBeforeYourEyesSceneReveal
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x0006771A File Offset: 0x0006591A
		public new IRenderBeforeYourEyesSceneReveal_SetValue ToSetValue()
		{
			return new IRenderBeforeYourEyesSceneReveal_SetValue
			{
				Type = this.Type,
				CenterTarget = this.CenterTarget,
				StateRadiusConfigs = this.StateRadiusConfigs
			};
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x00067745 File Offset: 0x00065945
		// (set) Token: 0x06002667 RID: 9831 RVA: 0x00067770 File Offset: 0x00065970
		public override ERenderSpecifiedRangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERenderSpecifiedRangeType.FlowerBridge;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x0006777E File Offset: 0x0006597E
		// (set) Token: 0x06002669 RID: 9833 RVA: 0x000677A5 File Offset: 0x000659A5
		public virtual ITargetEntityType CenterTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CenterTarget;
				}
				IRenderBeforeYourEyesSceneReveal_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CenterTarget;
			}
			set
			{
				this.GetOrCreatePoco().CenterTarget = value;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x000677B4 File Offset: 0x000659B4
		// (set) Token: 0x0600266B RID: 9835 RVA: 0x00067847 File Offset: 0x00065A47
		public virtual List<IRenderStateRadiusConfig> StateRadiusConfigs
		{
			get
			{
				if (this._StateRadiusConfigsInited)
				{
					return this._StateRadiusConfigsCache;
				}
				this._StateRadiusConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IRenderStateRadiusConfig> stateRadiusConfigs = this.FbInstance.StateRadiusConfigs;
					if (stateRadiusConfigs != null)
					{
						this._StateRadiusConfigsCache = new List<IRenderStateRadiusConfig>(stateRadiusConfigs.Count);
						for (int i = 0; i < stateRadiusConfigs.Count; i++)
						{
							this._StateRadiusConfigsCache.Add(IRenderStateRadiusConfig.Create(stateRadiusConfigs[i]));
						}
					}
				}
				else
				{
					IRenderBeforeYourEyesSceneReveal_SetValue pocoInterface = this.PocoInterface;
					this._StateRadiusConfigsCache = ((pocoInterface != null) ? pocoInterface.StateRadiusConfigs : null);
				}
				return this._StateRadiusConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().StateRadiusConfigs = value;
				this._StateRadiusConfigsInited = false;
			}
		}

		// Token: 0x04001A62 RID: 6754
		[Nullable(2)]
		protected new IRenderBeforeYourEyesSceneReveal FbInstance;

		// Token: 0x04001A63 RID: 6755
		[Nullable(2)]
		protected new IRenderBeforeYourEyesSceneReveal_SetValue PocoInterface;

		// Token: 0x04001A64 RID: 6756
		private List<IRenderStateRadiusConfig> _StateRadiusConfigsCache;

		// Token: 0x04001A65 RID: 6757
		private bool _StateRadiusConfigsInited;
	}
}
