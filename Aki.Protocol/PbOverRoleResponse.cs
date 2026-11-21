using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFB RID: 3067
	[NetMessage(EMessageId.PbOverRoleResponse)]
	public sealed class PbOverRoleResponse : IMessage<PbOverRoleResponse>, IMessage, IEquatable<PbOverRoleResponse>, IDeepCloneable<PbOverRoleResponse>, IBufferMessage
	{
		// Token: 0x06010AD0 RID: 68304 RVA: 0x00271B29 File Offset: 0x0026FD29
		[NullableContext(1)]
		public static PbOverRoleResponse Create()
		{
			return new PbOverRoleResponse();
		}

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x06010AD1 RID: 68305 RVA: 0x00271B30 File Offset: 0x0026FD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x06010AD2 RID: 68306 RVA: 0x00271B33 File Offset: 0x0026FD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbOverRoleResponse.Descriptor;
			}
		}

		// Token: 0x06010AD3 RID: 68307 RVA: 0x00271B3A File Offset: 0x0026FD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleResponse()
		{
		}

		// Token: 0x06010AD4 RID: 68308 RVA: 0x00271B42 File Offset: 0x0026FD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleResponse(PbOverRoleResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_;
			this.breakthrough_ = other.breakthrough_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010AD5 RID: 68309 RVA: 0x00271B7F File Offset: 0x0026FD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbOverRoleResponse Clone()
		{
			return new PbOverRoleResponse(this);
		}

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x06010AD6 RID: 68310 RVA: 0x00271B87 File Offset: 0x0026FD87
		// (set) Token: 0x06010AD7 RID: 68311 RVA: 0x00271B8F File Offset: 0x0026FD8F
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

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x06010AD8 RID: 68312 RVA: 0x00271B98 File Offset: 0x0026FD98
		// (set) Token: 0x06010AD9 RID: 68313 RVA: 0x00271BA0 File Offset: 0x0026FDA0
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

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x06010ADA RID: 68314 RVA: 0x00271BA9 File Offset: 0x0026FDA9
		// (set) Token: 0x06010ADB RID: 68315 RVA: 0x00271BB1 File Offset: 0x0026FDB1
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

		// Token: 0x06010ADC RID: 68316 RVA: 0x00271BBA File Offset: 0x0026FDBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbOverRoleResponse);
		}

		// Token: 0x06010ADD RID: 68317 RVA: 0x00271BC8 File Offset: 0x0026FDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbOverRoleResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.RoleId == other.RoleId && this.Breakthrough == other.Breakthrough && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010ADE RID: 68318 RVA: 0x00271C24 File Offset: 0x0026FE24
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

		// Token: 0x06010ADF RID: 68319 RVA: 0x00271C9B File Offset: 0x0026FE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010AE0 RID: 68320 RVA: 0x00271CA8 File Offset: 0x0026FEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010AE1 RID: 68321 RVA: 0x00271CB4 File Offset: 0x0026FEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Breakthrough != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Breakthrough);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010AE2 RID: 68322 RVA: 0x00271D28 File Offset: 0x0026FF28
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

		// Token: 0x06010AE3 RID: 68323 RVA: 0x00271D98 File Offset: 0x0026FF98
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

		// Token: 0x06010AE4 RID: 68324 RVA: 0x00271DFC File Offset: 0x0026FFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010AE5 RID: 68325 RVA: 0x00271E08 File Offset: 0x00270008
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
					if (num != 48U)
					{
						if (num != 72U)
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

		// Token: 0x04006A70 RID: 27248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A71 RID: 27249
		public const int CodeFieldNumber = 9;

		// Token: 0x04006A72 RID: 27250
		private ErrorCode code_;

		// Token: 0x04006A73 RID: 27251
		public const int RoleIdFieldNumber = 6;

		// Token: 0x04006A74 RID: 27252
		private int roleId_;

		// Token: 0x04006A75 RID: 27253
		public const int BreakthroughFieldNumber = 1;

		// Token: 0x04006A76 RID: 27254
		private int breakthrough_;
	}
}
