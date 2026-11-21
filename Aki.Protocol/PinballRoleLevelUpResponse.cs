using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4A RID: 3402
	[NetMessage(EMessageId.PinballRoleLevelUpResponse)]
	public sealed class PinballRoleLevelUpResponse : IMessage<PinballRoleLevelUpResponse>, IMessage, IEquatable<PinballRoleLevelUpResponse>, IDeepCloneable<PinballRoleLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0601260C RID: 75276 RVA: 0x002AF37B File Offset: 0x002AD57B
		[NullableContext(1)]
		public static PinballRoleLevelUpResponse Create()
		{
			return new PinballRoleLevelUpResponse();
		}

		// Token: 0x17003CEE RID: 15598
		// (get) Token: 0x0601260D RID: 75277 RVA: 0x002AF382 File Offset: 0x002AD582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x0601260E RID: 75278 RVA: 0x002AF385 File Offset: 0x002AD585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballRoleLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601260F RID: 75279 RVA: 0x002AF38C File Offset: 0x002AD58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpResponse()
		{
		}

		// Token: 0x06012610 RID: 75280 RVA: 0x002AF394 File Offset: 0x002AD594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpResponse(PinballRoleLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012611 RID: 75281 RVA: 0x002AF3B9 File Offset: 0x002AD5B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpResponse Clone()
		{
			return new PinballRoleLevelUpResponse(this);
		}

		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x06012612 RID: 75282 RVA: 0x002AF3C1 File Offset: 0x002AD5C1
		// (set) Token: 0x06012613 RID: 75283 RVA: 0x002AF3C9 File Offset: 0x002AD5C9
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

		// Token: 0x06012614 RID: 75284 RVA: 0x002AF3D2 File Offset: 0x002AD5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballRoleLevelUpResponse);
		}

		// Token: 0x06012615 RID: 75285 RVA: 0x002AF3E0 File Offset: 0x002AD5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballRoleLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012616 RID: 75286 RVA: 0x002AF410 File Offset: 0x002AD610
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

		// Token: 0x06012617 RID: 75287 RVA: 0x002AF455 File Offset: 0x002AD655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012618 RID: 75288 RVA: 0x002AF462 File Offset: 0x002AD662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012619 RID: 75289 RVA: 0x002AF46B File Offset: 0x002AD66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601261A RID: 75290 RVA: 0x002AF4A0 File Offset: 0x002AD6A0
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

		// Token: 0x0601261B RID: 75291 RVA: 0x002AF4DE File Offset: 0x002AD6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballRoleLevelUpResponse other)
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

		// Token: 0x0601261C RID: 75292 RVA: 0x002AF50F File Offset: 0x002AD70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601261D RID: 75293 RVA: 0x002AF518 File Offset: 0x002AD718
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040072E2 RID: 29410
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072E3 RID: 29411
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040072E4 RID: 29412
		private ErrorCode errorCode_;
	}
}
