using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FE RID: 5374
	[NetMessage(EMessageId.WeatherControlRequest)]
	public sealed class WeatherControlRequest : IMessage<WeatherControlRequest>, IMessage, IEquatable<WeatherControlRequest>, IDeepCloneable<WeatherControlRequest>, IBufferMessage
	{
		// Token: 0x0601C686 RID: 116358 RVA: 0x0041A8E2 File Offset: 0x00418AE2
		[NullableContext(1)]
		public static WeatherControlRequest Create()
		{
			return new WeatherControlRequest();
		}

		// Token: 0x17005FC4 RID: 24516
		// (get) Token: 0x0601C687 RID: 116359 RVA: 0x0041A8E9 File Offset: 0x00418AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FC5 RID: 24517
		// (get) Token: 0x0601C688 RID: 116360 RVA: 0x0041A8EC File Offset: 0x00418AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherControlRequest.Descriptor;
			}
		}

		// Token: 0x0601C689 RID: 116361 RVA: 0x0041A8F3 File Offset: 0x00418AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlRequest()
		{
		}

		// Token: 0x0601C68A RID: 116362 RVA: 0x0041A8FB File Offset: 0x00418AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlRequest(WeatherControlRequest other) : this()
		{
			this.weatherSwitchId_ = other.weatherSwitchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C68B RID: 116363 RVA: 0x0041A920 File Offset: 0x00418B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlRequest Clone()
		{
			return new WeatherControlRequest(this);
		}

		// Token: 0x17005FC6 RID: 24518
		// (get) Token: 0x0601C68C RID: 116364 RVA: 0x0041A928 File Offset: 0x00418B28
		// (set) Token: 0x0601C68D RID: 116365 RVA: 0x0041A930 File Offset: 0x00418B30
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

		// Token: 0x0601C68E RID: 116366 RVA: 0x0041A939 File Offset: 0x00418B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherControlRequest);
		}

		// Token: 0x0601C68F RID: 116367 RVA: 0x0041A947 File Offset: 0x00418B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherControlRequest other)
		{
			return other != null && (other == this || (this.WeatherSwitchId == other.WeatherSwitchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C690 RID: 116368 RVA: 0x0041A978 File Offset: 0x00418B78
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

		// Token: 0x0601C691 RID: 116369 RVA: 0x0041A9B7 File Offset: 0x00418BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C692 RID: 116370 RVA: 0x0041A9C4 File Offset: 0x00418BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C693 RID: 116371 RVA: 0x0041A9CD File Offset: 0x00418BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeatherSwitchId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.WeatherSwitchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C694 RID: 116372 RVA: 0x0041AA00 File Offset: 0x00418C00
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

		// Token: 0x0601C695 RID: 116373 RVA: 0x0041AA3E File Offset: 0x00418C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeatherControlRequest other)
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

		// Token: 0x0601C696 RID: 116374 RVA: 0x0041AA6F File Offset: 0x00418C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C697 RID: 116375 RVA: 0x0041AA78 File Offset: 0x00418C78
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeatherSwitchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A2AD RID: 41645
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2AE RID: 41646
		public const int WeatherSwitchIdFieldNumber = 14;

		// Token: 0x0400A2AF RID: 41647
		private int weatherSwitchId_;
	}
}
