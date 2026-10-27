using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086C RID: 2156
	public sealed class JokerGuessHpAction : IMessage<JokerGuessHpAction>, IMessage, IEquatable<JokerGuessHpAction>, IDeepCloneable<JokerGuessHpAction>, IBufferMessage
	{
		// Token: 0x0600C005 RID: 49157 RVA: 0x001C7F07 File Offset: 0x001C6107
		[NullableContext(1)]
		public static JokerGuessHpAction Create()
		{
			return new JokerGuessHpAction();
		}

		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x0600C006 RID: 49158 RVA: 0x001C7F0E File Offset: 0x001C610E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026C8 RID: 9928
		// (get) Token: 0x0600C007 RID: 49159 RVA: 0x001C7F11 File Offset: 0x001C6111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessHpAction.Descriptor;
			}
		}

		// Token: 0x0600C008 RID: 49160 RVA: 0x001C7F18 File Offset: 0x001C6118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessHpAction()
		{
		}

		// Token: 0x0600C009 RID: 49161 RVA: 0x001C7F20 File Offset: 0x001C6120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessHpAction(JokerGuessHpAction other) : this()
		{
			this.actor_ = other.actor_;
			this.healthHp_ = other.healthHp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C00A RID: 49162 RVA: 0x001C7F51 File Offset: 0x001C6151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessHpAction Clone()
		{
			return new JokerGuessHpAction(this);
		}

		// Token: 0x170026C9 RID: 9929
		// (get) Token: 0x0600C00B RID: 49163 RVA: 0x001C7F59 File Offset: 0x001C6159
		// (set) Token: 0x0600C00C RID: 49164 RVA: 0x001C7F61 File Offset: 0x001C6161
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

		// Token: 0x170026CA RID: 9930
		// (get) Token: 0x0600C00D RID: 49165 RVA: 0x001C7F6A File Offset: 0x001C616A
		// (set) Token: 0x0600C00E RID: 49166 RVA: 0x001C7F72 File Offset: 0x001C6172
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

		// Token: 0x0600C00F RID: 49167 RVA: 0x001C7F7B File Offset: 0x001C617B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessHpAction);
		}

		// Token: 0x0600C010 RID: 49168 RVA: 0x001C7F89 File Offset: 0x001C6189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessHpAction other)
		{
			return other != null && (other == this || (this.Actor == other.Actor && this.HealthHp == other.HealthHp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C011 RID: 49169 RVA: 0x001C7FC8 File Offset: 0x001C61C8
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

		// Token: 0x0600C012 RID: 49170 RVA: 0x001C8026 File Offset: 0x001C6226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C013 RID: 49171 RVA: 0x001C8033 File Offset: 0x001C6233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C014 RID: 49172 RVA: 0x001C803C File Offset: 0x001C623C
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

		// Token: 0x0600C015 RID: 49173 RVA: 0x001C8094 File Offset: 0x001C6294
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

		// Token: 0x0600C016 RID: 49174 RVA: 0x001C80EC File Offset: 0x001C62EC
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

		// Token: 0x0600C017 RID: 49175 RVA: 0x001C813C File Offset: 0x001C633C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C018 RID: 49176 RVA: 0x001C8148 File Offset: 0x001C6348
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

		// Token: 0x0400537D RID: 21373
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400537E RID: 21374
		public const int ActorFieldNumber = 1;

		// Token: 0x0400537F RID: 21375
		private JokerGuessActor actor_;

		// Token: 0x04005380 RID: 21376
		public const int HealthHpFieldNumber = 2;

		// Token: 0x04005381 RID: 21377
		private int healthHp_;
	}
}
