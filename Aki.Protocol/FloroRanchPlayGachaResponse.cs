using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AA RID: 1450
	[NetMessage(EMessageId.FloroRanchPlayGachaResponse)]
	public sealed class FloroRanchPlayGachaResponse : IMessage<FloroRanchPlayGachaResponse>, IMessage, IEquatable<FloroRanchPlayGachaResponse>, IDeepCloneable<FloroRanchPlayGachaResponse>, IBufferMessage
	{
		// Token: 0x0600867B RID: 34427 RVA: 0x00144389 File Offset: 0x00142589
		[NullableContext(1)]
		public static FloroRanchPlayGachaResponse Create()
		{
			return new FloroRanchPlayGachaResponse();
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x0600867C RID: 34428 RVA: 0x00144390 File Offset: 0x00142590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x0600867D RID: 34429 RVA: 0x00144393 File Offset: 0x00142593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayGachaResponse.Descriptor;
			}
		}

		// Token: 0x0600867E RID: 34430 RVA: 0x0014439A File Offset: 0x0014259A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaResponse()
		{
		}

		// Token: 0x0600867F RID: 34431 RVA: 0x001443B0 File Offset: 0x001425B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaResponse(FloroRanchPlayGachaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.unit_ = ((other.unit_ != null) ? other.unit_.Clone() : null);
			this.gachaResult_ = other.gachaResult_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008680 RID: 34432 RVA: 0x0014440D File Offset: 0x0014260D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaResponse Clone()
		{
			return new FloroRanchPlayGachaResponse(this);
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06008681 RID: 34433 RVA: 0x00144415 File Offset: 0x00142615
		// (set) Token: 0x06008682 RID: 34434 RVA: 0x0014441D File Offset: 0x0014261D
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

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06008683 RID: 34435 RVA: 0x00144426 File Offset: 0x00142626
		// (set) Token: 0x06008684 RID: 34436 RVA: 0x0014442E File Offset: 0x0014262E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit Unit
		{
			get
			{
				return this.unit_;
			}
			set
			{
				this.unit_ = value;
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06008685 RID: 34437 RVA: 0x00144437 File Offset: 0x00142637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> GachaResult
		{
			get
			{
				return this.gachaResult_;
			}
		}

		// Token: 0x06008686 RID: 34438 RVA: 0x0014443F File Offset: 0x0014263F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayGachaResponse);
		}

		// Token: 0x06008687 RID: 34439 RVA: 0x00144450 File Offset: 0x00142650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayGachaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Unit, other.Unit) && this.gachaResult_.Equals(other.gachaResult_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008688 RID: 34440 RVA: 0x001444B4 File Offset: 0x001426B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.unit_ != null)
			{
				num ^= this.Unit.GetHashCode();
			}
			num ^= this.gachaResult_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008689 RID: 34441 RVA: 0x0014451D File Offset: 0x0014271D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600868A RID: 34442 RVA: 0x0014452A File Offset: 0x0014272A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600868B RID: 34443 RVA: 0x00144534 File Offset: 0x00142734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.gachaResult_.WriteTo(ref output, FloroRanchPlayGachaResponse._repeated_gachaResult_codec);
			if (this.unit_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Unit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600868C RID: 34444 RVA: 0x001445A0 File Offset: 0x001427A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.unit_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Unit);
			}
			num += this.gachaResult_.CalculateSize(FloroRanchPlayGachaResponse._repeated_gachaResult_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600868D RID: 34445 RVA: 0x0014460C File Offset: 0x0014280C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayGachaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.unit_ != null)
			{
				if (this.unit_ == null)
				{
					this.Unit = new FloroRanchPlayUnit();
				}
				this.Unit.MergeFrom(other.Unit);
			}
			this.gachaResult_.Add(other.gachaResult_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600868E RID: 34446 RVA: 0x00144685 File Offset: 0x00142885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600868F RID: 34447 RVA: 0x00144690 File Offset: 0x00142890
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
					if (num != 34U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.unit_ == null)
							{
								this.Unit = new FloroRanchPlayUnit();
							}
							input.ReadMessage(this.Unit);
						}
					}
					else
					{
						this.gachaResult_.AddEntriesFrom(ref input, FloroRanchPlayGachaResponse._repeated_gachaResult_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040042DD RID: 17117
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042DE RID: 17118
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040042DF RID: 17119
		private ErrorCode errorCode_;

		// Token: 0x040042E0 RID: 17120
		public const int UnitFieldNumber = 9;

		// Token: 0x040042E1 RID: 17121
		private FloroRanchPlayUnit unit_;

		// Token: 0x040042E2 RID: 17122
		public const int GachaResultFieldNumber = 4;

		// Token: 0x040042E3 RID: 17123
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_gachaResult_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(34U, FloroRanchPlayUnit.Parser);

		// Token: 0x040042E4 RID: 17124
		private readonly RepeatedField<FloroRanchPlayUnit> gachaResult_ = new RepeatedField<FloroRanchPlayUnit>();
	}
}
