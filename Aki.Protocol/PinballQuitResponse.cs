using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D44 RID: 3396
	[NetMessage(EMessageId.PinballQuitResponse)]
	public sealed class PinballQuitResponse : IMessage<PinballQuitResponse>, IMessage, IEquatable<PinballQuitResponse>, IDeepCloneable<PinballQuitResponse>, IBufferMessage
	{
		// Token: 0x0601257A RID: 75130 RVA: 0x002ADC0F File Offset: 0x002ABE0F
		[NullableContext(1)]
		public static PinballQuitResponse Create()
		{
			return new PinballQuitResponse();
		}

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x0601257B RID: 75131 RVA: 0x002ADC16 File Offset: 0x002ABE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x0601257C RID: 75132 RVA: 0x002ADC19 File Offset: 0x002ABE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballQuitResponse.Descriptor;
			}
		}

		// Token: 0x0601257D RID: 75133 RVA: 0x002ADC20 File Offset: 0x002ABE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitResponse()
		{
		}

		// Token: 0x0601257E RID: 75134 RVA: 0x002ADC28 File Offset: 0x002ABE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitResponse(PinballQuitResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601257F RID: 75135 RVA: 0x002ADC4D File Offset: 0x002ABE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballQuitResponse Clone()
		{
			return new PinballQuitResponse(this);
		}

		// Token: 0x17003CCA RID: 15562
		// (get) Token: 0x06012580 RID: 75136 RVA: 0x002ADC55 File Offset: 0x002ABE55
		// (set) Token: 0x06012581 RID: 75137 RVA: 0x002ADC5D File Offset: 0x002ABE5D
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

		// Token: 0x06012582 RID: 75138 RVA: 0x002ADC66 File Offset: 0x002ABE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballQuitResponse);
		}

		// Token: 0x06012583 RID: 75139 RVA: 0x002ADC74 File Offset: 0x002ABE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballQuitResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012584 RID: 75140 RVA: 0x002ADCA4 File Offset: 0x002ABEA4
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

		// Token: 0x06012585 RID: 75141 RVA: 0x002ADCE9 File Offset: 0x002ABEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012586 RID: 75142 RVA: 0x002ADCF6 File Offset: 0x002ABEF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012587 RID: 75143 RVA: 0x002ADCFF File Offset: 0x002ABEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012588 RID: 75144 RVA: 0x002ADD34 File Offset: 0x002ABF34
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

		// Token: 0x06012589 RID: 75145 RVA: 0x002ADD72 File Offset: 0x002ABF72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballQuitResponse other)
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

		// Token: 0x0601258A RID: 75146 RVA: 0x002ADDA3 File Offset: 0x002ABFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601258B RID: 75147 RVA: 0x002ADDAC File Offset: 0x002ABFAC
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040072A8 RID: 29352
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072A9 RID: 29353
		public const int ErrCodeFieldNumber = 9;

		// Token: 0x040072AA RID: 29354
		private ErrorCode errCode_;
	}
}
