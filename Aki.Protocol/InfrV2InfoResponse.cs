using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E7 RID: 2023
	[NetMessage(EMessageId.InfrV2InfoResponse)]
	public sealed class InfrV2InfoResponse : IMessage<InfrV2InfoResponse>, IMessage, IEquatable<InfrV2InfoResponse>, IDeepCloneable<InfrV2InfoResponse>, IBufferMessage
	{
		// Token: 0x0600B5B0 RID: 46512 RVA: 0x001B1F46 File Offset: 0x001B0146
		[NullableContext(1)]
		public static InfrV2InfoResponse Create()
		{
			return new InfrV2InfoResponse();
		}

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x0600B5B1 RID: 46513 RVA: 0x001B1F4D File Offset: 0x001B014D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x0600B5B2 RID: 46514 RVA: 0x001B1F50 File Offset: 0x001B0150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2InfoResponse.Descriptor;
			}
		}

		// Token: 0x0600B5B3 RID: 46515 RVA: 0x001B1F57 File Offset: 0x001B0157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoResponse()
		{
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x001B1F60 File Offset: 0x001B0160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoResponse(InfrV2InfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.infrInfo_ = ((other.infrInfo_ != null) ? other.infrInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5B5 RID: 46517 RVA: 0x001B1FAC File Offset: 0x001B01AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoResponse Clone()
		{
			return new InfrV2InfoResponse(this);
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x0600B5B6 RID: 46518 RVA: 0x001B1FB4 File Offset: 0x001B01B4
		// (set) Token: 0x0600B5B7 RID: 46519 RVA: 0x001B1FBC File Offset: 0x001B01BC
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

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x0600B5B8 RID: 46520 RVA: 0x001B1FC5 File Offset: 0x001B01C5
		// (set) Token: 0x0600B5B9 RID: 46521 RVA: 0x001B1FCD File Offset: 0x001B01CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2Pb InfrInfo
		{
			get
			{
				return this.infrInfo_;
			}
			set
			{
				this.infrInfo_ = value;
			}
		}

		// Token: 0x0600B5BA RID: 46522 RVA: 0x001B1FD6 File Offset: 0x001B01D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2InfoResponse);
		}

		// Token: 0x0600B5BB RID: 46523 RVA: 0x001B1FE4 File Offset: 0x001B01E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2InfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.InfrInfo, other.InfrInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B5BC RID: 46524 RVA: 0x001B2034 File Offset: 0x001B0234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.infrInfo_ != null)
			{
				num ^= this.InfrInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B5BD RID: 46525 RVA: 0x001B208F File Offset: 0x001B028F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B5BE RID: 46526 RVA: 0x001B209C File Offset: 0x001B029C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5BF RID: 46527 RVA: 0x001B20A8 File Offset: 0x001B02A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.infrInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.InfrInfo);
			}
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

		// Token: 0x0600B5C0 RID: 46528 RVA: 0x001B2104 File Offset: 0x001B0304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.infrInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InfrInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B5C1 RID: 46529 RVA: 0x001B215C File Offset: 0x001B035C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2InfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.infrInfo_ != null)
			{
				if (this.infrInfo_ == null)
				{
					this.InfrInfo = new InfrV2Pb();
				}
				this.InfrInfo.MergeFrom(other.InfrInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5C2 RID: 46530 RVA: 0x001B21C4 File Offset: 0x001B03C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5C3 RID: 46531 RVA: 0x001B21D0 File Offset: 0x001B03D0
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
				if (num != 74U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.infrInfo_ == null)
					{
						this.InfrInfo = new InfrV2Pb();
					}
					input.ReadMessage(this.InfrInfo);
				}
			}
		}

		// Token: 0x040050E3 RID: 20707
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050E4 RID: 20708
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040050E5 RID: 20709
		private ErrorCode errorCode_;

		// Token: 0x040050E6 RID: 20710
		public const int InfrInfoFieldNumber = 9;

		// Token: 0x040050E7 RID: 20711
		private InfrV2Pb infrInfo_;
	}
}
