using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D5 RID: 981
	public sealed class DFsm : IMessage<DFsm>, IMessage, IEquatable<DFsm>, IDeepCloneable<DFsm>, IBufferMessage
	{
		// Token: 0x06005FA1 RID: 24481 RVA: 0x000E792C File Offset: 0x000E5B2C
		[NullableContext(1)]
		public static DFsm Create()
		{
			return new DFsm();
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06005FA2 RID: 24482 RVA: 0x000E7933 File Offset: 0x000E5B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DFsm> Parser
		{
			get
			{
				return DFsm._parser;
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06005FA3 RID: 24483 RVA: 0x000E793A File Offset: 0x000E5B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06005FA4 RID: 24484 RVA: 0x000E793D File Offset: 0x000E5B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DFsm.Descriptor;
			}
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x000E7944 File Offset: 0x000E5B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsm()
		{
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x000E794C File Offset: 0x000E5B4C
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

		// Token: 0x06005FA7 RID: 24487 RVA: 0x000E79A0 File Offset: 0x000E5BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DFsm Clone()
		{
			return new DFsm(this);
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06005FA8 RID: 24488 RVA: 0x000E79A8 File Offset: 0x000E5BA8
		// (set) Token: 0x06005FA9 RID: 24489 RVA: 0x000E79B0 File Offset: 0x000E5BB0
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

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06005FAA RID: 24490 RVA: 0x000E79B9 File Offset: 0x000E5BB9
		// (set) Token: 0x06005FAB RID: 24491 RVA: 0x000E79C1 File Offset: 0x000E5BC1
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

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06005FAC RID: 24492 RVA: 0x000E79CA File Offset: 0x000E5BCA
		// (set) Token: 0x06005FAD RID: 24493 RVA: 0x000E79D2 File Offset: 0x000E5BD2
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

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06005FAE RID: 24494 RVA: 0x000E79DB File Offset: 0x000E5BDB
		// (set) Token: 0x06005FAF RID: 24495 RVA: 0x000E79E3 File Offset: 0x000E5BE3
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

		// Token: 0x06005FB0 RID: 24496 RVA: 0x000E79EC File Offset: 0x000E5BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DFsm);
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x000E79FC File Offset: 0x000E5BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DFsm other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.CurrentState == other.CurrentState && this.Flag == other.Flag && this.StateElapseTime == other.StateElapseTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x000E7A68 File Offset: 0x000E5C68
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

		// Token: 0x06005FB3 RID: 24499 RVA: 0x000E7AF8 File Offset: 0x000E5CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x000E7B05 File Offset: 0x000E5D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x000E7B10 File Offset: 0x000E5D10
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

		// Token: 0x06005FB6 RID: 24502 RVA: 0x000E7BA0 File Offset: 0x000E5DA0
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

		// Token: 0x06005FB7 RID: 24503 RVA: 0x000E7C28 File Offset: 0x000E5E28
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

		// Token: 0x06005FB8 RID: 24504 RVA: 0x000E7CA0 File Offset: 0x000E5EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x000E7CAC File Offset: 0x000E5EAC
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

		// Token: 0x04003730 RID: 14128
		private static readonly MessageParser<DFsm> _parser = new MessageParser<DFsm>(() => new DFsm());

		// Token: 0x04003731 RID: 14129
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003732 RID: 14130
		public const int FsmIdFieldNumber = 1;

		// Token: 0x04003733 RID: 14131
		private int fsmId_;

		// Token: 0x04003734 RID: 14132
		public const int CurrentStateFieldNumber = 2;

		// Token: 0x04003735 RID: 14133
		private int currentState_;

		// Token: 0x04003736 RID: 14134
		public const int FlagFieldNumber = 3;

		// Token: 0x04003737 RID: 14135
		private EFsmStateFlag flag_;

		// Token: 0x04003738 RID: 14136
		public const int StateElapseTimeFieldNumber = 6;

		// Token: 0x04003739 RID: 14137
		private int stateElapseTime_;
	}
}
