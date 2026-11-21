using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001577 RID: 5495
	[NetMessage(EMessageId.WeatherNotify)]
	public sealed class WeatherNotify : IMessage<WeatherNotify>, IMessage, IEquatable<WeatherNotify>, IDeepCloneable<WeatherNotify>, IBufferMessage
	{
		// Token: 0x0601D185 RID: 119173 RVA: 0x004369F5 File Offset: 0x00434BF5
		[NullableContext(1)]
		public static WeatherNotify Create()
		{
			return new WeatherNotify();
		}

		// Token: 0x1700626F RID: 25199
		// (get) Token: 0x0601D186 RID: 119174 RVA: 0x004369FC File Offset: 0x00434BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006270 RID: 25200
		// (get) Token: 0x0601D187 RID: 119175 RVA: 0x004369FF File Offset: 0x00434BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherNotify.Descriptor;
			}
		}

		// Token: 0x0601D188 RID: 119176 RVA: 0x00436A06 File Offset: 0x00434C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherNotify()
		{
		}

		// Token: 0x0601D189 RID: 119177 RVA: 0x00436A0E File Offset: 0x00434C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherNotify(WeatherNotify other) : this()
		{
			this.weatherId_ = other.weatherId_;
			this.isClient_ = other.isClient_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D18A RID: 119178 RVA: 0x00436A3F File Offset: 0x00434C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherNotify Clone()
		{
			return new WeatherNotify(this);
		}

		// Token: 0x17006271 RID: 25201
		// (get) Token: 0x0601D18B RID: 119179 RVA: 0x00436A47 File Offset: 0x00434C47
		// (set) Token: 0x0601D18C RID: 119180 RVA: 0x00436A4F File Offset: 0x00434C4F
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

		// Token: 0x17006272 RID: 25202
		// (get) Token: 0x0601D18D RID: 119181 RVA: 0x00436A58 File Offset: 0x00434C58
		// (set) Token: 0x0601D18E RID: 119182 RVA: 0x00436A60 File Offset: 0x00434C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsClient
		{
			get
			{
				return this.isClient_;
			}
			set
			{
				this.isClient_ = value;
			}
		}

		// Token: 0x0601D18F RID: 119183 RVA: 0x00436A69 File Offset: 0x00434C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherNotify);
		}

		// Token: 0x0601D190 RID: 119184 RVA: 0x00436A77 File Offset: 0x00434C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherNotify other)
		{
			return other != null && (other == this || (this.WeatherId == other.WeatherId && this.IsClient == other.IsClient && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D191 RID: 119185 RVA: 0x00436AB8 File Offset: 0x00434CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeatherId != 0)
			{
				num ^= this.WeatherId.GetHashCode();
			}
			if (this.IsClient)
			{
				num ^= this.IsClient.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D192 RID: 119186 RVA: 0x00436B10 File Offset: 0x00434D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D193 RID: 119187 RVA: 0x00436B1D File Offset: 0x00434D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D194 RID: 119188 RVA: 0x00436B28 File Offset: 0x00434D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeatherId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WeatherId);
			}
			if (this.IsClient)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsClient);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D195 RID: 119189 RVA: 0x00436B84 File Offset: 0x00434D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeatherId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeatherId);
			}
			if (this.IsClient)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D196 RID: 119190 RVA: 0x00436BD0 File Offset: 0x00434DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeatherNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeatherId != 0)
			{
				this.WeatherId = other.WeatherId;
			}
			if (other.IsClient)
			{
				this.IsClient = other.IsClient;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D197 RID: 119191 RVA: 0x00436C20 File Offset: 0x00434E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D198 RID: 119192 RVA: 0x00436C2C File Offset: 0x00434E2C
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsClient = input.ReadBool();
					}
				}
				else
				{
					this.WeatherId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A711 RID: 42769
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A712 RID: 42770
		public const int WeatherIdFieldNumber = 9;

		// Token: 0x0400A713 RID: 42771
		private int weatherId_;

		// Token: 0x0400A714 RID: 42772
		public const int IsClientFieldNumber = 13;

		// Token: 0x0400A715 RID: 42773
		private bool isClient_;
	}
}
