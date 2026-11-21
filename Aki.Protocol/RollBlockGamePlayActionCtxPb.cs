using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001113 RID: 4371
	public sealed class RollBlockGamePlayActionCtxPb : IMessage<RollBlockGamePlayActionCtxPb>, IMessage, IEquatable<RollBlockGamePlayActionCtxPb>, IDeepCloneable<RollBlockGamePlayActionCtxPb>, IBufferMessage
	{
		// Token: 0x060175BD RID: 95677 RVA: 0x00365E01 File Offset: 0x00364001
		[NullableContext(1)]
		public static RollBlockGamePlayActionCtxPb Create()
		{
			return new RollBlockGamePlayActionCtxPb();
		}

		// Token: 0x17004E79 RID: 20089
		// (get) Token: 0x060175BE RID: 95678 RVA: 0x00365E08 File Offset: 0x00364008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E7A RID: 20090
		// (get) Token: 0x060175BF RID: 95679 RVA: 0x00365E0B File Offset: 0x0036400B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockGamePlayActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060175C0 RID: 95680 RVA: 0x00365E12 File Offset: 0x00364012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayActionCtxPb()
		{
		}

		// Token: 0x060175C1 RID: 95681 RVA: 0x00365E1C File Offset: 0x0036401C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayActionCtxPb(RollBlockGamePlayActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060175C2 RID: 95682 RVA: 0x00365E68 File Offset: 0x00364068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayActionCtxPb Clone()
		{
			return new RollBlockGamePlayActionCtxPb(this);
		}

		// Token: 0x17004E7B RID: 20091
		// (get) Token: 0x060175C3 RID: 95683 RVA: 0x00365E70 File Offset: 0x00364070
		// (set) Token: 0x060175C4 RID: 95684 RVA: 0x00365E78 File Offset: 0x00364078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeCtxPb BehaviorTreeCtx
		{
			get
			{
				return this.behaviorTreeCtx_;
			}
			set
			{
				this.behaviorTreeCtx_ = value;
			}
		}

		// Token: 0x17004E7C RID: 20092
		// (get) Token: 0x060175C5 RID: 95685 RVA: 0x00365E81 File Offset: 0x00364081
		// (set) Token: 0x060175C6 RID: 95686 RVA: 0x00365E89 File Offset: 0x00364089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGameActionType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x060175C7 RID: 95687 RVA: 0x00365E92 File Offset: 0x00364092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockGamePlayActionCtxPb);
		}

		// Token: 0x060175C8 RID: 95688 RVA: 0x00365EA0 File Offset: 0x003640A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockGamePlayActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060175C9 RID: 95689 RVA: 0x00365EF0 File Offset: 0x003640F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.behaviorTreeCtx_ != null)
			{
				num ^= this.BehaviorTreeCtx.GetHashCode();
			}
			if (this.Type != RollBlockGameActionType.RbMidWayExit)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060175CA RID: 95690 RVA: 0x00365F4B File Offset: 0x0036414B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060175CB RID: 95691 RVA: 0x00365F58 File Offset: 0x00364158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060175CC RID: 95692 RVA: 0x00365F64 File Offset: 0x00364164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.behaviorTreeCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BehaviorTreeCtx);
			}
			if (this.Type != RollBlockGameActionType.RbMidWayExit)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060175CD RID: 95693 RVA: 0x00365FC0 File Offset: 0x003641C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.behaviorTreeCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BehaviorTreeCtx);
			}
			if (this.Type != RollBlockGameActionType.RbMidWayExit)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060175CE RID: 95694 RVA: 0x00366018 File Offset: 0x00364218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockGamePlayActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.behaviorTreeCtx_ != null)
			{
				if (this.behaviorTreeCtx_ == null)
				{
					this.BehaviorTreeCtx = new BehaviorTreeCtxPb();
				}
				this.BehaviorTreeCtx.MergeFrom(other.BehaviorTreeCtx);
			}
			if (other.Type != RollBlockGameActionType.RbMidWayExit)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060175CF RID: 95695 RVA: 0x00366080 File Offset: 0x00364280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060175D0 RID: 95696 RVA: 0x0036608C File Offset: 0x0036428C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (RollBlockGameActionType)input.ReadEnum();
					}
				}
				else
				{
					if (this.behaviorTreeCtx_ == null)
					{
						this.BehaviorTreeCtx = new BehaviorTreeCtxPb();
					}
					input.ReadMessage(this.BehaviorTreeCtx);
				}
			}
		}

		// Token: 0x04008B84 RID: 35716
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B85 RID: 35717
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04008B86 RID: 35718
		private BehaviorTreeCtxPb behaviorTreeCtx_;

		// Token: 0x04008B87 RID: 35719
		public const int TypeFieldNumber = 2;

		// Token: 0x04008B88 RID: 35720
		private RollBlockGameActionType type_;
	}
}
