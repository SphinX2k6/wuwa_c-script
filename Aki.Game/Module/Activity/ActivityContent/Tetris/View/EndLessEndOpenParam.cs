using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Module.ItemReward;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FE9 RID: 12265
	[NullableContext(1)]
	[Nullable(0)]
	public class EndLessEndOpenParam : IEquatable<EndLessEndOpenParam>
	{
		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x0601D1A3 RID: 119203 RVA: 0x008E53AD File Offset: 0x008E35AD
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(EndLessEndOpenParam);
			}
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x0601D1A4 RID: 119204 RVA: 0x008E53B9 File Offset: 0x008E35B9
		// (set) Token: 0x0601D1A5 RID: 119205 RVA: 0x008E53C1 File Offset: 0x008E35C1
		public int Score { get; set; }

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x0601D1A6 RID: 119206 RVA: 0x008E53CA File Offset: 0x008E35CA
		// (set) Token: 0x0601D1A7 RID: 119207 RVA: 0x008E53D2 File Offset: 0x008E35D2
		public bool IsNewRecord { get; set; }

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x0601D1A8 RID: 119208 RVA: 0x008E53DB File Offset: 0x008E35DB
		// (set) Token: 0x0601D1A9 RID: 119209 RVA: 0x008E53E3 File Offset: 0x008E35E3
		public bool IsQuit { get; set; }

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x0601D1AA RID: 119210 RVA: 0x008E53EC File Offset: 0x008E35EC
		// (set) Token: 0x0601D1AB RID: 119211 RVA: 0x008E53F4 File Offset: 0x008E35F4
		public bool IsAutoClose { get; set; }

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x0601D1AC RID: 119212 RVA: 0x008E53FD File Offset: 0x008E35FD
		// (set) Token: 0x0601D1AD RID: 119213 RVA: 0x008E5405 File Offset: 0x008E3605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RewardItemData> Rewards { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x0601D1AE RID: 119214 RVA: 0x008E5410 File Offset: 0x008E3610
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("EndLessEndOpenParam");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601D1AF RID: 119215 RVA: 0x008E545C File Offset: 0x008E365C
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Score = ");
			builder.Append(this.Score.ToString());
			builder.Append(", IsNewRecord = ");
			builder.Append(this.IsNewRecord.ToString());
			builder.Append(", IsQuit = ");
			builder.Append(this.IsQuit.ToString());
			builder.Append(", IsAutoClose = ");
			builder.Append(this.IsAutoClose.ToString());
			builder.Append(", Rewards = ");
			builder.Append(this.Rewards);
			return true;
		}

		// Token: 0x0601D1B0 RID: 119216 RVA: 0x008E5524 File Offset: 0x008E3724
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(EndLessEndOpenParam left, EndLessEndOpenParam right)
		{
			return !(left == right);
		}

		// Token: 0x0601D1B1 RID: 119217 RVA: 0x008E5530 File Offset: 0x008E3730
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(EndLessEndOpenParam left, EndLessEndOpenParam right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0601D1B2 RID: 119218 RVA: 0x008E5544 File Offset: 0x008E3744
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Score>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsNewRecord>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsQuit>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<IsAutoClose>k__BackingField)) * -1521134295 + EqualityComparer<List<RewardItemData>>.Default.GetHashCode(this.<Rewards>k__BackingField);
		}

		// Token: 0x0601D1B3 RID: 119219 RVA: 0x008E55D4 File Offset: 0x008E37D4
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as EndLessEndOpenParam);
		}

		// Token: 0x0601D1B4 RID: 119220 RVA: 0x008E55E4 File Offset: 0x008E37E4
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(EndLessEndOpenParam other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(this.<Score>k__BackingField, other.<Score>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<IsNewRecord>k__BackingField, other.<IsNewRecord>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<IsQuit>k__BackingField, other.<IsQuit>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<IsAutoClose>k__BackingField, other.<IsAutoClose>k__BackingField) && EqualityComparer<List<RewardItemData>>.Default.Equals(this.<Rewards>k__BackingField, other.<Rewards>k__BackingField));
		}

		// Token: 0x0601D1B6 RID: 119222 RVA: 0x008E5694 File Offset: 0x008E3894
		[CompilerGenerated]
		protected EndLessEndOpenParam(EndLessEndOpenParam original)
		{
			this.Score = original.<Score>k__BackingField;
			this.IsNewRecord = original.<IsNewRecord>k__BackingField;
			this.IsQuit = original.<IsQuit>k__BackingField;
			this.IsAutoClose = original.<IsAutoClose>k__BackingField;
			this.Rewards = original.<Rewards>k__BackingField;
		}

		// Token: 0x0601D1B7 RID: 119223 RVA: 0x008E56E3 File Offset: 0x008E38E3
		public EndLessEndOpenParam()
		{
		}
	}
}
