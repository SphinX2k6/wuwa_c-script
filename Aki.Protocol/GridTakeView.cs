using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071C RID: 1820
	public sealed class GridTakeView : IMessage<GridTakeView>, IMessage, IEquatable<GridTakeView>, IDeepCloneable<GridTakeView>, IBufferMessage
	{
		// Token: 0x0600A56E RID: 42350 RVA: 0x0018F32B File Offset: 0x0018D52B
		[NullableContext(1)]
		public static GridTakeView Create()
		{
			return new GridTakeView();
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x0600A56F RID: 42351 RVA: 0x0018F332 File Offset: 0x0018D532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x0600A570 RID: 42352 RVA: 0x0018F335 File Offset: 0x0018D535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridTakeView.Descriptor;
			}
		}

		// Token: 0x0600A571 RID: 42353 RVA: 0x0018F33C File Offset: 0x0018D53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridTakeView()
		{
		}

		// Token: 0x0600A572 RID: 42354 RVA: 0x0018F350 File Offset: 0x0018D550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridTakeView(GridTakeView other) : this()
		{
			this.oldTeamLevel_ = other.oldTeamLevel_;
			this.newTeamLevel_ = other.newTeamLevel_;
			this.effects_ = other.effects_.Clone();
			this.index_ = other.index_;
			this.preChangeMood_ = other.preChangeMood_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x0018F3B5 File Offset: 0x0018D5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridTakeView Clone()
		{
			return new GridTakeView(this);
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x0600A574 RID: 42356 RVA: 0x0018F3BD File Offset: 0x0018D5BD
		// (set) Token: 0x0600A575 RID: 42357 RVA: 0x0018F3C5 File Offset: 0x0018D5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OldTeamLevel
		{
			get
			{
				return this.oldTeamLevel_;
			}
			set
			{
				this.oldTeamLevel_ = value;
			}
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x0600A576 RID: 42358 RVA: 0x0018F3CE File Offset: 0x0018D5CE
		// (set) Token: 0x0600A577 RID: 42359 RVA: 0x0018F3D6 File Offset: 0x0018D5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewTeamLevel
		{
			get
			{
				return this.newTeamLevel_;
			}
			set
			{
				this.newTeamLevel_ = value;
			}
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x0600A578 RID: 42360 RVA: 0x0018F3DF File Offset: 0x0018D5DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Effects
		{
			get
			{
				return this.effects_;
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x0600A579 RID: 42361 RVA: 0x0018F3E7 File Offset: 0x0018D5E7
		// (set) Token: 0x0600A57A RID: 42362 RVA: 0x0018F3EF File Offset: 0x0018D5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x0600A57B RID: 42363 RVA: 0x0018F3F8 File Offset: 0x0018D5F8
		// (set) Token: 0x0600A57C RID: 42364 RVA: 0x0018F400 File Offset: 0x0018D600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreChangeMood
		{
			get
			{
				return this.preChangeMood_;
			}
			set
			{
				this.preChangeMood_ = value;
			}
		}

		// Token: 0x0600A57D RID: 42365 RVA: 0x0018F409 File Offset: 0x0018D609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridTakeView);
		}

		// Token: 0x0600A57E RID: 42366 RVA: 0x0018F418 File Offset: 0x0018D618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridTakeView other)
		{
			return other != null && (other == this || (this.OldTeamLevel == other.OldTeamLevel && this.NewTeamLevel == other.NewTeamLevel && this.effects_.Equals(other.effects_) && this.Index == other.Index && this.PreChangeMood == other.PreChangeMood && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x0018F498 File Offset: 0x0018D698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OldTeamLevel != 0)
			{
				num ^= this.OldTeamLevel.GetHashCode();
			}
			if (this.NewTeamLevel != 0)
			{
				num ^= this.NewTeamLevel.GetHashCode();
			}
			num ^= this.effects_.GetHashCode();
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.PreChangeMood != 0)
			{
				num ^= this.PreChangeMood.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A580 RID: 42368 RVA: 0x0018F530 File Offset: 0x0018D730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A581 RID: 42369 RVA: 0x0018F53D File Offset: 0x0018D73D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A582 RID: 42370 RVA: 0x0018F548 File Offset: 0x0018D748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OldTeamLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.OldTeamLevel);
			}
			if (this.NewTeamLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NewTeamLevel);
			}
			this.effects_.WriteTo(ref output, GridTakeView._repeated_effects_codec);
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this.PreChangeMood != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PreChangeMood);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A583 RID: 42371 RVA: 0x0018F5EC File Offset: 0x0018D7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OldTeamLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OldTeamLevel);
			}
			if (this.NewTeamLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewTeamLevel);
			}
			num += this.effects_.CalculateSize(GridTakeView._repeated_effects_codec);
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.PreChangeMood != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreChangeMood);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A584 RID: 42372 RVA: 0x0018F688 File Offset: 0x0018D888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GridTakeView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OldTeamLevel != 0)
			{
				this.OldTeamLevel = other.OldTeamLevel;
			}
			if (other.NewTeamLevel != 0)
			{
				this.NewTeamLevel = other.NewTeamLevel;
			}
			this.effects_.Add(other.effects_);
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.PreChangeMood != 0)
			{
				this.PreChangeMood = other.PreChangeMood;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x0018F711 File Offset: 0x0018D911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x0018F71C File Offset: 0x0018D91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.OldTeamLevel = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.NewTeamLevel = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_60;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_60;
					}
					if (num == 32U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.PreChangeMood = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_60:
				this.effects_.AddEntriesFrom(ref input, GridTakeView._repeated_effects_codec);
			}
		}

		// Token: 0x04004C11 RID: 19473
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C12 RID: 19474
		public const int OldTeamLevelFieldNumber = 1;

		// Token: 0x04004C13 RID: 19475
		private int oldTeamLevel_;

		// Token: 0x04004C14 RID: 19476
		public const int NewTeamLevelFieldNumber = 2;

		// Token: 0x04004C15 RID: 19477
		private int newTeamLevel_;

		// Token: 0x04004C16 RID: 19478
		public const int EffectsFieldNumber = 3;

		// Token: 0x04004C17 RID: 19479
		private static readonly FieldCodec<int> _repeated_effects_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004C18 RID: 19480
		private readonly RepeatedField<int> effects_ = new RepeatedField<int>();

		// Token: 0x04004C19 RID: 19481
		public const int IndexFieldNumber = 4;

		// Token: 0x04004C1A RID: 19482
		private int index_;

		// Token: 0x04004C1B RID: 19483
		public const int PreChangeMoodFieldNumber = 5;

		// Token: 0x04004C1C RID: 19484
		private int preChangeMood_;
	}
}
