using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014A2 RID: 5282
	public class IMechaTrackScoreMechanismStateType
	{
		// Token: 0x060077EB RID: 30699 RVA: 0x0011F76B File Offset: 0x0011D96B
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

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x060077EC RID: 30700 RVA: 0x0011F78A File Offset: 0x0011D98A
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

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x060077ED RID: 30701 RVA: 0x0011F7BE File Offset: 0x0011D9BE
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x060077EE RID: 30702 RVA: 0x0011F7CB File Offset: 0x0011D9CB
		public virtual int ScoreId
		{
			get
			{
				return this.Instance.ScoreId;
			}
		}

		// Token: 0x040044E8 RID: 17640
		private IMechaTrackScoreMechanismStateType Instance;

		// Token: 0x040044E9 RID: 17641
		[Nullable(2)]
		private IStaticEntitiyMatch _EntitiyMatchCache;

		// Token: 0x040044EA RID: 17642
		private bool _EntitiyMatchInited;
	}
}
