using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AF RID: 4271
	[NetMessage(EMessageId.RoleSkillBranchModifyResponse)]
	public sealed class RoleSkillBranchModifyResponse : IMessage<RoleSkillBranchModifyResponse>, IMessage, IEquatable<RoleSkillBranchModifyResponse>, IDeepCloneable<RoleSkillBranchModifyResponse>, IBufferMessage
	{
		// Token: 0x06016CDB RID: 93403 RVA: 0x0035019C File Offset: 0x0034E39C
		[NullableContext(1)]
		public static RoleSkillBranchModifyResponse Create()
		{
			return new RoleSkillBranchModifyResponse();
		}

		// Token: 0x17004C66 RID: 19558
		// (get) Token: 0x06016CDC RID: 93404 RVA: 0x003501A3 File Offset: 0x0034E3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C67 RID: 19559
		// (get) Token: 0x06016CDD RID: 93405 RVA: 0x003501A6 File Offset: 0x0034E3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillBranchModifyResponse.Descriptor;
			}
		}

		// Token: 0x06016CDE RID: 93406 RVA: 0x003501AD File Offset: 0x0034E3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyResponse()
		{
		}

		// Token: 0x06016CDF RID: 93407 RVA: 0x003501B5 File Offset: 0x0034E3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyResponse(RoleSkillBranchModifyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016CE0 RID: 93408 RVA: 0x003501DA File Offset: 0x0034E3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillBranchModifyResponse Clone()
		{
			return new RoleSkillBranchModifyResponse(this);
		}

		// Token: 0x17004C68 RID: 19560
		// (get) Token: 0x06016CE1 RID: 93409 RVA: 0x003501E2 File Offset: 0x0034E3E2
		// (set) Token: 0x06016CE2 RID: 93410 RVA: 0x003501EA File Offset: 0x0034E3EA
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

		// Token: 0x06016CE3 RID: 93411 RVA: 0x003501F3 File Offset: 0x0034E3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillBranchModifyResponse);
		}

		// Token: 0x06016CE4 RID: 93412 RVA: 0x00350201 File Offset: 0x0034E401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillBranchModifyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016CE5 RID: 93413 RVA: 0x00350230 File Offset: 0x0034E430
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

		// Token: 0x06016CE6 RID: 93414 RVA: 0x00350275 File Offset: 0x0034E475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016CE7 RID: 93415 RVA: 0x00350282 File Offset: 0x0034E482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016CE8 RID: 93416 RVA: 0x0035028B File Offset: 0x0034E48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016CE9 RID: 93417 RVA: 0x003502C0 File Offset: 0x0034E4C0
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

		// Token: 0x06016CEA RID: 93418 RVA: 0x003502FE File Offset: 0x0034E4FE
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

		// Token: 0x06016CEB RID: 93419 RVA: 0x0035032F File Offset: 0x0034E52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016CEC RID: 93420 RVA: 0x00350338 File Offset: 0x0034E538
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008818 RID: 34840
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008819 RID: 34841
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400881A RID: 34842
		private ErrorCode errorCode_;
	}
}
