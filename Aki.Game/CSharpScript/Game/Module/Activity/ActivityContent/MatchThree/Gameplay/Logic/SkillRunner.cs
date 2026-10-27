using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064FE RID: 25854
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillRunner
	{
		// Token: 0x06040E77 RID: 265847 RVA: 0x00FBAE68 File Offset: 0x00FB9068
		public SkillRunner(EnergyPool energy, List<ISkill> skills)
		{
			this.Released = new bool[this.<skills>P.Count];
			this.FullNode = SkillRunner.MaxNode(this.<skills>P);
			base..ctor();
		}

		// Token: 0x17009508 RID: 38152
		// (get) Token: 0x06040E78 RID: 265848 RVA: 0x00FBAEA5 File Offset: 0x00FB90A5
		public int FullNode { get; }

		// Token: 0x06040E79 RID: 265849 RVA: 0x00FBAEB0 File Offset: 0x00FB90B0
		private static int MaxNode(List<ISkill> skills)
		{
			int num = 0;
			foreach (ISkill skill in skills)
			{
				if (skill.EnergyNode > num)
				{
					num = skill.EnergyNode;
				}
			}
			return num;
		}

		// Token: 0x06040E7A RID: 265850 RVA: 0x00FBAF0C File Offset: 0x00FB910C
		[NullableContext(2)]
		public ISkill TakeReleasable()
		{
			for (int i = 0; i < this.<skills>P.Count; i++)
			{
				if (!this.Released[i] && this.<energy>P.Reached(this.<skills>P[i].EnergyNode))
				{
					this.Released[i] = true;
					return this.<skills>P[i];
				}
			}
			return null;
		}

		// Token: 0x06040E7B RID: 265851 RVA: 0x00FBAF6E File Offset: 0x00FB916E
		public bool IsUltimate(ISkill skill)
		{
			return this.FullNode > 0 && skill.EnergyNode >= this.FullNode;
		}

		// Token: 0x06040E7C RID: 265852 RVA: 0x00FBAF8C File Offset: 0x00FB918C
		public void CompleteRelease(ISkill skill)
		{
			if (!this.IsUltimate(skill))
			{
				return;
			}
			this.<energy>P.StartNewCycle(this.FullNode);
			for (int i = 0; i < this.Released.Length; i++)
			{
				this.Released[i] = false;
			}
		}

		// Token: 0x06040E7D RID: 265853 RVA: 0x00FBAFD0 File Offset: 0x00FB91D0
		public void Reset()
		{
			for (int i = 0; i < this.Released.Length; i++)
			{
				this.Released[i] = false;
			}
		}

		// Token: 0x06040E7E RID: 265854 RVA: 0x00FBAFFC File Offset: 0x00FB91FC
		public void CollectDisplays(List<SkillPointDisplayData> buffer, int displayEnergy)
		{
			buffer.Clear();
			for (int i = 0; i < this.<skills>P.Count; i++)
			{
				ISkill skill = this.<skills>P[i];
				buffer.Add(new SkillPointDisplayData(skill.EnergyNode, skill.Icon, displayEnergy >= skill.EnergyNode, this.Released[i]));
			}
			buffer.Sort((SkillPointDisplayData x, SkillPointDisplayData y) => x.EnergyNode.CompareTo(y.EnergyNode));
		}

		// Token: 0x04021D43 RID: 138563
		[CompilerGenerated]
		private EnergyPool <energy>P = energy;

		// Token: 0x04021D44 RID: 138564
		[CompilerGenerated]
		private List<ISkill> <skills>P = skills;

		// Token: 0x04021D45 RID: 138565
		private readonly bool[] Released;
	}
}
