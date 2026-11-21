using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FC RID: 5372
	public sealed class UnlockInfo : IMessage<UnlockInfo>, IMessage, IEquatable<UnlockInfo>, IDeepCloneable<UnlockInfo>, IBufferMessage
	{
		// Token: 0x0601C7A0 RID: 116640 RVA: 0x004212A6 File Offset: 0x0041F4A6
		[NullableContext(1)]
		public static UnlockInfo Create()
		{
			return new UnlockInfo();
		}

		// Token: 0x1700605D RID: 24669
		// (get) Token: 0x0601C7A1 RID: 116641 RVA: 0x004212AD File Offset: 0x0041F4AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockInfo> Parser
		{
			get
			{
				return UnlockInfo._parser;
			}
		}

		// Token: 0x1700605E RID: 24670
		// (get) Token: 0x0601C7A2 RID: 116642 RVA: 0x004212B4 File Offset: 0x0041F4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700605F RID: 24671
		// (get) Token: 0x0601C7A3 RID: 116643 RVA: 0x004212B7 File Offset: 0x0041F4B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockInfo.Descriptor;
			}
		}

		// Token: 0x0601C7A4 RID: 116644 RVA: 0x004212BE File Offset: 0x0041F4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInfo()
		{
		}

		// Token: 0x0601C7A5 RID: 116645 RVA: 0x004212C6 File Offset: 0x0041F4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInfo(UnlockInfo other) : this()
		{
			this.shopId_ = other.shopId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C7A6 RID: 116646 RVA: 0x004212F7 File Offset: 0x0041F4F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInfo Clone()
		{
			return new UnlockInfo(this);
		}

		// Token: 0x17006060 RID: 24672
		// (get) Token: 0x0601C7A7 RID: 116647 RVA: 0x004212FF File Offset: 0x0041F4FF
		// (set) Token: 0x0601C7A8 RID: 116648 RVA: 0x00421307 File Offset: 0x0041F507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x17006061 RID: 24673
		// (get) Token: 0x0601C7A9 RID: 116649 RVA: 0x00421310 File Offset: 0x0041F510
		// (set) Token: 0x0601C7AA RID: 116650 RVA: 0x00421318 File Offset: 0x0041F518
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

		// Token: 0x0601C7AB RID: 116651 RVA: 0x00421321 File Offset: 0x0041F521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockInfo);
		}

		// Token: 0x0601C7AC RID: 116652 RVA: 0x0042132F File Offset: 0x0041F52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockInfo other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C7AD RID: 116653 RVA: 0x00421370 File Offset: 0x0041F570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C7AE RID: 116654 RVA: 0x004213C8 File Offset: 0x0041F5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C7AF RID: 116655 RVA: 0x004213D5 File Offset: 0x0041F5D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C7B0 RID: 116656 RVA: 0x004213E0 File Offset: 0x0041F5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShopId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C7B1 RID: 116657 RVA: 0x00421438 File Offset: 0x0041F638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C7B2 RID: 116658 RVA: 0x00421490 File Offset: 0x0041F690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C7B3 RID: 116659 RVA: 0x004214E0 File Offset: 0x0041F6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C7B4 RID: 116660 RVA: 0x004214EC File Offset: 0x0041F6EC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.ShopId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A454 RID: 42068
		private static readonly MessageParser<UnlockInfo> _parser = new MessageParser<UnlockInfo>(() => new UnlockInfo());

		// Token: 0x0400A455 RID: 42069
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A456 RID: 42070
		public const int ShopIdFieldNumber = 1;

		// Token: 0x0400A457 RID: 42071
		private int shopId_;

		// Token: 0x0400A458 RID: 42072
		public const int IdFieldNumber = 2;

		// Token: 0x0400A459 RID: 42073
		private int id_;
	}
}
