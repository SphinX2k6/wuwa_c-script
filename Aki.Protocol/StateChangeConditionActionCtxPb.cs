using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001301 RID: 4865
	public sealed class StateChangeConditionActionCtxPb : IMessage<StateChangeConditionActionCtxPb>, IMessage, IEquatable<StateChangeConditionActionCtxPb>, IDeepCloneable<StateChangeConditionActionCtxPb>, IBufferMessage
	{
		// Token: 0x06019F34 RID: 106292 RVA: 0x003C8B5F File Offset: 0x003C6D5F
		[NullableContext(1)]
		public static StateChangeConditionActionCtxPb Create()
		{
			return new StateChangeConditionActionCtxPb();
		}

		// Token: 0x170057E2 RID: 22498
		// (get) Token: 0x06019F35 RID: 106293 RVA: 0x003C8B66 File Offset: 0x003C6D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057E3 RID: 22499
		// (get) Token: 0x06019F36 RID: 106294 RVA: 0x003C8B69 File Offset: 0x003C6D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StateChangeConditionActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06019F37 RID: 106295 RVA: 0x003C8B70 File Offset: 0x003C6D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeConditionActionCtxPb()
		{
		}

		// Token: 0x06019F38 RID: 106296 RVA: 0x003C8B78 File Offset: 0x003C6D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeConditionActionCtxPb(StateChangeConditionActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.stateIndex_ = other.stateIndex_;
			this.conditionIndex_ = other.conditionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F39 RID: 106297 RVA: 0x003C8BD0 File Offset: 0x003C6DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateChangeConditionActionCtxPb Clone()
		{
			return new StateChangeConditionActionCtxPb(this);
		}

		// Token: 0x170057E4 RID: 22500
		// (get) Token: 0x06019F3A RID: 106298 RVA: 0x003C8BD8 File Offset: 0x003C6DD8
		// (set) Token: 0x06019F3B RID: 106299 RVA: 0x003C8BE0 File Offset: 0x003C6DE0
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

		// Token: 0x170057E5 RID: 22501
		// (get) Token: 0x06019F3C RID: 106300 RVA: 0x003C8BE9 File Offset: 0x003C6DE9
		// (set) Token: 0x06019F3D RID: 106301 RVA: 0x003C8BF1 File Offset: 0x003C6DF1
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

		// Token: 0x170057E6 RID: 22502
		// (get) Token: 0x06019F3E RID: 106302 RVA: 0x003C8BFA File Offset: 0x003C6DFA
		// (set) Token: 0x06019F3F RID: 106303 RVA: 0x003C8C02 File Offset: 0x003C6E02
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

		// Token: 0x06019F40 RID: 106304 RVA: 0x003C8C0B File Offset: 0x003C6E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StateChangeConditionActionCtxPb);
		}

		// Token: 0x06019F41 RID: 106305 RVA: 0x003C8C1C File Offset: 0x003C6E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StateChangeConditionActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.StateIndex == other.StateIndex && this.ConditionIndex == other.ConditionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F42 RID: 106306 RVA: 0x003C8C7C File Offset: 0x003C6E7C
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

		// Token: 0x06019F43 RID: 106307 RVA: 0x003C8CEA File Offset: 0x003C6EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F44 RID: 106308 RVA: 0x003C8CF7 File Offset: 0x003C6EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F45 RID: 106309 RVA: 0x003C8D00 File Offset: 0x003C6F00
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

		// Token: 0x06019F46 RID: 106310 RVA: 0x003C8D78 File Offset: 0x003C6F78
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

		// Token: 0x06019F47 RID: 106311 RVA: 0x003C8DE8 File Offset: 0x003C6FE8
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

		// Token: 0x06019F48 RID: 106312 RVA: 0x003C8E64 File Offset: 0x003C7064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F49 RID: 106313 RVA: 0x003C8E70 File Offset: 0x003C7070
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

		// Token: 0x040098F3 RID: 39155
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098F4 RID: 39156
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040098F5 RID: 39157
		private EntityCtxPb entityCtx_;

		// Token: 0x040098F6 RID: 39158
		public const int StateIndexFieldNumber = 2;

		// Token: 0x040098F7 RID: 39159
		private int stateIndex_;

		// Token: 0x040098F8 RID: 39160
		public const int ConditionIndexFieldNumber = 3;

		// Token: 0x040098F9 RID: 39161
		private int conditionIndex_;
	}
}
