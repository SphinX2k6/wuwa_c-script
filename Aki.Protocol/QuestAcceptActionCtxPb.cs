using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF2 RID: 3570
	public sealed class QuestAcceptActionCtxPb : IMessage<QuestAcceptActionCtxPb>, IMessage, IEquatable<QuestAcceptActionCtxPb>, IDeepCloneable<QuestAcceptActionCtxPb>, IBufferMessage
	{
		// Token: 0x06013396 RID: 78742 RVA: 0x002CD148 File Offset: 0x002CB348
		[NullableContext(1)]
		public static QuestAcceptActionCtxPb Create()
		{
			return new QuestAcceptActionCtxPb();
		}

		// Token: 0x17003FCB RID: 16331
		// (get) Token: 0x06013397 RID: 78743 RVA: 0x002CD14F File Offset: 0x002CB34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FCC RID: 16332
		// (get) Token: 0x06013398 RID: 78744 RVA: 0x002CD152 File Offset: 0x002CB352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestAcceptActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06013399 RID: 78745 RVA: 0x002CD159 File Offset: 0x002CB359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestAcceptActionCtxPb()
		{
		}

		// Token: 0x0601339A RID: 78746 RVA: 0x002CD161 File Offset: 0x002CB361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestAcceptActionCtxPb(QuestAcceptActionCtxPb other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601339B RID: 78747 RVA: 0x002CD186 File Offset: 0x002CB386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestAcceptActionCtxPb Clone()
		{
			return new QuestAcceptActionCtxPb(this);
		}

		// Token: 0x17003FCD RID: 16333
		// (get) Token: 0x0601339C RID: 78748 RVA: 0x002CD18E File Offset: 0x002CB38E
		// (set) Token: 0x0601339D RID: 78749 RVA: 0x002CD196 File Offset: 0x002CB396
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

		// Token: 0x0601339E RID: 78750 RVA: 0x002CD19F File Offset: 0x002CB39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestAcceptActionCtxPb);
		}

		// Token: 0x0601339F RID: 78751 RVA: 0x002CD1AD File Offset: 0x002CB3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestAcceptActionCtxPb other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060133A0 RID: 78752 RVA: 0x002CD1DC File Offset: 0x002CB3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060133A1 RID: 78753 RVA: 0x002CD21B File Offset: 0x002CB41B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060133A2 RID: 78754 RVA: 0x002CD228 File Offset: 0x002CB428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060133A3 RID: 78755 RVA: 0x002CD231 File Offset: 0x002CB431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060133A4 RID: 78756 RVA: 0x002CD264 File Offset: 0x002CB464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060133A5 RID: 78757 RVA: 0x002CD2A2 File Offset: 0x002CB4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestAcceptActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060133A6 RID: 78758 RVA: 0x002CD2D3 File Offset: 0x002CB4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060133A7 RID: 78759 RVA: 0x002CD2DC File Offset: 0x002CB4DC
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
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040076B5 RID: 30389
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076B6 RID: 30390
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040076B7 RID: 30391
		private int questId_;
	}
}
