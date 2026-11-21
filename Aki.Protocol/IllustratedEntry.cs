using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B1 RID: 1969
	public sealed class IllustratedEntry : IMessage<IllustratedEntry>, IMessage, IEquatable<IllustratedEntry>, IDeepCloneable<IllustratedEntry>, IBufferMessage
	{
		// Token: 0x0600B197 RID: 45463 RVA: 0x001A9B49 File Offset: 0x001A7D49
		[NullableContext(1)]
		public static IllustratedEntry Create()
		{
			return new IllustratedEntry();
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x0600B198 RID: 45464 RVA: 0x001A9B50 File Offset: 0x001A7D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IllustratedEntry> Parser
		{
			get
			{
				return IllustratedEntry._parser;
			}
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x0600B199 RID: 45465 RVA: 0x001A9B57 File Offset: 0x001A7D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x0600B19A RID: 45466 RVA: 0x001A9B5A File Offset: 0x001A7D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedEntry.Descriptor;
			}
		}

		// Token: 0x0600B19B RID: 45467 RVA: 0x001A9B61 File Offset: 0x001A7D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedEntry()
		{
		}

		// Token: 0x0600B19C RID: 45468 RVA: 0x001A9B6C File Offset: 0x001A7D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedEntry(IllustratedEntry other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.createTime_ = other.createTime_;
			this.num_ = other.num_;
			this.isRead_ = other.isRead_;
			this.photographSubType_ = other.photographSubType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B19D RID: 45469 RVA: 0x001A9BD8 File Offset: 0x001A7DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedEntry Clone()
		{
			return new IllustratedEntry(this);
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x0600B19E RID: 45470 RVA: 0x001A9BE0 File Offset: 0x001A7DE0
		// (set) Token: 0x0600B19F RID: 45471 RVA: 0x001A9BE8 File Offset: 0x001A7DE8
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

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x0600B1A0 RID: 45472 RVA: 0x001A9BF1 File Offset: 0x001A7DF1
		// (set) Token: 0x0600B1A1 RID: 45473 RVA: 0x001A9BF9 File Offset: 0x001A7DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				this.createTime_ = value;
			}
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x0600B1A2 RID: 45474 RVA: 0x001A9C02 File Offset: 0x001A7E02
		// (set) Token: 0x0600B1A3 RID: 45475 RVA: 0x001A9C0A File Offset: 0x001A7E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x0600B1A4 RID: 45476 RVA: 0x001A9C13 File Offset: 0x001A7E13
		// (set) Token: 0x0600B1A5 RID: 45477 RVA: 0x001A9C1B File Offset: 0x001A7E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRead
		{
			get
			{
				return this.isRead_;
			}
			set
			{
				this.isRead_ = value;
			}
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x0600B1A6 RID: 45478 RVA: 0x001A9C24 File Offset: 0x001A7E24
		// (set) Token: 0x0600B1A7 RID: 45479 RVA: 0x001A9C3C File Offset: 0x001A7E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotographSubType PhotographSubType
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.photographSubType_;
				}
				return IllustratedEntry.PhotographSubTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.photographSubType_ = value;
			}
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x0600B1A8 RID: 45480 RVA: 0x001A9C53 File Offset: 0x001A7E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPhotographSubType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B1A9 RID: 45481 RVA: 0x001A9C60 File Offset: 0x001A7E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhotographSubType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600B1AA RID: 45482 RVA: 0x001A9C71 File Offset: 0x001A7E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedEntry);
		}

		// Token: 0x0600B1AB RID: 45483 RVA: 0x001A9C80 File Offset: 0x001A7E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedEntry other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CreateTime == other.CreateTime && this.Num == other.Num && this.IsRead == other.IsRead && this.PhotographSubType == other.PhotographSubType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1AC RID: 45484 RVA: 0x001A9CFC File Offset: 0x001A7EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CreateTime != 0U)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.IsRead)
			{
				num ^= this.IsRead.GetHashCode();
			}
			if (this.HasPhotographSubType)
			{
				num ^= this.PhotographSubType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B1AD RID: 45485 RVA: 0x001A9DA6 File Offset: 0x001A7FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B1AE RID: 45486 RVA: 0x001A9DB3 File Offset: 0x001A7FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1AF RID: 45487 RVA: 0x001A9DBC File Offset: 0x001A7FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.CreateTime != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CreateTime);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Num);
			}
			if (this.IsRead)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsRead);
			}
			if (this.HasPhotographSubType)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.PhotographSubType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1B0 RID: 45488 RVA: 0x001A9E68 File Offset: 0x001A8068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.CreateTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CreateTime);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.IsRead)
			{
				num += 2;
			}
			if (this.HasPhotographSubType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PhotographSubType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B1B1 RID: 45489 RVA: 0x001A9EFC File Offset: 0x001A80FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.CreateTime != 0U)
			{
				this.CreateTime = other.CreateTime;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.IsRead)
			{
				this.IsRead = other.IsRead;
			}
			if (other.HasPhotographSubType)
			{
				this.PhotographSubType = other.PhotographSubType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x001A9F88 File Offset: 0x001A8188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1B3 RID: 45491 RVA: 0x001A9F94 File Offset: 0x001A8194
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CreateTime = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Num = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsRead = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.PhotographSubType = (PhotographSubType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004FDE RID: 20446
		private static readonly MessageParser<IllustratedEntry> _parser = new MessageParser<IllustratedEntry>(() => new IllustratedEntry());

		// Token: 0x04004FDF RID: 20447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FE0 RID: 20448
		private int _hasBits0;

		// Token: 0x04004FE1 RID: 20449
		public const int IdFieldNumber = 1;

		// Token: 0x04004FE2 RID: 20450
		private int id_;

		// Token: 0x04004FE3 RID: 20451
		public const int CreateTimeFieldNumber = 2;

		// Token: 0x04004FE4 RID: 20452
		private uint createTime_;

		// Token: 0x04004FE5 RID: 20453
		public const int NumFieldNumber = 3;

		// Token: 0x04004FE6 RID: 20454
		private int num_;

		// Token: 0x04004FE7 RID: 20455
		public const int IsReadFieldNumber = 4;

		// Token: 0x04004FE8 RID: 20456
		private bool isRead_;

		// Token: 0x04004FE9 RID: 20457
		public const int PhotographSubTypeFieldNumber = 5;

		// Token: 0x04004FEA RID: 20458
		private static readonly PhotographSubType PhotographSubTypeDefaultValue = PhotographSubType.None;

		// Token: 0x04004FEB RID: 20459
		private PhotographSubType photographSubType_;
	}
}
