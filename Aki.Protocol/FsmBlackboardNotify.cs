using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000652 RID: 1618
	[NetMessage(EMessageId.FsmBlackboardNotify)]
	public sealed class FsmBlackboardNotify : IMessage<FsmBlackboardNotify>, IMessage, IEquatable<FsmBlackboardNotify>, IDeepCloneable<FsmBlackboardNotify>, IBufferMessage
	{
		// Token: 0x060094F5 RID: 38133 RVA: 0x00167E4E File Offset: 0x0016604E
		[NullableContext(1)]
		public static FsmBlackboardNotify Create()
		{
			return new FsmBlackboardNotify();
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x060094F6 RID: 38134 RVA: 0x00167E55 File Offset: 0x00166055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x060094F7 RID: 38135 RVA: 0x00167E58 File Offset: 0x00166058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmBlackboardNotify.Descriptor;
			}
		}

		// Token: 0x060094F8 RID: 38136 RVA: 0x00167E5F File Offset: 0x0016605F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmBlackboardNotify()
		{
		}

		// Token: 0x060094F9 RID: 38137 RVA: 0x00167E72 File Offset: 0x00166072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmBlackboardNotify(FsmBlackboardNotify other) : this()
		{
			this.fsmBlackBoards_ = other.fsmBlackBoards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094FA RID: 38138 RVA: 0x00167E9C File Offset: 0x0016609C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmBlackboardNotify Clone()
		{
			return new FsmBlackboardNotify(this);
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x060094FB RID: 38139 RVA: 0x00167EA4 File Offset: 0x001660A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DFsmBlackBoard> FsmBlackBoards
		{
			get
			{
				return this.fsmBlackBoards_;
			}
		}

		// Token: 0x060094FC RID: 38140 RVA: 0x00167EAC File Offset: 0x001660AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmBlackboardNotify);
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x00167EBA File Offset: 0x001660BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmBlackboardNotify other)
		{
			return other != null && (other == this || (this.fsmBlackBoards_.Equals(other.fsmBlackBoards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094FE RID: 38142 RVA: 0x00167EF0 File Offset: 0x001660F0
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

		// Token: 0x060094FF RID: 38143 RVA: 0x00167F24 File Offset: 0x00166124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009500 RID: 38144 RVA: 0x00167F31 File Offset: 0x00166131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009501 RID: 38145 RVA: 0x00167F3A File Offset: 0x0016613A
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

		// Token: 0x06009502 RID: 38146 RVA: 0x00167F64 File Offset: 0x00166164
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

		// Token: 0x06009503 RID: 38147 RVA: 0x00167F9D File Offset: 0x0016619D
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

		// Token: 0x06009504 RID: 38148 RVA: 0x00167FCB File Offset: 0x001661CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009505 RID: 38149 RVA: 0x00167FD4 File Offset: 0x001661D4
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.fsmBlackBoards_.AddEntriesFrom(ref input, FsmBlackboardNotify._repeated_fsmBlackBoards_codec);
				}
			}
		}

		// Token: 0x0400479C RID: 18332
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400479D RID: 18333
		public const int FsmBlackBoardsFieldNumber = 5;

		// Token: 0x0400479E RID: 18334
		private static readonly FieldCodec<DFsmBlackBoard> _repeated_fsmBlackBoards_codec = FieldCodec.ForMessage<DFsmBlackBoard>(42U, DFsmBlackBoard.Parser);

		// Token: 0x0400479F RID: 18335
		private readonly RepeatedField<DFsmBlackBoard> fsmBlackBoards_ = new RepeatedField<DFsmBlackBoard>();
	}
}
