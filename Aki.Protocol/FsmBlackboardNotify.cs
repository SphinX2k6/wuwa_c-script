using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000666 RID: 1638
	[NetMessage(EMessageId.FsmBlackboardNotify)]
	public sealed class FsmBlackboardNotify : IMessage<FsmBlackboardNotify>, IMessage, IEquatable<FsmBlackboardNotify>, IDeepCloneable<FsmBlackboardNotify>, IBufferMessage
	{
		// Token: 0x0600964B RID: 38475 RVA: 0x0016A87A File Offset: 0x00168A7A
		[NullableContext(1)]
		public static FsmBlackboardNotify Create()
		{
			return new FsmBlackboardNotify();
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x0600964C RID: 38476 RVA: 0x0016A881 File Offset: 0x00168A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x0600964D RID: 38477 RVA: 0x0016A884 File Offset: 0x00168A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmBlackboardNotify.Descriptor;
			}
		}

		// Token: 0x0600964E RID: 38478 RVA: 0x0016A88B File Offset: 0x00168A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmBlackboardNotify()
		{
		}

		// Token: 0x0600964F RID: 38479 RVA: 0x0016A89E File Offset: 0x00168A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmBlackboardNotify(FsmBlackboardNotify other) : this()
		{
			this.fsmBlackBoards_ = other.fsmBlackBoards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009650 RID: 38480 RVA: 0x0016A8C8 File Offset: 0x00168AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmBlackboardNotify Clone()
		{
			return new FsmBlackboardNotify(this);
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06009651 RID: 38481 RVA: 0x0016A8D0 File Offset: 0x00168AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DFsmBlackBoard> FsmBlackBoards
		{
			get
			{
				return this.fsmBlackBoards_;
			}
		}

		// Token: 0x06009652 RID: 38482 RVA: 0x0016A8D8 File Offset: 0x00168AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmBlackboardNotify);
		}

		// Token: 0x06009653 RID: 38483 RVA: 0x0016A8E6 File Offset: 0x00168AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmBlackboardNotify other)
		{
			return other != null && (other == this || (this.fsmBlackBoards_.Equals(other.fsmBlackBoards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009654 RID: 38484 RVA: 0x0016A91C File Offset: 0x00168B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fsmBlackBoards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009655 RID: 38485 RVA: 0x0016A950 File Offset: 0x00168B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009656 RID: 38486 RVA: 0x0016A95D File Offset: 0x00168B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009657 RID: 38487 RVA: 0x0016A966 File Offset: 0x00168B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fsmBlackBoards_.WriteTo(ref output, FsmBlackboardNotify._repeated_fsmBlackBoards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009658 RID: 38488 RVA: 0x0016A990 File Offset: 0x00168B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fsmBlackBoards_.CalculateSize(FsmBlackboardNotify._repeated_fsmBlackBoards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009659 RID: 38489 RVA: 0x0016A9C9 File Offset: 0x00168BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmBlackboardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.fsmBlackBoards_.Add(other.fsmBlackBoards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600965A RID: 38490 RVA: 0x0016A9F7 File Offset: 0x00168BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600965B RID: 38491 RVA: 0x0016AA00 File Offset: 0x00168C00
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.fsmBlackBoards_.AddEntriesFrom(ref input, FsmBlackboardNotify._repeated_fsmBlackBoards_codec);
				}
			}
		}

		// Token: 0x040047A3 RID: 18339
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047A4 RID: 18340
		public const int FsmBlackBoardsFieldNumber = 9;

		// Token: 0x040047A5 RID: 18341
		private static readonly FieldCodec<DFsmBlackBoard> _repeated_fsmBlackBoards_codec = FieldCodec.ForMessage<DFsmBlackBoard>(74U, DFsmBlackBoard.Parser);

		// Token: 0x040047A6 RID: 18342
		private readonly RepeatedField<DFsmBlackBoard> fsmBlackBoards_ = new RepeatedField<DFsmBlackBoard>();
	}
}
