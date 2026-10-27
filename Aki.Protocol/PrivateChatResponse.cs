using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE5 RID: 3557
	[NetMessage(EMessageId.PrivateChatResponse)]
	public sealed class PrivateChatResponse : IMessage<PrivateChatResponse>, IMessage, IEquatable<PrivateChatResponse>, IDeepCloneable<PrivateChatResponse>, IBufferMessage
	{
		// Token: 0x06013230 RID: 78384 RVA: 0x002C99B1 File Offset: 0x002C7BB1
		[NullableContext(1)]
		public static PrivateChatResponse Create()
		{
			return new PrivateChatResponse();
		}

		// Token: 0x17003F7C RID: 16252
		// (get) Token: 0x06013231 RID: 78385 RVA: 0x002C99B8 File Offset: 0x002C7BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F7D RID: 16253
		// (get) Token: 0x06013232 RID: 78386 RVA: 0x002C99BB File Offset: 0x002C7BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatResponse.Descriptor;
			}
		}

		// Token: 0x06013233 RID: 78387 RVA: 0x002C99C2 File Offset: 0x002C7BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatResponse()
		{
		}

		// Token: 0x06013234 RID: 78388 RVA: 0x002C99E0 File Offset: 0x002C7BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatResponse(PrivateChatResponse other) : this()
		{
			this.targetUID_ = other.targetUID_;
			this.errorCode_ = other.errorCode_;
			this.msgId_ = other.msgId_;
			this.filterMsg_ = other.filterMsg_;
			this.banEndTime_ = other.banEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013235 RID: 78389 RVA: 0x002C9A40 File Offset: 0x002C7C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatResponse Clone()
		{
			return new PrivateChatResponse(this);
		}

		// Token: 0x17003F7E RID: 16254
		// (get) Token: 0x06013236 RID: 78390 RVA: 0x002C9A48 File Offset: 0x002C7C48
		// (set) Token: 0x06013237 RID: 78391 RVA: 0x002C9A50 File Offset: 0x002C7C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetUID
		{
			get
			{
				return this.targetUID_;
			}
			set
			{
				this.targetUID_ = value;
			}
		}

		// Token: 0x17003F7F RID: 16255
		// (get) Token: 0x06013238 RID: 78392 RVA: 0x002C9A59 File Offset: 0x002C7C59
		// (set) Token: 0x06013239 RID: 78393 RVA: 0x002C9A61 File Offset: 0x002C7C61
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

		// Token: 0x17003F80 RID: 16256
		// (get) Token: 0x0601323A RID: 78394 RVA: 0x002C9A6A File Offset: 0x002C7C6A
		// (set) Token: 0x0601323B RID: 78395 RVA: 0x002C9A72 File Offset: 0x002C7C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MsgId
		{
			get
			{
				return this.msgId_;
			}
			set
			{
				this.msgId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003F81 RID: 16257
		// (get) Token: 0x0601323C RID: 78396 RVA: 0x002C9A85 File Offset: 0x002C7C85
		// (set) Token: 0x0601323D RID: 78397 RVA: 0x002C9A8D File Offset: 0x002C7C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FilterMsg
		{
			get
			{
				return this.filterMsg_;
			}
			set
			{
				this.filterMsg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003F82 RID: 16258
		// (get) Token: 0x0601323E RID: 78398 RVA: 0x002C9AA0 File Offset: 0x002C7CA0
		// (set) Token: 0x0601323F RID: 78399 RVA: 0x002C9AA8 File Offset: 0x002C7CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BanEndTime
		{
			get
			{
				return this.banEndTime_;
			}
			set
			{
				this.banEndTime_ = value;
			}
		}

		// Token: 0x06013240 RID: 78400 RVA: 0x002C9AB1 File Offset: 0x002C7CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatResponse);
		}

		// Token: 0x06013241 RID: 78401 RVA: 0x002C9AC0 File Offset: 0x002C7CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatResponse other)
		{
			return other != null && (other == this || (this.TargetUID == other.TargetUID && this.ErrorCode == other.ErrorCode && !(this.MsgId != other.MsgId) && !(this.FilterMsg != other.FilterMsg) && this.BanEndTime == other.BanEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013242 RID: 78402 RVA: 0x002C9B44 File Offset: 0x002C7D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetUID != 0)
			{
				num ^= this.TargetUID.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.MsgId.Length != 0)
			{
				num ^= this.MsgId.GetHashCode();
			}
			if (this.FilterMsg.Length != 0)
			{
				num ^= this.FilterMsg.GetHashCode();
			}
			if (this.BanEndTime != 0L)
			{
				num ^= this.BanEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013243 RID: 78403 RVA: 0x002C9BF1 File Offset: 0x002C7DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013244 RID: 78404 RVA: 0x002C9BFE File Offset: 0x002C7DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013245 RID: 78405 RVA: 0x002C9C08 File Offset: 0x002C7E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FilterMsg.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.FilterMsg);
			}
			if (this.MsgId.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.MsgId);
			}
			if (this.TargetUID != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TargetUID);
			}
			if (this.BanEndTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.BanEndTime);
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

		// Token: 0x06013246 RID: 78406 RVA: 0x002C9CC0 File Offset: 0x002C7EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetUID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetUID);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.MsgId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MsgId);
			}
			if (this.FilterMsg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FilterMsg);
			}
			if (this.BanEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BanEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013247 RID: 78407 RVA: 0x002C9D68 File Offset: 0x002C7F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetUID != 0)
			{
				this.TargetUID = other.TargetUID;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.MsgId.Length != 0)
			{
				this.MsgId = other.MsgId;
			}
			if (other.FilterMsg.Length != 0)
			{
				this.FilterMsg = other.FilterMsg;
			}
			if (other.BanEndTime != 0L)
			{
				this.BanEndTime = other.BanEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013248 RID: 78408 RVA: 0x002C9DFE File Offset: 0x002C7FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013249 RID: 78409 RVA: 0x002C9E08 File Offset: 0x002C8008
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.FilterMsg = input.ReadString();
						continue;
					}
					if (num == 26U)
					{
						this.MsgId = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.TargetUID = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.BanEndTime = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040075EB RID: 30187
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075EC RID: 30188
		public const int TargetUIDFieldNumber = 7;

		// Token: 0x040075ED RID: 30189
		private int targetUID_;

		// Token: 0x040075EE RID: 30190
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040075EF RID: 30191
		private ErrorCode errorCode_;

		// Token: 0x040075F0 RID: 30192
		public const int MsgIdFieldNumber = 3;

		// Token: 0x040075F1 RID: 30193
		private string msgId_ = "";

		// Token: 0x040075F2 RID: 30194
		public const int FilterMsgFieldNumber = 1;

		// Token: 0x040075F3 RID: 30195
		private string filterMsg_ = "";

		// Token: 0x040075F4 RID: 30196
		public const int BanEndTimeFieldNumber = 8;

		// Token: 0x040075F5 RID: 30197
		private long banEndTime_;
	}
}
