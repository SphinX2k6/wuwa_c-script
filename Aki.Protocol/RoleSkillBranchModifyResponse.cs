using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109F RID: 4255
	[NetMessage(EMessageId.RoleSkillBranchModifyResponse)]
	public sealed class RoleSkillBranchModifyResponse : IMessage<RoleSkillBranchModifyResponse>, IMessage, IEquatable<RoleSkillBranchModifyResponse>, IDeepCloneable<RoleSkillBranchModifyResponse>, IBufferMessage
	{
		// Token: 0x06016BF6 RID: 93174 RVA: 0x0034EAC0 File Offset: 0x0034CCC0
		[NullableContext(1)]
		public static RoleSkillBranchModifyResponse Create()
		{
			return new RoleSkillBranchModifyResponse();
		}

		// Token: 0x17004C3C RID: 19516
		// (get) Token: 0x06016BF7 RID: 93175 RVA: 0x0034EAC7 File Offset: 0x0034CCC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C3D RID: 19517
		// (get) Token: 0x06016BF8 RID: 93176 RVA: 0x0034EACA File Offset: 0x0034CCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillBranchModifyResponse.Descriptor;
			}
		}

		// Token: 0x06016BF9 RID: 93177 RVA: 0x0034EAD1 File Offset: 0x0034CCD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyResponse()
		{
		}

		// Token: 0x06016BFA RID: 93178 RVA: 0x0034EAD9 File Offset: 0x0034CCD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyResponse(RoleSkillBranchModifyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016BFB RID: 93179 RVA: 0x0034EAFE File Offset: 0x0034CCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyResponse Clone()
		{
			return new RoleSkillBranchModifyResponse(this);
		}

		// Token: 0x17004C3E RID: 19518
		// (get) Token: 0x06016BFC RID: 93180 RVA: 0x0034EB06 File Offset: 0x0034CD06
		// (set) Token: 0x06016BFD RID: 93181 RVA: 0x0034EB0E File Offset: 0x0034CD0E
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

		// Token: 0x06016BFE RID: 93182 RVA: 0x0034EB17 File Offset: 0x0034CD17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillBranchModifyResponse);
		}

		// Token: 0x06016BFF RID: 93183 RVA: 0x0034EB25 File Offset: 0x0034CD25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillBranchModifyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C00 RID: 93184 RVA: 0x0034EB54 File Offset: 0x0034CD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016C01 RID: 93185 RVA: 0x0034EB99 File Offset: 0x0034CD99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C02 RID: 93186 RVA: 0x0034EBA6 File Offset: 0x0034CDA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C03 RID: 93187 RVA: 0x0034EBAF File Offset: 0x0034CDAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C04 RID: 93188 RVA: 0x0034EBE4 File Offset: 0x0034CDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016C05 RID: 93189 RVA: 0x0034EC22 File Offset: 0x0034CE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillBranchModifyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016C06 RID: 93190 RVA: 0x0034EC53 File Offset: 0x0034CE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C07 RID: 93191 RVA: 0x0034EC5C File Offset: 0x0034CE5C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008842 RID: 34882
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008843 RID: 34883
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04008844 RID: 34884
		private ErrorCode errorCode_;
	}
}
