using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FF RID: 5119
	public sealed class TotalTopUpRewardInfo : IMessage<TotalTopUpRewardInfo>, IMessage, IEquatable<TotalTopUpRewardInfo>, IDeepCloneable<TotalTopUpRewardInfo>, IBufferMessage
	{
		// Token: 0x0601B372 RID: 111474 RVA: 0x003F5918 File Offset: 0x003F3B18
		[NullableContext(1)]
		public static TotalTopUpRewardInfo Create()
		{
			return new TotalTopUpRewardInfo();
		}

		// Token: 0x17005C1F RID: 23583
		// (get) Token: 0x0601B373 RID: 111475 RVA: 0x003F591F File Offset: 0x003F3B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TotalTopUpRewardInfo> Parser
		{
			get
			{
				return TotalTopUpRewardInfo._parser;
			}
		}

		// Token: 0x17005C20 RID: 23584
		// (get) Token: 0x0601B374 RID: 111476 RVA: 0x003F5926 File Offset: 0x003F3B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C21 RID: 23585
		// (get) Token: 0x0601B375 RID: 111477 RVA: 0x003F5929 File Offset: 0x003F3B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpRewardInfo.Descriptor;
			}
		}

		// Token: 0x0601B376 RID: 111478 RVA: 0x003F5930 File Offset: 0x003F3B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardInfo()
		{
		}

		// Token: 0x0601B377 RID: 111479 RVA: 0x003F5944 File Offset: 0x003F3B44
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

		// Token: 0x0601B378 RID: 111480 RVA: 0x003F599D File Offset: 0x003F3B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardInfo Clone()
		{
			return new TotalTopUpRewardInfo(this);
		}

		// Token: 0x17005C22 RID: 23586
		// (get) Token: 0x0601B379 RID: 111481 RVA: 0x003F59A5 File Offset: 0x003F3BA5
		// (set) Token: 0x0601B37A RID: 111482 RVA: 0x003F59AD File Offset: 0x003F3BAD
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

		// Token: 0x17005C23 RID: 23587
		// (get) Token: 0x0601B37B RID: 111483 RVA: 0x003F59B6 File Offset: 0x003F3BB6
		// (set) Token: 0x0601B37C RID: 111484 RVA: 0x003F59BE File Offset: 0x003F3BBE
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

		// Token: 0x17005C24 RID: 23588
		// (get) Token: 0x0601B37D RID: 111485 RVA: 0x003F59C7 File Offset: 0x003F3BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardContent
		{
			get
			{
				return this.rewardContent_;
			}
		}

		// Token: 0x17005C25 RID: 23589
		// (get) Token: 0x0601B37E RID: 111486 RVA: 0x003F59CF File Offset: 0x003F3BCF
		// (set) Token: 0x0601B37F RID: 111487 RVA: 0x003F59D7 File Offset: 0x003F3BD7
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

		// Token: 0x0601B380 RID: 111488 RVA: 0x003F59E0 File Offset: 0x003F3BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpRewardInfo);
		}

		// Token: 0x0601B381 RID: 111489 RVA: 0x003F59F0 File Offset: 0x003F3BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Score == other.Score && this.RewardContent.Equals(other.RewardContent) && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B382 RID: 111490 RVA: 0x003F5A60 File Offset: 0x003F3C60
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

		// Token: 0x0601B383 RID: 111491 RVA: 0x003F5ADF File Offset: 0x003F3CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B384 RID: 111492 RVA: 0x003F5AEC File Offset: 0x003F3CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B385 RID: 111493 RVA: 0x003F5AF8 File Offset: 0x003F3CF8
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

		// Token: 0x0601B386 RID: 111494 RVA: 0x003F5B80 File Offset: 0x003F3D80
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

		// Token: 0x0601B387 RID: 111495 RVA: 0x003F5C04 File Offset: 0x003F3E04
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

		// Token: 0x0601B388 RID: 111496 RVA: 0x003F5C79 File Offset: 0x003F3E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B389 RID: 111497 RVA: 0x003F5C84 File Offset: 0x003F3E84
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

		// Token: 0x04009EAA RID: 40618
		private static readonly MessageParser<TotalTopUpRewardInfo> _parser = new MessageParser<TotalTopUpRewardInfo>(() => new TotalTopUpRewardInfo());

		// Token: 0x04009EAB RID: 40619
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EAC RID: 40620
		public const int IdFieldNumber = 1;

		// Token: 0x04009EAD RID: 40621
		private int id_;

		// Token: 0x04009EAE RID: 40622
		public const int ScoreFieldNumber = 2;

		// Token: 0x04009EAF RID: 40623
		private int score_;

		// Token: 0x04009EB0 RID: 40624
		public const int RewardContentFieldNumber = 3;

		// Token: 0x04009EB1 RID: 40625
		private static readonly MapField<int, int>.Codec _map_rewardContent_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x04009EB2 RID: 40626
		private readonly MapField<int, int> rewardContent_ = new MapField<int, int>();

		// Token: 0x04009EB3 RID: 40627
		public const int StatusFieldNumber = 4;

		// Token: 0x04009EB4 RID: 40628
		private int status_;
	}
}
