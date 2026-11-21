using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000935 RID: 2357
	[NetMessage(EMessageId.LogicStateInitNotify)]
	public sealed class LogicStateInitNotify : IMessage<LogicStateInitNotify>, IMessage, IEquatable<LogicStateInitNotify>, IDeepCloneable<LogicStateInitNotify>, IBufferMessage
	{
		// Token: 0x0600CFF6 RID: 53238 RVA: 0x001E9CF8 File Offset: 0x001E7EF8
		[NullableContext(1)]
		public static LogicStateInitNotify Create()
		{
			return new LogicStateInitNotify();
		}

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x0600CFF7 RID: 53239 RVA: 0x001E9CFF File Offset: 0x001E7EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x0600CFF8 RID: 53240 RVA: 0x001E9D02 File Offset: 0x001E7F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogicStateInitNotify.Descriptor;
			}
		}

		// Token: 0x0600CFF9 RID: 53241 RVA: 0x001E9D09 File Offset: 0x001E7F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitNotify()
		{
		}

		// Token: 0x0600CFFA RID: 53242 RVA: 0x001E9D14 File Offset: 0x001E7F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitNotify(LogicStateInitNotify other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.entityId_ = other.entityId_;
			this.initData_ = ((other.initData_ != null) ? other.initData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFFB RID: 53243 RVA: 0x001E9D7C File Offset: 0x001E7F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitNotify Clone()
		{
			return new LogicStateInitNotify(this);
		}

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x0600CFFC RID: 53244 RVA: 0x001E9D84 File Offset: 0x001E7F84
		// (set) Token: 0x0600CFFD RID: 53245 RVA: 0x001E9D8C File Offset: 0x001E7F8C
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

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x0600CFFE RID: 53246 RVA: 0x001E9D95 File Offset: 0x001E7F95
		// (set) Token: 0x0600CFFF RID: 53247 RVA: 0x001E9D9D File Offset: 0x001E7F9D
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

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x0600D000 RID: 53248 RVA: 0x001E9DA6 File Offset: 0x001E7FA6
		// (set) Token: 0x0600D001 RID: 53249 RVA: 0x001E9DAE File Offset: 0x001E7FAE
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

		// Token: 0x0600D002 RID: 53250 RVA: 0x001E9DB7 File Offset: 0x001E7FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogicStateInitNotify);
		}

		// Token: 0x0600D003 RID: 53251 RVA: 0x001E9DC8 File Offset: 0x001E7FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogicStateInitNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.EntityId == other.EntityId && object.Equals(this.InitData, other.InitData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D004 RID: 53252 RVA: 0x001E9E2C File Offset: 0x001E802C
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

		// Token: 0x0600D005 RID: 53253 RVA: 0x001E9E97 File Offset: 0x001E8097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D006 RID: 53254 RVA: 0x001E9EA4 File Offset: 0x001E80A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D007 RID: 53255 RVA: 0x001E9EB0 File Offset: 0x001E80B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.initData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.InitData);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
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

		// Token: 0x0600D008 RID: 53256 RVA: 0x001E9F28 File Offset: 0x001E8128
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

		// Token: 0x0600D009 RID: 53257 RVA: 0x001E9F98 File Offset: 0x001E8198
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

		// Token: 0x0600D00A RID: 53258 RVA: 0x001EA02C File Offset: 0x001E822C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D00B RID: 53259 RVA: 0x001EA038 File Offset: 0x001E8238
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
				if (num != 18U)
				{
					if (num != 80U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
					else
					{
						this.EntityId = input.ReadInt64();
					}
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
		}

		// Token: 0x040057F8 RID: 22520
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057F9 RID: 22521
		public const int CombatCommonFieldNumber = 15;

		// Token: 0x040057FA RID: 22522
		private CombatCommon combatCommon_;

		// Token: 0x040057FB RID: 22523
		public const int EntityIdFieldNumber = 10;

		// Token: 0x040057FC RID: 22524
		private long entityId_;

		// Token: 0x040057FD RID: 22525
		public const int InitDataFieldNumber = 2;

		// Token: 0x040057FE RID: 22526
		private LogicStateComponentPb initData_;
	}
}
