using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000540 RID: 1344
	[NetMessage(EMessageId.FireShopCoinNotify)]
	public sealed class FireShopCoinNotify : IMessage<FireShopCoinNotify>, IMessage, IEquatable<FireShopCoinNotify>, IDeepCloneable<FireShopCoinNotify>, IBufferMessage
	{
		// Token: 0x06007DD9 RID: 32217 RVA: 0x00130D8D File Offset: 0x0012EF8D
		[NullableContext(1)]
		public static FireShopCoinNotify Create()
		{
			return new FireShopCoinNotify();
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x06007DDA RID: 32218 RVA: 0x00130D94 File Offset: 0x0012EF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06007DDB RID: 32219 RVA: 0x00130D97 File Offset: 0x0012EF97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FireShopCoinNotify.Descriptor;
			}
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x00130D9E File Offset: 0x0012EF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FireShopCoinNotify()
		{
		}

		// Token: 0x06007DDD RID: 32221 RVA: 0x00130DA6 File Offset: 0x0012EFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FireShopCoinNotify(FireShopCoinNotify other) : this()
		{
			this.moneyCount_ = other.moneyCount_;
			this.moneyHistorySpent_ = other.moneyHistorySpent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DDE RID: 32222 RVA: 0x00130DD7 File Offset: 0x0012EFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FireShopCoinNotify Clone()
		{
			return new FireShopCoinNotify(this);
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06007DDF RID: 32223 RVA: 0x00130DDF File Offset: 0x0012EFDF
		// (set) Token: 0x06007DE0 RID: 32224 RVA: 0x00130DE7 File Offset: 0x0012EFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MoneyCount
		{
			get
			{
				return this.moneyCount_;
			}
			set
			{
				this.moneyCount_ = value;
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x06007DE1 RID: 32225 RVA: 0x00130DF0 File Offset: 0x0012EFF0
		// (set) Token: 0x06007DE2 RID: 32226 RVA: 0x00130DF8 File Offset: 0x0012EFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MoneyHistorySpent
		{
			get
			{
				return this.moneyHistorySpent_;
			}
			set
			{
				this.moneyHistorySpent_ = value;
			}
		}

		// Token: 0x06007DE3 RID: 32227 RVA: 0x00130E01 File Offset: 0x0012F001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FireShopCoinNotify);
		}

		// Token: 0x06007DE4 RID: 32228 RVA: 0x00130E0F File Offset: 0x0012F00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FireShopCoinNotify other)
		{
			return other != null && (other == this || (this.MoneyCount == other.MoneyCount && this.MoneyHistorySpent == other.MoneyHistorySpent && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x00130E50 File Offset: 0x0012F050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MoneyCount != 0L)
			{
				num ^= this.MoneyCount.GetHashCode();
			}
			if (this.MoneyHistorySpent != 0L)
			{
				num ^= this.MoneyHistorySpent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007DE6 RID: 32230 RVA: 0x00130EA8 File Offset: 0x0012F0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007DE7 RID: 32231 RVA: 0x00130EB5 File Offset: 0x0012F0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DE8 RID: 32232 RVA: 0x00130EC0 File Offset: 0x0012F0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoneyHistorySpent != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.MoneyHistorySpent);
			}
			if (this.MoneyCount != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.MoneyCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DE9 RID: 32233 RVA: 0x00130F1C File Offset: 0x0012F11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MoneyCount != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MoneyCount);
			}
			if (this.MoneyHistorySpent != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MoneyHistorySpent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007DEA RID: 32234 RVA: 0x00130F74 File Offset: 0x0012F174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FireShopCoinNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MoneyCount != 0L)
			{
				this.MoneyCount = other.MoneyCount;
			}
			if (other.MoneyHistorySpent != 0L)
			{
				this.MoneyHistorySpent = other.MoneyHistorySpent;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007DEB RID: 32235 RVA: 0x00130FC4 File Offset: 0x0012F1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DEC RID: 32236 RVA: 0x00130FD0 File Offset: 0x0012F1D0
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MoneyCount = input.ReadInt64();
					}
				}
				else
				{
					this.MoneyHistorySpent = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003FF1 RID: 16369
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FF2 RID: 16370
		public const int MoneyCountFieldNumber = 12;

		// Token: 0x04003FF3 RID: 16371
		private long moneyCount_;

		// Token: 0x04003FF4 RID: 16372
		public const int MoneyHistorySpentFieldNumber = 10;

		// Token: 0x04003FF5 RID: 16373
		private long moneyHistorySpent_;
	}
}
