using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000056 RID: 86
	public sealed class AccessRangeResultMessage : IMessage<AccessRangeResultMessage>, IMessage, IEquatable<AccessRangeResultMessage>, IDeepCloneable<AccessRangeResultMessage>, IBufferMessage
	{
		// Token: 0x0600157A RID: 5498 RVA: 0x00038FF9 File Offset: 0x000371F9
		[NullableContext(1)]
		public static AccessRangeResultMessage Create()
		{
			return new AccessRangeResultMessage();
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x00039000 File Offset: 0x00037200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AccessRangeResultMessage> Parser
		{
			get
			{
				return AccessRangeResultMessage._parser;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00039007 File Offset: 0x00037207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x0003900A File Offset: 0x0003720A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessRangeResultMessage.Descriptor;
			}
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00039011 File Offset: 0x00037211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeResultMessage()
		{
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00039024 File Offset: 0x00037224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeResultMessage(AccessRangeResultMessage other) : this()
		{
			this.accessEntityId_ = other.accessEntityId_;
			this.accessRangeType_ = other.accessRangeType_;
			this.accessRangeResults_ = other.accessRangeResults_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00039071 File Offset: 0x00037271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeResultMessage Clone()
		{
			return new AccessRangeResultMessage(this);
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x00039079 File Offset: 0x00037279
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x00039081 File Offset: 0x00037281
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

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0003908A File Offset: 0x0003728A
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x00039092 File Offset: 0x00037292
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x0003909B File Offset: 0x0003729B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ErrorCode> AccessRangeResults
		{
			get
			{
				return this.accessRangeResults_;
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x000390A3 File Offset: 0x000372A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessRangeResultMessage);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x000390B4 File Offset: 0x000372B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessRangeResultMessage other)
		{
			return other != null && (other == this || (this.AccessEntityId == other.AccessEntityId && this.AccessRangeType == other.AccessRangeType && this.AccessRangeResults.Equals(other.AccessRangeResults) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00039114 File Offset: 0x00037314
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

		// Token: 0x06001589 RID: 5513 RVA: 0x00039180 File Offset: 0x00037380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0003918D File Offset: 0x0003738D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00039198 File Offset: 0x00037398
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

		// Token: 0x0600158C RID: 5516 RVA: 0x00039204 File Offset: 0x00037404
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

		// Token: 0x0600158D RID: 5517 RVA: 0x00039270 File Offset: 0x00037470
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

		// Token: 0x0600158E RID: 5518 RVA: 0x000392D1 File Offset: 0x000374D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x000392DC File Offset: 0x000374DC
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

		// Token: 0x040020EF RID: 8431
		private static readonly MessageParser<AccessRangeResultMessage> _parser = new MessageParser<AccessRangeResultMessage>(() => new AccessRangeResultMessage());

		// Token: 0x040020F0 RID: 8432
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020F1 RID: 8433
		public const int AccessEntityIdFieldNumber = 1;

		// Token: 0x040020F2 RID: 8434
		private long accessEntityId_;

		// Token: 0x040020F3 RID: 8435
		public const int AccessRangeTypeFieldNumber = 2;

		// Token: 0x040020F4 RID: 8436
		private AccessRangeType accessRangeType_;

		// Token: 0x040020F5 RID: 8437
		public const int AccessRangeResultsFieldNumber = 3;

		// Token: 0x040020F6 RID: 8438
		private static readonly MapField<int, ErrorCode>.Codec _map_accessRangeResults_codec = new MapField<int, ErrorCode>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<ErrorCode>(16U, (ErrorCode x) => (int)x, (int x) => (ErrorCode)x, ErrorCode.Success), 26U);

		// Token: 0x040020F7 RID: 8439
		private readonly MapField<int, ErrorCode> accessRangeResults_ = new MapField<int, ErrorCode>();
	}
}
