using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081D RID: 2077
	public sealed class InteractComponentPb : IMessage<InteractComponentPb>, IMessage, IEquatable<InteractComponentPb>, IDeepCloneable<InteractComponentPb>, IBufferMessage
	{
		// Token: 0x0600BA11 RID: 47633 RVA: 0x001BBBD8 File Offset: 0x001B9DD8
		[NullableContext(1)]
		public static InteractComponentPb Create()
		{
			return new InteractComponentPb();
		}

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x0600BA12 RID: 47634 RVA: 0x001BBBDF File Offset: 0x001B9DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x0600BA13 RID: 47635 RVA: 0x001BBBE2 File Offset: 0x001B9DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractComponentPb.Descriptor;
			}
		}

		// Token: 0x0600BA14 RID: 47636 RVA: 0x001BBBE9 File Offset: 0x001B9DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractComponentPb()
		{
		}

		// Token: 0x0600BA15 RID: 47637 RVA: 0x001BBC08 File Offset: 0x001B9E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractComponentPb(InteractComponentPb other) : this()
		{
			this.dynamicInteractInfos_ = other.dynamicInteractInfos_.Clone();
			this.randomInteractIndex_ = other.randomInteractIndex_.Clone();
			this.interacting_ = other.interacting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA16 RID: 47638 RVA: 0x001BBC5A File Offset: 0x001B9E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractComponentPb Clone()
		{
			return new InteractComponentPb(this);
		}

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x0600BA17 RID: 47639 RVA: 0x001BBC62 File Offset: 0x001B9E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicInteractInfo> DynamicInteractInfos
		{
			get
			{
				return this.dynamicInteractInfos_;
			}
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x0600BA18 RID: 47640 RVA: 0x001BBC6A File Offset: 0x001B9E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RandomInteractIndex
		{
			get
			{
				return this.randomInteractIndex_;
			}
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x0600BA19 RID: 47641 RVA: 0x001BBC72 File Offset: 0x001B9E72
		// (set) Token: 0x0600BA1A RID: 47642 RVA: 0x001BBC7A File Offset: 0x001B9E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Interacting
		{
			get
			{
				return this.interacting_;
			}
			set
			{
				this.interacting_ = value;
			}
		}

		// Token: 0x0600BA1B RID: 47643 RVA: 0x001BBC83 File Offset: 0x001B9E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractComponentPb);
		}

		// Token: 0x0600BA1C RID: 47644 RVA: 0x001BBC94 File Offset: 0x001B9E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractComponentPb other)
		{
			return other != null && (other == this || (this.dynamicInteractInfos_.Equals(other.dynamicInteractInfos_) && this.randomInteractIndex_.Equals(other.randomInteractIndex_) && this.Interacting == other.Interacting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA1D RID: 47645 RVA: 0x001BBCF8 File Offset: 0x001B9EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dynamicInteractInfos_.GetHashCode();
			num ^= this.randomInteractIndex_.GetHashCode();
			if (this.Interacting)
			{
				num ^= this.Interacting.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA1E RID: 47646 RVA: 0x001BBD53 File Offset: 0x001B9F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA1F RID: 47647 RVA: 0x001BBD60 File Offset: 0x001B9F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA20 RID: 47648 RVA: 0x001BBD6C File Offset: 0x001B9F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dynamicInteractInfos_.WriteTo(ref output, InteractComponentPb._repeated_dynamicInteractInfos_codec);
			this.randomInteractIndex_.WriteTo(ref output, InteractComponentPb._repeated_randomInteractIndex_codec);
			if (this.Interacting)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Interacting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA21 RID: 47649 RVA: 0x001BBDCC File Offset: 0x001B9FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dynamicInteractInfos_.CalculateSize(InteractComponentPb._repeated_dynamicInteractInfos_codec);
			num += this.randomInteractIndex_.CalculateSize(InteractComponentPb._repeated_randomInteractIndex_codec);
			if (this.Interacting)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA22 RID: 47650 RVA: 0x001BBE24 File Offset: 0x001BA024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.dynamicInteractInfos_.Add(other.dynamicInteractInfos_);
			this.randomInteractIndex_.Add(other.randomInteractIndex_);
			if (other.Interacting)
			{
				this.Interacting = other.Interacting;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA23 RID: 47651 RVA: 0x001BBE82 File Offset: 0x001BA082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA24 RID: 47652 RVA: 0x001BBE8C File Offset: 0x001BA08C
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.dynamicInteractInfos_.AddEntriesFrom(ref input, InteractComponentPb._repeated_dynamicInteractInfos_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4B;
					}
					if (num == 24U)
					{
						this.Interacting = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.randomInteractIndex_.AddEntriesFrom(ref input, InteractComponentPb._repeated_randomInteractIndex_codec);
			}
		}

		// Token: 0x0400523B RID: 21051
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400523C RID: 21052
		public const int DynamicInteractInfosFieldNumber = 1;

		// Token: 0x0400523D RID: 21053
		private static readonly FieldCodec<DynamicInteractInfo> _repeated_dynamicInteractInfos_codec = FieldCodec.ForMessage<DynamicInteractInfo>(10U, DynamicInteractInfo.Parser);

		// Token: 0x0400523E RID: 21054
		private readonly RepeatedField<DynamicInteractInfo> dynamicInteractInfos_ = new RepeatedField<DynamicInteractInfo>();

		// Token: 0x0400523F RID: 21055
		public const int RandomInteractIndexFieldNumber = 2;

		// Token: 0x04005240 RID: 21056
		private static readonly FieldCodec<int> _repeated_randomInteractIndex_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005241 RID: 21057
		private readonly RepeatedField<int> randomInteractIndex_ = new RepeatedField<int>();

		// Token: 0x04005242 RID: 21058
		public const int InteractingFieldNumber = 3;

		// Token: 0x04005243 RID: 21059
		private bool interacting_;
	}
}
