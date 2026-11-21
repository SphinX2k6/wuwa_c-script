using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000864 RID: 2148
	public sealed class JokerGuessSkillExecAction : IMessage<JokerGuessSkillExecAction>, IMessage, IEquatable<JokerGuessSkillExecAction>, IDeepCloneable<JokerGuessSkillExecAction>, IBufferMessage
	{
		// Token: 0x0600BFAF RID: 49071 RVA: 0x001C7C2B File Offset: 0x001C5E2B
		[NullableContext(1)]
		public static JokerGuessSkillExecAction Create()
		{
			return new JokerGuessSkillExecAction();
		}

		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x0600BFB0 RID: 49072 RVA: 0x001C7C32 File Offset: 0x001C5E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x0600BFB1 RID: 49073 RVA: 0x001C7C35 File Offset: 0x001C5E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessSkillExecAction.Descriptor;
			}
		}

		// Token: 0x0600BFB2 RID: 49074 RVA: 0x001C7C3C File Offset: 0x001C5E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillExecAction()
		{
		}

		// Token: 0x0600BFB3 RID: 49075 RVA: 0x001C7C44 File Offset: 0x001C5E44
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

		// Token: 0x0600BFB4 RID: 49076 RVA: 0x001C7CC4 File Offset: 0x001C5EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillExecAction Clone()
		{
			return new JokerGuessSkillExecAction(this);
		}

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x0600BFB5 RID: 49077 RVA: 0x001C7CCC File Offset: 0x001C5ECC
		// (set) Token: 0x0600BFB6 RID: 49078 RVA: 0x001C7CD4 File Offset: 0x001C5ED4
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

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x0600BFB7 RID: 49079 RVA: 0x001C7CDD File Offset: 0x001C5EDD
		// (set) Token: 0x0600BFB8 RID: 49080 RVA: 0x001C7CE5 File Offset: 0x001C5EE5
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

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x0600BFB9 RID: 49081 RVA: 0x001C7CEE File Offset: 0x001C5EEE
		// (set) Token: 0x0600BFBA RID: 49082 RVA: 0x001C7CF6 File Offset: 0x001C5EF6
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

		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x0600BFBB RID: 49083 RVA: 0x001C7CFF File Offset: 0x001C5EFF
		// (set) Token: 0x0600BFBC RID: 49084 RVA: 0x001C7D07 File Offset: 0x001C5F07
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

		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x0600BFBD RID: 49085 RVA: 0x001C7D10 File Offset: 0x001C5F10
		// (set) Token: 0x0600BFBE RID: 49086 RVA: 0x001C7D18 File Offset: 0x001C5F18
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

		// Token: 0x0600BFBF RID: 49087 RVA: 0x001C7D21 File Offset: 0x001C5F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessSkillExecAction);
		}

		// Token: 0x0600BFC0 RID: 49088 RVA: 0x001C7D30 File Offset: 0x001C5F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessSkillExecAction other)
		{
			return other != null && (other == this || (this.JokerSkillId == other.JokerSkillId && this.Owner == other.Owner && this.Result == other.Result && object.Equals(this.AiHandCards, other.AiHandCards) && object.Equals(this.PlayerHandCards, other.PlayerHandCards) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFC1 RID: 49089 RVA: 0x001C7DB4 File Offset: 0x001C5FB4
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

		// Token: 0x0600BFC2 RID: 49090 RVA: 0x001C7E5D File Offset: 0x001C605D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BFC3 RID: 49091 RVA: 0x001C7E6A File Offset: 0x001C606A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFC4 RID: 49092 RVA: 0x001C7E74 File Offset: 0x001C6074
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

		// Token: 0x0600BFC5 RID: 49093 RVA: 0x001C7F20 File Offset: 0x001C6120
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

		// Token: 0x0600BFC6 RID: 49094 RVA: 0x001C7FC0 File Offset: 0x001C61C0
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

		// Token: 0x0600BFC7 RID: 49095 RVA: 0x001C807C File Offset: 0x001C627C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFC8 RID: 49096 RVA: 0x001C8088 File Offset: 0x001C6288
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

		// Token: 0x040053B9 RID: 21433
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053BA RID: 21434
		public const int JokerSkillIdFieldNumber = 1;

		// Token: 0x040053BB RID: 21435
		private int jokerSkillId_;

		// Token: 0x040053BC RID: 21436
		public const int OwnerFieldNumber = 2;

		// Token: 0x040053BD RID: 21437
		private JokerGuessActor owner_;

		// Token: 0x040053BE RID: 21438
		public const int ResultFieldNumber = 3;

		// Token: 0x040053BF RID: 21439
		private JokerGuessSkillOp result_;

		// Token: 0x040053C0 RID: 21440
		public const int AiHandCardsFieldNumber = 4;

		// Token: 0x040053C1 RID: 21441
		private JokerGuessCard aiHandCards_;

		// Token: 0x040053C2 RID: 21442
		public const int PlayerHandCardsFieldNumber = 5;

		// Token: 0x040053C3 RID: 21443
		private JokerGuessCard playerHandCards_;
	}
}
