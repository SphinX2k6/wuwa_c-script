using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000146 RID: 326
	[NetMessage(EMessageId.BabelActivitySettleInfoNotify)]
	public sealed class BabelActivitySettleInfoNotify : IMessage<BabelActivitySettleInfoNotify>, IMessage, IEquatable<BabelActivitySettleInfoNotify>, IDeepCloneable<BabelActivitySettleInfoNotify>, IBufferMessage
	{
		// Token: 0x06002A07 RID: 10759 RVA: 0x0006E60D File Offset: 0x0006C80D
		[NullableContext(1)]
		public static BabelActivitySettleInfoNotify Create()
		{
			return new BabelActivitySettleInfoNotify();
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x0006E614 File Offset: 0x0006C814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x0006E617 File Offset: 0x0006C817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivitySettleInfoNotify.Descriptor;
			}
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x0006E61E File Offset: 0x0006C81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivitySettleInfoNotify()
		{
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x0006E63C File Offset: 0x0006C83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivitySettleInfoNotify(BabelActivitySettleInfoNotify other) : this()
		{
			this.star_ = other.star_;
			this.isPass_ = other.isPass_;
			this.isActivityClose_ = other.isActivityClose_;
			this.passTime_ = other.passTime_;
			this.newBabelBuffIds_ = other.newBabelBuffIds_.Clone();
			this.newBabelDeTermId_ = other.newBabelDeTermId_.Clone();
			this.useTime_ = other.useTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x0006E6BE File Offset: 0x0006C8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivitySettleInfoNotify Clone()
		{
			return new BabelActivitySettleInfoNotify(this);
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x0006E6C6 File Offset: 0x0006C8C6
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x0006E6CE File Offset: 0x0006C8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Star
		{
			get
			{
				return this.star_;
			}
			set
			{
				this.star_ = value;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x0006E6D7 File Offset: 0x0006C8D7
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x0006E6DF File Offset: 0x0006C8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPass
		{
			get
			{
				return this.isPass_;
			}
			set
			{
				this.isPass_ = value;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x0006E6E8 File Offset: 0x0006C8E8
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x0006E6F0 File Offset: 0x0006C8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsActivityClose
		{
			get
			{
				return this.isActivityClose_;
			}
			set
			{
				this.isActivityClose_ = value;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x0006E6F9 File Offset: 0x0006C8F9
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x0006E701 File Offset: 0x0006C901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PassTime
		{
			get
			{
				return this.passTime_;
			}
			set
			{
				this.passTime_ = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x0006E70A File Offset: 0x0006C90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NewBabelBuffIds
		{
			get
			{
				return this.newBabelBuffIds_;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002A16 RID: 10774 RVA: 0x0006E712 File Offset: 0x0006C912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NewBabelDeTermId
		{
			get
			{
				return this.newBabelDeTermId_;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x0006E71A File Offset: 0x0006C91A
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x0006E722 File Offset: 0x0006C922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseTime
		{
			get
			{
				return this.useTime_;
			}
			set
			{
				this.useTime_ = value;
			}
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x0006E72B File Offset: 0x0006C92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivitySettleInfoNotify);
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x0006E73C File Offset: 0x0006C93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivitySettleInfoNotify other)
		{
			return other != null && (other == this || (this.Star == other.Star && this.IsPass == other.IsPass && this.IsActivityClose == other.IsActivityClose && this.PassTime == other.PassTime && this.newBabelBuffIds_.Equals(other.newBabelBuffIds_) && this.newBabelDeTermId_.Equals(other.newBabelDeTermId_) && this.UseTime == other.UseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x0006E7E0 File Offset: 0x0006C9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Star != 0)
			{
				num ^= this.Star.GetHashCode();
			}
			if (this.IsPass)
			{
				num ^= this.IsPass.GetHashCode();
			}
			if (this.IsActivityClose)
			{
				num ^= this.IsActivityClose.GetHashCode();
			}
			if (this.PassTime != 0L)
			{
				num ^= this.PassTime.GetHashCode();
			}
			num ^= this.newBabelBuffIds_.GetHashCode();
			num ^= this.newBabelDeTermId_.GetHashCode();
			if (this.UseTime != 0)
			{
				num ^= this.UseTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x0006E89F File Offset: 0x0006CA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x0006E8AC File Offset: 0x0006CAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x0006E8B8 File Offset: 0x0006CAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UseTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UseTime);
			}
			if (this.Star != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Star);
			}
			if (this.PassTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.PassTime);
			}
			this.newBabelDeTermId_.WriteTo(ref output, BabelActivitySettleInfoNotify._repeated_newBabelDeTermId_codec);
			if (this.IsActivityClose)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsActivityClose);
			}
			this.newBabelBuffIds_.WriteTo(ref output, BabelActivitySettleInfoNotify._repeated_newBabelBuffIds_codec);
			if (this.IsPass)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsPass);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x0006E988 File Offset: 0x0006CB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Star != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Star);
			}
			if (this.IsPass)
			{
				num += 2;
			}
			if (this.IsActivityClose)
			{
				num += 2;
			}
			if (this.PassTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PassTime);
			}
			num += this.newBabelBuffIds_.CalculateSize(BabelActivitySettleInfoNotify._repeated_newBabelBuffIds_codec);
			num += this.newBabelDeTermId_.CalculateSize(BabelActivitySettleInfoNotify._repeated_newBabelDeTermId_codec);
			if (this.UseTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x0006EA34 File Offset: 0x0006CC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivitySettleInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Star != 0)
			{
				this.Star = other.Star;
			}
			if (other.IsPass)
			{
				this.IsPass = other.IsPass;
			}
			if (other.IsActivityClose)
			{
				this.IsActivityClose = other.IsActivityClose;
			}
			if (other.PassTime != 0L)
			{
				this.PassTime = other.PassTime;
			}
			this.newBabelBuffIds_.Add(other.newBabelBuffIds_);
			this.newBabelDeTermId_.Add(other.newBabelDeTermId_);
			if (other.UseTime != 0)
			{
				this.UseTime = other.UseTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x0006EAE2 File Offset: 0x0006CCE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x0006EAEC File Offset: 0x0006CCEC
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
				if (num <= 88U)
				{
					if (num <= 48U)
					{
						if (num == 16U)
						{
							this.UseTime = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.Star = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 72U)
						{
							this.PassTime = input.ReadInt64();
							continue;
						}
						if (num == 88U)
						{
							goto IL_8C;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 90U)
					{
						goto IL_8C;
					}
					if (num == 104U)
					{
						this.IsActivityClose = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 112U || num == 114U)
					{
						this.newBabelBuffIds_.AddEntriesFrom(ref input, BabelActivitySettleInfoNotify._repeated_newBabelBuffIds_codec);
						continue;
					}
					if (num == 120U)
					{
						this.IsPass = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_8C:
				this.newBabelDeTermId_.AddEntriesFrom(ref input, BabelActivitySettleInfoNotify._repeated_newBabelDeTermId_codec);
			}
		}

		// Token: 0x04002741 RID: 10049
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002742 RID: 10050
		public const int StarFieldNumber = 6;

		// Token: 0x04002743 RID: 10051
		private int star_;

		// Token: 0x04002744 RID: 10052
		public const int IsPassFieldNumber = 15;

		// Token: 0x04002745 RID: 10053
		private bool isPass_;

		// Token: 0x04002746 RID: 10054
		public const int IsActivityCloseFieldNumber = 13;

		// Token: 0x04002747 RID: 10055
		private bool isActivityClose_;

		// Token: 0x04002748 RID: 10056
		public const int PassTimeFieldNumber = 9;

		// Token: 0x04002749 RID: 10057
		private long passTime_;

		// Token: 0x0400274A RID: 10058
		public const int NewBabelBuffIdsFieldNumber = 14;

		// Token: 0x0400274B RID: 10059
		private static readonly FieldCodec<int> _repeated_newBabelBuffIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400274C RID: 10060
		private readonly RepeatedField<int> newBabelBuffIds_ = new RepeatedField<int>();

		// Token: 0x0400274D RID: 10061
		public const int NewBabelDeTermIdFieldNumber = 11;

		// Token: 0x0400274E RID: 10062
		private static readonly FieldCodec<int> _repeated_newBabelDeTermId_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400274F RID: 10063
		private readonly RepeatedField<int> newBabelDeTermId_ = new RepeatedField<int>();

		// Token: 0x04002750 RID: 10064
		public const int UseTimeFieldNumber = 2;

		// Token: 0x04002751 RID: 10065
		private int useTime_;
	}
}
