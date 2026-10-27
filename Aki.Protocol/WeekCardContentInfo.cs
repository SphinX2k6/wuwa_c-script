using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001504 RID: 5380
	public sealed class WeekCardContentInfo : IMessage<WeekCardContentInfo>, IMessage, IEquatable<WeekCardContentInfo>, IDeepCloneable<WeekCardContentInfo>, IBufferMessage
	{
		// Token: 0x0601C6F4 RID: 116468 RVA: 0x0041B4E1 File Offset: 0x004196E1
		[NullableContext(1)]
		public static WeekCardContentInfo Create()
		{
			return new WeekCardContentInfo();
		}

		// Token: 0x17005FD7 RID: 24535
		// (get) Token: 0x0601C6F5 RID: 116469 RVA: 0x0041B4E8 File Offset: 0x004196E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeekCardContentInfo> Parser
		{
			get
			{
				return WeekCardContentInfo._parser;
			}
		}

		// Token: 0x17005FD8 RID: 24536
		// (get) Token: 0x0601C6F6 RID: 116470 RVA: 0x0041B4EF File Offset: 0x004196EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FD9 RID: 24537
		// (get) Token: 0x0601C6F7 RID: 116471 RVA: 0x0041B4F2 File Offset: 0x004196F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardContentInfo.Descriptor;
			}
		}

		// Token: 0x0601C6F8 RID: 116472 RVA: 0x0041B4F9 File Offset: 0x004196F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardContentInfo()
		{
		}

		// Token: 0x0601C6F9 RID: 116473 RVA: 0x0041B50C File Offset: 0x0041970C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardContentInfo(WeekCardContentInfo other) : this()
		{
			this.weekCardContentId_ = other.weekCardContentId_;
			this.unlockDay_ = other.unlockDay_;
			this.rewardContent_ = other.rewardContent_.Clone();
			this.unlockTimeStamp_ = other.unlockTimeStamp_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C6FA RID: 116474 RVA: 0x0041B571 File Offset: 0x00419771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardContentInfo Clone()
		{
			return new WeekCardContentInfo(this);
		}

		// Token: 0x17005FDA RID: 24538
		// (get) Token: 0x0601C6FB RID: 116475 RVA: 0x0041B579 File Offset: 0x00419779
		// (set) Token: 0x0601C6FC RID: 116476 RVA: 0x0041B581 File Offset: 0x00419781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeekCardContentId
		{
			get
			{
				return this.weekCardContentId_;
			}
			set
			{
				this.weekCardContentId_ = value;
			}
		}

		// Token: 0x17005FDB RID: 24539
		// (get) Token: 0x0601C6FD RID: 116477 RVA: 0x0041B58A File Offset: 0x0041978A
		// (set) Token: 0x0601C6FE RID: 116478 RVA: 0x0041B592 File Offset: 0x00419792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnlockDay
		{
			get
			{
				return this.unlockDay_;
			}
			set
			{
				this.unlockDay_ = value;
			}
		}

		// Token: 0x17005FDC RID: 24540
		// (get) Token: 0x0601C6FF RID: 116479 RVA: 0x0041B59B File Offset: 0x0041979B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardContent
		{
			get
			{
				return this.rewardContent_;
			}
		}

		// Token: 0x17005FDD RID: 24541
		// (get) Token: 0x0601C700 RID: 116480 RVA: 0x0041B5A3 File Offset: 0x004197A3
		// (set) Token: 0x0601C701 RID: 116481 RVA: 0x0041B5AB File Offset: 0x004197AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTimeStamp
		{
			get
			{
				return this.unlockTimeStamp_;
			}
			set
			{
				this.unlockTimeStamp_ = value;
			}
		}

		// Token: 0x17005FDE RID: 24542
		// (get) Token: 0x0601C702 RID: 116482 RVA: 0x0041B5B4 File Offset: 0x004197B4
		// (set) Token: 0x0601C703 RID: 116483 RVA: 0x0041B5BC File Offset: 0x004197BC
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

		// Token: 0x0601C704 RID: 116484 RVA: 0x0041B5C5 File Offset: 0x004197C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardContentInfo);
		}

		// Token: 0x0601C705 RID: 116485 RVA: 0x0041B5D4 File Offset: 0x004197D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardContentInfo other)
		{
			return other != null && (other == this || (this.WeekCardContentId == other.WeekCardContentId && this.UnlockDay == other.UnlockDay && this.RewardContent.Equals(other.RewardContent) && this.UnlockTimeStamp == other.UnlockTimeStamp && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C706 RID: 116486 RVA: 0x0041B654 File Offset: 0x00419854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeekCardContentId != 0)
			{
				num ^= this.WeekCardContentId.GetHashCode();
			}
			if (this.UnlockDay != 0)
			{
				num ^= this.UnlockDay.GetHashCode();
			}
			num ^= this.RewardContent.GetHashCode();
			if (this.UnlockTimeStamp != 0L)
			{
				num ^= this.UnlockTimeStamp.GetHashCode();
			}
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

		// Token: 0x0601C707 RID: 116487 RVA: 0x0041B6EC File Offset: 0x004198EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C708 RID: 116488 RVA: 0x0041B6F9 File Offset: 0x004198F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C709 RID: 116489 RVA: 0x0041B704 File Offset: 0x00419904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeekCardContentId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeekCardContentId);
			}
			if (this.UnlockDay != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UnlockDay);
			}
			this.rewardContent_.WriteTo(ref output, WeekCardContentInfo._map_rewardContent_codec);
			if (this.UnlockTimeStamp != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.UnlockTimeStamp);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C70A RID: 116490 RVA: 0x0041B7A8 File Offset: 0x004199A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeekCardContentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeekCardContentId);
			}
			if (this.UnlockDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnlockDay);
			}
			num += this.rewardContent_.CalculateSize(WeekCardContentInfo._map_rewardContent_codec);
			if (this.UnlockTimeStamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTimeStamp);
			}
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

		// Token: 0x0601C70B RID: 116491 RVA: 0x0041B844 File Offset: 0x00419A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeekCardContentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeekCardContentId != 0)
			{
				this.WeekCardContentId = other.WeekCardContentId;
			}
			if (other.UnlockDay != 0)
			{
				this.UnlockDay = other.UnlockDay;
			}
			this.rewardContent_.MergeFrom(other.rewardContent_);
			if (other.UnlockTimeStamp != 0L)
			{
				this.UnlockTimeStamp = other.UnlockTimeStamp;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C70C RID: 116492 RVA: 0x0041B8CD File Offset: 0x00419ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C70D RID: 116493 RVA: 0x0041B8D8 File Offset: 0x00419AD8
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
						this.WeekCardContentId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.UnlockDay = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.rewardContent_.AddEntriesFrom(ref input, WeekCardContentInfo._map_rewardContent_codec);
						continue;
					}
					if (num == 32U)
					{
						this.UnlockTimeStamp = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.Status = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A2C2 RID: 41666
		private static readonly MessageParser<WeekCardContentInfo> _parser = new MessageParser<WeekCardContentInfo>(() => new WeekCardContentInfo());

		// Token: 0x0400A2C3 RID: 41667
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2C4 RID: 41668
		public const int WeekCardContentIdFieldNumber = 1;

		// Token: 0x0400A2C5 RID: 41669
		private int weekCardContentId_;

		// Token: 0x0400A2C6 RID: 41670
		public const int UnlockDayFieldNumber = 2;

		// Token: 0x0400A2C7 RID: 41671
		private int unlockDay_;

		// Token: 0x0400A2C8 RID: 41672
		public const int RewardContentFieldNumber = 3;

		// Token: 0x0400A2C9 RID: 41673
		private static readonly MapField<int, int>.Codec _map_rewardContent_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x0400A2CA RID: 41674
		private readonly MapField<int, int> rewardContent_ = new MapField<int, int>();

		// Token: 0x0400A2CB RID: 41675
		public const int UnlockTimeStampFieldNumber = 4;

		// Token: 0x0400A2CC RID: 41676
		private long unlockTimeStamp_;

		// Token: 0x0400A2CD RID: 41677
		public const int StatusFieldNumber = 5;

		// Token: 0x0400A2CE RID: 41678
		private int status_;
	}
}
