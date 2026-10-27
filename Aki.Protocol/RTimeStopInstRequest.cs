using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001138 RID: 4408
	[NetMessage(EMessageId.RTimeStopInstRequest)]
	public sealed class RTimeStopInstRequest : IMessage<RTimeStopInstRequest>, IMessage, IEquatable<RTimeStopInstRequest>, IDeepCloneable<RTimeStopInstRequest>, IBufferMessage
	{
		// Token: 0x06017824 RID: 96292 RVA: 0x0036A06C File Offset: 0x0036826C
		[NullableContext(1)]
		public static RTimeStopInstRequest Create()
		{
			return new RTimeStopInstRequest();
		}

		// Token: 0x17004EE7 RID: 20199
		// (get) Token: 0x06017825 RID: 96293 RVA: 0x0036A073 File Offset: 0x00368273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EE8 RID: 20200
		// (get) Token: 0x06017826 RID: 96294 RVA: 0x0036A076 File Offset: 0x00368276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopInstRequest.Descriptor;
			}
		}

		// Token: 0x06017827 RID: 96295 RVA: 0x0036A07D File Offset: 0x0036827D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstRequest()
		{
		}

		// Token: 0x06017828 RID: 96296 RVA: 0x0036A085 File Offset: 0x00368285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstRequest(RTimeStopInstRequest other) : this()
		{
			this.flag_ = other.flag_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017829 RID: 96297 RVA: 0x0036A0B6 File Offset: 0x003682B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstRequest Clone()
		{
			return new RTimeStopInstRequest(this);
		}

		// Token: 0x17004EE9 RID: 20201
		// (get) Token: 0x0601782A RID: 96298 RVA: 0x0036A0BE File Offset: 0x003682BE
		// (set) Token: 0x0601782B RID: 96299 RVA: 0x0036A0C6 File Offset: 0x003682C6
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

		// Token: 0x17004EEA RID: 20202
		// (get) Token: 0x0601782C RID: 96300 RVA: 0x0036A0CF File Offset: 0x003682CF
		// (set) Token: 0x0601782D RID: 96301 RVA: 0x0036A0D7 File Offset: 0x003682D7
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

		// Token: 0x0601782E RID: 96302 RVA: 0x0036A0E0 File Offset: 0x003682E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopInstRequest);
		}

		// Token: 0x0601782F RID: 96303 RVA: 0x0036A0EE File Offset: 0x003682EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopInstRequest other)
		{
			return other != null && (other == this || (this.Flag == other.Flag && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017830 RID: 96304 RVA: 0x0036A12C File Offset: 0x0036832C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Flag)
			{
				num ^= this.Flag.GetHashCode();
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

		// Token: 0x06017831 RID: 96305 RVA: 0x0036A184 File Offset: 0x00368384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017832 RID: 96306 RVA: 0x0036A191 File Offset: 0x00368391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017833 RID: 96307 RVA: 0x0036A19C File Offset: 0x0036839C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Duration);
			}
			if (this.Flag)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Flag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017834 RID: 96308 RVA: 0x0036A1F8 File Offset: 0x003683F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Flag)
			{
				num += 2;
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

		// Token: 0x06017835 RID: 96309 RVA: 0x0036A244 File Offset: 0x00368444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopInstRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Flag)
			{
				this.Flag = other.Flag;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017836 RID: 96310 RVA: 0x0036A294 File Offset: 0x00368494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017837 RID: 96311 RVA: 0x0036A2A0 File Offset: 0x003684A0
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
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04008BB6 RID: 35766
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BB7 RID: 35767
		public const int FlagFieldNumber = 11;

		// Token: 0x04008BB8 RID: 35768
		private bool flag_;

		// Token: 0x04008BB9 RID: 35769
		public const int DurationFieldNumber = 6;

		// Token: 0x04008BBA RID: 35770
		private int duration_;
	}
}
