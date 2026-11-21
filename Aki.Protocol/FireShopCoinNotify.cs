using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052B RID: 1323
	[NetMessage(EMessageId.FireShopCoinNotify)]
	public sealed class FireShopCoinNotify : IMessage<FireShopCoinNotify>, IMessage, IEquatable<FireShopCoinNotify>, IDeepCloneable<FireShopCoinNotify>, IBufferMessage
	{
		// Token: 0x06007C71 RID: 31857 RVA: 0x0012E189 File Offset: 0x0012C389
		[NullableContext(1)]
		public static FireShopCoinNotify Create()
		{
			return new FireShopCoinNotify();
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06007C72 RID: 31858 RVA: 0x0012E190 File Offset: 0x0012C390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06007C73 RID: 31859 RVA: 0x0012E193 File Offset: 0x0012C393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FireShopCoinNotify.Descriptor;
			}
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x0012E19A File Offset: 0x0012C39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FireShopCoinNotify()
		{
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x0012E1A2 File Offset: 0x0012C3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FireShopCoinNotify(FireShopCoinNotify other) : this()
		{
			this.moneyCount_ = other.moneyCount_;
			this.moneyHistorySpent_ = other.moneyHistorySpent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x0012E1D3 File Offset: 0x0012C3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FireShopCoinNotify Clone()
		{
			return new FireShopCoinNotify(this);
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x06007C77 RID: 31863 RVA: 0x0012E1DB File Offset: 0x0012C3DB
		// (set) Token: 0x06007C78 RID: 31864 RVA: 0x0012E1E3 File Offset: 0x0012C3E3
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

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x06007C79 RID: 31865 RVA: 0x0012E1EC File Offset: 0x0012C3EC
		// (set) Token: 0x06007C7A RID: 31866 RVA: 0x0012E1F4 File Offset: 0x0012C3F4
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

		// Token: 0x06007C7B RID: 31867 RVA: 0x0012E1FD File Offset: 0x0012C3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FireShopCoinNotify);
		}

		// Token: 0x06007C7C RID: 31868 RVA: 0x0012E20B File Offset: 0x0012C40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FireShopCoinNotify other)
		{
			return other != null && (other == this || (this.MoneyCount == other.MoneyCount && this.MoneyHistorySpent == other.MoneyHistorySpent && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C7D RID: 31869 RVA: 0x0012E24C File Offset: 0x0012C44C
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

		// Token: 0x06007C7E RID: 31870 RVA: 0x0012E2A4 File Offset: 0x0012C4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C7F RID: 31871 RVA: 0x0012E2B1 File Offset: 0x0012C4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C80 RID: 31872 RVA: 0x0012E2BC File Offset: 0x0012C4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoneyCount != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.MoneyCount);
			}
			if (this.MoneyHistorySpent != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.MoneyHistorySpent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x0012E318 File Offset: 0x0012C518
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

		// Token: 0x06007C82 RID: 31874 RVA: 0x0012E370 File Offset: 0x0012C570
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

		// Token: 0x06007C83 RID: 31875 RVA: 0x0012E3C0 File Offset: 0x0012C5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x0012E3CC File Offset: 0x0012C5CC
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
				if (num != 64U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MoneyHistorySpent = input.ReadInt64();
					}
				}
				else
				{
					this.MoneyCount = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003FE7 RID: 16359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FE8 RID: 16360
		public const int MoneyCountFieldNumber = 8;

		// Token: 0x04003FE9 RID: 16361
		private long moneyCount_;

		// Token: 0x04003FEA RID: 16362
		public const int MoneyHistorySpentFieldNumber = 10;

		// Token: 0x04003FEB RID: 16363
		private long moneyHistorySpent_;
	}
}
