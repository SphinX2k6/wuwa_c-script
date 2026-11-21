using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200157A RID: 5498
	public sealed class WeekCardContentInfo : IMessage<WeekCardContentInfo>, IMessage, IEquatable<WeekCardContentInfo>, IDeepCloneable<WeekCardContentInfo>, IBufferMessage
	{
		// Token: 0x0601D1BB RID: 119227 RVA: 0x00436FA1 File Offset: 0x004351A1
		[NullableContext(1)]
		public static WeekCardContentInfo Create()
		{
			return new WeekCardContentInfo();
		}

		// Token: 0x17006278 RID: 25208
		// (get) Token: 0x0601D1BC RID: 119228 RVA: 0x00436FA8 File Offset: 0x004351A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeekCardContentInfo> Parser
		{
			get
			{
				return WeekCardContentInfo._parser;
			}
		}

		// Token: 0x17006279 RID: 25209
		// (get) Token: 0x0601D1BD RID: 119229 RVA: 0x00436FAF File Offset: 0x004351AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700627A RID: 25210
		// (get) Token: 0x0601D1BE RID: 119230 RVA: 0x00436FB2 File Offset: 0x004351B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardContentInfo.Descriptor;
			}
		}

		// Token: 0x0601D1BF RID: 119231 RVA: 0x00436FB9 File Offset: 0x004351B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardContentInfo()
		{
		}

		// Token: 0x0601D1C0 RID: 119232 RVA: 0x00436FCC File Offset: 0x004351CC
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

		// Token: 0x0601D1C1 RID: 119233 RVA: 0x00437031 File Offset: 0x00435231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardContentInfo Clone()
		{
			return new WeekCardContentInfo(this);
		}

		// Token: 0x1700627B RID: 25211
		// (get) Token: 0x0601D1C2 RID: 119234 RVA: 0x00437039 File Offset: 0x00435239
		// (set) Token: 0x0601D1C3 RID: 119235 RVA: 0x00437041 File Offset: 0x00435241
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

		// Token: 0x1700627C RID: 25212
		// (get) Token: 0x0601D1C4 RID: 119236 RVA: 0x0043704A File Offset: 0x0043524A
		// (set) Token: 0x0601D1C5 RID: 119237 RVA: 0x00437052 File Offset: 0x00435252
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

		// Token: 0x1700627D RID: 25213
		// (get) Token: 0x0601D1C6 RID: 119238 RVA: 0x0043705B File Offset: 0x0043525B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardContent
		{
			get
			{
				return this.rewardContent_;
			}
		}

		// Token: 0x1700627E RID: 25214
		// (get) Token: 0x0601D1C7 RID: 119239 RVA: 0x00437063 File Offset: 0x00435263
		// (set) Token: 0x0601D1C8 RID: 119240 RVA: 0x0043706B File Offset: 0x0043526B
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

		// Token: 0x1700627F RID: 25215
		// (get) Token: 0x0601D1C9 RID: 119241 RVA: 0x00437074 File Offset: 0x00435274
		// (set) Token: 0x0601D1CA RID: 119242 RVA: 0x0043707C File Offset: 0x0043527C
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

		// Token: 0x0601D1CB RID: 119243 RVA: 0x00437085 File Offset: 0x00435285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardContentInfo);
		}

		// Token: 0x0601D1CC RID: 119244 RVA: 0x00437094 File Offset: 0x00435294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardContentInfo other)
		{
			return other != null && (other == this || (this.WeekCardContentId == other.WeekCardContentId && this.UnlockDay == other.UnlockDay && this.RewardContent.Equals(other.RewardContent) && this.UnlockTimeStamp == other.UnlockTimeStamp && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D1CD RID: 119245 RVA: 0x00437114 File Offset: 0x00435314
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

		// Token: 0x0601D1CE RID: 119246 RVA: 0x004371AC File Offset: 0x004353AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D1CF RID: 119247 RVA: 0x004371B9 File Offset: 0x004353B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D1D0 RID: 119248 RVA: 0x004371C4 File Offset: 0x004353C4
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

		// Token: 0x0601D1D1 RID: 119249 RVA: 0x00437268 File Offset: 0x00435468
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

		// Token: 0x0601D1D2 RID: 119250 RVA: 0x00437304 File Offset: 0x00435504
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

		// Token: 0x0601D1D3 RID: 119251 RVA: 0x0043738D File Offset: 0x0043558D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D1D4 RID: 119252 RVA: 0x00437398 File Offset: 0x00435598
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

		// Token: 0x0400A71B RID: 42779
		private static readonly MessageParser<WeekCardContentInfo> _parser = new MessageParser<WeekCardContentInfo>(() => new WeekCardContentInfo());

		// Token: 0x0400A71C RID: 42780
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A71D RID: 42781
		public const int WeekCardContentIdFieldNumber = 1;

		// Token: 0x0400A71E RID: 42782
		private int weekCardContentId_;

		// Token: 0x0400A71F RID: 42783
		public const int UnlockDayFieldNumber = 2;

		// Token: 0x0400A720 RID: 42784
		private int unlockDay_;

		// Token: 0x0400A721 RID: 42785
		public const int RewardContentFieldNumber = 3;

		// Token: 0x0400A722 RID: 42786
		private static readonly MapField<int, int>.Codec _map_rewardContent_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x0400A723 RID: 42787
		private readonly MapField<int, int> rewardContent_ = new MapField<int, int>();

		// Token: 0x0400A724 RID: 42788
		public const int UnlockTimeStampFieldNumber = 4;

		// Token: 0x0400A725 RID: 42789
		private long unlockTimeStamp_;

		// Token: 0x0400A726 RID: 42790
		public const int StatusFieldNumber = 5;

		// Token: 0x0400A727 RID: 42791
		private int status_;
	}
}
