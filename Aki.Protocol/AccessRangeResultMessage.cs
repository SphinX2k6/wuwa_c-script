using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000055 RID: 85
	public sealed class AccessRangeResultMessage : IMessage<AccessRangeResultMessage>, IMessage, IEquatable<AccessRangeResultMessage>, IDeepCloneable<AccessRangeResultMessage>, IBufferMessage
	{
		// Token: 0x06001537 RID: 5431 RVA: 0x00038655 File Offset: 0x00036855
		[NullableContext(1)]
		public static AccessRangeResultMessage Create()
		{
			return new AccessRangeResultMessage();
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x0003865C File Offset: 0x0003685C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AccessRangeResultMessage> Parser
		{
			get
			{
				return AccessRangeResultMessage._parser;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x00038663 File Offset: 0x00036863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x00038666 File Offset: 0x00036866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessRangeResultMessage.Descriptor;
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0003866D File Offset: 0x0003686D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeResultMessage()
		{
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00038680 File Offset: 0x00036880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeResultMessage(AccessRangeResultMessage other) : this()
		{
			this.accessEntityId_ = other.accessEntityId_;
			this.accessRangeType_ = other.accessRangeType_;
			this.accessRangeResults_ = other.accessRangeResults_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x000386CD File Offset: 0x000368CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeResultMessage Clone()
		{
			return new AccessRangeResultMessage(this);
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x000386D5 File Offset: 0x000368D5
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x000386DD File Offset: 0x000368DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccessEntityId
		{
			get
			{
				return this.accessEntityId_;
			}
			set
			{
				this.accessEntityId_ = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x000386E6 File Offset: 0x000368E6
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x000386EE File Offset: 0x000368EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeType AccessRangeType
		{
			get
			{
				return this.accessRangeType_;
			}
			set
			{
				this.accessRangeType_ = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x000386F7 File Offset: 0x000368F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ErrorCode> AccessRangeResults
		{
			get
			{
				return this.accessRangeResults_;
			}
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x000386FF File Offset: 0x000368FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessRangeResultMessage);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00038710 File Offset: 0x00036910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessRangeResultMessage other)
		{
			return other != null && (other == this || (this.AccessEntityId == other.AccessEntityId && this.AccessRangeType == other.AccessRangeType && this.AccessRangeResults.Equals(other.AccessRangeResults) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00038770 File Offset: 0x00036970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AccessEntityId != 0L)
			{
				num ^= this.AccessEntityId.GetHashCode();
			}
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				num ^= this.AccessRangeType.GetHashCode();
			}
			num ^= this.AccessRangeResults.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000387DC File Offset: 0x000369DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000387E9 File Offset: 0x000369E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x000387F4 File Offset: 0x000369F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AccessEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.AccessEntityId);
			}
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.AccessRangeType);
			}
			this.accessRangeResults_.WriteTo(ref output, AccessRangeResultMessage._map_accessRangeResults_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00038860 File Offset: 0x00036A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AccessEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AccessEntityId);
			}
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AccessRangeType);
			}
			num += this.accessRangeResults_.CalculateSize(AccessRangeResultMessage._map_accessRangeResults_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x000388CC File Offset: 0x00036ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AccessRangeResultMessage other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AccessEntityId != 0L)
			{
				this.AccessEntityId = other.AccessEntityId;
			}
			if (other.AccessRangeType != AccessRangeType.RangeEnter)
			{
				this.AccessRangeType = other.AccessRangeType;
			}
			this.accessRangeResults_.MergeFrom(other.accessRangeResults_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0003892D File Offset: 0x00036B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00038938 File Offset: 0x00036B38
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
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.accessRangeResults_.AddEntriesFrom(ref input, AccessRangeResultMessage._map_accessRangeResults_codec);
						}
					}
					else
					{
						this.AccessRangeType = (AccessRangeType)input.ReadEnum();
					}
				}
				else
				{
					this.AccessEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002090 RID: 8336
		private static readonly MessageParser<AccessRangeResultMessage> _parser = new MessageParser<AccessRangeResultMessage>(() => new AccessRangeResultMessage());

		// Token: 0x04002091 RID: 8337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002092 RID: 8338
		public const int AccessEntityIdFieldNumber = 1;

		// Token: 0x04002093 RID: 8339
		private long accessEntityId_;

		// Token: 0x04002094 RID: 8340
		public const int AccessRangeTypeFieldNumber = 2;

		// Token: 0x04002095 RID: 8341
		private AccessRangeType accessRangeType_;

		// Token: 0x04002096 RID: 8342
		public const int AccessRangeResultsFieldNumber = 3;

		// Token: 0x04002097 RID: 8343
		private static readonly MapField<int, ErrorCode>.Codec _map_accessRangeResults_codec = new MapField<int, ErrorCode>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<ErrorCode>(16U, (ErrorCode x) => (int)x, (int x) => (ErrorCode)x, ErrorCode.Success), 26U);

		// Token: 0x04002098 RID: 8344
		private readonly MapField<int, ErrorCode> accessRangeResults_ = new MapField<int, ErrorCode>();
	}
}
