using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001505 RID: 5381
	public sealed class WeekCardInfo : IMessage<WeekCardInfo>, IMessage, IEquatable<WeekCardInfo>, IDeepCloneable<WeekCardInfo>, IBufferMessage
	{
		// Token: 0x0601C70F RID: 116495 RVA: 0x0041B9B1 File Offset: 0x00419BB1
		[NullableContext(1)]
		public static WeekCardInfo Create()
		{
			return new WeekCardInfo();
		}

		// Token: 0x17005FDF RID: 24543
		// (get) Token: 0x0601C710 RID: 116496 RVA: 0x0041B9B8 File Offset: 0x00419BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeekCardInfo> Parser
		{
			get
			{
				return WeekCardInfo._parser;
			}
		}

		// Token: 0x17005FE0 RID: 24544
		// (get) Token: 0x0601C711 RID: 116497 RVA: 0x0041B9BF File Offset: 0x00419BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FE1 RID: 24545
		// (get) Token: 0x0601C712 RID: 116498 RVA: 0x0041B9C2 File Offset: 0x00419BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardInfo.Descriptor;
			}
		}

		// Token: 0x0601C713 RID: 116499 RVA: 0x0041B9C9 File Offset: 0x00419BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfo()
		{
		}

		// Token: 0x0601C714 RID: 116500 RVA: 0x0041B9DC File Offset: 0x00419BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfo(WeekCardInfo other) : this()
		{
			this.weekCardId_ = other.weekCardId_;
			this.days_ = other.days_;
			this.buyTimeStamp_ = other.buyTimeStamp_;
			this.endTimeStamp_ = other.endTimeStamp_;
			this.weekCardContentInfos_ = other.weekCardContentInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C715 RID: 116501 RVA: 0x0041BA41 File Offset: 0x00419C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfo Clone()
		{
			return new WeekCardInfo(this);
		}

		// Token: 0x17005FE2 RID: 24546
		// (get) Token: 0x0601C716 RID: 116502 RVA: 0x0041BA49 File Offset: 0x00419C49
		// (set) Token: 0x0601C717 RID: 116503 RVA: 0x0041BA51 File Offset: 0x00419C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeekCardId
		{
			get
			{
				return this.weekCardId_;
			}
			set
			{
				this.weekCardId_ = value;
			}
		}

		// Token: 0x17005FE3 RID: 24547
		// (get) Token: 0x0601C718 RID: 116504 RVA: 0x0041BA5A File Offset: 0x00419C5A
		// (set) Token: 0x0601C719 RID: 116505 RVA: 0x0041BA62 File Offset: 0x00419C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Days
		{
			get
			{
				return this.days_;
			}
			set
			{
				this.days_ = value;
			}
		}

		// Token: 0x17005FE4 RID: 24548
		// (get) Token: 0x0601C71A RID: 116506 RVA: 0x0041BA6B File Offset: 0x00419C6B
		// (set) Token: 0x0601C71B RID: 116507 RVA: 0x0041BA73 File Offset: 0x00419C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuyTimeStamp
		{
			get
			{
				return this.buyTimeStamp_;
			}
			set
			{
				this.buyTimeStamp_ = value;
			}
		}

		// Token: 0x17005FE5 RID: 24549
		// (get) Token: 0x0601C71C RID: 116508 RVA: 0x0041BA7C File Offset: 0x00419C7C
		// (set) Token: 0x0601C71D RID: 116509 RVA: 0x0041BA84 File Offset: 0x00419C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTimeStamp
		{
			get
			{
				return this.endTimeStamp_;
			}
			set
			{
				this.endTimeStamp_ = value;
			}
		}

		// Token: 0x17005FE6 RID: 24550
		// (get) Token: 0x0601C71E RID: 116510 RVA: 0x0041BA8D File Offset: 0x00419C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeekCardContentInfo> WeekCardContentInfos
		{
			get
			{
				return this.weekCardContentInfos_;
			}
		}

		// Token: 0x0601C71F RID: 116511 RVA: 0x0041BA95 File Offset: 0x00419C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardInfo);
		}

		// Token: 0x0601C720 RID: 116512 RVA: 0x0041BAA4 File Offset: 0x00419CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardInfo other)
		{
			return other != null && (other == this || (this.WeekCardId == other.WeekCardId && this.Days == other.Days && this.BuyTimeStamp == other.BuyTimeStamp && this.EndTimeStamp == other.EndTimeStamp && this.weekCardContentInfos_.Equals(other.weekCardContentInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C721 RID: 116513 RVA: 0x0041BB24 File Offset: 0x00419D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeekCardId != 0)
			{
				num ^= this.WeekCardId.GetHashCode();
			}
			if (this.Days != 0)
			{
				num ^= this.Days.GetHashCode();
			}
			if (this.BuyTimeStamp != 0L)
			{
				num ^= this.BuyTimeStamp.GetHashCode();
			}
			if (this.EndTimeStamp != 0L)
			{
				num ^= this.EndTimeStamp.GetHashCode();
			}
			num ^= this.weekCardContentInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C722 RID: 116514 RVA: 0x0041BBBC File Offset: 0x00419DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C723 RID: 116515 RVA: 0x0041BBC9 File Offset: 0x00419DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C724 RID: 116516 RVA: 0x0041BBD4 File Offset: 0x00419DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeekCardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeekCardId);
			}
			if (this.Days != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Days);
			}
			if (this.BuyTimeStamp != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BuyTimeStamp);
			}
			if (this.EndTimeStamp != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EndTimeStamp);
			}
			this.weekCardContentInfos_.WriteTo(ref output, WeekCardInfo._repeated_weekCardContentInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C725 RID: 116517 RVA: 0x0041BC78 File Offset: 0x00419E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeekCardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeekCardId);
			}
			if (this.Days != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Days);
			}
			if (this.BuyTimeStamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuyTimeStamp);
			}
			if (this.EndTimeStamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTimeStamp);
			}
			num += this.weekCardContentInfos_.CalculateSize(WeekCardInfo._repeated_weekCardContentInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C726 RID: 116518 RVA: 0x0041BD14 File Offset: 0x00419F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeekCardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeekCardId != 0)
			{
				this.WeekCardId = other.WeekCardId;
			}
			if (other.Days != 0)
			{
				this.Days = other.Days;
			}
			if (other.BuyTimeStamp != 0L)
			{
				this.BuyTimeStamp = other.BuyTimeStamp;
			}
			if (other.EndTimeStamp != 0L)
			{
				this.EndTimeStamp = other.EndTimeStamp;
			}
			this.weekCardContentInfos_.Add(other.weekCardContentInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C727 RID: 116519 RVA: 0x0041BD9D File Offset: 0x00419F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C728 RID: 116520 RVA: 0x0041BDA8 File Offset: 0x00419FA8
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
						this.WeekCardId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Days = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BuyTimeStamp = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.EndTimeStamp = input.ReadInt64();
						continue;
					}
					if (num == 42U)
					{
						this.weekCardContentInfos_.AddEntriesFrom(ref input, WeekCardInfo._repeated_weekCardContentInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A2CF RID: 41679
		private static readonly MessageParser<WeekCardInfo> _parser = new MessageParser<WeekCardInfo>(() => new WeekCardInfo());

		// Token: 0x0400A2D0 RID: 41680
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2D1 RID: 41681
		public const int WeekCardIdFieldNumber = 1;

		// Token: 0x0400A2D2 RID: 41682
		private int weekCardId_;

		// Token: 0x0400A2D3 RID: 41683
		public const int DaysFieldNumber = 2;

		// Token: 0x0400A2D4 RID: 41684
		private int days_;

		// Token: 0x0400A2D5 RID: 41685
		public const int BuyTimeStampFieldNumber = 3;

		// Token: 0x0400A2D6 RID: 41686
		private long buyTimeStamp_;

		// Token: 0x0400A2D7 RID: 41687
		public const int EndTimeStampFieldNumber = 4;

		// Token: 0x0400A2D8 RID: 41688
		private long endTimeStamp_;

		// Token: 0x0400A2D9 RID: 41689
		public const int WeekCardContentInfosFieldNumber = 5;

		// Token: 0x0400A2DA RID: 41690
		private static readonly FieldCodec<WeekCardContentInfo> _repeated_weekCardContentInfos_codec = FieldCodec.ForMessage<WeekCardContentInfo>(42U, WeekCardContentInfo.Parser);

		// Token: 0x0400A2DB RID: 41691
		private readonly RepeatedField<WeekCardContentInfo> weekCardContentInfos_ = new RepeatedField<WeekCardContentInfo>();
	}
}
