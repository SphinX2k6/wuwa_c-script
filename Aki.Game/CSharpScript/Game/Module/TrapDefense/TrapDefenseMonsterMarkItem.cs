using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A39 RID: 19001
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMonsterMarkItem : TrapDefenseMarkItem
	{
		// Token: 0x06031554 RID: 202068 RVA: 0x00B71400 File Offset: 0x00B6F600
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

		// Token: 0x17007A40 RID: 31296
		// (get) Token: 0x06031555 RID: 202069 RVA: 0x00B7143A File Offset: 0x00B6F63A
		public override TrapDefenseDefine.ETrapDefenseMarkType MarkType
		{
			get
			{
				return TrapDefenseDefine.ETrapDefenseMarkType.Phantom;
			}
		}

		// Token: 0x17007A41 RID: 31297
		// (get) Token: 0x06031556 RID: 202070 RVA: 0x00B7143D File Offset: 0x00B6F63D
		public override Vector WorldPosition
		{
			get
			{
				return this.WorldPositionVector;
			}
		}

		// Token: 0x17007A42 RID: 31298
		// (get) Token: 0x06031557 RID: 202071 RVA: 0x00B71445 File Offset: 0x00B6F645
		// (set) Token: 0x06031558 RID: 202072 RVA: 0x00B7144D File Offset: 0x00B6F64D
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

		// Token: 0x06031559 RID: 202073 RVA: 0x00B71456 File Offset: 0x00B6F656
		protected override void OnInitialize()
		{
			this.EnableCachePosition = false;
		}

		// Token: 0x0603155A RID: 202074 RVA: 0x00B7145F File Offset: 0x00B6F65F
		public void SetWorldPosition(float x, float y, float z)
		{
			this.WorldPositionVector.Set((double)x, (double)y, (double)z);
		}

		// Token: 0x0401A5CD RID: 107981
		private ETrapDefenseEnemyType EnemyTypeInner = ETrapDefenseEnemyType.Phantom;
	}
}
