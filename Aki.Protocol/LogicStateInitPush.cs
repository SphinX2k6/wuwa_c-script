using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000947 RID: 2375
	[NetMessage(EMessageId.LogicStateInitPush)]
	public sealed class LogicStateInitPush : IMessage<LogicStateInitPush>, IMessage, IEquatable<LogicStateInitPush>, IDeepCloneable<LogicStateInitPush>, IBufferMessage
	{
		// Token: 0x0600D128 RID: 53544 RVA: 0x001EC3A0 File Offset: 0x001EA5A0
		[NullableContext(1)]
		public static LogicStateInitPush Create()
		{
			return new LogicStateInitPush();
		}

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x0600D129 RID: 53545 RVA: 0x001EC3A7 File Offset: 0x001EA5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x0600D12A RID: 53546 RVA: 0x001EC3AA File Offset: 0x001EA5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogicStateInitPush.Descriptor;
			}
		}

		// Token: 0x0600D12B RID: 53547 RVA: 0x001EC3B1 File Offset: 0x001EA5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitPush()
		{
		}

		// Token: 0x0600D12C RID: 53548 RVA: 0x001EC3BC File Offset: 0x001EA5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitPush(LogicStateInitPush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.entityId_ = other.entityId_;
			this.initData_ = ((other.initData_ != null) ? other.initData_.Clone() : null);
			this.clientEntityId_ = other.clientEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D12D RID: 53549 RVA: 0x001EC430 File Offset: 0x001EA630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitPush Clone()
		{
			return new LogicStateInitPush(this);
		}

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x0600D12E RID: 53550 RVA: 0x001EC438 File Offset: 0x001EA638
		// (set) Token: 0x0600D12F RID: 53551 RVA: 0x001EC440 File Offset: 0x001EA640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x0600D130 RID: 53552 RVA: 0x001EC449 File Offset: 0x001EA649
		// (set) Token: 0x0600D131 RID: 53553 RVA: 0x001EC451 File Offset: 0x001EA651
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

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x0600D132 RID: 53554 RVA: 0x001EC45A File Offset: 0x001EA65A
		// (set) Token: 0x0600D133 RID: 53555 RVA: 0x001EC462 File Offset: 0x001EA662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateComponentPb InitData
		{
			get
			{
				return this.initData_;
			}
			set
			{
				this.initData_ = value;
			}
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x0600D134 RID: 53556 RVA: 0x001EC46B File Offset: 0x001EA66B
		// (set) Token: 0x0600D135 RID: 53557 RVA: 0x001EC473 File Offset: 0x001EA673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ClientEntityId
		{
			get
			{
				return this.clientEntityId_;
			}
			set
			{
				this.clientEntityId_ = value;
			}
		}

		// Token: 0x0600D136 RID: 53558 RVA: 0x001EC47C File Offset: 0x001EA67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogicStateInitPush);
		}

		// Token: 0x0600D137 RID: 53559 RVA: 0x001EC48C File Offset: 0x001EA68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogicStateInitPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.EntityId == other.EntityId && object.Equals(this.InitData, other.InitData) && this.ClientEntityId == other.ClientEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D138 RID: 53560 RVA: 0x001EC500 File Offset: 0x001EA700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.initData_ != null)
			{
				num ^= this.InitData.GetHashCode();
			}
			if (this.ClientEntityId != 0L)
			{
				num ^= this.ClientEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D139 RID: 53561 RVA: 0x001EC584 File Offset: 0x001EA784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D13A RID: 53562 RVA: 0x001EC591 File Offset: 0x001EA791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D13B RID: 53563 RVA: 0x001EC59C File Offset: 0x001EA79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.initData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.InitData);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.ClientEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.ClientEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D13C RID: 53564 RVA: 0x001EC630 File Offset: 0x001EA830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.initData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InitData);
			}
			if (this.ClientEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ClientEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D13D RID: 53565 RVA: 0x001EC6B8 File Offset: 0x001EA8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogicStateInitPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.initData_ != null)
			{
				if (this.initData_ == null)
				{
					this.InitData = new LogicStateComponentPb();
				}
				this.InitData.MergeFrom(other.InitData);
			}
			if (other.ClientEntityId != 0L)
			{
				this.ClientEntityId = other.ClientEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D13E RID: 53566 RVA: 0x001EC760 File Offset: 0x001EA960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D13F RID: 53567 RVA: 0x001EC76C File Offset: 0x001EA96C
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
				if (num <= 32U)
				{
					if (num == 10U)
					{
						if (this.initData_ == null)
						{
							this.InitData = new LogicStateComponentPb();
						}
						input.ReadMessage(this.InitData);
						continue;
					}
					if (num == 32U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 112U)
					{
						this.ClientEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040057F8 RID: 22520
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057F9 RID: 22521
		public const int CombatCommonFieldNumber = 8;

		// Token: 0x040057FA RID: 22522
		private CombatCommon combatCommon_;

		// Token: 0x040057FB RID: 22523
		public const int EntityIdFieldNumber = 4;

		// Token: 0x040057FC RID: 22524
		private long entityId_;

		// Token: 0x040057FD RID: 22525
		public const int InitDataFieldNumber = 1;

		// Token: 0x040057FE RID: 22526
		private LogicStateComponentPb initData_;

		// Token: 0x040057FF RID: 22527
		public const int ClientEntityIdFieldNumber = 14;

		// Token: 0x04005800 RID: 22528
		private long clientEntityId_;
	}
}
