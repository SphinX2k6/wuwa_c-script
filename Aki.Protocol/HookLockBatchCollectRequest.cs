using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079C RID: 1948
	[NetMessage(EMessageId.HookLockBatchCollectRequest)]
	public sealed class HookLockBatchCollectRequest : IMessage<HookLockBatchCollectRequest>, IMessage, IEquatable<HookLockBatchCollectRequest>, IDeepCloneable<HookLockBatchCollectRequest>, IBufferMessage
	{
		// Token: 0x0600AFF3 RID: 45043 RVA: 0x001A65AE File Offset: 0x001A47AE
		[NullableContext(1)]
		public static HookLockBatchCollectRequest Create()
		{
			return new HookLockBatchCollectRequest();
		}

		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x0600AFF4 RID: 45044 RVA: 0x001A65B5 File Offset: 0x001A47B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x0600AFF5 RID: 45045 RVA: 0x001A65B8 File Offset: 0x001A47B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockBatchCollectRequest.Descriptor;
			}
		}

		// Token: 0x0600AFF6 RID: 45046 RVA: 0x001A65BF File Offset: 0x001A47BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectRequest()
		{
		}

		// Token: 0x0600AFF7 RID: 45047 RVA: 0x001A65D4 File Offset: 0x001A47D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectRequest(HookLockBatchCollectRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.entityId_ = other.entityId_;
			this.batchIds_ = other.batchIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFF8 RID: 45048 RVA: 0x001A6621 File Offset: 0x001A4821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectRequest Clone()
		{
			return new HookLockBatchCollectRequest(this);
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x0600AFF9 RID: 45049 RVA: 0x001A6629 File Offset: 0x001A4829
		// (set) Token: 0x0600AFFA RID: 45050 RVA: 0x001A6631 File Offset: 0x001A4831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x0600AFFB RID: 45051 RVA: 0x001A663A File Offset: 0x001A483A
		// (set) Token: 0x0600AFFC RID: 45052 RVA: 0x001A6642 File Offset: 0x001A4842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x0600AFFD RID: 45053 RVA: 0x001A664B File Offset: 0x001A484B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BatchIds
		{
			get
			{
				return this.batchIds_;
			}
		}

		// Token: 0x0600AFFE RID: 45054 RVA: 0x001A6653 File Offset: 0x001A4853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockBatchCollectRequest);
		}

		// Token: 0x0600AFFF RID: 45055 RVA: 0x001A6664 File Offset: 0x001A4864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockBatchCollectRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.EntityId == other.EntityId && this.batchIds_.Equals(other.batchIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B000 RID: 45056 RVA: 0x001A66C4 File Offset: 0x001A48C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.batchIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B001 RID: 45057 RVA: 0x001A672A File Offset: 0x001A492A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B002 RID: 45058 RVA: 0x001A6737 File Offset: 0x001A4937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B003 RID: 45059 RVA: 0x001A6740 File Offset: 0x001A4940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.InstId);
			}
			this.batchIds_.WriteTo(ref output, HookLockBatchCollectRequest._repeated_batchIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B004 RID: 45060 RVA: 0x001A67AC File Offset: 0x001A49AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.batchIds_.CalculateSize(HookLockBatchCollectRequest._repeated_batchIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B005 RID: 45061 RVA: 0x001A6818 File Offset: 0x001A4A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockBatchCollectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.batchIds_.Add(other.batchIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B006 RID: 45062 RVA: 0x001A6879 File Offset: 0x001A4A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B007 RID: 45063 RVA: 0x001A6884 File Offset: 0x001A4A84
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
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.batchIds_.AddEntriesFrom(ref input, HookLockBatchCollectRequest._repeated_batchIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F79 RID: 20345
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F7A RID: 20346
		public const int InstIdFieldNumber = 4;

		// Token: 0x04004F7B RID: 20347
		private int instId_;

		// Token: 0x04004F7C RID: 20348
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04004F7D RID: 20349
		private long entityId_;

		// Token: 0x04004F7E RID: 20350
		public const int BatchIdsFieldNumber = 15;

		// Token: 0x04004F7F RID: 20351
		private static readonly FieldCodec<long> _repeated_batchIds_codec = FieldCodec.ForInt64(122U);

		// Token: 0x04004F80 RID: 20352
		private readonly RepeatedField<long> batchIds_ = new RepeatedField<long>();
	}
}
