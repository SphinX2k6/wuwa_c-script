using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0B RID: 3083
	[NetMessage(EMessageId.PbOverRoleResponse)]
	public sealed class PbOverRoleResponse : IMessage<PbOverRoleResponse>, IMessage, IEquatable<PbOverRoleResponse>, IDeepCloneable<PbOverRoleResponse>, IBufferMessage
	{
		// Token: 0x06010BD0 RID: 68560 RVA: 0x00273891 File Offset: 0x00271A91
		[NullableContext(1)]
		public static PbOverRoleResponse Create()
		{
			return new PbOverRoleResponse();
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x06010BD1 RID: 68561 RVA: 0x00273898 File Offset: 0x00271A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x06010BD2 RID: 68562 RVA: 0x0027389B File Offset: 0x00271A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbOverRoleResponse.Descriptor;
			}
		}

		// Token: 0x06010BD3 RID: 68563 RVA: 0x002738A2 File Offset: 0x00271AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleResponse()
		{
		}

		// Token: 0x06010BD4 RID: 68564 RVA: 0x002738AA File Offset: 0x00271AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleResponse(PbOverRoleResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.breakthrough_ = other.breakthrough_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010BD5 RID: 68565 RVA: 0x002738E7 File Offset: 0x00271AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleResponse Clone()
		{
			return new PbOverRoleResponse(this);
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x06010BD6 RID: 68566 RVA: 0x002738EF File Offset: 0x00271AEF
		// (set) Token: 0x06010BD7 RID: 68567 RVA: 0x002738F7 File Offset: 0x00271AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x06010BD8 RID: 68568 RVA: 0x00273900 File Offset: 0x00271B00
		// (set) Token: 0x06010BD9 RID: 68569 RVA: 0x00273908 File Offset: 0x00271B08
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

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x06010BDA RID: 68570 RVA: 0x00273911 File Offset: 0x00271B11
		// (set) Token: 0x06010BDB RID: 68571 RVA: 0x00273919 File Offset: 0x00271B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Breakthrough
		{
			get
			{
				return this.breakthrough_;
			}
			set
			{
				this.breakthrough_ = value;
			}
		}

		// Token: 0x06010BDC RID: 68572 RVA: 0x00273922 File Offset: 0x00271B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbOverRoleResponse);
		}

		// Token: 0x06010BDD RID: 68573 RVA: 0x00273930 File Offset: 0x00271B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbOverRoleResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && this.Breakthrough == other.Breakthrough && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010BDE RID: 68574 RVA: 0x0027398C File Offset: 0x00271B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Breakthrough != 0)
			{
				num ^= this.Breakthrough.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010BDF RID: 68575 RVA: 0x00273A03 File Offset: 0x00271C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010BE0 RID: 68576 RVA: 0x00273A10 File Offset: 0x00271C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010BE1 RID: 68577 RVA: 0x00273A1C File Offset: 0x00271C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Breakthrough != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Breakthrough);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010BE2 RID: 68578 RVA: 0x00273A94 File Offset: 0x00271C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Breakthrough != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Breakthrough);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010BE3 RID: 68579 RVA: 0x00273B04 File Offset: 0x00271D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbOverRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Breakthrough != 0)
			{
				this.Breakthrough = other.Breakthrough;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010BE4 RID: 68580 RVA: 0x00273B68 File Offset: 0x00271D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010BE5 RID: 68581 RVA: 0x00273B74 File Offset: 0x00271D74
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Code = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.Breakthrough = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A5C RID: 27228
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A5D RID: 27229
		public const int CodeFieldNumber = 12;

		// Token: 0x04006A5E RID: 27230
		private ErrorCode code_;

		// Token: 0x04006A5F RID: 27231
		public const int RoleIdFieldNumber = 5;

		// Token: 0x04006A60 RID: 27232
		private int roleId_;

		// Token: 0x04006A61 RID: 27233
		public const int BreakthroughFieldNumber = 2;

		// Token: 0x04006A62 RID: 27234
		private int breakthrough_;
	}
}
