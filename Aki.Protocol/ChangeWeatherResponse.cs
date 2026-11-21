using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026C RID: 620
	[NetMessage(EMessageId.ChangeWeatherResponse)]
	public sealed class ChangeWeatherResponse : IMessage<ChangeWeatherResponse>, IMessage, IEquatable<ChangeWeatherResponse>, IDeepCloneable<ChangeWeatherResponse>, IBufferMessage
	{
		// Token: 0x06004192 RID: 16786 RVA: 0x000A10DF File Offset: 0x0009F2DF
		[NullableContext(1)]
		public static ChangeWeatherResponse Create()
		{
			return new ChangeWeatherResponse();
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06004193 RID: 16787 RVA: 0x000A10E6 File Offset: 0x0009F2E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06004194 RID: 16788 RVA: 0x000A10E9 File Offset: 0x0009F2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeWeatherResponse.Descriptor;
			}
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x000A10F0 File Offset: 0x0009F2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherResponse()
		{
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x000A10F8 File Offset: 0x0009F2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherResponse(ChangeWeatherResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.weatherId_ = other.weatherId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x000A1129 File Offset: 0x0009F329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherResponse Clone()
		{
			return new ChangeWeatherResponse(this);
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06004198 RID: 16792 RVA: 0x000A1131 File Offset: 0x0009F331
		// (set) Token: 0x06004199 RID: 16793 RVA: 0x000A1139 File Offset: 0x0009F339
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

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x0600419A RID: 16794 RVA: 0x000A1142 File Offset: 0x0009F342
		// (set) Token: 0x0600419B RID: 16795 RVA: 0x000A114A File Offset: 0x0009F34A
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

		// Token: 0x0600419C RID: 16796 RVA: 0x000A1153 File Offset: 0x0009F353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeWeatherResponse);
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x000A1161 File Offset: 0x0009F361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeWeatherResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.WeatherId == other.WeatherId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x000A11A0 File Offset: 0x0009F3A0
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

		// Token: 0x0600419F RID: 16799 RVA: 0x000A11FE File Offset: 0x0009F3FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x000A120B File Offset: 0x0009F40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x000A1214 File Offset: 0x0009F414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeatherId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeatherId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x000A1270 File Offset: 0x0009F470
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

		// Token: 0x060041A3 RID: 16803 RVA: 0x000A12C8 File Offset: 0x0009F4C8
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

		// Token: 0x060041A4 RID: 16804 RVA: 0x000A1318 File Offset: 0x0009F518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x000A1324 File Offset: 0x0009F524
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
					if (num != 112U)
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
					this.WeatherId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002E06 RID: 11782
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E07 RID: 11783
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002E08 RID: 11784
		private ErrorCode errorCode_;

		// Token: 0x04002E09 RID: 11785
		public const int WeatherIdFieldNumber = 6;

		// Token: 0x04002E0A RID: 11786
		private int weatherId_;
	}
}
