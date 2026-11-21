using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BB RID: 1211
	public sealed class EntrustRoleInfo : IMessage<EntrustRoleInfo>, IMessage, IEquatable<EntrustRoleInfo>, IDeepCloneable<EntrustRoleInfo>, IBufferMessage
	{
		// Token: 0x060073A4 RID: 29604 RVA: 0x0011BF72 File Offset: 0x0011A172
		[NullableContext(1)]
		public static EntrustRoleInfo Create()
		{
			return new EntrustRoleInfo();
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x060073A5 RID: 29605 RVA: 0x0011BF79 File Offset: 0x0011A179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntrustRoleInfo> Parser
		{
			get
			{
				return EntrustRoleInfo._parser;
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x060073A6 RID: 29606 RVA: 0x0011BF80 File Offset: 0x0011A180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x060073A7 RID: 29607 RVA: 0x0011BF83 File Offset: 0x0011A183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntrustRoleInfo.Descriptor;
			}
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x0011BF8A File Offset: 0x0011A18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustRoleInfo()
		{
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x0011BF94 File Offset: 0x0011A194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustRoleInfo(EntrustRoleInfo other) : this()
		{
			this.level_ = other.level_;
			this.roleAttr_ = ((other.roleAttr_ != null) ? other.roleAttr_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x0011BFE0 File Offset: 0x0011A1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustRoleInfo Clone()
		{
			return new EntrustRoleInfo(this);
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x060073AB RID: 29611 RVA: 0x0011BFE8 File Offset: 0x0011A1E8
		// (set) Token: 0x060073AC RID: 29612 RVA: 0x0011BFF0 File Offset: 0x0011A1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x060073AD RID: 29613 RVA: 0x0011BFF9 File Offset: 0x0011A1F9
		// (set) Token: 0x060073AE RID: 29614 RVA: 0x0011C001 File Offset: 0x0011A201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleProperSettle RoleAttr
		{
			get
			{
				return this.roleAttr_;
			}
			set
			{
				this.roleAttr_ = value;
			}
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x0011C00A File Offset: 0x0011A20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntrustRoleInfo);
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x0011C018 File Offset: 0x0011A218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntrustRoleInfo other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this.RoleAttr, other.RoleAttr) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x0011C068 File Offset: 0x0011A268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.roleAttr_ != null)
			{
				num ^= this.RoleAttr.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x0011C0BD File Offset: 0x0011A2BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x0011C0CA File Offset: 0x0011A2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x0011C0D4 File Offset: 0x0011A2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this.roleAttr_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RoleAttr);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x0011C12C File Offset: 0x0011A32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.roleAttr_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleAttr);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x0011C184 File Offset: 0x0011A384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntrustRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.roleAttr_ != null)
			{
				if (this.roleAttr_ == null)
				{
					this.RoleAttr = new RoleProperSettle();
				}
				this.RoleAttr.MergeFrom(other.RoleAttr);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x0011C1EC File Offset: 0x0011A3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x0011C1F8 File Offset: 0x0011A3F8
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.roleAttr_ == null)
						{
							this.RoleAttr = new RoleProperSettle();
						}
						input.ReadMessage(this.RoleAttr);
					}
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003D8E RID: 15758
		private static readonly MessageParser<EntrustRoleInfo> _parser = new MessageParser<EntrustRoleInfo>(() => new EntrustRoleInfo());

		// Token: 0x04003D8F RID: 15759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D90 RID: 15760
		public const int LevelFieldNumber = 1;

		// Token: 0x04003D91 RID: 15761
		private int level_;

		// Token: 0x04003D92 RID: 15762
		public const int RoleAttrFieldNumber = 2;

		// Token: 0x04003D93 RID: 15763
		private RoleProperSettle roleAttr_;
	}
}
