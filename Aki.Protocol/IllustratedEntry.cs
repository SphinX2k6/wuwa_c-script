using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C5 RID: 1989
	public sealed class IllustratedEntry : IMessage<IllustratedEntry>, IMessage, IEquatable<IllustratedEntry>, IDeepCloneable<IllustratedEntry>, IBufferMessage
	{
		// Token: 0x0600B2ED RID: 45805 RVA: 0x001AC579 File Offset: 0x001AA779
		[NullableContext(1)]
		public static IllustratedEntry Create()
		{
			return new IllustratedEntry();
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x0600B2EE RID: 45806 RVA: 0x001AC580 File Offset: 0x001AA780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IllustratedEntry> Parser
		{
			get
			{
				return IllustratedEntry._parser;
			}
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x0600B2EF RID: 45807 RVA: 0x001AC587 File Offset: 0x001AA787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x0600B2F0 RID: 45808 RVA: 0x001AC58A File Offset: 0x001AA78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedEntry.Descriptor;
			}
		}

		// Token: 0x0600B2F1 RID: 45809 RVA: 0x001AC591 File Offset: 0x001AA791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedEntry()
		{
		}

		// Token: 0x0600B2F2 RID: 45810 RVA: 0x001AC59C File Offset: 0x001AA79C
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

		// Token: 0x0600B2F3 RID: 45811 RVA: 0x001AC608 File Offset: 0x001AA808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedEntry Clone()
		{
			return new IllustratedEntry(this);
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x0600B2F4 RID: 45812 RVA: 0x001AC610 File Offset: 0x001AA810
		// (set) Token: 0x0600B2F5 RID: 45813 RVA: 0x001AC618 File Offset: 0x001AA818
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

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x0600B2F6 RID: 45814 RVA: 0x001AC621 File Offset: 0x001AA821
		// (set) Token: 0x0600B2F7 RID: 45815 RVA: 0x001AC629 File Offset: 0x001AA829
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

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x0600B2F8 RID: 45816 RVA: 0x001AC632 File Offset: 0x001AA832
		// (set) Token: 0x0600B2F9 RID: 45817 RVA: 0x001AC63A File Offset: 0x001AA83A
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

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x0600B2FA RID: 45818 RVA: 0x001AC643 File Offset: 0x001AA843
		// (set) Token: 0x0600B2FB RID: 45819 RVA: 0x001AC64B File Offset: 0x001AA84B
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

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x0600B2FC RID: 45820 RVA: 0x001AC654 File Offset: 0x001AA854
		// (set) Token: 0x0600B2FD RID: 45821 RVA: 0x001AC66C File Offset: 0x001AA86C
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

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x0600B2FE RID: 45822 RVA: 0x001AC683 File Offset: 0x001AA883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPhotographSubType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B2FF RID: 45823 RVA: 0x001AC690 File Offset: 0x001AA890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPhotographSubType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600B300 RID: 45824 RVA: 0x001AC6A1 File Offset: 0x001AA8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedEntry);
		}

		// Token: 0x0600B301 RID: 45825 RVA: 0x001AC6B0 File Offset: 0x001AA8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedEntry other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CreateTime == other.CreateTime && this.Num == other.Num && this.IsRead == other.IsRead && this.PhotographSubType == other.PhotographSubType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B302 RID: 45826 RVA: 0x001AC72C File Offset: 0x001AA92C
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

		// Token: 0x0600B303 RID: 45827 RVA: 0x001AC7D6 File Offset: 0x001AA9D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B304 RID: 45828 RVA: 0x001AC7E3 File Offset: 0x001AA9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B305 RID: 45829 RVA: 0x001AC7EC File Offset: 0x001AA9EC
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

		// Token: 0x0600B306 RID: 45830 RVA: 0x001AC898 File Offset: 0x001AAA98
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

		// Token: 0x0600B307 RID: 45831 RVA: 0x001AC92C File Offset: 0x001AAB2C
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

		// Token: 0x0600B308 RID: 45832 RVA: 0x001AC9B8 File Offset: 0x001AABB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B309 RID: 45833 RVA: 0x001AC9C4 File Offset: 0x001AABC4
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

		// Token: 0x04004FE5 RID: 20453
		private static readonly MessageParser<IllustratedEntry> _parser = new MessageParser<IllustratedEntry>(() => new IllustratedEntry());

		// Token: 0x04004FE6 RID: 20454
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FE7 RID: 20455
		private int _hasBits0;

		// Token: 0x04004FE8 RID: 20456
		public const int IdFieldNumber = 1;

		// Token: 0x04004FE9 RID: 20457
		private int id_;

		// Token: 0x04004FEA RID: 20458
		public const int CreateTimeFieldNumber = 2;

		// Token: 0x04004FEB RID: 20459
		private uint createTime_;

		// Token: 0x04004FEC RID: 20460
		public const int NumFieldNumber = 3;

		// Token: 0x04004FED RID: 20461
		private int num_;

		// Token: 0x04004FEE RID: 20462
		public const int IsReadFieldNumber = 4;

		// Token: 0x04004FEF RID: 20463
		private bool isRead_;

		// Token: 0x04004FF0 RID: 20464
		public const int PhotographSubTypeFieldNumber = 5;

		// Token: 0x04004FF1 RID: 20465
		private static readonly PhotographSubType PhotographSubTypeDefaultValue = PhotographSubType.None;

		// Token: 0x04004FF2 RID: 20466
		private PhotographSubType photographSubType_;
	}
}
