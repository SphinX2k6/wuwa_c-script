using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000948 RID: 2376
	[NetMessage(EMessageId.LogicStateInitRequest)]
	public sealed class LogicStateInitRequest : IMessage<LogicStateInitRequest>, IMessage, IEquatable<LogicStateInitRequest>, IDeepCloneable<LogicStateInitRequest>, IBufferMessage
	{
		// Token: 0x0600D140 RID: 53568 RVA: 0x001EC81D File Offset: 0x001EAA1D
		[NullableContext(1)]
		public static LogicStateInitRequest Create()
		{
			return new LogicStateInitRequest();
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x0600D141 RID: 53569 RVA: 0x001EC824 File Offset: 0x001EAA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x0600D142 RID: 53570 RVA: 0x001EC827 File Offset: 0x001EAA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogicStateInitRequest.Descriptor;
			}
		}

		// Token: 0x0600D143 RID: 53571 RVA: 0x001EC82E File Offset: 0x001EAA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitRequest()
		{
		}

		// Token: 0x0600D144 RID: 53572 RVA: 0x001EC838 File Offset: 0x001EAA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitRequest(LogicStateInitRequest other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.entityId_ = other.entityId_;
			this.initData_ = ((other.initData_ != null) ? other.initData_.Clone() : null);
			this.clientEntityId_ = other.clientEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D145 RID: 53573 RVA: 0x001EC8AC File Offset: 0x001EAAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitRequest Clone()
		{
			return new LogicStateInitRequest(this);
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x0600D146 RID: 53574 RVA: 0x001EC8B4 File Offset: 0x001EAAB4
		// (set) Token: 0x0600D147 RID: 53575 RVA: 0x001EC8BC File Offset: 0x001EAABC
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

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x0600D148 RID: 53576 RVA: 0x001EC8C5 File Offset: 0x001EAAC5
		// (set) Token: 0x0600D149 RID: 53577 RVA: 0x001EC8CD File Offset: 0x001EAACD
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

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x0600D14A RID: 53578 RVA: 0x001EC8D6 File Offset: 0x001EAAD6
		// (set) Token: 0x0600D14B RID: 53579 RVA: 0x001EC8DE File Offset: 0x001EAADE
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

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x0600D14C RID: 53580 RVA: 0x001EC8E7 File Offset: 0x001EAAE7
		// (set) Token: 0x0600D14D RID: 53581 RVA: 0x001EC8EF File Offset: 0x001EAAEF
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

		// Token: 0x0600D14E RID: 53582 RVA: 0x001EC8F8 File Offset: 0x001EAAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogicStateInitRequest);
		}

		// Token: 0x0600D14F RID: 53583 RVA: 0x001EC908 File Offset: 0x001EAB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogicStateInitRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.EntityId == other.EntityId && object.Equals(this.InitData, other.InitData) && this.ClientEntityId == other.ClientEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D150 RID: 53584 RVA: 0x001EC97C File Offset: 0x001EAB7C
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

		// Token: 0x0600D151 RID: 53585 RVA: 0x001ECA00 File Offset: 0x001EAC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D152 RID: 53586 RVA: 0x001ECA0D File Offset: 0x001EAC0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D153 RID: 53587 RVA: 0x001ECA18 File Offset: 0x001EAC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.initData_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.InitData);
			}
			if (this.ClientEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.ClientEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D154 RID: 53588 RVA: 0x001ECAAC File Offset: 0x001EACAC
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

		// Token: 0x0600D155 RID: 53589 RVA: 0x001ECB34 File Offset: 0x001EAD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogicStateInitRequest other)
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

		// Token: 0x0600D156 RID: 53590 RVA: 0x001ECBDC File Offset: 0x001EADDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D157 RID: 53591 RVA: 0x001ECBE8 File Offset: 0x001EADE8
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 16U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						if (this.initData_ == null)
						{
							this.InitData = new LogicStateComponentPb();
						}
						input.ReadMessage(this.InitData);
						continue;
					}
					if (num == 56U)
					{
						this.ClientEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005801 RID: 22529
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005802 RID: 22530
		public const int CombatCommonFieldNumber = 1;

		// Token: 0x04005803 RID: 22531
		private CombatCommon combatCommon_;

		// Token: 0x04005804 RID: 22532
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04005805 RID: 22533
		private long entityId_;

		// Token: 0x04005806 RID: 22534
		public const int InitDataFieldNumber = 5;

		// Token: 0x04005807 RID: 22535
		private LogicStateComponentPb initData_;

		// Token: 0x04005808 RID: 22536
		public const int ClientEntityIdFieldNumber = 7;

		// Token: 0x04005809 RID: 22537
		private long clientEntityId_;
	}
}
