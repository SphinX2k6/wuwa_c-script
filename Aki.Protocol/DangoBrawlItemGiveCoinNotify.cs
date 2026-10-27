using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000360 RID: 864
	[NetMessage(EMessageId.DangoBrawlItemGiveCoinNotify)]
	public sealed class DangoBrawlItemGiveCoinNotify : IMessage<DangoBrawlItemGiveCoinNotify>, IMessage, IEquatable<DangoBrawlItemGiveCoinNotify>, IDeepCloneable<DangoBrawlItemGiveCoinNotify>, IBufferMessage
	{
		// Token: 0x06005638 RID: 22072 RVA: 0x000D2BB7 File Offset: 0x000D0DB7
		[NullableContext(1)]
		public static DangoBrawlItemGiveCoinNotify Create()
		{
			return new DangoBrawlItemGiveCoinNotify();
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06005639 RID: 22073 RVA: 0x000D2BBE File Offset: 0x000D0DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x0600563A RID: 22074 RVA: 0x000D2BC1 File Offset: 0x000D0DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlItemGiveCoinNotify.Descriptor;
			}
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x000D2BC8 File Offset: 0x000D0DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinNotify()
		{
		}

		// Token: 0x0600563C RID: 22076 RVA: 0x000D2BDB File Offset: 0x000D0DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinNotify(DangoBrawlItemGiveCoinNotify other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.coin_ = other.coin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x000D2C11 File Offset: 0x000D0E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemGiveCoinNotify Clone()
		{
			return new DangoBrawlItemGiveCoinNotify(this);
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x0600563E RID: 22078 RVA: 0x000D2C19 File Offset: 0x000D0E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlItemGiveCoinInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x0600563F RID: 22079 RVA: 0x000D2C21 File Offset: 0x000D0E21
		// (set) Token: 0x06005640 RID: 22080 RVA: 0x000D2C29 File Offset: 0x000D0E29
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

		// Token: 0x06005641 RID: 22081 RVA: 0x000D2C32 File Offset: 0x000D0E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlItemGiveCoinNotify);
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x000D2C40 File Offset: 0x000D0E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlItemGiveCoinNotify other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.Coin == other.Coin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x000D2C90 File Offset: 0x000D0E90
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

		// Token: 0x06005644 RID: 22084 RVA: 0x000D2CDD File Offset: 0x000D0EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x000D2CEA File Offset: 0x000D0EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x000D2CF4 File Offset: 0x000D0EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, DangoBrawlItemGiveCoinNotify._repeated_infos_codec);
			if (this.Coin != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Coin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x000D2D44 File Offset: 0x000D0F44
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

		// Token: 0x06005648 RID: 22088 RVA: 0x000D2D98 File Offset: 0x000D0F98
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

		// Token: 0x06005649 RID: 22089 RVA: 0x000D2DE5 File Offset: 0x000D0FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x000D2DF0 File Offset: 0x000D0FF0
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
				if (num != 42U)
				{
					if (num != 72U)
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

		// Token: 0x0400346D RID: 13421
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400346E RID: 13422
		public const int InfosFieldNumber = 5;

		// Token: 0x0400346F RID: 13423
		private static readonly FieldCodec<DangoBrawlItemGiveCoinInfo> _repeated_infos_codec = FieldCodec.ForMessage<DangoBrawlItemGiveCoinInfo>(42U, DangoBrawlItemGiveCoinInfo.Parser);

		// Token: 0x04003470 RID: 13424
		private readonly RepeatedField<DangoBrawlItemGiveCoinInfo> infos_ = new RepeatedField<DangoBrawlItemGiveCoinInfo>();

		// Token: 0x04003471 RID: 13425
		public const int CoinFieldNumber = 9;

		// Token: 0x04003472 RID: 13426
		private int coin_;
	}
}
