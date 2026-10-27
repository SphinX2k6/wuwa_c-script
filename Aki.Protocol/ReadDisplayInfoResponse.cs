using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E99 RID: 3737
	[NetMessage(EMessageId.ReadDisplayInfoResponse)]
	public sealed class ReadDisplayInfoResponse : IMessage<ReadDisplayInfoResponse>, IMessage, IEquatable<ReadDisplayInfoResponse>, IDeepCloneable<ReadDisplayInfoResponse>, IBufferMessage
	{
		// Token: 0x06014100 RID: 82176 RVA: 0x002EBAD9 File Offset: 0x002E9CD9
		[NullableContext(1)]
		public static ReadDisplayInfoResponse Create()
		{
			return new ReadDisplayInfoResponse();
		}

		// Token: 0x170042BA RID: 17082
		// (get) Token: 0x06014101 RID: 82177 RVA: 0x002EBAE0 File Offset: 0x002E9CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042BB RID: 17083
		// (get) Token: 0x06014102 RID: 82178 RVA: 0x002EBAE3 File Offset: 0x002E9CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReadDisplayInfoResponse.Descriptor;
			}
		}

		// Token: 0x06014103 RID: 82179 RVA: 0x002EBAEA File Offset: 0x002E9CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoResponse()
		{
		}

		// Token: 0x06014104 RID: 82180 RVA: 0x002EBAF2 File Offset: 0x002E9CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoResponse(ReadDisplayInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014105 RID: 82181 RVA: 0x002EBB17 File Offset: 0x002E9D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadDisplayInfoResponse Clone()
		{
			return new ReadDisplayInfoResponse(this);
		}

		// Token: 0x170042BC RID: 17084
		// (get) Token: 0x06014106 RID: 82182 RVA: 0x002EBB1F File Offset: 0x002E9D1F
		// (set) Token: 0x06014107 RID: 82183 RVA: 0x002EBB27 File Offset: 0x002E9D27
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

		// Token: 0x06014108 RID: 82184 RVA: 0x002EBB30 File Offset: 0x002E9D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReadDisplayInfoResponse);
		}

		// Token: 0x06014109 RID: 82185 RVA: 0x002EBB3E File Offset: 0x002E9D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReadDisplayInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601410A RID: 82186 RVA: 0x002EBB6C File Offset: 0x002E9D6C
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

		// Token: 0x0601410B RID: 82187 RVA: 0x002EBBB1 File Offset: 0x002E9DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601410C RID: 82188 RVA: 0x002EBBBE File Offset: 0x002E9DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601410D RID: 82189 RVA: 0x002EBBC7 File Offset: 0x002E9DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601410E RID: 82190 RVA: 0x002EBBF8 File Offset: 0x002E9DF8
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

		// Token: 0x0601410F RID: 82191 RVA: 0x002EBC36 File Offset: 0x002E9E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReadDisplayInfoResponse other)
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

		// Token: 0x06014110 RID: 82192 RVA: 0x002EBC67 File Offset: 0x002E9E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014111 RID: 82193 RVA: 0x002EBC70 File Offset: 0x002E9E70
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007A5D RID: 31325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A5E RID: 31326
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007A5F RID: 31327
		private ErrorCode errorCode_;
	}
}
