using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001408 RID: 5128
	[NetMessage(EMessageId.ToughCalcExtraRatioChangeResponse)]
	public sealed class ToughCalcExtraRatioChangeResponse : IMessage<ToughCalcExtraRatioChangeResponse>, IMessage, IEquatable<ToughCalcExtraRatioChangeResponse>, IDeepCloneable<ToughCalcExtraRatioChangeResponse>, IBufferMessage
	{
		// Token: 0x0601B42B RID: 111659 RVA: 0x003F7188 File Offset: 0x003F5388
		[NullableContext(1)]
		public static ToughCalcExtraRatioChangeResponse Create()
		{
			return new ToughCalcExtraRatioChangeResponse();
		}

		// Token: 0x17005C46 RID: 23622
		// (get) Token: 0x0601B42C RID: 111660 RVA: 0x003F718F File Offset: 0x003F538F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C47 RID: 23623
		// (get) Token: 0x0601B42D RID: 111661 RVA: 0x003F7192 File Offset: 0x003F5392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ToughCalcExtraRatioChangeResponse.Descriptor;
			}
		}

		// Token: 0x0601B42E RID: 111662 RVA: 0x003F7199 File Offset: 0x003F5399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeResponse()
		{
		}

		// Token: 0x0601B42F RID: 111663 RVA: 0x003F71A1 File Offset: 0x003F53A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeResponse(ToughCalcExtraRatioChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B430 RID: 111664 RVA: 0x003F71C6 File Offset: 0x003F53C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeResponse Clone()
		{
			return new ToughCalcExtraRatioChangeResponse(this);
		}

		// Token: 0x17005C48 RID: 23624
		// (get) Token: 0x0601B431 RID: 111665 RVA: 0x003F71CE File Offset: 0x003F53CE
		// (set) Token: 0x0601B432 RID: 111666 RVA: 0x003F71D6 File Offset: 0x003F53D6
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

		// Token: 0x0601B433 RID: 111667 RVA: 0x003F71DF File Offset: 0x003F53DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ToughCalcExtraRatioChangeResponse);
		}

		// Token: 0x0601B434 RID: 111668 RVA: 0x003F71ED File Offset: 0x003F53ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ToughCalcExtraRatioChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B435 RID: 111669 RVA: 0x003F721C File Offset: 0x003F541C
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

		// Token: 0x0601B436 RID: 111670 RVA: 0x003F7261 File Offset: 0x003F5461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B437 RID: 111671 RVA: 0x003F726E File Offset: 0x003F546E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B438 RID: 111672 RVA: 0x003F7277 File Offset: 0x003F5477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B439 RID: 111673 RVA: 0x003F72AC File Offset: 0x003F54AC
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

		// Token: 0x0601B43A RID: 111674 RVA: 0x003F72EA File Offset: 0x003F54EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ToughCalcExtraRatioChangeResponse other)
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

		// Token: 0x0601B43B RID: 111675 RVA: 0x003F731B File Offset: 0x003F551B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B43C RID: 111676 RVA: 0x003F7324 File Offset: 0x003F5524
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009EDF RID: 40671
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EE0 RID: 40672
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009EE1 RID: 40673
		private ErrorCode errorCode_;
	}
}
