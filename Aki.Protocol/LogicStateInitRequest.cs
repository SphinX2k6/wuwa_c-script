using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000937 RID: 2359
	[NetMessage(EMessageId.LogicStateInitRequest)]
	public sealed class LogicStateInitRequest : IMessage<LogicStateInitRequest>, IMessage, IEquatable<LogicStateInitRequest>, IDeepCloneable<LogicStateInitRequest>, IBufferMessage
	{
		// Token: 0x0600D024 RID: 53284 RVA: 0x001EA549 File Offset: 0x001E8749
		[NullableContext(1)]
		public static LogicStateInitRequest Create()
		{
			return new LogicStateInitRequest();
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x0600D025 RID: 53285 RVA: 0x001EA550 File Offset: 0x001E8750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x0600D026 RID: 53286 RVA: 0x001EA553 File Offset: 0x001E8753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogicStateInitRequest.Descriptor;
			}
		}

		// Token: 0x0600D027 RID: 53287 RVA: 0x001EA55A File Offset: 0x001E875A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitRequest()
		{
		}

		// Token: 0x0600D028 RID: 53288 RVA: 0x001EA564 File Offset: 0x001E8764
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

		// Token: 0x0600D029 RID: 53289 RVA: 0x001EA5D8 File Offset: 0x001E87D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitRequest Clone()
		{
			return new LogicStateInitRequest(this);
		}

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x0600D02A RID: 53290 RVA: 0x001EA5E0 File Offset: 0x001E87E0
		// (set) Token: 0x0600D02B RID: 53291 RVA: 0x001EA5E8 File Offset: 0x001E87E8
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

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x0600D02C RID: 53292 RVA: 0x001EA5F1 File Offset: 0x001E87F1
		// (set) Token: 0x0600D02D RID: 53293 RVA: 0x001EA5F9 File Offset: 0x001E87F9
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

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x0600D02E RID: 53294 RVA: 0x001EA602 File Offset: 0x001E8802
		// (set) Token: 0x0600D02F RID: 53295 RVA: 0x001EA60A File Offset: 0x001E880A
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

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x0600D030 RID: 53296 RVA: 0x001EA613 File Offset: 0x001E8813
		// (set) Token: 0x0600D031 RID: 53297 RVA: 0x001EA61B File Offset: 0x001E881B
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

		// Token: 0x0600D032 RID: 53298 RVA: 0x001EA624 File Offset: 0x001E8824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogicStateInitRequest);
		}

		// Token: 0x0600D033 RID: 53299 RVA: 0x001EA634 File Offset: 0x001E8834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogicStateInitRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.EntityId == other.EntityId && object.Equals(this.InitData, other.InitData) && this.ClientEntityId == other.ClientEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D034 RID: 53300 RVA: 0x001EA6A8 File Offset: 0x001E88A8
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

		// Token: 0x0600D035 RID: 53301 RVA: 0x001EA72C File Offset: 0x001E892C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D036 RID: 53302 RVA: 0x001EA739 File Offset: 0x001E8939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D037 RID: 53303 RVA: 0x001EA744 File Offset: 0x001E8944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.initData_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.InitData);
			}
			if (this.ClientEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.ClientEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D038 RID: 53304 RVA: 0x001EA7D8 File Offset: 0x001E89D8
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

		// Token: 0x0600D039 RID: 53305 RVA: 0x001EA860 File Offset: 0x001E8A60
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

		// Token: 0x0600D03A RID: 53306 RVA: 0x001EA908 File Offset: 0x001E8B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D03B RID: 53307 RVA: 0x001EA914 File Offset: 0x001E8B14
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
				if (num <= 34U)
				{
					if (num == 16U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 34U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.initData_ == null)
						{
							this.InitData = new LogicStateComponentPb();
						}
						input.ReadMessage(this.InitData);
						continue;
					}
					if (num == 96U)
					{
						this.ClientEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005808 RID: 22536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005809 RID: 22537
		public const int CombatCommonFieldNumber = 4;

		// Token: 0x0400580A RID: 22538
		private CombatCommon combatCommon_;

		// Token: 0x0400580B RID: 22539
		public const int EntityIdFieldNumber = 2;

		// Token: 0x0400580C RID: 22540
		private long entityId_;

		// Token: 0x0400580D RID: 22541
		public const int InitDataFieldNumber = 10;

		// Token: 0x0400580E RID: 22542
		private LogicStateComponentPb initData_;

		// Token: 0x0400580F RID: 22543
		public const int ClientEntityIdFieldNumber = 12;

		// Token: 0x04005810 RID: 22544
		private long clientEntityId_;
	}
}
