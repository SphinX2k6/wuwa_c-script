using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C43 RID: 3139
	[NetMessage(EMessageId.PhantomBattleCardOutLookUpRequest)]
	public sealed class PhantomBattleCardOutLookUpRequest : IMessage<PhantomBattleCardOutLookUpRequest>, IMessage, IEquatable<PhantomBattleCardOutLookUpRequest>, IDeepCloneable<PhantomBattleCardOutLookUpRequest>, IBufferMessage
	{
		// Token: 0x060110BE RID: 69822 RVA: 0x0027F9F1 File Offset: 0x0027DBF1
		[NullableContext(1)]
		public static PhantomBattleCardOutLookUpRequest Create()
		{
			return new PhantomBattleCardOutLookUpRequest();
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x060110BF RID: 69823 RVA: 0x0027F9F8 File Offset: 0x0027DBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x060110C0 RID: 69824 RVA: 0x0027F9FB File Offset: 0x0027DBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardOutLookUpRequest.Descriptor;
			}
		}

		// Token: 0x060110C1 RID: 69825 RVA: 0x0027FA02 File Offset: 0x0027DC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpRequest()
		{
		}

		// Token: 0x060110C2 RID: 69826 RVA: 0x0027FA0A File Offset: 0x0027DC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpRequest(PhantomBattleCardOutLookUpRequest other) : this()
		{
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060110C3 RID: 69827 RVA: 0x0027FA2F File Offset: 0x0027DC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardOutLookUpRequest Clone()
		{
			return new PhantomBattleCardOutLookUpRequest(this);
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x060110C4 RID: 69828 RVA: 0x0027FA37 File Offset: 0x0027DC37
		// (set) Token: 0x060110C5 RID: 69829 RVA: 0x0027FA3F File Offset: 0x0027DC3F
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

		// Token: 0x060110C6 RID: 69830 RVA: 0x0027FA48 File Offset: 0x0027DC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardOutLookUpRequest);
		}

		// Token: 0x060110C7 RID: 69831 RVA: 0x0027FA56 File Offset: 0x0027DC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardOutLookUpRequest other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060110C8 RID: 69832 RVA: 0x0027FA84 File Offset: 0x0027DC84
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

		// Token: 0x060110C9 RID: 69833 RVA: 0x0027FAC3 File Offset: 0x0027DCC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060110CA RID: 69834 RVA: 0x0027FAD0 File Offset: 0x0027DCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060110CB RID: 69835 RVA: 0x0027FAD9 File Offset: 0x0027DCD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060110CC RID: 69836 RVA: 0x0027FB0C File Offset: 0x0027DD0C
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

		// Token: 0x060110CD RID: 69837 RVA: 0x0027FB4A File Offset: 0x0027DD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardOutLookUpRequest other)
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

		// Token: 0x060110CE RID: 69838 RVA: 0x0027FB7B File Offset: 0x0027DD7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060110CF RID: 69839 RVA: 0x0027FB84 File Offset: 0x0027DD84
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C73 RID: 27763
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C74 RID: 27764
		public const int CardIdFieldNumber = 8;

		// Token: 0x04006C75 RID: 27765
		private int cardId_;
	}
}
