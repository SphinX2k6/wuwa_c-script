using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B0 RID: 1968
	[NetMessage(EMessageId.HookLockBatchCollectRequest)]
	public sealed class HookLockBatchCollectRequest : IMessage<HookLockBatchCollectRequest>, IMessage, IEquatable<HookLockBatchCollectRequest>, IDeepCloneable<HookLockBatchCollectRequest>, IBufferMessage
	{
		// Token: 0x0600B149 RID: 45385 RVA: 0x001A8FDE File Offset: 0x001A71DE
		[NullableContext(1)]
		public static HookLockBatchCollectRequest Create()
		{
			return new HookLockBatchCollectRequest();
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x0600B14A RID: 45386 RVA: 0x001A8FE5 File Offset: 0x001A71E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x0600B14B RID: 45387 RVA: 0x001A8FE8 File Offset: 0x001A71E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockBatchCollectRequest.Descriptor;
			}
		}

		// Token: 0x0600B14C RID: 45388 RVA: 0x001A8FEF File Offset: 0x001A71EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectRequest()
		{
		}

		// Token: 0x0600B14D RID: 45389 RVA: 0x001A9004 File Offset: 0x001A7204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectRequest(HookLockBatchCollectRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.entityId_ = other.entityId_;
			this.batchIds_ = other.batchIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B14E RID: 45390 RVA: 0x001A9051 File Offset: 0x001A7251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectRequest Clone()
		{
			return new HookLockBatchCollectRequest(this);
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x0600B14F RID: 45391 RVA: 0x001A9059 File Offset: 0x001A7259
		// (set) Token: 0x0600B150 RID: 45392 RVA: 0x001A9061 File Offset: 0x001A7261
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

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x0600B151 RID: 45393 RVA: 0x001A906A File Offset: 0x001A726A
		// (set) Token: 0x0600B152 RID: 45394 RVA: 0x001A9072 File Offset: 0x001A7272
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

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x0600B153 RID: 45395 RVA: 0x001A907B File Offset: 0x001A727B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BatchIds
		{
			get
			{
				return this.batchIds_;
			}
		}

		// Token: 0x0600B154 RID: 45396 RVA: 0x001A9083 File Offset: 0x001A7283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockBatchCollectRequest);
		}

		// Token: 0x0600B155 RID: 45397 RVA: 0x001A9094 File Offset: 0x001A7294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockBatchCollectRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.EntityId == other.EntityId && this.batchIds_.Equals(other.batchIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B156 RID: 45398 RVA: 0x001A90F4 File Offset: 0x001A72F4
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

		// Token: 0x0600B157 RID: 45399 RVA: 0x001A915A File Offset: 0x001A735A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B158 RID: 45400 RVA: 0x001A9167 File Offset: 0x001A7367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B159 RID: 45401 RVA: 0x001A9170 File Offset: 0x001A7370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.InstId);
			}
			this.batchIds_.WriteTo(ref output, HookLockBatchCollectRequest._repeated_batchIds_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B15A RID: 45402 RVA: 0x001A91DC File Offset: 0x001A73DC
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

		// Token: 0x0600B15B RID: 45403 RVA: 0x001A9248 File Offset: 0x001A7448
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

		// Token: 0x0600B15C RID: 45404 RVA: 0x001A92A9 File Offset: 0x001A74A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B15D RID: 45405 RVA: 0x001A92B4 File Offset: 0x001A74B4
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
				if (num <= 80U)
				{
					if (num == 32U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 82U)
					{
						goto IL_46;
					}
					if (num == 120U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.batchIds_.AddEntriesFrom(ref input, HookLockBatchCollectRequest._repeated_batchIds_codec);
			}
		}

		// Token: 0x04004F80 RID: 20352
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F81 RID: 20353
		public const int InstIdFieldNumber = 4;

		// Token: 0x04004F82 RID: 20354
		private int instId_;

		// Token: 0x04004F83 RID: 20355
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04004F84 RID: 20356
		private long entityId_;

		// Token: 0x04004F85 RID: 20357
		public const int BatchIdsFieldNumber = 10;

		// Token: 0x04004F86 RID: 20358
		private static readonly FieldCodec<long> _repeated_batchIds_codec = FieldCodec.ForInt64(82U);

		// Token: 0x04004F87 RID: 20359
		private readonly RepeatedField<long> batchIds_ = new RepeatedField<long>();
	}
}
