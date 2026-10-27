using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040C RID: 1036
	[NetMessage(EMessageId.DropCatchLevelRewardRequest)]
	public sealed class DropCatchLevelRewardRequest : IMessage<DropCatchLevelRewardRequest>, IMessage, IEquatable<DropCatchLevelRewardRequest>, IDeepCloneable<DropCatchLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x060063DC RID: 25564 RVA: 0x000F0096 File Offset: 0x000EE296
		[NullableContext(1)]
		public static DropCatchLevelRewardRequest Create()
		{
			return new DropCatchLevelRewardRequest();
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x060063DD RID: 25565 RVA: 0x000F009D File Offset: 0x000EE29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x060063DE RID: 25566 RVA: 0x000F00A0 File Offset: 0x000EE2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x000F00A7 File Offset: 0x000EE2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardRequest()
		{
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x000F00BA File Offset: 0x000EE2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardRequest(DropCatchLevelRewardRequest other) : this()
		{
			this.dropCatchId_ = other.dropCatchId_;
			this.rewardIdxs_ = other.rewardIdxs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x000F00F0 File Offset: 0x000EE2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardRequest Clone()
		{
			return new DropCatchLevelRewardRequest(this);
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x060063E2 RID: 25570 RVA: 0x000F00F8 File Offset: 0x000EE2F8
		// (set) Token: 0x060063E3 RID: 25571 RVA: 0x000F0100 File Offset: 0x000EE300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DropCatchId
		{
			get
			{
				return this.dropCatchId_;
			}
			set
			{
				this.dropCatchId_ = value;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x060063E4 RID: 25572 RVA: 0x000F0109 File Offset: 0x000EE309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIdxs
		{
			get
			{
				return this.rewardIdxs_;
			}
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x000F0111 File Offset: 0x000EE311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelRewardRequest);
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x000F0120 File Offset: 0x000EE320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelRewardRequest other)
		{
			return other != null && (other == this || (this.DropCatchId == other.DropCatchId && this.rewardIdxs_.Equals(other.rewardIdxs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x000F0170 File Offset: 0x000EE370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DropCatchId != 0)
			{
				num ^= this.DropCatchId.GetHashCode();
			}
			num ^= this.rewardIdxs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x000F01BD File Offset: 0x000EE3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x000F01CA File Offset: 0x000EE3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x000F01D4 File Offset: 0x000EE3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DropCatchId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DropCatchId);
			}
			this.rewardIdxs_.WriteTo(ref output, DropCatchLevelRewardRequest._repeated_rewardIdxs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x000F0224 File Offset: 0x000EE424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DropCatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropCatchId);
			}
			num += this.rewardIdxs_.CalculateSize(DropCatchLevelRewardRequest._repeated_rewardIdxs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x000F0278 File Offset: 0x000EE478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DropCatchId != 0)
			{
				this.DropCatchId = other.DropCatchId;
			}
			this.rewardIdxs_.Add(other.rewardIdxs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x000F02C5 File Offset: 0x000EE4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x000F02D0 File Offset: 0x000EE4D0
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
				if (num != 32U)
				{
					if (num != 40U && num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewardIdxs_.AddEntriesFrom(ref input, DropCatchLevelRewardRequest._repeated_rewardIdxs_codec);
					}
				}
				else
				{
					this.DropCatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003841 RID: 14401
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003842 RID: 14402
		public const int DropCatchIdFieldNumber = 4;

		// Token: 0x04003843 RID: 14403
		private int dropCatchId_;

		// Token: 0x04003844 RID: 14404
		public const int RewardIdxsFieldNumber = 5;

		// Token: 0x04003845 RID: 14405
		private static readonly FieldCodec<int> _repeated_rewardIdxs_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04003846 RID: 14406
		private readonly RepeatedField<int> rewardIdxs_ = new RepeatedField<int>();
	}
}
