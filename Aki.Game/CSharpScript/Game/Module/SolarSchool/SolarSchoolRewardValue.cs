using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200597D RID: 22909
	public readonly struct SolarSchoolRewardValue : IEquatable<SolarSchoolRewardValue>
	{
		// Token: 0x0603876E RID: 231278 RVA: 0x00FCAEC1 File Offset: 0x00FC90C1
		public SolarSchoolRewardValue(int Id, ESolarSchoolRewardType RewardType, int TargetId, int Value)
		{
			this.Id = Id;
			this.RewardType = RewardType;
			this.TargetId = TargetId;
			this.Value = Value;
		}

		// Token: 0x17006C12 RID: 27666
		// (get) Token: 0x0603876F RID: 231279 RVA: 0x00FCAEE0 File Offset: 0x00FC90E0
		// (set) Token: 0x06038770 RID: 231280 RVA: 0x00FCAEE8 File Offset: 0x00FC90E8
		public int Id { get; set; }

		// Token: 0x17006C13 RID: 27667
		// (get) Token: 0x06038771 RID: 231281 RVA: 0x00FCAEF1 File Offset: 0x00FC90F1
		// (set) Token: 0x06038772 RID: 231282 RVA: 0x00FCAEF9 File Offset: 0x00FC90F9
		public ESolarSchoolRewardType RewardType { get; set; }

		// Token: 0x17006C14 RID: 27668
		// (get) Token: 0x06038773 RID: 231283 RVA: 0x00FCAF02 File Offset: 0x00FC9102
		// (set) Token: 0x06038774 RID: 231284 RVA: 0x00FCAF0A File Offset: 0x00FC910A
		public int TargetId { get; set; }

		// Token: 0x17006C15 RID: 27669
		// (get) Token: 0x06038775 RID: 231285 RVA: 0x00FCAF13 File Offset: 0x00FC9113
		// (set) Token: 0x06038776 RID: 231286 RVA: 0x00FCAF1B File Offset: 0x00FC911B
		public int Value { get; set; }

		// Token: 0x06038777 RID: 231287 RVA: 0x00FCAF24 File Offset: 0x00FC9124
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SolarSchoolRewardValue");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06038778 RID: 231288 RVA: 0x00FCAF70 File Offset: 0x00FC9170
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("Id = ");
			builder.Append(this.Id.ToString());
			builder.Append(", RewardType = ");
			builder.Append(this.RewardType.ToString());
			builder.Append(", TargetId = ");
			builder.Append(this.TargetId.ToString());
			builder.Append(", Value = ");
			builder.Append(this.Value.ToString());
			return true;
		}

		// Token: 0x06038779 RID: 231289 RVA: 0x00FCB01A File Offset: 0x00FC921A
		[CompilerGenerated]
		public static bool operator !=(SolarSchoolRewardValue left, SolarSchoolRewardValue right)
		{
			return !(left == right);
		}

		// Token: 0x0603877A RID: 231290 RVA: 0x00FCB026 File Offset: 0x00FC9226
		[CompilerGenerated]
		public static bool operator ==(SolarSchoolRewardValue left, SolarSchoolRewardValue right)
		{
			return left.Equals(right);
		}

		// Token: 0x0603877B RID: 231291 RVA: 0x00FCB030 File Offset: 0x00FC9230
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<int>.Default.GetHashCode(this.<Id>k__BackingField) * -1521134295 + EqualityComparer<ESolarSchoolRewardType>.Default.GetHashCode(this.<RewardType>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<TargetId>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Value>k__BackingField);
		}

		// Token: 0x0603877C RID: 231292 RVA: 0x00FCB092 File Offset: 0x00FC9292
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return obj is SolarSchoolRewardValue && this.Equals((SolarSchoolRewardValue)obj);
		}

		// Token: 0x0603877D RID: 231293 RVA: 0x00FCB0AC File Offset: 0x00FC92AC
		[CompilerGenerated]
		public bool Equals(SolarSchoolRewardValue other)
		{
			return EqualityComparer<int>.Default.Equals(this.<Id>k__BackingField, other.<Id>k__BackingField) && EqualityComparer<ESolarSchoolRewardType>.Default.Equals(this.<RewardType>k__BackingField, other.<RewardType>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<TargetId>k__BackingField, other.<TargetId>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<Value>k__BackingField, other.<Value>k__BackingField);
		}

		// Token: 0x0603877E RID: 231294 RVA: 0x00FCB119 File Offset: 0x00FC9319
		[CompilerGenerated]
		public void Deconstruct(out int Id, out ESolarSchoolRewardType RewardType, out int TargetId, out int Value)
		{
			Id = this.Id;
			RewardType = this.RewardType;
			TargetId = this.TargetId;
			Value = this.Value;
		}
	}
}
