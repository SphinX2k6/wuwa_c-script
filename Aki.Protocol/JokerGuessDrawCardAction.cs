using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000869 RID: 2153
	public sealed class JokerGuessDrawCardAction : IMessage<JokerGuessDrawCardAction>, IMessage, IEquatable<JokerGuessDrawCardAction>, IDeepCloneable<JokerGuessDrawCardAction>, IBufferMessage
	{
		// Token: 0x0600BFC7 RID: 49095 RVA: 0x001C767E File Offset: 0x001C587E
		[NullableContext(1)]
		public static JokerGuessDrawCardAction Create()
		{
			return new JokerGuessDrawCardAction();
		}

		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x0600BFC8 RID: 49096 RVA: 0x001C7685 File Offset: 0x001C5885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x0600BFC9 RID: 49097 RVA: 0x001C7688 File Offset: 0x001C5888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessDrawCardAction.Descriptor;
			}
		}

		// Token: 0x0600BFCA RID: 49098 RVA: 0x001C768F File Offset: 0x001C588F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardAction()
		{
		}

		// Token: 0x0600BFCB RID: 49099 RVA: 0x001C7697 File Offset: 0x001C5897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardAction(JokerGuessDrawCardAction other) : this()
		{
			this.drawer_ = other.drawer_;
			this.drawCard_ = other.drawCard_;
			this.preSkill_ = other.preSkill_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFCC RID: 49100 RVA: 0x001C76D4 File Offset: 0x001C58D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardAction Clone()
		{
			return new JokerGuessDrawCardAction(this);
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x0600BFCD RID: 49101 RVA: 0x001C76DC File Offset: 0x001C58DC
		// (set) Token: 0x0600BFCE RID: 49102 RVA: 0x001C76E4 File Offset: 0x001C58E4
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

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x0600BFCF RID: 49103 RVA: 0x001C76ED File Offset: 0x001C58ED
		// (set) Token: 0x0600BFD0 RID: 49104 RVA: 0x001C76F5 File Offset: 0x001C58F5
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

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x0600BFD1 RID: 49105 RVA: 0x001C76FE File Offset: 0x001C58FE
		// (set) Token: 0x0600BFD2 RID: 49106 RVA: 0x001C7706 File Offset: 0x001C5906
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

		// Token: 0x0600BFD3 RID: 49107 RVA: 0x001C770F File Offset: 0x001C590F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessDrawCardAction);
		}

		// Token: 0x0600BFD4 RID: 49108 RVA: 0x001C7720 File Offset: 0x001C5920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessDrawCardAction other)
		{
			return other != null && (other == this || (this.Drawer == other.Drawer && this.DrawCard == other.DrawCard && this.PreSkill == other.PreSkill && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFD5 RID: 49109 RVA: 0x001C777C File Offset: 0x001C597C
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

		// Token: 0x0600BFD6 RID: 49110 RVA: 0x001C77F3 File Offset: 0x001C59F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BFD7 RID: 49111 RVA: 0x001C7800 File Offset: 0x001C5A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFD8 RID: 49112 RVA: 0x001C780C File Offset: 0x001C5A0C
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

		// Token: 0x0600BFD9 RID: 49113 RVA: 0x001C7880 File Offset: 0x001C5A80
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

		// Token: 0x0600BFDA RID: 49114 RVA: 0x001C78F0 File Offset: 0x001C5AF0
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

		// Token: 0x0600BFDB RID: 49115 RVA: 0x001C7954 File Offset: 0x001C5B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFDC RID: 49116 RVA: 0x001C7960 File Offset: 0x001C5B60
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

		// Token: 0x0400536B RID: 21355
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400536C RID: 21356
		public const int DrawerFieldNumber = 1;

		// Token: 0x0400536D RID: 21357
		private JokerGuessActor drawer_;

		// Token: 0x0400536E RID: 21358
		public const int DrawCardFieldNumber = 2;

		// Token: 0x0400536F RID: 21359
		private int drawCard_;

		// Token: 0x04005370 RID: 21360
		public const int PreSkillFieldNumber = 3;

		// Token: 0x04005371 RID: 21361
		private int preSkill_;
	}
}
