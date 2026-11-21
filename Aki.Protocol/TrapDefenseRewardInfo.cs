using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B4 RID: 5300
	public sealed class TrapDefenseRewardInfo : IMessage<TrapDefenseRewardInfo>, IMessage, IEquatable<TrapDefenseRewardInfo>, IDeepCloneable<TrapDefenseRewardInfo>, IBufferMessage
	{
		// Token: 0x0601C1F9 RID: 115193 RVA: 0x004153E0 File Offset: 0x004135E0
		[NullableContext(1)]
		public static TrapDefenseRewardInfo Create()
		{
			return new TrapDefenseRewardInfo();
		}

		// Token: 0x17005F32 RID: 24370
		// (get) Token: 0x0601C1FA RID: 115194 RVA: 0x004153E7 File Offset: 0x004135E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseRewardInfo> Parser
		{
			get
			{
				return TrapDefenseRewardInfo._parser;
			}
		}

		// Token: 0x17005F33 RID: 24371
		// (get) Token: 0x0601C1FB RID: 115195 RVA: 0x004153EE File Offset: 0x004135EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F34 RID: 24372
		// (get) Token: 0x0601C1FC RID: 115196 RVA: 0x004153F1 File Offset: 0x004135F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRewardInfo.Descriptor;
			}
		}

		// Token: 0x0601C1FD RID: 115197 RVA: 0x004153F8 File Offset: 0x004135F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardInfo()
		{
		}

		// Token: 0x0601C1FE RID: 115198 RVA: 0x00415400 File Offset: 0x00413600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardInfo(TrapDefenseRewardInfo other) : this()
		{
			this.taskInfo_ = ((other.taskInfo_ != null) ? other.taskInfo_.Clone() : null);
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1FF RID: 115199 RVA: 0x00415458 File Offset: 0x00413658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardInfo Clone()
		{
			return new TrapDefenseRewardInfo(this);
		}

		// Token: 0x17005F35 RID: 24373
		// (get) Token: 0x0601C200 RID: 115200 RVA: 0x00415460 File Offset: 0x00413660
		// (set) Token: 0x0601C201 RID: 115201 RVA: 0x00415468 File Offset: 0x00413668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask TaskInfo
		{
			get
			{
				return this.taskInfo_;
			}
			set
			{
				this.taskInfo_ = value;
			}
		}

		// Token: 0x17005F36 RID: 24374
		// (get) Token: 0x0601C202 RID: 115202 RVA: 0x00415471 File Offset: 0x00413671
		// (set) Token: 0x0601C203 RID: 115203 RVA: 0x00415479 File Offset: 0x00413679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitBeginTime
		{
			get
			{
				return this.limitBeginTime_;
			}
			set
			{
				this.limitBeginTime_ = value;
			}
		}

		// Token: 0x17005F37 RID: 24375
		// (get) Token: 0x0601C204 RID: 115204 RVA: 0x00415482 File Offset: 0x00413682
		// (set) Token: 0x0601C205 RID: 115205 RVA: 0x0041548A File Offset: 0x0041368A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitEndTime
		{
			get
			{
				return this.limitEndTime_;
			}
			set
			{
				this.limitEndTime_ = value;
			}
		}

		// Token: 0x0601C206 RID: 115206 RVA: 0x00415493 File Offset: 0x00413693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRewardInfo);
		}

		// Token: 0x0601C207 RID: 115207 RVA: 0x004154A4 File Offset: 0x004136A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRewardInfo other)
		{
			return other != null && (other == this || (object.Equals(this.TaskInfo, other.TaskInfo) && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C208 RID: 115208 RVA: 0x00415504 File Offset: 0x00413704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.taskInfo_ != null)
			{
				num ^= this.TaskInfo.GetHashCode();
			}
			if (this.LimitBeginTime != 0L)
			{
				num ^= this.LimitBeginTime.GetHashCode();
			}
			if (this.LimitEndTime != 0L)
			{
				num ^= this.LimitEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C209 RID: 115209 RVA: 0x00415572 File Offset: 0x00413772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C20A RID: 115210 RVA: 0x0041557F File Offset: 0x0041377F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C20B RID: 115211 RVA: 0x00415588 File Offset: 0x00413788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.taskInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TaskInfo);
			}
			if (this.LimitBeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C20C RID: 115212 RVA: 0x00415600 File Offset: 0x00413800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.taskInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TaskInfo);
			}
			if (this.LimitBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C20D RID: 115213 RVA: 0x00415670 File Offset: 0x00413870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.taskInfo_ != null)
			{
				if (this.taskInfo_ == null)
				{
					this.TaskInfo = new ConditionTask();
				}
				this.TaskInfo.MergeFrom(other.TaskInfo);
			}
			if (other.LimitBeginTime != 0L)
			{
				this.LimitBeginTime = other.LimitBeginTime;
			}
			if (other.LimitEndTime != 0L)
			{
				this.LimitEndTime = other.LimitEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C20E RID: 115214 RVA: 0x004156EC File Offset: 0x004138EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C20F RID: 115215 RVA: 0x004156F8 File Offset: 0x004138F8
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LimitEndTime = input.ReadInt64();
						}
					}
					else
					{
						this.LimitBeginTime = input.ReadInt64();
					}
				}
				else
				{
					if (this.taskInfo_ == null)
					{
						this.TaskInfo = new ConditionTask();
					}
					input.ReadMessage(this.TaskInfo);
				}
			}
		}

		// Token: 0x0400A2C4 RID: 41668
		private static readonly MessageParser<TrapDefenseRewardInfo> _parser = new MessageParser<TrapDefenseRewardInfo>(() => new TrapDefenseRewardInfo());

		// Token: 0x0400A2C5 RID: 41669
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2C6 RID: 41670
		public const int TaskInfoFieldNumber = 1;

		// Token: 0x0400A2C7 RID: 41671
		private ConditionTask taskInfo_;

		// Token: 0x0400A2C8 RID: 41672
		public const int LimitBeginTimeFieldNumber = 2;

		// Token: 0x0400A2C9 RID: 41673
		private long limitBeginTime_;

		// Token: 0x0400A2CA RID: 41674
		public const int LimitEndTimeFieldNumber = 3;

		// Token: 0x0400A2CB RID: 41675
		private long limitEndTime_;
	}
}
