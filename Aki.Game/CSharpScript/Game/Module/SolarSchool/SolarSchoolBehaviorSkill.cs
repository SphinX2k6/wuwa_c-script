using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005962 RID: 22882
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolBehaviorSkill : IEquatable<SolarSchoolBehaviorSkill>
	{
		// Token: 0x060385D8 RID: 230872 RVA: 0x00FC2A0D File Offset: 0x00FC0C0D
		public SolarSchoolBehaviorSkill(SolarSchoolRole Role, SolarSchoolRoleFavorLevel FavorLevel, SolarSchoolBuff Buff)
		{
			this.Role = Role;
			this.FavorLevel = FavorLevel;
			this.Buff = Buff;
			base..ctor();
		}

		// Token: 0x17006BE4 RID: 27620
		// (get) Token: 0x060385D9 RID: 230873 RVA: 0x00FC2A2A File Offset: 0x00FC0C2A
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SolarSchoolBehaviorSkill);
			}
		}

		// Token: 0x17006BE5 RID: 27621
		// (get) Token: 0x060385DA RID: 230874 RVA: 0x00FC2A36 File Offset: 0x00FC0C36
		// (set) Token: 0x060385DB RID: 230875 RVA: 0x00FC2A3E File Offset: 0x00FC0C3E
		public SolarSchoolRole Role { get; set; }

		// Token: 0x17006BE6 RID: 27622
		// (get) Token: 0x060385DC RID: 230876 RVA: 0x00FC2A47 File Offset: 0x00FC0C47
		// (set) Token: 0x060385DD RID: 230877 RVA: 0x00FC2A4F File Offset: 0x00FC0C4F
		public SolarSchoolRoleFavorLevel FavorLevel { get; set; }

		// Token: 0x17006BE7 RID: 27623
		// (get) Token: 0x060385DE RID: 230878 RVA: 0x00FC2A58 File Offset: 0x00FC0C58
		// (set) Token: 0x060385DF RID: 230879 RVA: 0x00FC2A60 File Offset: 0x00FC0C60
		public SolarSchoolBuff Buff { get; set; }

		// Token: 0x060385E0 RID: 230880 RVA: 0x00FC2A6C File Offset: 0x00FC0C6C
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SolarSchoolBehaviorSkill");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x060385E1 RID: 230881 RVA: 0x00FC2AB8 File Offset: 0x00FC0CB8
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Role = ");
			builder.Append(this.Role.ToString());
			builder.Append(", FavorLevel = ");
			builder.Append(this.FavorLevel.ToString());
			builder.Append(", Buff = ");
			builder.Append(this.Buff.ToString());
			return true;
		}

		// Token: 0x060385E2 RID: 230882 RVA: 0x00FC2B40 File Offset: 0x00FC0D40
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(SolarSchoolBehaviorSkill left, SolarSchoolBehaviorSkill right)
		{
			return !(left == right);
		}

		// Token: 0x060385E3 RID: 230883 RVA: 0x00FC2B4C File Offset: 0x00FC0D4C
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(SolarSchoolBehaviorSkill left, SolarSchoolBehaviorSkill right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x060385E4 RID: 230884 RVA: 0x00FC2B60 File Offset: 0x00FC0D60
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<SolarSchoolRole>.Default.GetHashCode(this.<Role>k__BackingField)) * -1521134295 + EqualityComparer<SolarSchoolRoleFavorLevel>.Default.GetHashCode(this.<FavorLevel>k__BackingField)) * -1521134295 + EqualityComparer<SolarSchoolBuff>.Default.GetHashCode(this.<Buff>k__BackingField);
		}

		// Token: 0x060385E5 RID: 230885 RVA: 0x00FC2BC2 File Offset: 0x00FC0DC2
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as SolarSchoolBehaviorSkill);
		}

		// Token: 0x060385E6 RID: 230886 RVA: 0x00FC2BD0 File Offset: 0x00FC0DD0
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(SolarSchoolBehaviorSkill other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<SolarSchoolRole>.Default.Equals(this.<Role>k__BackingField, other.<Role>k__BackingField) && EqualityComparer<SolarSchoolRoleFavorLevel>.Default.Equals(this.<FavorLevel>k__BackingField, other.<FavorLevel>k__BackingField) && EqualityComparer<SolarSchoolBuff>.Default.Equals(this.<Buff>k__BackingField, other.<Buff>k__BackingField));
		}

		// Token: 0x060385E8 RID: 230888 RVA: 0x00FC2C49 File Offset: 0x00FC0E49
		[CompilerGenerated]
		private SolarSchoolBehaviorSkill(SolarSchoolBehaviorSkill original)
		{
			this.Role = original.<Role>k__BackingField;
			this.FavorLevel = original.<FavorLevel>k__BackingField;
			this.Buff = original.<Buff>k__BackingField;
		}

		// Token: 0x060385E9 RID: 230889 RVA: 0x00FC2C75 File Offset: 0x00FC0E75
		[CompilerGenerated]
		public void Deconstruct(out SolarSchoolRole Role, out SolarSchoolRoleFavorLevel FavorLevel, out SolarSchoolBuff Buff)
		{
			Role = this.Role;
			FavorLevel = this.FavorLevel;
			Buff = this.Buff;
		}
	}
}
