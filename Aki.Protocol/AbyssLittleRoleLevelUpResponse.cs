using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200002C RID: 44
	[NetMessage(EMessageId.AbyssLittleRoleLevelUpResponse)]
	public sealed class AbyssLittleRoleLevelUpResponse : IMessage<AbyssLittleRoleLevelUpResponse>, IMessage, IEquatable<AbyssLittleRoleLevelUpResponse>, IDeepCloneable<AbyssLittleRoleLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06001203 RID: 4611 RVA: 0x00031DCC File Offset: 0x0002FFCC
		[NullableContext(1)]
		public static AbyssLittleRoleLevelUpResponse Create()
		{
			return new AbyssLittleRoleLevelUpResponse();
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x00031DD3 File Offset: 0x0002FFD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x00031DD6 File Offset: 0x0002FFD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLittleRoleLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00031DDD File Offset: 0x0002FFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpResponse()
		{
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00031DE5 File Offset: 0x0002FFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpResponse(AbyssLittleRoleLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00031E0A File Offset: 0x0003000A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpResponse Clone()
		{
			return new AbyssLittleRoleLevelUpResponse(this);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00031E12 File Offset: 0x00030012
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x00031E1A File Offset: 0x0003001A
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

		// Token: 0x0600120B RID: 4619 RVA: 0x00031E23 File Offset: 0x00030023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLittleRoleLevelUpResponse);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00031E31 File Offset: 0x00030031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLittleRoleLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00031E60 File Offset: 0x00030060
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

		// Token: 0x0600120E RID: 4622 RVA: 0x00031EA5 File Offset: 0x000300A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00031EB2 File Offset: 0x000300B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00031EBB File Offset: 0x000300BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00031EF0 File Offset: 0x000300F0
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

		// Token: 0x06001212 RID: 4626 RVA: 0x00031F2E File Offset: 0x0003012E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssLittleRoleLevelUpResponse other)
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

		// Token: 0x06001213 RID: 4627 RVA: 0x00031F5F File Offset: 0x0003015F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00031F68 File Offset: 0x00030168
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001FAC RID: 8108
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FAD RID: 8109
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04001FAE RID: 8110
		private ErrorCode errorCode_;
	}
}
