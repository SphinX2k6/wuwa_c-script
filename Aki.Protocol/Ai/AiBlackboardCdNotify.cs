using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x0200171F RID: 5919
	[NetMessage(EMessageId.AiBlackboardCdNotify)]
	public sealed class AiBlackboardCdNotify : IMessage<AiBlackboardCdNotify>, IMessage, IEquatable<AiBlackboardCdNotify>, IDeepCloneable<AiBlackboardCdNotify>, IBufferMessage
	{
		// Token: 0x0601DB72 RID: 121714 RVA: 0x0045BFB5 File Offset: 0x0045A1B5
		[NullableContext(1)]
		public static AiBlackboardCdNotify Create()
		{
			return new AiBlackboardCdNotify();
		}

		// Token: 0x1700652F RID: 25903
		// (get) Token: 0x0601DB73 RID: 121715 RVA: 0x0045BFBC File Offset: 0x0045A1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006530 RID: 25904
		// (get) Token: 0x0601DB74 RID: 121716 RVA: 0x0045BFBF File Offset: 0x0045A1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardCdNotify.Descriptor;
			}
		}

		// Token: 0x0601DB75 RID: 121717 RVA: 0x0045BFC6 File Offset: 0x0045A1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdNotify()
		{
		}

		// Token: 0x0601DB76 RID: 121718 RVA: 0x0045BFF0 File Offset: 0x0045A1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdNotify(AiBlackboardCdNotify other) : this()
		{
			this.aiBlackboardCdDel_ = other.aiBlackboardCdDel_.Clone();
			this.aiBlackboardCdModify_ = other.aiBlackboardCdModify_.Clone();
			this.aiBlackboardCdComplete_ = other.aiBlackboardCdComplete_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DB77 RID: 121719 RVA: 0x0045C047 File Offset: 0x0045A247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdNotify Clone()
		{
			return new AiBlackboardCdNotify(this);
		}

		// Token: 0x17006531 RID: 25905
		// (get) Token: 0x0601DB78 RID: 121720 RVA: 0x0045C04F File Offset: 0x0045A24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AiBlackboardCdDel
		{
			get
			{
				return this.aiBlackboardCdDel_;
			}
		}

		// Token: 0x17006532 RID: 25906
		// (get) Token: 0x0601DB79 RID: 121721 RVA: 0x0045C057 File Offset: 0x0045A257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Long> AiBlackboardCdModify
		{
			get
			{
				return this.aiBlackboardCdModify_;
			}
		}

		// Token: 0x17006533 RID: 25907
		// (get) Token: 0x0601DB7A RID: 121722 RVA: 0x0045C05F File Offset: 0x0045A25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Bool> AiBlackboardCdComplete
		{
			get
			{
				return this.aiBlackboardCdComplete_;
			}
		}

		// Token: 0x0601DB7B RID: 121723 RVA: 0x0045C067 File Offset: 0x0045A267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardCdNotify);
		}

		// Token: 0x0601DB7C RID: 121724 RVA: 0x0045C078 File Offset: 0x0045A278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardCdNotify other)
		{
			return other != null && (other == this || (this.aiBlackboardCdDel_.Equals(other.aiBlackboardCdDel_) && this.aiBlackboardCdModify_.Equals(other.aiBlackboardCdModify_) && this.aiBlackboardCdComplete_.Equals(other.aiBlackboardCdComplete_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DB7D RID: 121725 RVA: 0x0045C0E0 File Offset: 0x0045A2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboardCdDel_.GetHashCode();
			num ^= this.aiBlackboardCdModify_.GetHashCode();
			num ^= this.aiBlackboardCdComplete_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DB7E RID: 121726 RVA: 0x0045C130 File Offset: 0x0045A330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DB7F RID: 121727 RVA: 0x0045C13D File Offset: 0x0045A33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DB80 RID: 121728 RVA: 0x0045C148 File Offset: 0x0045A348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboardCdComplete_.WriteTo(ref output, AiBlackboardCdNotify._repeated_aiBlackboardCdComplete_codec);
			this.aiBlackboardCdDel_.WriteTo(ref output, AiBlackboardCdNotify._repeated_aiBlackboardCdDel_codec);
			this.aiBlackboardCdModify_.WriteTo(ref output, AiBlackboardCdNotify._repeated_aiBlackboardCdModify_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DB81 RID: 121729 RVA: 0x0045C19C File Offset: 0x0045A39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboardCdDel_.CalculateSize(AiBlackboardCdNotify._repeated_aiBlackboardCdDel_codec);
			num += this.aiBlackboardCdModify_.CalculateSize(AiBlackboardCdNotify._repeated_aiBlackboardCdModify_codec);
			num += this.aiBlackboardCdComplete_.CalculateSize(AiBlackboardCdNotify._repeated_aiBlackboardCdComplete_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DB82 RID: 121730 RVA: 0x0045C1FC File Offset: 0x0045A3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardCdNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboardCdDel_.Add(other.aiBlackboardCdDel_);
			this.aiBlackboardCdModify_.Add(other.aiBlackboardCdModify_);
			this.aiBlackboardCdComplete_.Add(other.aiBlackboardCdComplete_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DB83 RID: 121731 RVA: 0x0045C257 File Offset: 0x0045A457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DB84 RID: 121732 RVA: 0x0045C260 File Offset: 0x0045A460
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
				if (num <= 96U)
				{
					if (num == 42U)
					{
						this.aiBlackboardCdComplete_.AddEntriesFrom(ref input, AiBlackboardCdNotify._repeated_aiBlackboardCdComplete_codec);
						continue;
					}
					if (num == 96U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 98U)
					{
						goto IL_4B;
					}
					if (num == 122U)
					{
						this.aiBlackboardCdModify_.AddEntriesFrom(ref input, AiBlackboardCdNotify._repeated_aiBlackboardCdModify_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.aiBlackboardCdDel_.AddEntriesFrom(ref input, AiBlackboardCdNotify._repeated_aiBlackboardCdDel_codec);
			}
		}

		// Token: 0x0400C931 RID: 51505
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C932 RID: 51506
		public const int AiBlackboardCdDelFieldNumber = 12;

		// Token: 0x0400C933 RID: 51507
		private static readonly FieldCodec<int> _repeated_aiBlackboardCdDel_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400C934 RID: 51508
		private readonly RepeatedField<int> aiBlackboardCdDel_ = new RepeatedField<int>();

		// Token: 0x0400C935 RID: 51509
		public const int AiBlackboardCdModifyFieldNumber = 15;

		// Token: 0x0400C936 RID: 51510
		private static readonly FieldCodec<Int2Long> _repeated_aiBlackboardCdModify_codec = FieldCodec.ForMessage<Int2Long>(122U, Int2Long.Parser);

		// Token: 0x0400C937 RID: 51511
		private readonly RepeatedField<Int2Long> aiBlackboardCdModify_ = new RepeatedField<Int2Long>();

		// Token: 0x0400C938 RID: 51512
		public const int AiBlackboardCdCompleteFieldNumber = 5;

		// Token: 0x0400C939 RID: 51513
		private static readonly FieldCodec<Int2Bool> _repeated_aiBlackboardCdComplete_codec = FieldCodec.ForMessage<Int2Bool>(42U, Int2Bool.Parser);

		// Token: 0x0400C93A RID: 51514
		private readonly RepeatedField<Int2Bool> aiBlackboardCdComplete_ = new RepeatedField<Int2Bool>();
	}
}
