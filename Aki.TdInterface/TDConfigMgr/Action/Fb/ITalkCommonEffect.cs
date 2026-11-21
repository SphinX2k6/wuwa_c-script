using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E1 RID: 10209
	public class ITalkCommonEffect : ITalkEffectType
	{
		// Token: 0x0600E1C2 RID: 57794 RVA: 0x00212AE2 File Offset: 0x00210CE2
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

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x0600E1C3 RID: 57795 RVA: 0x00212B01 File Offset: 0x00210D01
		public override ETalkEffectType Type
		{
			get
			{
				return (ETalkEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x0600E1C4 RID: 57796 RVA: 0x00212B0E File Offset: 0x00210D0E
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x0600E1C5 RID: 57797 RVA: 0x00212B1B File Offset: 0x00210D1B
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

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x0600E1C6 RID: 57798 RVA: 0x00212B50 File Offset: 0x00210D50
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

		// Token: 0x04007AAB RID: 31403
		private ITalkCommonEffect Instance;

		// Token: 0x04007AAC RID: 31404
		[Nullable(2)]
		private IAbsolutePos2 _Pos2Cache;

		// Token: 0x04007AAD RID: 31405
		private bool _Pos2Inited;
	}
}
