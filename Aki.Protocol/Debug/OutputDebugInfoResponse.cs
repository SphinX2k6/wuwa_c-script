using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200169E RID: 5790
	[NetMessage(EMessageId.OutputDebugInfoResponse)]
	public sealed class OutputDebugInfoResponse : IMessage<OutputDebugInfoResponse>, IMessage, IEquatable<OutputDebugInfoResponse>, IDeepCloneable<OutputDebugInfoResponse>, IBufferMessage
	{
		// Token: 0x0601D04D RID: 118861 RVA: 0x0043F605 File Offset: 0x0043D805
		[NullableContext(1)]
		public static OutputDebugInfoResponse Create()
		{
			return new OutputDebugInfoResponse();
		}

		// Token: 0x17006276 RID: 25206
		// (get) Token: 0x0601D04E RID: 118862 RVA: 0x0043F60C File Offset: 0x0043D80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006277 RID: 25207
		// (get) Token: 0x0601D04F RID: 118863 RVA: 0x0043F60F File Offset: 0x0043D80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OutputDebugInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601D050 RID: 118864 RVA: 0x0043F616 File Offset: 0x0043D816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoResponse()
		{
		}

		// Token: 0x0601D051 RID: 118865 RVA: 0x0043F61E File Offset: 0x0043D81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoResponse(OutputDebugInfoResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D052 RID: 118866 RVA: 0x0043F637 File Offset: 0x0043D837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoResponse Clone()
		{
			return new OutputDebugInfoResponse(this);
		}

		// Token: 0x0601D053 RID: 118867 RVA: 0x0043F63F File Offset: 0x0043D83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OutputDebugInfoResponse);
		}

		// Token: 0x0601D054 RID: 118868 RVA: 0x0043F64D File Offset: 0x0043D84D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OutputDebugInfoResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D055 RID: 118869 RVA: 0x0043F66C File Offset: 0x0043D86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D056 RID: 118870 RVA: 0x0043F692 File Offset: 0x0043D892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D057 RID: 118871 RVA: 0x0043F69F File Offset: 0x0043D89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D058 RID: 118872 RVA: 0x0043F6A8 File Offset: 0x0043D8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D059 RID: 118873 RVA: 0x0043F6C0 File Offset: 0x0043D8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D05A RID: 118874 RVA: 0x0043F6E6 File Offset: 0x0043D8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OutputDebugInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D05B RID: 118875 RVA: 0x0043F703 File Offset: 0x0043D903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D05C RID: 118876 RVA: 0x0043F70C File Offset: 0x0043D90C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C3E1 RID: 50145
		private UnknownFieldSet _unknownFields;
	}
}
