using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200679F RID: 26527
	[NullableContext(1)]
	[Nullable(0)]
	public class BuildResult : IEquatable<BuildResult>
	{
		// Token: 0x06042208 RID: 270856 RVA: 0x0100A2CB File Offset: 0x010084CB
		public BuildResult(IDragVisual Visual, FVector2D? PrimaryAbsBeforeReparent = null)
		{
			this.Visual = Visual;
			this.PrimaryAbsBeforeReparent = PrimaryAbsBeforeReparent;
			base..ctor();
		}

		// Token: 0x170096A1 RID: 38561
		// (get) Token: 0x06042209 RID: 270857 RVA: 0x0100A2E1 File Offset: 0x010084E1
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BuildResult);
			}
		}

		// Token: 0x170096A2 RID: 38562
		// (get) Token: 0x0604220A RID: 270858 RVA: 0x0100A2ED File Offset: 0x010084ED
		// (set) Token: 0x0604220B RID: 270859 RVA: 0x0100A2F5 File Offset: 0x010084F5
		public IDragVisual Visual { get; set; }

		// Token: 0x170096A3 RID: 38563
		// (get) Token: 0x0604220C RID: 270860 RVA: 0x0100A2FE File Offset: 0x010084FE
		// (set) Token: 0x0604220D RID: 270861 RVA: 0x0100A306 File Offset: 0x01008506
		public FVector2D? PrimaryAbsBeforeReparent { get; set; }

		// Token: 0x0604220E RID: 270862 RVA: 0x0100A310 File Offset: 0x01008510
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

		// Token: 0x0604220F RID: 270863 RVA: 0x0100A35C File Offset: 0x0100855C
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

		// Token: 0x06042210 RID: 270864 RVA: 0x0100A3AF File Offset: 0x010085AF
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(BuildResult left, BuildResult right)
		{
			return !(left == right);
		}

		// Token: 0x06042211 RID: 270865 RVA: 0x0100A3BB File Offset: 0x010085BB
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(BuildResult left, BuildResult right)
		{
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06042212 RID: 270866 RVA: 0x0100A3CF File Offset: 0x010085CF
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<IDragVisual>.Default.GetHashCode(this.<Visual>k__BackingField)) * -1521134295 + EqualityComparer<FVector2D?>.Default.GetHashCode(this.<PrimaryAbsBeforeReparent>k__BackingField);
		}

		// Token: 0x06042213 RID: 270867 RVA: 0x0100A40F File Offset: 0x0100860F
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as BuildResult);
		}

		// Token: 0x06042214 RID: 270868 RVA: 0x0100A420 File Offset: 0x01008620
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(BuildResult other)
		{
			return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<IDragVisual>.Default.Equals(this.<Visual>k__BackingField, other.<Visual>k__BackingField) && EqualityComparer<FVector2D?>.Default.Equals(this.<PrimaryAbsBeforeReparent>k__BackingField, other.<PrimaryAbsBeforeReparent>k__BackingField));
		}

		// Token: 0x06042216 RID: 270870 RVA: 0x0100A481 File Offset: 0x01008681
		[CompilerGenerated]
		protected BuildResult(BuildResult original)
		{
			this.Visual = original.<Visual>k__BackingField;
			this.PrimaryAbsBeforeReparent = original.<PrimaryAbsBeforeReparent>k__BackingField;
		}

		// Token: 0x06042217 RID: 270871 RVA: 0x0100A4A1 File Offset: 0x010086A1
		[CompilerGenerated]
		public void Deconstruct(out IDragVisual Visual, out FVector2D? PrimaryAbsBeforeReparent)
		{
			Visual = this.Visual;
			PrimaryAbsBeforeReparent = this.PrimaryAbsBeforeReparent;
		}
	}
}
