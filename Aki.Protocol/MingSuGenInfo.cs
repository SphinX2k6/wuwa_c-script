using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D3 RID: 2515
	public sealed class MingSuGenInfo : IMessage<MingSuGenInfo>, IMessage, IEquatable<MingSuGenInfo>, IDeepCloneable<MingSuGenInfo>, IBufferMessage
	{
		// Token: 0x0600DC8F RID: 56463 RVA: 0x002061F1 File Offset: 0x002043F1
		[NullableContext(1)]
		public static MingSuGenInfo Create()
		{
			return new MingSuGenInfo();
		}

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x0600DC90 RID: 56464 RVA: 0x002061F8 File Offset: 0x002043F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MingSuGenInfo> Parser
		{
			get
			{
				return MingSuGenInfo._parser;
			}
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x0600DC91 RID: 56465 RVA: 0x002061FF File Offset: 0x002043FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x0600DC92 RID: 56466 RVA: 0x00206202 File Offset: 0x00204402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MingSuGenInfo.Descriptor;
			}
		}

		// Token: 0x0600DC93 RID: 56467 RVA: 0x00206209 File Offset: 0x00204409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuGenInfo()
		{
		}

		// Token: 0x0600DC94 RID: 56468 RVA: 0x00206211 File Offset: 0x00204411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuGenInfo(MingSuGenInfo other) : this()
		{
			this.creatureGenID_ = other.creatureGenID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC95 RID: 56469 RVA: 0x00206236 File Offset: 0x00204436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuGenInfo Clone()
		{
			return new MingSuGenInfo(this);
		}

		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x0600DC96 RID: 56470 RVA: 0x0020623E File Offset: 0x0020443E
		// (set) Token: 0x0600DC97 RID: 56471 RVA: 0x00206246 File Offset: 0x00204446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreatureGenID
		{
			get
			{
				return this.creatureGenID_;
			}
			set
			{
				this.creatureGenID_ = value;
			}
		}

		// Token: 0x0600DC98 RID: 56472 RVA: 0x0020624F File Offset: 0x0020444F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MingSuGenInfo);
		}

		// Token: 0x0600DC99 RID: 56473 RVA: 0x0020625D File Offset: 0x0020445D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MingSuGenInfo other)
		{
			return other != null && (other == this || (this.CreatureGenID == other.CreatureGenID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC9A RID: 56474 RVA: 0x0020628C File Offset: 0x0020448C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CreatureGenID != 0L)
			{
				num ^= this.CreatureGenID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DC9B RID: 56475 RVA: 0x002062CB File Offset: 0x002044CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC9C RID: 56476 RVA: 0x002062D8 File Offset: 0x002044D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC9D RID: 56477 RVA: 0x002062E1 File Offset: 0x002044E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CreatureGenID != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.CreatureGenID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC9E RID: 56478 RVA: 0x00206314 File Offset: 0x00204514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CreatureGenID != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CreatureGenID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DC9F RID: 56479 RVA: 0x00206352 File Offset: 0x00204552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MingSuGenInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CreatureGenID != 0L)
			{
				this.CreatureGenID = other.CreatureGenID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCA0 RID: 56480 RVA: 0x00206383 File Offset: 0x00204583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCA1 RID: 56481 RVA: 0x0020638C File Offset: 0x0020458C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CreatureGenID = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005B5C RID: 23388
		private static readonly MessageParser<MingSuGenInfo> _parser = new MessageParser<MingSuGenInfo>(() => new MingSuGenInfo());

		// Token: 0x04005B5D RID: 23389
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B5E RID: 23390
		public const int CreatureGenIDFieldNumber = 1;

		// Token: 0x04005B5F RID: 23391
		private long creatureGenID_;
	}
}
