using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B93 RID: 2963
	[NetMessage(EMessageId.OpenSystemBoardResultResponse)]
	public sealed class OpenSystemBoardResultResponse : IMessage<OpenSystemBoardResultResponse>, IMessage, IEquatable<OpenSystemBoardResultResponse>, IDeepCloneable<OpenSystemBoardResultResponse>, IBufferMessage
	{
		// Token: 0x06010172 RID: 65906 RVA: 0x00259CDB File Offset: 0x00257EDB
		[NullableContext(1)]
		public static OpenSystemBoardResultResponse Create()
		{
			return new OpenSystemBoardResultResponse();
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x06010173 RID: 65907 RVA: 0x00259CE2 File Offset: 0x00257EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x06010174 RID: 65908 RVA: 0x00259CE5 File Offset: 0x00257EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenSystemBoardResultResponse.Descriptor;
			}
		}

		// Token: 0x06010175 RID: 65909 RVA: 0x00259CEC File Offset: 0x00257EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultResponse()
		{
		}

		// Token: 0x06010176 RID: 65910 RVA: 0x00259CF4 File Offset: 0x00257EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultResponse(OpenSystemBoardResultResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010177 RID: 65911 RVA: 0x00259D19 File Offset: 0x00257F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultResponse Clone()
		{
			return new OpenSystemBoardResultResponse(this);
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x06010178 RID: 65912 RVA: 0x00259D21 File Offset: 0x00257F21
		// (set) Token: 0x06010179 RID: 65913 RVA: 0x00259D29 File Offset: 0x00257F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0601017A RID: 65914 RVA: 0x00259D32 File Offset: 0x00257F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenSystemBoardResultResponse);
		}

		// Token: 0x0601017B RID: 65915 RVA: 0x00259D40 File Offset: 0x00257F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OpenSystemBoardResultResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601017C RID: 65916 RVA: 0x00259D70 File Offset: 0x00257F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601017D RID: 65917 RVA: 0x00259DB5 File Offset: 0x00257FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601017E RID: 65918 RVA: 0x00259DC2 File Offset: 0x00257FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601017F RID: 65919 RVA: 0x00259DCB File Offset: 0x00257FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010180 RID: 65920 RVA: 0x00259E00 File Offset: 0x00258000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010181 RID: 65921 RVA: 0x00259E3E File Offset: 0x0025803E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OpenSystemBoardResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010182 RID: 65922 RVA: 0x00259E6F File Offset: 0x0025806F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010183 RID: 65923 RVA: 0x00259E78 File Offset: 0x00258078
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040066FC RID: 26364
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066FD RID: 26365
		public const int CodeFieldNumber = 6;

		// Token: 0x040066FE RID: 26366
		private ErrorCode code_;
	}
}
