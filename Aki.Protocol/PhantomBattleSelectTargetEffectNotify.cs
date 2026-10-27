using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB2 RID: 3250
	[NetMessage(EMessageId.PhantomBattleSelectTargetEffectNotify)]
	public sealed class PhantomBattleSelectTargetEffectNotify : IMessage<PhantomBattleSelectTargetEffectNotify>, IMessage, IEquatable<PhantomBattleSelectTargetEffectNotify>, IDeepCloneable<PhantomBattleSelectTargetEffectNotify>, IBufferMessage
	{
		// Token: 0x060119AC RID: 72108 RVA: 0x00293F48 File Offset: 0x00292148
		[NullableContext(1)]
		public static PhantomBattleSelectTargetEffectNotify Create()
		{
			return new PhantomBattleSelectTargetEffectNotify();
		}

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x060119AD RID: 72109 RVA: 0x00293F4F File Offset: 0x0029214F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x060119AE RID: 72110 RVA: 0x00293F52 File Offset: 0x00292152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectTargetEffectNotify.Descriptor;
			}
		}

		// Token: 0x060119AF RID: 72111 RVA: 0x00293F59 File Offset: 0x00292159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetEffectNotify()
		{
		}

		// Token: 0x060119B0 RID: 72112 RVA: 0x00293F6C File Offset: 0x0029216C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetEffectNotify(PhantomBattleSelectTargetEffectNotify other) : this()
		{
			this.fighterUId_ = other.fighterUId_.Clone();
			this.num_ = other.num_;
			this.effectType_ = other.effectType_;
			this.ownerUid_ = other.ownerUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060119B1 RID: 72113 RVA: 0x00293FC5 File Offset: 0x002921C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetEffectNotify Clone()
		{
			return new PhantomBattleSelectTargetEffectNotify(this);
		}

		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x060119B2 RID: 72114 RVA: 0x00293FCD File Offset: 0x002921CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
		}

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x060119B3 RID: 72115 RVA: 0x00293FD5 File Offset: 0x002921D5
		// (set) Token: 0x060119B4 RID: 72116 RVA: 0x00293FDD File Offset: 0x002921DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x060119B5 RID: 72117 RVA: 0x00293FE6 File Offset: 0x002921E6
		// (set) Token: 0x060119B6 RID: 72118 RVA: 0x00293FEE File Offset: 0x002921EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectType
		{
			get
			{
				return this.effectType_;
			}
			set
			{
				this.effectType_ = value;
			}
		}

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x060119B7 RID: 72119 RVA: 0x00293FF7 File Offset: 0x002921F7
		// (set) Token: 0x060119B8 RID: 72120 RVA: 0x00293FFF File Offset: 0x002921FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OwnerUid
		{
			get
			{
				return this.ownerUid_;
			}
			set
			{
				this.ownerUid_ = value;
			}
		}

		// Token: 0x060119B9 RID: 72121 RVA: 0x00294008 File Offset: 0x00292208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectTargetEffectNotify);
		}

		// Token: 0x060119BA RID: 72122 RVA: 0x00294018 File Offset: 0x00292218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectTargetEffectNotify other)
		{
			return other != null && (other == this || (this.fighterUId_.Equals(other.fighterUId_) && this.Num == other.Num && this.EffectType == other.EffectType && this.OwnerUid == other.OwnerUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060119BB RID: 72123 RVA: 0x00294088 File Offset: 0x00292288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fighterUId_.GetHashCode();
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.EffectType != 0)
			{
				num ^= this.EffectType.GetHashCode();
			}
			if (this.OwnerUid != 0)
			{
				num ^= this.OwnerUid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060119BC RID: 72124 RVA: 0x00294107 File Offset: 0x00292307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060119BD RID: 72125 RVA: 0x00294114 File Offset: 0x00292314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060119BE RID: 72126 RVA: 0x00294120 File Offset: 0x00292320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fighterUId_.WriteTo(ref output, PhantomBattleSelectTargetEffectNotify._repeated_fighterUId_codec);
			if (this.OwnerUid != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.OwnerUid);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Num);
			}
			if (this.EffectType != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EffectType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060119BF RID: 72127 RVA: 0x002941A8 File Offset: 0x002923A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fighterUId_.CalculateSize(PhantomBattleSelectTargetEffectNotify._repeated_fighterUId_codec);
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.EffectType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectType);
			}
			if (this.OwnerUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OwnerUid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060119C0 RID: 72128 RVA: 0x0029422C File Offset: 0x0029242C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSelectTargetEffectNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.fighterUId_.Add(other.fighterUId_);
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.EffectType != 0)
			{
				this.EffectType = other.EffectType;
			}
			if (other.OwnerUid != 0)
			{
				this.OwnerUid = other.OwnerUid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060119C1 RID: 72129 RVA: 0x002942A1 File Offset: 0x002924A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060119C2 RID: 72130 RVA: 0x002942AC File Offset: 0x002924AC
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.fighterUId_.AddEntriesFrom(ref input, PhantomBattleSelectTargetEffectNotify._repeated_fighterUId_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.OwnerUid = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Num = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.EffectType = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006EE1 RID: 28385
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EE2 RID: 28386
		public const int FighterUIdFieldNumber = 2;

		// Token: 0x04006EE3 RID: 28387
		private static readonly FieldCodec<int> _repeated_fighterUId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006EE4 RID: 28388
		private readonly RepeatedField<int> fighterUId_ = new RepeatedField<int>();

		// Token: 0x04006EE5 RID: 28389
		public const int NumFieldNumber = 8;

		// Token: 0x04006EE6 RID: 28390
		private int num_;

		// Token: 0x04006EE7 RID: 28391
		public const int EffectTypeFieldNumber = 10;

		// Token: 0x04006EE8 RID: 28392
		private int effectType_;

		// Token: 0x04006EE9 RID: 28393
		public const int OwnerUidFieldNumber = 3;

		// Token: 0x04006EEA RID: 28394
		private int ownerUid_;
	}
}
