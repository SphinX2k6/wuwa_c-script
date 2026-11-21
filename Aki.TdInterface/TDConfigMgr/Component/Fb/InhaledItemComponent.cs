using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E61 RID: 3681
	public class InhaledItemComponent : IComponentBase
	{
		// Token: 0x06005333 RID: 21299 RVA: 0x000CD60E File Offset: 0x000CB80E
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

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06005334 RID: 21300 RVA: 0x000CD630 File Offset: 0x000CB830
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

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06005335 RID: 21301 RVA: 0x000CD668 File Offset: 0x000CB868
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06005336 RID: 21302 RVA: 0x000CD67E File Offset: 0x000CB87E
		public virtual int InhaledStrength
		{
			get
			{
				return this.Instance.InhaledStrength;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x06005337 RID: 21303 RVA: 0x000CD68C File Offset: 0x000CB88C
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

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x06005338 RID: 21304 RVA: 0x000CD6C2 File Offset: 0x000CB8C2
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

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06005339 RID: 21305 RVA: 0x000CD6F6 File Offset: 0x000CB8F6
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

		// Token: 0x04002F82 RID: 12162
		private IInhaledItemComponent Instance;

		// Token: 0x04002F83 RID: 12163
		[Nullable(2)]
		private IInhaledPerformance _InhaledPerformanceCache;

		// Token: 0x04002F84 RID: 12164
		private bool _InhaledPerformanceInited;

		// Token: 0x04002F85 RID: 12165
		private IInhaledPerResultType _InhaledPerResultCache;

		// Token: 0x04002F86 RID: 12166
		private bool _InhaledPerResultInited;
	}
}
