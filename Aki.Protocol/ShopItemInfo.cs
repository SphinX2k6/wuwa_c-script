using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001232 RID: 4658
	public sealed class ShopItemInfo : IMessage<ShopItemInfo>, IMessage, IEquatable<ShopItemInfo>, IDeepCloneable<ShopItemInfo>, IBufferMessage
	{
		// Token: 0x06018E01 RID: 101889 RVA: 0x003A0368 File Offset: 0x0039E568
		[NullableContext(1)]
		public static ShopItemInfo Create()
		{
			return new ShopItemInfo();
		}

		// Token: 0x17005406 RID: 21510
		// (get) Token: 0x06018E02 RID: 101890 RVA: 0x003A036F File Offset: 0x0039E56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005407 RID: 21511
		// (get) Token: 0x06018E03 RID: 101891 RVA: 0x003A0372 File Offset: 0x0039E572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopItemInfo.Descriptor;
			}
		}

		// Token: 0x06018E04 RID: 101892 RVA: 0x003A0379 File Offset: 0x0039E579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopItemInfo()
		{
		}

		// Token: 0x06018E05 RID: 101893 RVA: 0x003A0381 File Offset: 0x0039E581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopItemInfo(ShopItemInfo other) : this()
		{
			this.id_ = other.id_;
			this.boughtCount_ = other.boughtCount_;
			this.lock_ = other.lock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E06 RID: 101894 RVA: 0x003A03BE File Offset: 0x0039E5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopItemInfo Clone()
		{
			return new ShopItemInfo(this);
		}

		// Token: 0x17005408 RID: 21512
		// (get) Token: 0x06018E07 RID: 101895 RVA: 0x003A03C6 File Offset: 0x0039E5C6
		// (set) Token: 0x06018E08 RID: 101896 RVA: 0x003A03CE File Offset: 0x0039E5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005409 RID: 21513
		// (get) Token: 0x06018E09 RID: 101897 RVA: 0x003A03D7 File Offset: 0x0039E5D7
		// (set) Token: 0x06018E0A RID: 101898 RVA: 0x003A03DF File Offset: 0x0039E5DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoughtCount
		{
			get
			{
				return this.boughtCount_;
			}
			set
			{
				this.boughtCount_ = value;
			}
		}

		// Token: 0x1700540A RID: 21514
		// (get) Token: 0x06018E0B RID: 101899 RVA: 0x003A03E8 File Offset: 0x0039E5E8
		// (set) Token: 0x06018E0C RID: 101900 RVA: 0x003A03F0 File Offset: 0x0039E5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Lock
		{
			get
			{
				return this.lock_;
			}
			set
			{
				this.lock_ = value;
			}
		}

		// Token: 0x06018E0D RID: 101901 RVA: 0x003A03F9 File Offset: 0x0039E5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopItemInfo);
		}

		// Token: 0x06018E0E RID: 101902 RVA: 0x003A0408 File Offset: 0x0039E608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopItemInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BoughtCount == other.BoughtCount && this.Lock == other.Lock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E0F RID: 101903 RVA: 0x003A0464 File Offset: 0x0039E664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BoughtCount != 0)
			{
				num ^= this.BoughtCount.GetHashCode();
			}
			if (this.Lock != 0)
			{
				num ^= this.Lock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018E10 RID: 101904 RVA: 0x003A04D5 File Offset: 0x0039E6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E11 RID: 101905 RVA: 0x003A04E2 File Offset: 0x0039E6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E12 RID: 101906 RVA: 0x003A04EC File Offset: 0x0039E6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.BoughtCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BoughtCount);
			}
			if (this.Lock != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Lock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E13 RID: 101907 RVA: 0x003A0560 File Offset: 0x0039E760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.BoughtCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoughtCount);
			}
			if (this.Lock != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Lock);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018E14 RID: 101908 RVA: 0x003A05D0 File Offset: 0x0039E7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BoughtCount != 0)
			{
				this.BoughtCount = other.BoughtCount;
			}
			if (other.Lock != 0)
			{
				this.Lock = other.Lock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018E15 RID: 101909 RVA: 0x003A0634 File Offset: 0x0039E834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E16 RID: 101910 RVA: 0x003A0640 File Offset: 0x0039E840
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Lock = input.ReadInt32();
						}
					}
					else
					{
						this.BoughtCount = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400938B RID: 37771
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400938C RID: 37772
		public const int IdFieldNumber = 1;

		// Token: 0x0400938D RID: 37773
		private int id_;

		// Token: 0x0400938E RID: 37774
		public const int BoughtCountFieldNumber = 2;

		// Token: 0x0400938F RID: 37775
		private int boughtCount_;

		// Token: 0x04009390 RID: 37776
		public const int LockFieldNumber = 3;

		// Token: 0x04009391 RID: 37777
		private int lock_;
	}
}
