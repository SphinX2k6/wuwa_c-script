using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD5 RID: 3541
	[NetMessage(EMessageId.PrivateChatResponse)]
	public sealed class PrivateChatResponse : IMessage<PrivateChatResponse>, IMessage, IEquatable<PrivateChatResponse>, IDeepCloneable<PrivateChatResponse>, IBufferMessage
	{
		// Token: 0x0601314B RID: 78155 RVA: 0x002C82ED File Offset: 0x002C64ED
		[NullableContext(1)]
		public static PrivateChatResponse Create()
		{
			return new PrivateChatResponse();
		}

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x0601314C RID: 78156 RVA: 0x002C82F4 File Offset: 0x002C64F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F53 RID: 16211
		// (get) Token: 0x0601314D RID: 78157 RVA: 0x002C82F7 File Offset: 0x002C64F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatResponse.Descriptor;
			}
		}

		// Token: 0x0601314E RID: 78158 RVA: 0x002C82FE File Offset: 0x002C64FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatResponse()
		{
		}

		// Token: 0x0601314F RID: 78159 RVA: 0x002C831C File Offset: 0x002C651C
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

		// Token: 0x06013150 RID: 78160 RVA: 0x002C837C File Offset: 0x002C657C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatResponse Clone()
		{
			return new PrivateChatResponse(this);
		}

		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x06013151 RID: 78161 RVA: 0x002C8384 File Offset: 0x002C6584
		// (set) Token: 0x06013152 RID: 78162 RVA: 0x002C838C File Offset: 0x002C658C
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

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x06013153 RID: 78163 RVA: 0x002C8395 File Offset: 0x002C6595
		// (set) Token: 0x06013154 RID: 78164 RVA: 0x002C839D File Offset: 0x002C659D
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

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x06013155 RID: 78165 RVA: 0x002C83A6 File Offset: 0x002C65A6
		// (set) Token: 0x06013156 RID: 78166 RVA: 0x002C83AE File Offset: 0x002C65AE
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

		// Token: 0x17003F57 RID: 16215
		// (get) Token: 0x06013157 RID: 78167 RVA: 0x002C83C1 File Offset: 0x002C65C1
		// (set) Token: 0x06013158 RID: 78168 RVA: 0x002C83C9 File Offset: 0x002C65C9
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

		// Token: 0x17003F58 RID: 16216
		// (get) Token: 0x06013159 RID: 78169 RVA: 0x002C83DC File Offset: 0x002C65DC
		// (set) Token: 0x0601315A RID: 78170 RVA: 0x002C83E4 File Offset: 0x002C65E4
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

		// Token: 0x0601315B RID: 78171 RVA: 0x002C83ED File Offset: 0x002C65ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatResponse);
		}

		// Token: 0x0601315C RID: 78172 RVA: 0x002C83FC File Offset: 0x002C65FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatResponse other)
		{
			return other != null && (other == this || (this.TargetUID == other.TargetUID && this.ErrorCode == other.ErrorCode && !(this.MsgId != other.MsgId) && !(this.FilterMsg != other.FilterMsg) && this.BanEndTime == other.BanEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601315D RID: 78173 RVA: 0x002C8480 File Offset: 0x002C6680
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

		// Token: 0x0601315E RID: 78174 RVA: 0x002C852D File Offset: 0x002C672D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601315F RID: 78175 RVA: 0x002C853A File Offset: 0x002C673A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013160 RID: 78176 RVA: 0x002C8544 File Offset: 0x002C6744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BanEndTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BanEndTime);
			}
			if (this.TargetUID != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TargetUID);
			}
			if (this.FilterMsg.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.FilterMsg);
			}
			if (this.MsgId.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.MsgId);
			}
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

		// Token: 0x06013161 RID: 78177 RVA: 0x002C85FC File Offset: 0x002C67FC
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

		// Token: 0x06013162 RID: 78178 RVA: 0x002C86A4 File Offset: 0x002C68A4
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

		// Token: 0x06013163 RID: 78179 RVA: 0x002C873A File Offset: 0x002C693A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013164 RID: 78180 RVA: 0x002C8744 File Offset: 0x002C6944
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.BanEndTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.TargetUID = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.FilterMsg = input.ReadString();
						continue;
					}
					if (num == 82U)
					{
						this.MsgId = input.ReadString();
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007615 RID: 30229
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007616 RID: 30230
		public const int TargetUIDFieldNumber = 5;

		// Token: 0x04007617 RID: 30231
		private int targetUID_;

		// Token: 0x04007618 RID: 30232
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007619 RID: 30233
		private ErrorCode errorCode_;

		// Token: 0x0400761A RID: 30234
		public const int MsgIdFieldNumber = 10;

		// Token: 0x0400761B RID: 30235
		private string msgId_ = "";

		// Token: 0x0400761C RID: 30236
		public const int FilterMsgFieldNumber = 9;

		// Token: 0x0400761D RID: 30237
		private string filterMsg_ = "";

		// Token: 0x0400761E RID: 30238
		public const int BanEndTimeFieldNumber = 1;

		// Token: 0x0400761F RID: 30239
		private long banEndTime_;
	}
}
