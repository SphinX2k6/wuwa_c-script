using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BC RID: 4284
	public sealed class RoleSkinEquipData : IMessage<RoleSkinEquipData>, IMessage, IEquatable<RoleSkinEquipData>, IDeepCloneable<RoleSkinEquipData>, IBufferMessage
	{
		// Token: 0x06016DE5 RID: 93669 RVA: 0x00352639 File Offset: 0x00350839
		[NullableContext(1)]
		public static RoleSkinEquipData Create()
		{
			return new RoleSkinEquipData();
		}

		// Token: 0x17004C9E RID: 19614
		// (get) Token: 0x06016DE6 RID: 93670 RVA: 0x00352640 File Offset: 0x00350840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleSkinEquipData> Parser
		{
			get
			{
				return RoleSkinEquipData._parser;
			}
		}

		// Token: 0x17004C9F RID: 19615
		// (get) Token: 0x06016DE7 RID: 93671 RVA: 0x00352647 File Offset: 0x00350847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CA0 RID: 19616
		// (get) Token: 0x06016DE8 RID: 93672 RVA: 0x0035264A File Offset: 0x0035084A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinEquipData.Descriptor;
			}
		}

		// Token: 0x06016DE9 RID: 93673 RVA: 0x00352651 File Offset: 0x00350851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinEquipData()
		{
		}

		// Token: 0x06016DEA RID: 93674 RVA: 0x00352659 File Offset: 0x00350859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinEquipData(RoleSkinEquipData other) : this()
		{
			this.roleID_ = other.roleID_;
			this.skinItemId_ = other.skinItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016DEB RID: 93675 RVA: 0x0035268A File Offset: 0x0035088A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinEquipData Clone()
		{
			return new RoleSkinEquipData(this);
		}

		// Token: 0x17004CA1 RID: 19617
		// (get) Token: 0x06016DEC RID: 93676 RVA: 0x00352692 File Offset: 0x00350892
		// (set) Token: 0x06016DED RID: 93677 RVA: 0x0035269A File Offset: 0x0035089A
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

		// Token: 0x17004CA2 RID: 19618
		// (get) Token: 0x06016DEE RID: 93678 RVA: 0x003526A3 File Offset: 0x003508A3
		// (set) Token: 0x06016DEF RID: 93679 RVA: 0x003526AB File Offset: 0x003508AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinItemId
		{
			get
			{
				return this.skinItemId_;
			}
			set
			{
				this.skinItemId_ = value;
			}
		}

		// Token: 0x06016DF0 RID: 93680 RVA: 0x003526B4 File Offset: 0x003508B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinEquipData);
		}

		// Token: 0x06016DF1 RID: 93681 RVA: 0x003526C2 File Offset: 0x003508C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinEquipData other)
		{
			return other != null && (other == this || (this.RoleID == other.RoleID && this.SkinItemId == other.SkinItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016DF2 RID: 93682 RVA: 0x00352700 File Offset: 0x00350900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleID != 0)
			{
				num ^= this.RoleID.GetHashCode();
			}
			if (this.SkinItemId != 0)
			{
				num ^= this.SkinItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016DF3 RID: 93683 RVA: 0x00352758 File Offset: 0x00350958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016DF4 RID: 93684 RVA: 0x00352765 File Offset: 0x00350965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016DF5 RID: 93685 RVA: 0x00352770 File Offset: 0x00350970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleID != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleID);
			}
			if (this.SkinItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkinItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016DF6 RID: 93686 RVA: 0x003527C8 File Offset: 0x003509C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleID);
			}
			if (this.SkinItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016DF7 RID: 93687 RVA: 0x00352820 File Offset: 0x00350A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinEquipData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleID != 0)
			{
				this.RoleID = other.RoleID;
			}
			if (other.SkinItemId != 0)
			{
				this.SkinItemId = other.SkinItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016DF8 RID: 93688 RVA: 0x00352870 File Offset: 0x00350A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016DF9 RID: 93689 RVA: 0x0035287C File Offset: 0x00350A7C
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
						this.SkinItemId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleID = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008866 RID: 34918
		private static readonly MessageParser<RoleSkinEquipData> _parser = new MessageParser<RoleSkinEquipData>(() => new RoleSkinEquipData());

		// Token: 0x04008867 RID: 34919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008868 RID: 34920
		public const int RoleIDFieldNumber = 1;

		// Token: 0x04008869 RID: 34921
		private int roleID_;

		// Token: 0x0400886A RID: 34922
		public const int SkinItemIdFieldNumber = 2;

		// Token: 0x0400886B RID: 34923
		private int skinItemId_;
	}
}
