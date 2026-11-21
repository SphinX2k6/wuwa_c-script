using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF0 RID: 4080
	[NetMessage(EMessageId.RogueResPlayerStatusUpdateNotify)]
	public sealed class RogueResPlayerStatusUpdateNotify : IMessage<RogueResPlayerStatusUpdateNotify>, IMessage, IEquatable<RogueResPlayerStatusUpdateNotify>, IDeepCloneable<RogueResPlayerStatusUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015D80 RID: 89472 RVA: 0x0032D722 File Offset: 0x0032B922
		[NullableContext(1)]
		public static RogueResPlayerStatusUpdateNotify Create()
		{
			return new RogueResPlayerStatusUpdateNotify();
		}

		// Token: 0x170048FE RID: 18686
		// (get) Token: 0x06015D81 RID: 89473 RVA: 0x0032D729 File Offset: 0x0032B929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048FF RID: 18687
		// (get) Token: 0x06015D82 RID: 89474 RVA: 0x0032D72C File Offset: 0x0032B92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResPlayerStatusUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015D83 RID: 89475 RVA: 0x0032D733 File Offset: 0x0032B933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPlayerStatusUpdateNotify()
		{
		}

		// Token: 0x06015D84 RID: 89476 RVA: 0x0032D73B File Offset: 0x0032B93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPlayerStatusUpdateNotify(RogueResPlayerStatusUpdateNotify other) : this()
		{
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D85 RID: 89477 RVA: 0x0032D760 File Offset: 0x0032B960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPlayerStatusUpdateNotify Clone()
		{
			return new RogueResPlayerStatusUpdateNotify(this);
		}

		// Token: 0x17004900 RID: 18688
		// (get) Token: 0x06015D86 RID: 89478 RVA: 0x0032D768 File Offset: 0x0032B968
		// (set) Token: 0x06015D87 RID: 89479 RVA: 0x0032D770 File Offset: 0x0032B970
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

		// Token: 0x06015D88 RID: 89480 RVA: 0x0032D779 File Offset: 0x0032B979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResPlayerStatusUpdateNotify);
		}

		// Token: 0x06015D89 RID: 89481 RVA: 0x0032D787 File Offset: 0x0032B987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResPlayerStatusUpdateNotify other)
		{
			return other != null && (other == this || (this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D8A RID: 89482 RVA: 0x0032D7B8 File Offset: 0x0032B9B8
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

		// Token: 0x06015D8B RID: 89483 RVA: 0x0032D7F7 File Offset: 0x0032B9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D8C RID: 89484 RVA: 0x0032D804 File Offset: 0x0032BA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D8D RID: 89485 RVA: 0x0032D80D File Offset: 0x0032BA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InBattle)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.InBattle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D8E RID: 89486 RVA: 0x0032D840 File Offset: 0x0032BA40
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

		// Token: 0x06015D8F RID: 89487 RVA: 0x0032D872 File Offset: 0x0032BA72
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

		// Token: 0x06015D90 RID: 89488 RVA: 0x0032D8A3 File Offset: 0x0032BAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D91 RID: 89489 RVA: 0x0032D8AC File Offset: 0x0032BAAC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InBattle = input.ReadBool();
				}
			}
		}

		// Token: 0x0400838C RID: 33676
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400838D RID: 33677
		public const int InBattleFieldNumber = 12;

		// Token: 0x0400838E RID: 33678
		private bool inBattle_;
	}
}
