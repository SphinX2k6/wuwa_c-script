using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AC RID: 4268
	public sealed class RoleSkinEquipData : IMessage<RoleSkinEquipData>, IMessage, IEquatable<RoleSkinEquipData>, IDeepCloneable<RoleSkinEquipData>, IBufferMessage
	{
		// Token: 0x06016D00 RID: 93440 RVA: 0x00350F5D File Offset: 0x0034F15D
		[NullableContext(1)]
		public static RoleSkinEquipData Create()
		{
			return new RoleSkinEquipData();
		}

		// Token: 0x17004C74 RID: 19572
		// (get) Token: 0x06016D01 RID: 93441 RVA: 0x00350F64 File Offset: 0x0034F164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleSkinEquipData> Parser
		{
			get
			{
				return RoleSkinEquipData._parser;
			}
		}

		// Token: 0x17004C75 RID: 19573
		// (get) Token: 0x06016D02 RID: 93442 RVA: 0x00350F6B File Offset: 0x0034F16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C76 RID: 19574
		// (get) Token: 0x06016D03 RID: 93443 RVA: 0x00350F6E File Offset: 0x0034F16E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinEquipData.Descriptor;
			}
		}

		// Token: 0x06016D04 RID: 93444 RVA: 0x00350F75 File Offset: 0x0034F175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinEquipData()
		{
		}

		// Token: 0x06016D05 RID: 93445 RVA: 0x00350F7D File Offset: 0x0034F17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinEquipData(RoleSkinEquipData other) : this()
		{
			this.roleID_ = other.roleID_;
			this.skinItemId_ = other.skinItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D06 RID: 93446 RVA: 0x00350FAE File Offset: 0x0034F1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinEquipData Clone()
		{
			return new RoleSkinEquipData(this);
		}

		// Token: 0x17004C77 RID: 19575
		// (get) Token: 0x06016D07 RID: 93447 RVA: 0x00350FB6 File Offset: 0x0034F1B6
		// (set) Token: 0x06016D08 RID: 93448 RVA: 0x00350FBE File Offset: 0x0034F1BE
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

		// Token: 0x17004C78 RID: 19576
		// (get) Token: 0x06016D09 RID: 93449 RVA: 0x00350FC7 File Offset: 0x0034F1C7
		// (set) Token: 0x06016D0A RID: 93450 RVA: 0x00350FCF File Offset: 0x0034F1CF
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

		// Token: 0x06016D0B RID: 93451 RVA: 0x00350FD8 File Offset: 0x0034F1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinEquipData);
		}

		// Token: 0x06016D0C RID: 93452 RVA: 0x00350FE6 File Offset: 0x0034F1E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinEquipData other)
		{
			return other != null && (other == this || (this.RoleID == other.RoleID && this.SkinItemId == other.SkinItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D0D RID: 93453 RVA: 0x00351024 File Offset: 0x0034F224
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

		// Token: 0x06016D0E RID: 93454 RVA: 0x0035107C File Offset: 0x0034F27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D0F RID: 93455 RVA: 0x00351089 File Offset: 0x0034F289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D10 RID: 93456 RVA: 0x00351094 File Offset: 0x0034F294
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

		// Token: 0x06016D11 RID: 93457 RVA: 0x003510EC File Offset: 0x0034F2EC
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

		// Token: 0x06016D12 RID: 93458 RVA: 0x00351144 File Offset: 0x0034F344
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

		// Token: 0x06016D13 RID: 93459 RVA: 0x00351194 File Offset: 0x0034F394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D14 RID: 93460 RVA: 0x003511A0 File Offset: 0x0034F3A0
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

		// Token: 0x04008890 RID: 34960
		private static readonly MessageParser<RoleSkinEquipData> _parser = new MessageParser<RoleSkinEquipData>(() => new RoleSkinEquipData());

		// Token: 0x04008891 RID: 34961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008892 RID: 34962
		public const int RoleIDFieldNumber = 1;

		// Token: 0x04008893 RID: 34963
		private int roleID_;

		// Token: 0x04008894 RID: 34964
		public const int SkinItemIdFieldNumber = 2;

		// Token: 0x04008895 RID: 34965
		private int skinItemId_;
	}
}
