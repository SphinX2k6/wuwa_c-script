using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136C RID: 4972
	[NetMessage(EMessageId.TimeCheckNotify)]
	public sealed class TimeCheckNotify : IMessage<TimeCheckNotify>, IMessage, IEquatable<TimeCheckNotify>, IDeepCloneable<TimeCheckNotify>, IBufferMessage
	{
		// Token: 0x0601A666 RID: 108134 RVA: 0x003D5271 File Offset: 0x003D3471
		[NullableContext(1)]
		public static TimeCheckNotify Create()
		{
			return new TimeCheckNotify();
		}

		// Token: 0x17005909 RID: 22793
		// (get) Token: 0x0601A667 RID: 108135 RVA: 0x003D5278 File Offset: 0x003D3478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700590A RID: 22794
		// (get) Token: 0x0601A668 RID: 108136 RVA: 0x003D527B File Offset: 0x003D347B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeCheckNotify.Descriptor;
			}
		}

		// Token: 0x0601A669 RID: 108137 RVA: 0x003D5282 File Offset: 0x003D3482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckNotify()
		{
		}

		// Token: 0x0601A66A RID: 108138 RVA: 0x003D528C File Offset: 0x003D348C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckNotify(TimeCheckNotify other) : this()
		{
			this.clientTime_ = other.clientTime_;
			this.serverTime_ = other.serverTime_;
			this.serverStopTime_ = other.serverStopTime_;
			this.sceneStopTime_ = other.sceneStopTime_;
			this.flowTime_ = other.flowTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A66B RID: 108139 RVA: 0x003D52EC File Offset: 0x003D34EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckNotify Clone()
		{
			return new TimeCheckNotify(this);
		}

		// Token: 0x1700590B RID: 22795
		// (get) Token: 0x0601A66C RID: 108140 RVA: 0x003D52F4 File Offset: 0x003D34F4
		// (set) Token: 0x0601A66D RID: 108141 RVA: 0x003D52FC File Offset: 0x003D34FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ClientTime
		{
			get
			{
				return this.clientTime_;
			}
			set
			{
				this.clientTime_ = value;
			}
		}

		// Token: 0x1700590C RID: 22796
		// (get) Token: 0x0601A66E RID: 108142 RVA: 0x003D5305 File Offset: 0x003D3505
		// (set) Token: 0x0601A66F RID: 108143 RVA: 0x003D530D File Offset: 0x003D350D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ServerTime
		{
			get
			{
				return this.serverTime_;
			}
			set
			{
				this.serverTime_ = value;
			}
		}

		// Token: 0x1700590D RID: 22797
		// (get) Token: 0x0601A670 RID: 108144 RVA: 0x003D5316 File Offset: 0x003D3516
		// (set) Token: 0x0601A671 RID: 108145 RVA: 0x003D531E File Offset: 0x003D351E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ServerStopTime
		{
			get
			{
				return this.serverStopTime_;
			}
			set
			{
				this.serverStopTime_ = value;
			}
		}

		// Token: 0x1700590E RID: 22798
		// (get) Token: 0x0601A672 RID: 108146 RVA: 0x003D5327 File Offset: 0x003D3527
		// (set) Token: 0x0601A673 RID: 108147 RVA: 0x003D532F File Offset: 0x003D352F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SceneStopTime
		{
			get
			{
				return this.sceneStopTime_;
			}
			set
			{
				this.sceneStopTime_ = value;
			}
		}

		// Token: 0x1700590F RID: 22799
		// (get) Token: 0x0601A674 RID: 108148 RVA: 0x003D5338 File Offset: 0x003D3538
		// (set) Token: 0x0601A675 RID: 108149 RVA: 0x003D5340 File Offset: 0x003D3540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FlowTime
		{
			get
			{
				return this.flowTime_;
			}
			set
			{
				this.flowTime_ = value;
			}
		}

		// Token: 0x0601A676 RID: 108150 RVA: 0x003D5349 File Offset: 0x003D3549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeCheckNotify);
		}

		// Token: 0x0601A677 RID: 108151 RVA: 0x003D5358 File Offset: 0x003D3558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeCheckNotify other)
		{
			return other != null && (other == this || (this.ClientTime == other.ClientTime && this.ServerTime == other.ServerTime && this.ServerStopTime == other.ServerStopTime && this.SceneStopTime == other.SceneStopTime && this.FlowTime == other.FlowTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A678 RID: 108152 RVA: 0x003D53D4 File Offset: 0x003D35D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ClientTime != 0L)
			{
				num ^= this.ClientTime.GetHashCode();
			}
			if (this.ServerTime != 0L)
			{
				num ^= this.ServerTime.GetHashCode();
			}
			if (this.ServerStopTime != 0L)
			{
				num ^= this.ServerStopTime.GetHashCode();
			}
			if (this.SceneStopTime != 0L)
			{
				num ^= this.SceneStopTime.GetHashCode();
			}
			if (this.FlowTime != 0L)
			{
				num ^= this.FlowTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A679 RID: 108153 RVA: 0x003D5477 File Offset: 0x003D3677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A67A RID: 108154 RVA: 0x003D5484 File Offset: 0x003D3684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A67B RID: 108155 RVA: 0x003D5490 File Offset: 0x003D3690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.FlowTime);
			}
			if (this.ServerStopTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.ServerStopTime);
			}
			if (this.ServerTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.ServerTime);
			}
			if (this.ClientTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.ClientTime);
			}
			if (this.SceneStopTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.SceneStopTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A67C RID: 108156 RVA: 0x003D5540 File Offset: 0x003D3740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ClientTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ClientTime);
			}
			if (this.ServerTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ServerTime);
			}
			if (this.ServerStopTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ServerStopTime);
			}
			if (this.SceneStopTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SceneStopTime);
			}
			if (this.FlowTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FlowTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A67D RID: 108157 RVA: 0x003D55E0 File Offset: 0x003D37E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimeCheckNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ClientTime != 0L)
			{
				this.ClientTime = other.ClientTime;
			}
			if (other.ServerTime != 0L)
			{
				this.ServerTime = other.ServerTime;
			}
			if (other.ServerStopTime != 0L)
			{
				this.ServerStopTime = other.ServerStopTime;
			}
			if (other.SceneStopTime != 0L)
			{
				this.SceneStopTime = other.SceneStopTime;
			}
			if (other.FlowTime != 0L)
			{
				this.FlowTime = other.FlowTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A67E RID: 108158 RVA: 0x003D566C File Offset: 0x003D386C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A67F RID: 108159 RVA: 0x003D5678 File Offset: 0x003D3878
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
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.FlowTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.ServerStopTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.ServerTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.ClientTime = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.SceneStopTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040099BA RID: 39354
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099BB RID: 39355
		public const int ClientTimeFieldNumber = 7;

		// Token: 0x040099BC RID: 39356
		private long clientTime_;

		// Token: 0x040099BD RID: 39357
		public const int ServerTimeFieldNumber = 6;

		// Token: 0x040099BE RID: 39358
		private long serverTime_;

		// Token: 0x040099BF RID: 39359
		public const int ServerStopTimeFieldNumber = 5;

		// Token: 0x040099C0 RID: 39360
		private long serverStopTime_;

		// Token: 0x040099C1 RID: 39361
		public const int SceneStopTimeFieldNumber = 15;

		// Token: 0x040099C2 RID: 39362
		private long sceneStopTime_;

		// Token: 0x040099C3 RID: 39363
		public const int FlowTimeFieldNumber = 4;

		// Token: 0x040099C4 RID: 39364
		private long flowTime_;
	}
}
