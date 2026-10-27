using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000120 RID: 288
	[NetMessage(EMessageId.AttachEntityResponse)]
	public sealed class AttachEntityResponse : IMessage<AttachEntityResponse>, IMessage, IEquatable<AttachEntityResponse>, IDeepCloneable<AttachEntityResponse>, IBufferMessage
	{
		// Token: 0x060026ED RID: 9965 RVA: 0x000675E3 File Offset: 0x000657E3
		[NullableContext(1)]
		public static AttachEntityResponse Create()
		{
			return new AttachEntityResponse();
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x000675EA File Offset: 0x000657EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x000675ED File Offset: 0x000657ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttachEntityResponse.Descriptor;
			}
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x000675F4 File Offset: 0x000657F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityResponse()
		{
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000675FC File Offset: 0x000657FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityResponse(AttachEntityResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x00067621 File Offset: 0x00065821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityResponse Clone()
		{
			return new AttachEntityResponse(this);
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x00067629 File Offset: 0x00065829
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x00067631 File Offset: 0x00065831
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

		// Token: 0x060026F5 RID: 9973 RVA: 0x0006763A File Offset: 0x0006583A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttachEntityResponse);
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00067648 File Offset: 0x00065848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttachEntityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x00067678 File Offset: 0x00065878
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

		// Token: 0x060026F8 RID: 9976 RVA: 0x000676BD File Offset: 0x000658BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x000676CA File Offset: 0x000658CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x000676D3 File Offset: 0x000658D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00067708 File Offset: 0x00065908
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

		// Token: 0x060026FC RID: 9980 RVA: 0x00067746 File Offset: 0x00065946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttachEntityResponse other)
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

		// Token: 0x060026FD RID: 9981 RVA: 0x00067777 File Offset: 0x00065977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x00067780 File Offset: 0x00065980
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002640 RID: 9792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002641 RID: 9793
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04002642 RID: 9794
		private ErrorCode errorCode_;
	}
}
