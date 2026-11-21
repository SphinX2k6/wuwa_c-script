using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F7 RID: 5367
	[NetMessage(EMessageId.UnlockCardNotify)]
	public sealed class UnlockCardNotify : IMessage<UnlockCardNotify>, IMessage, IEquatable<UnlockCardNotify>, IDeepCloneable<UnlockCardNotify>, IBufferMessage
	{
		// Token: 0x0601C73E RID: 116542 RVA: 0x0042066E File Offset: 0x0041E86E
		[NullableContext(1)]
		public static UnlockCardNotify Create()
		{
			return new UnlockCardNotify();
		}

		// Token: 0x17006049 RID: 24649
		// (get) Token: 0x0601C73F RID: 116543 RVA: 0x00420675 File Offset: 0x0041E875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700604A RID: 24650
		// (get) Token: 0x0601C740 RID: 116544 RVA: 0x00420678 File Offset: 0x0041E878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockCardNotify.Descriptor;
			}
		}

		// Token: 0x0601C741 RID: 116545 RVA: 0x0042067F File Offset: 0x0041E87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockCardNotify()
		{
		}

		// Token: 0x0601C742 RID: 116546 RVA: 0x00420687 File Offset: 0x0041E887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockCardNotify(UnlockCardNotify other) : this()
		{
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C743 RID: 116547 RVA: 0x004206AC File Offset: 0x0041E8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockCardNotify Clone()
		{
			return new UnlockCardNotify(this);
		}

		// Token: 0x1700604B RID: 24651
		// (get) Token: 0x0601C744 RID: 116548 RVA: 0x004206B4 File Offset: 0x0041E8B4
		// (set) Token: 0x0601C745 RID: 116549 RVA: 0x004206BC File Offset: 0x0041E8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardId
		{
			get
			{
				return this.cardId_;
			}
			set
			{
				this.cardId_ = value;
			}
		}

		// Token: 0x0601C746 RID: 116550 RVA: 0x004206C5 File Offset: 0x0041E8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockCardNotify);
		}

		// Token: 0x0601C747 RID: 116551 RVA: 0x004206D3 File Offset: 0x0041E8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockCardNotify other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C748 RID: 116552 RVA: 0x00420704 File Offset: 0x0041E904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C749 RID: 116553 RVA: 0x00420743 File Offset: 0x0041E943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C74A RID: 116554 RVA: 0x00420750 File Offset: 0x0041E950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C74B RID: 116555 RVA: 0x00420759 File Offset: 0x0041E959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C74C RID: 116556 RVA: 0x0042078C File Offset: 0x0041E98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C74D RID: 116557 RVA: 0x004207CA File Offset: 0x0041E9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockCardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C74E RID: 116558 RVA: 0x004207FB File Offset: 0x0041E9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C74F RID: 116559 RVA: 0x00420804 File Offset: 0x0041EA04
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A439 RID: 42041
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A43A RID: 42042
		public const int CardIdFieldNumber = 6;

		// Token: 0x0400A43B RID: 42043
		private int cardId_;
	}
}
