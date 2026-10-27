using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FF RID: 5375
	[NetMessage(EMessageId.WeatherControlResponse)]
	public sealed class WeatherControlResponse : IMessage<WeatherControlResponse>, IMessage, IEquatable<WeatherControlResponse>, IDeepCloneable<WeatherControlResponse>, IBufferMessage
	{
		// Token: 0x0601C698 RID: 116376 RVA: 0x0041AABD File Offset: 0x00418CBD
		[NullableContext(1)]
		public static WeatherControlResponse Create()
		{
			return new WeatherControlResponse();
		}

		// Token: 0x17005FC7 RID: 24519
		// (get) Token: 0x0601C699 RID: 116377 RVA: 0x0041AAC4 File Offset: 0x00418CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FC8 RID: 24520
		// (get) Token: 0x0601C69A RID: 116378 RVA: 0x0041AAC7 File Offset: 0x00418CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherControlResponse.Descriptor;
			}
		}

		// Token: 0x0601C69B RID: 116379 RVA: 0x0041AACE File Offset: 0x00418CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlResponse()
		{
		}

		// Token: 0x0601C69C RID: 116380 RVA: 0x0041AAD6 File Offset: 0x00418CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlResponse(WeatherControlResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.weatherId_ = other.weatherId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C69D RID: 116381 RVA: 0x0041AB07 File Offset: 0x00418D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlResponse Clone()
		{
			return new WeatherControlResponse(this);
		}

		// Token: 0x17005FC9 RID: 24521
		// (get) Token: 0x0601C69E RID: 116382 RVA: 0x0041AB0F File Offset: 0x00418D0F
		// (set) Token: 0x0601C69F RID: 116383 RVA: 0x0041AB17 File Offset: 0x00418D17
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

		// Token: 0x17005FCA RID: 24522
		// (get) Token: 0x0601C6A0 RID: 116384 RVA: 0x0041AB20 File Offset: 0x00418D20
		// (set) Token: 0x0601C6A1 RID: 116385 RVA: 0x0041AB28 File Offset: 0x00418D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeatherId
		{
			get
			{
				return this.weatherId_;
			}
			set
			{
				this.weatherId_ = value;
			}
		}

		// Token: 0x0601C6A2 RID: 116386 RVA: 0x0041AB31 File Offset: 0x00418D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherControlResponse);
		}

		// Token: 0x0601C6A3 RID: 116387 RVA: 0x0041AB3F File Offset: 0x00418D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherControlResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.WeatherId == other.WeatherId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C6A4 RID: 116388 RVA: 0x0041AB80 File Offset: 0x00418D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.WeatherId != 0)
			{
				num ^= this.WeatherId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C6A5 RID: 116389 RVA: 0x0041ABDE File Offset: 0x00418DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C6A6 RID: 116390 RVA: 0x0041ABEB File Offset: 0x00418DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C6A7 RID: 116391 RVA: 0x0041ABF4 File Offset: 0x00418DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.WeatherId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeatherId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C6A8 RID: 116392 RVA: 0x0041AC50 File Offset: 0x00418E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.WeatherId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeatherId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C6A9 RID: 116393 RVA: 0x0041ACA8 File Offset: 0x00418EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeatherControlResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.WeatherId != 0)
			{
				this.WeatherId = other.WeatherId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C6AA RID: 116394 RVA: 0x0041ACF8 File Offset: 0x00418EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C6AB RID: 116395 RVA: 0x0041AD04 File Offset: 0x00418F04
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WeatherId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A2B0 RID: 41648
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2B1 RID: 41649
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400A2B2 RID: 41650
		private ErrorCode errorCode_;

		// Token: 0x0400A2B3 RID: 41651
		public const int WeatherIdFieldNumber = 6;

		// Token: 0x0400A2B4 RID: 41652
		private int weatherId_;
	}
}
