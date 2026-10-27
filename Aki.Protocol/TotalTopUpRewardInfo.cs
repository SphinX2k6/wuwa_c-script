using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138C RID: 5004
	public sealed class TotalTopUpRewardInfo : IMessage<TotalTopUpRewardInfo>, IMessage, IEquatable<TotalTopUpRewardInfo>, IDeepCloneable<TotalTopUpRewardInfo>, IBufferMessage
	{
		// Token: 0x0601A8E7 RID: 108775 RVA: 0x003DA64C File Offset: 0x003D884C
		[NullableContext(1)]
		public static TotalTopUpRewardInfo Create()
		{
			return new TotalTopUpRewardInfo();
		}

		// Token: 0x1700598A RID: 22922
		// (get) Token: 0x0601A8E8 RID: 108776 RVA: 0x003DA653 File Offset: 0x003D8853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TotalTopUpRewardInfo> Parser
		{
			get
			{
				return TotalTopUpRewardInfo._parser;
			}
		}

		// Token: 0x1700598B RID: 22923
		// (get) Token: 0x0601A8E9 RID: 108777 RVA: 0x003DA65A File Offset: 0x003D885A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700598C RID: 22924
		// (get) Token: 0x0601A8EA RID: 108778 RVA: 0x003DA65D File Offset: 0x003D885D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpRewardInfo.Descriptor;
			}
		}

		// Token: 0x0601A8EB RID: 108779 RVA: 0x003DA664 File Offset: 0x003D8864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardInfo()
		{
		}

		// Token: 0x0601A8EC RID: 108780 RVA: 0x003DA678 File Offset: 0x003D8878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardInfo(TotalTopUpRewardInfo other) : this()
		{
			this.id_ = other.id_;
			this.score_ = other.score_;
			this.rewardContent_ = other.rewardContent_.Clone();
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A8ED RID: 108781 RVA: 0x003DA6D1 File Offset: 0x003D88D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardInfo Clone()
		{
			return new TotalTopUpRewardInfo(this);
		}

		// Token: 0x1700598D RID: 22925
		// (get) Token: 0x0601A8EE RID: 108782 RVA: 0x003DA6D9 File Offset: 0x003D88D9
		// (set) Token: 0x0601A8EF RID: 108783 RVA: 0x003DA6E1 File Offset: 0x003D88E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700598E RID: 22926
		// (get) Token: 0x0601A8F0 RID: 108784 RVA: 0x003DA6EA File Offset: 0x003D88EA
		// (set) Token: 0x0601A8F1 RID: 108785 RVA: 0x003DA6F2 File Offset: 0x003D88F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x1700598F RID: 22927
		// (get) Token: 0x0601A8F2 RID: 108786 RVA: 0x003DA6FB File Offset: 0x003D88FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardContent
		{
			get
			{
				return this.rewardContent_;
			}
		}

		// Token: 0x17005990 RID: 22928
		// (get) Token: 0x0601A8F3 RID: 108787 RVA: 0x003DA703 File Offset: 0x003D8903
		// (set) Token: 0x0601A8F4 RID: 108788 RVA: 0x003DA70B File Offset: 0x003D890B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0601A8F5 RID: 108789 RVA: 0x003DA714 File Offset: 0x003D8914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpRewardInfo);
		}

		// Token: 0x0601A8F6 RID: 108790 RVA: 0x003DA724 File Offset: 0x003D8924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Score == other.Score && this.RewardContent.Equals(other.RewardContent) && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A8F7 RID: 108791 RVA: 0x003DA794 File Offset: 0x003D8994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			num ^= this.RewardContent.GetHashCode();
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A8F8 RID: 108792 RVA: 0x003DA813 File Offset: 0x003D8A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A8F9 RID: 108793 RVA: 0x003DA820 File Offset: 0x003D8A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A8FA RID: 108794 RVA: 0x003DA82C File Offset: 0x003D8A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			this.rewardContent_.WriteTo(ref output, TotalTopUpRewardInfo._map_rewardContent_codec);
			if (this.Status != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A8FB RID: 108795 RVA: 0x003DA8B4 File Offset: 0x003D8AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			num += this.rewardContent_.CalculateSize(TotalTopUpRewardInfo._map_rewardContent_codec);
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A8FC RID: 108796 RVA: 0x003DA938 File Offset: 0x003D8B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this.rewardContent_.MergeFrom(other.rewardContent_);
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A8FD RID: 108797 RVA: 0x003DA9AD File Offset: 0x003D8BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A8FE RID: 108798 RVA: 0x003DA9B8 File Offset: 0x003D8BB8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.rewardContent_.AddEntriesFrom(ref input, TotalTopUpRewardInfo._map_rewardContent_codec);
						continue;
					}
					if (num == 32U)
					{
						this.Status = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009A63 RID: 39523
		private static readonly MessageParser<TotalTopUpRewardInfo> _parser = new MessageParser<TotalTopUpRewardInfo>(() => new TotalTopUpRewardInfo());

		// Token: 0x04009A64 RID: 39524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A65 RID: 39525
		public const int IdFieldNumber = 1;

		// Token: 0x04009A66 RID: 39526
		private int id_;

		// Token: 0x04009A67 RID: 39527
		public const int ScoreFieldNumber = 2;

		// Token: 0x04009A68 RID: 39528
		private int score_;

		// Token: 0x04009A69 RID: 39529
		public const int RewardContentFieldNumber = 3;

		// Token: 0x04009A6A RID: 39530
		private static readonly MapField<int, int>.Codec _map_rewardContent_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x04009A6B RID: 39531
		private readonly MapField<int, int> rewardContent_ = new MapField<int, int>();

		// Token: 0x04009A6C RID: 39532
		public const int StatusFieldNumber = 4;

		// Token: 0x04009A6D RID: 39533
		private int status_;
	}
}
