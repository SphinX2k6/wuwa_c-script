using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E0B RID: 3595
	public sealed class QuestLockInfo : IMessage<QuestLockInfo>, IMessage, IEquatable<QuestLockInfo>, IDeepCloneable<QuestLockInfo>, IBufferMessage
	{
		// Token: 0x0601357C RID: 79228 RVA: 0x002D0DB5 File Offset: 0x002CEFB5
		[NullableContext(1)]
		public static QuestLockInfo Create()
		{
			return new QuestLockInfo();
		}

		// Token: 0x17004029 RID: 16425
		// (get) Token: 0x0601357D RID: 79229 RVA: 0x002D0DBC File Offset: 0x002CEFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestLockInfo> Parser
		{
			get
			{
				return QuestLockInfo._parser;
			}
		}

		// Token: 0x1700402A RID: 16426
		// (get) Token: 0x0601357E RID: 79230 RVA: 0x002D0DC3 File Offset: 0x002CEFC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700402B RID: 16427
		// (get) Token: 0x0601357F RID: 79231 RVA: 0x002D0DC6 File Offset: 0x002CEFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestLockInfo.Descriptor;
			}
		}

		// Token: 0x06013580 RID: 79232 RVA: 0x002D0DCD File Offset: 0x002CEFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfo()
		{
		}

		// Token: 0x06013581 RID: 79233 RVA: 0x002D0DD5 File Offset: 0x002CEFD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfo(QuestLockInfo other) : this()
		{
			this.questId_ = other.questId_;
			this.multiModeLock_ = other.multiModeLock_;
			this.lockType_ = other.lockType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013582 RID: 79234 RVA: 0x002D0E12 File Offset: 0x002CF012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfo Clone()
		{
			return new QuestLockInfo(this);
		}

		// Token: 0x1700402C RID: 16428
		// (get) Token: 0x06013583 RID: 79235 RVA: 0x002D0E1A File Offset: 0x002CF01A
		// (set) Token: 0x06013584 RID: 79236 RVA: 0x002D0E22 File Offset: 0x002CF022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x1700402D RID: 16429
		// (get) Token: 0x06013585 RID: 79237 RVA: 0x002D0E2B File Offset: 0x002CF02B
		// (set) Token: 0x06013586 RID: 79238 RVA: 0x002D0E33 File Offset: 0x002CF033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MultiModeLock
		{
			get
			{
				return this.multiModeLock_;
			}
			set
			{
				this.multiModeLock_ = value;
			}
		}

		// Token: 0x1700402E RID: 16430
		// (get) Token: 0x06013587 RID: 79239 RVA: 0x002D0E3C File Offset: 0x002CF03C
		// (set) Token: 0x06013588 RID: 79240 RVA: 0x002D0E44 File Offset: 0x002CF044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockType LockType
		{
			get
			{
				return this.lockType_;
			}
			set
			{
				this.lockType_ = value;
			}
		}

		// Token: 0x06013589 RID: 79241 RVA: 0x002D0E4D File Offset: 0x002CF04D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestLockInfo);
		}

		// Token: 0x0601358A RID: 79242 RVA: 0x002D0E5C File Offset: 0x002CF05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestLockInfo other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.MultiModeLock == other.MultiModeLock && this.LockType == other.LockType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601358B RID: 79243 RVA: 0x002D0EB8 File Offset: 0x002CF0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.MultiModeLock)
			{
				num ^= this.MultiModeLock.GetHashCode();
			}
			if (this.LockType != QuestLockType.QuestResource)
			{
				num ^= this.LockType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601358C RID: 79244 RVA: 0x002D0F2F File Offset: 0x002CF12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601358D RID: 79245 RVA: 0x002D0F3C File Offset: 0x002CF13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601358E RID: 79246 RVA: 0x002D0F48 File Offset: 0x002CF148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			if (this.MultiModeLock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.MultiModeLock);
			}
			if (this.LockType != QuestLockType.QuestResource)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.LockType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601358F RID: 79247 RVA: 0x002D0FBC File Offset: 0x002CF1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.MultiModeLock)
			{
				num += 2;
			}
			if (this.LockType != QuestLockType.QuestResource)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LockType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013590 RID: 79248 RVA: 0x002D1020 File Offset: 0x002CF220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestLockInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.MultiModeLock)
			{
				this.MultiModeLock = other.MultiModeLock;
			}
			if (other.LockType != QuestLockType.QuestResource)
			{
				this.LockType = other.LockType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013591 RID: 79249 RVA: 0x002D1084 File Offset: 0x002CF284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013592 RID: 79250 RVA: 0x002D1090 File Offset: 0x002CF290
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LockType = (QuestLockType)input.ReadEnum();
						}
					}
					else
					{
						this.MultiModeLock = input.ReadBool();
					}
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400772C RID: 30508
		private static readonly MessageParser<QuestLockInfo> _parser = new MessageParser<QuestLockInfo>(() => new QuestLockInfo());

		// Token: 0x0400772D RID: 30509
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400772E RID: 30510
		public const int QuestIdFieldNumber = 1;

		// Token: 0x0400772F RID: 30511
		private int questId_;

		// Token: 0x04007730 RID: 30512
		public const int MultiModeLockFieldNumber = 2;

		// Token: 0x04007731 RID: 30513
		private bool multiModeLock_;

		// Token: 0x04007732 RID: 30514
		public const int LockTypeFieldNumber = 3;

		// Token: 0x04007733 RID: 30515
		private QuestLockType lockType_;
	}
}
