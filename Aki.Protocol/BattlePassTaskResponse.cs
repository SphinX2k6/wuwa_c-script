using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000177 RID: 375
	[NetMessage(EMessageId.BattlePassTaskResponse)]
	public sealed class BattlePassTaskResponse : IMessage<BattlePassTaskResponse>, IMessage, IEquatable<BattlePassTaskResponse>, IDeepCloneable<BattlePassTaskResponse>, IBufferMessage
	{
		// Token: 0x06002DD1 RID: 11729 RVA: 0x0007646A File Offset: 0x0007466A
		[NullableContext(1)]
		public static BattlePassTaskResponse Create()
		{
			return new BattlePassTaskResponse();
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x00076471 File Offset: 0x00074671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x00076474 File Offset: 0x00074674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTaskResponse.Descriptor;
			}
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x0007647B File Offset: 0x0007467B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskResponse()
		{
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00076490 File Offset: 0x00074690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskResponse(BattlePassTaskResponse other) : this()
		{
			this.dayEnd_ = other.dayEnd_;
			this.weekEnd_ = other.weekEnd_;
			this.tasks_ = other.tasks_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x000764E9 File Offset: 0x000746E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskResponse Clone()
		{
			return new BattlePassTaskResponse(this);
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x000764F1 File Offset: 0x000746F1
		// (set) Token: 0x06002DD8 RID: 11736 RVA: 0x000764F9 File Offset: 0x000746F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DayEnd
		{
			get
			{
				return this.dayEnd_;
			}
			set
			{
				this.dayEnd_ = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x00076502 File Offset: 0x00074702
		// (set) Token: 0x06002DDA RID: 11738 RVA: 0x0007650A File Offset: 0x0007470A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long WeekEnd
		{
			get
			{
				return this.weekEnd_;
			}
			set
			{
				this.weekEnd_ = value;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x00076513 File Offset: 0x00074713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x0007651B File Offset: 0x0007471B
		// (set) Token: 0x06002DDD RID: 11741 RVA: 0x00076523 File Offset: 0x00074723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x0007652C File Offset: 0x0007472C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTaskResponse);
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x0007653C File Offset: 0x0007473C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTaskResponse other)
		{
			return other != null && (other == this || (this.DayEnd == other.DayEnd && this.WeekEnd == other.WeekEnd && this.tasks_.Equals(other.tasks_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x000765AC File Offset: 0x000747AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DayEnd != 0L)
			{
				num ^= this.DayEnd.GetHashCode();
			}
			if (this.WeekEnd != 0L)
			{
				num ^= this.WeekEnd.GetHashCode();
			}
			num ^= this.tasks_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00076631 File Offset: 0x00074831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x0007663E File Offset: 0x0007483E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00076648 File Offset: 0x00074848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeekEnd != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.WeekEnd);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.tasks_.WriteTo(ref output, BattlePassTaskResponse._repeated_tasks_codec);
			if (this.DayEnd != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.DayEnd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x000766D0 File Offset: 0x000748D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DayEnd != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DayEnd);
			}
			if (this.WeekEnd != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.WeekEnd);
			}
			num += this.tasks_.CalculateSize(BattlePassTaskResponse._repeated_tasks_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x00076754 File Offset: 0x00074954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTaskResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DayEnd != 0L)
			{
				this.DayEnd = other.DayEnd;
			}
			if (other.WeekEnd != 0L)
			{
				this.WeekEnd = other.WeekEnd;
			}
			this.tasks_.Add(other.tasks_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x000767C9 File Offset: 0x000749C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x000767D4 File Offset: 0x000749D4
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
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.WeekEnd = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.tasks_.AddEntriesFrom(ref input, BattlePassTaskResponse._repeated_tasks_codec);
						continue;
					}
					if (num == 120U)
					{
						this.DayEnd = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002849 RID: 10313
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400284A RID: 10314
		public const int DayEndFieldNumber = 15;

		// Token: 0x0400284B RID: 10315
		private long dayEnd_;

		// Token: 0x0400284C RID: 10316
		public const int WeekEndFieldNumber = 1;

		// Token: 0x0400284D RID: 10317
		private long weekEnd_;

		// Token: 0x0400284E RID: 10318
		public const int TasksFieldNumber = 8;

		// Token: 0x0400284F RID: 10319
		private static readonly FieldCodec<PbBattlePassTask> _repeated_tasks_codec = FieldCodec.ForMessage<PbBattlePassTask>(66U, PbBattlePassTask.Parser);

		// Token: 0x04002850 RID: 10320
		private readonly RepeatedField<PbBattlePassTask> tasks_ = new RepeatedField<PbBattlePassTask>();

		// Token: 0x04002851 RID: 10321
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002852 RID: 10322
		private ErrorCode errorCode_;
	}
}
