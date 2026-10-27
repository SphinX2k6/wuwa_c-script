using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001500 RID: 5376
	[NetMessage(EMessageId.WeatherControlUnlockNotify)]
	public sealed class WeatherControlUnlockNotify : IMessage<WeatherControlUnlockNotify>, IMessage, IEquatable<WeatherControlUnlockNotify>, IDeepCloneable<WeatherControlUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601C6AC RID: 116396 RVA: 0x0041AD5C File Offset: 0x00418F5C
		[NullableContext(1)]
		public static WeatherControlUnlockNotify Create()
		{
			return new WeatherControlUnlockNotify();
		}

		// Token: 0x17005FCB RID: 24523
		// (get) Token: 0x0601C6AD RID: 116397 RVA: 0x0041AD63 File Offset: 0x00418F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FCC RID: 24524
		// (get) Token: 0x0601C6AE RID: 116398 RVA: 0x0041AD66 File Offset: 0x00418F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherControlUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0601C6AF RID: 116399 RVA: 0x0041AD6D File Offset: 0x00418F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlUnlockNotify()
		{
		}

		// Token: 0x0601C6B0 RID: 116400 RVA: 0x0041AD75 File Offset: 0x00418F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlUnlockNotify(WeatherControlUnlockNotify other) : this()
		{
			this.weatherSwitchId_ = other.weatherSwitchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C6B1 RID: 116401 RVA: 0x0041AD9A File Offset: 0x00418F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlUnlockNotify Clone()
		{
			return new WeatherControlUnlockNotify(this);
		}

		// Token: 0x17005FCD RID: 24525
		// (get) Token: 0x0601C6B2 RID: 116402 RVA: 0x0041ADA2 File Offset: 0x00418FA2
		// (set) Token: 0x0601C6B3 RID: 116403 RVA: 0x0041ADAA File Offset: 0x00418FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeatherSwitchId
		{
			get
			{
				return this.weatherSwitchId_;
			}
			set
			{
				this.weatherSwitchId_ = value;
			}
		}

		// Token: 0x0601C6B4 RID: 116404 RVA: 0x0041ADB3 File Offset: 0x00418FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherControlUnlockNotify);
		}

		// Token: 0x0601C6B5 RID: 116405 RVA: 0x0041ADC1 File Offset: 0x00418FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherControlUnlockNotify other)
		{
			return other != null && (other == this || (this.WeatherSwitchId == other.WeatherSwitchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C6B6 RID: 116406 RVA: 0x0041ADF0 File Offset: 0x00418FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeatherSwitchId != 0)
			{
				num ^= this.WeatherSwitchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C6B7 RID: 116407 RVA: 0x0041AE2F File Offset: 0x0041902F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C6B8 RID: 116408 RVA: 0x0041AE3C File Offset: 0x0041903C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C6B9 RID: 116409 RVA: 0x0041AE45 File Offset: 0x00419045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeatherSwitchId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WeatherSwitchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C6BA RID: 116410 RVA: 0x0041AE78 File Offset: 0x00419078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeatherSwitchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeatherSwitchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C6BB RID: 116411 RVA: 0x0041AEB6 File Offset: 0x004190B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeatherControlUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeatherSwitchId != 0)
			{
				this.WeatherSwitchId = other.WeatherSwitchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C6BC RID: 116412 RVA: 0x0041AEE7 File Offset: 0x004190E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C6BD RID: 116413 RVA: 0x0041AEF0 File Offset: 0x004190F0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeatherSwitchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A2B5 RID: 41653
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2B6 RID: 41654
		public const int WeatherSwitchIdFieldNumber = 9;

		// Token: 0x0400A2B7 RID: 41655
		private int weatherSwitchId_;
	}
}
