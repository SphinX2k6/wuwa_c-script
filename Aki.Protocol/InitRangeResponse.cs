using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FB RID: 2043
	[NetMessage(EMessageId.InitRangeResponse)]
	public sealed class InitRangeResponse : IMessage<InitRangeResponse>, IMessage, IEquatable<InitRangeResponse>, IDeepCloneable<InitRangeResponse>, IBufferMessage
	{
		// Token: 0x0600B72C RID: 46892 RVA: 0x001B4D7A File Offset: 0x001B2F7A
		[NullableContext(1)]
		public static InitRangeResponse Create()
		{
			return new InitRangeResponse();
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x0600B72D RID: 46893 RVA: 0x001B4D81 File Offset: 0x001B2F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x0600B72E RID: 46894 RVA: 0x001B4D84 File Offset: 0x001B2F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InitRangeResponse.Descriptor;
			}
		}

		// Token: 0x0600B72F RID: 46895 RVA: 0x001B4D8B File Offset: 0x001B2F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InitRangeResponse()
		{
		}

		// Token: 0x0600B730 RID: 46896 RVA: 0x001B4DA0 File Offset: 0x001B2FA0
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

		// Token: 0x0600B731 RID: 46897 RVA: 0x001B4E09 File Offset: 0x001B3009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InitRangeResponse Clone()
		{
			return new InitRangeResponse(this);
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x0600B732 RID: 46898 RVA: 0x001B4E11 File Offset: 0x001B3011
		// (set) Token: 0x0600B733 RID: 46899 RVA: 0x001B4E19 File Offset: 0x001B3019
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

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x0600B734 RID: 46900 RVA: 0x001B4E22 File Offset: 0x001B3022
		// (set) Token: 0x0600B735 RID: 46901 RVA: 0x001B4E2A File Offset: 0x001B302A
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

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x0600B736 RID: 46902 RVA: 0x001B4E33 File Offset: 0x001B3033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AccessRangeResultMessage> EntitiesAccessRangeResult
		{
			get
			{
				return this.entitiesAccessRangeResult_;
			}
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x0600B737 RID: 46903 RVA: 0x001B4E3B File Offset: 0x001B303B
		// (set) Token: 0x0600B738 RID: 46904 RVA: 0x001B4E43 File Offset: 0x001B3043
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

		// Token: 0x0600B739 RID: 46905 RVA: 0x001B4E4C File Offset: 0x001B304C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InitRangeResponse);
		}

		// Token: 0x0600B73A RID: 46906 RVA: 0x001B4E5C File Offset: 0x001B305C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InitRangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RangeEntityId == other.RangeEntityId && this.entitiesAccessRangeResult_.Equals(other.entitiesAccessRangeResult_) && object.Equals(this.PlayerAccessRangeResult, other.PlayerAccessRangeResult) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B73B RID: 46907 RVA: 0x001B4ED0 File Offset: 0x001B30D0
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

		// Token: 0x0600B73C RID: 46908 RVA: 0x001B4F52 File Offset: 0x001B3152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B73D RID: 46909 RVA: 0x001B4F5F File Offset: 0x001B315F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B73E RID: 46910 RVA: 0x001B4F68 File Offset: 0x001B3168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerAccessRangeResult_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PlayerAccessRangeResult);
			}
			this.entitiesAccessRangeResult_.WriteTo(ref output, InitRangeResponse._repeated_entitiesAccessRangeResult_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.RangeEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B73F RID: 46911 RVA: 0x001B4FF0 File Offset: 0x001B31F0
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

		// Token: 0x0600B740 RID: 46912 RVA: 0x001B5074 File Offset: 0x001B3274
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

		// Token: 0x0600B741 RID: 46913 RVA: 0x001B5101 File Offset: 0x001B3301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x001B510C File Offset: 0x001B330C
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
				if (num <= 98U)
				{
					if (num == 66U)
					{
						if (this.playerAccessRangeResult_ == null)
						{
							this.PlayerAccessRangeResult = new AccessRangeResultMessage();
						}
						input.ReadMessage(this.PlayerAccessRangeResult);
						continue;
					}
					if (num == 98U)
					{
						this.entitiesAccessRangeResult_.AddEntriesFrom(ref input, InitRangeResponse._repeated_entitiesAccessRangeResult_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.RangeEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400513C RID: 20796
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400513D RID: 20797
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400513E RID: 20798
		private ErrorCode errorCode_;

		// Token: 0x0400513F RID: 20799
		public const int RangeEntityIdFieldNumber = 14;

		// Token: 0x04005140 RID: 20800
		private long rangeEntityId_;

		// Token: 0x04005141 RID: 20801
		public const int EntitiesAccessRangeResultFieldNumber = 12;

		// Token: 0x04005142 RID: 20802
		private static readonly FieldCodec<AccessRangeResultMessage> _repeated_entitiesAccessRangeResult_codec = FieldCodec.ForMessage<AccessRangeResultMessage>(98U, AccessRangeResultMessage.Parser);

		// Token: 0x04005143 RID: 20803
		private readonly RepeatedField<AccessRangeResultMessage> entitiesAccessRangeResult_ = new RepeatedField<AccessRangeResultMessage>();

		// Token: 0x04005144 RID: 20804
		public const int PlayerAccessRangeResultFieldNumber = 8;

		// Token: 0x04005145 RID: 20805
		private AccessRangeResultMessage playerAccessRangeResult_;
	}
}
