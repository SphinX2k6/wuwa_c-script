using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001292 RID: 4754
	public sealed class StateChangeConditionActionCtxPb : IMessage<StateChangeConditionActionCtxPb>, IMessage, IEquatable<StateChangeConditionActionCtxPb>, IDeepCloneable<StateChangeConditionActionCtxPb>, IBufferMessage
	{
		// Token: 0x060194FE RID: 103678 RVA: 0x003AE433 File Offset: 0x003AC633
		[NullableContext(1)]
		public static StateChangeConditionActionCtxPb Create()
		{
			return new StateChangeConditionActionCtxPb();
		}

		// Token: 0x17005561 RID: 21857
		// (get) Token: 0x060194FF RID: 103679 RVA: 0x003AE43A File Offset: 0x003AC63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005562 RID: 21858
		// (get) Token: 0x06019500 RID: 103680 RVA: 0x003AE43D File Offset: 0x003AC63D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StateChangeConditionActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06019501 RID: 103681 RVA: 0x003AE444 File Offset: 0x003AC644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeConditionActionCtxPb()
		{
		}

		// Token: 0x06019502 RID: 103682 RVA: 0x003AE44C File Offset: 0x003AC64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeConditionActionCtxPb(StateChangeConditionActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.stateIndex_ = other.stateIndex_;
			this.conditionIndex_ = other.conditionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019503 RID: 103683 RVA: 0x003AE4A4 File Offset: 0x003AC6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeConditionActionCtxPb Clone()
		{
			return new StateChangeConditionActionCtxPb(this);
		}

		// Token: 0x17005563 RID: 21859
		// (get) Token: 0x06019504 RID: 103684 RVA: 0x003AE4AC File Offset: 0x003AC6AC
		// (set) Token: 0x06019505 RID: 103685 RVA: 0x003AE4B4 File Offset: 0x003AC6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x17005564 RID: 21860
		// (get) Token: 0x06019506 RID: 103686 RVA: 0x003AE4BD File Offset: 0x003AC6BD
		// (set) Token: 0x06019507 RID: 103687 RVA: 0x003AE4C5 File Offset: 0x003AC6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateIndex
		{
			get
			{
				return this.stateIndex_;
			}
			set
			{
				this.stateIndex_ = value;
			}
		}

		// Token: 0x17005565 RID: 21861
		// (get) Token: 0x06019508 RID: 103688 RVA: 0x003AE4CE File Offset: 0x003AC6CE
		// (set) Token: 0x06019509 RID: 103689 RVA: 0x003AE4D6 File Offset: 0x003AC6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionIndex
		{
			get
			{
				return this.conditionIndex_;
			}
			set
			{
				this.conditionIndex_ = value;
			}
		}

		// Token: 0x0601950A RID: 103690 RVA: 0x003AE4DF File Offset: 0x003AC6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StateChangeConditionActionCtxPb);
		}

		// Token: 0x0601950B RID: 103691 RVA: 0x003AE4F0 File Offset: 0x003AC6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StateChangeConditionActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.StateIndex == other.StateIndex && this.ConditionIndex == other.ConditionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601950C RID: 103692 RVA: 0x003AE550 File Offset: 0x003AC750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.StateIndex != 0)
			{
				num ^= this.StateIndex.GetHashCode();
			}
			if (this.ConditionIndex != 0)
			{
				num ^= this.ConditionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601950D RID: 103693 RVA: 0x003AE5BE File Offset: 0x003AC7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601950E RID: 103694 RVA: 0x003AE5CB File Offset: 0x003AC7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601950F RID: 103695 RVA: 0x003AE5D4 File Offset: 0x003AC7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.StateIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StateIndex);
			}
			if (this.ConditionIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConditionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019510 RID: 103696 RVA: 0x003AE64C File Offset: 0x003AC84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.StateIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateIndex);
			}
			if (this.ConditionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019511 RID: 103697 RVA: 0x003AE6BC File Offset: 0x003AC8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StateChangeConditionActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.StateIndex != 0)
			{
				this.StateIndex = other.StateIndex;
			}
			if (other.ConditionIndex != 0)
			{
				this.ConditionIndex = other.ConditionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019512 RID: 103698 RVA: 0x003AE738 File Offset: 0x003AC938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019513 RID: 103699 RVA: 0x003AE744 File Offset: 0x003AC944
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
							this.ConditionIndex = input.ReadInt32();
						}
					}
					else
					{
						this.StateIndex = input.ReadInt32();
					}
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x040094C9 RID: 38089
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094CA RID: 38090
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040094CB RID: 38091
		private EntityCtxPb entityCtx_;

		// Token: 0x040094CC RID: 38092
		public const int StateIndexFieldNumber = 2;

		// Token: 0x040094CD RID: 38093
		private int stateIndex_;

		// Token: 0x040094CE RID: 38094
		public const int ConditionIndexFieldNumber = 3;

		// Token: 0x040094CF RID: 38095
		private int conditionIndex_;
	}
}
