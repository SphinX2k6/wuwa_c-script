using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059F5 RID: 23029
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolRewardTipData : IEquatable<SolarSchoolRewardTipData>
	{
		// Token: 0x06038B7B RID: 232315 RVA: 0x00FDFC92 File Offset: 0x00FDDE92
		public SolarSchoolRewardTipData(ESolarSchoolRewardTipType Type, int TargetId, int Delta)
		{
			this.Type = Type;
			this.TargetId = TargetId;
			this.Delta = Delta;
			base..ctor();
		}

		// Token: 0x17006C5C RID: 27740
		// (get) Token: 0x06038B7C RID: 232316 RVA: 0x00FDFCAF File Offset: 0x00FDDEAF
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SolarSchoolRewardTipData);
			}
		}

		// Token: 0x17006C5D RID: 27741
		// (get) Token: 0x06038B7D RID: 232317 RVA: 0x00FDFCBB File Offset: 0x00FDDEBB
		// (set) Token: 0x06038B7E RID: 232318 RVA: 0x00FDFCC3 File Offset: 0x00FDDEC3
		public ESolarSchoolRewardTipType Type { get; set; }

		// Token: 0x17006C5E RID: 27742
		// (get) Token: 0x06038B7F RID: 232319 RVA: 0x00FDFCCC File Offset: 0x00FDDECC
		// (set) Token: 0x06038B80 RID: 232320 RVA: 0x00FDFCD4 File Offset: 0x00FDDED4
		public int TargetId { get; set; }

		// Token: 0x17006C5F RID: 27743
		// (get) Token: 0x06038B81 RID: 232321 RVA: 0x00FDFCDD File Offset: 0x00FDDEDD
		// (set) Token: 0x06038B82 RID: 232322 RVA: 0x00FDFCE5 File Offset: 0x00FDDEE5
		public int Delta { get; set; }

		// Token: 0x06038B83 RID: 232323 RVA: 0x00FDFCF0 File Offset: 0x00FDDEF0
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SolarSchoolRewardTipData");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06038B84 RID: 232324 RVA: 0x00FDFD3C File Offset: 0x00FDDF3C
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Type = ");
			builder.Append(this.Type.ToString());
			builder.Append(", TargetId = ");
			builder.Append(this.TargetId.ToString());
			builder.Append(", Delta = ");
			builder.Append(this.Delta.ToString());
			return true;
		}

		// Token: 0x06038B85 RID: 232325 RVA: 0x00FDFDC4 File Offset: 0x00FDDFC4
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(SolarSchoolRewardTipData left, SolarSchoolRewardTipData right)
		{
			return !(left == right);
		}

		// Token: 0x06038B86 RID: 232326 RVA: 0x00FDFDD0 File Offset: 0x00FDDFD0
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(SolarSchoolRewardTipData left, SolarSchoolRewardTipData right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06038B87 RID: 232327 RVA: 0x00FDFDE4 File Offset: 0x00FDDFE4
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<System.Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<ESolarSchoolRewardTipType>.Default.GetHashCode(this.<Type>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<TargetId>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Delta>k__BackingField);
		}

		// Token: 0x06038B88 RID: 232328 RVA: 0x00FDFE46 File Offset: 0x00FDE046
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as SolarSchoolRewardTipData);
		}

		// Token: 0x06038B89 RID: 232329 RVA: 0x00FDFE54 File Offset: 0x00FDE054
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(SolarSchoolRewardTipData other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<ESolarSchoolRewardTipType>.Default.Equals(this.<Type>k__BackingField, other.<Type>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<TargetId>k__BackingField, other.<TargetId>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<Delta>k__BackingField, other.<Delta>k__BackingField));
		}

		// Token: 0x06038B8B RID: 232331 RVA: 0x00FDFECD File Offset: 0x00FDE0CD
		[CompilerGenerated]
		private SolarSchoolRewardTipData(SolarSchoolRewardTipData original)
		{
			this.Type = original.<Type>k__BackingField;
			this.TargetId = original.<TargetId>k__BackingField;
			this.Delta = original.<Delta>k__BackingField;
		}

		// Token: 0x06038B8C RID: 232332 RVA: 0x00FDFEF9 File Offset: 0x00FDE0F9
		[CompilerGenerated]
		public void Deconstruct(out ESolarSchoolRewardTipType Type, out int TargetId, out int Delta)
		{
			Type = this.Type;
			TargetId = this.TargetId;
			Delta = this.Delta;
		}
	}
}
