using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001345 RID: 4933
	public class IMonsterPointEntityConfig
	{
		// Token: 0x0600710B RID: 28939 RVA: 0x0011093F File Offset: 0x0010EB3F
		[NullableContext(1)]
		public static IMonsterPointEntityConfig Create(IMonsterPointEntityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterPointEntityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x0600710C RID: 28940 RVA: 0x0011095E File Offset: 0x0010EB5E
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x0600710D RID: 28941 RVA: 0x0011096B File Offset: 0x0010EB6B
		public virtual int Point
		{
			get
			{
				return this.Instance.Point;
			}
		}

		// Token: 0x04004143 RID: 16707
		private IMonsterPointEntityConfig Instance;
	}
}
