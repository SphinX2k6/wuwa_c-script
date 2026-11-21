using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000865 RID: 2149
	public sealed class JokerGuessSkillTriggerAction : IMessage<JokerGuessSkillTriggerAction>, IMessage, IEquatable<JokerGuessSkillTriggerAction>, IDeepCloneable<JokerGuessSkillTriggerAction>, IBufferMessage
	{
		// Token: 0x0600BFC9 RID: 49097 RVA: 0x001C814B File Offset: 0x001C634B
		[NullableContext(1)]
		public static JokerGuessSkillTriggerAction Create()
		{
			return new JokerGuessSkillTriggerAction();
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x0600BFCA RID: 49098 RVA: 0x001C8152 File Offset: 0x001C6352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x0600BFCB RID: 49099 RVA: 0x001C8155 File Offset: 0x001C6355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessSkillTriggerAction.Descriptor;
			}
		}

		// Token: 0x0600BFCC RID: 49100 RVA: 0x001C815C File Offset: 0x001C635C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillTriggerAction()
		{
		}

		// Token: 0x0600BFCD RID: 49101 RVA: 0x001C8164 File Offset: 0x001C6364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillTriggerAction(JokerGuessSkillTriggerAction other) : this()
		{
			this.jokerSkillId_ = other.jokerSkillId_;
			this.owner_ = other.owner_;
			this.remainingSkillNum_ = other.remainingSkillNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFCE RID: 49102 RVA: 0x001C81A1 File Offset: 0x001C63A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillTriggerAction Clone()
		{
			return new JokerGuessSkillTriggerAction(this);
		}

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x0600BFCF RID: 49103 RVA: 0x001C81A9 File Offset: 0x001C63A9
		// (set) Token: 0x0600BFD0 RID: 49104 RVA: 0x001C81B1 File Offset: 0x001C63B1
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

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x0600BFD1 RID: 49105 RVA: 0x001C81BA File Offset: 0x001C63BA
		// (set) Token: 0x0600BFD2 RID: 49106 RVA: 0x001C81C2 File Offset: 0x001C63C2
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

		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x0600BFD3 RID: 49107 RVA: 0x001C81CB File Offset: 0x001C63CB
		// (set) Token: 0x0600BFD4 RID: 49108 RVA: 0x001C81D3 File Offset: 0x001C63D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainingSkillNum
		{
			get
			{
				return this.remainingSkillNum_;
			}
			set
			{
				this.remainingSkillNum_ = value;
			}
		}

		// Token: 0x0600BFD5 RID: 49109 RVA: 0x001C81DC File Offset: 0x001C63DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessSkillTriggerAction);
		}

		// Token: 0x0600BFD6 RID: 49110 RVA: 0x001C81EC File Offset: 0x001C63EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessSkillTriggerAction other)
		{
			return other != null && (other == this || (this.JokerSkillId == other.JokerSkillId && this.Owner == other.Owner && this.RemainingSkillNum == other.RemainingSkillNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFD7 RID: 49111 RVA: 0x001C8248 File Offset: 0x001C6448
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
			if (this.RemainingSkillNum != 0)
			{
				num ^= this.RemainingSkillNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BFD8 RID: 49112 RVA: 0x001C82BF File Offset: 0x001C64BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BFD9 RID: 49113 RVA: 0x001C82CC File Offset: 0x001C64CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFDA RID: 49114 RVA: 0x001C82D8 File Offset: 0x001C64D8
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
			if (this.RemainingSkillNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RemainingSkillNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BFDB RID: 49115 RVA: 0x001C834C File Offset: 0x001C654C
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
			if (this.RemainingSkillNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainingSkillNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BFDC RID: 49116 RVA: 0x001C83BC File Offset: 0x001C65BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessSkillTriggerAction other)
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
			if (other.RemainingSkillNum != 0)
			{
				this.RemainingSkillNum = other.RemainingSkillNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BFDD RID: 49117 RVA: 0x001C8420 File Offset: 0x001C6620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFDE RID: 49118 RVA: 0x001C842C File Offset: 0x001C662C
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
							this.RemainingSkillNum = input.ReadInt32();
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

		// Token: 0x040053C4 RID: 21444
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053C5 RID: 21445
		public const int JokerSkillIdFieldNumber = 1;

		// Token: 0x040053C6 RID: 21446
		private int jokerSkillId_;

		// Token: 0x040053C7 RID: 21447
		public const int OwnerFieldNumber = 2;

		// Token: 0x040053C8 RID: 21448
		private JokerGuessActor owner_;

		// Token: 0x040053C9 RID: 21449
		public const int RemainingSkillNumFieldNumber = 3;

		// Token: 0x040053CA RID: 21450
		private int remainingSkillNum_;
	}
}
