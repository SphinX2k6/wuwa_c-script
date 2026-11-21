using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Platform
{
	// Token: 0x020057BF RID: 22463
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlPlatformState
	{
		// Token: 0x17006AD7 RID: 27351
		// (get) Token: 0x06037783 RID: 227203 RVA: 0x00F810C5 File Offset: 0x00F7F2C5
		// (set) Token: 0x06037784 RID: 227204 RVA: 0x00F810CD File Offset: 0x00F7F2CD
		public EInputPlatform Current { get; private set; }

		// Token: 0x17006AD8 RID: 27352
		// (get) Token: 0x06037785 RID: 227205 RVA: 0x00F810D8 File Offset: 0x00F7F2D8
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

		// Token: 0x17006AD9 RID: 27353
		// (get) Token: 0x06037786 RID: 227206 RVA: 0x00F81108 File Offset: 0x00F7F308
		public bool SupportsSticky
		{
			get
			{
				return this.Traits.SupportsSticky;
			}
		}

		// Token: 0x06037787 RID: 227207 RVA: 0x00F81115 File Offset: 0x00F7F315
		public FVector2D DragAnchorOffset(EDangoBrawlTemplateType templateType)
		{
			return this.Traits.DragAnchorOffset;
		}

		// Token: 0x06037788 RID: 227208 RVA: 0x00F81124 File Offset: 0x00F7F324
		public DangoBrawlPlatformState()
		{
			Dictionary<EInputPlatform, DangoBrawlPlatformState.PlatformTraits> dictionary = new Dictionary<EInputPlatform, DangoBrawlPlatformState.PlatformTraits>();
			dictionary[EInputPlatform.Pc] = new DangoBrawlPlatformState.PlatformTraits(new FVector2D(0f, 0f), true);
			dictionary[EInputPlatform.Mobile] = new DangoBrawlPlatformState.PlatformTraits(new FVector2D(0f, 136f), false);
			dictionary[EInputPlatform.Gamepad] = new DangoBrawlPlatformState.PlatformTraits(new FVector2D(0f, 0f), true);
			this.Table = dictionary;
			this.Current = DangoBrawlPlatformState.DetectPlatform();
		}

		// Token: 0x06037789 RID: 227209 RVA: 0x00F811A1 File Offset: 0x00F7F3A1
		public void Switch(EInputPlatform platform)
		{
			this.Current = platform;
		}

		// Token: 0x0603778A RID: 227210 RVA: 0x00F811AC File Offset: 0x00F7F3AC
		public void UpdatePlatform()
		{
			EInputPlatform platform = DangoBrawlPlatformState.DetectPlatform();
			this.Switch(platform);
		}

		// Token: 0x0603778B RID: 227211 RVA: 0x00F811C6 File Offset: 0x00F7F3C6
		private static EInputPlatform DetectPlatform()
		{
			if (Info.Instance.IsGamepadPlatform() || Info.Instance.IsInGamepad())
			{
				return EInputPlatform.Gamepad;
			}
			if (Info.Instance.IsMobilePlatform() || Info.Instance.IsMobileInputModel())
			{
				return EInputPlatform.Mobile;
			}
			return EInputPlatform.Pc;
		}

		// Token: 0x0401D46C RID: 119916
		private readonly Dictionary<EInputPlatform, DangoBrawlPlatformState.PlatformTraits> Table;

		// Token: 0x0200B407 RID: 46087
		[Nullable(0)]
		public sealed class PlatformTraits : IEquatable<DangoBrawlPlatformState.PlatformTraits>
		{
			// Token: 0x060478F4 RID: 293108 RVA: 0x015BFB6A File Offset: 0x015BDD6A
			public PlatformTraits(FVector2D DragAnchorOffset, bool SupportsSticky)
			{
				this.DragAnchorOffset = DragAnchorOffset;
				this.SupportsSticky = SupportsSticky;
				base..ctor();
			}

			// Token: 0x17007A2D RID: 31277
			// (get) Token: 0x060478F5 RID: 293109 RVA: 0x015BFB80 File Offset: 0x015BDD80
			[CompilerGenerated]
			private Type EqualityContract
			{
				[CompilerGenerated]
				get
				{
					return typeof(DangoBrawlPlatformState.PlatformTraits);
				}
			}

			// Token: 0x17007A2E RID: 31278
			// (get) Token: 0x060478F6 RID: 293110 RVA: 0x015BFB8C File Offset: 0x015BDD8C
			// (set) Token: 0x060478F7 RID: 293111 RVA: 0x015BFB94 File Offset: 0x015BDD94
			public FVector2D DragAnchorOffset { get; set; }

			// Token: 0x17007A2F RID: 31279
			// (get) Token: 0x060478F8 RID: 293112 RVA: 0x015BFB9D File Offset: 0x015BDD9D
			// (set) Token: 0x060478F9 RID: 293113 RVA: 0x015BFBA5 File Offset: 0x015BDDA5
			public bool SupportsSticky { get; set; }

			// Token: 0x060478FA RID: 293114 RVA: 0x015BFBB0 File Offset: 0x015BDDB0
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

			// Token: 0x060478FB RID: 293115 RVA: 0x015BFBFC File Offset: 0x015BDDFC
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

			// Token: 0x060478FC RID: 293116 RVA: 0x015BFC5D File Offset: 0x015BDE5D
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator !=(DangoBrawlPlatformState.PlatformTraits left, DangoBrawlPlatformState.PlatformTraits right)
			{
				return !(left == right);
			}

			// Token: 0x060478FD RID: 293117 RVA: 0x015BFC69 File Offset: 0x015BDE69
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator ==(DangoBrawlPlatformState.PlatformTraits left, DangoBrawlPlatformState.PlatformTraits right)
			{
				return left == right || (left != null && left.Equals(right));
			}

			// Token: 0x060478FE RID: 293118 RVA: 0x015BFC7D File Offset: 0x015BDE7D
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return (EqualityComparer<Type>.Default.GetHashCode(this.EqualityContract) * -1521134295 + EqualityComparer<FVector2D>.Default.GetHashCode(this.<DragAnchorOffset>k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.<SupportsSticky>k__BackingField);
			}

			// Token: 0x060478FF RID: 293119 RVA: 0x015BFCBD File Offset: 0x015BDEBD
			[NullableContext(2)]
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return this.Equals(obj as DangoBrawlPlatformState.PlatformTraits);
			}

			// Token: 0x06047900 RID: 293120 RVA: 0x015BFCCC File Offset: 0x015BDECC
			[NullableContext(2)]
			[CompilerGenerated]
			public bool Equals(DangoBrawlPlatformState.PlatformTraits other)
			{
				return this == other || (other != null && this.EqualityContract == other.EqualityContract && EqualityComparer<FVector2D>.Default.Equals(this.<DragAnchorOffset>k__BackingField, other.<DragAnchorOffset>k__BackingField) && EqualityComparer<bool>.Default.Equals(this.<SupportsSticky>k__BackingField, other.<SupportsSticky>k__BackingField));
			}

			// Token: 0x06047902 RID: 293122 RVA: 0x015BFD2D File Offset: 0x015BDF2D
			[CompilerGenerated]
			private PlatformTraits(DangoBrawlPlatformState.PlatformTraits original)
			{
				this.DragAnchorOffset = original.<DragAnchorOffset>k__BackingField;
				this.SupportsSticky = original.<SupportsSticky>k__BackingField;
			}

			// Token: 0x06047903 RID: 293123 RVA: 0x015BFD4D File Offset: 0x015BDF4D
			[CompilerGenerated]
			public void Deconstruct(out FVector2D DragAnchorOffset, out bool SupportsSticky)
			{
				DragAnchorOffset = this.DragAnchorOffset;
				SupportsSticky = this.SupportsSticky;
			}
		}
	}
}
