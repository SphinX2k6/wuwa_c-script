using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000368 RID: 872
	[NetMessage(EMessageId.DangoBrawlItemGiveCoinNotify)]
	public sealed class DangoBrawlItemGiveCoinNotify : IMessage<DangoBrawlItemGiveCoinNotify>, IMessage, IEquatable<DangoBrawlItemGiveCoinNotify>, IDeepCloneable<DangoBrawlItemGiveCoinNotify>, IBufferMessage
	{
		// Token: 0x06005725 RID: 22309 RVA: 0x000D523F File Offset: 0x000D343F
		[NullableContext(1)]
		public static DangoBrawlItemGiveCoinNotify Create()
		{
			return new DangoBrawlItemGiveCoinNotify();
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06005726 RID: 22310 RVA: 0x000D5246 File Offset: 0x000D3446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06005727 RID: 22311 RVA: 0x000D5249 File Offset: 0x000D3449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlItemGiveCoinNotify.Descriptor;
			}
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x000D5250 File Offset: 0x000D3450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinNotify()
		{
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x000D5263 File Offset: 0x000D3463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinNotify(DangoBrawlItemGiveCoinNotify other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.coin_ = other.coin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x000D5299 File Offset: 0x000D3499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinNotify Clone()
		{
			return new DangoBrawlItemGiveCoinNotify(this);
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x0600572B RID: 22315 RVA: 0x000D52A1 File Offset: 0x000D34A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlItemGiveCoinInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x0600572C RID: 22316 RVA: 0x000D52A9 File Offset: 0x000D34A9
		// (set) Token: 0x0600572D RID: 22317 RVA: 0x000D52B1 File Offset: 0x000D34B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Coin
		{
			get
			{
				return this.coin_;
			}
			set
			{
				this.coin_ = value;
			}
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x000D52BA File Offset: 0x000D34BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlItemGiveCoinNotify);
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x000D52C8 File Offset: 0x000D34C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlItemGiveCoinNotify other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.Coin == other.Coin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005730 RID: 22320 RVA: 0x000D5318 File Offset: 0x000D3518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
			if (this.Coin != 0)
			{
				num ^= this.Coin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x000D5365 File Offset: 0x000D3565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x000D5372 File Offset: 0x000D3572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x000D537C File Offset: 0x000D357C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, DangoBrawlItemGiveCoinNotify._repeated_infos_codec);
			if (this.Coin != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Coin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x000D53CC File Offset: 0x000D35CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(DangoBrawlItemGiveCoinNotify._repeated_infos_codec);
			if (this.Coin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Coin);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x000D5420 File Offset: 0x000D3620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlItemGiveCoinNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			if (other.Coin != 0)
			{
				this.Coin = other.Coin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x000D546D File Offset: 0x000D366D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x000D5478 File Offset: 0x000D3678
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
				if (num != 18U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Coin = input.ReadInt32();
					}
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, DangoBrawlItemGiveCoinNotify._repeated_infos_codec);
				}
			}
		}

		// Token: 0x04003509 RID: 13577
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400350A RID: 13578
		public const int InfosFieldNumber = 2;

		// Token: 0x0400350B RID: 13579
		private static readonly FieldCodec<DangoBrawlItemGiveCoinInfo> _repeated_infos_codec = FieldCodec.ForMessage<DangoBrawlItemGiveCoinInfo>(18U, DangoBrawlItemGiveCoinInfo.Parser);

		// Token: 0x0400350C RID: 13580
		private readonly RepeatedField<DangoBrawlItemGiveCoinInfo> infos_ = new RepeatedField<DangoBrawlItemGiveCoinInfo>();

		// Token: 0x0400350D RID: 13581
		public const int CoinFieldNumber = 14;

		// Token: 0x0400350E RID: 13582
		private int coin_;
	}
}
