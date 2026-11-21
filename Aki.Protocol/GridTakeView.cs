using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000708 RID: 1800
	public sealed class GridTakeView : IMessage<GridTakeView>, IMessage, IEquatable<GridTakeView>, IDeepCloneable<GridTakeView>, IBufferMessage
	{
		// Token: 0x0600A418 RID: 42008 RVA: 0x0018C8F7 File Offset: 0x0018AAF7
		[NullableContext(1)]
		public static GridTakeView Create()
		{
			return new GridTakeView();
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x0600A419 RID: 42009 RVA: 0x0018C8FE File Offset: 0x0018AAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x0600A41A RID: 42010 RVA: 0x0018C901 File Offset: 0x0018AB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridTakeView.Descriptor;
			}
		}

		// Token: 0x0600A41B RID: 42011 RVA: 0x0018C908 File Offset: 0x0018AB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridTakeView()
		{
		}

		// Token: 0x0600A41C RID: 42012 RVA: 0x0018C91C File Offset: 0x0018AB1C
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

		// Token: 0x0600A41D RID: 42013 RVA: 0x0018C981 File Offset: 0x0018AB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridTakeView Clone()
		{
			return new GridTakeView(this);
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x0600A41E RID: 42014 RVA: 0x0018C989 File Offset: 0x0018AB89
		// (set) Token: 0x0600A41F RID: 42015 RVA: 0x0018C991 File Offset: 0x0018AB91
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

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x0600A420 RID: 42016 RVA: 0x0018C99A File Offset: 0x0018AB9A
		// (set) Token: 0x0600A421 RID: 42017 RVA: 0x0018C9A2 File Offset: 0x0018ABA2
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

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x0600A422 RID: 42018 RVA: 0x0018C9AB File Offset: 0x0018ABAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Effects
		{
			get
			{
				return this.effects_;
			}
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x0600A423 RID: 42019 RVA: 0x0018C9B3 File Offset: 0x0018ABB3
		// (set) Token: 0x0600A424 RID: 42020 RVA: 0x0018C9BB File Offset: 0x0018ABBB
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

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x0600A425 RID: 42021 RVA: 0x0018C9C4 File Offset: 0x0018ABC4
		// (set) Token: 0x0600A426 RID: 42022 RVA: 0x0018C9CC File Offset: 0x0018ABCC
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

		// Token: 0x0600A427 RID: 42023 RVA: 0x0018C9D5 File Offset: 0x0018ABD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridTakeView);
		}

		// Token: 0x0600A428 RID: 42024 RVA: 0x0018C9E4 File Offset: 0x0018ABE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridTakeView other)
		{
			return other != null && (other == this || (this.OldTeamLevel == other.OldTeamLevel && this.NewTeamLevel == other.NewTeamLevel && this.effects_.Equals(other.effects_) && this.Index == other.Index && this.PreChangeMood == other.PreChangeMood && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A429 RID: 42025 RVA: 0x0018CA64 File Offset: 0x0018AC64
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

		// Token: 0x0600A42A RID: 42026 RVA: 0x0018CAFC File Offset: 0x0018ACFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A42B RID: 42027 RVA: 0x0018CB09 File Offset: 0x0018AD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A42C RID: 42028 RVA: 0x0018CB14 File Offset: 0x0018AD14
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

		// Token: 0x0600A42D RID: 42029 RVA: 0x0018CBB8 File Offset: 0x0018ADB8
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

		// Token: 0x0600A42E RID: 42030 RVA: 0x0018CC54 File Offset: 0x0018AE54
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

		// Token: 0x0600A42F RID: 42031 RVA: 0x0018CCDD File Offset: 0x0018AEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A430 RID: 42032 RVA: 0x0018CCE8 File Offset: 0x0018AEE8
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

		// Token: 0x04004C0A RID: 19466
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C0B RID: 19467
		public const int OldTeamLevelFieldNumber = 1;

		// Token: 0x04004C0C RID: 19468
		private int oldTeamLevel_;

		// Token: 0x04004C0D RID: 19469
		public const int NewTeamLevelFieldNumber = 2;

		// Token: 0x04004C0E RID: 19470
		private int newTeamLevel_;

		// Token: 0x04004C0F RID: 19471
		public const int EffectsFieldNumber = 3;

		// Token: 0x04004C10 RID: 19472
		private static readonly FieldCodec<int> _repeated_effects_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004C11 RID: 19473
		private readonly RepeatedField<int> effects_ = new RepeatedField<int>();

		// Token: 0x04004C12 RID: 19474
		public const int IndexFieldNumber = 4;

		// Token: 0x04004C13 RID: 19475
		private int index_;

		// Token: 0x04004C14 RID: 19476
		public const int PreChangeMoodFieldNumber = 5;

		// Token: 0x04004C15 RID: 19477
		private int preChangeMood_;
	}
}
