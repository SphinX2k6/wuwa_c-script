using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048A RID: 1162
	[NetMessage(EMessageId.EntityLoadCompleteNotify)]
	public sealed class EntityLoadCompleteNotify : IMessage<EntityLoadCompleteNotify>, IMessage, IEquatable<EntityLoadCompleteNotify>, IDeepCloneable<EntityLoadCompleteNotify>, IBufferMessage
	{
		// Token: 0x06006F82 RID: 28546 RVA: 0x001125DF File Offset: 0x001107DF
		[NullableContext(1)]
		public static EntityLoadCompleteNotify Create()
		{
			return new EntityLoadCompleteNotify();
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06006F83 RID: 28547 RVA: 0x001125E6 File Offset: 0x001107E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06006F84 RID: 28548 RVA: 0x001125E9 File Offset: 0x001107E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityLoadCompleteNotify.Descriptor;
			}
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x001125F0 File Offset: 0x001107F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLoadCompleteNotify()
		{
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x00112610 File Offset: 0x00110810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLoadCompleteNotify(EntityLoadCompleteNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.entityIds_ = other.entityIds_.Clone();
			this.entityIdsUnload_ = other.entityIdsUnload_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x00112662 File Offset: 0x00110862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLoadCompleteNotify Clone()
		{
			return new EntityLoadCompleteNotify(this);
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06006F88 RID: 28552 RVA: 0x0011266A File Offset: 0x0011086A
		// (set) Token: 0x06006F89 RID: 28553 RVA: 0x00112672 File Offset: 0x00110872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06006F8A RID: 28554 RVA: 0x0011267B File Offset: 0x0011087B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06006F8B RID: 28555 RVA: 0x00112683 File Offset: 0x00110883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIdsUnload
		{
			get
			{
				return this.entityIdsUnload_;
			}
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x0011268B File Offset: 0x0011088B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityLoadCompleteNotify);
		}

		// Token: 0x06006F8D RID: 28557 RVA: 0x0011269C File Offset: 0x0011089C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityLoadCompleteNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.entityIds_.Equals(other.entityIds_) && this.entityIdsUnload_.Equals(other.entityIdsUnload_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x00112700 File Offset: 0x00110900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			num ^= this.entityIdsUnload_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x0011275B File Offset: 0x0011095B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F90 RID: 28560 RVA: 0x00112768 File Offset: 0x00110968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x00112774 File Offset: 0x00110974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.entityIds_.WriteTo(ref output, EntityLoadCompleteNotify._repeated_entityIds_codec);
			this.entityIdsUnload_.WriteTo(ref output, EntityLoadCompleteNotify._repeated_entityIdsUnload_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x001127D4 File Offset: 0x001109D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.entityIds_.CalculateSize(EntityLoadCompleteNotify._repeated_entityIds_codec);
			num += this.entityIdsUnload_.CalculateSize(EntityLoadCompleteNotify._repeated_entityIdsUnload_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F93 RID: 28563 RVA: 0x00112838 File Offset: 0x00110A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityLoadCompleteNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.entityIds_.Add(other.entityIds_);
			this.entityIdsUnload_.Add(other.entityIdsUnload_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x00112896 File Offset: 0x00110A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x001128A0 File Offset: 0x00110AA0
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
					if (num == 8U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 34U)
					{
						goto IL_4A;
					}
					if (num == 96U || num == 98U)
					{
						this.entityIdsUnload_.AddEntriesFrom(ref input, EntityLoadCompleteNotify._repeated_entityIdsUnload_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.entityIds_.AddEntriesFrom(ref input, EntityLoadCompleteNotify._repeated_entityIds_codec);
			}
		}

		// Token: 0x04003C55 RID: 15445
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C56 RID: 15446
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04003C57 RID: 15447
		private int playerId_;

		// Token: 0x04003C58 RID: 15448
		public const int EntityIdsFieldNumber = 4;

		// Token: 0x04003C59 RID: 15449
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(34U);

		// Token: 0x04003C5A RID: 15450
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();

		// Token: 0x04003C5B RID: 15451
		public const int EntityIdsUnloadFieldNumber = 12;

		// Token: 0x04003C5C RID: 15452
		private static readonly FieldCodec<long> _repeated_entityIdsUnload_codec = FieldCodec.ForInt64(98U);

		// Token: 0x04003C5D RID: 15453
		private readonly RepeatedField<long> entityIdsUnload_ = new RepeatedField<long>();
	}
}
