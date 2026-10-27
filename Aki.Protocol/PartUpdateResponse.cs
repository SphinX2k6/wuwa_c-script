using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCA RID: 3018
	[NetMessage(EMessageId.PartUpdateResponse)]
	public sealed class PartUpdateResponse : IMessage<PartUpdateResponse>, IMessage, IEquatable<PartUpdateResponse>, IDeepCloneable<PartUpdateResponse>, IBufferMessage
	{
		// Token: 0x0601059B RID: 66971 RVA: 0x00262938 File Offset: 0x00260B38
		[NullableContext(1)]
		public static PartUpdateResponse Create()
		{
			return new PartUpdateResponse();
		}

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0601059C RID: 66972 RVA: 0x0026293F File Offset: 0x00260B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x0601059D RID: 66973 RVA: 0x00262942 File Offset: 0x00260B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601059E RID: 66974 RVA: 0x00262949 File Offset: 0x00260B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateResponse()
		{
		}

		// Token: 0x0601059F RID: 66975 RVA: 0x00262951 File Offset: 0x00260B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateResponse(PartUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060105A0 RID: 66976 RVA: 0x00262976 File Offset: 0x00260B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateResponse Clone()
		{
			return new PartUpdateResponse(this);
		}

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x060105A1 RID: 66977 RVA: 0x0026297E File Offset: 0x00260B7E
		// (set) Token: 0x060105A2 RID: 66978 RVA: 0x00262986 File Offset: 0x00260B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060105A3 RID: 66979 RVA: 0x0026298F File Offset: 0x00260B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartUpdateResponse);
		}

		// Token: 0x060105A4 RID: 66980 RVA: 0x0026299D File Offset: 0x00260B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060105A5 RID: 66981 RVA: 0x002629CC File Offset: 0x00260BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060105A6 RID: 66982 RVA: 0x00262A11 File Offset: 0x00260C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060105A7 RID: 66983 RVA: 0x00262A1E File Offset: 0x00260C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060105A8 RID: 66984 RVA: 0x00262A27 File Offset: 0x00260C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060105A9 RID: 66985 RVA: 0x00262A5C File Offset: 0x00260C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060105AA RID: 66986 RVA: 0x00262A9A File Offset: 0x00260C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060105AB RID: 66987 RVA: 0x00262ACB File Offset: 0x00260CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060105AC RID: 66988 RVA: 0x00262AD4 File Offset: 0x00260CD4
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040067DB RID: 26587
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067DC RID: 26588
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040067DD RID: 26589
		private ErrorCode errorCode_;
	}
}
