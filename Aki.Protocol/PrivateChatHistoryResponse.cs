using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD1 RID: 3537
	[NetMessage(EMessageId.PrivateChatHistoryResponse)]
	public sealed class PrivateChatHistoryResponse : IMessage<PrivateChatHistoryResponse>, IMessage, IEquatable<PrivateChatHistoryResponse>, IDeepCloneable<PrivateChatHistoryResponse>, IBufferMessage
	{
		// Token: 0x060130F9 RID: 78073 RVA: 0x002C774C File Offset: 0x002C594C
		[NullableContext(1)]
		public static PrivateChatHistoryResponse Create()
		{
			return new PrivateChatHistoryResponse();
		}

		// Token: 0x17003F41 RID: 16193
		// (get) Token: 0x060130FA RID: 78074 RVA: 0x002C7753 File Offset: 0x002C5953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F42 RID: 16194
		// (get) Token: 0x060130FB RID: 78075 RVA: 0x002C7756 File Offset: 0x002C5956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatHistoryResponse.Descriptor;
			}
		}

		// Token: 0x060130FC RID: 78076 RVA: 0x002C775D File Offset: 0x002C595D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryResponse()
		{
		}

		// Token: 0x060130FD RID: 78077 RVA: 0x002C7768 File Offset: 0x002C5968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryResponse(PrivateChatHistoryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060130FE RID: 78078 RVA: 0x002C77B4 File Offset: 0x002C59B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryResponse Clone()
		{
			return new PrivateChatHistoryResponse(this);
		}

		// Token: 0x17003F43 RID: 16195
		// (get) Token: 0x060130FF RID: 78079 RVA: 0x002C77BC File Offset: 0x002C59BC
		// (set) Token: 0x06013100 RID: 78080 RVA: 0x002C77C4 File Offset: 0x002C59C4
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

		// Token: 0x17003F44 RID: 16196
		// (get) Token: 0x06013101 RID: 78081 RVA: 0x002C77CD File Offset: 0x002C59CD
		// (set) Token: 0x06013102 RID: 78082 RVA: 0x002C77D5 File Offset: 0x002C59D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryContentProto Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x06013103 RID: 78083 RVA: 0x002C77DE File Offset: 0x002C59DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatHistoryResponse);
		}

		// Token: 0x06013104 RID: 78084 RVA: 0x002C77EC File Offset: 0x002C59EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatHistoryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013105 RID: 78085 RVA: 0x002C783C File Offset: 0x002C5A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013106 RID: 78086 RVA: 0x002C7897 File Offset: 0x002C5A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013107 RID: 78087 RVA: 0x002C78A4 File Offset: 0x002C5AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013108 RID: 78088 RVA: 0x002C78B0 File Offset: 0x002C5AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Data);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013109 RID: 78089 RVA: 0x002C790C File Offset: 0x002C5B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601310A RID: 78090 RVA: 0x002C7964 File Offset: 0x002C5B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatHistoryResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new PrivateChatHistoryContentProto();
				}
				this.Data.MergeFrom(other.Data);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601310B RID: 78091 RVA: 0x002C79CC File Offset: 0x002C5BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601310C RID: 78092 RVA: 0x002C79D8 File Offset: 0x002C5BD8
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
				if (num != 66U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.data_ == null)
					{
						this.Data = new PrivateChatHistoryContentProto();
					}
					input.ReadMessage(this.Data);
				}
			}
		}

		// Token: 0x040075FE RID: 30206
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075FF RID: 30207
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04007600 RID: 30208
		private ErrorCode errorCode_;

		// Token: 0x04007601 RID: 30209
		public const int DataFieldNumber = 8;

		// Token: 0x04007602 RID: 30210
		private PrivateChatHistoryContentProto data_;
	}
}
