using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107B RID: 4219
	public sealed class RoleLoadEquipData : IMessage<RoleLoadEquipData>, IMessage, IEquatable<RoleLoadEquipData>, IDeepCloneable<RoleLoadEquipData>, IBufferMessage
	{
		// Token: 0x06016921 RID: 92449 RVA: 0x00348BFE File Offset: 0x00346DFE
		[NullableContext(1)]
		public static RoleLoadEquipData Create()
		{
			return new RoleLoadEquipData();
		}

		// Token: 0x17004BA3 RID: 19363
		// (get) Token: 0x06016922 RID: 92450 RVA: 0x00348C05 File Offset: 0x00346E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleLoadEquipData> Parser
		{
			get
			{
				return RoleLoadEquipData._parser;
			}
		}

		// Token: 0x17004BA4 RID: 19364
		// (get) Token: 0x06016923 RID: 92451 RVA: 0x00348C0C File Offset: 0x00346E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BA5 RID: 19365
		// (get) Token: 0x06016924 RID: 92452 RVA: 0x00348C0F File Offset: 0x00346E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleLoadEquipData.Descriptor;
			}
		}

		// Token: 0x06016925 RID: 92453 RVA: 0x00348C16 File Offset: 0x00346E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLoadEquipData()
		{
		}

		// Token: 0x06016926 RID: 92454 RVA: 0x00348C1E File Offset: 0x00346E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLoadEquipData(RoleLoadEquipData other) : this()
		{
			this.roleID_ = other.roleID_;
			this.pos_ = other.pos_;
			this.equipIncID_ = other.equipIncID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016927 RID: 92455 RVA: 0x00348C5B File Offset: 0x00346E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLoadEquipData Clone()
		{
			return new RoleLoadEquipData(this);
		}

		// Token: 0x17004BA6 RID: 19366
		// (get) Token: 0x06016928 RID: 92456 RVA: 0x00348C63 File Offset: 0x00346E63
		// (set) Token: 0x06016929 RID: 92457 RVA: 0x00348C6B File Offset: 0x00346E6B
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

		// Token: 0x17004BA7 RID: 19367
		// (get) Token: 0x0601692A RID: 92458 RVA: 0x00348C74 File Offset: 0x00346E74
		// (set) Token: 0x0601692B RID: 92459 RVA: 0x00348C7C File Offset: 0x00346E7C
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

		// Token: 0x17004BA8 RID: 19368
		// (get) Token: 0x0601692C RID: 92460 RVA: 0x00348C85 File Offset: 0x00346E85
		// (set) Token: 0x0601692D RID: 92461 RVA: 0x00348C8D File Offset: 0x00346E8D
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

		// Token: 0x0601692E RID: 92462 RVA: 0x00348C96 File Offset: 0x00346E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleLoadEquipData);
		}

		// Token: 0x0601692F RID: 92463 RVA: 0x00348CA4 File Offset: 0x00346EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleLoadEquipData other)
		{
			return other != null && (other == this || (this.RoleID == other.RoleID && this.Pos == other.Pos && this.EquipIncID == other.EquipIncID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016930 RID: 92464 RVA: 0x00348D00 File Offset: 0x00346F00
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

		// Token: 0x06016931 RID: 92465 RVA: 0x00348D77 File Offset: 0x00346F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016932 RID: 92466 RVA: 0x00348D84 File Offset: 0x00346F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016933 RID: 92467 RVA: 0x00348D90 File Offset: 0x00346F90
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

		// Token: 0x06016934 RID: 92468 RVA: 0x00348E04 File Offset: 0x00347004
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

		// Token: 0x06016935 RID: 92469 RVA: 0x00348E74 File Offset: 0x00347074
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

		// Token: 0x06016936 RID: 92470 RVA: 0x00348ED8 File Offset: 0x003470D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016937 RID: 92471 RVA: 0x00348EE4 File Offset: 0x003470E4
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

		// Token: 0x04008770 RID: 34672
		private static readonly MessageParser<RoleLoadEquipData> _parser = new MessageParser<RoleLoadEquipData>(() => new RoleLoadEquipData());

		// Token: 0x04008771 RID: 34673
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008772 RID: 34674
		public const int RoleIDFieldNumber = 1;

		// Token: 0x04008773 RID: 34675
		private int roleID_;

		// Token: 0x04008774 RID: 34676
		public const int PosFieldNumber = 2;

		// Token: 0x04008775 RID: 34677
		private EquipPos pos_;

		// Token: 0x04008776 RID: 34678
		public const int EquipIncIDFieldNumber = 3;

		// Token: 0x04008777 RID: 34679
		private int equipIncID_;
	}
}
