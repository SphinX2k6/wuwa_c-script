using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001352 RID: 4946
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechaTrackScoreMechanismStateType
	{
		// Token: 0x0600714B RID: 29003 RVA: 0x001111FF File Offset: 0x0010F3FF
		public static IMechaTrackScoreMechanismStateType Create(IMechaTrackScoreMechanismStateType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackScoreMechanismStateType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x0600714C RID: 29004 RVA: 0x0011121E File Offset: 0x0010F41E
		public virtual IStaticEntitiyMatch EntitiyMatch
		{
			get
			{
				if (this._EntitiyMatchInited)
				{
					return this._EntitiyMatchCache;
				}
				this._EntitiyMatchInited = true;
				this._EntitiyMatchCache = IStaticEntitiyMatch.Create(this.Instance.EntitiyMatch);
				return this._EntitiyMatchCache;
			}
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x0600714D RID: 29005 RVA: 0x00111252 File Offset: 0x0010F452
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x0600714E RID: 29006 RVA: 0x0011125F File Offset: 0x0010F45F
		public virtual int ScoreId
		{
			get
			{
				return this.Instance.ScoreId;
			}
		}

		// Token: 0x0400416C RID: 16748
		private IMechaTrackScoreMechanismStateType Instance;

		// Token: 0x0400416D RID: 16749
		[Nullable(2)]
		private IStaticEntitiyMatch _EntitiyMatchCache;

		// Token: 0x0400416E RID: 16750
		private bool _EntitiyMatchInited;
	}
}
