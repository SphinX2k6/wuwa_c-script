using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079B RID: 1947
	[NetMessage(EMessageId.HookLockBatchCollectNotify)]
	public sealed class HookLockBatchCollectNotify : IMessage<HookLockBatchCollectNotify>, IMessage, IEquatable<HookLockBatchCollectNotify>, IDeepCloneable<HookLockBatchCollectNotify>, IBufferMessage
	{
		// Token: 0x0600AFDD RID: 45021 RVA: 0x001A624F File Offset: 0x001A444F
		[NullableContext(1)]
		public static HookLockBatchCollectNotify Create()
		{
			return new HookLockBatchCollectNotify();
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x0600AFDE RID: 45022 RVA: 0x001A6256 File Offset: 0x001A4456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x0600AFDF RID: 45023 RVA: 0x001A6259 File Offset: 0x001A4459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockBatchCollectNotify.Descriptor;
			}
		}

		// Token: 0x0600AFE0 RID: 45024 RVA: 0x001A6260 File Offset: 0x001A4460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectNotify()
		{
		}

		// Token: 0x0600AFE1 RID: 45025 RVA: 0x001A6274 File Offset: 0x001A4474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectNotify(HookLockBatchCollectNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.entityConfigId_ = other.entityConfigId_;
			this.successConfigIds_ = other.successConfigIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFE2 RID: 45026 RVA: 0x001A62C1 File Offset: 0x001A44C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectNotify Clone()
		{
			return new HookLockBatchCollectNotify(this);
		}

		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x0600AFE3 RID: 45027 RVA: 0x001A62C9 File Offset: 0x001A44C9
		// (set) Token: 0x0600AFE4 RID: 45028 RVA: 0x001A62D1 File Offset: 0x001A44D1
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

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x0600AFE5 RID: 45029 RVA: 0x001A62DA File Offset: 0x001A44DA
		// (set) Token: 0x0600AFE6 RID: 45030 RVA: 0x001A62E2 File Offset: 0x001A44E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x0600AFE7 RID: 45031 RVA: 0x001A62EB File Offset: 0x001A44EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SuccessConfigIds
		{
			get
			{
				return this.successConfigIds_;
			}
		}

		// Token: 0x0600AFE8 RID: 45032 RVA: 0x001A62F3 File Offset: 0x001A44F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockBatchCollectNotify);
		}

		// Token: 0x0600AFE9 RID: 45033 RVA: 0x001A6304 File Offset: 0x001A4504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockBatchCollectNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EntityConfigId == other.EntityConfigId && this.successConfigIds_.Equals(other.successConfigIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFEA RID: 45034 RVA: 0x001A6364 File Offset: 0x001A4564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			num ^= this.successConfigIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AFEB RID: 45035 RVA: 0x001A63CA File Offset: 0x001A45CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x001A63D7 File Offset: 0x001A45D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFED RID: 45037 RVA: 0x001A63E0 File Offset: 0x001A45E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.successConfigIds_.WriteTo(ref output, HookLockBatchCollectNotify._repeated_successConfigIds_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFEE RID: 45038 RVA: 0x001A644C File Offset: 0x001A464C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			num += this.successConfigIds_.CalculateSize(HookLockBatchCollectNotify._repeated_successConfigIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AFEF RID: 45039 RVA: 0x001A64B8 File Offset: 0x001A46B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockBatchCollectNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			this.successConfigIds_.Add(other.successConfigIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AFF0 RID: 45040 RVA: 0x001A6519 File Offset: 0x001A4719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFF1 RID: 45041 RVA: 0x001A6524 File Offset: 0x001A4724
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
				if (num <= 90U)
				{
					if (num == 88U || num == 90U)
					{
						this.successConfigIds_.AddEntriesFrom(ref input, HookLockBatchCollectNotify._repeated_successConfigIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F71 RID: 20337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F72 RID: 20338
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x04004F73 RID: 20339
		private int playerId_;

		// Token: 0x04004F74 RID: 20340
		public const int EntityConfigIdFieldNumber = 14;

		// Token: 0x04004F75 RID: 20341
		private int entityConfigId_;

		// Token: 0x04004F76 RID: 20342
		public const int SuccessConfigIdsFieldNumber = 11;

		// Token: 0x04004F77 RID: 20343
		private static readonly FieldCodec<int> _repeated_successConfigIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04004F78 RID: 20344
		private readonly RepeatedField<int> successConfigIds_ = new RepeatedField<int>();
	}
}
