using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000345 RID: 837
	[NetMessage(EMessageId.DangoBrawlCoinUpdateNotify)]
	public sealed class DangoBrawlCoinUpdateNotify : IMessage<DangoBrawlCoinUpdateNotify>, IMessage, IEquatable<DangoBrawlCoinUpdateNotify>, IDeepCloneable<DangoBrawlCoinUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600540C RID: 21516 RVA: 0x000CD2C1 File Offset: 0x000CB4C1
		[NullableContext(1)]
		public static DangoBrawlCoinUpdateNotify Create()
		{
			return new DangoBrawlCoinUpdateNotify();
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x0600540D RID: 21517 RVA: 0x000CD2C8 File Offset: 0x000CB4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x0600540E RID: 21518 RVA: 0x000CD2CB File Offset: 0x000CB4CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlCoinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600540F RID: 21519 RVA: 0x000CD2D2 File Offset: 0x000CB4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlCoinUpdateNotify()
		{
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x000CD2DA File Offset: 0x000CB4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlCoinUpdateNotify(DangoBrawlCoinUpdateNotify other) : this()
		{
			this.coin_ = other.coin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x000CD2FF File Offset: 0x000CB4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlCoinUpdateNotify Clone()
		{
			return new DangoBrawlCoinUpdateNotify(this);
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06005412 RID: 21522 RVA: 0x000CD307 File Offset: 0x000CB507
		// (set) Token: 0x06005413 RID: 21523 RVA: 0x000CD30F File Offset: 0x000CB50F
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

		// Token: 0x06005414 RID: 21524 RVA: 0x000CD318 File Offset: 0x000CB518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlCoinUpdateNotify);
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x000CD326 File Offset: 0x000CB526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlCoinUpdateNotify other)
		{
			return other != null && (other == this || (this.Coin == other.Coin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x000CD354 File Offset: 0x000CB554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06005417 RID: 21527 RVA: 0x000CD393 File Offset: 0x000CB593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x000CD3A0 File Offset: 0x000CB5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x000CD3A9 File Offset: 0x000CB5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Coin != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Coin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x000CD3DC File Offset: 0x000CB5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600541B RID: 21531 RVA: 0x000CD41A File Offset: 0x000CB61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlCoinUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Coin != 0)
			{
				this.Coin = other.Coin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x000CD44B File Offset: 0x000CB64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x000CD454 File Offset: 0x000CB654
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Coin = input.ReadInt32();
				}
			}
		}

		// Token: 0x040033FF RID: 13311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003400 RID: 13312
		public const int CoinFieldNumber = 10;

		// Token: 0x04003401 RID: 13313
		private int coin_;
	}
}
