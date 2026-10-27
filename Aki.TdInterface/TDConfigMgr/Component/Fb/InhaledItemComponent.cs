using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D67 RID: 3431
	[NullableContext(1)]
	[Nullable(0)]
	public class InhaledItemComponent : IComponentBase
	{
		// Token: 0x06004E17 RID: 19991 RVA: 0x000C1ECA File Offset: 0x000C00CA
		public static InhaledItemComponent Create(IInhaledItemComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InhaledItemComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x06004E18 RID: 19992 RVA: 0x000C1EEC File Offset: 0x000C00EC
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x06004E19 RID: 19993 RVA: 0x000C1F24 File Offset: 0x000C0124
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x06004E1A RID: 19994 RVA: 0x000C1F3A File Offset: 0x000C013A
		public virtual int InhaledStrength
		{
			get
			{
				return this.Instance.InhaledStrength;
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x06004E1B RID: 19995 RVA: 0x000C1F48 File Offset: 0x000C0148
		public virtual int? InhaledInterruptionRecoveryTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.InhaledInterruptionRecoveryTime);
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x06004E1C RID: 19996 RVA: 0x000C1F7E File Offset: 0x000C017E
		public virtual IInhaledPerformance InhaledPerformance
		{
			get
			{
				if (this._InhaledPerformanceInited)
				{
					return this._InhaledPerformanceCache;
				}
				this._InhaledPerformanceInited = true;
				this._InhaledPerformanceCache = IInhaledPerformance.Create(this.Instance.InhaledPerformance);
				return this._InhaledPerformanceCache;
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x06004E1D RID: 19997 RVA: 0x000C1FB2 File Offset: 0x000C01B2
		public virtual IInhaledPerResultType InhaledPerResult
		{
			get
			{
				if (this._InhaledPerResultInited)
				{
					return this._InhaledPerResultCache;
				}
				this._InhaledPerResultInited = true;
				this._InhaledPerResultCache = ComponentReadHelper.ReadInhaledItemComponent_InhaledPerResult(this.Instance);
				return this._InhaledPerResultCache;
			}
		}

		// Token: 0x04002CC2 RID: 11458
		private IInhaledItemComponent Instance;

		// Token: 0x04002CC3 RID: 11459
		[Nullable(2)]
		private IInhaledPerformance _InhaledPerformanceCache;

		// Token: 0x04002CC4 RID: 11460
		private bool _InhaledPerformanceInited;

		// Token: 0x04002CC5 RID: 11461
		private IInhaledPerResultType _InhaledPerResultCache;

		// Token: 0x04002CC6 RID: 11462
		private bool _InhaledPerResultInited;
	}
}
