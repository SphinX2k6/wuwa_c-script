using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA4 RID: 3748
	public sealed class RecallQuestAcceptActionCtxPb : IMessage<RecallQuestAcceptActionCtxPb>, IMessage, IEquatable<RecallQuestAcceptActionCtxPb>, IDeepCloneable<RecallQuestAcceptActionCtxPb>, IBufferMessage
	{
		// Token: 0x0601423C RID: 82492 RVA: 0x002EEB7C File Offset: 0x002ECD7C
		[NullableContext(1)]
		public static RecallQuestAcceptActionCtxPb Create()
		{
			return new RecallQuestAcceptActionCtxPb();
		}

		// Token: 0x17004301 RID: 17153
		// (get) Token: 0x0601423D RID: 82493 RVA: 0x002EEB83 File Offset: 0x002ECD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004302 RID: 17154
		// (get) Token: 0x0601423E RID: 82494 RVA: 0x002EEB86 File Offset: 0x002ECD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestAcceptActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0601423F RID: 82495 RVA: 0x002EEB8D File Offset: 0x002ECD8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestAcceptActionCtxPb()
		{
		}

		// Token: 0x06014240 RID: 82496 RVA: 0x002EEB95 File Offset: 0x002ECD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestAcceptActionCtxPb(RecallQuestAcceptActionCtxPb other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014241 RID: 82497 RVA: 0x002EEBBA File Offset: 0x002ECDBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestAcceptActionCtxPb Clone()
		{
			return new RecallQuestAcceptActionCtxPb(this);
		}

		// Token: 0x17004303 RID: 17155
		// (get) Token: 0x06014242 RID: 82498 RVA: 0x002EEBC2 File Offset: 0x002ECDC2
		// (set) Token: 0x06014243 RID: 82499 RVA: 0x002EEBCA File Offset: 0x002ECDCA
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

		// Token: 0x06014244 RID: 82500 RVA: 0x002EEBD3 File Offset: 0x002ECDD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestAcceptActionCtxPb);
		}

		// Token: 0x06014245 RID: 82501 RVA: 0x002EEBE1 File Offset: 0x002ECDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestAcceptActionCtxPb other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014246 RID: 82502 RVA: 0x002EEC10 File Offset: 0x002ECE10
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

		// Token: 0x06014247 RID: 82503 RVA: 0x002EEC4F File Offset: 0x002ECE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014248 RID: 82504 RVA: 0x002EEC5C File Offset: 0x002ECE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014249 RID: 82505 RVA: 0x002EEC65 File Offset: 0x002ECE65
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

		// Token: 0x0601424A RID: 82506 RVA: 0x002EEC98 File Offset: 0x002ECE98
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

		// Token: 0x0601424B RID: 82507 RVA: 0x002EECD6 File Offset: 0x002ECED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestAcceptActionCtxPb other)
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

		// Token: 0x0601424C RID: 82508 RVA: 0x002EED07 File Offset: 0x002ECF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601424D RID: 82509 RVA: 0x002EED10 File Offset: 0x002ECF10
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

		// Token: 0x04007B1B RID: 31515
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B1C RID: 31516
		public const int RecallQuestIdFieldNumber = 1;

		// Token: 0x04007B1D RID: 31517
		private int recallQuestId_;
	}
}
