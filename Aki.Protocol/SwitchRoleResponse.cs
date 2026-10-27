using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001306 RID: 4870
	[NetMessage(EMessageId.SwitchRoleResponse)]
	public sealed class SwitchRoleResponse : IMessage<SwitchRoleResponse>, IMessage, IEquatable<SwitchRoleResponse>, IDeepCloneable<SwitchRoleResponse>, IBufferMessage
	{
		// Token: 0x06019E2E RID: 106030 RVA: 0x003C2E97 File Offset: 0x003C1097
		[NullableContext(1)]
		public static SwitchRoleResponse Create()
		{
			return new SwitchRoleResponse();
		}

		// Token: 0x1700574B RID: 22347
		// (get) Token: 0x06019E2F RID: 106031 RVA: 0x003C2E9E File Offset: 0x003C109E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700574C RID: 22348
		// (get) Token: 0x06019E30 RID: 106032 RVA: 0x003C2EA1 File Offset: 0x003C10A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchRoleResponse.Descriptor;
			}
		}

		// Token: 0x06019E31 RID: 106033 RVA: 0x003C2EA8 File Offset: 0x003C10A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleResponse()
		{
		}

		// Token: 0x06019E32 RID: 106034 RVA: 0x003C2EB0 File Offset: 0x003C10B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleResponse(SwitchRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E33 RID: 106035 RVA: 0x003C2EE1 File Offset: 0x003C10E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleResponse Clone()
		{
			return new SwitchRoleResponse(this);
		}

		// Token: 0x1700574D RID: 22349
		// (get) Token: 0x06019E34 RID: 106036 RVA: 0x003C2EE9 File Offset: 0x003C10E9
		// (set) Token: 0x06019E35 RID: 106037 RVA: 0x003C2EF1 File Offset: 0x003C10F1
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

		// Token: 0x1700574E RID: 22350
		// (get) Token: 0x06019E36 RID: 106038 RVA: 0x003C2EFA File Offset: 0x003C10FA
		// (set) Token: 0x06019E37 RID: 106039 RVA: 0x003C2F02 File Offset: 0x003C1102
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

		// Token: 0x06019E38 RID: 106040 RVA: 0x003C2F0B File Offset: 0x003C110B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchRoleResponse);
		}

		// Token: 0x06019E39 RID: 106041 RVA: 0x003C2F19 File Offset: 0x003C1119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E3A RID: 106042 RVA: 0x003C2F58 File Offset: 0x003C1158
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

		// Token: 0x06019E3B RID: 106043 RVA: 0x003C2FB6 File Offset: 0x003C11B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E3C RID: 106044 RVA: 0x003C2FC3 File Offset: 0x003C11C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E3D RID: 106045 RVA: 0x003C2FCC File Offset: 0x003C11CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E3E RID: 106046 RVA: 0x003C3028 File Offset: 0x003C1228
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

		// Token: 0x06019E3F RID: 106047 RVA: 0x003C3080 File Offset: 0x003C1280
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

		// Token: 0x06019E40 RID: 106048 RVA: 0x003C30D0 File Offset: 0x003C12D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E41 RID: 106049 RVA: 0x003C30DC File Offset: 0x003C12DC
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
				if (num != 48U)
				{
					if (num != 104U)
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

		// Token: 0x04009757 RID: 38743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009758 RID: 38744
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009759 RID: 38745
		private ErrorCode errorCode_;

		// Token: 0x0400975A RID: 38746
		public const int RoleIdFieldNumber = 13;

		// Token: 0x0400975B RID: 38747
		private int roleId_;
	}
}
