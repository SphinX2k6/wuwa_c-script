using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D31 RID: 3377
	[NetMessage(EMessageId.PinballBonusFullWinResponse)]
	public sealed class PinballBonusFullWinResponse : IMessage<PinballBonusFullWinResponse>, IMessage, IEquatable<PinballBonusFullWinResponse>, IDeepCloneable<PinballBonusFullWinResponse>, IBufferMessage
	{
		// Token: 0x060123F2 RID: 74738 RVA: 0x002AA4B4 File Offset: 0x002A86B4
		[NullableContext(1)]
		public static PinballBonusFullWinResponse Create()
		{
			return new PinballBonusFullWinResponse();
		}

		// Token: 0x17003C74 RID: 15476
		// (get) Token: 0x060123F3 RID: 74739 RVA: 0x002AA4BB File Offset: 0x002A86BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C75 RID: 15477
		// (get) Token: 0x060123F4 RID: 74740 RVA: 0x002AA4BE File Offset: 0x002A86BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballBonusFullWinResponse.Descriptor;
			}
		}

		// Token: 0x060123F5 RID: 74741 RVA: 0x002AA4C5 File Offset: 0x002A86C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinResponse()
		{
		}

		// Token: 0x060123F6 RID: 74742 RVA: 0x002AA4CD File Offset: 0x002A86CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinResponse(PinballBonusFullWinResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060123F7 RID: 74743 RVA: 0x002AA4F2 File Offset: 0x002A86F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballBonusFullWinResponse Clone()
		{
			return new PinballBonusFullWinResponse(this);
		}

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x060123F8 RID: 74744 RVA: 0x002AA4FA File Offset: 0x002A86FA
		// (set) Token: 0x060123F9 RID: 74745 RVA: 0x002AA502 File Offset: 0x002A8702
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

		// Token: 0x060123FA RID: 74746 RVA: 0x002AA50B File Offset: 0x002A870B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballBonusFullWinResponse);
		}

		// Token: 0x060123FB RID: 74747 RVA: 0x002AA519 File Offset: 0x002A8719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballBonusFullWinResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060123FC RID: 74748 RVA: 0x002AA548 File Offset: 0x002A8748
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

		// Token: 0x060123FD RID: 74749 RVA: 0x002AA58D File Offset: 0x002A878D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060123FE RID: 74750 RVA: 0x002AA59A File Offset: 0x002A879A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060123FF RID: 74751 RVA: 0x002AA5A3 File Offset: 0x002A87A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012400 RID: 74752 RVA: 0x002AA5D8 File Offset: 0x002A87D8
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

		// Token: 0x06012401 RID: 74753 RVA: 0x002AA616 File Offset: 0x002A8816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballBonusFullWinResponse other)
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

		// Token: 0x06012402 RID: 74754 RVA: 0x002AA647 File Offset: 0x002A8847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012403 RID: 74755 RVA: 0x002AA650 File Offset: 0x002A8850
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400723A RID: 29242
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400723B RID: 29243
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x0400723C RID: 29244
		private ErrorCode errCode_;
	}
}
