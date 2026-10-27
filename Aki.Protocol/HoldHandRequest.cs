using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000758 RID: 1880
	[NetMessage(EMessageId.HoldHandRequest)]
	public sealed class HoldHandRequest : IMessage<HoldHandRequest>, IMessage, IEquatable<HoldHandRequest>, IDeepCloneable<HoldHandRequest>, IBufferMessage
	{
		// Token: 0x0600AA38 RID: 43576 RVA: 0x00199998 File Offset: 0x00197B98
		[NullableContext(1)]
		public static HoldHandRequest Create()
		{
			return new HoldHandRequest();
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x0600AA39 RID: 43577 RVA: 0x0019999F File Offset: 0x00197B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x0600AA3A RID: 43578 RVA: 0x001999A2 File Offset: 0x00197BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoldHandRequest.Descriptor;
			}
		}

		// Token: 0x0600AA3B RID: 43579 RVA: 0x001999A9 File Offset: 0x00197BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandRequest()
		{
		}

		// Token: 0x0600AA3C RID: 43580 RVA: 0x001999B4 File Offset: 0x00197BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandRequest(HoldHandRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.targetEntityId_ = other.targetEntityId_;
			this.hostPlayerId_ = other.hostPlayerId_;
			this.handType_ = other.handType_;
			this.isHold_ = other.isHold_;
			this.actionType_ = other.actionType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA3D RID: 43581 RVA: 0x00199A20 File Offset: 0x00197C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandRequest Clone()
		{
			return new HoldHandRequest(this);
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x0600AA3E RID: 43582 RVA: 0x00199A28 File Offset: 0x00197C28
		// (set) Token: 0x0600AA3F RID: 43583 RVA: 0x00199A30 File Offset: 0x00197C30
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

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x0600AA40 RID: 43584 RVA: 0x00199A39 File Offset: 0x00197C39
		// (set) Token: 0x0600AA41 RID: 43585 RVA: 0x00199A41 File Offset: 0x00197C41
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

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x0600AA42 RID: 43586 RVA: 0x00199A4A File Offset: 0x00197C4A
		// (set) Token: 0x0600AA43 RID: 43587 RVA: 0x00199A52 File Offset: 0x00197C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x0600AA44 RID: 43588 RVA: 0x00199A5B File Offset: 0x00197C5B
		// (set) Token: 0x0600AA45 RID: 43589 RVA: 0x00199A63 File Offset: 0x00197C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandType
		{
			get
			{
				return this.handType_;
			}
			set
			{
				this.handType_ = value;
			}
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x0600AA46 RID: 43590 RVA: 0x00199A6C File Offset: 0x00197C6C
		// (set) Token: 0x0600AA47 RID: 43591 RVA: 0x00199A74 File Offset: 0x00197C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsHold
		{
			get
			{
				return this.isHold_;
			}
			set
			{
				this.isHold_ = value;
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x0600AA48 RID: 43592 RVA: 0x00199A7D File Offset: 0x00197C7D
		// (set) Token: 0x0600AA49 RID: 43593 RVA: 0x00199A85 File Offset: 0x00197C85
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

		// Token: 0x0600AA4A RID: 43594 RVA: 0x00199A8E File Offset: 0x00197C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoldHandRequest);
		}

		// Token: 0x0600AA4B RID: 43595 RVA: 0x00199A9C File Offset: 0x00197C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HoldHandRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.TargetEntityId == other.TargetEntityId && this.HostPlayerId == other.HostPlayerId && this.HandType == other.HandType && this.IsHold == other.IsHold && this.ActionType == other.ActionType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA4C RID: 43596 RVA: 0x00199B28 File Offset: 0x00197D28
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
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.HandType != 0)
			{
				num ^= this.HandType.GetHashCode();
			}
			if (this.IsHold)
			{
				num ^= this.IsHold.GetHashCode();
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

		// Token: 0x0600AA4D RID: 43597 RVA: 0x00199BE4 File Offset: 0x00197DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA4E RID: 43598 RVA: 0x00199BF1 File Offset: 0x00197DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA4F RID: 43599 RVA: 0x00199BFC File Offset: 0x00197DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActionType);
			}
			if (this.IsHold)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsHold);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.HandType != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.HandType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x00199CC8 File Offset: 0x00197EC8
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
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.HandType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandType);
			}
			if (this.IsHold)
			{
				num += 2;
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

		// Token: 0x0600AA51 RID: 43601 RVA: 0x00199D74 File Offset: 0x00197F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HoldHandRequest other)
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
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.HandType != 0)
			{
				this.HandType = other.HandType;
			}
			if (other.IsHold)
			{
				this.IsHold = other.IsHold;
			}
			if (other.ActionType != 0)
			{
				this.ActionType = other.ActionType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA52 RID: 43602 RVA: 0x00199E14 File Offset: 0x00198014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA53 RID: 43603 RVA: 0x00199E20 File Offset: 0x00198020
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
				if (num <= 80U)
				{
					if (num == 24U)
					{
						this.ActionType = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsHold = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.HandType = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D68 RID: 19816
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D69 RID: 19817
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04004D6A RID: 19818
		private long entityId_;

		// Token: 0x04004D6B RID: 19819
		public const int TargetEntityIdFieldNumber = 15;

		// Token: 0x04004D6C RID: 19820
		private long targetEntityId_;

		// Token: 0x04004D6D RID: 19821
		public const int HostPlayerIdFieldNumber = 10;

		// Token: 0x04004D6E RID: 19822
		private int hostPlayerId_;

		// Token: 0x04004D6F RID: 19823
		public const int HandTypeFieldNumber = 11;

		// Token: 0x04004D70 RID: 19824
		private int handType_;

		// Token: 0x04004D71 RID: 19825
		public const int IsHoldFieldNumber = 6;

		// Token: 0x04004D72 RID: 19826
		private bool isHold_;

		// Token: 0x04004D73 RID: 19827
		public const int ActionTypeFieldNumber = 3;

		// Token: 0x04004D74 RID: 19828
		private int actionType_;
	}
}
