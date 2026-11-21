using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DBE RID: 3518
	public class IPasserbyNpcFixIntervalSpawn : IPasserbyNpcSpawnBase
	{
		// Token: 0x06004FEC RID: 20460 RVA: 0x000C6B4A File Offset: 0x000C4D4A
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

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x000C6B69 File Offset: 0x000C4D69
		public override EPasserbyNpcSpawnType Type
		{
			get
			{
				return (EPasserbyNpcSpawnType)this.Instance.Type;
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x06004FEE RID: 20462 RVA: 0x000C6B76 File Offset: 0x000C4D76
		public override int MaxSpawnCount
		{
			get
			{
				return this.Instance.MaxSpawnCount;
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x06004FEF RID: 20463 RVA: 0x000C6B84 File Offset: 0x000C4D84
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

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x06004FF0 RID: 20464 RVA: 0x000C6BBA File Offset: 0x000C4DBA
		public virtual float Interval
		{
			get
			{
				return this.Instance.Interval;
			}
		}

		// Token: 0x04002D8B RID: 11659
		private IPasserbyNpcFixIntervalSpawn Instance;
	}
}
