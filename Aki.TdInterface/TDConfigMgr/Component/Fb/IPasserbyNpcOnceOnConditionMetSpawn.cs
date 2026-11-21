using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC5 RID: 3525
	public class IPasserbyNpcOnceOnConditionMetSpawn : IPasserbyNpcSpawnBase
	{
		// Token: 0x06005009 RID: 20489 RVA: 0x000C6E51 File Offset: 0x000C5051
		public static IPasserbyNpcOnceOnConditionMetSpawn Create(IPasserbyNpcOnceOnConditionMetSpawn? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcOnceOnConditionMetSpawn
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x0600500A RID: 20490 RVA: 0x000C6E70 File Offset: 0x000C5070
		public override EPasserbyNpcSpawnType Type
		{
			get
			{
				return (EPasserbyNpcSpawnType)this.Instance.Type;
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x0600500B RID: 20491 RVA: 0x000C6E7D File Offset: 0x000C507D
		public override int MaxSpawnCount
		{
			get
			{
				return this.Instance.MaxSpawnCount;
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x0600500C RID: 20492 RVA: 0x000C6E8C File Offset: 0x000C508C
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

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x0600500D RID: 20493 RVA: 0x000C6EC2 File Offset: 0x000C50C2
		public virtual IPasserbyNpcRandomStandGenerate SpawnPos
		{
			get
			{
				if (this._SpawnPosInited)
				{
					return this._SpawnPosCache;
				}
				this._SpawnPosInited = true;
				this._SpawnPosCache = IPasserbyNpcRandomStandGenerate.Create(this.Instance.SpawnPos);
				return this._SpawnPosCache;
			}
		}

		// Token: 0x04002D9A RID: 11674
		private IPasserbyNpcOnceOnConditionMetSpawn Instance;

		// Token: 0x04002D9B RID: 11675
		[Nullable(2)]
		private IPasserbyNpcRandomStandGenerate _SpawnPosCache;

		// Token: 0x04002D9C RID: 11676
		private bool _SpawnPosInited;
	}
}
