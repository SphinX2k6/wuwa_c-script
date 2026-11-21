using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000744 RID: 1860
	[NetMessage(EMessageId.HoldHandRequest)]
	public sealed class HoldHandRequest : IMessage<HoldHandRequest>, IMessage, IEquatable<HoldHandRequest>, IDeepCloneable<HoldHandRequest>, IBufferMessage
	{
		// Token: 0x0600A8E2 RID: 43234 RVA: 0x00196F70 File Offset: 0x00195170
		[NullableContext(1)]
		public static HoldHandRequest Create()
		{
			return new HoldHandRequest();
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x0600A8E3 RID: 43235 RVA: 0x00196F77 File Offset: 0x00195177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x0600A8E4 RID: 43236 RVA: 0x00196F7A File Offset: 0x0019517A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoldHandRequest.Descriptor;
			}
		}

		// Token: 0x0600A8E5 RID: 43237 RVA: 0x00196F81 File Offset: 0x00195181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandRequest()
		{
		}

		// Token: 0x0600A8E6 RID: 43238 RVA: 0x00196F8C File Offset: 0x0019518C
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

		// Token: 0x0600A8E7 RID: 43239 RVA: 0x00196FF8 File Offset: 0x001951F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandRequest Clone()
		{
			return new HoldHandRequest(this);
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x0600A8E8 RID: 43240 RVA: 0x00197000 File Offset: 0x00195200
		// (set) Token: 0x0600A8E9 RID: 43241 RVA: 0x00197008 File Offset: 0x00195208
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

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x0600A8EA RID: 43242 RVA: 0x00197011 File Offset: 0x00195211
		// (set) Token: 0x0600A8EB RID: 43243 RVA: 0x00197019 File Offset: 0x00195219
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

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x0600A8EC RID: 43244 RVA: 0x00197022 File Offset: 0x00195222
		// (set) Token: 0x0600A8ED RID: 43245 RVA: 0x0019702A File Offset: 0x0019522A
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

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x0600A8EE RID: 43246 RVA: 0x00197033 File Offset: 0x00195233
		// (set) Token: 0x0600A8EF RID: 43247 RVA: 0x0019703B File Offset: 0x0019523B
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

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x0600A8F0 RID: 43248 RVA: 0x00197044 File Offset: 0x00195244
		// (set) Token: 0x0600A8F1 RID: 43249 RVA: 0x0019704C File Offset: 0x0019524C
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

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x0600A8F2 RID: 43250 RVA: 0x00197055 File Offset: 0x00195255
		// (set) Token: 0x0600A8F3 RID: 43251 RVA: 0x0019705D File Offset: 0x0019525D
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

		// Token: 0x0600A8F4 RID: 43252 RVA: 0x00197066 File Offset: 0x00195266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoldHandRequest);
		}

		// Token: 0x0600A8F5 RID: 43253 RVA: 0x00197074 File Offset: 0x00195274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HoldHandRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.TargetEntityId == other.TargetEntityId && this.HostPlayerId == other.HostPlayerId && this.HandType == other.HandType && this.IsHold == other.IsHold && this.ActionType == other.ActionType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A8F6 RID: 43254 RVA: 0x00197100 File Offset: 0x00195300
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

		// Token: 0x0600A8F7 RID: 43255 RVA: 0x001971BC File Offset: 0x001953BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A8F8 RID: 43256 RVA: 0x001971C9 File Offset: 0x001953C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8F9 RID: 43257 RVA: 0x001971D4 File Offset: 0x001953D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsHold)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsHold);
			}
			if (this.ActionType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActionType);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.HandType != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.HandType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8FA RID: 43258 RVA: 0x0019729C File Offset: 0x0019549C
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

		// Token: 0x0600A8FB RID: 43259 RVA: 0x00197348 File Offset: 0x00195548
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

		// Token: 0x0600A8FC RID: 43260 RVA: 0x001973E8 File Offset: 0x001955E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x001973F4 File Offset: 0x001955F4
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.IsHold = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.ActionType = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.TargetEntityId = input.ReadInt64();
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
					if (num == 96U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D61 RID: 19809
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D62 RID: 19810
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04004D63 RID: 19811
		private long entityId_;

		// Token: 0x04004D64 RID: 19812
		public const int TargetEntityIdFieldNumber = 5;

		// Token: 0x04004D65 RID: 19813
		private long targetEntityId_;

		// Token: 0x04004D66 RID: 19814
		public const int HostPlayerIdFieldNumber = 14;

		// Token: 0x04004D67 RID: 19815
		private int hostPlayerId_;

		// Token: 0x04004D68 RID: 19816
		public const int HandTypeFieldNumber = 11;

		// Token: 0x04004D69 RID: 19817
		private int handType_;

		// Token: 0x04004D6A RID: 19818
		public const int IsHoldFieldNumber = 1;

		// Token: 0x04004D6B RID: 19819
		private bool isHold_;

		// Token: 0x04004D6C RID: 19820
		public const int ActionTypeFieldNumber = 3;

		// Token: 0x04004D6D RID: 19821
		private int actionType_;
	}
}
