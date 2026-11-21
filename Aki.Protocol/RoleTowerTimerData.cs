using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F8 RID: 4344
	public sealed class RoleTowerTimerData : IMessage<RoleTowerTimerData>, IMessage, IEquatable<RoleTowerTimerData>, IDeepCloneable<RoleTowerTimerData>, IBufferMessage
	{
		// Token: 0x06017394 RID: 95124 RVA: 0x00361526 File Offset: 0x0035F726
		[NullableContext(1)]
		public static RoleTowerTimerData Create()
		{
			return new RoleTowerTimerData();
		}

		// Token: 0x17004E05 RID: 19973
		// (get) Token: 0x06017395 RID: 95125 RVA: 0x0036152D File Offset: 0x0035F72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E06 RID: 19974
		// (get) Token: 0x06017396 RID: 95126 RVA: 0x00361530 File Offset: 0x0035F730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerTimerData.Descriptor;
			}
		}

		// Token: 0x06017397 RID: 95127 RVA: 0x00361537 File Offset: 0x0035F737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerData()
		{
		}

		// Token: 0x06017398 RID: 95128 RVA: 0x00361540 File Offset: 0x0035F740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerData(RoleTowerTimerData other) : this()
		{
			this.startTime_ = other.startTime_;
			this.duration_ = other.duration_;
			this.pauseEndTime_ = other.pauseEndTime_;
			this.pauseStartTime_ = other.pauseStartTime_;
			this.changeTime_ = other.changeTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017399 RID: 95129 RVA: 0x003615A0 File Offset: 0x0035F7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTimerData Clone()
		{
			return new RoleTowerTimerData(this);
		}

		// Token: 0x17004E07 RID: 19975
		// (get) Token: 0x0601739A RID: 95130 RVA: 0x003615A8 File Offset: 0x0035F7A8
		// (set) Token: 0x0601739B RID: 95131 RVA: 0x003615B0 File Offset: 0x0035F7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		// Token: 0x17004E08 RID: 19976
		// (get) Token: 0x0601739C RID: 95132 RVA: 0x003615B9 File Offset: 0x0035F7B9
		// (set) Token: 0x0601739D RID: 95133 RVA: 0x003615C1 File Offset: 0x0035F7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Duration
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

		// Token: 0x17004E09 RID: 19977
		// (get) Token: 0x0601739E RID: 95134 RVA: 0x003615CA File Offset: 0x0035F7CA
		// (set) Token: 0x0601739F RID: 95135 RVA: 0x003615D2 File Offset: 0x0035F7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PauseEndTime
		{
			get
			{
				return this.pauseEndTime_;
			}
			set
			{
				this.pauseEndTime_ = value;
			}
		}

		// Token: 0x17004E0A RID: 19978
		// (get) Token: 0x060173A0 RID: 95136 RVA: 0x003615DB File Offset: 0x0035F7DB
		// (set) Token: 0x060173A1 RID: 95137 RVA: 0x003615E3 File Offset: 0x0035F7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PauseStartTime
		{
			get
			{
				return this.pauseStartTime_;
			}
			set
			{
				this.pauseStartTime_ = value;
			}
		}

		// Token: 0x17004E0B RID: 19979
		// (get) Token: 0x060173A2 RID: 95138 RVA: 0x003615EC File Offset: 0x0035F7EC
		// (set) Token: 0x060173A3 RID: 95139 RVA: 0x003615F4 File Offset: 0x0035F7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ChangeTime
		{
			get
			{
				return this.changeTime_;
			}
			set
			{
				this.changeTime_ = value;
			}
		}

		// Token: 0x060173A4 RID: 95140 RVA: 0x003615FD File Offset: 0x0035F7FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerTimerData);
		}

		// Token: 0x060173A5 RID: 95141 RVA: 0x0036160C File Offset: 0x0035F80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerTimerData other)
		{
			return other != null && (other == this || (this.StartTime == other.StartTime && this.Duration == other.Duration && this.PauseEndTime == other.PauseEndTime && this.PauseStartTime == other.PauseStartTime && this.ChangeTime == other.ChangeTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060173A6 RID: 95142 RVA: 0x00361688 File Offset: 0x0035F888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.Duration != 0L)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this.PauseEndTime != 0L)
			{
				num ^= this.PauseEndTime.GetHashCode();
			}
			if (this.PauseStartTime != 0L)
			{
				num ^= this.PauseStartTime.GetHashCode();
			}
			if (this.ChangeTime != 0L)
			{
				num ^= this.ChangeTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060173A7 RID: 95143 RVA: 0x0036172B File Offset: 0x0035F92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060173A8 RID: 95144 RVA: 0x00361738 File Offset: 0x0035F938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060173A9 RID: 95145 RVA: 0x00361744 File Offset: 0x0035F944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.StartTime);
			}
			if (this.Duration != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Duration);
			}
			if (this.PauseEndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.PauseEndTime);
			}
			if (this.PauseStartTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.PauseStartTime);
			}
			if (this.ChangeTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.ChangeTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060173AA RID: 95146 RVA: 0x003617F0 File Offset: 0x0035F9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this.Duration != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Duration);
			}
			if (this.PauseEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PauseEndTime);
			}
			if (this.PauseStartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PauseStartTime);
			}
			if (this.ChangeTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ChangeTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060173AB RID: 95147 RVA: 0x00361890 File Offset: 0x0035FA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerTimerData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			if (other.Duration != 0L)
			{
				this.Duration = other.Duration;
			}
			if (other.PauseEndTime != 0L)
			{
				this.PauseEndTime = other.PauseEndTime;
			}
			if (other.PauseStartTime != 0L)
			{
				this.PauseStartTime = other.PauseStartTime;
			}
			if (other.ChangeTime != 0L)
			{
				this.ChangeTime = other.ChangeTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060173AC RID: 95148 RVA: 0x0036191C File Offset: 0x0035FB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060173AD RID: 95149 RVA: 0x00361928 File Offset: 0x0035FB28
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.StartTime = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.Duration = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.PauseEndTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.PauseStartTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.ChangeTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008AE9 RID: 35561
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AEA RID: 35562
		public const int StartTimeFieldNumber = 1;

		// Token: 0x04008AEB RID: 35563
		private long startTime_;

		// Token: 0x04008AEC RID: 35564
		public const int DurationFieldNumber = 2;

		// Token: 0x04008AED RID: 35565
		private long duration_;

		// Token: 0x04008AEE RID: 35566
		public const int PauseEndTimeFieldNumber = 3;

		// Token: 0x04008AEF RID: 35567
		private long pauseEndTime_;

		// Token: 0x04008AF0 RID: 35568
		public const int PauseStartTimeFieldNumber = 4;

		// Token: 0x04008AF1 RID: 35569
		private long pauseStartTime_;

		// Token: 0x04008AF2 RID: 35570
		public const int ChangeTimeFieldNumber = 5;

		// Token: 0x04008AF3 RID: 35571
		private long changeTime_;
	}
}
