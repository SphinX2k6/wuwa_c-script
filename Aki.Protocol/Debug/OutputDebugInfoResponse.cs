using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200171A RID: 5914
	[NetMessage(EMessageId.OutputDebugInfoResponse)]
	public sealed class OutputDebugInfoResponse : IMessage<OutputDebugInfoResponse>, IMessage, IEquatable<OutputDebugInfoResponse>, IDeepCloneable<OutputDebugInfoResponse>, IBufferMessage
	{
		// Token: 0x0601DB1C RID: 121628 RVA: 0x0045B345 File Offset: 0x00459545
		[NullableContext(1)]
		public static OutputDebugInfoResponse Create()
		{
			return new OutputDebugInfoResponse();
		}

		// Token: 0x1700651B RID: 25883
		// (get) Token: 0x0601DB1D RID: 121629 RVA: 0x0045B34C File Offset: 0x0045954C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700651C RID: 25884
		// (get) Token: 0x0601DB1E RID: 121630 RVA: 0x0045B34F File Offset: 0x0045954F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OutputDebugInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601DB1F RID: 121631 RVA: 0x0045B356 File Offset: 0x00459556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoResponse()
		{
		}

		// Token: 0x0601DB20 RID: 121632 RVA: 0x0045B35E File Offset: 0x0045955E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoResponse(OutputDebugInfoResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DB21 RID: 121633 RVA: 0x0045B377 File Offset: 0x00459577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OutputDebugInfoResponse Clone()
		{
			return new OutputDebugInfoResponse(this);
		}

		// Token: 0x0601DB22 RID: 121634 RVA: 0x0045B37F File Offset: 0x0045957F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OutputDebugInfoResponse);
		}

		// Token: 0x0601DB23 RID: 121635 RVA: 0x0045B38D File Offset: 0x0045958D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OutputDebugInfoResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601DB24 RID: 121636 RVA: 0x0045B3AC File Offset: 0x004595AC
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

		// Token: 0x0601DB25 RID: 121637 RVA: 0x0045B3D2 File Offset: 0x004595D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DB26 RID: 121638 RVA: 0x0045B3DF File Offset: 0x004595DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DB27 RID: 121639 RVA: 0x0045B3E8 File Offset: 0x004595E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DB28 RID: 121640 RVA: 0x0045B400 File Offset: 0x00459600
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

		// Token: 0x0601DB29 RID: 121641 RVA: 0x0045B426 File Offset: 0x00459626
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

		// Token: 0x0601DB2A RID: 121642 RVA: 0x0045B443 File Offset: 0x00459643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DB2B RID: 121643 RVA: 0x0045B44C File Offset: 0x0045964C
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

		// Token: 0x0400C910 RID: 51472
		private UnknownFieldSet _unknownFields;
	}
}
