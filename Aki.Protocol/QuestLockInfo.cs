using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1B RID: 3611
	public sealed class QuestLockInfo : IMessage<QuestLockInfo>, IMessage, IEquatable<QuestLockInfo>, IDeepCloneable<QuestLockInfo>, IBufferMessage
	{
		// Token: 0x06013661 RID: 79457 RVA: 0x002D2479 File Offset: 0x002D0679
		[NullableContext(1)]
		public static QuestLockInfo Create()
		{
			return new QuestLockInfo();
		}

		// Token: 0x17004053 RID: 16467
		// (get) Token: 0x06013662 RID: 79458 RVA: 0x002D2480 File Offset: 0x002D0680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestLockInfo> Parser
		{
			get
			{
				return QuestLockInfo._parser;
			}
		}

		// Token: 0x17004054 RID: 16468
		// (get) Token: 0x06013663 RID: 79459 RVA: 0x002D2487 File Offset: 0x002D0687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004055 RID: 16469
		// (get) Token: 0x06013664 RID: 79460 RVA: 0x002D248A File Offset: 0x002D068A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestLockInfo.Descriptor;
			}
		}

		// Token: 0x06013665 RID: 79461 RVA: 0x002D2491 File Offset: 0x002D0691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfo()
		{
		}

		// Token: 0x06013666 RID: 79462 RVA: 0x002D2499 File Offset: 0x002D0699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfo(QuestLockInfo other) : this()
		{
			this.questId_ = other.questId_;
			this.multiModeLock_ = other.multiModeLock_;
			this.lockType_ = other.lockType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013667 RID: 79463 RVA: 0x002D24D6 File Offset: 0x002D06D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfo Clone()
		{
			return new QuestLockInfo(this);
		}

		// Token: 0x17004056 RID: 16470
		// (get) Token: 0x06013668 RID: 79464 RVA: 0x002D24DE File Offset: 0x002D06DE
		// (set) Token: 0x06013669 RID: 79465 RVA: 0x002D24E6 File Offset: 0x002D06E6
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

		// Token: 0x17004057 RID: 16471
		// (get) Token: 0x0601366A RID: 79466 RVA: 0x002D24EF File Offset: 0x002D06EF
		// (set) Token: 0x0601366B RID: 79467 RVA: 0x002D24F7 File Offset: 0x002D06F7
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

		// Token: 0x17004058 RID: 16472
		// (get) Token: 0x0601366C RID: 79468 RVA: 0x002D2500 File Offset: 0x002D0700
		// (set) Token: 0x0601366D RID: 79469 RVA: 0x002D2508 File Offset: 0x002D0708
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

		// Token: 0x0601366E RID: 79470 RVA: 0x002D2511 File Offset: 0x002D0711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestLockInfo);
		}

		// Token: 0x0601366F RID: 79471 RVA: 0x002D2520 File Offset: 0x002D0720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestLockInfo other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.MultiModeLock == other.MultiModeLock && this.LockType == other.LockType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013670 RID: 79472 RVA: 0x002D257C File Offset: 0x002D077C
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

		// Token: 0x06013671 RID: 79473 RVA: 0x002D25F3 File Offset: 0x002D07F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013672 RID: 79474 RVA: 0x002D2600 File Offset: 0x002D0800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013673 RID: 79475 RVA: 0x002D260C File Offset: 0x002D080C
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

		// Token: 0x06013674 RID: 79476 RVA: 0x002D2680 File Offset: 0x002D0880
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

		// Token: 0x06013675 RID: 79477 RVA: 0x002D26E4 File Offset: 0x002D08E4
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

		// Token: 0x06013676 RID: 79478 RVA: 0x002D2748 File Offset: 0x002D0948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013677 RID: 79479 RVA: 0x002D2754 File Offset: 0x002D0954
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

		// Token: 0x04007702 RID: 30466
		private static readonly MessageParser<QuestLockInfo> _parser = new MessageParser<QuestLockInfo>(() => new QuestLockInfo());

		// Token: 0x04007703 RID: 30467
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007704 RID: 30468
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04007705 RID: 30469
		private int questId_;

		// Token: 0x04007706 RID: 30470
		public const int MultiModeLockFieldNumber = 2;

		// Token: 0x04007707 RID: 30471
		private bool multiModeLock_;

		// Token: 0x04007708 RID: 30472
		public const int LockTypeFieldNumber = 3;

		// Token: 0x04007709 RID: 30473
		private QuestLockType lockType_;
	}
}
