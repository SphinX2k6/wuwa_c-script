using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D3 RID: 2003
	[NetMessage(EMessageId.InfluenceRewardResponse)]
	public sealed class InfluenceRewardResponse : IMessage<InfluenceRewardResponse>, IMessage, IEquatable<InfluenceRewardResponse>, IDeepCloneable<InfluenceRewardResponse>, IBufferMessage
	{
		// Token: 0x0600B402 RID: 46082 RVA: 0x001AE8F1 File Offset: 0x001ACAF1
		[NullableContext(1)]
		public static InfluenceRewardResponse Create()
		{
			return new InfluenceRewardResponse();
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x0600B403 RID: 46083 RVA: 0x001AE8F8 File Offset: 0x001ACAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x0600B404 RID: 46084 RVA: 0x001AE8FB File Offset: 0x001ACAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfluenceRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600B405 RID: 46085 RVA: 0x001AE902 File Offset: 0x001ACB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardResponse()
		{
		}

		// Token: 0x0600B406 RID: 46086 RVA: 0x001AE918 File Offset: 0x001ACB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardResponse(InfluenceRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this.influenceId_ = other.influenceId_;
			this.rewardIndex_ = other.rewardIndex_;
			this.rewardItems_ = other.rewardItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B407 RID: 46087 RVA: 0x001AE971 File Offset: 0x001ACB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardResponse Clone()
		{
			return new InfluenceRewardResponse(this);
		}

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x0600B408 RID: 46088 RVA: 0x001AE979 File Offset: 0x001ACB79
		// (set) Token: 0x0600B409 RID: 46089 RVA: 0x001AE981 File Offset: 0x001ACB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x0600B40A RID: 46090 RVA: 0x001AE98A File Offset: 0x001ACB8A
		// (set) Token: 0x0600B40B RID: 46091 RVA: 0x001AE992 File Offset: 0x001ACB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InfluenceId
		{
			get
			{
				return this.influenceId_;
			}
			set
			{
				this.influenceId_ = value;
			}
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x0600B40C RID: 46092 RVA: 0x001AE99B File Offset: 0x001ACB9B
		// (set) Token: 0x0600B40D RID: 46093 RVA: 0x001AE9A3 File Offset: 0x001ACBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardIndex
		{
			get
			{
				return this.rewardIndex_;
			}
			set
			{
				this.rewardIndex_ = value;
			}
		}

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x0600B40E RID: 46094 RVA: 0x001AE9AC File Offset: 0x001ACBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x0600B40F RID: 46095 RVA: 0x001AE9B4 File Offset: 0x001ACBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfluenceRewardResponse);
		}

		// Token: 0x0600B410 RID: 46096 RVA: 0x001AE9C4 File Offset: 0x001ACBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfluenceRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.InfluenceId == other.InfluenceId && this.RewardIndex == other.RewardIndex && this.RewardItems.Equals(other.RewardItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B411 RID: 46097 RVA: 0x001AEA34 File Offset: 0x001ACC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.InfluenceId != 0)
			{
				num ^= this.InfluenceId.GetHashCode();
			}
			if (this.RewardIndex != 0)
			{
				num ^= this.RewardIndex.GetHashCode();
			}
			num ^= this.RewardItems.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B412 RID: 46098 RVA: 0x001AEAB9 File Offset: 0x001ACCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B413 RID: 46099 RVA: 0x001AEAC6 File Offset: 0x001ACCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B414 RID: 46100 RVA: 0x001AEAD0 File Offset: 0x001ACCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InfluenceId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.InfluenceId);
			}
			if (this.RewardIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RewardIndex);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Code);
			}
			this.rewardItems_.WriteTo(ref output, InfluenceRewardResponse._map_rewardItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B415 RID: 46101 RVA: 0x001AEB58 File Offset: 0x001ACD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.InfluenceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InfluenceId);
			}
			if (this.RewardIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardIndex);
			}
			num += this.rewardItems_.CalculateSize(InfluenceRewardResponse._map_rewardItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B416 RID: 46102 RVA: 0x001AEBDC File Offset: 0x001ACDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfluenceRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.InfluenceId != 0)
			{
				this.InfluenceId = other.InfluenceId;
			}
			if (other.RewardIndex != 0)
			{
				this.RewardIndex = other.RewardIndex;
			}
			this.rewardItems_.MergeFrom(other.rewardItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B417 RID: 46103 RVA: 0x001AEC51 File Offset: 0x001ACE51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B418 RID: 46104 RVA: 0x001AEC5C File Offset: 0x001ACE5C
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
					if (num == 24U)
					{
						this.InfluenceId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.RewardIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 98U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, InfluenceRewardResponse._map_rewardItems_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005030 RID: 20528
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005031 RID: 20529
		public const int CodeFieldNumber = 11;

		// Token: 0x04005032 RID: 20530
		private ErrorCode code_;

		// Token: 0x04005033 RID: 20531
		public const int InfluenceIdFieldNumber = 3;

		// Token: 0x04005034 RID: 20532
		private int influenceId_;

		// Token: 0x04005035 RID: 20533
		public const int RewardIndexFieldNumber = 9;

		// Token: 0x04005036 RID: 20534
		private int rewardIndex_;

		// Token: 0x04005037 RID: 20535
		public const int RewardItemsFieldNumber = 12;

		// Token: 0x04005038 RID: 20536
		private static readonly MapField<int, int>.Codec _map_rewardItems_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 98U);

		// Token: 0x04005039 RID: 20537
		private readonly MapField<int, int> rewardItems_ = new MapField<int, int>();
	}
}
