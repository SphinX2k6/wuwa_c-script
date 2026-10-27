using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.Pawn.Controllers;

namespace CSharpScript.Game.NewWorld.Pawn.SensoryInfo
{
	// Token: 0x02007061 RID: 28769
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterNearbySensory : BaseSensoryInfo
	{
		// Token: 0x17009BFA RID: 39930
		// (get) Token: 0x0604604C RID: 286796 RVA: 0x0117408E File Offset: 0x0117228E
		public override ESensoryInfoType SensoryInfoType
		{
			get
			{
				return ESensoryInfoType.EnterAndExit;
			}
		}

		// Token: 0x0604604D RID: 286797 RVA: 0x01174091 File Offset: 0x01172291
		protected override void OnInit(params object[] @params)
		{
			this.SensoryRange = (double)((float)@params[0]);
		}

		// Token: 0x0604604E RID: 286798 RVA: 0x011740A2 File Offset: 0x011722A2
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0604604F RID: 286799 RVA: 0x011740A4 File Offset: 0x011722A4
		protected override void OnClear()
		{
			this.LastFindEntities.Clear();
			this.CacheEntityList.Clear();
			this.OnEnterSensoryRange = null;
			this.OnExitSensoryRange = null;
		}

		// Token: 0x06046050 RID: 286800 RVA: 0x011740CA File Offset: 0x011722CA
		public override void ClearCacheList()
		{
			this.CacheEntityList.Clear();
		}

		// Token: 0x06046051 RID: 286801 RVA: 0x011740D8 File Offset: 0x011722D8
		public override bool CheckEntity(Entity entity)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			return component != null && component.IsMonster() && MonsterNearbySensory.MonsterCamp.Contains(component.GetEntityCamp());
		}

		// Token: 0x06046052 RID: 286802 RVA: 0x0117410C File Offset: 0x0117230C
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

		// Token: 0x06046053 RID: 286803 RVA: 0x01174178 File Offset: 0x01172378
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

		// Token: 0x04024A81 RID: 150145
		[StaticVariableRuleIgnore]
		private static readonly HashSet<ECamp> MonsterCamp = new HashSet<ECamp>
		{
			ECamp.Monster,
			ECamp.liufangzhe_e,
			ECamp.Common_enemy
		};

		// Token: 0x04024A82 RID: 150146
		protected readonly List<int> CacheEntityList = new List<int>();

		// Token: 0x04024A83 RID: 150147
		protected readonly HashSet<int> LastFindEntities = new HashSet<int>();

		// Token: 0x04024A84 RID: 150148
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<Entity, bool> OnEnterSensoryRange;

		// Token: 0x04024A85 RID: 150149
		[Nullable(2)]
		public Action<int> OnExitSensoryRange;
	}
}
