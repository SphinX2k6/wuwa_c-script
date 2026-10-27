using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0B RID: 3851
	[NetMessage(EMessageId.RemoveSummonEntityResponse)]
	public sealed class RemoveSummonEntityResponse : IMessage<RemoveSummonEntityResponse>, IMessage, IEquatable<RemoveSummonEntityResponse>, IDeepCloneable<RemoveSummonEntityResponse>, IBufferMessage
	{
		// Token: 0x060149FA RID: 84474 RVA: 0x002FEABC File Offset: 0x002FCCBC
		[NullableContext(1)]
		public static RemoveSummonEntityResponse Create()
		{
			return new RemoveSummonEntityResponse();
		}

		// Token: 0x17004492 RID: 17554
		// (get) Token: 0x060149FB RID: 84475 RVA: 0x002FEAC3 File Offset: 0x002FCCC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004493 RID: 17555
		// (get) Token: 0x060149FC RID: 84476 RVA: 0x002FEAC6 File Offset: 0x002FCCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveSummonEntityResponse.Descriptor;
			}
		}

		// Token: 0x060149FD RID: 84477 RVA: 0x002FEACD File Offset: 0x002FCCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityResponse()
		{
		}

		// Token: 0x060149FE RID: 84478 RVA: 0x002FEAD5 File Offset: 0x002FCCD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityResponse(RemoveSummonEntityResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060149FF RID: 84479 RVA: 0x002FEAFA File Offset: 0x002FCCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityResponse Clone()
		{
			return new RemoveSummonEntityResponse(this);
		}

		// Token: 0x17004494 RID: 17556
		// (get) Token: 0x06014A00 RID: 84480 RVA: 0x002FEB02 File Offset: 0x002FCD02
		// (set) Token: 0x06014A01 RID: 84481 RVA: 0x002FEB0A File Offset: 0x002FCD0A
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

		// Token: 0x06014A02 RID: 84482 RVA: 0x002FEB13 File Offset: 0x002FCD13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveSummonEntityResponse);
		}

		// Token: 0x06014A03 RID: 84483 RVA: 0x002FEB21 File Offset: 0x002FCD21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveSummonEntityResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A04 RID: 84484 RVA: 0x002FEB50 File Offset: 0x002FCD50
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

		// Token: 0x06014A05 RID: 84485 RVA: 0x002FEB95 File Offset: 0x002FCD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A06 RID: 84486 RVA: 0x002FEBA2 File Offset: 0x002FCDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A07 RID: 84487 RVA: 0x002FEBAB File Offset: 0x002FCDAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A08 RID: 84488 RVA: 0x002FEBE0 File Offset: 0x002FCDE0
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

		// Token: 0x06014A09 RID: 84489 RVA: 0x002FEC1E File Offset: 0x002FCE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveSummonEntityResponse other)
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

		// Token: 0x06014A0A RID: 84490 RVA: 0x002FEC4F File Offset: 0x002FCE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A0B RID: 84491 RVA: 0x002FEC58 File Offset: 0x002FCE58
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007CD4 RID: 31956
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CD5 RID: 31957
		public const int ErrCodeFieldNumber = 6;

		// Token: 0x04007CD6 RID: 31958
		private ErrorCode errCode_;
	}
}
