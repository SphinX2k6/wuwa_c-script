using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116E RID: 4462
	[NetMessage(EMessageId.RTimeStopAnimPush)]
	public sealed class RTimeStopAnimPush : IMessage<RTimeStopAnimPush>, IMessage, IEquatable<RTimeStopAnimPush>, IDeepCloneable<RTimeStopAnimPush>, IBufferMessage
	{
		// Token: 0x06017D77 RID: 97655 RVA: 0x00378A1C File Offset: 0x00376C1C
		[NullableContext(1)]
		public static RTimeStopAnimPush Create()
		{
			return new RTimeStopAnimPush();
		}

		// Token: 0x17005044 RID: 20548
		// (get) Token: 0x06017D78 RID: 97656 RVA: 0x00378A23 File Offset: 0x00376C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005045 RID: 20549
		// (get) Token: 0x06017D79 RID: 97657 RVA: 0x00378A26 File Offset: 0x00376C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopAnimPush.Descriptor;
			}
		}

		// Token: 0x06017D7A RID: 97658 RVA: 0x00378A2D File Offset: 0x00376C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimPush()
		{
		}

		// Token: 0x06017D7B RID: 97659 RVA: 0x00378A35 File Offset: 0x00376C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimPush(RTimeStopAnimPush other) : this()
		{
			this.duration_ = other.duration_;
			this.dilation_ = other.dilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D7C RID: 97660 RVA: 0x00378A66 File Offset: 0x00376C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimPush Clone()
		{
			return new RTimeStopAnimPush(this);
		}

		// Token: 0x17005046 RID: 20550
		// (get) Token: 0x06017D7D RID: 97661 RVA: 0x00378A6E File Offset: 0x00376C6E
		// (set) Token: 0x06017D7E RID: 97662 RVA: 0x00378A76 File Offset: 0x00376C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x17005047 RID: 20551
		// (get) Token: 0x06017D7F RID: 97663 RVA: 0x00378A7F File Offset: 0x00376C7F
		// (set) Token: 0x06017D80 RID: 97664 RVA: 0x00378A87 File Offset: 0x00376C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Dilation
		{
			get
			{
				return this.dilation_;
			}
			set
			{
				this.dilation_ = value;
			}
		}

		// Token: 0x06017D81 RID: 97665 RVA: 0x00378A90 File Offset: 0x00376C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopAnimPush);
		}

		// Token: 0x06017D82 RID: 97666 RVA: 0x00378A9E File Offset: 0x00376C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopAnimPush other)
		{
			return other != null && (other == this || (this.Duration == other.Duration && this.Dilation == other.Dilation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D83 RID: 97667 RVA: 0x00378ADC File Offset: 0x00376CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this.Dilation != 0)
			{
				num ^= this.Dilation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017D84 RID: 97668 RVA: 0x00378B34 File Offset: 0x00376D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D85 RID: 97669 RVA: 0x00378B41 File Offset: 0x00376D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D86 RID: 97670 RVA: 0x00378B4C File Offset: 0x00376D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Duration);
			}
			if (this.Dilation != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Dilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D87 RID: 97671 RVA: 0x00378BA8 File Offset: 0x00376DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this.Dilation != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Dilation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017D88 RID: 97672 RVA: 0x00378C00 File Offset: 0x00376E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopAnimPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			if (other.Dilation != 0)
			{
				this.Dilation = other.Dilation;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017D89 RID: 97673 RVA: 0x00378C50 File Offset: 0x00376E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D8A RID: 97674 RVA: 0x00378C5C File Offset: 0x00376E5C
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
						this.Dilation = input.ReadInt32();
					}
				}
				else
				{
					this.Duration = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E37 RID: 36407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E38 RID: 36408
		public const int DurationFieldNumber = 6;

		// Token: 0x04008E39 RID: 36409
		private int duration_;

		// Token: 0x04008E3A RID: 36410
		public const int DilationFieldNumber = 14;

		// Token: 0x04008E3B RID: 36411
		private int dilation_;
	}
}
