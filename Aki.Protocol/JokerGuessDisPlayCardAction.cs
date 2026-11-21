using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000857 RID: 2135
	public sealed class JokerGuessDisPlayCardAction : IMessage<JokerGuessDisPlayCardAction>, IMessage, IEquatable<JokerGuessDisPlayCardAction>, IDeepCloneable<JokerGuessDisPlayCardAction>, IBufferMessage
	{
		// Token: 0x0600BE95 RID: 48789 RVA: 0x001C504C File Offset: 0x001C324C
		[NullableContext(1)]
		public static JokerGuessDisPlayCardAction Create()
		{
			return new JokerGuessDisPlayCardAction();
		}

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x0600BE96 RID: 48790 RVA: 0x001C5053 File Offset: 0x001C3253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x0600BE97 RID: 48791 RVA: 0x001C5056 File Offset: 0x001C3256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessDisPlayCardAction.Descriptor;
			}
		}

		// Token: 0x0600BE98 RID: 48792 RVA: 0x001C505D File Offset: 0x001C325D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDisPlayCardAction()
		{
		}

		// Token: 0x0600BE99 RID: 48793 RVA: 0x001C5065 File Offset: 0x001C3265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDisPlayCardAction(JokerGuessDisPlayCardAction other) : this()
		{
			this.jokerSkillId_ = other.jokerSkillId_;
			this.owner_ = other.owner_;
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE9A RID: 48794 RVA: 0x001C50A2 File Offset: 0x001C32A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDisPlayCardAction Clone()
		{
			return new JokerGuessDisPlayCardAction(this);
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x0600BE9B RID: 48795 RVA: 0x001C50AA File Offset: 0x001C32AA
		// (set) Token: 0x0600BE9C RID: 48796 RVA: 0x001C50B2 File Offset: 0x001C32B2
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

		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x0600BE9D RID: 48797 RVA: 0x001C50BB File Offset: 0x001C32BB
		// (set) Token: 0x0600BE9E RID: 48798 RVA: 0x001C50C3 File Offset: 0x001C32C3
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

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x0600BE9F RID: 48799 RVA: 0x001C50CC File Offset: 0x001C32CC
		// (set) Token: 0x0600BEA0 RID: 48800 RVA: 0x001C50D4 File Offset: 0x001C32D4
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

		// Token: 0x0600BEA1 RID: 48801 RVA: 0x001C50DD File Offset: 0x001C32DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessDisPlayCardAction);
		}

		// Token: 0x0600BEA2 RID: 48802 RVA: 0x001C50EC File Offset: 0x001C32EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessDisPlayCardAction other)
		{
			return other != null && (other == this || (this.JokerSkillId == other.JokerSkillId && this.Owner == other.Owner && this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEA3 RID: 48803 RVA: 0x001C5148 File Offset: 0x001C3348
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

		// Token: 0x0600BEA4 RID: 48804 RVA: 0x001C51BF File Offset: 0x001C33BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BEA5 RID: 48805 RVA: 0x001C51CC File Offset: 0x001C33CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEA6 RID: 48806 RVA: 0x001C51D8 File Offset: 0x001C33D8
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
			if (this.CardId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BEA7 RID: 48807 RVA: 0x001C524C File Offset: 0x001C344C
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

		// Token: 0x0600BEA8 RID: 48808 RVA: 0x001C52BC File Offset: 0x001C34BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessDisPlayCardAction other)
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
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BEA9 RID: 48809 RVA: 0x001C5320 File Offset: 0x001C3520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BEAA RID: 48810 RVA: 0x001C532C File Offset: 0x001C352C
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CardId = input.ReadInt32();
						}
					}
					else
					{
						this.Owner = (JokerGuessActor)input.ReadEnum();
					}
				}
				else
				{
					this.JokerSkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400536B RID: 21355
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400536C RID: 21356
		public const int JokerSkillIdFieldNumber = 1;

		// Token: 0x0400536D RID: 21357
		private int jokerSkillId_;

		// Token: 0x0400536E RID: 21358
		public const int OwnerFieldNumber = 2;

		// Token: 0x0400536F RID: 21359
		private JokerGuessActor owner_;

		// Token: 0x04005370 RID: 21360
		public const int CardIdFieldNumber = 3;

		// Token: 0x04005371 RID: 21361
		private int cardId_;
	}
}
