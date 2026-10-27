using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001134 RID: 4404
	[NetMessage(EMessageId.RTimeStopAnimPush)]
	public sealed class RTimeStopAnimPush : IMessage<RTimeStopAnimPush>, IMessage, IEquatable<RTimeStopAnimPush>, IDeepCloneable<RTimeStopAnimPush>, IBufferMessage
	{
		// Token: 0x060177D6 RID: 96214 RVA: 0x003696CC File Offset: 0x003678CC
		[NullableContext(1)]
		public static RTimeStopAnimPush Create()
		{
			return new RTimeStopAnimPush();
		}

		// Token: 0x17004ED8 RID: 20184
		// (get) Token: 0x060177D7 RID: 96215 RVA: 0x003696D3 File Offset: 0x003678D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ED9 RID: 20185
		// (get) Token: 0x060177D8 RID: 96216 RVA: 0x003696D6 File Offset: 0x003678D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopAnimPush.Descriptor;
			}
		}

		// Token: 0x060177D9 RID: 96217 RVA: 0x003696DD File Offset: 0x003678DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimPush()
		{
		}

		// Token: 0x060177DA RID: 96218 RVA: 0x003696E5 File Offset: 0x003678E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimPush(RTimeStopAnimPush other) : this()
		{
			this.duration_ = other.duration_;
			this.dilation_ = other.dilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060177DB RID: 96219 RVA: 0x00369716 File Offset: 0x00367916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopAnimPush Clone()
		{
			return new RTimeStopAnimPush(this);
		}

		// Token: 0x17004EDA RID: 20186
		// (get) Token: 0x060177DC RID: 96220 RVA: 0x0036971E File Offset: 0x0036791E
		// (set) Token: 0x060177DD RID: 96221 RVA: 0x00369726 File Offset: 0x00367926
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

		// Token: 0x17004EDB RID: 20187
		// (get) Token: 0x060177DE RID: 96222 RVA: 0x0036972F File Offset: 0x0036792F
		// (set) Token: 0x060177DF RID: 96223 RVA: 0x00369737 File Offset: 0x00367937
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

		// Token: 0x060177E0 RID: 96224 RVA: 0x00369740 File Offset: 0x00367940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopAnimPush);
		}

		// Token: 0x060177E1 RID: 96225 RVA: 0x0036974E File Offset: 0x0036794E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopAnimPush other)
		{
			return other != null && (other == this || (this.Duration == other.Duration && this.Dilation == other.Dilation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060177E2 RID: 96226 RVA: 0x0036978C File Offset: 0x0036798C
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

		// Token: 0x060177E3 RID: 96227 RVA: 0x003697E4 File Offset: 0x003679E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060177E4 RID: 96228 RVA: 0x003697F1 File Offset: 0x003679F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060177E5 RID: 96229 RVA: 0x003697FC File Offset: 0x003679FC
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
				output.WriteRawTag(64);
				output.WriteInt32(this.Dilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060177E6 RID: 96230 RVA: 0x00369858 File Offset: 0x00367A58
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

		// Token: 0x060177E7 RID: 96231 RVA: 0x003698B0 File Offset: 0x00367AB0
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

		// Token: 0x060177E8 RID: 96232 RVA: 0x00369900 File Offset: 0x00367B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060177E9 RID: 96233 RVA: 0x0036990C File Offset: 0x00367B0C
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
					if (num != 64U)
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

		// Token: 0x04008BA4 RID: 35748
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BA5 RID: 35749
		public const int DurationFieldNumber = 6;

		// Token: 0x04008BA6 RID: 35750
		private int duration_;

		// Token: 0x04008BA7 RID: 35751
		public const int DilationFieldNumber = 8;

		// Token: 0x04008BA8 RID: 35752
		private int dilation_;
	}
}
