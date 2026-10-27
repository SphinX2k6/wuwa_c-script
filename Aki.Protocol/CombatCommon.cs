using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AD RID: 685
	public sealed class CombatCommon : IMessage<CombatCommon>, IMessage, IEquatable<CombatCommon>, IDeepCloneable<CombatCommon>, IBufferMessage
	{
		// Token: 0x060046F1 RID: 18161 RVA: 0x000AE3C0 File Offset: 0x000AC5C0
		[NullableContext(1)]
		public static CombatCommon Create()
		{
			return new CombatCommon();
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060046F2 RID: 18162 RVA: 0x000AE3C7 File Offset: 0x000AC5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060046F3 RID: 18163 RVA: 0x000AE3CA File Offset: 0x000AC5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatCommon.Descriptor;
			}
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x000AE3D1 File Offset: 0x000AC5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon()
		{
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x000AE3DC File Offset: 0x000AC5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon(CombatCommon other) : this()
		{
			this.preMessageId_ = other.preMessageId_;
			this.messageId_ = other.messageId_;
			this.originator_ = other.originator_;
			this.timeStamp_ = other.timeStamp_;
			this.entityId_ = other.entityId_;
			this.isServerRequest_ = other.isServerRequest_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x000AE448 File Offset: 0x000AC648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon Clone()
		{
			return new CombatCommon(this);
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060046F7 RID: 18167 RVA: 0x000AE450 File Offset: 0x000AC650
		// (set) Token: 0x060046F8 RID: 18168 RVA: 0x000AE458 File Offset: 0x000AC658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PreMessageId
		{
			get
			{
				return this.preMessageId_;
			}
			set
			{
				this.preMessageId_ = value;
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060046F9 RID: 18169 RVA: 0x000AE461 File Offset: 0x000AC661
		// (set) Token: 0x060046FA RID: 18170 RVA: 0x000AE469 File Offset: 0x000AC669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MessageId
		{
			get
			{
				return this.messageId_;
			}
			set
			{
				this.messageId_ = value;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x000AE472 File Offset: 0x000AC672
		// (set) Token: 0x060046FC RID: 18172 RVA: 0x000AE47A File Offset: 0x000AC67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Originator
		{
			get
			{
				return this.originator_;
			}
			set
			{
				this.originator_ = value;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x000AE483 File Offset: 0x000AC683
		// (set) Token: 0x060046FE RID: 18174 RVA: 0x000AE48B File Offset: 0x000AC68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TimeStamp
		{
			get
			{
				return this.timeStamp_;
			}
			set
			{
				this.timeStamp_ = value;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x000AE494 File Offset: 0x000AC694
		// (set) Token: 0x06004700 RID: 18176 RVA: 0x000AE49C File Offset: 0x000AC69C
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

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06004701 RID: 18177 RVA: 0x000AE4A5 File Offset: 0x000AC6A5
		// (set) Token: 0x06004702 RID: 18178 RVA: 0x000AE4AD File Offset: 0x000AC6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsServerRequest
		{
			get
			{
				return this.isServerRequest_;
			}
			set
			{
				this.isServerRequest_ = value;
			}
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x000AE4B6 File Offset: 0x000AC6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatCommon);
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x000AE4C4 File Offset: 0x000AC6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatCommon other)
		{
			return other != null && (other == this || (this.PreMessageId == other.PreMessageId && this.MessageId == other.MessageId && this.Originator == other.Originator && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeStamp, other.TimeStamp) && this.EntityId == other.EntityId && this.IsServerRequest == other.IsServerRequest && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x000AE558 File Offset: 0x000AC758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PreMessageId != 0L)
			{
				num ^= this.PreMessageId.GetHashCode();
			}
			if (this.MessageId != 0L)
			{
				num ^= this.MessageId.GetHashCode();
			}
			if (this.Originator != 0L)
			{
				num ^= this.Originator.GetHashCode();
			}
			if (this.TimeStamp != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TimeStamp);
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsServerRequest)
			{
				num ^= this.IsServerRequest.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x000AE61B File Offset: 0x000AC81B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x000AE628 File Offset: 0x000AC828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x000AE634 File Offset: 0x000AC834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PreMessageId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.PreMessageId);
			}
			if (this.MessageId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.MessageId);
			}
			if (this.Originator != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Originator);
			}
			if (this.TimeStamp != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.TimeStamp);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsServerRequest)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsServerRequest);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x000AE704 File Offset: 0x000AC904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PreMessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PreMessageId);
			}
			if (this.MessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MessageId);
			}
			if (this.Originator != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Originator);
			}
			if (this.TimeStamp != 0f)
			{
				num += 5;
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsServerRequest)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x000AE7A8 File Offset: 0x000AC9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatCommon other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PreMessageId != 0L)
			{
				this.PreMessageId = other.PreMessageId;
			}
			if (other.MessageId != 0L)
			{
				this.MessageId = other.MessageId;
			}
			if (other.Originator != 0L)
			{
				this.Originator = other.Originator;
			}
			if (other.TimeStamp != 0f)
			{
				this.TimeStamp = other.TimeStamp;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsServerRequest)
			{
				this.IsServerRequest = other.IsServerRequest;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x000AE84D File Offset: 0x000ACA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x000AE858 File Offset: 0x000ACA58
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.PreMessageId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.MessageId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.Originator = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 37U)
					{
						this.TimeStamp = input.ReadFloat();
						continue;
					}
					if (num == 40U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.IsServerRequest = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F72 RID: 12146
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F73 RID: 12147
		public const int PreMessageIdFieldNumber = 1;

		// Token: 0x04002F74 RID: 12148
		private long preMessageId_;

		// Token: 0x04002F75 RID: 12149
		public const int MessageIdFieldNumber = 2;

		// Token: 0x04002F76 RID: 12150
		private long messageId_;

		// Token: 0x04002F77 RID: 12151
		public const int OriginatorFieldNumber = 3;

		// Token: 0x04002F78 RID: 12152
		private long originator_;

		// Token: 0x04002F79 RID: 12153
		public const int TimeStampFieldNumber = 4;

		// Token: 0x04002F7A RID: 12154
		private float timeStamp_;

		// Token: 0x04002F7B RID: 12155
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04002F7C RID: 12156
		private long entityId_;

		// Token: 0x04002F7D RID: 12157
		public const int IsServerRequestFieldNumber = 6;

		// Token: 0x04002F7E RID: 12158
		private bool isServerRequest_;
	}
}
