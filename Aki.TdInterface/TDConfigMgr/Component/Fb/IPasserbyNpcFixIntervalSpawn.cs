using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD6 RID: 3286
	public class IPasserbyNpcFixIntervalSpawn : IPasserbyNpcSpawnBase
	{
		// Token: 0x06004B1F RID: 19231 RVA: 0x000BBD22 File Offset: 0x000B9F22
		[NullableContext(1)]
		public static IPasserbyNpcFixIntervalSpawn Create(IPasserbyNpcFixIntervalSpawn? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcFixIntervalSpawn
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06004B20 RID: 19232 RVA: 0x000BBD41 File Offset: 0x000B9F41
		public override EPasserbyNpcSpawnType Type
		{
			get
			{
				return (EPasserbyNpcSpawnType)this.Instance.Type;
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06004B21 RID: 19233 RVA: 0x000BBD4E File Offset: 0x000B9F4E
		public override int MaxSpawnCount
		{
			get
			{
				return this.Instance.MaxSpawnCount;
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06004B22 RID: 19234 RVA: 0x000BBD5C File Offset: 0x000B9F5C
		public override int? MinDistance
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

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06004B23 RID: 19235 RVA: 0x000BBD92 File Offset: 0x000B9F92
		public virtual float Interval
		{
			get
			{
				return this.Instance.Interval;
			}
		}

		// Token: 0x04002AF9 RID: 11001
		private IPasserbyNpcFixIntervalSpawn Instance;
	}
}
