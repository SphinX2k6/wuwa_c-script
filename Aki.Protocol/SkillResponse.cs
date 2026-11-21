using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200127D RID: 4733
	[NetMessage(EMessageId.SkillResponse)]
	public sealed class SkillResponse : IMessage<SkillResponse>, IMessage, IEquatable<SkillResponse>, IDeepCloneable<SkillResponse>, IBufferMessage
	{
		// Token: 0x06019453 RID: 103507 RVA: 0x003AFCC6 File Offset: 0x003ADEC6
		[NullableContext(1)]
		public static SkillResponse Create()
		{
			return new SkillResponse();
		}

		// Token: 0x1700557A RID: 21882
		// (get) Token: 0x06019454 RID: 103508 RVA: 0x003AFCCD File Offset: 0x003ADECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700557B RID: 21883
		// (get) Token: 0x06019455 RID: 103509 RVA: 0x003AFCD0 File Offset: 0x003ADED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillResponse.Descriptor;
			}
		}

		// Token: 0x06019456 RID: 103510 RVA: 0x003AFCD7 File Offset: 0x003ADED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillResponse()
		{
		}

		// Token: 0x06019457 RID: 103511 RVA: 0x003AFCDF File Offset: 0x003ADEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillResponse(SkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019458 RID: 103512 RVA: 0x003AFD04 File Offset: 0x003ADF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillResponse Clone()
		{
			return new SkillResponse(this);
		}

		// Token: 0x1700557C RID: 21884
		// (get) Token: 0x06019459 RID: 103513 RVA: 0x003AFD0C File Offset: 0x003ADF0C
		// (set) Token: 0x0601945A RID: 103514 RVA: 0x003AFD14 File Offset: 0x003ADF14
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

		// Token: 0x0601945B RID: 103515 RVA: 0x003AFD1D File Offset: 0x003ADF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillResponse);
		}

		// Token: 0x0601945C RID: 103516 RVA: 0x003AFD2B File Offset: 0x003ADF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601945D RID: 103517 RVA: 0x003AFD5C File Offset: 0x003ADF5C
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

		// Token: 0x0601945E RID: 103518 RVA: 0x003AFDA1 File Offset: 0x003ADFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601945F RID: 103519 RVA: 0x003AFDAE File Offset: 0x003ADFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019460 RID: 103520 RVA: 0x003AFDB7 File Offset: 0x003ADFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019461 RID: 103521 RVA: 0x003AFDEC File Offset: 0x003ADFEC
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

		// Token: 0x06019462 RID: 103522 RVA: 0x003AFE2A File Offset: 0x003AE02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillResponse other)
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

		// Token: 0x06019463 RID: 103523 RVA: 0x003AFE5B File Offset: 0x003AE05B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019464 RID: 103524 RVA: 0x003AFE64 File Offset: 0x003AE064
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009595 RID: 38293
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009596 RID: 38294
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04009597 RID: 38295
		private ErrorCode errorCode_;
	}
}
