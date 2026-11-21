using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C66 RID: 3174
	public sealed class PhantomBattleDebugCardInfo : IMessage<PhantomBattleDebugCardInfo>, IMessage, IEquatable<PhantomBattleDebugCardInfo>, IDeepCloneable<PhantomBattleDebugCardInfo>, IBufferMessage
	{
		// Token: 0x060113AC RID: 70572 RVA: 0x0028642E File Offset: 0x0028462E
		[NullableContext(1)]
		public static PhantomBattleDebugCardInfo Create()
		{
			return new PhantomBattleDebugCardInfo();
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x060113AD RID: 70573 RVA: 0x00286435 File Offset: 0x00284635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleDebugCardInfo> Parser
		{
			get
			{
				return PhantomBattleDebugCardInfo._parser;
			}
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x060113AE RID: 70574 RVA: 0x0028643C File Offset: 0x0028463C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x060113AF RID: 70575 RVA: 0x0028643F File Offset: 0x0028463F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugCardInfo.Descriptor;
			}
		}

		// Token: 0x060113B0 RID: 70576 RVA: 0x00286446 File Offset: 0x00284646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugCardInfo()
		{
		}

		// Token: 0x060113B1 RID: 70577 RVA: 0x00286450 File Offset: 0x00284650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugCardInfo(PhantomBattleDebugCardInfo other) : this()
		{
			this.phantomBattleHandCardInfo_ = ((other.phantomBattleHandCardInfo_ != null) ? other.phantomBattleHandCardInfo_.Clone() : null);
			this.fightPower_ = other.fightPower_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060113B2 RID: 70578 RVA: 0x0028649C File Offset: 0x0028469C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugCardInfo Clone()
		{
			return new PhantomBattleDebugCardInfo(this);
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x060113B3 RID: 70579 RVA: 0x002864A4 File Offset: 0x002846A4
		// (set) Token: 0x060113B4 RID: 70580 RVA: 0x002864AC File Offset: 0x002846AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo PhantomBattleHandCardInfo
		{
			get
			{
				return this.phantomBattleHandCardInfo_;
			}
			set
			{
				this.phantomBattleHandCardInfo_ = value;
			}
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x060113B5 RID: 70581 RVA: 0x002864B5 File Offset: 0x002846B5
		// (set) Token: 0x060113B6 RID: 70582 RVA: 0x002864BD File Offset: 0x002846BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightPower
		{
			get
			{
				return this.fightPower_;
			}
			set
			{
				this.fightPower_ = value;
			}
		}

		// Token: 0x060113B7 RID: 70583 RVA: 0x002864C6 File Offset: 0x002846C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugCardInfo);
		}

		// Token: 0x060113B8 RID: 70584 RVA: 0x002864D4 File Offset: 0x002846D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugCardInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleHandCardInfo, other.PhantomBattleHandCardInfo) && this.FightPower == other.FightPower && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060113B9 RID: 70585 RVA: 0x00286524 File Offset: 0x00284724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num ^= this.PhantomBattleHandCardInfo.GetHashCode();
			}
			if (this.FightPower != 0)
			{
				num ^= this.FightPower.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060113BA RID: 70586 RVA: 0x00286579 File Offset: 0x00284779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060113BB RID: 70587 RVA: 0x00286586 File Offset: 0x00284786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060113BC RID: 70588 RVA: 0x00286590 File Offset: 0x00284790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleHandCardInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PhantomBattleHandCardInfo);
			}
			if (this.FightPower != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FightPower);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060113BD RID: 70589 RVA: 0x002865EC File Offset: 0x002847EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleHandCardInfo);
			}
			if (this.FightPower != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FightPower);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060113BE RID: 70590 RVA: 0x00286644 File Offset: 0x00284844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDebugCardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleHandCardInfo_ != null)
			{
				if (this.phantomBattleHandCardInfo_ == null)
				{
					this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
				}
				this.PhantomBattleHandCardInfo.MergeFrom(other.PhantomBattleHandCardInfo);
			}
			if (other.FightPower != 0)
			{
				this.FightPower = other.FightPower;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060113BF RID: 70591 RVA: 0x002866AC File Offset: 0x002848AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060113C0 RID: 70592 RVA: 0x002866B8 File Offset: 0x002848B8
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FightPower = input.ReadInt32();
					}
				}
				else
				{
					if (this.phantomBattleHandCardInfo_ == null)
					{
						this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
					}
					input.ReadMessage(this.PhantomBattleHandCardInfo);
				}
			}
		}

		// Token: 0x04006D68 RID: 28008
		private static readonly MessageParser<PhantomBattleDebugCardInfo> _parser = new MessageParser<PhantomBattleDebugCardInfo>(() => new PhantomBattleDebugCardInfo());

		// Token: 0x04006D69 RID: 28009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D6A RID: 28010
		public const int PhantomBattleHandCardInfoFieldNumber = 1;

		// Token: 0x04006D6B RID: 28011
		private PhantomBattleHandCardInfo phantomBattleHandCardInfo_;

		// Token: 0x04006D6C RID: 28012
		public const int FightPowerFieldNumber = 2;

		// Token: 0x04006D6D RID: 28013
		private int fightPower_;
	}
}
