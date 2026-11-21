using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001575 RID: 5493
	[NetMessage(EMessageId.WeatherControlResponse)]
	public sealed class WeatherControlResponse : IMessage<WeatherControlResponse>, IMessage, IEquatable<WeatherControlResponse>, IDeepCloneable<WeatherControlResponse>, IBufferMessage
	{
		// Token: 0x0601D15F RID: 119135 RVA: 0x0043657D File Offset: 0x0043477D
		[NullableContext(1)]
		public static WeatherControlResponse Create()
		{
			return new WeatherControlResponse();
		}

		// Token: 0x17006268 RID: 25192
		// (get) Token: 0x0601D160 RID: 119136 RVA: 0x00436584 File Offset: 0x00434784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006269 RID: 25193
		// (get) Token: 0x0601D161 RID: 119137 RVA: 0x00436587 File Offset: 0x00434787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherControlResponse.Descriptor;
			}
		}

		// Token: 0x0601D162 RID: 119138 RVA: 0x0043658E File Offset: 0x0043478E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlResponse()
		{
		}

		// Token: 0x0601D163 RID: 119139 RVA: 0x00436596 File Offset: 0x00434796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlResponse(WeatherControlResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.weatherId_ = other.weatherId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D164 RID: 119140 RVA: 0x004365C7 File Offset: 0x004347C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlResponse Clone()
		{
			return new WeatherControlResponse(this);
		}

		// Token: 0x1700626A RID: 25194
		// (get) Token: 0x0601D165 RID: 119141 RVA: 0x004365CF File Offset: 0x004347CF
		// (set) Token: 0x0601D166 RID: 119142 RVA: 0x004365D7 File Offset: 0x004347D7
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

		// Token: 0x1700626B RID: 25195
		// (get) Token: 0x0601D167 RID: 119143 RVA: 0x004365E0 File Offset: 0x004347E0
		// (set) Token: 0x0601D168 RID: 119144 RVA: 0x004365E8 File Offset: 0x004347E8
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

		// Token: 0x0601D169 RID: 119145 RVA: 0x004365F1 File Offset: 0x004347F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherControlResponse);
		}

		// Token: 0x0601D16A RID: 119146 RVA: 0x004365FF File Offset: 0x004347FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherControlResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.WeatherId == other.WeatherId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D16B RID: 119147 RVA: 0x00436640 File Offset: 0x00434840
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

		// Token: 0x0601D16C RID: 119148 RVA: 0x0043669E File Offset: 0x0043489E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D16D RID: 119149 RVA: 0x004366AB File Offset: 0x004348AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D16E RID: 119150 RVA: 0x004366B4 File Offset: 0x004348B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.WeatherId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.WeatherId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D16F RID: 119151 RVA: 0x00436710 File Offset: 0x00434910
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

		// Token: 0x0601D170 RID: 119152 RVA: 0x00436768 File Offset: 0x00434968
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

		// Token: 0x0601D171 RID: 119153 RVA: 0x004367B8 File Offset: 0x004349B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D172 RID: 119154 RVA: 0x004367C4 File Offset: 0x004349C4
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
				if (num != 80U)
				{
					if (num != 88U)
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

		// Token: 0x0400A709 RID: 42761
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A70A RID: 42762
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400A70B RID: 42763
		private ErrorCode errorCode_;

		// Token: 0x0400A70C RID: 42764
		public const int WeatherIdFieldNumber = 11;

		// Token: 0x0400A70D RID: 42765
		private int weatherId_;
	}
}
