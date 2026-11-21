using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EAA RID: 3754
	public sealed class RecallQuestFinishActionCtxPb : IMessage<RecallQuestFinishActionCtxPb>, IMessage, IEquatable<RecallQuestFinishActionCtxPb>, IDeepCloneable<RecallQuestFinishActionCtxPb>, IBufferMessage
	{
		// Token: 0x060142AE RID: 82606 RVA: 0x002EF8C4 File Offset: 0x002EDAC4
		[NullableContext(1)]
		public static RecallQuestFinishActionCtxPb Create()
		{
			return new RecallQuestFinishActionCtxPb();
		}

		// Token: 0x17004316 RID: 17174
		// (get) Token: 0x060142AF RID: 82607 RVA: 0x002EF8CB File Offset: 0x002EDACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004317 RID: 17175
		// (get) Token: 0x060142B0 RID: 82608 RVA: 0x002EF8CE File Offset: 0x002EDACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060142B1 RID: 82609 RVA: 0x002EF8D5 File Offset: 0x002EDAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionCtxPb()
		{
		}

		// Token: 0x060142B2 RID: 82610 RVA: 0x002EF8DD File Offset: 0x002EDADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionCtxPb(RecallQuestFinishActionCtxPb other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060142B3 RID: 82611 RVA: 0x002EF902 File Offset: 0x002EDB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionCtxPb Clone()
		{
			return new RecallQuestFinishActionCtxPb(this);
		}

		// Token: 0x17004318 RID: 17176
		// (get) Token: 0x060142B4 RID: 82612 RVA: 0x002EF90A File Offset: 0x002EDB0A
		// (set) Token: 0x060142B5 RID: 82613 RVA: 0x002EF912 File Offset: 0x002EDB12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x060142B6 RID: 82614 RVA: 0x002EF91B File Offset: 0x002EDB1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishActionCtxPb);
		}

		// Token: 0x060142B7 RID: 82615 RVA: 0x002EF929 File Offset: 0x002EDB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishActionCtxPb other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060142B8 RID: 82616 RVA: 0x002EF958 File Offset: 0x002EDB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060142B9 RID: 82617 RVA: 0x002EF997 File Offset: 0x002EDB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060142BA RID: 82618 RVA: 0x002EF9A4 File Offset: 0x002EDBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060142BB RID: 82619 RVA: 0x002EF9AD File Offset: 0x002EDBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060142BC RID: 82620 RVA: 0x002EF9E0 File Offset: 0x002EDBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060142BD RID: 82621 RVA: 0x002EFA1E File Offset: 0x002EDC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestFinishActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060142BE RID: 82622 RVA: 0x002EFA4F File Offset: 0x002EDC4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060142BF RID: 82623 RVA: 0x002EFA58 File Offset: 0x002EDC58
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
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B34 RID: 31540
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B35 RID: 31541
		public const int RecallQuestIdFieldNumber = 1;

		// Token: 0x04007B36 RID: 31542
		private int recallQuestId_;
	}
}
