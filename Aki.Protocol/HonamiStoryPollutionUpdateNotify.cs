using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000782 RID: 1922
	[NetMessage(EMessageId.HonamiStoryPollutionUpdateNotify)]
	public sealed class HonamiStoryPollutionUpdateNotify : IMessage<HonamiStoryPollutionUpdateNotify>, IMessage, IEquatable<HonamiStoryPollutionUpdateNotify>, IDeepCloneable<HonamiStoryPollutionUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600ADDE RID: 44510 RVA: 0x001A1F5A File Offset: 0x001A015A
		[NullableContext(1)]
		public static HonamiStoryPollutionUpdateNotify Create()
		{
			return new HonamiStoryPollutionUpdateNotify();
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x0600ADDF RID: 44511 RVA: 0x001A1F61 File Offset: 0x001A0161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x0600ADE0 RID: 44512 RVA: 0x001A1F64 File Offset: 0x001A0164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPollutionUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600ADE1 RID: 44513 RVA: 0x001A1F6B File Offset: 0x001A016B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionUpdateNotify()
		{
		}

		// Token: 0x0600ADE2 RID: 44514 RVA: 0x001A1F73 File Offset: 0x001A0173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionUpdateNotify(HonamiStoryPollutionUpdateNotify other) : this()
		{
			this.pollutionLevel_ = other.pollutionLevel_;
			this.pollutionStartTime_ = other.pollutionStartTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADE3 RID: 44515 RVA: 0x001A1FA4 File Offset: 0x001A01A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionUpdateNotify Clone()
		{
			return new HonamiStoryPollutionUpdateNotify(this);
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x0600ADE4 RID: 44516 RVA: 0x001A1FAC File Offset: 0x001A01AC
		// (set) Token: 0x0600ADE5 RID: 44517 RVA: 0x001A1FB4 File Offset: 0x001A01B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PollutionLevel
		{
			get
			{
				return this.pollutionLevel_;
			}
			set
			{
				this.pollutionLevel_ = value;
			}
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x0600ADE6 RID: 44518 RVA: 0x001A1FBD File Offset: 0x001A01BD
		// (set) Token: 0x0600ADE7 RID: 44519 RVA: 0x001A1FC5 File Offset: 0x001A01C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PollutionStartTime
		{
			get
			{
				return this.pollutionStartTime_;
			}
			set
			{
				this.pollutionStartTime_ = value;
			}
		}

		// Token: 0x0600ADE8 RID: 44520 RVA: 0x001A1FCE File Offset: 0x001A01CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPollutionUpdateNotify);
		}

		// Token: 0x0600ADE9 RID: 44521 RVA: 0x001A1FDC File Offset: 0x001A01DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPollutionUpdateNotify other)
		{
			return other != null && (other == this || (this.PollutionLevel == other.PollutionLevel && this.PollutionStartTime == other.PollutionStartTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ADEA RID: 44522 RVA: 0x001A201C File Offset: 0x001A021C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PollutionLevel != 0)
			{
				num ^= this.PollutionLevel.GetHashCode();
			}
			if (this.PollutionStartTime != 0L)
			{
				num ^= this.PollutionStartTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADEB RID: 44523 RVA: 0x001A2074 File Offset: 0x001A0274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ADEC RID: 44524 RVA: 0x001A2081 File Offset: 0x001A0281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADED RID: 44525 RVA: 0x001A208C File Offset: 0x001A028C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PollutionStartTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.PollutionStartTime);
			}
			if (this.PollutionLevel != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PollutionLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADEE RID: 44526 RVA: 0x001A20E8 File Offset: 0x001A02E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PollutionLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PollutionLevel);
			}
			if (this.PollutionStartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PollutionStartTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADEF RID: 44527 RVA: 0x001A2140 File Offset: 0x001A0340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryPollutionUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PollutionLevel != 0)
			{
				this.PollutionLevel = other.PollutionLevel;
			}
			if (other.PollutionStartTime != 0L)
			{
				this.PollutionStartTime = other.PollutionStartTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ADF0 RID: 44528 RVA: 0x001A2190 File Offset: 0x001A0390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADF1 RID: 44529 RVA: 0x001A219C File Offset: 0x001A039C
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PollutionLevel = input.ReadInt32();
					}
				}
				else
				{
					this.PollutionStartTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004EE1 RID: 20193
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EE2 RID: 20194
		public const int PollutionLevelFieldNumber = 5;

		// Token: 0x04004EE3 RID: 20195
		private int pollutionLevel_;

		// Token: 0x04004EE4 RID: 20196
		public const int PollutionStartTimeFieldNumber = 3;

		// Token: 0x04004EE5 RID: 20197
		private long pollutionStartTime_;
	}
}
