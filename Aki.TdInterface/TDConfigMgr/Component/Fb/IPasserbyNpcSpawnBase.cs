using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD5 RID: 3285
	public class IPasserbyNpcSpawnBase
	{
		// Token: 0x06004B1A RID: 19226 RVA: 0x000BBCA9 File Offset: 0x000B9EA9
		[NullableContext(1)]
		public static IPasserbyNpcSpawnBase Create(IPasserbyNpcSpawnBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06004B1B RID: 19227 RVA: 0x000BBCC8 File Offset: 0x000B9EC8
		public virtual EPasserbyNpcSpawnType Type
		{
			get
			{
				return (EPasserbyNpcSpawnType)this.Instance.Type;
			}
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x000BBCD5 File Offset: 0x000B9ED5
		public virtual int MaxSpawnCount
		{
			get
			{
				return this.Instance.MaxSpawnCount;
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06004B1D RID: 19229 RVA: 0x000BBCE4 File Offset: 0x000B9EE4
		public virtual int? MinDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MinDistance);
			}
		}

		// Token: 0x04002AF8 RID: 11000
		private IPasserbyNpcSpawnBase Instance;
	}
}
