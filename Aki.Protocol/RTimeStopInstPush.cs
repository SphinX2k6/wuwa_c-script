using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001137 RID: 4407
	[NetMessage(EMessageId.RTimeStopInstPush)]
	public sealed class RTimeStopInstPush : IMessage<RTimeStopInstPush>, IMessage, IEquatable<RTimeStopInstPush>, IDeepCloneable<RTimeStopInstPush>, IBufferMessage
	{
		// Token: 0x06017810 RID: 96272 RVA: 0x00369DDD File Offset: 0x00367FDD
		[NullableContext(1)]
		public static RTimeStopInstPush Create()
		{
			return new RTimeStopInstPush();
		}

		// Token: 0x17004EE3 RID: 20195
		// (get) Token: 0x06017811 RID: 96273 RVA: 0x00369DE4 File Offset: 0x00367FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EE4 RID: 20196
		// (get) Token: 0x06017812 RID: 96274 RVA: 0x00369DE7 File Offset: 0x00367FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RTimeStopInstPush.Descriptor;
			}
		}

		// Token: 0x06017813 RID: 96275 RVA: 0x00369DEE File Offset: 0x00367FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstPush()
		{
		}

		// Token: 0x06017814 RID: 96276 RVA: 0x00369DF6 File Offset: 0x00367FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstPush(RTimeStopInstPush other) : this()
		{
			this.flag_ = other.flag_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017815 RID: 96277 RVA: 0x00369E27 File Offset: 0x00368027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RTimeStopInstPush Clone()
		{
			return new RTimeStopInstPush(this);
		}

		// Token: 0x17004EE5 RID: 20197
		// (get) Token: 0x06017816 RID: 96278 RVA: 0x00369E2F File Offset: 0x0036802F
		// (set) Token: 0x06017817 RID: 96279 RVA: 0x00369E37 File Offset: 0x00368037
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

		// Token: 0x17004EE6 RID: 20198
		// (get) Token: 0x06017818 RID: 96280 RVA: 0x00369E40 File Offset: 0x00368040
		// (set) Token: 0x06017819 RID: 96281 RVA: 0x00369E48 File Offset: 0x00368048
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

		// Token: 0x0601781A RID: 96282 RVA: 0x00369E51 File Offset: 0x00368051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RTimeStopInstPush);
		}

		// Token: 0x0601781B RID: 96283 RVA: 0x00369E5F File Offset: 0x0036805F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RTimeStopInstPush other)
		{
			return other != null && (other == this || (this.Flag == other.Flag && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601781C RID: 96284 RVA: 0x00369EA0 File Offset: 0x003680A0
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

		// Token: 0x0601781D RID: 96285 RVA: 0x00369EF8 File Offset: 0x003680F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601781E RID: 96286 RVA: 0x00369F05 File Offset: 0x00368105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601781F RID: 96287 RVA: 0x00369F10 File Offset: 0x00368110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Duration);
			}
			if (this.Flag)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Flag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017820 RID: 96288 RVA: 0x00369F6C File Offset: 0x0036816C
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

		// Token: 0x06017821 RID: 96289 RVA: 0x00369FB8 File Offset: 0x003681B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RTimeStopInstPush other)
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

		// Token: 0x06017822 RID: 96290 RVA: 0x0036A008 File Offset: 0x00368208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017823 RID: 96291 RVA: 0x0036A014 File Offset: 0x00368214
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
				if (num != 104U)
				{
					if (num != 112U)
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

		// Token: 0x04008BB1 RID: 35761
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BB2 RID: 35762
		public const int FlagFieldNumber = 14;

		// Token: 0x04008BB3 RID: 35763
		private bool flag_;

		// Token: 0x04008BB4 RID: 35764
		public const int DurationFieldNumber = 13;

		// Token: 0x04008BB5 RID: 35765
		private int duration_;
	}
}
