using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F6 RID: 4598
	public sealed class ShopItemInfo : IMessage<ShopItemInfo>, IMessage, IEquatable<ShopItemInfo>, IDeepCloneable<ShopItemInfo>, IBufferMessage
	{
		// Token: 0x06018827 RID: 100391 RVA: 0x003904C4 File Offset: 0x0038E6C4
		[NullableContext(1)]
		public static ShopItemInfo Create()
		{
			return new ShopItemInfo();
		}

		// Token: 0x17005289 RID: 21129
		// (get) Token: 0x06018828 RID: 100392 RVA: 0x003904CB File Offset: 0x0038E6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700528A RID: 21130
		// (get) Token: 0x06018829 RID: 100393 RVA: 0x003904CE File Offset: 0x0038E6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopItemInfo.Descriptor;
			}
		}

		// Token: 0x0601882A RID: 100394 RVA: 0x003904D5 File Offset: 0x0038E6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopItemInfo()
		{
		}

		// Token: 0x0601882B RID: 100395 RVA: 0x003904DD File Offset: 0x0038E6DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopItemInfo(ShopItemInfo other) : this()
		{
			this.id_ = other.id_;
			this.boughtCount_ = other.boughtCount_;
			this.lock_ = other.lock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601882C RID: 100396 RVA: 0x0039051A File Offset: 0x0038E71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopItemInfo Clone()
		{
			return new ShopItemInfo(this);
		}

		// Token: 0x1700528B RID: 21131
		// (get) Token: 0x0601882D RID: 100397 RVA: 0x00390522 File Offset: 0x0038E722
		// (set) Token: 0x0601882E RID: 100398 RVA: 0x0039052A File Offset: 0x0038E72A
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

		// Token: 0x1700528C RID: 21132
		// (get) Token: 0x0601882F RID: 100399 RVA: 0x00390533 File Offset: 0x0038E733
		// (set) Token: 0x06018830 RID: 100400 RVA: 0x0039053B File Offset: 0x0038E73B
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

		// Token: 0x1700528D RID: 21133
		// (get) Token: 0x06018831 RID: 100401 RVA: 0x00390544 File Offset: 0x0038E744
		// (set) Token: 0x06018832 RID: 100402 RVA: 0x0039054C File Offset: 0x0038E74C
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

		// Token: 0x06018833 RID: 100403 RVA: 0x00390555 File Offset: 0x0038E755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopItemInfo);
		}

		// Token: 0x06018834 RID: 100404 RVA: 0x00390564 File Offset: 0x0038E764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopItemInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BoughtCount == other.BoughtCount && this.Lock == other.Lock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018835 RID: 100405 RVA: 0x003905C0 File Offset: 0x0038E7C0
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

		// Token: 0x06018836 RID: 100406 RVA: 0x00390631 File Offset: 0x0038E831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018837 RID: 100407 RVA: 0x0039063E File Offset: 0x0038E83E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018838 RID: 100408 RVA: 0x00390648 File Offset: 0x0038E848
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

		// Token: 0x06018839 RID: 100409 RVA: 0x003906BC File Offset: 0x0038E8BC
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

		// Token: 0x0601883A RID: 100410 RVA: 0x0039072C File Offset: 0x0038E92C
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

		// Token: 0x0601883B RID: 100411 RVA: 0x00390790 File Offset: 0x0038E990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601883C RID: 100412 RVA: 0x0039079C File Offset: 0x0038E99C
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

		// Token: 0x040090DA RID: 37082
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090DB RID: 37083
		public const int IdFieldNumber = 1;

		// Token: 0x040090DC RID: 37084
		private int id_;

		// Token: 0x040090DD RID: 37085
		public const int BoughtCountFieldNumber = 2;

		// Token: 0x040090DE RID: 37086
		private int boughtCount_;

		// Token: 0x040090DF RID: 37087
		public const int LockFieldNumber = 3;

		// Token: 0x040090E0 RID: 37088
		private int lock_;
	}
}
