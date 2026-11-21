using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x0200547C RID: 21628
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillRunner
	{
		// Token: 0x06035B3B RID: 219963 RVA: 0x00F01E98 File Offset: 0x00F00098
		public SkillRunner(EnergyPool energy, List<ISkill> skills)
		{
			this.Released = new bool[this.<skills>P.Count];
			this.FullNode = SkillRunner.MaxNode(this.<skills>P);
			base..ctor();
		}

		// Token: 0x1700686A RID: 26730
		// (get) Token: 0x06035B3C RID: 219964 RVA: 0x00F01ED5 File Offset: 0x00F000D5
		public int FullNode { get; }

		// Token: 0x06035B3D RID: 219965 RVA: 0x00F01EE0 File Offset: 0x00F000E0
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

		// Token: 0x06035B3E RID: 219966 RVA: 0x00F01F3C File Offset: 0x00F0013C
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

		// Token: 0x06035B3F RID: 219967 RVA: 0x00F01F9E File Offset: 0x00F0019E
		public bool IsUltimate(ISkill skill)
		{
			return this.FullNode > 0 && skill.EnergyNode >= this.FullNode;
		}

		// Token: 0x06035B40 RID: 219968 RVA: 0x00F01FBC File Offset: 0x00F001BC
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

		// Token: 0x06035B41 RID: 219969 RVA: 0x00F02000 File Offset: 0x00F00200
		public void Reset()
		{
			for (int i = 0; i < this.Released.Length; i++)
			{
				this.Released[i] = false;
			}
		}

		// Token: 0x06035B42 RID: 219970 RVA: 0x00F0202C File Offset: 0x00F0022C
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

		// Token: 0x0401C674 RID: 116340
		[CompilerGenerated]
		private EnergyPool <energy>P = energy;

		// Token: 0x0401C675 RID: 116341
		[CompilerGenerated]
		private List<ISkill> <skills>P = skills;

		// Token: 0x0401C676 RID: 116342
		private readonly bool[] Released;
	}
}
