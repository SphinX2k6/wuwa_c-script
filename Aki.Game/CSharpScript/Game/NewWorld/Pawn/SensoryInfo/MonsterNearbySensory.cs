using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.Pawn.Controllers;

namespace CSharpScript.Game.NewWorld.Pawn.SensoryInfo
{
	// Token: 0x020061E2 RID: 25058
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterNearbySensory : BaseSensoryInfo
	{
		// Token: 0x1700717E RID: 29054
		// (get) Token: 0x0603C245 RID: 246341 RVA: 0x0111DC8E File Offset: 0x0111BE8E
		public override ESensoryInfoType SensoryInfoType
		{
			get
			{
				return ESensoryInfoType.EnterAndExit;
			}
		}

		// Token: 0x0603C246 RID: 246342 RVA: 0x0111DC91 File Offset: 0x0111BE91
		protected override void OnInit(params object[] @params)
		{
			this.SensoryRange = (double)((float)@params[0]);
		}

		// Token: 0x0603C247 RID: 246343 RVA: 0x0111DCA2 File Offset: 0x0111BEA2
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0603C248 RID: 246344 RVA: 0x0111DCA4 File Offset: 0x0111BEA4
		protected override void OnClear()
		{
			this.LastFindEntities.Clear();
			this.CacheEntityList.Clear();
			this.OnEnterSensoryRange = null;
			this.OnExitSensoryRange = null;
		}

		// Token: 0x0603C249 RID: 246345 RVA: 0x0111DCCA File Offset: 0x0111BECA
		public override void ClearCacheList()
		{
			this.CacheEntityList.Clear();
		}

		// Token: 0x0603C24A RID: 246346 RVA: 0x0111DCD8 File Offset: 0x0111BED8
		public override bool CheckEntity(Entity entity)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			return component != null && component.IsMonster() && MonsterNearbySensory.MonsterCamp.Contains(component.GetEntityCamp());
		}

		// Token: 0x0603C24B RID: 246347 RVA: 0x0111DD0C File Offset: 0x0111BF0C
		public override void EnterRange(Entity entity)
		{
			this.InRange = true;
			if (!this.LastFindEntities.Contains(entity.Id) && (this.SensoryInfoType & ESensoryInfoType.EnterAndExit) != (ESensoryInfoType)0 && this.OnEnterSensoryRange != null && !this.OnEnterSensoryRange(entity))
			{
				return;
			}
			this.CacheEntityList.Add(entity.Id);
			this.LastFindEntities.Remove(entity.Id);
		}

		// Token: 0x0603C24C RID: 246348 RVA: 0x0111DD78 File Offset: 0x0111BF78
		public override void ExitRange()
		{
			this.InRange = (this.CacheEntityList.Count != 0);
			if ((this.SensoryInfoType & ESensoryInfoType.EnterAndExit) != (ESensoryInfoType)0)
			{
				foreach (int obj in this.LastFindEntities)
				{
					Action<int> onExitSensoryRange = this.OnExitSensoryRange;
					if (onExitSensoryRange != null)
					{
						onExitSensoryRange(obj);
					}
				}
			}
			this.LastFindEntities.Clear();
			foreach (int item in this.CacheEntityList)
			{
				this.LastFindEntities.Add(item);
			}
		}

		// Token: 0x0401FD37 RID: 130359
		[StaticVariableRuleIgnore]
		private static readonly HashSet<ECamp> MonsterCamp = new HashSet<ECamp>
		{
			ECamp.Monster,
			ECamp.liufangzhe_e,
			ECamp.Common_enemy
		};

		// Token: 0x0401FD38 RID: 130360
		protected readonly List<int> CacheEntityList = new List<int>();

		// Token: 0x0401FD39 RID: 130361
		protected readonly HashSet<int> LastFindEntities = new HashSet<int>();

		// Token: 0x0401FD3A RID: 130362
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<Entity, bool> OnEnterSensoryRange;

		// Token: 0x0401FD3B RID: 130363
		[Nullable(2)]
		public Action<int> OnExitSensoryRange;
	}
}
