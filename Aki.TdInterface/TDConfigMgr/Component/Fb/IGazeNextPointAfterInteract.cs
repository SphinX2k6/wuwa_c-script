using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BDF RID: 3039
	public class IGazeNextPointAfterInteract
	{
		// Token: 0x060045C9 RID: 17865 RVA: 0x000B20C6 File Offset: 0x000B02C6
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

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060045CA RID: 17866 RVA: 0x000B20E5 File Offset: 0x000B02E5
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
				this._GazeConditionCache = IGazeCondition.Create(this.Instance.GazeCondition);
				return this._GazeConditionCache;
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060045CB RID: 17867 RVA: 0x000B2119 File Offset: 0x000B0319
		public virtual IGazePerformance GazePerformance
		{
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

		// Token: 0x04002722 RID: 10018
		private IGazeNextPointAfterInteract Instance;

		// Token: 0x04002723 RID: 10019
		[Nullable(2)]
		private IGazeCondition _GazeConditionCache;

		// Token: 0x04002724 RID: 10020
		private bool _GazeConditionInited;

		// Token: 0x04002725 RID: 10021
		[Nullable(2)]
		private IGazePerformance _GazePerformanceCache;

		// Token: 0x04002726 RID: 10022
		private bool _GazePerformanceInited;
	}
}
