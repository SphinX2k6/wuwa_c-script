using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297F RID: 10623
	public class SetAssistCharacterPos : ActionParams
	{
		// Token: 0x0600EBA5 RID: 60325 RVA: 0x0022B5D7 File Offset: 0x002297D7
		public static SetAssistCharacterPos Create(ISetAssistCharacterPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetAssistCharacterPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004555 RID: 17749
		// (get) Token: 0x0600EBA6 RID: 60326 RVA: 0x0022B5F6 File Offset: 0x002297F6
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004556 RID: 17750
		// (get) Token: 0x0600EBA7 RID: 60327 RVA: 0x0022B603 File Offset: 0x00229803
		public virtual PosA Pos
		{
			get
			{
				if (this._PosInited)
				{
					return this._PosCache;
				}
				this._PosInited = true;
				this._PosCache = PosA.Create(this.Instance.Pos);
				return this._PosCache;
			}
		}

		// Token: 0x040081BF RID: 33215
		private ISetAssistCharacterPos Instance;

		// Token: 0x040081C0 RID: 33216
		[Nullable(2)]
		private PosA _PosCache;

		// Token: 0x040081C1 RID: 33217
		private bool _PosInited;
	}
}
