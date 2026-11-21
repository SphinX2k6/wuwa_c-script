using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039E1 RID: 14817
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMonsterMarkItem : TrapDefenseMarkItem
	{
		// Token: 0x060262E4 RID: 156388 RVA: 0x00AB5374 File Offset: 0x00AB3574
		[NullableContext(2)]
		public TrapDefenseMonsterMarkItem(int markId, object extraParam = null) : base(markId, extraParam)
		{
			if (extraParam is ETrapDefenseEnemyType)
			{
				ETrapDefenseEnemyType enemyTypeInner = (ETrapDefenseEnemyType)extraParam;
				this.EnemyTypeInner = enemyTypeInner;
				return;
			}
			this.EnemyTypeInner = ETrapDefenseEnemyType.Phantom;
		}

		// Token: 0x17004DED RID: 19949
		// (get) Token: 0x060262E5 RID: 156389 RVA: 0x00AB53AE File Offset: 0x00AB35AE
		public override TrapDefenseDefine.ETrapDefenseMarkType MarkType
		{
			get
			{
				return TrapDefenseDefine.ETrapDefenseMarkType.Phantom;
			}
		}

		// Token: 0x17004DEE RID: 19950
		// (get) Token: 0x060262E6 RID: 156390 RVA: 0x00AB53B1 File Offset: 0x00AB35B1
		public override Vector WorldPosition
		{
			get
			{
				return this.WorldPositionVector;
			}
		}

		// Token: 0x17004DEF RID: 19951
		// (get) Token: 0x060262E7 RID: 156391 RVA: 0x00AB53B9 File Offset: 0x00AB35B9
		// (set) Token: 0x060262E8 RID: 156392 RVA: 0x00AB53C1 File Offset: 0x00AB35C1
		public ETrapDefenseEnemyType EnemyType
		{
			get
			{
				return this.EnemyTypeInner;
			}
			set
			{
				this.EnemyTypeInner = value;
			}
		}

		// Token: 0x060262E9 RID: 156393 RVA: 0x00AB53CA File Offset: 0x00AB35CA
		protected override void OnInitialize()
		{
			this.EnableCachePosition = false;
		}

		// Token: 0x060262EA RID: 156394 RVA: 0x00AB53D3 File Offset: 0x00AB35D3
		public void SetWorldPosition(float x, float y, float z)
		{
			this.WorldPositionVector.Set((double)x, (double)y, (double)z);
		}

		// Token: 0x04014F1F RID: 85791
		private ETrapDefenseEnemyType EnemyTypeInner = ETrapDefenseEnemyType.Phantom;
	}
}
