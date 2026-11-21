using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200042B RID: 1067
	public class IGazeNextPointAfterInteract
	{
		// Token: 0x0600153D RID: 5437 RVA: 0x000436B4 File Offset: 0x000418B4
		private IGazeNextPointAfterInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGazeNextPointAfterInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGazeNextPointAfterInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGazeNextPointAfterInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x000436EC File Offset: 0x000418EC
		public static IGazeNextPointAfterInteract Create([Nullable(2)] IGazeNextPointAfterInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGazeNextPointAfterInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x000436FF File Offset: 0x000418FF
		public static IGazeNextPointAfterInteract CreateFromSetValue([Nullable(2)] IGazeNextPointAfterInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGazeNextPointAfterInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00043712 File Offset: 0x00041912
		public IGazeNextPointAfterInteract_SetValue ToSetValue()
		{
			return new IGazeNextPointAfterInteract_SetValue
			{
				GazeCondition = this.GazeCondition,
				GazePerformance = this.GazePerformance
			};
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00043734 File Offset: 0x00041934
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x00043795 File Offset: 0x00041995
		[Nullable(2)]
		public virtual IGazeCondition GazeCondition
		{
			[NullableContext(2)]
			get
			{
				if (this._GazeConditionInited)
				{
					return this._GazeConditionCache;
				}
				this._GazeConditionInited = true;
				if (this.FbInstance != null)
				{
					this._GazeConditionCache = IGazeCondition.Create(this.FbInstance.GazeCondition);
				}
				else
				{
					IGazeNextPointAfterInteract_SetValue pocoInterface = this.PocoInterface;
					this._GazeConditionCache = ((pocoInterface != null) ? pocoInterface.GazeCondition : null);
				}
				return this._GazeConditionCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().GazeCondition = value;
				this._GazeConditionInited = false;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x000437AC File Offset: 0x000419AC
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x0004380D File Offset: 0x00041A0D
		public virtual IGazePerformance GazePerformance
		{
			get
			{
				if (this._GazePerformanceInited)
				{
					return this._GazePerformanceCache;
				}
				this._GazePerformanceInited = true;
				if (this.FbInstance != null)
				{
					this._GazePerformanceCache = IGazePerformance.Create(this.FbInstance.GazePerformance);
				}
				else
				{
					IGazeNextPointAfterInteract_SetValue pocoInterface = this.PocoInterface;
					this._GazePerformanceCache = ((pocoInterface != null) ? pocoInterface.GazePerformance : null);
				}
				return this._GazePerformanceCache;
			}
			set
			{
				this.GetOrCreatePoco().GazePerformance = value;
				this._GazePerformanceInited = false;
			}
		}

		// Token: 0x040010BD RID: 4285
		[Nullable(2)]
		protected IGazeNextPointAfterInteract FbInstance;

		// Token: 0x040010BE RID: 4286
		[Nullable(2)]
		protected IGazeNextPointAfterInteract_SetValue PocoInterface;

		// Token: 0x040010BF RID: 4287
		private IGazeCondition _GazeConditionCache;

		// Token: 0x040010C0 RID: 4288
		private bool _GazeConditionInited;

		// Token: 0x040010C1 RID: 4289
		private IGazePerformance _GazePerformanceCache;

		// Token: 0x040010C2 RID: 4290
		private bool _GazePerformanceInited;
	}
}
