using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A40 RID: 2624
	[NetMessage(EMessageId.MotorFightEnterSubLevelResponse)]
	public sealed class MotorFightEnterSubLevelResponse : IMessage<MotorFightEnterSubLevelResponse>, IMessage, IEquatable<MotorFightEnterSubLevelResponse>, IDeepCloneable<MotorFightEnterSubLevelResponse>, IBufferMessage
	{
		// Token: 0x0600E519 RID: 58649 RVA: 0x00217E69 File Offset: 0x00216069
		[NullableContext(1)]
		public static MotorFightEnterSubLevelResponse Create()
		{
			return new MotorFightEnterSubLevelResponse();
		}

		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x0600E51A RID: 58650 RVA: 0x00217E70 File Offset: 0x00216070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x0600E51B RID: 58651 RVA: 0x00217E73 File Offset: 0x00216073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightEnterSubLevelResponse.Descriptor;
			}
		}

		// Token: 0x0600E51C RID: 58652 RVA: 0x00217E7A File Offset: 0x0021607A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelResponse()
		{
		}

		// Token: 0x0600E51D RID: 58653 RVA: 0x00217E82 File Offset: 0x00216082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelResponse(MotorFightEnterSubLevelResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E51E RID: 58654 RVA: 0x00217EA7 File Offset: 0x002160A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelResponse Clone()
		{
			return new MotorFightEnterSubLevelResponse(this);
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x0600E51F RID: 58655 RVA: 0x00217EAF File Offset: 0x002160AF
		// (set) Token: 0x0600E520 RID: 58656 RVA: 0x00217EB7 File Offset: 0x002160B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600E521 RID: 58657 RVA: 0x00217EC0 File Offset: 0x002160C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightEnterSubLevelResponse);
		}

		// Token: 0x0600E522 RID: 58658 RVA: 0x00217ECE File Offset: 0x002160CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightEnterSubLevelResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E523 RID: 58659 RVA: 0x00217EFC File Offset: 0x002160FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E524 RID: 58660 RVA: 0x00217F41 File Offset: 0x00216141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E525 RID: 58661 RVA: 0x00217F4E File Offset: 0x0021614E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E526 RID: 58662 RVA: 0x00217F57 File Offset: 0x00216157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E527 RID: 58663 RVA: 0x00217F8C File Offset: 0x0021618C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E528 RID: 58664 RVA: 0x00217FCA File Offset: 0x002161CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightEnterSubLevelResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E529 RID: 58665 RVA: 0x00217FFB File Offset: 0x002161FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E52A RID: 58666 RVA: 0x00218004 File Offset: 0x00216204
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005DA8 RID: 23976
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DA9 RID: 23977
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x04005DAA RID: 23978
		private ErrorCode errCode_;
	}
}
