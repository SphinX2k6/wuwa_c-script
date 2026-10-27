using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001000 RID: 4096
	[NetMessage(EMessageId.RogueResPlayerStatusUpdateNotify)]
	public sealed class RogueResPlayerStatusUpdateNotify : IMessage<RogueResPlayerStatusUpdateNotify>, IMessage, IEquatable<RogueResPlayerStatusUpdateNotify>, IDeepCloneable<RogueResPlayerStatusUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015E65 RID: 89701 RVA: 0x0032EDE2 File Offset: 0x0032CFE2
		[NullableContext(1)]
		public static RogueResPlayerStatusUpdateNotify Create()
		{
			return new RogueResPlayerStatusUpdateNotify();
		}

		// Token: 0x17004928 RID: 18728
		// (get) Token: 0x06015E66 RID: 89702 RVA: 0x0032EDE9 File Offset: 0x0032CFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004929 RID: 18729
		// (get) Token: 0x06015E67 RID: 89703 RVA: 0x0032EDEC File Offset: 0x0032CFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResPlayerStatusUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015E68 RID: 89704 RVA: 0x0032EDF3 File Offset: 0x0032CFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPlayerStatusUpdateNotify()
		{
		}

		// Token: 0x06015E69 RID: 89705 RVA: 0x0032EDFB File Offset: 0x0032CFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPlayerStatusUpdateNotify(RogueResPlayerStatusUpdateNotify other) : this()
		{
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E6A RID: 89706 RVA: 0x0032EE20 File Offset: 0x0032D020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPlayerStatusUpdateNotify Clone()
		{
			return new RogueResPlayerStatusUpdateNotify(this);
		}

		// Token: 0x1700492A RID: 18730
		// (get) Token: 0x06015E6B RID: 89707 RVA: 0x0032EE28 File Offset: 0x0032D028
		// (set) Token: 0x06015E6C RID: 89708 RVA: 0x0032EE30 File Offset: 0x0032D030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InBattle
		{
			get
			{
				return this.inBattle_;
			}
			set
			{
				this.inBattle_ = value;
			}
		}

		// Token: 0x06015E6D RID: 89709 RVA: 0x0032EE39 File Offset: 0x0032D039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResPlayerStatusUpdateNotify);
		}

		// Token: 0x06015E6E RID: 89710 RVA: 0x0032EE47 File Offset: 0x0032D047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResPlayerStatusUpdateNotify other)
		{
			return other != null && (other == this || (this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E6F RID: 89711 RVA: 0x0032EE78 File Offset: 0x0032D078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InBattle)
			{
				num ^= this.InBattle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015E70 RID: 89712 RVA: 0x0032EEB7 File Offset: 0x0032D0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E71 RID: 89713 RVA: 0x0032EEC4 File Offset: 0x0032D0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E72 RID: 89714 RVA: 0x0032EECD File Offset: 0x0032D0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InBattle)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.InBattle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015E73 RID: 89715 RVA: 0x0032EF00 File Offset: 0x0032D100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InBattle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015E74 RID: 89716 RVA: 0x0032EF32 File Offset: 0x0032D132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResPlayerStatusUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InBattle)
			{
				this.InBattle = other.InBattle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015E75 RID: 89717 RVA: 0x0032EF63 File Offset: 0x0032D163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E76 RID: 89718 RVA: 0x0032EF6C File Offset: 0x0032D16C
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
					this.InBattle = input.ReadBool();
				}
			}
		}

		// Token: 0x04008362 RID: 33634
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008363 RID: 33635
		public const int InBattleFieldNumber = 1;

		// Token: 0x04008364 RID: 33636
		private bool inBattle_;
	}
}
