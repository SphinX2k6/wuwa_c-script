using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000125 RID: 293
	public sealed class AttrChangeSyncDataPb : IMessage<AttrChangeSyncDataPb>, IMessage, IEquatable<AttrChangeSyncDataPb>, IDeepCloneable<AttrChangeSyncDataPb>, IBufferMessage
	{
		// Token: 0x06002784 RID: 10116 RVA: 0x00068C93 File Offset: 0x00066E93
		[NullableContext(1)]
		public static AttrChangeSyncDataPb Create()
		{
			return new AttrChangeSyncDataPb();
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x00068C9A File Offset: 0x00066E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x00068C9D File Offset: 0x00066E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttrChangeSyncDataPb.Descriptor;
			}
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00068CA4 File Offset: 0x00066EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttrChangeSyncDataPb()
		{
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00068CAC File Offset: 0x00066EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttrChangeSyncDataPb(AttrChangeSyncDataPb other) : this()
		{
			this.attrType_ = other.attrType_;
			this.delta_ = other.delta_;
			this.attrCost_ = other.attrCost_;
			this.attrAdd_ = other.attrAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00068D00 File Offset: 0x00066F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttrChangeSyncDataPb Clone()
		{
			return new AttrChangeSyncDataPb(this);
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600278A RID: 10122 RVA: 0x00068D08 File Offset: 0x00066F08
		// (set) Token: 0x0600278B RID: 10123 RVA: 0x00068D10 File Offset: 0x00066F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolAttrType AttrType
		{
			get
			{
				return this.attrType_;
			}
			set
			{
				this.attrType_ = value;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x00068D19 File Offset: 0x00066F19
		// (set) Token: 0x0600278D RID: 10125 RVA: 0x00068D21 File Offset: 0x00066F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Delta
		{
			get
			{
				return this.delta_;
			}
			set
			{
				this.delta_ = value;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x00068D2A File Offset: 0x00066F2A
		// (set) Token: 0x0600278F RID: 10127 RVA: 0x00068D32 File Offset: 0x00066F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttrCost
		{
			get
			{
				return this.attrCost_;
			}
			set
			{
				this.attrCost_ = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06002790 RID: 10128 RVA: 0x00068D3B File Offset: 0x00066F3B
		// (set) Token: 0x06002791 RID: 10129 RVA: 0x00068D43 File Offset: 0x00066F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttrAdd
		{
			get
			{
				return this.attrAdd_;
			}
			set
			{
				this.attrAdd_ = value;
			}
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x00068D4C File Offset: 0x00066F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttrChangeSyncDataPb);
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00068D5C File Offset: 0x00066F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttrChangeSyncDataPb other)
		{
			return other != null && (other == this || (this.AttrType == other.AttrType && this.Delta == other.Delta && this.AttrCost == other.AttrCost && this.AttrAdd == other.AttrAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x00068DC8 File Offset: 0x00066FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttrType != SolarSchoolAttrType.SolarSchoolAttrUnknown)
			{
				num ^= this.AttrType.GetHashCode();
			}
			if (this.Delta != 0)
			{
				num ^= this.Delta.GetHashCode();
			}
			if (this.AttrCost != 0)
			{
				num ^= this.AttrCost.GetHashCode();
			}
			if (this.AttrAdd != 0)
			{
				num ^= this.AttrAdd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x00068E58 File Offset: 0x00067058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00068E65 File Offset: 0x00067065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00068E70 File Offset: 0x00067070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttrType != SolarSchoolAttrType.SolarSchoolAttrUnknown)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.AttrType);
			}
			if (this.Delta != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Delta);
			}
			if (this.AttrCost != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AttrCost);
			}
			if (this.AttrAdd != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.AttrAdd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x00068F00 File Offset: 0x00067100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttrType != SolarSchoolAttrType.SolarSchoolAttrUnknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AttrType);
			}
			if (this.Delta != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Delta);
			}
			if (this.AttrCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttrCost);
			}
			if (this.AttrAdd != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttrAdd);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00068F88 File Offset: 0x00067188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttrChangeSyncDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttrType != SolarSchoolAttrType.SolarSchoolAttrUnknown)
			{
				this.AttrType = other.AttrType;
			}
			if (other.Delta != 0)
			{
				this.Delta = other.Delta;
			}
			if (other.AttrCost != 0)
			{
				this.AttrCost = other.AttrCost;
			}
			if (other.AttrAdd != 0)
			{
				this.AttrAdd = other.AttrAdd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00069000 File Offset: 0x00067200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x0006900C File Offset: 0x0006720C
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
						this.AttrType = (SolarSchoolAttrType)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.Delta = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.AttrCost = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.AttrAdd = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040026B7 RID: 9911
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026B8 RID: 9912
		public const int AttrTypeFieldNumber = 1;

		// Token: 0x040026B9 RID: 9913
		private SolarSchoolAttrType attrType_;

		// Token: 0x040026BA RID: 9914
		public const int DeltaFieldNumber = 2;

		// Token: 0x040026BB RID: 9915
		private int delta_;

		// Token: 0x040026BC RID: 9916
		public const int AttrCostFieldNumber = 3;

		// Token: 0x040026BD RID: 9917
		private int attrCost_;

		// Token: 0x040026BE RID: 9918
		public const int AttrAddFieldNumber = 4;

		// Token: 0x040026BF RID: 9919
		private int attrAdd_;
	}
}
