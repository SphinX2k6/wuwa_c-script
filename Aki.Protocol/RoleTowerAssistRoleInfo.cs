using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B7 RID: 4279
	public sealed class RoleTowerAssistRoleInfo : IMessage<RoleTowerAssistRoleInfo>, IMessage, IEquatable<RoleTowerAssistRoleInfo>, IDeepCloneable<RoleTowerAssistRoleInfo>, IBufferMessage
	{
		// Token: 0x06016DD3 RID: 93651 RVA: 0x00352898 File Offset: 0x00350A98
		[NullableContext(1)]
		public static RoleTowerAssistRoleInfo Create()
		{
			return new RoleTowerAssistRoleInfo();
		}

		// Token: 0x17004C9D RID: 19613
		// (get) Token: 0x06016DD4 RID: 93652 RVA: 0x0035289F File Offset: 0x00350A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerAssistRoleInfo> Parser
		{
			get
			{
				return RoleTowerAssistRoleInfo._parser;
			}
		}

		// Token: 0x17004C9E RID: 19614
		// (get) Token: 0x06016DD5 RID: 93653 RVA: 0x003528A6 File Offset: 0x00350AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C9F RID: 19615
		// (get) Token: 0x06016DD6 RID: 93654 RVA: 0x003528A9 File Offset: 0x00350AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerAssistRoleInfo.Descriptor;
			}
		}

		// Token: 0x06016DD7 RID: 93655 RVA: 0x003528B0 File Offset: 0x00350AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerAssistRoleInfo()
		{
		}

		// Token: 0x06016DD8 RID: 93656 RVA: 0x003528B8 File Offset: 0x00350AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerAssistRoleInfo(RoleTowerAssistRoleInfo other) : this()
		{
			this.role_ = ((other.role_ != null) ? other.role_.Clone() : null);
			this.energy_ = other.energy_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016DD9 RID: 93657 RVA: 0x00352904 File Offset: 0x00350B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerAssistRoleInfo Clone()
		{
			return new RoleTowerAssistRoleInfo(this);
		}

		// Token: 0x17004CA0 RID: 19616
		// (get) Token: 0x06016DDA RID: 93658 RVA: 0x0035290C File Offset: 0x00350B0C
		// (set) Token: 0x06016DDB RID: 93659 RVA: 0x00352914 File Offset: 0x00350B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleBrief Role
		{
			get
			{
				return this.role_;
			}
			set
			{
				this.role_ = value;
			}
		}

		// Token: 0x17004CA1 RID: 19617
		// (get) Token: 0x06016DDC RID: 93660 RVA: 0x0035291D File Offset: 0x00350B1D
		// (set) Token: 0x06016DDD RID: 93661 RVA: 0x00352925 File Offset: 0x00350B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Energy
		{
			get
			{
				return this.energy_;
			}
			set
			{
				this.energy_ = value;
			}
		}

		// Token: 0x06016DDE RID: 93662 RVA: 0x0035292E File Offset: 0x00350B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerAssistRoleInfo);
		}

		// Token: 0x06016DDF RID: 93663 RVA: 0x0035293C File Offset: 0x00350B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerAssistRoleInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Role, other.Role) && this.Energy == other.Energy && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016DE0 RID: 93664 RVA: 0x0035298C File Offset: 0x00350B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.role_ != null)
			{
				num ^= this.Role.GetHashCode();
			}
			if (this.Energy != 0)
			{
				num ^= this.Energy.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016DE1 RID: 93665 RVA: 0x003529E1 File Offset: 0x00350BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016DE2 RID: 93666 RVA: 0x003529EE File Offset: 0x00350BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016DE3 RID: 93667 RVA: 0x003529F8 File Offset: 0x00350BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.role_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Role);
			}
			if (this.Energy != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Energy);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016DE4 RID: 93668 RVA: 0x00352A54 File Offset: 0x00350C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.role_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Role);
			}
			if (this.Energy != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Energy);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016DE5 RID: 93669 RVA: 0x00352AAC File Offset: 0x00350CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerAssistRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.role_ != null)
			{
				if (this.role_ == null)
				{
					this.Role = new RoleTowerRoleBrief();
				}
				this.Role.MergeFrom(other.Role);
			}
			if (other.Energy != 0)
			{
				this.Energy = other.Energy;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016DE6 RID: 93670 RVA: 0x00352B14 File Offset: 0x00350D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016DE7 RID: 93671 RVA: 0x00352B20 File Offset: 0x00350D20
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Energy = input.ReadInt32();
					}
				}
				else
				{
					if (this.role_ == null)
					{
						this.Role = new RoleTowerRoleBrief();
					}
					input.ReadMessage(this.Role);
				}
			}
		}

		// Token: 0x040088C6 RID: 35014
		private static readonly MessageParser<RoleTowerAssistRoleInfo> _parser = new MessageParser<RoleTowerAssistRoleInfo>(() => new RoleTowerAssistRoleInfo());

		// Token: 0x040088C7 RID: 35015
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088C8 RID: 35016
		public const int RoleFieldNumber = 1;

		// Token: 0x040088C9 RID: 35017
		private RoleTowerRoleBrief role_;

		// Token: 0x040088CA RID: 35018
		public const int EnergyFieldNumber = 2;

		// Token: 0x040088CB RID: 35019
		private int energy_;
	}
}
