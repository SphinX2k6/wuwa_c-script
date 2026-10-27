using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Platform
{
	// Token: 0x0200686F RID: 26735
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlPlatformState
	{
		// Token: 0x17009796 RID: 38806
		// (get) Token: 0x06042C2C RID: 273452 RVA: 0x0103FBE5 File Offset: 0x0103DDE5
		// (set) Token: 0x06042C2D RID: 273453 RVA: 0x0103FBED File Offset: 0x0103DDED
		public EInputPlatform Current { get; private set; }

		// Token: 0x17009797 RID: 38807
		// (get) Token: 0x06042C2E RID: 273454 RVA: 0x0103FBF8 File Offset: 0x0103DDF8
		public DangoBrawlPlatformState.PlatformTraits Traits
		{
			get
			{
				DangoBrawlPlatformState.PlatformTraits result;
				if (!this.Table.TryGetValue(this.Current, out result))
				{
					return this.Table[EInputPlatform.Pc];
				}
				return result;
			}
		}

		// Token: 0x17009798 RID: 38808
		// (get) Token: 0x06042C2F RID: 273455 RVA: 0x0103FC28 File Offset: 0x0103DE28
		public bool SupportsSticky
		{
			get
			{
				return this.Traits.SupportsSticky;
			}
		}

		// Token: 0x06042C30 RID: 273456 RVA: 0x0103FC35 File Offset: 0x0103DE35
		public FVector2D DragAnchorOffset(EDangoBrawlTemplateType templateType)
		{
			return this.Traits.DragAnchorOffset;
		}

		// Token: 0x06042C31 RID: 273457 RVA: 0x0103FC44 File Offset: 0x0103DE44
		public DangoBrawlPlatformState()
		{
			Dictionary<EInputPlatform, DangoBrawlPlatformState.PlatformTraits> dictionary = new Dictionary<EInputPlatform, DangoBrawlPlatformState.PlatformTraits>();
			dictionary[EInputPlatform.Pc] = new DangoBrawlPlatformState.PlatformTraits(new FVector2D(0f, 0f), true);
			dictionary[EInputPlatform.Mobile] = new DangoBrawlPlatformState.PlatformTraits(new FVector2D(0f, 136f), false);
			dictionary[EInputPlatform.Gamepad] = new DangoBrawlPlatformState.PlatformTraits(new FVector2D(0f, 0f), true);
			this.Table = dictionary;
			this.Current = DangoBrawlPlatformState.DetectPlatform();
		}

		// Token: 0x06042C32 RID: 273458 RVA: 0x0103FCC1 File Offset: 0x0103DEC1
		public void Switch(EInputPlatform platform)
		{
			this.Current = platform;
		}

		// Token: 0x06042C33 RID: 273459 RVA: 0x0103FCCC File Offset: 0x0103DECC
		public void UpdatePlatform()
		{
			EInputPlatform platform = DangoBrawlPlatformState.DetectPlatform();
			this.Switch(platform);
		}

		// Token: 0x06042C34 RID: 273460 RVA: 0x0103FCE6 File Offset: 0x0103DEE6
		private static EInputPlatform DetectPlatform()
		{
			if (Info.Instance.IsMobilePlatform() || Info.Instance.IsMobileInputModel())
			{
				return EInputPlatform.Mobile;
			}
			if (Info.Instance.IsGamepadPlatform() || Info.Instance.IsInGamepad())
			{
				return EInputPlatform.Gamepad;
			}
			return EInputPlatform.Pc;
		}

		// Token: 0x04022C0F RID: 142351
		private readonly Dictionary<EInputPlatform, DangoBrawlPlatformState.PlatformTraits> Table;

		// Token: 0x0200CA3D RID: 51773
		[Nullable(0)]
		public sealed class PlatformTraits : IEquatable<DangoBrawlPlatformState.PlatformTraits>
		{
			// Token: 0x0605147C RID: 332924 RVA: 0x01608CF6 File Offset: 0x01606EF6
			public PlatformTraits(FVector2D DragAnchorOffset, bool SupportsSticky)
			{
				this.DragAnchorOffset = DragAnchorOffset;
				this.SupportsSticky = SupportsSticky;
				base..ctor();
			}

			// Token: 0x1700A290 RID: 41616
			// (get) Token: 0x0605147D RID: 332925 RVA: 0x01608D0C File Offset: 0x01606F0C
			[CompilerGenerated]
			private Type EqualityContract
			{
				[CompilerGenerated]
				get
				{
					return typeof(DangoBrawlPlatformState.PlatformTraits);
				}
			}

			// Token: 0x1700A291 RID: 41617
			// (get) Token: 0x0605147E RID: 332926 RVA: 0x01608D18 File Offset: 0x01606F18
			// (set) Token: 0x0605147F RID: 332927 RVA: 0x01608D20 File Offset: 0x01606F20
			public FVector2D DragAnchorOffset { get; set; }

			// Token: 0x1700A292 RID: 41618
			// (get) Token: 0x06051480 RID: 332928 RVA: 0x01608D29 File Offset: 0x01606F29
			// (set) Token: 0x06051481 RID: 332929 RVA: 0x01608D31 File Offset: 0x01606F31
			public bool SupportsSticky { get; set; }

			// Token: 0x06051482 RID: 332930 RVA: 0x01608D3C File Offset: 0x01606F3C
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("PlatformTraits");
				stringBuilder.Append(" { ");
				if (this.PrintMembers(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x06051483 RID: 332931 RVA: 0x01608D88 File Offset: 0x01606F88
			[CompilerGenerated]
			private bool PrintMembers(StringBuilder builder)
			{
				RuntimeHelpers.EnsureSufficientExecutionStack();
				builder.Append("DragAnchorOffset = ");
				builder.Append(this.DragAnchorOffset.ToString());
				builder.Append(", SupportsSticky = ");
				builder.Append(this.SupportsSticky.ToString());
				return true;
			}

			// Token: 0x06051484 RID: 332932 RVA: 0x01608DE9 File Offset: 0x01606FE9
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator !=(DangoBrawlPlatformState.PlatformTraits left, DangoBrawlPlatformState.PlatformTraits right)
			{
				return !(left == right);
			}

			// Token: 0x06051485 RID: 332933 RVA: 0x01608DF5 File Offset: 0x01606FF5
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator ==(DangoBrawlPlatformState.PlatformTraits left, DangoBrawlPlatformState.PlatformTraits right)
			{
				return left == right || (left != null && left.Equals(right));
			}

			// Token: 0x06051486 RID: 332934 RVA: 0x01608E09 File Offset: 0x01607009
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return (EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<FVector2D>.Default.GetHashCode(this.<DragAnchorOffset>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<SupportsSticky>k__BackingField);
			}

			// Token: 0x06051487 RID: 332935 RVA: 0x01608E49 File Offset: 0x01607049
			[NullableContext(2)]
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return this.Equals(obj as DangoBrawlPlatformState.PlatformTraits);
			}

			// Token: 0x06051488 RID: 332936 RVA: 0x01608E58 File Offset: 0x01607058
			[NullableContext(2)]
			[CompilerGenerated]
			public bool Equals(DangoBrawlPlatformState.PlatformTraits other)
			{
				return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<FVector2D>.Default.Equals(this.<DragAnchorOffset>k__BackingField, other.<DragAnchorOffset>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<SupportsSticky>k__BackingField, other.<SupportsSticky>k__BackingField));
			}

			// Token: 0x0605148A RID: 332938 RVA: 0x01608EB9 File Offset: 0x016070B9
			[CompilerGenerated]
			private PlatformTraits(DangoBrawlPlatformState.PlatformTraits original)
			{
				this.DragAnchorOffset = original.<DragAnchorOffset>k__BackingField;
				this.SupportsSticky = original.<SupportsSticky>k__BackingField;
			}

			// Token: 0x0605148B RID: 332939 RVA: 0x01608ED9 File Offset: 0x016070D9
			[CompilerGenerated]
			public void Deconstruct(out FVector2D DragAnchorOffset, out bool SupportsSticky)
			{
				DragAnchorOffset = this.DragAnchorOffset;
				SupportsSticky = this.SupportsSticky;
			}
		}
	}
}
