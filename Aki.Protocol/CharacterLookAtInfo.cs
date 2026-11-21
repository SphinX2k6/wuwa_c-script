using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027A RID: 634
	public sealed class CharacterLookAtInfo : IMessage<CharacterLookAtInfo>, IMessage, IEquatable<CharacterLookAtInfo>, IDeepCloneable<CharacterLookAtInfo>, IBufferMessage
	{
		// Token: 0x060042C8 RID: 17096 RVA: 0x000A3FEA File Offset: 0x000A21EA
		[NullableContext(1)]
		public static CharacterLookAtInfo Create()
		{
			return new CharacterLookAtInfo();
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060042C9 RID: 17097 RVA: 0x000A3FF1 File Offset: 0x000A21F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterLookAtInfo> Parser
		{
			get
			{
				return CharacterLookAtInfo._parser;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060042CA RID: 17098 RVA: 0x000A3FF8 File Offset: 0x000A21F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060042CB RID: 17099 RVA: 0x000A3FFB File Offset: 0x000A21FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterLookAtInfo.Descriptor;
			}
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x000A4002 File Offset: 0x000A2202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtInfo()
		{
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x000A400C File Offset: 0x000A220C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtInfo(CharacterLookAtInfo other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityId_ = other.entityId_;
			this.targetType_ = other.targetType_;
			this.targetEntityId_ = other.targetEntityId_;
			this.targetPos_ = ((other.targetPos_ != null) ? other.targetPos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x000A407C File Offset: 0x000A227C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLookAtInfo Clone()
		{
			return new CharacterLookAtInfo(this);
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x060042CF RID: 17103 RVA: 0x000A4084 File Offset: 0x000A2284
		// (set) Token: 0x060042D0 RID: 17104 RVA: 0x000A408C File Offset: 0x000A228C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
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

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060042D1 RID: 17105 RVA: 0x000A4095 File Offset: 0x000A2295
		// (set) Token: 0x060042D2 RID: 17106 RVA: 0x000A409D File Offset: 0x000A229D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetType
		{
			get
			{
				return this.targetType_;
			}
			set
			{
				this.targetType_ = value;
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060042D3 RID: 17107 RVA: 0x000A40A6 File Offset: 0x000A22A6
		// (set) Token: 0x060042D4 RID: 17108 RVA: 0x000A40BE File Offset: 0x000A22BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetEntityId
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.targetEntityId_;
				}
				return CharacterLookAtInfo.TargetEntityIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060042D5 RID: 17109 RVA: 0x000A40D5 File Offset: 0x000A22D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTargetEntityId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x000A40E2 File Offset: 0x000A22E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTargetEntityId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060042D7 RID: 17111 RVA: 0x000A40F3 File Offset: 0x000A22F3
		// (set) Token: 0x060042D8 RID: 17112 RVA: 0x000A40FB File Offset: 0x000A22FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector TargetPos
		{
			get
			{
				return this.targetPos_;
			}
			set
			{
				this.targetPos_ = value;
			}
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x000A4104 File Offset: 0x000A2304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterLookAtInfo);
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x000A4114 File Offset: 0x000A2314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterLookAtInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.TargetType == other.TargetType && this.TargetEntityId == other.TargetEntityId && object.Equals(this.TargetPos, other.TargetPos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x000A4184 File Offset: 0x000A2384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.TargetType != 0)
			{
				num ^= this.TargetType.GetHashCode();
			}
			if (this.HasTargetEntityId)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this.targetPos_ != null)
			{
				num ^= this.TargetPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x000A420B File Offset: 0x000A240B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x000A4218 File Offset: 0x000A2418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x000A4224 File Offset: 0x000A2424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityId);
			}
			if (this.TargetType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TargetType);
			}
			if (this.HasTargetEntityId)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetEntityId);
			}
			if (this.targetPos_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TargetPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x000A42B4 File Offset: 0x000A24B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this.TargetType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetType);
			}
			if (this.HasTargetEntityId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetEntityId);
			}
			if (this.targetPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x000A433C File Offset: 0x000A253C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharacterLookAtInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			if (other.TargetType != 0)
			{
				this.TargetType = other.TargetType;
			}
			if (other.HasTargetEntityId)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			if (other.targetPos_ != null)
			{
				if (this.targetPos_ == null)
				{
					this.TargetPos = new Vector();
				}
				this.TargetPos.MergeFrom(other.TargetPos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x000A43CC File Offset: 0x000A25CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x000A43D8 File Offset: 0x000A25D8
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
					if (num == 8U)
					{
						this.EntityId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TargetType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TargetEntityId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.targetPos_ == null)
						{
							this.TargetPos = new Vector();
						}
						input.ReadMessage(this.TargetPos);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E6C RID: 11884
		private static readonly MessageParser<CharacterLookAtInfo> _parser = new MessageParser<CharacterLookAtInfo>(() => new CharacterLookAtInfo());

		// Token: 0x04002E6D RID: 11885
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E6E RID: 11886
		private int _hasBits0;

		// Token: 0x04002E6F RID: 11887
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04002E70 RID: 11888
		private int entityId_;

		// Token: 0x04002E71 RID: 11889
		public const int TargetTypeFieldNumber = 2;

		// Token: 0x04002E72 RID: 11890
		private int targetType_;

		// Token: 0x04002E73 RID: 11891
		public const int TargetEntityIdFieldNumber = 3;

		// Token: 0x04002E74 RID: 11892
		private static readonly int TargetEntityIdDefaultValue = 0;

		// Token: 0x04002E75 RID: 11893
		private int targetEntityId_;

		// Token: 0x04002E76 RID: 11894
		public const int TargetPosFieldNumber = 4;

		// Token: 0x04002E77 RID: 11895
		private Vector targetPos_;
	}
}
