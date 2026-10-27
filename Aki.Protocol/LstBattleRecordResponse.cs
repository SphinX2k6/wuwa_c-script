using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096B RID: 2411
	[NetMessage(EMessageId.LstBattleRecordResponse)]
	public sealed class LstBattleRecordResponse : IMessage<LstBattleRecordResponse>, IMessage, IEquatable<LstBattleRecordResponse>, IDeepCloneable<LstBattleRecordResponse>, IBufferMessage
	{
		// Token: 0x0600D44A RID: 54346 RVA: 0x001F427A File Offset: 0x001F247A
		[NullableContext(1)]
		public static LstBattleRecordResponse Create()
		{
			return new LstBattleRecordResponse();
		}

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x0600D44B RID: 54347 RVA: 0x001F4281 File Offset: 0x001F2481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x0600D44C RID: 54348 RVA: 0x001F4284 File Offset: 0x001F2484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LstBattleRecordResponse.Descriptor;
			}
		}

		// Token: 0x0600D44D RID: 54349 RVA: 0x001F428B File Offset: 0x001F248B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordResponse()
		{
		}

		// Token: 0x0600D44E RID: 54350 RVA: 0x001F42A0 File Offset: 0x001F24A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordResponse(LstBattleRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.lstLevelInfos_ = other.lstLevelInfos_.Clone();
			this.lastTotalRewardCount_ = other.lastTotalRewardCount_;
			this.lastCanRewardCount_ = other.lastCanRewardCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D44F RID: 54351 RVA: 0x001F42F9 File Offset: 0x001F24F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordResponse Clone()
		{
			return new LstBattleRecordResponse(this);
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x0600D450 RID: 54352 RVA: 0x001F4301 File Offset: 0x001F2501
		// (set) Token: 0x0600D451 RID: 54353 RVA: 0x001F4309 File Offset: 0x001F2509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x0600D452 RID: 54354 RVA: 0x001F4312 File Offset: 0x001F2512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LstLevelInfo> LstLevelInfos
		{
			get
			{
				return this.lstLevelInfos_;
			}
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x0600D453 RID: 54355 RVA: 0x001F431A File Offset: 0x001F251A
		// (set) Token: 0x0600D454 RID: 54356 RVA: 0x001F4322 File Offset: 0x001F2522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastTotalRewardCount
		{
			get
			{
				return this.lastTotalRewardCount_;
			}
			set
			{
				this.lastTotalRewardCount_ = value;
			}
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x0600D455 RID: 54357 RVA: 0x001F432B File Offset: 0x001F252B
		// (set) Token: 0x0600D456 RID: 54358 RVA: 0x001F4333 File Offset: 0x001F2533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastCanRewardCount
		{
			get
			{
				return this.lastCanRewardCount_;
			}
			set
			{
				this.lastCanRewardCount_ = value;
			}
		}

		// Token: 0x0600D457 RID: 54359 RVA: 0x001F433C File Offset: 0x001F253C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LstBattleRecordResponse);
		}

		// Token: 0x0600D458 RID: 54360 RVA: 0x001F434C File Offset: 0x001F254C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LstBattleRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.lstLevelInfos_.Equals(other.lstLevelInfos_) && this.LastTotalRewardCount == other.LastTotalRewardCount && this.LastCanRewardCount == other.LastCanRewardCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D459 RID: 54361 RVA: 0x001F43BC File Offset: 0x001F25BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.lstLevelInfos_.GetHashCode();
			if (this.LastTotalRewardCount != 0)
			{
				num ^= this.LastTotalRewardCount.GetHashCode();
			}
			if (this.LastCanRewardCount != 0)
			{
				num ^= this.LastCanRewardCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D45A RID: 54362 RVA: 0x001F4441 File Offset: 0x001F2641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D45B RID: 54363 RVA: 0x001F444E File Offset: 0x001F264E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D45C RID: 54364 RVA: 0x001F4458 File Offset: 0x001F2658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lstLevelInfos_.WriteTo(ref output, LstBattleRecordResponse._repeated_lstLevelInfos_codec);
			if (this.LastCanRewardCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LastCanRewardCount);
			}
			if (this.LastTotalRewardCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LastTotalRewardCount);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D45D RID: 54365 RVA: 0x001F44E0 File Offset: 0x001F26E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.lstLevelInfos_.CalculateSize(LstBattleRecordResponse._repeated_lstLevelInfos_codec);
			if (this.LastTotalRewardCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastTotalRewardCount);
			}
			if (this.LastCanRewardCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastCanRewardCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D45E RID: 54366 RVA: 0x001F4564 File Offset: 0x001F2764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LstBattleRecordResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.lstLevelInfos_.Add(other.lstLevelInfos_);
			if (other.LastTotalRewardCount != 0)
			{
				this.LastTotalRewardCount = other.LastTotalRewardCount;
			}
			if (other.LastCanRewardCount != 0)
			{
				this.LastCanRewardCount = other.LastCanRewardCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D45F RID: 54367 RVA: 0x001F45D9 File Offset: 0x001F27D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D460 RID: 54368 RVA: 0x001F45E4 File Offset: 0x001F27E4
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
				if (num <= 48U)
				{
					if (num == 18U)
					{
						this.lstLevelInfos_.AddEntriesFrom(ref input, LstBattleRecordResponse._repeated_lstLevelInfos_codec);
						continue;
					}
					if (num == 48U)
					{
						this.LastCanRewardCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.LastTotalRewardCount = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005915 RID: 22805
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005916 RID: 22806
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005917 RID: 22807
		private ErrorCode errorCode_;

		// Token: 0x04005918 RID: 22808
		public const int LstLevelInfosFieldNumber = 2;

		// Token: 0x04005919 RID: 22809
		private static readonly FieldCodec<LstLevelInfo> _repeated_lstLevelInfos_codec = FieldCodec.ForMessage<LstLevelInfo>(18U, LstLevelInfo.Parser);

		// Token: 0x0400591A RID: 22810
		private readonly RepeatedField<LstLevelInfo> lstLevelInfos_ = new RepeatedField<LstLevelInfo>();

		// Token: 0x0400591B RID: 22811
		public const int LastTotalRewardCountFieldNumber = 7;

		// Token: 0x0400591C RID: 22812
		private int lastTotalRewardCount_;

		// Token: 0x0400591D RID: 22813
		public const int LastCanRewardCountFieldNumber = 6;

		// Token: 0x0400591E RID: 22814
		private int lastCanRewardCount_;
	}
}
