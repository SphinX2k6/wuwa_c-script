using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000149 RID: 329
	[NetMessage(EMessageId.BabelActivitySettleInfoNotify)]
	public sealed class BabelActivitySettleInfoNotify : IMessage<BabelActivitySettleInfoNotify>, IMessage, IEquatable<BabelActivitySettleInfoNotify>, IDeepCloneable<BabelActivitySettleInfoNotify>, IBufferMessage
	{
		// Token: 0x06002A7E RID: 10878 RVA: 0x0006FA41 File Offset: 0x0006DC41
		[NullableContext(1)]
		public static BabelActivitySettleInfoNotify Create()
		{
			return new BabelActivitySettleInfoNotify();
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x0006FA48 File Offset: 0x0006DC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06002A80 RID: 10880 RVA: 0x0006FA4B File Offset: 0x0006DC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivitySettleInfoNotify.Descriptor;
			}
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x0006FA52 File Offset: 0x0006DC52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivitySettleInfoNotify()
		{
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x0006FA70 File Offset: 0x0006DC70
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

		// Token: 0x06002A83 RID: 10883 RVA: 0x0006FAF2 File Offset: 0x0006DCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivitySettleInfoNotify Clone()
		{
			return new BabelActivitySettleInfoNotify(this);
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x0006FAFA File Offset: 0x0006DCFA
		// (set) Token: 0x06002A85 RID: 10885 RVA: 0x0006FB02 File Offset: 0x0006DD02
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

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x0006FB0B File Offset: 0x0006DD0B
		// (set) Token: 0x06002A87 RID: 10887 RVA: 0x0006FB13 File Offset: 0x0006DD13
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

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002A88 RID: 10888 RVA: 0x0006FB1C File Offset: 0x0006DD1C
		// (set) Token: 0x06002A89 RID: 10889 RVA: 0x0006FB24 File Offset: 0x0006DD24
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

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x0006FB2D File Offset: 0x0006DD2D
		// (set) Token: 0x06002A8B RID: 10891 RVA: 0x0006FB35 File Offset: 0x0006DD35
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

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x0006FB3E File Offset: 0x0006DD3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NewBabelBuffIds
		{
			get
			{
				return this.newBabelBuffIds_;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x0006FB46 File Offset: 0x0006DD46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NewBabelDeTermId
		{
			get
			{
				return this.newBabelDeTermId_;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002A8E RID: 10894 RVA: 0x0006FB4E File Offset: 0x0006DD4E
		// (set) Token: 0x06002A8F RID: 10895 RVA: 0x0006FB56 File Offset: 0x0006DD56
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

		// Token: 0x06002A90 RID: 10896 RVA: 0x0006FB5F File Offset: 0x0006DD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivitySettleInfoNotify);
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x0006FB70 File Offset: 0x0006DD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivitySettleInfoNotify other)
		{
			return other != null && (other == this || (this.Star == other.Star && this.IsPass == other.IsPass && this.IsActivityClose == other.IsActivityClose && this.PassTime == other.PassTime && this.newBabelBuffIds_.Equals(other.newBabelBuffIds_) && this.newBabelDeTermId_.Equals(other.newBabelDeTermId_) && this.UseTime == other.UseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x0006FC14 File Offset: 0x0006DE14
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

		// Token: 0x06002A93 RID: 10899 RVA: 0x0006FCD3 File Offset: 0x0006DED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x0006FCE0 File Offset: 0x0006DEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x0006FCEC File Offset: 0x0006DEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Star != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Star);
			}
			this.newBabelBuffIds_.WriteTo(ref output, BabelActivitySettleInfoNotify._repeated_newBabelBuffIds_codec);
			if (this.UseTime != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.UseTime);
			}
			this.newBabelDeTermId_.WriteTo(ref output, BabelActivitySettleInfoNotify._repeated_newBabelDeTermId_codec);
			if (this.IsActivityClose)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsActivityClose);
			}
			if (this.PassTime != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.PassTime);
			}
			if (this.IsPass)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsPass);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x0006FDBC File Offset: 0x0006DFBC
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

		// Token: 0x06002A97 RID: 10903 RVA: 0x0006FE68 File Offset: 0x0006E068
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

		// Token: 0x06002A98 RID: 10904 RVA: 0x0006FF16 File Offset: 0x0006E116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x0006FF20 File Offset: 0x0006E120
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
				if (num <= 56U)
				{
					if (num <= 32U)
					{
						if (num == 24U)
						{
							this.Star = input.ReadInt32();
							continue;
						}
						if (num != 32U)
						{
							goto IL_4E;
						}
					}
					else if (num != 34U)
					{
						if (num != 56U)
						{
							goto IL_4E;
						}
						this.UseTime = input.ReadInt32();
						continue;
					}
					this.newBabelBuffIds_.AddEntriesFrom(ref input, BabelActivitySettleInfoNotify._repeated_newBabelBuffIds_codec);
					continue;
				}
				if (num <= 82U)
				{
					if (num == 80U || num == 82U)
					{
						this.newBabelDeTermId_.AddEntriesFrom(ref input, BabelActivitySettleInfoNotify._repeated_newBabelDeTermId_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.IsActivityClose = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.PassTime = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.IsPass = input.ReadBool();
						continue;
					}
				}
				IL_4E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040027B5 RID: 10165
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027B6 RID: 10166
		public const int StarFieldNumber = 3;

		// Token: 0x040027B7 RID: 10167
		private int star_;

		// Token: 0x040027B8 RID: 10168
		public const int IsPassFieldNumber = 14;

		// Token: 0x040027B9 RID: 10169
		private bool isPass_;

		// Token: 0x040027BA RID: 10170
		public const int IsActivityCloseFieldNumber = 12;

		// Token: 0x040027BB RID: 10171
		private bool isActivityClose_;

		// Token: 0x040027BC RID: 10172
		public const int PassTimeFieldNumber = 13;

		// Token: 0x040027BD RID: 10173
		private long passTime_;

		// Token: 0x040027BE RID: 10174
		public const int NewBabelBuffIdsFieldNumber = 4;

		// Token: 0x040027BF RID: 10175
		private static readonly FieldCodec<int> _repeated_newBabelBuffIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040027C0 RID: 10176
		private readonly RepeatedField<int> newBabelBuffIds_ = new RepeatedField<int>();

		// Token: 0x040027C1 RID: 10177
		public const int NewBabelDeTermIdFieldNumber = 10;

		// Token: 0x040027C2 RID: 10178
		private static readonly FieldCodec<int> _repeated_newBabelDeTermId_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040027C3 RID: 10179
		private readonly RepeatedField<int> newBabelDeTermId_ = new RepeatedField<int>();

		// Token: 0x040027C4 RID: 10180
		public const int UseTimeFieldNumber = 7;

		// Token: 0x040027C5 RID: 10181
		private int useTime_;
	}
}
