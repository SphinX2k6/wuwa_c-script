using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DF RID: 5087
	[NetMessage(EMessageId.TimeCheckNotify)]
	public sealed class TimeCheckNotify : IMessage<TimeCheckNotify>, IMessage, IEquatable<TimeCheckNotify>, IDeepCloneable<TimeCheckNotify>, IBufferMessage
	{
		// Token: 0x0601B0EF RID: 110831 RVA: 0x003F0481 File Offset: 0x003EE681
		[NullableContext(1)]
		public static TimeCheckNotify Create()
		{
			return new TimeCheckNotify();
		}

		// Token: 0x17005B9D RID: 23453
		// (get) Token: 0x0601B0F0 RID: 110832 RVA: 0x003F0488 File Offset: 0x003EE688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B9E RID: 23454
		// (get) Token: 0x0601B0F1 RID: 110833 RVA: 0x003F048B File Offset: 0x003EE68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeCheckNotify.Descriptor;
			}
		}

		// Token: 0x0601B0F2 RID: 110834 RVA: 0x003F0492 File Offset: 0x003EE692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckNotify()
		{
		}

		// Token: 0x0601B0F3 RID: 110835 RVA: 0x003F049C File Offset: 0x003EE69C
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

		// Token: 0x0601B0F4 RID: 110836 RVA: 0x003F04FC File Offset: 0x003EE6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeCheckNotify Clone()
		{
			return new TimeCheckNotify(this);
		}

		// Token: 0x17005B9F RID: 23455
		// (get) Token: 0x0601B0F5 RID: 110837 RVA: 0x003F0504 File Offset: 0x003EE704
		// (set) Token: 0x0601B0F6 RID: 110838 RVA: 0x003F050C File Offset: 0x003EE70C
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

		// Token: 0x17005BA0 RID: 23456
		// (get) Token: 0x0601B0F7 RID: 110839 RVA: 0x003F0515 File Offset: 0x003EE715
		// (set) Token: 0x0601B0F8 RID: 110840 RVA: 0x003F051D File Offset: 0x003EE71D
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

		// Token: 0x17005BA1 RID: 23457
		// (get) Token: 0x0601B0F9 RID: 110841 RVA: 0x003F0526 File Offset: 0x003EE726
		// (set) Token: 0x0601B0FA RID: 110842 RVA: 0x003F052E File Offset: 0x003EE72E
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

		// Token: 0x17005BA2 RID: 23458
		// (get) Token: 0x0601B0FB RID: 110843 RVA: 0x003F0537 File Offset: 0x003EE737
		// (set) Token: 0x0601B0FC RID: 110844 RVA: 0x003F053F File Offset: 0x003EE73F
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

		// Token: 0x17005BA3 RID: 23459
		// (get) Token: 0x0601B0FD RID: 110845 RVA: 0x003F0548 File Offset: 0x003EE748
		// (set) Token: 0x0601B0FE RID: 110846 RVA: 0x003F0550 File Offset: 0x003EE750
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

		// Token: 0x0601B0FF RID: 110847 RVA: 0x003F0559 File Offset: 0x003EE759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeCheckNotify);
		}

		// Token: 0x0601B100 RID: 110848 RVA: 0x003F0568 File Offset: 0x003EE768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeCheckNotify other)
		{
			return other != null && (other == this || (this.ClientTime == other.ClientTime && this.ServerTime == other.ServerTime && this.ServerStopTime == other.ServerStopTime && this.SceneStopTime == other.SceneStopTime && this.FlowTime == other.FlowTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B101 RID: 110849 RVA: 0x003F05E4 File Offset: 0x003EE7E4
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

		// Token: 0x0601B102 RID: 110850 RVA: 0x003F0687 File Offset: 0x003EE887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B103 RID: 110851 RVA: 0x003F0694 File Offset: 0x003EE894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B104 RID: 110852 RVA: 0x003F06A0 File Offset: 0x003EE8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ServerStopTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.ServerStopTime);
			}
			if (this.ServerTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.ServerTime);
			}
			if (this.SceneStopTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.SceneStopTime);
			}
			if (this.ClientTime != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.ClientTime);
			}
			if (this.FlowTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.FlowTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B105 RID: 110853 RVA: 0x003F0750 File Offset: 0x003EE950
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

		// Token: 0x0601B106 RID: 110854 RVA: 0x003F07F0 File Offset: 0x003EE9F0
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

		// Token: 0x0601B107 RID: 110855 RVA: 0x003F087C File Offset: 0x003EEA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B108 RID: 110856 RVA: 0x003F0888 File Offset: 0x003EEA88
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
				if (num <= 72U)
				{
					if (num == 32U)
					{
						this.ServerStopTime = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.ServerTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.SceneStopTime = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.ClientTime = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.FlowTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009DFF RID: 40447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E00 RID: 40448
		public const int ClientTimeFieldNumber = 13;

		// Token: 0x04009E01 RID: 40449
		private long clientTime_;

		// Token: 0x04009E02 RID: 40450
		public const int ServerTimeFieldNumber = 9;

		// Token: 0x04009E03 RID: 40451
		private long serverTime_;

		// Token: 0x04009E04 RID: 40452
		public const int ServerStopTimeFieldNumber = 4;

		// Token: 0x04009E05 RID: 40453
		private long serverStopTime_;

		// Token: 0x04009E06 RID: 40454
		public const int SceneStopTimeFieldNumber = 10;

		// Token: 0x04009E07 RID: 40455
		private long sceneStopTime_;

		// Token: 0x04009E08 RID: 40456
		public const int FlowTimeFieldNumber = 15;

		// Token: 0x04009E09 RID: 40457
		private long flowTime_;
	}
}
