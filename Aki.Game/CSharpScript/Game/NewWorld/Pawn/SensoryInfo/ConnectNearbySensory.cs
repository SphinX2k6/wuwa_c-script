using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Pawn.SensoryInfo
{
	// Token: 0x02007060 RID: 28768
	[NullableContext(1)]
	[Nullable(0)]
	public class ConnectNearbySensory : BaseSensoryInfo
	{
		// Token: 0x17009BF9 RID: 39929
		// (get) Token: 0x06046043 RID: 286787 RVA: 0x01173EDE File Offset: 0x011720DE
		public override ERangePerceptionType RangePerceptionType
		{
			get
			{
				return ERangePerceptionType.Dynamic;
			}
		}

		// Token: 0x06046044 RID: 286788 RVA: 0x01173EE1 File Offset: 0x011720E1
		protected override void OnInit(params object[] @params)
		{
			this.SensoryRange = Convert.ToDouble(@params[0]);
		}

		// Token: 0x06046045 RID: 286789 RVA: 0x01173EF1 File Offset: 0x011720F1
		protected override void OnClear()
		{
			this.LastFindEntities.Clear();
			this.CacheEntityList.Clear();
			this.OnEnterSensoryRange = null;
			this.OnExitSensoryRange = null;
		}

		// Token: 0x06046046 RID: 286790 RVA: 0x01173F17 File Offset: 0x01172117
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x06046047 RID: 286791 RVA: 0x01173F19 File Offset: 0x01172119
		public override bool CheckEntity(Entity entity)
		{
			return true;
		}

		// Token: 0x06046048 RID: 286792 RVA: 0x01173F1C File Offset: 0x0117211C
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

		// Token: 0x06046049 RID: 286793 RVA: 0x01173F80 File Offset: 0x01172180
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

		// Token: 0x0604604A RID: 286794 RVA: 0x01174054 File Offset: 0x01172254
		public void OnEntityExitConnectRange(int entityId)
		{
			this.LastFindEntities.Remove(entityId);
			this.CacheEntityList.Remove(entityId);
		}

		// Token: 0x04024A7D RID: 150141
		protected readonly HashSet<int> CacheEntityList = new HashSet<int>();

		// Token: 0x04024A7E RID: 150142
		protected readonly HashSet<int> LastFindEntities = new HashSet<int>();

		// Token: 0x04024A7F RID: 150143
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<Entity, bool> OnEnterSensoryRange;

		// Token: 0x04024A80 RID: 150144
		[Nullable(2)]
		public Action<int> OnExitSensoryRange;
	}
}
