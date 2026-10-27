using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9C RID: 2716
	[NetMessage(EMessageId.MotorPositionStatePush)]
	public sealed class MotorPositionStatePush : IMessage<MotorPositionStatePush>, IMessage, IEquatable<MotorPositionStatePush>, IDeepCloneable<MotorPositionStatePush>, IBufferMessage
	{
		// Token: 0x0600EC7D RID: 60541 RVA: 0x0022869C File Offset: 0x0022689C
		[NullableContext(1)]
		public static MotorPositionStatePush Create()
		{
			return new MotorPositionStatePush();
		}

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x0600EC7E RID: 60542 RVA: 0x002286A3 File Offset: 0x002268A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x0600EC7F RID: 60543 RVA: 0x002286A6 File Offset: 0x002268A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorPositionStatePush.Descriptor;
			}
		}

		// Token: 0x0600EC80 RID: 60544 RVA: 0x002286AD File Offset: 0x002268AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStatePush()
		{
		}

		// Token: 0x0600EC81 RID: 60545 RVA: 0x002286B5 File Offset: 0x002268B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStatePush(MotorPositionStatePush other) : this()
		{
			this.positionState_ = other.positionState_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC82 RID: 60546 RVA: 0x002286E6 File Offset: 0x002268E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStatePush Clone()
		{
			return new MotorPositionStatePush(this);
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x0600EC83 RID: 60547 RVA: 0x002286EE File Offset: 0x002268EE
		// (set) Token: 0x0600EC84 RID: 60548 RVA: 0x002286F6 File Offset: 0x002268F6
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

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x0600EC85 RID: 60549 RVA: 0x002286FF File Offset: 0x002268FF
		// (set) Token: 0x0600EC86 RID: 60550 RVA: 0x00228707 File Offset: 0x00226907
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

		// Token: 0x0600EC87 RID: 60551 RVA: 0x00228710 File Offset: 0x00226910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorPositionStatePush);
		}

		// Token: 0x0600EC88 RID: 60552 RVA: 0x0022871E File Offset: 0x0022691E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorPositionStatePush other)
		{
			return other != null && (other == this || (this.PositionState == other.PositionState && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC89 RID: 60553 RVA: 0x0022875C File Offset: 0x0022695C
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

		// Token: 0x0600EC8A RID: 60554 RVA: 0x002287B4 File Offset: 0x002269B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC8B RID: 60555 RVA: 0x002287C1 File Offset: 0x002269C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC8C RID: 60556 RVA: 0x002287CC File Offset: 0x002269CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.PositionState != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PositionState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EC8D RID: 60557 RVA: 0x00228828 File Offset: 0x00226A28
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

		// Token: 0x0600EC8E RID: 60558 RVA: 0x00228880 File Offset: 0x00226A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorPositionStatePush other)
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

		// Token: 0x0600EC8F RID: 60559 RVA: 0x002288D0 File Offset: 0x00226AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC90 RID: 60560 RVA: 0x002288DC File Offset: 0x00226ADC
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PositionState = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005FE4 RID: 24548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FE5 RID: 24549
		public const int PositionStateFieldNumber = 12;

		// Token: 0x04005FE6 RID: 24550
		private int positionState_;

		// Token: 0x04005FE7 RID: 24551
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04005FE8 RID: 24552
		private long entityId_;
	}
}
