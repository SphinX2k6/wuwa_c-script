using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003EE RID: 1006
	public sealed class DropBagItemInfo : IMessage<DropBagItemInfo>, IMessage, IEquatable<DropBagItemInfo>, IDeepCloneable<DropBagItemInfo>, IBufferMessage
	{
		// Token: 0x060061BF RID: 25023 RVA: 0x000EBD54 File Offset: 0x000E9F54
		[NullableContext(1)]
		public static DropBagItemInfo Create()
		{
			return new DropBagItemInfo();
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x060061C0 RID: 25024 RVA: 0x000EBD5B File Offset: 0x000E9F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DropBagItemInfo> Parser
		{
			get
			{
				return DropBagItemInfo._parser;
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x060061C1 RID: 25025 RVA: 0x000EBD62 File Offset: 0x000E9F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x060061C2 RID: 25026 RVA: 0x000EBD65 File Offset: 0x000E9F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropBagItemInfo.Descriptor;
			}
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x000EBD6C File Offset: 0x000E9F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropBagItemInfo()
		{
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x000EBD74 File Offset: 0x000E9F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropBagItemInfo(DropBagItemInfo other) : this()
		{
			this.showPlanId_ = other.showPlanId_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x000EBDB1 File Offset: 0x000E9FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropBagItemInfo Clone()
		{
			return new DropBagItemInfo(this);
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x060061C6 RID: 25030 RVA: 0x000EBDB9 File Offset: 0x000E9FB9
		// (set) Token: 0x060061C7 RID: 25031 RVA: 0x000EBDC1 File Offset: 0x000E9FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShowPlanId
		{
			get
			{
				return this.showPlanId_;
			}
			set
			{
				this.showPlanId_ = value;
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x060061C8 RID: 25032 RVA: 0x000EBDCA File Offset: 0x000E9FCA
		// (set) Token: 0x060061C9 RID: 25033 RVA: 0x000EBDD2 File Offset: 0x000E9FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x060061CA RID: 25034 RVA: 0x000EBDDB File Offset: 0x000E9FDB
		// (set) Token: 0x060061CB RID: 25035 RVA: 0x000EBDE3 File Offset: 0x000E9FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x060061CC RID: 25036 RVA: 0x000EBDEC File Offset: 0x000E9FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropBagItemInfo);
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x000EBDFC File Offset: 0x000E9FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropBagItemInfo other)
		{
			return other != null && (other == this || (this.ShowPlanId == other.ShowPlanId && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x000EBE58 File Offset: 0x000EA058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShowPlanId != 0)
			{
				num ^= this.ShowPlanId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x000EBEC9 File Offset: 0x000EA0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x000EBED6 File Offset: 0x000EA0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061D1 RID: 25041 RVA: 0x000EBEE0 File Offset: 0x000EA0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowPlanId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShowPlanId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x000EBF54 File Offset: 0x000EA154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShowPlanId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShowPlanId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060061D3 RID: 25043 RVA: 0x000EBFC4 File Offset: 0x000EA1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropBagItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShowPlanId != 0)
			{
				this.ShowPlanId = other.ShowPlanId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060061D4 RID: 25044 RVA: 0x000EC028 File Offset: 0x000EA228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061D5 RID: 25045 RVA: 0x000EC034 File Offset: 0x000EA234
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
							this.ItemCount = input.ReadInt32();
						}
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.ShowPlanId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003808 RID: 14344
		private static readonly MessageParser<DropBagItemInfo> _parser = new MessageParser<DropBagItemInfo>(() => new DropBagItemInfo());

		// Token: 0x04003809 RID: 14345
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400380A RID: 14346
		public const int ShowPlanIdFieldNumber = 1;

		// Token: 0x0400380B RID: 14347
		private int showPlanId_;

		// Token: 0x0400380C RID: 14348
		public const int ItemIdFieldNumber = 2;

		// Token: 0x0400380D RID: 14349
		private int itemId_;

		// Token: 0x0400380E RID: 14350
		public const int ItemCountFieldNumber = 3;

		// Token: 0x0400380F RID: 14351
		private int itemCount_;
	}
}
