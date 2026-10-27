using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000267 RID: 615
	[NetMessage(EMessageId.ChangeWeatherResponse)]
	public sealed class ChangeWeatherResponse : IMessage<ChangeWeatherResponse>, IMessage, IEquatable<ChangeWeatherResponse>, IDeepCloneable<ChangeWeatherResponse>, IBufferMessage
	{
		// Token: 0x060040EB RID: 16619 RVA: 0x0009F410 File Offset: 0x0009D610
		[NullableContext(1)]
		public static ChangeWeatherResponse Create()
		{
			return new ChangeWeatherResponse();
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060040EC RID: 16620 RVA: 0x0009F417 File Offset: 0x0009D617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060040ED RID: 16621 RVA: 0x0009F41A File Offset: 0x0009D61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeWeatherResponse.Descriptor;
			}
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x0009F421 File Offset: 0x0009D621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherResponse()
		{
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x0009F429 File Offset: 0x0009D629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherResponse(ChangeWeatherResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.weatherId_ = other.weatherId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x0009F45A File Offset: 0x0009D65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherResponse Clone()
		{
			return new ChangeWeatherResponse(this);
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x0009F462 File Offset: 0x0009D662
		// (set) Token: 0x060040F2 RID: 16626 RVA: 0x0009F46A File Offset: 0x0009D66A
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

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060040F3 RID: 16627 RVA: 0x0009F473 File Offset: 0x0009D673
		// (set) Token: 0x060040F4 RID: 16628 RVA: 0x0009F47B File Offset: 0x0009D67B
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

		// Token: 0x060040F5 RID: 16629 RVA: 0x0009F484 File Offset: 0x0009D684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeWeatherResponse);
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x0009F492 File Offset: 0x0009D692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeWeatherResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.WeatherId == other.WeatherId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x0009F4D0 File Offset: 0x0009D6D0
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

		// Token: 0x060040F8 RID: 16632 RVA: 0x0009F52E File Offset: 0x0009D72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x0009F53B File Offset: 0x0009D73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x0009F544 File Offset: 0x0009D744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.WeatherId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.WeatherId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x0009F5A0 File Offset: 0x0009D7A0
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

		// Token: 0x060040FC RID: 16636 RVA: 0x0009F5F8 File Offset: 0x0009D7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeWeatherResponse other)
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

		// Token: 0x060040FD RID: 16637 RVA: 0x0009F648 File Offset: 0x0009D848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x0009F654 File Offset: 0x0009D854
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
					if (num != 120U)
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

		// Token: 0x04002D82 RID: 11650
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D83 RID: 11651
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04002D84 RID: 11652
		private ErrorCode errorCode_;

		// Token: 0x04002D85 RID: 11653
		public const int WeatherIdFieldNumber = 15;

		// Token: 0x04002D86 RID: 11654
		private int weatherId_;
	}
}
