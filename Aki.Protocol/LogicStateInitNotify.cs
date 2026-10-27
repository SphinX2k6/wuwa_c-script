using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000946 RID: 2374
	[NetMessage(EMessageId.LogicStateInitNotify)]
	public sealed class LogicStateInitNotify : IMessage<LogicStateInitNotify>, IMessage, IEquatable<LogicStateInitNotify>, IDeepCloneable<LogicStateInitNotify>, IBufferMessage
	{
		// Token: 0x0600D112 RID: 53522 RVA: 0x001EBFCC File Offset: 0x001EA1CC
		[NullableContext(1)]
		public static LogicStateInitNotify Create()
		{
			return new LogicStateInitNotify();
		}

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x0600D113 RID: 53523 RVA: 0x001EBFD3 File Offset: 0x001EA1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x0600D114 RID: 53524 RVA: 0x001EBFD6 File Offset: 0x001EA1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogicStateInitNotify.Descriptor;
			}
		}

		// Token: 0x0600D115 RID: 53525 RVA: 0x001EBFDD File Offset: 0x001EA1DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitNotify()
		{
		}

		// Token: 0x0600D116 RID: 53526 RVA: 0x001EBFE8 File Offset: 0x001EA1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitNotify(LogicStateInitNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.entityId_ = other.entityId_;
			this.initData_ = ((other.initData_ != null) ? other.initData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D117 RID: 53527 RVA: 0x001EC050 File Offset: 0x001EA250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitNotify Clone()
		{
			return new LogicStateInitNotify(this);
		}

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x0600D118 RID: 53528 RVA: 0x001EC058 File Offset: 0x001EA258
		// (set) Token: 0x0600D119 RID: 53529 RVA: 0x001EC060 File Offset: 0x001EA260
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

		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x0600D11A RID: 53530 RVA: 0x001EC069 File Offset: 0x001EA269
		// (set) Token: 0x0600D11B RID: 53531 RVA: 0x001EC071 File Offset: 0x001EA271
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

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x0600D11C RID: 53532 RVA: 0x001EC07A File Offset: 0x001EA27A
		// (set) Token: 0x0600D11D RID: 53533 RVA: 0x001EC082 File Offset: 0x001EA282
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

		// Token: 0x0600D11E RID: 53534 RVA: 0x001EC08B File Offset: 0x001EA28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogicStateInitNotify);
		}

		// Token: 0x0600D11F RID: 53535 RVA: 0x001EC09C File Offset: 0x001EA29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogicStateInitNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.EntityId == other.EntityId && object.Equals(this.InitData, other.InitData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D120 RID: 53536 RVA: 0x001EC100 File Offset: 0x001EA300
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D121 RID: 53537 RVA: 0x001EC16B File Offset: 0x001EA36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D122 RID: 53538 RVA: 0x001EC178 File Offset: 0x001EA378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D123 RID: 53539 RVA: 0x001EC184 File Offset: 0x001EA384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this.initData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.InitData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D124 RID: 53540 RVA: 0x001EC1FC File Offset: 0x001EA3FC
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D125 RID: 53541 RVA: 0x001EC26C File Offset: 0x001EA46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogicStateInitNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D126 RID: 53542 RVA: 0x001EC300 File Offset: 0x001EA500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D127 RID: 53543 RVA: 0x001EC30C File Offset: 0x001EA50C
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
				if (num != 90U)
				{
					if (num != 96U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.initData_ == null)
							{
								this.InitData = new LogicStateComponentPb();
							}
							input.ReadMessage(this.InitData);
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.combatCommon_ == null)
					{
						this.CombatCommon = new CombatCommon();
					}
					input.ReadMessage(this.CombatCommon);
				}
			}
		}

		// Token: 0x040057F1 RID: 22513
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057F2 RID: 22514
		public const int CombatCommonFieldNumber = 11;

		// Token: 0x040057F3 RID: 22515
		private CombatCommon combatCommon_;

		// Token: 0x040057F4 RID: 22516
		public const int EntityIdFieldNumber = 12;

		// Token: 0x040057F5 RID: 22517
		private long entityId_;

		// Token: 0x040057F6 RID: 22518
		public const int InitDataFieldNumber = 13;

		// Token: 0x040057F7 RID: 22519
		private LogicStateComponentPb initData_;
	}
}
