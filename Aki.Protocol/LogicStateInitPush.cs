using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000936 RID: 2358
	[NetMessage(EMessageId.LogicStateInitPush)]
	public sealed class LogicStateInitPush : IMessage<LogicStateInitPush>, IMessage, IEquatable<LogicStateInitPush>, IDeepCloneable<LogicStateInitPush>, IBufferMessage
	{
		// Token: 0x0600D00C RID: 53260 RVA: 0x001EA0CC File Offset: 0x001E82CC
		[NullableContext(1)]
		public static LogicStateInitPush Create()
		{
			return new LogicStateInitPush();
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x0600D00D RID: 53261 RVA: 0x001EA0D3 File Offset: 0x001E82D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x0600D00E RID: 53262 RVA: 0x001EA0D6 File Offset: 0x001E82D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogicStateInitPush.Descriptor;
			}
		}

		// Token: 0x0600D00F RID: 53263 RVA: 0x001EA0DD File Offset: 0x001E82DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitPush()
		{
		}

		// Token: 0x0600D010 RID: 53264 RVA: 0x001EA0E8 File Offset: 0x001E82E8
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

		// Token: 0x0600D011 RID: 53265 RVA: 0x001EA15C File Offset: 0x001E835C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitPush Clone()
		{
			return new LogicStateInitPush(this);
		}

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x0600D012 RID: 53266 RVA: 0x001EA164 File Offset: 0x001E8364
		// (set) Token: 0x0600D013 RID: 53267 RVA: 0x001EA16C File Offset: 0x001E836C
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

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x0600D014 RID: 53268 RVA: 0x001EA175 File Offset: 0x001E8375
		// (set) Token: 0x0600D015 RID: 53269 RVA: 0x001EA17D File Offset: 0x001E837D
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

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x0600D016 RID: 53270 RVA: 0x001EA186 File Offset: 0x001E8386
		// (set) Token: 0x0600D017 RID: 53271 RVA: 0x001EA18E File Offset: 0x001E838E
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

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x0600D018 RID: 53272 RVA: 0x001EA197 File Offset: 0x001E8397
		// (set) Token: 0x0600D019 RID: 53273 RVA: 0x001EA19F File Offset: 0x001E839F
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

		// Token: 0x0600D01A RID: 53274 RVA: 0x001EA1A8 File Offset: 0x001E83A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogicStateInitPush);
		}

		// Token: 0x0600D01B RID: 53275 RVA: 0x001EA1B8 File Offset: 0x001E83B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogicStateInitPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.EntityId == other.EntityId && object.Equals(this.InitData, other.InitData) && this.ClientEntityId == other.ClientEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D01C RID: 53276 RVA: 0x001EA22C File Offset: 0x001E842C
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

		// Token: 0x0600D01D RID: 53277 RVA: 0x001EA2B0 File Offset: 0x001E84B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D01E RID: 53278 RVA: 0x001EA2BD File Offset: 0x001E84BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D01F RID: 53279 RVA: 0x001EA2C8 File Offset: 0x001E84C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.initData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.InitData);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.ClientEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.ClientEntityId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D020 RID: 53280 RVA: 0x001EA35C File Offset: 0x001E855C
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

		// Token: 0x0600D021 RID: 53281 RVA: 0x001EA3E4 File Offset: 0x001E85E4
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

		// Token: 0x0600D022 RID: 53282 RVA: 0x001EA48C File Offset: 0x001E868C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D023 RID: 53283 RVA: 0x001EA498 File Offset: 0x001E8698
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
				if (num <= 48U)
				{
					if (num == 34U)
					{
						if (this.initData_ == null)
						{
							this.InitData = new LogicStateComponentPb();
						}
						input.ReadMessage(this.InitData);
						continue;
					}
					if (num == 48U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ClientEntityId = input.ReadInt64();
						continue;
					}
					if (num == 122U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040057FF RID: 22527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005800 RID: 22528
		public const int CombatCommonFieldNumber = 15;

		// Token: 0x04005801 RID: 22529
		private CombatCommon combatCommon_;

		// Token: 0x04005802 RID: 22530
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04005803 RID: 22531
		private long entityId_;

		// Token: 0x04005804 RID: 22532
		public const int InitDataFieldNumber = 4;

		// Token: 0x04005805 RID: 22533
		private LogicStateComponentPb initData_;

		// Token: 0x04005806 RID: 22534
		public const int ClientEntityIdFieldNumber = 7;

		// Token: 0x04005807 RID: 22535
		private long clientEntityId_;
	}
}
