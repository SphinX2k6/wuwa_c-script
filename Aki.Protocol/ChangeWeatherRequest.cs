using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026B RID: 619
	[NetMessage(EMessageId.ChangeWeatherRequest)]
	public sealed class ChangeWeatherRequest : IMessage<ChangeWeatherRequest>, IMessage, IEquatable<ChangeWeatherRequest>, IDeepCloneable<ChangeWeatherRequest>, IBufferMessage
	{
		// Token: 0x0600417E RID: 16766 RVA: 0x000A0E48 File Offset: 0x0009F048
		[NullableContext(1)]
		public static ChangeWeatherRequest Create()
		{
			return new ChangeWeatherRequest();
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x000A0E4F File Offset: 0x0009F04F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06004180 RID: 16768 RVA: 0x000A0E52 File Offset: 0x0009F052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeWeatherRequest.Descriptor;
			}
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x000A0E59 File Offset: 0x0009F059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherRequest()
		{
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x000A0E61 File Offset: 0x0009F061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherRequest(ChangeWeatherRequest other) : this()
		{
			this.weatherId_ = other.weatherId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x000A0E92 File Offset: 0x0009F092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherRequest Clone()
		{
			return new ChangeWeatherRequest(this);
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06004184 RID: 16772 RVA: 0x000A0E9A File Offset: 0x0009F09A
		// (set) Token: 0x06004185 RID: 16773 RVA: 0x000A0EA2 File Offset: 0x0009F0A2
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

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06004186 RID: 16774 RVA: 0x000A0EAB File Offset: 0x0009F0AB
		// (set) Token: 0x06004187 RID: 16775 RVA: 0x000A0EB3 File Offset: 0x0009F0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeWeatherReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x000A0EBC File Offset: 0x0009F0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeWeatherRequest);
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x000A0ECA File Offset: 0x0009F0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeWeatherRequest other)
		{
			return other != null && (other == this || (this.WeatherId == other.WeatherId && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x000A0F08 File Offset: 0x0009F108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeatherId != 0)
			{
				num ^= this.WeatherId.GetHashCode();
			}
			if (this.Reason != ChangeWeatherReason.ClientDefault)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x000A0F66 File Offset: 0x0009F166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x000A0F73 File Offset: 0x0009F173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x000A0F7C File Offset: 0x0009F17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != ChangeWeatherReason.ClientDefault)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Reason);
			}
			if (this.WeatherId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.WeatherId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x000A0FD4 File Offset: 0x0009F1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeatherId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeatherId);
			}
			if (this.Reason != ChangeWeatherReason.ClientDefault)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x000A102C File Offset: 0x0009F22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeWeatherRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeatherId != 0)
			{
				this.WeatherId = other.WeatherId;
			}
			if (other.Reason != ChangeWeatherReason.ClientDefault)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x000A107C File Offset: 0x0009F27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x000A1088 File Offset: 0x0009F288
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
					if (num != 80U)
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
					this.Reason = (ChangeWeatherReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002E01 RID: 11777
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E02 RID: 11778
		public const int WeatherIdFieldNumber = 10;

		// Token: 0x04002E03 RID: 11779
		private int weatherId_;

		// Token: 0x04002E04 RID: 11780
		public const int ReasonFieldNumber = 1;

		// Token: 0x04002E05 RID: 11781
		private ChangeWeatherReason reason_;
	}
}
