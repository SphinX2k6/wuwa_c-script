using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001295 RID: 4757
	[NetMessage(EMessageId.SlowTimePush)]
	public sealed class SlowTimePush : IMessage<SlowTimePush>, IMessage, IEquatable<SlowTimePush>, IDeepCloneable<SlowTimePush>, IBufferMessage
	{
		// Token: 0x0601963F RID: 103999 RVA: 0x003B3F61 File Offset: 0x003B2161
		[NullableContext(1)]
		public static SlowTimePush Create()
		{
			return new SlowTimePush();
		}

		// Token: 0x170055E2 RID: 21986
		// (get) Token: 0x06019640 RID: 104000 RVA: 0x003B3F68 File Offset: 0x003B2168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055E3 RID: 21987
		// (get) Token: 0x06019641 RID: 104001 RVA: 0x003B3F6B File Offset: 0x003B216B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlowTimePush.Descriptor;
			}
		}

		// Token: 0x06019642 RID: 104002 RVA: 0x003B3F72 File Offset: 0x003B2172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlowTimePush()
		{
		}

		// Token: 0x06019643 RID: 104003 RVA: 0x003B3F7A File Offset: 0x003B217A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlowTimePush(SlowTimePush other) : this()
		{
			this.flag_ = other.flag_;
			this.dilation_ = other.dilation_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019644 RID: 104004 RVA: 0x003B3FB7 File Offset: 0x003B21B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlowTimePush Clone()
		{
			return new SlowTimePush(this);
		}

		// Token: 0x170055E4 RID: 21988
		// (get) Token: 0x06019645 RID: 104005 RVA: 0x003B3FBF File Offset: 0x003B21BF
		// (set) Token: 0x06019646 RID: 104006 RVA: 0x003B3FC7 File Offset: 0x003B21C7
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

		// Token: 0x170055E5 RID: 21989
		// (get) Token: 0x06019647 RID: 104007 RVA: 0x003B3FD0 File Offset: 0x003B21D0
		// (set) Token: 0x06019648 RID: 104008 RVA: 0x003B3FD8 File Offset: 0x003B21D8
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

		// Token: 0x170055E6 RID: 21990
		// (get) Token: 0x06019649 RID: 104009 RVA: 0x003B3FE1 File Offset: 0x003B21E1
		// (set) Token: 0x0601964A RID: 104010 RVA: 0x003B3FE9 File Offset: 0x003B21E9
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

		// Token: 0x0601964B RID: 104011 RVA: 0x003B3FF2 File Offset: 0x003B21F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlowTimePush);
		}

		// Token: 0x0601964C RID: 104012 RVA: 0x003B4000 File Offset: 0x003B2200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlowTimePush other)
		{
			return other != null && (other == this || (this.Flag == other.Flag && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Dilation, other.Dilation) && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601964D RID: 104013 RVA: 0x003B4064 File Offset: 0x003B2264
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

		// Token: 0x0601964E RID: 104014 RVA: 0x003B40DC File Offset: 0x003B22DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601964F RID: 104015 RVA: 0x003B40E9 File Offset: 0x003B22E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019650 RID: 104016 RVA: 0x003B40F4 File Offset: 0x003B22F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Duration);
			}
			if (this.Flag)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Flag);
			}
			if (this.Dilation != 0f)
			{
				output.WriteRawTag(117);
				output.WriteFloat(this.Dilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019651 RID: 104017 RVA: 0x003B4170 File Offset: 0x003B2370
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

		// Token: 0x06019652 RID: 104018 RVA: 0x003B41CC File Offset: 0x003B23CC
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

		// Token: 0x06019653 RID: 104019 RVA: 0x003B4235 File Offset: 0x003B2435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019654 RID: 104020 RVA: 0x003B4240 File Offset: 0x003B2440
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
					if (num != 72U)
					{
						if (num != 117U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Duration = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009624 RID: 38436
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009625 RID: 38437
		public const int FlagFieldNumber = 9;

		// Token: 0x04009626 RID: 38438
		private bool flag_;

		// Token: 0x04009627 RID: 38439
		public const int DilationFieldNumber = 14;

		// Token: 0x04009628 RID: 38440
		private float dilation_;

		// Token: 0x04009629 RID: 38441
		public const int DurationFieldNumber = 3;

		// Token: 0x0400962A RID: 38442
		private int duration_;
	}
}
