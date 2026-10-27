using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001294 RID: 4756
	[NetMessage(EMessageId.StopHoldHandNotify)]
	public sealed class StopHoldHandNotify : IMessage<StopHoldHandNotify>, IMessage, IEquatable<StopHoldHandNotify>, IDeepCloneable<StopHoldHandNotify>, IBufferMessage
	{
		// Token: 0x06019526 RID: 103718 RVA: 0x003AE99C File Offset: 0x003ACB9C
		[NullableContext(1)]
		public static StopHoldHandNotify Create()
		{
			return new StopHoldHandNotify();
		}

		// Token: 0x17005569 RID: 21865
		// (get) Token: 0x06019527 RID: 103719 RVA: 0x003AE9A3 File Offset: 0x003ACBA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700556A RID: 21866
		// (get) Token: 0x06019528 RID: 103720 RVA: 0x003AE9A6 File Offset: 0x003ACBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StopHoldHandNotify.Descriptor;
			}
		}

		// Token: 0x06019529 RID: 103721 RVA: 0x003AE9AD File Offset: 0x003ACBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopHoldHandNotify()
		{
		}

		// Token: 0x0601952A RID: 103722 RVA: 0x003AE9B5 File Offset: 0x003ACBB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopHoldHandNotify(StopHoldHandNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.targetEntityId_ = other.targetEntityId_;
			this.actionType_ = other.actionType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601952B RID: 103723 RVA: 0x003AE9F2 File Offset: 0x003ACBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopHoldHandNotify Clone()
		{
			return new StopHoldHandNotify(this);
		}

		// Token: 0x1700556B RID: 21867
		// (get) Token: 0x0601952C RID: 103724 RVA: 0x003AE9FA File Offset: 0x003ACBFA
		// (set) Token: 0x0601952D RID: 103725 RVA: 0x003AEA02 File Offset: 0x003ACC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700556C RID: 21868
		// (get) Token: 0x0601952E RID: 103726 RVA: 0x003AEA0B File Offset: 0x003ACC0B
		// (set) Token: 0x0601952F RID: 103727 RVA: 0x003AEA13 File Offset: 0x003ACC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntityId
		{
			get
			{
				return this.targetEntityId_;
			}
			set
			{
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x1700556D RID: 21869
		// (get) Token: 0x06019530 RID: 103728 RVA: 0x003AEA1C File Offset: 0x003ACC1C
		// (set) Token: 0x06019531 RID: 103729 RVA: 0x003AEA24 File Offset: 0x003ACC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionType
		{
			get
			{
				return this.actionType_;
			}
			set
			{
				this.actionType_ = value;
			}
		}

		// Token: 0x06019532 RID: 103730 RVA: 0x003AEA2D File Offset: 0x003ACC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StopHoldHandNotify);
		}

		// Token: 0x06019533 RID: 103731 RVA: 0x003AEA3C File Offset: 0x003ACC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StopHoldHandNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.TargetEntityId == other.TargetEntityId && this.ActionType == other.ActionType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019534 RID: 103732 RVA: 0x003AEA98 File Offset: 0x003ACC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.TargetEntityId != 0L)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this.ActionType != 0)
			{
				num ^= this.ActionType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019535 RID: 103733 RVA: 0x003AEB09 File Offset: 0x003ACD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019536 RID: 103734 RVA: 0x003AEB16 File Offset: 0x003ACD16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019537 RID: 103735 RVA: 0x003AEB20 File Offset: 0x003ACD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.ActionType != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActionType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019538 RID: 103736 RVA: 0x003AEB98 File Offset: 0x003ACD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.TargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this.ActionType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019539 RID: 103737 RVA: 0x003AEC08 File Offset: 0x003ACE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StopHoldHandNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.TargetEntityId != 0L)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			if (other.ActionType != 0)
			{
				this.ActionType = other.ActionType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601953A RID: 103738 RVA: 0x003AEC6C File Offset: 0x003ACE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601953B RID: 103739 RVA: 0x003AEC78 File Offset: 0x003ACE78
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
				if (num != 16U)
				{
					if (num != 88U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActionType = input.ReadInt32();
						}
					}
					else
					{
						this.TargetEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040094D3 RID: 38099
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094D4 RID: 38100
		public const int EntityIdFieldNumber = 2;

		// Token: 0x040094D5 RID: 38101
		private long entityId_;

		// Token: 0x040094D6 RID: 38102
		public const int TargetEntityIdFieldNumber = 11;

		// Token: 0x040094D7 RID: 38103
		private long targetEntityId_;

		// Token: 0x040094D8 RID: 38104
		public const int ActionTypeFieldNumber = 12;

		// Token: 0x040094D9 RID: 38105
		private int actionType_;
	}
}
