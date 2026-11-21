using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066F RID: 1647
	[NetMessage(EMessageId.FurnitureDiySaveResponse)]
	public sealed class FurnitureDiySaveResponse : IMessage<FurnitureDiySaveResponse>, IMessage, IEquatable<FurnitureDiySaveResponse>, IDeepCloneable<FurnitureDiySaveResponse>, IBufferMessage
	{
		// Token: 0x06009750 RID: 38736 RVA: 0x0016D1E1 File Offset: 0x0016B3E1
		[NullableContext(1)]
		public static FurnitureDiySaveResponse Create()
		{
			return new FurnitureDiySaveResponse();
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x06009751 RID: 38737 RVA: 0x0016D1E8 File Offset: 0x0016B3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x06009752 RID: 38738 RVA: 0x0016D1EB File Offset: 0x0016B3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FurnitureDiySaveResponse.Descriptor;
			}
		}

		// Token: 0x06009753 RID: 38739 RVA: 0x0016D1F2 File Offset: 0x0016B3F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySaveResponse()
		{
		}

		// Token: 0x06009754 RID: 38740 RVA: 0x0016D1FA File Offset: 0x0016B3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySaveResponse(FurnitureDiySaveResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.atmosphere_ = other.atmosphere_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009755 RID: 38741 RVA: 0x0016D22B File Offset: 0x0016B42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySaveResponse Clone()
		{
			return new FurnitureDiySaveResponse(this);
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06009756 RID: 38742 RVA: 0x0016D233 File Offset: 0x0016B433
		// (set) Token: 0x06009757 RID: 38743 RVA: 0x0016D23B File Offset: 0x0016B43B
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

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x06009758 RID: 38744 RVA: 0x0016D244 File Offset: 0x0016B444
		// (set) Token: 0x06009759 RID: 38745 RVA: 0x0016D24C File Offset: 0x0016B44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Atmosphere
		{
			get
			{
				return this.atmosphere_;
			}
			set
			{
				this.atmosphere_ = value;
			}
		}

		// Token: 0x0600975A RID: 38746 RVA: 0x0016D255 File Offset: 0x0016B455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FurnitureDiySaveResponse);
		}

		// Token: 0x0600975B RID: 38747 RVA: 0x0016D263 File Offset: 0x0016B463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FurnitureDiySaveResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.Atmosphere == other.Atmosphere && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600975C RID: 38748 RVA: 0x0016D2A4 File Offset: 0x0016B4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.Atmosphere != 0)
			{
				num ^= this.Atmosphere.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600975D RID: 38749 RVA: 0x0016D302 File Offset: 0x0016B502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600975E RID: 38750 RVA: 0x0016D30F File Offset: 0x0016B50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600975F RID: 38751 RVA: 0x0016D318 File Offset: 0x0016B518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Atmosphere != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Atmosphere);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009760 RID: 38752 RVA: 0x0016D370 File Offset: 0x0016B570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.Atmosphere != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Atmosphere);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009761 RID: 38753 RVA: 0x0016D3C8 File Offset: 0x0016B5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FurnitureDiySaveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.Atmosphere != 0)
			{
				this.Atmosphere = other.Atmosphere;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x0016D418 File Offset: 0x0016B618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009763 RID: 38755 RVA: 0x0016D424 File Offset: 0x0016B624
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
				if (num != 8U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.Atmosphere = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400484C RID: 18508
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400484D RID: 18509
		public const int ErrCodeFieldNumber = 8;

		// Token: 0x0400484E RID: 18510
		private ErrorCode errCode_;

		// Token: 0x0400484F RID: 18511
		public const int AtmosphereFieldNumber = 1;

		// Token: 0x04004850 RID: 18512
		private int atmosphere_;
	}
}
