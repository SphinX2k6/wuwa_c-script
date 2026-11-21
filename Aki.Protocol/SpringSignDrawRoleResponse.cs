using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012EF RID: 4847
	[NetMessage(EMessageId.SpringSignDrawRoleResponse)]
	public sealed class SpringSignDrawRoleResponse : IMessage<SpringSignDrawRoleResponse>, IMessage, IEquatable<SpringSignDrawRoleResponse>, IDeepCloneable<SpringSignDrawRoleResponse>, IBufferMessage
	{
		// Token: 0x06019DCC RID: 105932 RVA: 0x003C5D4A File Offset: 0x003C3F4A
		[NullableContext(1)]
		public static SpringSignDrawRoleResponse Create()
		{
			return new SpringSignDrawRoleResponse();
		}

		// Token: 0x17005799 RID: 22425
		// (get) Token: 0x06019DCD RID: 105933 RVA: 0x003C5D51 File Offset: 0x003C3F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700579A RID: 22426
		// (get) Token: 0x06019DCE RID: 105934 RVA: 0x003C5D54 File Offset: 0x003C3F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignDrawRoleResponse.Descriptor;
			}
		}

		// Token: 0x06019DCF RID: 105935 RVA: 0x003C5D5B File Offset: 0x003C3F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleResponse()
		{
		}

		// Token: 0x06019DD0 RID: 105936 RVA: 0x003C5D63 File Offset: 0x003C3F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleResponse(SpringSignDrawRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.drawId_ = other.drawId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019DD1 RID: 105937 RVA: 0x003C5D94 File Offset: 0x003C3F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignDrawRoleResponse Clone()
		{
			return new SpringSignDrawRoleResponse(this);
		}

		// Token: 0x1700579B RID: 22427
		// (get) Token: 0x06019DD2 RID: 105938 RVA: 0x003C5D9C File Offset: 0x003C3F9C
		// (set) Token: 0x06019DD3 RID: 105939 RVA: 0x003C5DA4 File Offset: 0x003C3FA4
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

		// Token: 0x1700579C RID: 22428
		// (get) Token: 0x06019DD4 RID: 105940 RVA: 0x003C5DAD File Offset: 0x003C3FAD
		// (set) Token: 0x06019DD5 RID: 105941 RVA: 0x003C5DB5 File Offset: 0x003C3FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DrawId
		{
			get
			{
				return this.drawId_;
			}
			set
			{
				this.drawId_ = value;
			}
		}

		// Token: 0x06019DD6 RID: 105942 RVA: 0x003C5DBE File Offset: 0x003C3FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignDrawRoleResponse);
		}

		// Token: 0x06019DD7 RID: 105943 RVA: 0x003C5DCC File Offset: 0x003C3FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignDrawRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.DrawId == other.DrawId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019DD8 RID: 105944 RVA: 0x003C5E0C File Offset: 0x003C400C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.DrawId != 0)
			{
				num ^= this.DrawId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019DD9 RID: 105945 RVA: 0x003C5E6A File Offset: 0x003C406A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019DDA RID: 105946 RVA: 0x003C5E77 File Offset: 0x003C4077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019DDB RID: 105947 RVA: 0x003C5E80 File Offset: 0x003C4080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DrawId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.DrawId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019DDC RID: 105948 RVA: 0x003C5EDC File Offset: 0x003C40DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.DrawId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DrawId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019DDD RID: 105949 RVA: 0x003C5F34 File Offset: 0x003C4134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignDrawRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.DrawId != 0)
			{
				this.DrawId = other.DrawId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019DDE RID: 105950 RVA: 0x003C5F84 File Offset: 0x003C4184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019DDF RID: 105951 RVA: 0x003C5F90 File Offset: 0x003C4190
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
				if (num != 56U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.DrawId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009893 RID: 39059
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009894 RID: 39060
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04009895 RID: 39061
		private ErrorCode errorCode_;

		// Token: 0x04009896 RID: 39062
		public const int DrawIdFieldNumber = 7;

		// Token: 0x04009897 RID: 39063
		private int drawId_;
	}
}
