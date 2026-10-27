using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108B RID: 4235
	public sealed class RoleLoadEquipData : IMessage<RoleLoadEquipData>, IMessage, IEquatable<RoleLoadEquipData>, IDeepCloneable<RoleLoadEquipData>, IBufferMessage
	{
		// Token: 0x06016A06 RID: 92678 RVA: 0x0034A2D6 File Offset: 0x003484D6
		[NullableContext(1)]
		public static RoleLoadEquipData Create()
		{
			return new RoleLoadEquipData();
		}

		// Token: 0x17004BCD RID: 19405
		// (get) Token: 0x06016A07 RID: 92679 RVA: 0x0034A2DD File Offset: 0x003484DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleLoadEquipData> Parser
		{
			get
			{
				return RoleLoadEquipData._parser;
			}
		}

		// Token: 0x17004BCE RID: 19406
		// (get) Token: 0x06016A08 RID: 92680 RVA: 0x0034A2E4 File Offset: 0x003484E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BCF RID: 19407
		// (get) Token: 0x06016A09 RID: 92681 RVA: 0x0034A2E7 File Offset: 0x003484E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleLoadEquipData.Descriptor;
			}
		}

		// Token: 0x06016A0A RID: 92682 RVA: 0x0034A2EE File Offset: 0x003484EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLoadEquipData()
		{
		}

		// Token: 0x06016A0B RID: 92683 RVA: 0x0034A2F6 File Offset: 0x003484F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLoadEquipData(RoleLoadEquipData other) : this()
		{
			this.roleID_ = other.roleID_;
			this.pos_ = other.pos_;
			this.equipIncID_ = other.equipIncID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A0C RID: 92684 RVA: 0x0034A333 File Offset: 0x00348533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLoadEquipData Clone()
		{
			return new RoleLoadEquipData(this);
		}

		// Token: 0x17004BD0 RID: 19408
		// (get) Token: 0x06016A0D RID: 92685 RVA: 0x0034A33B File Offset: 0x0034853B
		// (set) Token: 0x06016A0E RID: 92686 RVA: 0x0034A343 File Offset: 0x00348543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleID
		{
			get
			{
				return this.roleID_;
			}
			set
			{
				this.roleID_ = value;
			}
		}

		// Token: 0x17004BD1 RID: 19409
		// (get) Token: 0x06016A0F RID: 92687 RVA: 0x0034A34C File Offset: 0x0034854C
		// (set) Token: 0x06016A10 RID: 92688 RVA: 0x0034A354 File Offset: 0x00348554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipPos Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17004BD2 RID: 19410
		// (get) Token: 0x06016A11 RID: 92689 RVA: 0x0034A35D File Offset: 0x0034855D
		// (set) Token: 0x06016A12 RID: 92690 RVA: 0x0034A365 File Offset: 0x00348565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EquipIncID
		{
			get
			{
				return this.equipIncID_;
			}
			set
			{
				this.equipIncID_ = value;
			}
		}

		// Token: 0x06016A13 RID: 92691 RVA: 0x0034A36E File Offset: 0x0034856E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleLoadEquipData);
		}

		// Token: 0x06016A14 RID: 92692 RVA: 0x0034A37C File Offset: 0x0034857C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleLoadEquipData other)
		{
			return other != null && (other == this || (this.RoleID == other.RoleID && this.Pos == other.Pos && this.EquipIncID == other.EquipIncID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A15 RID: 92693 RVA: 0x0034A3D8 File Offset: 0x003485D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleID != 0)
			{
				num ^= this.RoleID.GetHashCode();
			}
			if (this.Pos != EquipPos.Weapon)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.EquipIncID != 0)
			{
				num ^= this.EquipIncID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016A16 RID: 92694 RVA: 0x0034A44F File Offset: 0x0034864F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A17 RID: 92695 RVA: 0x0034A45C File Offset: 0x0034865C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A18 RID: 92696 RVA: 0x0034A468 File Offset: 0x00348668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleID != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleID);
			}
			if (this.Pos != EquipPos.Weapon)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Pos);
			}
			if (this.EquipIncID != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EquipIncID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A19 RID: 92697 RVA: 0x0034A4DC File Offset: 0x003486DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleID);
			}
			if (this.Pos != EquipPos.Weapon)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Pos);
			}
			if (this.EquipIncID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EquipIncID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016A1A RID: 92698 RVA: 0x0034A54C File Offset: 0x0034874C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleLoadEquipData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleID != 0)
			{
				this.RoleID = other.RoleID;
			}
			if (other.Pos != EquipPos.Weapon)
			{
				this.Pos = other.Pos;
			}
			if (other.EquipIncID != 0)
			{
				this.EquipIncID = other.EquipIncID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016A1B RID: 92699 RVA: 0x0034A5B0 File Offset: 0x003487B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A1C RID: 92700 RVA: 0x0034A5BC File Offset: 0x003487BC
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
							this.EquipIncID = input.ReadInt32();
						}
					}
					else
					{
						this.Pos = (EquipPos)input.ReadEnum();
					}
				}
				else
				{
					this.RoleID = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008746 RID: 34630
		private static readonly MessageParser<RoleLoadEquipData> _parser = new MessageParser<RoleLoadEquipData>(() => new RoleLoadEquipData());

		// Token: 0x04008747 RID: 34631
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008748 RID: 34632
		public const int RoleIDFieldNumber = 1;

		// Token: 0x04008749 RID: 34633
		private int roleID_;

		// Token: 0x0400874A RID: 34634
		public const int PosFieldNumber = 2;

		// Token: 0x0400874B RID: 34635
		private EquipPos pos_;

		// Token: 0x0400874C RID: 34636
		public const int EquipIncIDFieldNumber = 3;

		// Token: 0x0400874D RID: 34637
		private int equipIncID_;
	}
}
