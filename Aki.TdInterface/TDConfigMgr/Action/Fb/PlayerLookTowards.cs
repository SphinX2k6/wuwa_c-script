using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200262F RID: 9775
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerLookTowards : ActionParams
	{
		// Token: 0x0600DB5A RID: 56154 RVA: 0x0020A7DA File Offset: 0x002089DA
		public static PlayerLookTowards Create(IPlayerLookTowards? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayerLookTowards
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040BE RID: 16574
		// (get) Token: 0x0600DB5B RID: 56155 RVA: 0x0020A7F9 File Offset: 0x002089F9
		public virtual ICharacterLookAtData Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadPlayerLookTowards_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x040079D9 RID: 31193
		private IPlayerLookTowards Instance;

		// Token: 0x040079DA RID: 31194
		private ICharacterLookAtData _TargetCache;

		// Token: 0x040079DB RID: 31195
		private bool _TargetInited;
	}
}
