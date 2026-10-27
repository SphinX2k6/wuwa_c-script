using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DEC RID: 3564
	[NullableContext(1)]
	[Nullable(0)]
	public class IPointLightOperations
	{
		// Token: 0x060050BE RID: 20670 RVA: 0x000C74D0 File Offset: 0x000C56D0
		public static IPointLightOperations Create(IPointLightOperations? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointLightOperations
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x060050BF RID: 20671 RVA: 0x000C74EF File Offset: 0x000C56EF
		public virtual IEntityMatch Match
		{
			get
			{
				if (this._MatchInited)
				{
					return this._MatchCache;
				}
				this._MatchInited = true;
				this._MatchCache = IEntityMatch.Create(this.Instance.Match);
				return this._MatchCache;
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x060050C0 RID: 20672 RVA: 0x000C7523 File Offset: 0x000C5723
		public virtual string SwitchToTargetState
		{
			get
			{
				return this.Instance.SwitchToTargetState;
			}
		}

		// Token: 0x04002E5D RID: 11869
		private IPointLightOperations Instance;

		// Token: 0x04002E5E RID: 11870
		[Nullable(2)]
		private IEntityMatch _MatchCache;

		// Token: 0x04002E5F RID: 11871
		private bool _MatchInited;
	}
}
