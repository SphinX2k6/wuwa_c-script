using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AF RID: 1967
	[NetMessage(EMessageId.HookLockBatchCollectNotify)]
	public sealed class HookLockBatchCollectNotify : IMessage<HookLockBatchCollectNotify>, IMessage, IEquatable<HookLockBatchCollectNotify>, IDeepCloneable<HookLockBatchCollectNotify>, IBufferMessage
	{
		// Token: 0x0600B133 RID: 45363 RVA: 0x001A8C7F File Offset: 0x001A6E7F
		[NullableContext(1)]
		public static HookLockBatchCollectNotify Create()
		{
			return new HookLockBatchCollectNotify();
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x0600B134 RID: 45364 RVA: 0x001A8C86 File Offset: 0x001A6E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x0600B135 RID: 45365 RVA: 0x001A8C89 File Offset: 0x001A6E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockBatchCollectNotify.Descriptor;
			}
		}

		// Token: 0x0600B136 RID: 45366 RVA: 0x001A8C90 File Offset: 0x001A6E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectNotify()
		{
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x001A8CA4 File Offset: 0x001A6EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectNotify(HookLockBatchCollectNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.entityConfigId_ = other.entityConfigId_;
			this.successConfigIds_ = other.successConfigIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B138 RID: 45368 RVA: 0x001A8CF1 File Offset: 0x001A6EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockBatchCollectNotify Clone()
		{
			return new HookLockBatchCollectNotify(this);
		}

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x0600B139 RID: 45369 RVA: 0x001A8CF9 File Offset: 0x001A6EF9
		// (set) Token: 0x0600B13A RID: 45370 RVA: 0x001A8D01 File Offset: 0x001A6F01
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

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x0600B13B RID: 45371 RVA: 0x001A8D0A File Offset: 0x001A6F0A
		// (set) Token: 0x0600B13C RID: 45372 RVA: 0x001A8D12 File Offset: 0x001A6F12
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

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x0600B13D RID: 45373 RVA: 0x001A8D1B File Offset: 0x001A6F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SuccessConfigIds
		{
			get
			{
				return this.successConfigIds_;
			}
		}

		// Token: 0x0600B13E RID: 45374 RVA: 0x001A8D23 File Offset: 0x001A6F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockBatchCollectNotify);
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x001A8D34 File Offset: 0x001A6F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockBatchCollectNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EntityConfigId == other.EntityConfigId && this.successConfigIds_.Equals(other.successConfigIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x001A8D94 File Offset: 0x001A6F94
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

		// Token: 0x0600B141 RID: 45377 RVA: 0x001A8DFA File Offset: 0x001A6FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B142 RID: 45378 RVA: 0x001A8E07 File Offset: 0x001A7007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B143 RID: 45379 RVA: 0x001A8E10 File Offset: 0x001A7010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerId);
			}
			this.successConfigIds_.WriteTo(ref output, HookLockBatchCollectNotify._repeated_successConfigIds_codec);
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B144 RID: 45380 RVA: 0x001A8E7C File Offset: 0x001A707C
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

		// Token: 0x0600B145 RID: 45381 RVA: 0x001A8EE8 File Offset: 0x001A70E8
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

		// Token: 0x0600B146 RID: 45382 RVA: 0x001A8F49 File Offset: 0x001A7149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B147 RID: 45383 RVA: 0x001A8F54 File Offset: 0x001A7154
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
				if (num <= 72U)
				{
					if (num == 16U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_46;
					}
					if (num == 80U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.successConfigIds_.AddEntriesFrom(ref input, HookLockBatchCollectNotify._repeated_successConfigIds_codec);
			}
		}

		// Token: 0x04004F78 RID: 20344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F79 RID: 20345
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04004F7A RID: 20346
		private int playerId_;

		// Token: 0x04004F7B RID: 20347
		public const int EntityConfigIdFieldNumber = 10;

		// Token: 0x04004F7C RID: 20348
		private int entityConfigId_;

		// Token: 0x04004F7D RID: 20349
		public const int SuccessConfigIdsFieldNumber = 9;

		// Token: 0x04004F7E RID: 20350
		private static readonly FieldCodec<int> _repeated_successConfigIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04004F7F RID: 20351
		private readonly RepeatedField<int> successConfigIds_ = new RepeatedField<int>();
	}
}
