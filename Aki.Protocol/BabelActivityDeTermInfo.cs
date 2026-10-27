using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013F RID: 319
	public sealed class BabelActivityDeTermInfo : IMessage<BabelActivityDeTermInfo>, IMessage, IEquatable<BabelActivityDeTermInfo>, IDeepCloneable<BabelActivityDeTermInfo>, IBufferMessage
	{
		// Token: 0x06002961 RID: 10593 RVA: 0x0006C805 File Offset: 0x0006AA05
		[NullableContext(1)]
		public static BabelActivityDeTermInfo Create()
		{
			return new BabelActivityDeTermInfo();
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x0006C80C File Offset: 0x0006AA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BabelActivityDeTermInfo> Parser
		{
			get
			{
				return BabelActivityDeTermInfo._parser;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002963 RID: 10595 RVA: 0x0006C813 File Offset: 0x0006AA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x0006C816 File Offset: 0x0006AA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityDeTermInfo.Descriptor;
			}
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x0006C81D File Offset: 0x0006AA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfo()
		{
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x0006C825 File Offset: 0x0006AA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfo(BabelActivityDeTermInfo other) : this()
		{
			this.deTermId_ = other.deTermId_;
			this.difficultUnlock_ = other.difficultUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x0006C856 File Offset: 0x0006AA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfo Clone()
		{
			return new BabelActivityDeTermInfo(this);
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x0006C85E File Offset: 0x0006AA5E
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x0006C866 File Offset: 0x0006AA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DeTermId
		{
			get
			{
				return this.deTermId_;
			}
			set
			{
				this.deTermId_ = value;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x0006C86F File Offset: 0x0006AA6F
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x0006C877 File Offset: 0x0006AA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DifficultUnlock
		{
			get
			{
				return this.difficultUnlock_;
			}
			set
			{
				this.difficultUnlock_ = value;
			}
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x0006C880 File Offset: 0x0006AA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityDeTermInfo);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x0006C88E File Offset: 0x0006AA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityDeTermInfo other)
		{
			return other != null && (other == this || (this.DeTermId == other.DeTermId && this.DifficultUnlock == other.DifficultUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x0006C8CC File Offset: 0x0006AACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DeTermId != 0)
			{
				num ^= this.DeTermId.GetHashCode();
			}
			if (this.DifficultUnlock)
			{
				num ^= this.DifficultUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x0006C924 File Offset: 0x0006AB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x0006C931 File Offset: 0x0006AB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x0006C93C File Offset: 0x0006AB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DeTermId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DeTermId);
			}
			if (this.DifficultUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.DifficultUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x0006C994 File Offset: 0x0006AB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DeTermId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DeTermId);
			}
			if (this.DifficultUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x0006C9E0 File Offset: 0x0006ABE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityDeTermInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DeTermId != 0)
			{
				this.DeTermId = other.DeTermId;
			}
			if (other.DifficultUnlock)
			{
				this.DifficultUnlock = other.DifficultUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x0006CA30 File Offset: 0x0006AC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x0006CA3C File Offset: 0x0006AC3C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DifficultUnlock = input.ReadBool();
					}
				}
				else
				{
					this.DeTermId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040026EA RID: 9962
		private static readonly MessageParser<BabelActivityDeTermInfo> _parser = new MessageParser<BabelActivityDeTermInfo>(() => new BabelActivityDeTermInfo());

		// Token: 0x040026EB RID: 9963
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026EC RID: 9964
		public const int DeTermIdFieldNumber = 1;

		// Token: 0x040026ED RID: 9965
		private int deTermId_;

		// Token: 0x040026EE RID: 9966
		public const int DifficultUnlockFieldNumber = 2;

		// Token: 0x040026EF RID: 9967
		private bool difficultUnlock_;
	}
}
