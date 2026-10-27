using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F9 RID: 761
	public sealed class CookingInfo : IMessage<CookingInfo>, IMessage, IEquatable<CookingInfo>, IDeepCloneable<CookingInfo>, IBufferMessage
	{
		// Token: 0x06004D07 RID: 19719 RVA: 0x000BB5EE File Offset: 0x000B97EE
		[NullableContext(1)]
		public static CookingInfo Create()
		{
			return new CookingInfo();
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x000BB5F5 File Offset: 0x000B97F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06004D09 RID: 19721 RVA: 0x000BB5F8 File Offset: 0x000B97F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookingInfo.Descriptor;
			}
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x000BB5FF File Offset: 0x000B97FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfo()
		{
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x000BB607 File Offset: 0x000B9807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfo(CookingInfo other) : this()
		{
			this.cookingLevel_ = other.cookingLevel_;
			this.totalProficiencys_ = other.totalProficiencys_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x000BB638 File Offset: 0x000B9838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfo Clone()
		{
			return new CookingInfo(this);
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06004D0D RID: 19725 RVA: 0x000BB640 File Offset: 0x000B9840
		// (set) Token: 0x06004D0E RID: 19726 RVA: 0x000BB648 File Offset: 0x000B9848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CookingLevel
		{
			get
			{
				return this.cookingLevel_;
			}
			set
			{
				this.cookingLevel_ = value;
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06004D0F RID: 19727 RVA: 0x000BB651 File Offset: 0x000B9851
		// (set) Token: 0x06004D10 RID: 19728 RVA: 0x000BB659 File Offset: 0x000B9859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalProficiencys
		{
			get
			{
				return this.totalProficiencys_;
			}
			set
			{
				this.totalProficiencys_ = value;
			}
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x000BB662 File Offset: 0x000B9862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookingInfo);
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x000BB670 File Offset: 0x000B9870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookingInfo other)
		{
			return other != null && (other == this || (this.CookingLevel == other.CookingLevel && this.TotalProficiencys == other.TotalProficiencys && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x000BB6B0 File Offset: 0x000B98B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CookingLevel != 0)
			{
				num ^= this.CookingLevel.GetHashCode();
			}
			if (this.TotalProficiencys != 0)
			{
				num ^= this.TotalProficiencys.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x000BB708 File Offset: 0x000B9908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x000BB715 File Offset: 0x000B9915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x000BB720 File Offset: 0x000B9920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CookingLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CookingLevel);
			}
			if (this.TotalProficiencys != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalProficiencys);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x000BB778 File Offset: 0x000B9978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CookingLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CookingLevel);
			}
			if (this.TotalProficiencys != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalProficiencys);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x000BB7D0 File Offset: 0x000B99D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookingInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CookingLevel != 0)
			{
				this.CookingLevel = other.CookingLevel;
			}
			if (other.TotalProficiencys != 0)
			{
				this.TotalProficiencys = other.TotalProficiencys;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x000BB820 File Offset: 0x000B9A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x000BB82C File Offset: 0x000B9A2C
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
						this.TotalProficiencys = input.ReadInt32();
					}
				}
				else
				{
					this.CookingLevel = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003131 RID: 12593
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003132 RID: 12594
		public const int CookingLevelFieldNumber = 1;

		// Token: 0x04003133 RID: 12595
		private int cookingLevel_;

		// Token: 0x04003134 RID: 12596
		public const int TotalProficiencysFieldNumber = 2;

		// Token: 0x04003135 RID: 12597
		private int totalProficiencys_;
	}
}
