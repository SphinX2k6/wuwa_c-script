using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EE8 RID: 3816
	public class IPointLightOperations
	{
		// Token: 0x060055E5 RID: 21989 RVA: 0x000D2D98 File Offset: 0x000D0F98
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

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x060055E6 RID: 21990 RVA: 0x000D2DB7 File Offset: 0x000D0FB7
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

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x060055E7 RID: 21991 RVA: 0x000D2DEB File Offset: 0x000D0FEB
		public virtual string SwitchToTargetState
		{
			get
			{
				return this.Instance.SwitchToTargetState;
			}
		}

		// Token: 0x04003125 RID: 12581
		private IPointLightOperations Instance;

		// Token: 0x04003126 RID: 12582
		[Nullable(2)]
		private IEntityMatch _MatchCache;

		// Token: 0x04003127 RID: 12583
		private bool _MatchInited;
	}
}
