using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Pawn.SensoryInfo
{
	// Token: 0x020061E1 RID: 25057
	[NullableContext(1)]
	[Nullable(0)]
	public class ConnectNearbySensory : BaseSensoryInfo
	{
		// Token: 0x1700717D RID: 29053
		// (get) Token: 0x0603C23C RID: 246332 RVA: 0x0111DADD File Offset: 0x0111BCDD
		public override ERangePerceptionType RangePerceptionType
		{
			get
			{
				return ERangePerceptionType.Dynamic;
			}
		}

		// Token: 0x0603C23D RID: 246333 RVA: 0x0111DAE0 File Offset: 0x0111BCE0
		protected override void OnInit(params object[] @params)
		{
			this.SensoryRange = Convert.ToDouble(@params[0]);
		}

		// Token: 0x0603C23E RID: 246334 RVA: 0x0111DAF0 File Offset: 0x0111BCF0
		protected override void OnClear()
		{
			this.LastFindEntities.Clear();
			this.CacheEntityList.Clear();
			this.OnEnterSensoryRange = null;
			this.OnExitSensoryRange = null;
		}

		// Token: 0x0603C23F RID: 246335 RVA: 0x0111DB16 File Offset: 0x0111BD16
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0603C240 RID: 246336 RVA: 0x0111DB18 File Offset: 0x0111BD18
		public override bool CheckEntity(Entity entity)
		{
			return true;
		}

		// Token: 0x0603C241 RID: 246337 RVA: 0x0111DB1C File Offset: 0x0111BD1C
		public override void EnterRange(Entity entity)
		{
			this.InRange = true;
			if (!this.LastFindEntities.Contains(entity.Id) && this.OnEnterSensoryRange != null && !this.OnEnterSensoryRange(entity))
			{
				return;
			}
			this.CacheEntityList.Add(entity.Id);
			this.LastFindEntities.Remove(entity.Id);
		}

		// Token: 0x0603C242 RID: 246338 RVA: 0x0111DB80 File Offset: 0x0111BD80
		public override void ExitRange()
		{
			this.InRange = (this.CacheEntityList.Count != 0);
			foreach (int num in this.LastFindEntities)
			{
				Action<int> onExitSensoryRange = this.OnExitSensoryRange;
				if (onExitSensoryRange != null)
				{
					onExitSensoryRange(num);
				}
				this.CacheEntityList.Remove(num);
			}
			this.LastFindEntities.Clear();
			foreach (int item in this.CacheEntityList)
			{
				this.LastFindEntities.Add(item);
			}
		}

		// Token: 0x0603C243 RID: 246339 RVA: 0x0111DC54 File Offset: 0x0111BE54
		public void OnEntityExitConnectRange(int entityId)
		{
			this.LastFindEntities.Remove(entityId);
			this.CacheEntityList.Remove(entityId);
		}

		// Token: 0x0401FD33 RID: 130355
		protected readonly HashSet<int> CacheEntityList = new HashSet<int>();

		// Token: 0x0401FD34 RID: 130356
		protected readonly HashSet<int> LastFindEntities = new HashSet<int>();

		// Token: 0x0401FD35 RID: 130357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<Entity, bool> OnEnterSensoryRange;

		// Token: 0x0401FD36 RID: 130358
		[Nullable(2)]
		public Action<int> OnExitSensoryRange;
	}
}
