using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000858 RID: 2136
	public sealed class JokerGuessDrawCardAction : IMessage<JokerGuessDrawCardAction>, IMessage, IEquatable<JokerGuessDrawCardAction>, IDeepCloneable<JokerGuessDrawCardAction>, IBufferMessage
	{
		// Token: 0x0600BEAB RID: 48811 RVA: 0x001C5396 File Offset: 0x001C3596
		[NullableContext(1)]
		public static JokerGuessDrawCardAction Create()
		{
			return new JokerGuessDrawCardAction();
		}

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x0600BEAC RID: 48812 RVA: 0x001C539D File Offset: 0x001C359D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x0600BEAD RID: 48813 RVA: 0x001C53A0 File Offset: 0x001C35A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessDrawCardAction.Descriptor;
			}
		}

		// Token: 0x0600BEAE RID: 48814 RVA: 0x001C53A7 File Offset: 0x001C35A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardAction()
		{
		}

		// Token: 0x0600BEAF RID: 48815 RVA: 0x001C53AF File Offset: 0x001C35AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardAction(JokerGuessDrawCardAction other) : this()
		{
			this.drawer_ = other.drawer_;
			this.drawCard_ = other.drawCard_;
			this.preSkill_ = other.preSkill_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BEB0 RID: 48816 RVA: 0x001C53EC File Offset: 0x001C35EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardAction Clone()
		{
			return new JokerGuessDrawCardAction(this);
		}

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x0600BEB1 RID: 48817 RVA: 0x001C53F4 File Offset: 0x001C35F4
		// (set) Token: 0x0600BEB2 RID: 48818 RVA: 0x001C53FC File Offset: 0x001C35FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessActor Drawer
		{
			get
			{
				return this.drawer_;
			}
			set
			{
				this.drawer_ = value;
			}
		}

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x0600BEB3 RID: 48819 RVA: 0x001C5405 File Offset: 0x001C3605
		// (set) Token: 0x0600BEB4 RID: 48820 RVA: 0x001C540D File Offset: 0x001C360D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DrawCard
		{
			get
			{
				return this.drawCard_;
			}
			set
			{
				this.drawCard_ = value;
			}
		}

		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x0600BEB5 RID: 48821 RVA: 0x001C5416 File Offset: 0x001C3616
		// (set) Token: 0x0600BEB6 RID: 48822 RVA: 0x001C541E File Offset: 0x001C361E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreSkill
		{
			get
			{
				return this.preSkill_;
			}
			set
			{
				this.preSkill_ = value;
			}
		}

		// Token: 0x0600BEB7 RID: 48823 RVA: 0x001C5427 File Offset: 0x001C3627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessDrawCardAction);
		}

		// Token: 0x0600BEB8 RID: 48824 RVA: 0x001C5438 File Offset: 0x001C3638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessDrawCardAction other)
		{
			return other != null && (other == this || (this.Drawer == other.Drawer && this.DrawCard == other.DrawCard && this.PreSkill == other.PreSkill && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEB9 RID: 48825 RVA: 0x001C5494 File Offset: 0x001C3694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Drawer != JokerGuessActor.Who)
			{
				num ^= this.Drawer.GetHashCode();
			}
			if (this.DrawCard != 0)
			{
				num ^= this.DrawCard.GetHashCode();
			}
			if (this.PreSkill != 0)
			{
				num ^= this.PreSkill.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BEBA RID: 48826 RVA: 0x001C550B File Offset: 0x001C370B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BEBB RID: 48827 RVA: 0x001C5518 File Offset: 0x001C3718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEBC RID: 48828 RVA: 0x001C5524 File Offset: 0x001C3724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Drawer != JokerGuessActor.Who)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Drawer);
			}
			if (this.DrawCard != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DrawCard);
			}
			if (this.PreSkill != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PreSkill);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BEBD RID: 48829 RVA: 0x001C5598 File Offset: 0x001C3798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Drawer != JokerGuessActor.Who)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Drawer);
			}
			if (this.DrawCard != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DrawCard);
			}
			if (this.PreSkill != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreSkill);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BEBE RID: 48830 RVA: 0x001C5608 File Offset: 0x001C3808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessDrawCardAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Drawer != JokerGuessActor.Who)
			{
				this.Drawer = other.Drawer;
			}
			if (other.DrawCard != 0)
			{
				this.DrawCard = other.DrawCard;
			}
			if (other.PreSkill != 0)
			{
				this.PreSkill = other.PreSkill;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BEBF RID: 48831 RVA: 0x001C566C File Offset: 0x001C386C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BEC0 RID: 48832 RVA: 0x001C5678 File Offset: 0x001C3878
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
							this.PreSkill = input.ReadInt32();
						}
					}
					else
					{
						this.DrawCard = input.ReadInt32();
					}
				}
				else
				{
					this.Drawer = (JokerGuessActor)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005372 RID: 21362
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005373 RID: 21363
		public const int DrawerFieldNumber = 1;

		// Token: 0x04005374 RID: 21364
		private JokerGuessActor drawer_;

		// Token: 0x04005375 RID: 21365
		public const int DrawCardFieldNumber = 2;

		// Token: 0x04005376 RID: 21366
		private int drawCard_;

		// Token: 0x04005377 RID: 21367
		public const int PreSkillFieldNumber = 3;

		// Token: 0x04005378 RID: 21368
		private int preSkill_;
	}
}
