using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001303 RID: 4867
	[NetMessage(EMessageId.StopHoldHandNotify)]
	public sealed class StopHoldHandNotify : IMessage<StopHoldHandNotify>, IMessage, IEquatable<StopHoldHandNotify>, IDeepCloneable<StopHoldHandNotify>, IBufferMessage
	{
		// Token: 0x06019F5C RID: 106332 RVA: 0x003C90C8 File Offset: 0x003C72C8
		[NullableContext(1)]
		public static StopHoldHandNotify Create()
		{
			return new StopHoldHandNotify();
		}

		// Token: 0x170057EA RID: 22506
		// (get) Token: 0x06019F5D RID: 106333 RVA: 0x003C90CF File Offset: 0x003C72CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057EB RID: 22507
		// (get) Token: 0x06019F5E RID: 106334 RVA: 0x003C90D2 File Offset: 0x003C72D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StopHoldHandNotify.Descriptor;
			}
		}

		// Token: 0x06019F5F RID: 106335 RVA: 0x003C90D9 File Offset: 0x003C72D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopHoldHandNotify()
		{
		}

		// Token: 0x06019F60 RID: 106336 RVA: 0x003C90E1 File Offset: 0x003C72E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopHoldHandNotify(StopHoldHandNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.targetEntityId_ = other.targetEntityId_;
			this.actionType_ = other.actionType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F61 RID: 106337 RVA: 0x003C911E File Offset: 0x003C731E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopHoldHandNotify Clone()
		{
			return new StopHoldHandNotify(this);
		}

		// Token: 0x170057EC RID: 22508
		// (get) Token: 0x06019F62 RID: 106338 RVA: 0x003C9126 File Offset: 0x003C7326
		// (set) Token: 0x06019F63 RID: 106339 RVA: 0x003C912E File Offset: 0x003C732E
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

		// Token: 0x170057ED RID: 22509
		// (get) Token: 0x06019F64 RID: 106340 RVA: 0x003C9137 File Offset: 0x003C7337
		// (set) Token: 0x06019F65 RID: 106341 RVA: 0x003C913F File Offset: 0x003C733F
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

		// Token: 0x170057EE RID: 22510
		// (get) Token: 0x06019F66 RID: 106342 RVA: 0x003C9148 File Offset: 0x003C7348
		// (set) Token: 0x06019F67 RID: 106343 RVA: 0x003C9150 File Offset: 0x003C7350
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

		// Token: 0x06019F68 RID: 106344 RVA: 0x003C9159 File Offset: 0x003C7359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StopHoldHandNotify);
		}

		// Token: 0x06019F69 RID: 106345 RVA: 0x003C9168 File Offset: 0x003C7368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StopHoldHandNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.TargetEntityId == other.TargetEntityId && this.ActionType == other.ActionType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F6A RID: 106346 RVA: 0x003C91C4 File Offset: 0x003C73C4
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

		// Token: 0x06019F6B RID: 106347 RVA: 0x003C9235 File Offset: 0x003C7435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F6C RID: 106348 RVA: 0x003C9242 File Offset: 0x003C7442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F6D RID: 106349 RVA: 0x003C924C File Offset: 0x003C744C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.ActionType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActionType);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F6E RID: 106350 RVA: 0x003C92C4 File Offset: 0x003C74C4
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

		// Token: 0x06019F6F RID: 106351 RVA: 0x003C9334 File Offset: 0x003C7534
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

		// Token: 0x06019F70 RID: 106352 RVA: 0x003C9398 File Offset: 0x003C7598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F71 RID: 106353 RVA: 0x003C93A4 File Offset: 0x003C75A4
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
					if (num != 24U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TargetEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.ActionType = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040098FD RID: 39165
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098FE RID: 39166
		public const int EntityIdFieldNumber = 2;

		// Token: 0x040098FF RID: 39167
		private long entityId_;

		// Token: 0x04009900 RID: 39168
		public const int TargetEntityIdFieldNumber = 14;

		// Token: 0x04009901 RID: 39169
		private long targetEntityId_;

		// Token: 0x04009902 RID: 39170
		public const int ActionTypeFieldNumber = 3;

		// Token: 0x04009903 RID: 39171
		private int actionType_;
	}
}
