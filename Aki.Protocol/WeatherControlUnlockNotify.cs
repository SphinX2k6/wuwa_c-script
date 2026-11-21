using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001576 RID: 5494
	[NetMessage(EMessageId.WeatherControlUnlockNotify)]
	public sealed class WeatherControlUnlockNotify : IMessage<WeatherControlUnlockNotify>, IMessage, IEquatable<WeatherControlUnlockNotify>, IDeepCloneable<WeatherControlUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601D173 RID: 119155 RVA: 0x0043681C File Offset: 0x00434A1C
		[NullableContext(1)]
		public static WeatherControlUnlockNotify Create()
		{
			return new WeatherControlUnlockNotify();
		}

		// Token: 0x1700626C RID: 25196
		// (get) Token: 0x0601D174 RID: 119156 RVA: 0x00436823 File Offset: 0x00434A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700626D RID: 25197
		// (get) Token: 0x0601D175 RID: 119157 RVA: 0x00436826 File Offset: 0x00434A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherControlUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0601D176 RID: 119158 RVA: 0x0043682D File Offset: 0x00434A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlUnlockNotify()
		{
		}

		// Token: 0x0601D177 RID: 119159 RVA: 0x00436835 File Offset: 0x00434A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlUnlockNotify(WeatherControlUnlockNotify other) : this()
		{
			this.weatherSwitchId_ = other.weatherSwitchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D178 RID: 119160 RVA: 0x0043685A File Offset: 0x00434A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherControlUnlockNotify Clone()
		{
			return new WeatherControlUnlockNotify(this);
		}

		// Token: 0x1700626E RID: 25198
		// (get) Token: 0x0601D179 RID: 119161 RVA: 0x00436862 File Offset: 0x00434A62
		// (set) Token: 0x0601D17A RID: 119162 RVA: 0x0043686A File Offset: 0x00434A6A
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

		// Token: 0x0601D17B RID: 119163 RVA: 0x00436873 File Offset: 0x00434A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherControlUnlockNotify);
		}

		// Token: 0x0601D17C RID: 119164 RVA: 0x00436881 File Offset: 0x00434A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherControlUnlockNotify other)
		{
			return other != null && (other == this || (this.WeatherSwitchId == other.WeatherSwitchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D17D RID: 119165 RVA: 0x004368B0 File Offset: 0x00434AB0
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

		// Token: 0x0601D17E RID: 119166 RVA: 0x004368EF File Offset: 0x00434AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D17F RID: 119167 RVA: 0x004368FC File Offset: 0x00434AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D180 RID: 119168 RVA: 0x00436905 File Offset: 0x00434B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeatherSwitchId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.WeatherSwitchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D181 RID: 119169 RVA: 0x00436938 File Offset: 0x00434B38
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

		// Token: 0x0601D182 RID: 119170 RVA: 0x00436976 File Offset: 0x00434B76
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

		// Token: 0x0601D183 RID: 119171 RVA: 0x004369A7 File Offset: 0x00434BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D184 RID: 119172 RVA: 0x004369B0 File Offset: 0x00434BB0
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeatherSwitchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A70E RID: 42766
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A70F RID: 42767
		public const int WeatherSwitchIdFieldNumber = 7;

		// Token: 0x0400A710 RID: 42768
		private int weatherSwitchId_;
	}
}
