using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066A RID: 1642
	[NetMessage(EMessageId.FunPlayChallengeInfoUpdateNotify)]
	public sealed class FunPlayChallengeInfoUpdateNotify : IMessage<FunPlayChallengeInfoUpdateNotify>, IMessage, IEquatable<FunPlayChallengeInfoUpdateNotify>, IDeepCloneable<FunPlayChallengeInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060096EA RID: 38634 RVA: 0x0016C46F File Offset: 0x0016A66F
		[NullableContext(1)]
		public static FunPlayChallengeInfoUpdateNotify Create()
		{
			return new FunPlayChallengeInfoUpdateNotify();
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x060096EB RID: 38635 RVA: 0x0016C476 File Offset: 0x0016A676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x060096EC RID: 38636 RVA: 0x0016C479 File Offset: 0x0016A679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayChallengeInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060096ED RID: 38637 RVA: 0x0016C480 File Offset: 0x0016A680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeInfoUpdateNotify()
		{
		}

		// Token: 0x060096EE RID: 38638 RVA: 0x0016C493 File Offset: 0x0016A693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeInfoUpdateNotify(FunPlayChallengeInfoUpdateNotify other) : this()
		{
			this.funPlayChallengeInfos_ = other.funPlayChallengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096EF RID: 38639 RVA: 0x0016C4BD File Offset: 0x0016A6BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeInfoUpdateNotify Clone()
		{
			return new FunPlayChallengeInfoUpdateNotify(this);
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x060096F0 RID: 38640 RVA: 0x0016C4C5 File Offset: 0x0016A6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FunPlayChallengeInfo> FunPlayChallengeInfos
		{
			get
			{
				return this.funPlayChallengeInfos_;
			}
		}

		// Token: 0x060096F1 RID: 38641 RVA: 0x0016C4CD File Offset: 0x0016A6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayChallengeInfoUpdateNotify);
		}

		// Token: 0x060096F2 RID: 38642 RVA: 0x0016C4DB File Offset: 0x0016A6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayChallengeInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.funPlayChallengeInfos_.Equals(other.funPlayChallengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096F3 RID: 38643 RVA: 0x0016C510 File Offset: 0x0016A710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.funPlayChallengeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060096F4 RID: 38644 RVA: 0x0016C544 File Offset: 0x0016A744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060096F5 RID: 38645 RVA: 0x0016C551 File Offset: 0x0016A751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096F6 RID: 38646 RVA: 0x0016C55A File Offset: 0x0016A75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.funPlayChallengeInfos_.WriteTo(ref output, FunPlayChallengeInfoUpdateNotify._repeated_funPlayChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096F7 RID: 38647 RVA: 0x0016C584 File Offset: 0x0016A784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.funPlayChallengeInfos_.CalculateSize(FunPlayChallengeInfoUpdateNotify._repeated_funPlayChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096F8 RID: 38648 RVA: 0x0016C5BD File Offset: 0x0016A7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FunPlayChallengeInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.funPlayChallengeInfos_.Add(other.funPlayChallengeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096F9 RID: 38649 RVA: 0x0016C5EB File Offset: 0x0016A7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096FA RID: 38650 RVA: 0x0016C5F4 File Offset: 0x0016A7F4
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.funPlayChallengeInfos_.AddEntriesFrom(ref input, FunPlayChallengeInfoUpdateNotify._repeated_funPlayChallengeInfos_codec);
				}
			}
		}

		// Token: 0x0400482F RID: 18479
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004830 RID: 18480
		public const int FunPlayChallengeInfosFieldNumber = 13;

		// Token: 0x04004831 RID: 18481
		private static readonly FieldCodec<FunPlayChallengeInfo> _repeated_funPlayChallengeInfos_codec = FieldCodec.ForMessage<FunPlayChallengeInfo>(106U, FunPlayChallengeInfo.Parser);

		// Token: 0x04004832 RID: 18482
		private readonly RepeatedField<FunPlayChallengeInfo> funPlayChallengeInfos_ = new RepeatedField<FunPlayChallengeInfo>();
	}
}
