using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9B RID: 2715
	[NetMessage(EMessageId.MotorPositionStateNotify)]
	public sealed class MotorPositionStateNotify : IMessage<MotorPositionStateNotify>, IMessage, IEquatable<MotorPositionStateNotify>, IDeepCloneable<MotorPositionStateNotify>, IBufferMessage
	{
		// Token: 0x0600EC69 RID: 60521 RVA: 0x00228401 File Offset: 0x00226601
		[NullableContext(1)]
		public static MotorPositionStateNotify Create()
		{
			return new MotorPositionStateNotify();
		}

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x0600EC6A RID: 60522 RVA: 0x00228408 File Offset: 0x00226608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x0600EC6B RID: 60523 RVA: 0x0022840B File Offset: 0x0022660B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorPositionStateNotify.Descriptor;
			}
		}

		// Token: 0x0600EC6C RID: 60524 RVA: 0x00228412 File Offset: 0x00226612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStateNotify()
		{
		}

		// Token: 0x0600EC6D RID: 60525 RVA: 0x0022841A File Offset: 0x0022661A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStateNotify(MotorPositionStateNotify other) : this()
		{
			this.positionState_ = other.positionState_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC6E RID: 60526 RVA: 0x0022844B File Offset: 0x0022664B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStateNotify Clone()
		{
			return new MotorPositionStateNotify(this);
		}

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x0600EC6F RID: 60527 RVA: 0x00228453 File Offset: 0x00226653
		// (set) Token: 0x0600EC70 RID: 60528 RVA: 0x0022845B File Offset: 0x0022665B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PositionState
		{
			get
			{
				return this.positionState_;
			}
			set
			{
				this.positionState_ = value;
			}
		}

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x0600EC71 RID: 60529 RVA: 0x00228464 File Offset: 0x00226664
		// (set) Token: 0x0600EC72 RID: 60530 RVA: 0x0022846C File Offset: 0x0022666C
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

		// Token: 0x0600EC73 RID: 60531 RVA: 0x00228475 File Offset: 0x00226675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorPositionStateNotify);
		}

		// Token: 0x0600EC74 RID: 60532 RVA: 0x00228483 File Offset: 0x00226683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorPositionStateNotify other)
		{
			return other != null && (other == this || (this.PositionState == other.PositionState && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC75 RID: 60533 RVA: 0x002284C4 File Offset: 0x002266C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PositionState != 0)
			{
				num ^= this.PositionState.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EC76 RID: 60534 RVA: 0x0022851C File Offset: 0x0022671C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC77 RID: 60535 RVA: 0x00228529 File Offset: 0x00226729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC78 RID: 60536 RVA: 0x00228534 File Offset: 0x00226734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PositionState != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PositionState);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EC79 RID: 60537 RVA: 0x00228590 File Offset: 0x00226790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PositionState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PositionState);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EC7A RID: 60538 RVA: 0x002285E8 File Offset: 0x002267E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorPositionStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PositionState != 0)
			{
				this.PositionState = other.PositionState;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EC7B RID: 60539 RVA: 0x00228638 File Offset: 0x00226838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC7C RID: 60540 RVA: 0x00228644 File Offset: 0x00226844
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
				if (num != 80U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.PositionState = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005FDF RID: 24543
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FE0 RID: 24544
		public const int PositionStateFieldNumber = 10;

		// Token: 0x04005FE1 RID: 24545
		private int positionState_;

		// Token: 0x04005FE2 RID: 24546
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04005FE3 RID: 24547
		private long entityId_;
	}
}
