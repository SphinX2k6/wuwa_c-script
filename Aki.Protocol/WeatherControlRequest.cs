using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001574 RID: 5492
	[NetMessage(EMessageId.WeatherControlRequest)]
	public sealed class WeatherControlRequest : IMessage<WeatherControlRequest>, IMessage, IEquatable<WeatherControlRequest>, IDeepCloneable<WeatherControlRequest>, IBufferMessage
	{
		// Token: 0x0601D14D RID: 119117 RVA: 0x004363A2 File Offset: 0x004345A2
		[NullableContext(1)]
		public static WeatherControlRequest Create()
		{
			return new WeatherControlRequest();
		}

		// Token: 0x17006265 RID: 25189
		// (get) Token: 0x0601D14E RID: 119118 RVA: 0x004363A9 File Offset: 0x004345A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006266 RID: 25190
		// (get) Token: 0x0601D14F RID: 119119 RVA: 0x004363AC File Offset: 0x004345AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherControlRequest.Descriptor;
			}
		}

		// Token: 0x0601D150 RID: 119120 RVA: 0x004363B3 File Offset: 0x004345B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlRequest()
		{
		}

		// Token: 0x0601D151 RID: 119121 RVA: 0x004363BB File Offset: 0x004345BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlRequest(WeatherControlRequest other) : this()
		{
			this.weatherSwitchId_ = other.weatherSwitchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D152 RID: 119122 RVA: 0x004363E0 File Offset: 0x004345E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlRequest Clone()
		{
			return new WeatherControlRequest(this);
		}

		// Token: 0x17006267 RID: 25191
		// (get) Token: 0x0601D153 RID: 119123 RVA: 0x004363E8 File Offset: 0x004345E8
		// (set) Token: 0x0601D154 RID: 119124 RVA: 0x004363F0 File Offset: 0x004345F0
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

		// Token: 0x0601D155 RID: 119125 RVA: 0x004363F9 File Offset: 0x004345F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherControlRequest);
		}

		// Token: 0x0601D156 RID: 119126 RVA: 0x00436407 File Offset: 0x00434607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherControlRequest other)
		{
			return other != null && (other == this || (this.WeatherSwitchId == other.WeatherSwitchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D157 RID: 119127 RVA: 0x00436438 File Offset: 0x00434638
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

		// Token: 0x0601D158 RID: 119128 RVA: 0x00436477 File Offset: 0x00434677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D159 RID: 119129 RVA: 0x00436484 File Offset: 0x00434684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D15A RID: 119130 RVA: 0x0043648D File Offset: 0x0043468D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeatherSwitchId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WeatherSwitchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D15B RID: 119131 RVA: 0x004364C0 File Offset: 0x004346C0
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

		// Token: 0x0601D15C RID: 119132 RVA: 0x004364FE File Offset: 0x004346FE
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

		// Token: 0x0601D15D RID: 119133 RVA: 0x0043652F File Offset: 0x0043472F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D15E RID: 119134 RVA: 0x00436538 File Offset: 0x00434738
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeatherSwitchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A706 RID: 42758
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A707 RID: 42759
		public const int WeatherSwitchIdFieldNumber = 3;

		// Token: 0x0400A708 RID: 42760
		private int weatherSwitchId_;
	}
}
