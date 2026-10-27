using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000875 RID: 2165
	public sealed class JokerGuessSkillExecAction : IMessage<JokerGuessSkillExecAction>, IMessage, IEquatable<JokerGuessSkillExecAction>, IDeepCloneable<JokerGuessSkillExecAction>, IBufferMessage
	{
		// Token: 0x0600C0CB RID: 49355 RVA: 0x001C9F13 File Offset: 0x001C8113
		[NullableContext(1)]
		public static JokerGuessSkillExecAction Create()
		{
			return new JokerGuessSkillExecAction();
		}

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x0600C0CC RID: 49356 RVA: 0x001C9F1A File Offset: 0x001C811A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026F5 RID: 9973
		// (get) Token: 0x0600C0CD RID: 49357 RVA: 0x001C9F1D File Offset: 0x001C811D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessSkillExecAction.Descriptor;
			}
		}

		// Token: 0x0600C0CE RID: 49358 RVA: 0x001C9F24 File Offset: 0x001C8124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillExecAction()
		{
		}

		// Token: 0x0600C0CF RID: 49359 RVA: 0x001C9F2C File Offset: 0x001C812C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillExecAction(JokerGuessSkillExecAction other) : this()
		{
			this.jokerSkillId_ = other.jokerSkillId_;
			this.owner_ = other.owner_;
			this.result_ = other.result_;
			this.aiHandCards_ = ((other.aiHandCards_ != null) ? other.aiHandCards_.Clone() : null);
			this.playerHandCards_ = ((other.playerHandCards_ != null) ? other.playerHandCards_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0D0 RID: 49360 RVA: 0x001C9FAC File Offset: 0x001C81AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillExecAction Clone()
		{
			return new JokerGuessSkillExecAction(this);
		}

		// Token: 0x170026F6 RID: 9974
		// (get) Token: 0x0600C0D1 RID: 49361 RVA: 0x001C9FB4 File Offset: 0x001C81B4
		// (set) Token: 0x0600C0D2 RID: 49362 RVA: 0x001C9FBC File Offset: 0x001C81BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int JokerSkillId
		{
			get
			{
				return this.jokerSkillId_;
			}
			set
			{
				this.jokerSkillId_ = value;
			}
		}

		// Token: 0x170026F7 RID: 9975
		// (get) Token: 0x0600C0D3 RID: 49363 RVA: 0x001C9FC5 File Offset: 0x001C81C5
		// (set) Token: 0x0600C0D4 RID: 49364 RVA: 0x001C9FCD File Offset: 0x001C81CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessActor Owner
		{
			get
			{
				return this.owner_;
			}
			set
			{
				this.owner_ = value;
			}
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x0600C0D5 RID: 49365 RVA: 0x001C9FD6 File Offset: 0x001C81D6
		// (set) Token: 0x0600C0D6 RID: 49366 RVA: 0x001C9FDE File Offset: 0x001C81DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillOp Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x0600C0D7 RID: 49367 RVA: 0x001C9FE7 File Offset: 0x001C81E7
		// (set) Token: 0x0600C0D8 RID: 49368 RVA: 0x001C9FEF File Offset: 0x001C81EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessCard AiHandCards
		{
			get
			{
				return this.aiHandCards_;
			}
			set
			{
				this.aiHandCards_ = value;
			}
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x0600C0D9 RID: 49369 RVA: 0x001C9FF8 File Offset: 0x001C81F8
		// (set) Token: 0x0600C0DA RID: 49370 RVA: 0x001CA000 File Offset: 0x001C8200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessCard PlayerHandCards
		{
			get
			{
				return this.playerHandCards_;
			}
			set
			{
				this.playerHandCards_ = value;
			}
		}

		// Token: 0x0600C0DB RID: 49371 RVA: 0x001CA009 File Offset: 0x001C8209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessSkillExecAction);
		}

		// Token: 0x0600C0DC RID: 49372 RVA: 0x001CA018 File Offset: 0x001C8218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessSkillExecAction other)
		{
			return other != null && (other == this || (this.JokerSkillId == other.JokerSkillId && this.Owner == other.Owner && this.Result == other.Result && object.Equals(this.AiHandCards, other.AiHandCards) && object.Equals(this.PlayerHandCards, other.PlayerHandCards) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0DD RID: 49373 RVA: 0x001CA09C File Offset: 0x001C829C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JokerSkillId != 0)
			{
				num ^= this.JokerSkillId.GetHashCode();
			}
			if (this.Owner != JokerGuessActor.Who)
			{
				num ^= this.Owner.GetHashCode();
			}
			if (this.Result != JokerGuessSkillOp.Use)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this.aiHandCards_ != null)
			{
				num ^= this.AiHandCards.GetHashCode();
			}
			if (this.playerHandCards_ != null)
			{
				num ^= this.PlayerHandCards.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C0DE RID: 49374 RVA: 0x001CA145 File Offset: 0x001C8345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C0DF RID: 49375 RVA: 0x001CA152 File Offset: 0x001C8352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0E0 RID: 49376 RVA: 0x001CA15C File Offset: 0x001C835C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JokerSkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.JokerSkillId);
			}
			if (this.Owner != JokerGuessActor.Who)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Owner);
			}
			if (this.Result != JokerGuessSkillOp.Use)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Result);
			}
			if (this.aiHandCards_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AiHandCards);
			}
			if (this.playerHandCards_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PlayerHandCards);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C0E1 RID: 49377 RVA: 0x001CA208 File Offset: 0x001C8408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JokerSkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.JokerSkillId);
			}
			if (this.Owner != JokerGuessActor.Who)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Owner);
			}
			if (this.Result != JokerGuessSkillOp.Use)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Result);
			}
			if (this.aiHandCards_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AiHandCards);
			}
			if (this.playerHandCards_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerHandCards);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C0E2 RID: 49378 RVA: 0x001CA2A8 File Offset: 0x001C84A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessSkillExecAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JokerSkillId != 0)
			{
				this.JokerSkillId = other.JokerSkillId;
			}
			if (other.Owner != JokerGuessActor.Who)
			{
				this.Owner = other.Owner;
			}
			if (other.Result != JokerGuessSkillOp.Use)
			{
				this.Result = other.Result;
			}
			if (other.aiHandCards_ != null)
			{
				if (this.aiHandCards_ == null)
				{
					this.AiHandCards = new JokerGuessCard();
				}
				this.AiHandCards.MergeFrom(other.AiHandCards);
			}
			if (other.playerHandCards_ != null)
			{
				if (this.playerHandCards_ == null)
				{
					this.PlayerHandCards = new JokerGuessCard();
				}
				this.PlayerHandCards.MergeFrom(other.PlayerHandCards);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C0E3 RID: 49379 RVA: 0x001CA364 File Offset: 0x001C8564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0E4 RID: 49380 RVA: 0x001CA370 File Offset: 0x001C8570
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
						this.JokerSkillId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Owner = (JokerGuessActor)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Result = (JokerGuessSkillOp)input.ReadEnum();
						continue;
					}
					if (num == 34U)
					{
						if (this.aiHandCards_ == null)
						{
							this.AiHandCards = new JokerGuessCard();
						}
						input.ReadMessage(this.AiHandCards);
						continue;
					}
					if (num == 42U)
					{
						if (this.playerHandCards_ == null)
						{
							this.PlayerHandCards = new JokerGuessCard();
						}
						input.ReadMessage(this.PlayerHandCards);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040053B2 RID: 21426
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053B3 RID: 21427
		public const int JokerSkillIdFieldNumber = 1;

		// Token: 0x040053B4 RID: 21428
		private int jokerSkillId_;

		// Token: 0x040053B5 RID: 21429
		public const int OwnerFieldNumber = 2;

		// Token: 0x040053B6 RID: 21430
		private JokerGuessActor owner_;

		// Token: 0x040053B7 RID: 21431
		public const int ResultFieldNumber = 3;

		// Token: 0x040053B8 RID: 21432
		private JokerGuessSkillOp result_;

		// Token: 0x040053B9 RID: 21433
		public const int AiHandCardsFieldNumber = 4;

		// Token: 0x040053BA RID: 21434
		private JokerGuessCard aiHandCards_;

		// Token: 0x040053BB RID: 21435
		public const int PlayerHandCardsFieldNumber = 5;

		// Token: 0x040053BC RID: 21436
		private JokerGuessCard playerHandCards_;
	}
}
