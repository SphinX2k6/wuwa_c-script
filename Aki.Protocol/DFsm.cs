using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BE RID: 958
	public sealed class DFsm : IMessage<DFsm>, IMessage, IEquatable<DFsm>, IDeepCloneable<DFsm>, IBufferMessage
	{
		// Token: 0x06005E11 RID: 24081 RVA: 0x000E47AC File Offset: 0x000E29AC
		[NullableContext(1)]
		public static DFsm Create()
		{
			return new DFsm();
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06005E12 RID: 24082 RVA: 0x000E47B3 File Offset: 0x000E29B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DFsm> Parser
		{
			get
			{
				return DFsm._parser;
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06005E13 RID: 24083 RVA: 0x000E47BA File Offset: 0x000E29BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06005E14 RID: 24084 RVA: 0x000E47BD File Offset: 0x000E29BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DFsm.Descriptor;
			}
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x000E47C4 File Offset: 0x000E29C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsm()
		{
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x000E47CC File Offset: 0x000E29CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsm(DFsm other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.currentState_ = other.currentState_;
			this.flag_ = other.flag_;
			this.stateElapseTime_ = other.stateElapseTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x000E4820 File Offset: 0x000E2A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsm Clone()
		{
			return new DFsm(this);
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06005E18 RID: 24088 RVA: 0x000E4828 File Offset: 0x000E2A28
		// (set) Token: 0x06005E19 RID: 24089 RVA: 0x000E4830 File Offset: 0x000E2A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06005E1A RID: 24090 RVA: 0x000E4839 File Offset: 0x000E2A39
		// (set) Token: 0x06005E1B RID: 24091 RVA: 0x000E4841 File Offset: 0x000E2A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentState
		{
			get
			{
				return this.currentState_;
			}
			set
			{
				this.currentState_ = value;
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06005E1C RID: 24092 RVA: 0x000E484A File Offset: 0x000E2A4A
		// (set) Token: 0x06005E1D RID: 24093 RVA: 0x000E4852 File Offset: 0x000E2A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EFsmStateFlag Flag
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

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06005E1E RID: 24094 RVA: 0x000E485B File Offset: 0x000E2A5B
		// (set) Token: 0x06005E1F RID: 24095 RVA: 0x000E4863 File Offset: 0x000E2A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateElapseTime
		{
			get
			{
				return this.stateElapseTime_;
			}
			set
			{
				this.stateElapseTime_ = value;
			}
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x000E486C File Offset: 0x000E2A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DFsm);
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x000E487C File Offset: 0x000E2A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DFsm other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.CurrentState == other.CurrentState && this.Flag == other.Flag && this.StateElapseTime == other.StateElapseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x000E48E8 File Offset: 0x000E2AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.CurrentState != 0)
			{
				num ^= this.CurrentState.GetHashCode();
			}
			if (this.Flag != EFsmStateFlag.Changed)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this.StateElapseTime != 0)
			{
				num ^= this.StateElapseTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x000E4978 File Offset: 0x000E2B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E24 RID: 24100 RVA: 0x000E4985 File Offset: 0x000E2B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x000E4990 File Offset: 0x000E2B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FsmId);
			}
			if (this.CurrentState != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurrentState);
			}
			if (this.Flag != EFsmStateFlag.Changed)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Flag);
			}
			if (this.StateElapseTime != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.StateElapseTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x000E4A20 File Offset: 0x000E2C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.CurrentState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentState);
			}
			if (this.Flag != EFsmStateFlag.Changed)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Flag);
			}
			if (this.StateElapseTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateElapseTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x000E4AA8 File Offset: 0x000E2CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DFsm other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.CurrentState != 0)
			{
				this.CurrentState = other.CurrentState;
			}
			if (other.Flag != EFsmStateFlag.Changed)
			{
				this.Flag = other.Flag;
			}
			if (other.StateElapseTime != 0)
			{
				this.StateElapseTime = other.StateElapseTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x000E4B20 File Offset: 0x000E2D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x000E4B2C File Offset: 0x000E2D2C
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
						this.FsmId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurrentState = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Flag = (EFsmStateFlag)input.ReadEnum();
						continue;
					}
					if (num == 48U)
					{
						this.StateElapseTime = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400371D RID: 14109
		private static readonly MessageParser<DFsm> _parser = new MessageParser<DFsm>(() => new DFsm());

		// Token: 0x0400371E RID: 14110
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400371F RID: 14111
		public const int FsmIdFieldNumber = 1;

		// Token: 0x04003720 RID: 14112
		private int fsmId_;

		// Token: 0x04003721 RID: 14113
		public const int CurrentStateFieldNumber = 2;

		// Token: 0x04003722 RID: 14114
		private int currentState_;

		// Token: 0x04003723 RID: 14115
		public const int FlagFieldNumber = 3;

		// Token: 0x04003724 RID: 14116
		private EFsmStateFlag flag_;

		// Token: 0x04003725 RID: 14117
		public const int StateElapseTimeFieldNumber = 6;

		// Token: 0x04003726 RID: 14118
		private int stateElapseTime_;
	}
}
