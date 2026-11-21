using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8A RID: 2698
	[NetMessage(EMessageId.MotorPositionStateNotify)]
	public sealed class MotorPositionStateNotify : IMessage<MotorPositionStateNotify>, IMessage, IEquatable<MotorPositionStateNotify>, IDeepCloneable<MotorPositionStateNotify>, IBufferMessage
	{
		// Token: 0x0600EB4F RID: 60239 RVA: 0x00226209 File Offset: 0x00224409
		[NullableContext(1)]
		public static MotorPositionStateNotify Create()
		{
			return new MotorPositionStateNotify();
		}

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x0600EB50 RID: 60240 RVA: 0x00226210 File Offset: 0x00224410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x0600EB51 RID: 60241 RVA: 0x00226213 File Offset: 0x00224413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorPositionStateNotify.Descriptor;
			}
		}

		// Token: 0x0600EB52 RID: 60242 RVA: 0x0022621A File Offset: 0x0022441A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStateNotify()
		{
		}

		// Token: 0x0600EB53 RID: 60243 RVA: 0x00226222 File Offset: 0x00224422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStateNotify(MotorPositionStateNotify other) : this()
		{
			this.positionState_ = other.positionState_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB54 RID: 60244 RVA: 0x00226253 File Offset: 0x00224453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStateNotify Clone()
		{
			return new MotorPositionStateNotify(this);
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x0600EB55 RID: 60245 RVA: 0x0022625B File Offset: 0x0022445B
		// (set) Token: 0x0600EB56 RID: 60246 RVA: 0x00226263 File Offset: 0x00224463
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

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x0600EB57 RID: 60247 RVA: 0x0022626C File Offset: 0x0022446C
		// (set) Token: 0x0600EB58 RID: 60248 RVA: 0x00226274 File Offset: 0x00224474
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

		// Token: 0x0600EB59 RID: 60249 RVA: 0x0022627D File Offset: 0x0022447D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorPositionStateNotify);
		}

		// Token: 0x0600EB5A RID: 60250 RVA: 0x0022628B File Offset: 0x0022448B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorPositionStateNotify other)
		{
			return other != null && (other == this || (this.PositionState == other.PositionState && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB5B RID: 60251 RVA: 0x002262CC File Offset: 0x002244CC
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

		// Token: 0x0600EB5C RID: 60252 RVA: 0x00226324 File Offset: 0x00224524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB5D RID: 60253 RVA: 0x00226331 File Offset: 0x00224531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB5E RID: 60254 RVA: 0x0022633C File Offset: 0x0022453C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this.PositionState != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PositionState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EB5F RID: 60255 RVA: 0x00226398 File Offset: 0x00224598
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

		// Token: 0x0600EB60 RID: 60256 RVA: 0x002263F0 File Offset: 0x002245F0
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

		// Token: 0x0600EB61 RID: 60257 RVA: 0x00226440 File Offset: 0x00224640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB62 RID: 60258 RVA: 0x0022644C File Offset: 0x0022464C
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
				if (num != 32U)
				{
					if (num != 40U)
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

		// Token: 0x04005FE8 RID: 24552
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FE9 RID: 24553
		public const int PositionStateFieldNumber = 5;

		// Token: 0x04005FEA RID: 24554
		private int positionState_;

		// Token: 0x04005FEB RID: 24555
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04005FEC RID: 24556
		private long entityId_;
	}
}
