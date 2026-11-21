using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085B RID: 2139
	public sealed class JokerGuessHpAction : IMessage<JokerGuessHpAction>, IMessage, IEquatable<JokerGuessHpAction>, IDeepCloneable<JokerGuessHpAction>, IBufferMessage
	{
		// Token: 0x0600BEE9 RID: 48873 RVA: 0x001C5C1E File Offset: 0x001C3E1E
		[NullableContext(1)]
		public static JokerGuessHpAction Create()
		{
			return new JokerGuessHpAction();
		}

		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x0600BEEA RID: 48874 RVA: 0x001C5C25 File Offset: 0x001C3E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x0600BEEB RID: 48875 RVA: 0x001C5C28 File Offset: 0x001C3E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessHpAction.Descriptor;
			}
		}

		// Token: 0x0600BEEC RID: 48876 RVA: 0x001C5C2F File Offset: 0x001C3E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessHpAction()
		{
		}

		// Token: 0x0600BEED RID: 48877 RVA: 0x001C5C37 File Offset: 0x001C3E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessHpAction(JokerGuessHpAction other) : this()
		{
			this.actor_ = other.actor_;
			this.healthHp_ = other.healthHp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BEEE RID: 48878 RVA: 0x001C5C68 File Offset: 0x001C3E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessHpAction Clone()
		{
			return new JokerGuessHpAction(this);
		}

		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x0600BEEF RID: 48879 RVA: 0x001C5C70 File Offset: 0x001C3E70
		// (set) Token: 0x0600BEF0 RID: 48880 RVA: 0x001C5C78 File Offset: 0x001C3E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessActor Actor
		{
			get
			{
				return this.actor_;
			}
			set
			{
				this.actor_ = value;
			}
		}

		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x0600BEF1 RID: 48881 RVA: 0x001C5C81 File Offset: 0x001C3E81
		// (set) Token: 0x0600BEF2 RID: 48882 RVA: 0x001C5C89 File Offset: 0x001C3E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HealthHp
		{
			get
			{
				return this.healthHp_;
			}
			set
			{
				this.healthHp_ = value;
			}
		}

		// Token: 0x0600BEF3 RID: 48883 RVA: 0x001C5C92 File Offset: 0x001C3E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessHpAction);
		}

		// Token: 0x0600BEF4 RID: 48884 RVA: 0x001C5CA0 File Offset: 0x001C3EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessHpAction other)
		{
			return other != null && (other == this || (this.Actor == other.Actor && this.HealthHp == other.HealthHp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEF5 RID: 48885 RVA: 0x001C5CE0 File Offset: 0x001C3EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Actor != JokerGuessActor.Who)
			{
				num ^= this.Actor.GetHashCode();
			}
			if (this.HealthHp != 0)
			{
				num ^= this.HealthHp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BEF6 RID: 48886 RVA: 0x001C5D3E File Offset: 0x001C3F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BEF7 RID: 48887 RVA: 0x001C5D4B File Offset: 0x001C3F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEF8 RID: 48888 RVA: 0x001C5D54 File Offset: 0x001C3F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Actor != JokerGuessActor.Who)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Actor);
			}
			if (this.HealthHp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HealthHp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BEF9 RID: 48889 RVA: 0x001C5DAC File Offset: 0x001C3FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Actor != JokerGuessActor.Who)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Actor);
			}
			if (this.HealthHp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HealthHp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BEFA RID: 48890 RVA: 0x001C5E04 File Offset: 0x001C4004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessHpAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Actor != JokerGuessActor.Who)
			{
				this.Actor = other.Actor;
			}
			if (other.HealthHp != 0)
			{
				this.HealthHp = other.HealthHp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BEFB RID: 48891 RVA: 0x001C5E54 File Offset: 0x001C4054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BEFC RID: 48892 RVA: 0x001C5E60 File Offset: 0x001C4060
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HealthHp = input.ReadInt32();
					}
				}
				else
				{
					this.Actor = (JokerGuessActor)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005384 RID: 21380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005385 RID: 21381
		public const int ActorFieldNumber = 1;

		// Token: 0x04005386 RID: 21382
		private JokerGuessActor actor_;

		// Token: 0x04005387 RID: 21383
		public const int HealthHpFieldNumber = 2;

		// Token: 0x04005388 RID: 21384
		private int healthHp_;
	}
}
