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
		// Token: 0x0600122E RID: 4654 RVA: 0x00032380 File Offset: 0x00030580
		[NullableContext(1)]
		public static AbyssLittleRoleLevelUpResponse Create()
		{
			return new AbyssLittleRoleLevelUpResponse();
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00032387 File Offset: 0x00030587
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
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x0003238A File Offset: 0x0003058A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLittleRoleLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00032391 File Offset: 0x00030591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpResponse()
		{
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00032399 File Offset: 0x00030599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpResponse(AbyssLittleRoleLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x000323BE File Offset: 0x000305BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpResponse Clone()
		{
			return new AbyssLittleRoleLevelUpResponse(this);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x000323C6 File Offset: 0x000305C6
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x000323CE File Offset: 0x000305CE
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

		// Token: 0x06001236 RID: 4662 RVA: 0x000323D7 File Offset: 0x000305D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLittleRoleLevelUpResponse);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000323E5 File Offset: 0x000305E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLittleRoleLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00032414 File Offset: 0x00030614
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

		// Token: 0x06001239 RID: 4665 RVA: 0x00032459 File Offset: 0x00030659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00032466 File Offset: 0x00030666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0003246F File Offset: 0x0003066F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000324A4 File Offset: 0x000306A4
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

		// Token: 0x0600123D RID: 4669 RVA: 0x000324E2 File Offset: 0x000306E2
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

		// Token: 0x0600123E RID: 4670 RVA: 0x00032513 File Offset: 0x00030713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0003251C File Offset: 0x0003071C
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002002 RID: 8194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002003 RID: 8195
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04002004 RID: 8196
		private ErrorCode errorCode_;
	}
}
