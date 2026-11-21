using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SolarSchool;

namespace CSharpScript.Game.Module.ActivityCondition
{
	// Token: 0x02005A87 RID: 23175
	public class SolarSchoolConditionInfluenceLevel : ActivityConditionBase
	{
		// Token: 0x17006CCB RID: 27851
		// (get) Token: 0x060391F8 RID: 233976 RVA: 0x01000283 File Offset: 0x00FFE483
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060391F9 RID: 233977 RVA: 0x01000288 File Offset: 0x00FFE488
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.Influence = (ESolarSchoolInfluence)p.GetInt("InfluenceId", 0);
			this.IsValidInfluence = (this.Influence != ESolarSchoolInfluence.None && Enum.IsDefined(typeof(ESolarSchoolInfluence), this.Influence));
			this.HasExactLevel = p.Has("Level");
			this.ExactLevel = p.GetInt("Level", 0);
			this.MinLevel = p.GetInt("Min", int.MinValue);
			this.MaxLevel = p.GetInt("Max", int.MaxValue);
			return true;
		}

		// Token: 0x060391FA RID: 233978 RVA: 0x01000324 File Offset: 0x00FFE524
		protected override bool OnCheck()
		{
			if (!this.IsValidInfluence)
			{
				return false;
			}
			int conditionInfluenceLevel = SolarSchoolGamePlayModel.Instance.GetConditionInfluenceLevel(this.Influence);
			if (!this.HasExactLevel)
			{
				return conditionInfluenceLevel >= this.MinLevel && conditionInfluenceLevel <= this.MaxLevel;
			}
			return conditionInfluenceLevel == this.ExactLevel;
		}

		// Token: 0x060391FB RID: 233979 RVA: 0x01000375 File Offset: 0x00FFE575
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolInfluenceChanged, new Action(this.OnInfluenceChanged));
		}

		// Token: 0x060391FC RID: 233980 RVA: 0x01000393 File Offset: 0x00FFE593
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolInfluenceChanged, new Action(this.OnInfluenceChanged));
		}

		// Token: 0x060391FD RID: 233981 RVA: 0x010003B1 File Offset: 0x00FFE5B1
		protected override void OnClear()
		{
			this.Influence = ESolarSchoolInfluence.None;
			this.IsValidInfluence = false;
			this.HasExactLevel = false;
			this.ExactLevel = 0;
			this.MinLevel = 0;
			this.MaxLevel = 0;
		}

		// Token: 0x060391FE RID: 233982 RVA: 0x010003DD File Offset: 0x00FFE5DD
		private void OnInfluenceChanged()
		{
			base.FinishExecute();
		}

		// Token: 0x0401E0EC RID: 123116
		private ESolarSchoolInfluence Influence;

		// Token: 0x0401E0ED RID: 123117
		private bool IsValidInfluence;

		// Token: 0x0401E0EE RID: 123118
		private bool HasExactLevel;

		// Token: 0x0401E0EF RID: 123119
		private int ExactLevel;

		// Token: 0x0401E0F0 RID: 123120
		private int MinLevel;

		// Token: 0x0401E0F1 RID: 123121
		private int MaxLevel;
	}
}
