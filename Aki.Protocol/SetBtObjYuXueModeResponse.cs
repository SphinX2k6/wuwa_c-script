using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001206 RID: 4614
	[NetMessage(EMessageId.SetBtObjYuXueModeResponse)]
	public sealed class SetBtObjYuXueModeResponse : IMessage<SetBtObjYuXueModeResponse>, IMessage, IEquatable<SetBtObjYuXueModeResponse>, IDeepCloneable<SetBtObjYuXueModeResponse>, IBufferMessage
	{
		// Token: 0x06018A79 RID: 100985 RVA: 0x00398962 File Offset: 0x00396B62
		[NullableContext(1)]
		public static SetBtObjYuXueModeResponse Create()
		{
			return new SetBtObjYuXueModeResponse();
		}

		// Token: 0x17005347 RID: 21319
		// (get) Token: 0x06018A7A RID: 100986 RVA: 0x00398969 File Offset: 0x00396B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005348 RID: 21320
		// (get) Token: 0x06018A7B RID: 100987 RVA: 0x0039896C File Offset: 0x00396B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBtObjYuXueModeResponse.Descriptor;
			}
		}

		// Token: 0x06018A7C RID: 100988 RVA: 0x00398973 File Offset: 0x00396B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeResponse()
		{
		}

		// Token: 0x06018A7D RID: 100989 RVA: 0x0039897B File Offset: 0x00396B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeResponse(SetBtObjYuXueModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A7E RID: 100990 RVA: 0x003989A0 File Offset: 0x00396BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBtObjYuXueModeResponse Clone()
		{
			return new SetBtObjYuXueModeResponse(this);
		}

		// Token: 0x17005349 RID: 21321
		// (get) Token: 0x06018A7F RID: 100991 RVA: 0x003989A8 File Offset: 0x00396BA8
		// (set) Token: 0x06018A80 RID: 100992 RVA: 0x003989B0 File Offset: 0x00396BB0
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

		// Token: 0x06018A81 RID: 100993 RVA: 0x003989B9 File Offset: 0x00396BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBtObjYuXueModeResponse);
		}

		// Token: 0x06018A82 RID: 100994 RVA: 0x003989C7 File Offset: 0x00396BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetBtObjYuXueModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A83 RID: 100995 RVA: 0x003989F8 File Offset: 0x00396BF8
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

		// Token: 0x06018A84 RID: 100996 RVA: 0x00398A3D File Offset: 0x00396C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A85 RID: 100997 RVA: 0x00398A4A File Offset: 0x00396C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A86 RID: 100998 RVA: 0x00398A53 File Offset: 0x00396C53
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

		// Token: 0x06018A87 RID: 100999 RVA: 0x00398A88 File Offset: 0x00396C88
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

		// Token: 0x06018A88 RID: 101000 RVA: 0x00398AC6 File Offset: 0x00396CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetBtObjYuXueModeResponse other)
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

		// Token: 0x06018A89 RID: 101001 RVA: 0x00398AF7 File Offset: 0x00396CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A8A RID: 101002 RVA: 0x00398B00 File Offset: 0x00396D00
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

		// Token: 0x04009287 RID: 37511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009288 RID: 37512
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04009289 RID: 37513
		private ErrorCode errorCode_;
	}
}
