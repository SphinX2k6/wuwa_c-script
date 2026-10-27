using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003D4 RID: 980
	[NullableContext(1)]
	[Nullable(0)]
	public class IGazeNextPointAfterInteract
	{
		// Token: 0x060013AF RID: 5039 RVA: 0x0003FB34 File Offset: 0x0003DD34
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

		// Token: 0x060013B0 RID: 5040 RVA: 0x0003FB6C File Offset: 0x0003DD6C
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

		// Token: 0x060013B1 RID: 5041 RVA: 0x0003FB7F File Offset: 0x0003DD7F
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

		// Token: 0x060013B2 RID: 5042 RVA: 0x0003FB92 File Offset: 0x0003DD92
		public IGazeNextPointAfterInteract_SetValue ToSetValue()
		{
			return new IGazeNextPointAfterInteract_SetValue
			{
				GazeCondition = this.GazeCondition,
				GazePerformance = this.GazePerformance
			};
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x0003FBB4 File Offset: 0x0003DDB4
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x0003FC15 File Offset: 0x0003DE15
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0003FC2C File Offset: 0x0003DE2C
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x0003FC8D File Offset: 0x0003DE8D
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

		// Token: 0x04000FA4 RID: 4004
		[Nullable(2)]
		protected IGazeNextPointAfterInteract FbInstance;

		// Token: 0x04000FA5 RID: 4005
		[Nullable(2)]
		protected IGazeNextPointAfterInteract_SetValue PocoInterface;

		// Token: 0x04000FA6 RID: 4006
		private IGazeCondition _GazeConditionCache;

		// Token: 0x04000FA7 RID: 4007
		private bool _GazeConditionInited;

		// Token: 0x04000FA8 RID: 4008
		private IGazePerformance _GazePerformanceCache;

		// Token: 0x04000FA9 RID: 4009
		private bool _GazePerformanceInited;
	}
}
