using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A1 RID: 1185
	[NetMessage(EMessageId.EntityLoadCompleteNotify)]
	public sealed class EntityLoadCompleteNotify : IMessage<EntityLoadCompleteNotify>, IMessage, IEquatable<EntityLoadCompleteNotify>, IDeepCloneable<EntityLoadCompleteNotify>, IBufferMessage
	{
		// Token: 0x06007110 RID: 28944 RVA: 0x00115657 File Offset: 0x00113857
		[NullableContext(1)]
		public static EntityLoadCompleteNotify Create()
		{
			return new EntityLoadCompleteNotify();
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06007111 RID: 28945 RVA: 0x0011565E File Offset: 0x0011385E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06007112 RID: 28946 RVA: 0x00115661 File Offset: 0x00113861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityLoadCompleteNotify.Descriptor;
			}
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x00115668 File Offset: 0x00113868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLoadCompleteNotify()
		{
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x00115688 File Offset: 0x00113888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLoadCompleteNotify(EntityLoadCompleteNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.entityIds_ = other.entityIds_.Clone();
			this.entityIdsUnload_ = other.entityIdsUnload_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007115 RID: 28949 RVA: 0x001156DA File Offset: 0x001138DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityLoadCompleteNotify Clone()
		{
			return new EntityLoadCompleteNotify(this);
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06007116 RID: 28950 RVA: 0x001156E2 File Offset: 0x001138E2
		// (set) Token: 0x06007117 RID: 28951 RVA: 0x001156EA File Offset: 0x001138EA
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

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06007118 RID: 28952 RVA: 0x001156F3 File Offset: 0x001138F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06007119 RID: 28953 RVA: 0x001156FB File Offset: 0x001138FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIdsUnload
		{
			get
			{
				return this.entityIdsUnload_;
			}
		}

		// Token: 0x0600711A RID: 28954 RVA: 0x00115703 File Offset: 0x00113903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityLoadCompleteNotify);
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x00115714 File Offset: 0x00113914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityLoadCompleteNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.entityIds_.Equals(other.entityIds_) && this.entityIdsUnload_.Equals(other.entityIdsUnload_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x00115778 File Offset: 0x00113978
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

		// Token: 0x0600711D RID: 28957 RVA: 0x001157D3 File Offset: 0x001139D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x001157E0 File Offset: 0x001139E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x001157EC File Offset: 0x001139EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIdsUnload_.WriteTo(ref output, EntityLoadCompleteNotify._repeated_entityIdsUnload_codec);
			this.entityIds_.WriteTo(ref output, EntityLoadCompleteNotify._repeated_entityIds_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x0011584C File Offset: 0x00113A4C
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

		// Token: 0x06007121 RID: 28961 RVA: 0x001158B0 File Offset: 0x00113AB0
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

		// Token: 0x06007122 RID: 28962 RVA: 0x0011590E File Offset: 0x00113B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x00115918 File Offset: 0x00113B18
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.entityIdsUnload_.AddEntriesFrom(ref input, EntityLoadCompleteNotify._repeated_entityIdsUnload_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U || num == 42U)
					{
						this.entityIds_.AddEntriesFrom(ref input, EntityLoadCompleteNotify._repeated_entityIds_codec);
						continue;
					}
					if (num == 88U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C67 RID: 15463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C68 RID: 15464
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x04003C69 RID: 15465
		private int playerId_;

		// Token: 0x04003C6A RID: 15466
		public const int EntityIdsFieldNumber = 5;

		// Token: 0x04003C6B RID: 15467
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(42U);

		// Token: 0x04003C6C RID: 15468
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();

		// Token: 0x04003C6D RID: 15469
		public const int EntityIdsUnloadFieldNumber = 2;

		// Token: 0x04003C6E RID: 15470
		private static readonly FieldCodec<long> _repeated_entityIdsUnload_codec = FieldCodec.ForInt64(18U);

		// Token: 0x04003C6F RID: 15471
		private readonly RepeatedField<long> entityIdsUnload_ = new RepeatedField<long>();
	}
}
