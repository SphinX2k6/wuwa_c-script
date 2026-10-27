using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200281B RID: 10267
	[NullableContext(1)]
	[Nullable(0)]
	public class NpcLeisureInteract : ActionParams
	{
		// Token: 0x0600E3C2 RID: 58306 RVA: 0x00218DF2 File Offset: 0x00216FF2
		public static NpcLeisureInteract Create(INpcLeisureInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NpcLeisureInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700454E RID: 17742
		// (get) Token: 0x0600E3C3 RID: 58307 RVA: 0x00218E11 File Offset: 0x00217011
		public virtual INpcLeisureInteractType Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = ActionReadHelper.ReadNpcLeisureInteract_Option(this.Instance);
				return this._OptionCache;
			}
		}

		// Token: 0x04007E11 RID: 32273
		private INpcLeisureInteract Instance;

		// Token: 0x04007E12 RID: 32274
		private INpcLeisureInteractType _OptionCache;

		// Token: 0x04007E13 RID: 32275
		private bool _OptionInited;
	}
}
