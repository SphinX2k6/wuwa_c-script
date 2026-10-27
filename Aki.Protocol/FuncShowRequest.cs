using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000677 RID: 1655
	[NetMessage(EMessageId.FuncShowRequest)]
	public sealed class FuncShowRequest : IMessage<FuncShowRequest>, IMessage, IEquatable<FuncShowRequest>, IDeepCloneable<FuncShowRequest>, IBufferMessage
	{
		// Token: 0x060097B5 RID: 38837 RVA: 0x0016DDC8 File Offset: 0x0016BFC8
		[NullableContext(1)]
		public static FuncShowRequest Create()
		{
			return new FuncShowRequest();
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x060097B6 RID: 38838 RVA: 0x0016DDCF File Offset: 0x0016BFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x060097B7 RID: 38839 RVA: 0x0016DDD2 File Offset: 0x0016BFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FuncShowRequest.Descriptor;
			}
		}

		// Token: 0x060097B8 RID: 38840 RVA: 0x0016DDD9 File Offset: 0x0016BFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowRequest()
		{
		}

		// Token: 0x060097B9 RID: 38841 RVA: 0x0016DDEC File Offset: 0x0016BFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowRequest(FuncShowRequest other) : this()
		{
			this.funcId_ = other.funcId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097BA RID: 38842 RVA: 0x0016DE16 File Offset: 0x0016C016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowRequest Clone()
		{
			return new FuncShowRequest(this);
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x060097BB RID: 38843 RVA: 0x0016DE1E File Offset: 0x0016C01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FuncId
		{
			get
			{
				return this.funcId_;
			}
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x0016DE26 File Offset: 0x0016C026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FuncShowRequest);
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x0016DE34 File Offset: 0x0016C034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FuncShowRequest other)
		{
			return other != null && (other == this || (this.funcId_.Equals(other.funcId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x0016DE68 File Offset: 0x0016C068
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

		// Token: 0x060097BF RID: 38847 RVA: 0x0016DE9C File Offset: 0x0016C09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060097C0 RID: 38848 RVA: 0x0016DEA9 File Offset: 0x0016C0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097C1 RID: 38849 RVA: 0x0016DEB2 File Offset: 0x0016C0B2
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

		// Token: 0x060097C2 RID: 38850 RVA: 0x0016DEDC File Offset: 0x0016C0DC
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

		// Token: 0x060097C3 RID: 38851 RVA: 0x0016DF15 File Offset: 0x0016C115
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

		// Token: 0x060097C4 RID: 38852 RVA: 0x0016DF43 File Offset: 0x0016C143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097C5 RID: 38853 RVA: 0x0016DF4C File Offset: 0x0016C14C
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.funcId_.AddEntriesFrom(ref input, FuncShowRequest._repeated_funcId_codec);
				}
			}
		}

		// Token: 0x04004812 RID: 18450
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004813 RID: 18451
		public const int FuncIdFieldNumber = 8;

		// Token: 0x04004814 RID: 18452
		private static readonly FieldCodec<int> _repeated_funcId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04004815 RID: 18453
		private readonly RepeatedField<int> funcId_ = new RepeatedField<int>();
	}
}
