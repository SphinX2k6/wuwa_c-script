using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081F RID: 2079
	public sealed class InstDetailEntry : IMessage<InstDetailEntry>, IMessage, IEquatable<InstDetailEntry>, IDeepCloneable<InstDetailEntry>, IBufferMessage
	{
		// Token: 0x0600B9BE RID: 47550 RVA: 0x001BA079 File Offset: 0x001B8279
		[NullableContext(1)]
		public static InstDetailEntry Create()
		{
			return new InstDetailEntry();
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x0600B9BF RID: 47551 RVA: 0x001BA080 File Offset: 0x001B8280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InstDetailEntry> Parser
		{
			get
			{
				return InstDetailEntry._parser;
			}
		}

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x0600B9C0 RID: 47552 RVA: 0x001BA087 File Offset: 0x001B8287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x0600B9C1 RID: 47553 RVA: 0x001BA08A File Offset: 0x001B828A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstDetailEntry.Descriptor;
			}
		}

		// Token: 0x0600B9C2 RID: 47554 RVA: 0x001BA091 File Offset: 0x001B8291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDetailEntry()
		{
		}

		// Token: 0x0600B9C3 RID: 47555 RVA: 0x001BA09C File Offset: 0x001B829C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDetailEntry(InstDetailEntry other) : this()
		{
			this.instId_ = other.instId_;
			this.resetTime_ = other.resetTime_;
			this.count_ = other.count_;
			this.archiveType_ = other.archiveType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B9C4 RID: 47556 RVA: 0x001BA0F0 File Offset: 0x001B82F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstDetailEntry Clone()
		{
			return new InstDetailEntry(this);
		}

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x0600B9C5 RID: 47557 RVA: 0x001BA0F8 File Offset: 0x001B82F8
		// (set) Token: 0x0600B9C6 RID: 47558 RVA: 0x001BA100 File Offset: 0x001B8300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x0600B9C7 RID: 47559 RVA: 0x001BA109 File Offset: 0x001B8309
		// (set) Token: 0x0600B9C8 RID: 47560 RVA: 0x001BA111 File Offset: 0x001B8311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ResetTime
		{
			get
			{
				return this.resetTime_;
			}
			set
			{
				this.resetTime_ = value;
			}
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x0600B9C9 RID: 47561 RVA: 0x001BA11A File Offset: 0x001B831A
		// (set) Token: 0x0600B9CA RID: 47562 RVA: 0x001BA122 File Offset: 0x001B8322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x0600B9CB RID: 47563 RVA: 0x001BA12B File Offset: 0x001B832B
		// (set) Token: 0x0600B9CC RID: 47564 RVA: 0x001BA133 File Offset: 0x001B8333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveType ArchiveType
		{
			get
			{
				return this.archiveType_;
			}
			set
			{
				this.archiveType_ = value;
			}
		}

		// Token: 0x0600B9CD RID: 47565 RVA: 0x001BA13C File Offset: 0x001B833C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstDetailEntry);
		}

		// Token: 0x0600B9CE RID: 47566 RVA: 0x001BA14C File Offset: 0x001B834C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstDetailEntry other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.ResetTime == other.ResetTime && this.Count == other.Count && this.ArchiveType == other.ArchiveType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9CF RID: 47567 RVA: 0x001BA1B8 File Offset: 0x001B83B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.ResetTime != 0L)
			{
				num ^= this.ResetTime.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.ArchiveType != ArchiveType.NoneArchive)
			{
				num ^= this.ArchiveType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B9D0 RID: 47568 RVA: 0x001BA248 File Offset: 0x001B8448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B9D1 RID: 47569 RVA: 0x001BA255 File Offset: 0x001B8455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9D2 RID: 47570 RVA: 0x001BA260 File Offset: 0x001B8460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.ResetTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ResetTime);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Count);
			}
			if (this.ArchiveType != ArchiveType.NoneArchive)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ArchiveType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B9D3 RID: 47571 RVA: 0x001BA2F0 File Offset: 0x001B84F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.ResetTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ResetTime);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.ArchiveType != ArchiveType.NoneArchive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ArchiveType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B9D4 RID: 47572 RVA: 0x001BA378 File Offset: 0x001B8578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstDetailEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.ResetTime != 0L)
			{
				this.ResetTime = other.ResetTime;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.ArchiveType != ArchiveType.NoneArchive)
			{
				this.ArchiveType = other.ArchiveType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B9D5 RID: 47573 RVA: 0x001BA3F0 File Offset: 0x001B85F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B9D6 RID: 47574 RVA: 0x001BA3FC File Offset: 0x001B85FC
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
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ResetTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ArchiveType = (ArchiveType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005194 RID: 20884
		private static readonly MessageParser<InstDetailEntry> _parser = new MessageParser<InstDetailEntry>(() => new InstDetailEntry());

		// Token: 0x04005195 RID: 20885
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005196 RID: 20886
		public const int InstIdFieldNumber = 1;

		// Token: 0x04005197 RID: 20887
		private int instId_;

		// Token: 0x04005198 RID: 20888
		public const int ResetTimeFieldNumber = 2;

		// Token: 0x04005199 RID: 20889
		private long resetTime_;

		// Token: 0x0400519A RID: 20890
		public const int CountFieldNumber = 3;

		// Token: 0x0400519B RID: 20891
		private int count_;

		// Token: 0x0400519C RID: 20892
		public const int ArchiveTypeFieldNumber = 4;

		// Token: 0x0400519D RID: 20893
		private ArchiveType archiveType_;
	}
}
