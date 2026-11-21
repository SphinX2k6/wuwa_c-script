using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056EF RID: 22255
	[NullableContext(1)]
	[Nullable(0)]
	public class BuildResult : IEquatable<BuildResult>
	{
		// Token: 0x06036D5E RID: 224606 RVA: 0x00F4B6AF File Offset: 0x00F498AF
		public BuildResult(IDragVisual Visual, FVector2D? PrimaryAbsBeforeReparent = null)
		{
			this.Visual = Visual;
			this.PrimaryAbsBeforeReparent = PrimaryAbsBeforeReparent;
			base..ctor();
		}

		// Token: 0x170069E2 RID: 27106
		// (get) Token: 0x06036D5F RID: 224607 RVA: 0x00F4B6C5 File Offset: 0x00F498C5
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BuildResult);
			}
		}

		// Token: 0x170069E3 RID: 27107
		// (get) Token: 0x06036D60 RID: 224608 RVA: 0x00F4B6D1 File Offset: 0x00F498D1
		// (set) Token: 0x06036D61 RID: 224609 RVA: 0x00F4B6D9 File Offset: 0x00F498D9
		public IDragVisual Visual { get; set; }

		// Token: 0x170069E4 RID: 27108
		// (get) Token: 0x06036D62 RID: 224610 RVA: 0x00F4B6E2 File Offset: 0x00F498E2
		// (set) Token: 0x06036D63 RID: 224611 RVA: 0x00F4B6EA File Offset: 0x00F498EA
		public FVector2D? PrimaryAbsBeforeReparent { get; set; }

		// Token: 0x06036D64 RID: 224612 RVA: 0x00F4B6F4 File Offset: 0x00F498F4
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BuildResult");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06036D65 RID: 224613 RVA: 0x00F4B740 File Offset: 0x00F49940
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Visual = ");
			builder.Append(this.Visual);
			builder.Append(", PrimaryAbsBeforeReparent = ");
			builder.Append(this.PrimaryAbsBeforeReparent.ToString());
			return true;
		}

		// Token: 0x06036D66 RID: 224614 RVA: 0x00F4B793 File Offset: 0x00F49993
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(BuildResult left, BuildResult right)
		{
			return !(left == right);
		}

		// Token: 0x06036D67 RID: 224615 RVA: 0x00F4B79F File Offset: 0x00F4999F
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(BuildResult left, BuildResult right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06036D68 RID: 224616 RVA: 0x00F4B7B3 File Offset: 0x00F499B3
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<IDragVisual>.Default.GetHashCode(this.<Visual>k__BackingField)) * -1521134295 + EqualityComparer<FVector2D?>.Default.GetHashCode(this.<PrimaryAbsBeforeReparent>k__BackingField);
		}

		// Token: 0x06036D69 RID: 224617 RVA: 0x00F4B7F3 File Offset: 0x00F499F3
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as BuildResult);
		}

		// Token: 0x06036D6A RID: 224618 RVA: 0x00F4B804 File Offset: 0x00F49A04
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(BuildResult other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<IDragVisual>.Default.Equals(this.<Visual>k__BackingField, other.<Visual>k__BackingField) && EqualityComparer<FVector2D?>.Default.Equals(this.<PrimaryAbsBeforeReparent>k__BackingField, other.<PrimaryAbsBeforeReparent>k__BackingField));
		}

		// Token: 0x06036D6C RID: 224620 RVA: 0x00F4B865 File Offset: 0x00F49A65
		[CompilerGenerated]
		protected BuildResult(BuildResult original)
		{
			this.Visual = original.<Visual>k__BackingField;
			this.PrimaryAbsBeforeReparent = original.<PrimaryAbsBeforeReparent>k__BackingField;
		}

		// Token: 0x06036D6D RID: 224621 RVA: 0x00F4B885 File Offset: 0x00F49A85
		[CompilerGenerated]
		public void Deconstruct(out IDragVisual Visual, out FVector2D? PrimaryAbsBeforeReparent)
		{
			Visual = this.Visual;
			PrimaryAbsBeforeReparent = this.PrimaryAbsBeforeReparent;
		}
	}
}
