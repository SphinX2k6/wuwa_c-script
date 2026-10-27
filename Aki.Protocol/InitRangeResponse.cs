using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080F RID: 2063
	[NetMessage(EMessageId.InitRangeResponse)]
	public sealed class InitRangeResponse : IMessage<InitRangeResponse>, IMessage, IEquatable<InitRangeResponse>, IDeepCloneable<InitRangeResponse>, IBufferMessage
	{
		// Token: 0x0600B882 RID: 47234 RVA: 0x001B77B9 File Offset: 0x001B59B9
		[NullableContext(1)]
		public static InitRangeResponse Create()
		{
			return new InitRangeResponse();
		}

		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x0600B883 RID: 47235 RVA: 0x001B77C0 File Offset: 0x001B59C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x0600B884 RID: 47236 RVA: 0x001B77C3 File Offset: 0x001B59C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InitRangeResponse.Descriptor;
			}
		}

		// Token: 0x0600B885 RID: 47237 RVA: 0x001B77CA File Offset: 0x001B59CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InitRangeResponse()
		{
		}

		// Token: 0x0600B886 RID: 47238 RVA: 0x001B77E0 File Offset: 0x001B59E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InitRangeResponse(InitRangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rangeEntityId_ = other.rangeEntityId_;
			this.entitiesAccessRangeResult_ = other.entitiesAccessRangeResult_.Clone();
			this.playerAccessRangeResult_ = ((other.playerAccessRangeResult_ != null) ? other.playerAccessRangeResult_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B887 RID: 47239 RVA: 0x001B7849 File Offset: 0x001B5A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InitRangeResponse Clone()
		{
			return new InitRangeResponse(this);
		}

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x0600B888 RID: 47240 RVA: 0x001B7851 File Offset: 0x001B5A51
		// (set) Token: 0x0600B889 RID: 47241 RVA: 0x001B7859 File Offset: 0x001B5A59
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

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x0600B88A RID: 47242 RVA: 0x001B7862 File Offset: 0x001B5A62
		// (set) Token: 0x0600B88B RID: 47243 RVA: 0x001B786A File Offset: 0x001B5A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RangeEntityId
		{
			get
			{
				return this.rangeEntityId_;
			}
			set
			{
				this.rangeEntityId_ = value;
			}
		}

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x0600B88C RID: 47244 RVA: 0x001B7873 File Offset: 0x001B5A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AccessRangeResultMessage> EntitiesAccessRangeResult
		{
			get
			{
				return this.entitiesAccessRangeResult_;
			}
		}

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x0600B88D RID: 47245 RVA: 0x001B787B File Offset: 0x001B5A7B
		// (set) Token: 0x0600B88E RID: 47246 RVA: 0x001B7883 File Offset: 0x001B5A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeResultMessage PlayerAccessRangeResult
		{
			get
			{
				return this.playerAccessRangeResult_;
			}
			set
			{
				this.playerAccessRangeResult_ = value;
			}
		}

		// Token: 0x0600B88F RID: 47247 RVA: 0x001B788C File Offset: 0x001B5A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InitRangeResponse);
		}

		// Token: 0x0600B890 RID: 47248 RVA: 0x001B789C File Offset: 0x001B5A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InitRangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RangeEntityId == other.RangeEntityId && this.entitiesAccessRangeResult_.Equals(other.entitiesAccessRangeResult_) && object.Equals(this.PlayerAccessRangeResult, other.PlayerAccessRangeResult) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B891 RID: 47249 RVA: 0x001B7910 File Offset: 0x001B5B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.RangeEntityId != 0L)
			{
				num ^= this.RangeEntityId.GetHashCode();
			}
			num ^= this.entitiesAccessRangeResult_.GetHashCode();
			if (this.playerAccessRangeResult_ != null)
			{
				num ^= this.PlayerAccessRangeResult.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B892 RID: 47250 RVA: 0x001B7992 File Offset: 0x001B5B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x001B799F File Offset: 0x001B5B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B894 RID: 47252 RVA: 0x001B79A8 File Offset: 0x001B5BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.RangeEntityId);
			}
			this.entitiesAccessRangeResult_.WriteTo(ref output, InitRangeResponse._repeated_entitiesAccessRangeResult_codec);
			if (this.playerAccessRangeResult_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PlayerAccessRangeResult);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B895 RID: 47253 RVA: 0x001B7A30 File Offset: 0x001B5C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.RangeEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RangeEntityId);
			}
			num += this.entitiesAccessRangeResult_.CalculateSize(InitRangeResponse._repeated_entitiesAccessRangeResult_codec);
			if (this.playerAccessRangeResult_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerAccessRangeResult);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B896 RID: 47254 RVA: 0x001B7AB4 File Offset: 0x001B5CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InitRangeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.RangeEntityId != 0L)
			{
				this.RangeEntityId = other.RangeEntityId;
			}
			this.entitiesAccessRangeResult_.Add(other.entitiesAccessRangeResult_);
			if (other.playerAccessRangeResult_ != null)
			{
				if (this.playerAccessRangeResult_ == null)
				{
					this.PlayerAccessRangeResult = new AccessRangeResultMessage();
				}
				this.PlayerAccessRangeResult.MergeFrom(other.PlayerAccessRangeResult);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B897 RID: 47255 RVA: 0x001B7B41 File Offset: 0x001B5D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B898 RID: 47256 RVA: 0x001B7B4C File Offset: 0x001B5D4C
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
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.RangeEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.entitiesAccessRangeResult_.AddEntriesFrom(ref input, InitRangeResponse._repeated_entitiesAccessRangeResult_codec);
						continue;
					}
					if (num == 90U)
					{
						if (this.playerAccessRangeResult_ == null)
						{
							this.PlayerAccessRangeResult = new AccessRangeResultMessage();
						}
						input.ReadMessage(this.PlayerAccessRangeResult);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005143 RID: 20803
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005144 RID: 20804
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005145 RID: 20805
		private ErrorCode errorCode_;

		// Token: 0x04005146 RID: 20806
		public const int RangeEntityIdFieldNumber = 4;

		// Token: 0x04005147 RID: 20807
		private long rangeEntityId_;

		// Token: 0x04005148 RID: 20808
		public const int EntitiesAccessRangeResultFieldNumber = 9;

		// Token: 0x04005149 RID: 20809
		private static readonly FieldCodec<AccessRangeResultMessage> _repeated_entitiesAccessRangeResult_codec = FieldCodec.ForMessage<AccessRangeResultMessage>(74U, AccessRangeResultMessage.Parser);

		// Token: 0x0400514A RID: 20810
		private readonly RepeatedField<AccessRangeResultMessage> entitiesAccessRangeResult_ = new RepeatedField<AccessRangeResultMessage>();

		// Token: 0x0400514B RID: 20811
		public const int PlayerAccessRangeResultFieldNumber = 11;

		// Token: 0x0400514C RID: 20812
		private AccessRangeResultMessage playerAccessRangeResult_;
	}
}
