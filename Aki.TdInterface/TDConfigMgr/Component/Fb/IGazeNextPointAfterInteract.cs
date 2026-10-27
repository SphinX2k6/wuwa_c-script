using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B11 RID: 2833
	[NullableContext(2)]
	[Nullable(0)]
	public class IGazeNextPointAfterInteract
	{
		// Token: 0x06004173 RID: 16755 RVA: 0x000A809A File Offset: 0x000A629A
		[NullableContext(1)]
		public static IGazeNextPointAfterInteract Create(IGazeNextPointAfterInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGazeNextPointAfterInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06004174 RID: 16756 RVA: 0x000A80B9 File Offset: 0x000A62B9
		public virtual IGazeCondition GazeCondition
		{
			get
			{
				if (this._GazeConditionInited)
				{
					return this._GazeConditionCache;
				}
				this._GazeConditionInited = true;
				this._GazeConditionCache = IGazeCondition.Create(this.Instance.GazeCondition);
				return this._GazeConditionCache;
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06004175 RID: 16757 RVA: 0x000A80ED File Offset: 0x000A62ED
		[Nullable(1)]
		public virtual IGazePerformance GazePerformance
		{
			[NullableContext(1)]
			get
			{
				if (this._GazePerformanceInited)
				{
					return this._GazePerformanceCache;
				}
				this._GazePerformanceInited = true;
				this._GazePerformanceCache = IGazePerformance.Create(this.Instance.GazePerformance);
				return this._GazePerformanceCache;
			}
		}

		// Token: 0x040024DE RID: 9438
		private IGazeNextPointAfterInteract Instance;

		// Token: 0x040024DF RID: 9439
		private IGazeCondition _GazeConditionCache;

		// Token: 0x040024E0 RID: 9440
		private bool _GazeConditionInited;

		// Token: 0x040024E1 RID: 9441
		private IGazePerformance _GazePerformanceCache;

		// Token: 0x040024E2 RID: 9442
		private bool _GazePerformanceInited;
	}
}
