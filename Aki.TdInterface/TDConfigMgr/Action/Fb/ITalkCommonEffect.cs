using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200253A RID: 9530
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkCommonEffect : ITalkEffectType
	{
		// Token: 0x0600D462 RID: 54370 RVA: 0x001F7082 File Offset: 0x001F5282
		public static ITalkCommonEffect Create(ITalkCommonEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkCommonEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x0600D463 RID: 54371 RVA: 0x001F70A1 File Offset: 0x001F52A1
		public override ETalkEffectType Type
		{
			get
			{
				return (ETalkEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x0600D464 RID: 54372 RVA: 0x001F70AE File Offset: 0x001F52AE
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x0600D465 RID: 54373 RVA: 0x001F70BB File Offset: 0x001F52BB
		public virtual IAbsolutePos2 Pos2
		{
			get
			{
				if (this._Pos2Inited)
				{
					return this._Pos2Cache;
				}
				this._Pos2Inited = true;
				this._Pos2Cache = IAbsolutePos2.Create(this.Instance.Pos2);
				return this._Pos2Cache;
			}
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x0600D466 RID: 54374 RVA: 0x001F70F0 File Offset: 0x001F52F0
		public virtual bool? StartFromLoop
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.StartFromLoop);
			}
		}

		// Token: 0x04007456 RID: 29782
		private ITalkCommonEffect Instance;

		// Token: 0x04007457 RID: 29783
		[Nullable(2)]
		private IAbsolutePos2 _Pos2Cache;

		// Token: 0x04007458 RID: 29784
		private bool _Pos2Inited;
	}
}
