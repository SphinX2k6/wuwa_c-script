using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001373 RID: 4979
	[NetMessage(EMessageId.SwitchRoleResponse)]
	public sealed class SwitchRoleResponse : IMessage<SwitchRoleResponse>, IMessage, IEquatable<SwitchRoleResponse>, IDeepCloneable<SwitchRoleResponse>, IBufferMessage
	{
		// Token: 0x0601A83E RID: 108606 RVA: 0x003DD14F File Offset: 0x003DB34F
		[NullableContext(1)]
		public static SwitchRoleResponse Create()
		{
			return new SwitchRoleResponse();
		}

		// Token: 0x170059C5 RID: 22981
		// (get) Token: 0x0601A83F RID: 108607 RVA: 0x003DD156 File Offset: 0x003DB356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059C6 RID: 22982
		// (get) Token: 0x0601A840 RID: 108608 RVA: 0x003DD159 File Offset: 0x003DB359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchRoleResponse.Descriptor;
			}
		}

		// Token: 0x0601A841 RID: 108609 RVA: 0x003DD160 File Offset: 0x003DB360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleResponse()
		{
		}

		// Token: 0x0601A842 RID: 108610 RVA: 0x003DD168 File Offset: 0x003DB368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleResponse(SwitchRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A843 RID: 108611 RVA: 0x003DD199 File Offset: 0x003DB399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleResponse Clone()
		{
			return new SwitchRoleResponse(this);
		}

		// Token: 0x170059C7 RID: 22983
		// (get) Token: 0x0601A844 RID: 108612 RVA: 0x003DD1A1 File Offset: 0x003DB3A1
		// (set) Token: 0x0601A845 RID: 108613 RVA: 0x003DD1A9 File Offset: 0x003DB3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170059C8 RID: 22984
		// (get) Token: 0x0601A846 RID: 108614 RVA: 0x003DD1B2 File Offset: 0x003DB3B2
		// (set) Token: 0x0601A847 RID: 108615 RVA: 0x003DD1BA File Offset: 0x003DB3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x0601A848 RID: 108616 RVA: 0x003DD1C3 File Offset: 0x003DB3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchRoleResponse);
		}

		// Token: 0x0601A849 RID: 108617 RVA: 0x003DD1D1 File Offset: 0x003DB3D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A84A RID: 108618 RVA: 0x003DD210 File Offset: 0x003DB410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A84B RID: 108619 RVA: 0x003DD26E File Offset: 0x003DB46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A84C RID: 108620 RVA: 0x003DD27B File Offset: 0x003DB47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A84D RID: 108621 RVA: 0x003DD284 File Offset: 0x003DB484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A84E RID: 108622 RVA: 0x003DD2DC File Offset: 0x003DB4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A84F RID: 108623 RVA: 0x003DD334 File Offset: 0x003DB534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A850 RID: 108624 RVA: 0x003DD384 File Offset: 0x003DB584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A851 RID: 108625 RVA: 0x003DD390 File Offset: 0x003DB590
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
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009B79 RID: 39801
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B7A RID: 39802
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04009B7B RID: 39803
		private ErrorCode errorCode_;

		// Token: 0x04009B7C RID: 39804
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04009B7D RID: 39805
		private int roleId_;
	}
}
