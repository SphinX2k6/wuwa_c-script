using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE1 RID: 3553
	[NetMessage(EMessageId.PrivateChatHistoryResponse)]
	public sealed class PrivateChatHistoryResponse : IMessage<PrivateChatHistoryResponse>, IMessage, IEquatable<PrivateChatHistoryResponse>, IDeepCloneable<PrivateChatHistoryResponse>, IBufferMessage
	{
		// Token: 0x060131DE RID: 78302 RVA: 0x002C8E10 File Offset: 0x002C7010
		[NullableContext(1)]
		public static PrivateChatHistoryResponse Create()
		{
			return new PrivateChatHistoryResponse();
		}

		// Token: 0x17003F6B RID: 16235
		// (get) Token: 0x060131DF RID: 78303 RVA: 0x002C8E17 File Offset: 0x002C7017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F6C RID: 16236
		// (get) Token: 0x060131E0 RID: 78304 RVA: 0x002C8E1A File Offset: 0x002C701A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatHistoryResponse.Descriptor;
			}
		}

		// Token: 0x060131E1 RID: 78305 RVA: 0x002C8E21 File Offset: 0x002C7021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryResponse()
		{
		}

		// Token: 0x060131E2 RID: 78306 RVA: 0x002C8E2C File Offset: 0x002C702C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryResponse(PrivateChatHistoryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060131E3 RID: 78307 RVA: 0x002C8E78 File Offset: 0x002C7078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryResponse Clone()
		{
			return new PrivateChatHistoryResponse(this);
		}

		// Token: 0x17003F6D RID: 16237
		// (get) Token: 0x060131E4 RID: 78308 RVA: 0x002C8E80 File Offset: 0x002C7080
		// (set) Token: 0x060131E5 RID: 78309 RVA: 0x002C8E88 File Offset: 0x002C7088
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

		// Token: 0x17003F6E RID: 16238
		// (get) Token: 0x060131E6 RID: 78310 RVA: 0x002C8E91 File Offset: 0x002C7091
		// (set) Token: 0x060131E7 RID: 78311 RVA: 0x002C8E99 File Offset: 0x002C7099
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

		// Token: 0x060131E8 RID: 78312 RVA: 0x002C8EA2 File Offset: 0x002C70A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatHistoryResponse);
		}

		// Token: 0x060131E9 RID: 78313 RVA: 0x002C8EB0 File Offset: 0x002C70B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatHistoryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060131EA RID: 78314 RVA: 0x002C8F00 File Offset: 0x002C7100
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

		// Token: 0x060131EB RID: 78315 RVA: 0x002C8F5B File Offset: 0x002C715B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060131EC RID: 78316 RVA: 0x002C8F68 File Offset: 0x002C7168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060131ED RID: 78317 RVA: 0x002C8F74 File Offset: 0x002C7174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.data_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060131EE RID: 78318 RVA: 0x002C8FD0 File Offset: 0x002C71D0
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

		// Token: 0x060131EF RID: 78319 RVA: 0x002C9028 File Offset: 0x002C7228
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

		// Token: 0x060131F0 RID: 78320 RVA: 0x002C9090 File Offset: 0x002C7290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060131F1 RID: 78321 RVA: 0x002C909C File Offset: 0x002C729C
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
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040075D4 RID: 30164
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075D5 RID: 30165
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040075D6 RID: 30166
		private ErrorCode errorCode_;

		// Token: 0x040075D7 RID: 30167
		public const int DataFieldNumber = 9;

		// Token: 0x040075D8 RID: 30168
		private PrivateChatHistoryContentProto data_;
	}
}
