using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001258 RID: 4696
	[NetMessage(EMessageId.SlowTimePush)]
	public sealed class SlowTimePush : IMessage<SlowTimePush>, IMessage, IEquatable<SlowTimePush>, IDeepCloneable<SlowTimePush>, IBufferMessage
	{
		// Token: 0x06019055 RID: 102485 RVA: 0x003A4011 File Offset: 0x003A2211
		[NullableContext(1)]
		public static SlowTimePush Create()
		{
			return new SlowTimePush();
		}

		// Token: 0x17005463 RID: 21603
		// (get) Token: 0x06019056 RID: 102486 RVA: 0x003A4018 File Offset: 0x003A2218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005464 RID: 21604
		// (get) Token: 0x06019057 RID: 102487 RVA: 0x003A401B File Offset: 0x003A221B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlowTimePush.Descriptor;
			}
		}

		// Token: 0x06019058 RID: 102488 RVA: 0x003A4022 File Offset: 0x003A2222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlowTimePush()
		{
		}

		// Token: 0x06019059 RID: 102489 RVA: 0x003A402A File Offset: 0x003A222A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlowTimePush(SlowTimePush other) : this()
		{
			this.flag_ = other.flag_;
			this.dilation_ = other.dilation_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601905A RID: 102490 RVA: 0x003A4067 File Offset: 0x003A2267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlowTimePush Clone()
		{
			return new SlowTimePush(this);
		}

		// Token: 0x17005465 RID: 21605
		// (get) Token: 0x0601905B RID: 102491 RVA: 0x003A406F File Offset: 0x003A226F
		// (set) Token: 0x0601905C RID: 102492 RVA: 0x003A4077 File Offset: 0x003A2277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Flag
		{
			get
			{
				return this.flag_;
			}
			set
			{
				this.flag_ = value;
			}
		}

		// Token: 0x17005466 RID: 21606
		// (get) Token: 0x0601905D RID: 102493 RVA: 0x003A4080 File Offset: 0x003A2280
		// (set) Token: 0x0601905E RID: 102494 RVA: 0x003A4088 File Offset: 0x003A2288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Dilation
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

		// Token: 0x17005467 RID: 21607
		// (get) Token: 0x0601905F RID: 102495 RVA: 0x003A4091 File Offset: 0x003A2291
		// (set) Token: 0x06019060 RID: 102496 RVA: 0x003A4099 File Offset: 0x003A2299
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

		// Token: 0x06019061 RID: 102497 RVA: 0x003A40A2 File Offset: 0x003A22A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlowTimePush);
		}

		// Token: 0x06019062 RID: 102498 RVA: 0x003A40B0 File Offset: 0x003A22B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlowTimePush other)
		{
			return other != null && (other == this || (this.Flag == other.Flag && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Dilation, other.Dilation) && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019063 RID: 102499 RVA: 0x003A4114 File Offset: 0x003A2314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Flag)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this.Dilation != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Dilation);
			}
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019064 RID: 102500 RVA: 0x003A418C File Offset: 0x003A238C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019065 RID: 102501 RVA: 0x003A4199 File Offset: 0x003A2399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019066 RID: 102502 RVA: 0x003A41A4 File Offset: 0x003A23A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Flag)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Flag);
			}
			if (this.Dilation != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.Dilation);
			}
			if (this.Duration != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019067 RID: 102503 RVA: 0x003A4220 File Offset: 0x003A2420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Flag)
			{
				num += 2;
			}
			if (this.Dilation != 0f)
			{
				num += 5;
			}
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019068 RID: 102504 RVA: 0x003A427C File Offset: 0x003A247C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlowTimePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Flag)
			{
				this.Flag = other.Flag;
			}
			if (other.Dilation != 0f)
			{
				this.Dilation = other.Dilation;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019069 RID: 102505 RVA: 0x003A42E5 File Offset: 0x003A24E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601906A RID: 102506 RVA: 0x003A42F0 File Offset: 0x003A24F0
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
					if (num != 101U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Duration = input.ReadInt32();
						}
					}
					else
					{
						this.Dilation = input.ReadFloat();
					}
				}
				else
				{
					this.Flag = input.ReadBool();
				}
			}
		}

		// Token: 0x04009372 RID: 37746
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009373 RID: 37747
		public const int FlagFieldNumber = 3;

		// Token: 0x04009374 RID: 37748
		private bool flag_;

		// Token: 0x04009375 RID: 37749
		public const int DilationFieldNumber = 12;

		// Token: 0x04009376 RID: 37750
		private float dilation_;

		// Token: 0x04009377 RID: 37751
		public const int DurationFieldNumber = 13;

		// Token: 0x04009378 RID: 37752
		private int duration_;
	}
}
