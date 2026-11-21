using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059F8 RID: 23032
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class SolarSchoolRewardTipItemInstance : IEquatable<SolarSchoolRewardTipItemInstance>
	{
		// Token: 0x06038B91 RID: 232337 RVA: 0x00FDFFB2 File Offset: 0x00FDE1B2
		public SolarSchoolRewardTipItemInstance(SolarSchoolRewardTipItemBase Item, SolarSchoolRewardTipItemTypeState TypeState)
		{
			this.Item = Item;
			this.TypeState = TypeState;
			base..ctor();
		}

		// Token: 0x17006C60 RID: 27744
		// (get) Token: 0x06038B92 RID: 232338 RVA: 0x00FDFFC8 File Offset: 0x00FDE1C8
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SolarSchoolRewardTipItemInstance);
			}
		}

		// Token: 0x17006C61 RID: 27745
		// (get) Token: 0x06038B93 RID: 232339 RVA: 0x00FDFFD4 File Offset: 0x00FDE1D4
		// (set) Token: 0x06038B94 RID: 232340 RVA: 0x00FDFFDC File Offset: 0x00FDE1DC
		public SolarSchoolRewardTipItemBase Item { get; set; }

		// Token: 0x17006C62 RID: 27746
		// (get) Token: 0x06038B95 RID: 232341 RVA: 0x00FDFFE5 File Offset: 0x00FDE1E5
		// (set) Token: 0x06038B96 RID: 232342 RVA: 0x00FDFFED File Offset: 0x00FDE1ED
		public SolarSchoolRewardTipItemTypeState TypeState { get; set; }

		// Token: 0x06038B97 RID: 232343 RVA: 0x00FDFFF8 File Offset: 0x00FDE1F8
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SolarSchoolRewardTipItemInstance");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06038B98 RID: 232344 RVA: 0x00FE0044 File Offset: 0x00FDE244
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Item = ");
			builder.Append(this.Item);
			builder.Append(", TypeState = ");
			builder.Append(this.TypeState);
			return true;
		}

		// Token: 0x06038B99 RID: 232345 RVA: 0x00FE007E File Offset: 0x00FDE27E
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(SolarSchoolRewardTipItemInstance left, SolarSchoolRewardTipItemInstance right)
		{
			return !(left == right);
		}

		// Token: 0x06038B9A RID: 232346 RVA: 0x00FE008A File Offset: 0x00FDE28A
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(SolarSchoolRewardTipItemInstance left, SolarSchoolRewardTipItemInstance right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06038B9B RID: 232347 RVA: 0x00FE009E File Offset: 0x00FDE29E
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<SolarSchoolRewardTipItemBase>.Default.GetHashCode(this.<Item>k__BackingField)) * -1521134295 + EqualityComparer<SolarSchoolRewardTipItemTypeState>.Default.GetHashCode(this.<TypeState>k__BackingField);
		}

		// Token: 0x06038B9C RID: 232348 RVA: 0x00FE00DE File Offset: 0x00FDE2DE
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as SolarSchoolRewardTipItemInstance);
		}

		// Token: 0x06038B9D RID: 232349 RVA: 0x00FE00EC File Offset: 0x00FDE2EC
		[NullableContext(2)]
		[CompilerGenerated]
		public bool Equals(SolarSchoolRewardTipItemInstance other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<SolarSchoolRewardTipItemBase>.Default.Equals(this.<Item>k__BackingField, other.<Item>k__BackingField) && EqualityComparer<SolarSchoolRewardTipItemTypeState>.Default.Equals(this.<TypeState>k__BackingField, other.<TypeState>k__BackingField));
		}

		// Token: 0x06038B9F RID: 232351 RVA: 0x00FE014D File Offset: 0x00FDE34D
		[CompilerGenerated]
		private SolarSchoolRewardTipItemInstance(SolarSchoolRewardTipItemInstance original)
		{
			this.Item = original.<Item>k__BackingField;
			this.TypeState = original.<TypeState>k__BackingField;
		}

		// Token: 0x06038BA0 RID: 232352 RVA: 0x00FE016D File Offset: 0x00FDE36D
		[CompilerGenerated]
		public void Deconstruct(out SolarSchoolRewardTipItemBase Item, out SolarSchoolRewardTipItemTypeState TypeState)
		{
			Item = this.Item;
			TypeState = this.TypeState;
		}
	}
}
