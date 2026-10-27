using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAE RID: 3246
	[NetMessage(EMessageId.PhantomBattleRoundOverResponse)]
	public sealed class PhantomBattleRoundOverResponse : IMessage<PhantomBattleRoundOverResponse>, IMessage, IEquatable<PhantomBattleRoundOverResponse>, IDeepCloneable<PhantomBattleRoundOverResponse>, IBufferMessage
	{
		// Token: 0x0601195C RID: 72028 RVA: 0x002934D2 File Offset: 0x002916D2
		[NullableContext(1)]
		public static PhantomBattleRoundOverResponse Create()
		{
			return new PhantomBattleRoundOverResponse();
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x0601195D RID: 72029 RVA: 0x002934D9 File Offset: 0x002916D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A43 RID: 14915
		// (get) Token: 0x0601195E RID: 72030 RVA: 0x002934DC File Offset: 0x002916DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoundOverResponse.Descriptor;
			}
		}

		// Token: 0x0601195F RID: 72031 RVA: 0x002934E3 File Offset: 0x002916E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverResponse()
		{
		}

		// Token: 0x06011960 RID: 72032 RVA: 0x002934EB File Offset: 0x002916EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverResponse(PhantomBattleRoundOverResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011961 RID: 72033 RVA: 0x00293510 File Offset: 0x00291710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverResponse Clone()
		{
			return new PhantomBattleRoundOverResponse(this);
		}

		// Token: 0x17003A44 RID: 14916
		// (get) Token: 0x06011962 RID: 72034 RVA: 0x00293518 File Offset: 0x00291718
		// (set) Token: 0x06011963 RID: 72035 RVA: 0x00293520 File Offset: 0x00291720
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

		// Token: 0x06011964 RID: 72036 RVA: 0x00293529 File Offset: 0x00291729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoundOverResponse);
		}

		// Token: 0x06011965 RID: 72037 RVA: 0x00293537 File Offset: 0x00291737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoundOverResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011966 RID: 72038 RVA: 0x00293568 File Offset: 0x00291768
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

		// Token: 0x06011967 RID: 72039 RVA: 0x002935AD File Offset: 0x002917AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011968 RID: 72040 RVA: 0x002935BA File Offset: 0x002917BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011969 RID: 72041 RVA: 0x002935C3 File Offset: 0x002917C3
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

		// Token: 0x0601196A RID: 72042 RVA: 0x002935F8 File Offset: 0x002917F8
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

		// Token: 0x0601196B RID: 72043 RVA: 0x00293636 File Offset: 0x00291836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoundOverResponse other)
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

		// Token: 0x0601196C RID: 72044 RVA: 0x00293667 File Offset: 0x00291867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601196D RID: 72045 RVA: 0x00293670 File Offset: 0x00291870
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

		// Token: 0x04006ECA RID: 28362
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ECB RID: 28363
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04006ECC RID: 28364
		private ErrorCode errorCode_;
	}
}
