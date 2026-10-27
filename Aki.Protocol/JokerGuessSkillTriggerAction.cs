using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000876 RID: 2166
	public sealed class JokerGuessSkillTriggerAction : IMessage<JokerGuessSkillTriggerAction>, IMessage, IEquatable<JokerGuessSkillTriggerAction>, IDeepCloneable<JokerGuessSkillTriggerAction>, IBufferMessage
	{
		// Token: 0x0600C0E5 RID: 49381 RVA: 0x001CA433 File Offset: 0x001C8633
		[NullableContext(1)]
		public static JokerGuessSkillTriggerAction Create()
		{
			return new JokerGuessSkillTriggerAction();
		}

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x0600C0E6 RID: 49382 RVA: 0x001CA43A File Offset: 0x001C863A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x0600C0E7 RID: 49383 RVA: 0x001CA43D File Offset: 0x001C863D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessSkillTriggerAction.Descriptor;
			}
		}

		// Token: 0x0600C0E8 RID: 49384 RVA: 0x001CA444 File Offset: 0x001C8644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillTriggerAction()
		{
		}

		// Token: 0x0600C0E9 RID: 49385 RVA: 0x001CA44C File Offset: 0x001C864C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillTriggerAction(JokerGuessSkillTriggerAction other) : this()
		{
			this.jokerSkillId_ = other.jokerSkillId_;
			this.owner_ = other.owner_;
			this.remainingSkillNum_ = other.remainingSkillNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0EA RID: 49386 RVA: 0x001CA489 File Offset: 0x001C8689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessSkillTriggerAction Clone()
		{
			return new JokerGuessSkillTriggerAction(this);
		}

		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x0600C0EB RID: 49387 RVA: 0x001CA491 File Offset: 0x001C8691
		// (set) Token: 0x0600C0EC RID: 49388 RVA: 0x001CA499 File Offset: 0x001C8699
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

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x0600C0ED RID: 49389 RVA: 0x001CA4A2 File Offset: 0x001C86A2
		// (set) Token: 0x0600C0EE RID: 49390 RVA: 0x001CA4AA File Offset: 0x001C86AA
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

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x0600C0EF RID: 49391 RVA: 0x001CA4B3 File Offset: 0x001C86B3
		// (set) Token: 0x0600C0F0 RID: 49392 RVA: 0x001CA4BB File Offset: 0x001C86BB
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

		// Token: 0x0600C0F1 RID: 49393 RVA: 0x001CA4C4 File Offset: 0x001C86C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessSkillTriggerAction);
		}

		// Token: 0x0600C0F2 RID: 49394 RVA: 0x001CA4D4 File Offset: 0x001C86D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessSkillTriggerAction other)
		{
			return other != null && (other == this || (this.JokerSkillId == other.JokerSkillId && this.Owner == other.Owner && this.RemainingSkillNum == other.RemainingSkillNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0F3 RID: 49395 RVA: 0x001CA530 File Offset: 0x001C8730
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

		// Token: 0x0600C0F4 RID: 49396 RVA: 0x001CA5A7 File Offset: 0x001C87A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C0F5 RID: 49397 RVA: 0x001CA5B4 File Offset: 0x001C87B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0F6 RID: 49398 RVA: 0x001CA5C0 File Offset: 0x001C87C0
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

		// Token: 0x0600C0F7 RID: 49399 RVA: 0x001CA634 File Offset: 0x001C8834
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

		// Token: 0x0600C0F8 RID: 49400 RVA: 0x001CA6A4 File Offset: 0x001C88A4
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

		// Token: 0x0600C0F9 RID: 49401 RVA: 0x001CA708 File Offset: 0x001C8908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0FA RID: 49402 RVA: 0x001CA714 File Offset: 0x001C8914
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

		// Token: 0x040053BD RID: 21437
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053BE RID: 21438
		public const int JokerSkillIdFieldNumber = 1;

		// Token: 0x040053BF RID: 21439
		private int jokerSkillId_;

		// Token: 0x040053C0 RID: 21440
		public const int OwnerFieldNumber = 2;

		// Token: 0x040053C1 RID: 21441
		private JokerGuessActor owner_;

		// Token: 0x040053C2 RID: 21442
		public const int RemainingSkillNumFieldNumber = 3;

		// Token: 0x040053C3 RID: 21443
		private int remainingSkillNum_;
	}
}
