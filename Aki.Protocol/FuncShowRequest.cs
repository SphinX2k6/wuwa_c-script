using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000663 RID: 1635
	[NetMessage(EMessageId.FuncShowRequest)]
	public sealed class FuncShowRequest : IMessage<FuncShowRequest>, IMessage, IEquatable<FuncShowRequest>, IDeepCloneable<FuncShowRequest>, IBufferMessage
	{
		// Token: 0x0600965F RID: 38495 RVA: 0x0016B394 File Offset: 0x00169594
		[NullableContext(1)]
		public static FuncShowRequest Create()
		{
			return new FuncShowRequest();
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06009660 RID: 38496 RVA: 0x0016B39B File Offset: 0x0016959B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06009661 RID: 38497 RVA: 0x0016B39E File Offset: 0x0016959E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FuncShowRequest.Descriptor;
			}
		}

		// Token: 0x06009662 RID: 38498 RVA: 0x0016B3A5 File Offset: 0x001695A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowRequest()
		{
		}

		// Token: 0x06009663 RID: 38499 RVA: 0x0016B3B8 File Offset: 0x001695B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowRequest(FuncShowRequest other) : this()
		{
			this.funcId_ = other.funcId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009664 RID: 38500 RVA: 0x0016B3E2 File Offset: 0x001695E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowRequest Clone()
		{
			return new FuncShowRequest(this);
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06009665 RID: 38501 RVA: 0x0016B3EA File Offset: 0x001695EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FuncId
		{
			get
			{
				return this.funcId_;
			}
		}

		// Token: 0x06009666 RID: 38502 RVA: 0x0016B3F2 File Offset: 0x001695F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FuncShowRequest);
		}

		// Token: 0x06009667 RID: 38503 RVA: 0x0016B400 File Offset: 0x00169600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FuncShowRequest other)
		{
			return other != null && (other == this || (this.funcId_.Equals(other.funcId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009668 RID: 38504 RVA: 0x0016B434 File Offset: 0x00169634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.funcId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009669 RID: 38505 RVA: 0x0016B468 File Offset: 0x00169668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600966A RID: 38506 RVA: 0x0016B475 File Offset: 0x00169675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x0016B47E File Offset: 0x0016967E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.funcId_.WriteTo(ref output, FuncShowRequest._repeated_funcId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600966C RID: 38508 RVA: 0x0016B4A8 File Offset: 0x001696A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.funcId_.CalculateSize(FuncShowRequest._repeated_funcId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600966D RID: 38509 RVA: 0x0016B4E1 File Offset: 0x001696E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FuncShowRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.funcId_.Add(other.funcId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600966E RID: 38510 RVA: 0x0016B50F File Offset: 0x0016970F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600966F RID: 38511 RVA: 0x0016B518 File Offset: 0x00169718
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.funcId_.AddEntriesFrom(ref input, FuncShowRequest._repeated_funcId_codec);
				}
			}
		}

		// Token: 0x0400480B RID: 18443
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400480C RID: 18444
		public const int FuncIdFieldNumber = 10;

		// Token: 0x0400480D RID: 18445
		private static readonly FieldCodec<int> _repeated_funcId_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400480E RID: 18446
		private readonly RepeatedField<int> funcId_ = new RepeatedField<int>();
	}
}
