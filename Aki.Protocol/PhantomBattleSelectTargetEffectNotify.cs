using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA2 RID: 3234
	[NetMessage(EMessageId.PhantomBattleSelectTargetEffectNotify)]
	public sealed class PhantomBattleSelectTargetEffectNotify : IMessage<PhantomBattleSelectTargetEffectNotify>, IMessage, IEquatable<PhantomBattleSelectTargetEffectNotify>, IDeepCloneable<PhantomBattleSelectTargetEffectNotify>, IBufferMessage
	{
		// Token: 0x060118AC RID: 71852 RVA: 0x002921DD File Offset: 0x002903DD
		[NullableContext(1)]
		public static PhantomBattleSelectTargetEffectNotify Create()
		{
			return new PhantomBattleSelectTargetEffectNotify();
		}

		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x060118AD RID: 71853 RVA: 0x002921E4 File Offset: 0x002903E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x060118AE RID: 71854 RVA: 0x002921E7 File Offset: 0x002903E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectTargetEffectNotify.Descriptor;
			}
		}

		// Token: 0x060118AF RID: 71855 RVA: 0x002921EE File Offset: 0x002903EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetEffectNotify()
		{
		}

		// Token: 0x060118B0 RID: 71856 RVA: 0x00292204 File Offset: 0x00290404
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

		// Token: 0x060118B1 RID: 71857 RVA: 0x0029225D File Offset: 0x0029045D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetEffectNotify Clone()
		{
			return new PhantomBattleSelectTargetEffectNotify(this);
		}

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x060118B2 RID: 71858 RVA: 0x00292265 File Offset: 0x00290465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
		}

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x060118B3 RID: 71859 RVA: 0x0029226D File Offset: 0x0029046D
		// (set) Token: 0x060118B4 RID: 71860 RVA: 0x00292275 File Offset: 0x00290475
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

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x060118B5 RID: 71861 RVA: 0x0029227E File Offset: 0x0029047E
		// (set) Token: 0x060118B6 RID: 71862 RVA: 0x00292286 File Offset: 0x00290486
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

		// Token: 0x17003A20 RID: 14880
		// (get) Token: 0x060118B7 RID: 71863 RVA: 0x0029228F File Offset: 0x0029048F
		// (set) Token: 0x060118B8 RID: 71864 RVA: 0x00292297 File Offset: 0x00290497
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

		// Token: 0x060118B9 RID: 71865 RVA: 0x002922A0 File Offset: 0x002904A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectTargetEffectNotify);
		}

		// Token: 0x060118BA RID: 71866 RVA: 0x002922B0 File Offset: 0x002904B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectTargetEffectNotify other)
		{
			return other != null && (other == this || (this.fighterUId_.Equals(other.fighterUId_) && this.Num == other.Num && this.EffectType == other.EffectType && this.OwnerUid == other.OwnerUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060118BB RID: 71867 RVA: 0x00292320 File Offset: 0x00290520
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

		// Token: 0x060118BC RID: 71868 RVA: 0x0029239F File Offset: 0x0029059F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060118BD RID: 71869 RVA: 0x002923AC File Offset: 0x002905AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060118BE RID: 71870 RVA: 0x002923B8 File Offset: 0x002905B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Num != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Num);
			}
			if (this.EffectType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EffectType);
			}
			if (this.OwnerUid != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.OwnerUid);
			}
			this.fighterUId_.WriteTo(ref output, PhantomBattleSelectTargetEffectNotify._repeated_fighterUId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060118BF RID: 71871 RVA: 0x00292440 File Offset: 0x00290640
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

		// Token: 0x060118C0 RID: 71872 RVA: 0x002924C4 File Offset: 0x002906C4
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

		// Token: 0x060118C1 RID: 71873 RVA: 0x00292539 File Offset: 0x00290739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060118C2 RID: 71874 RVA: 0x00292544 File Offset: 0x00290744
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
				if (num <= 40U)
				{
					if (num == 24U)
					{
						this.Num = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.EffectType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.OwnerUid = input.ReadInt32();
						continue;
					}
					if (num == 104U || num == 106U)
					{
						this.fighterUId_.AddEntriesFrom(ref input, PhantomBattleSelectTargetEffectNotify._repeated_fighterUId_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006EF5 RID: 28405
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EF6 RID: 28406
		public const int FighterUIdFieldNumber = 13;

		// Token: 0x04006EF7 RID: 28407
		private static readonly FieldCodec<int> _repeated_fighterUId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04006EF8 RID: 28408
		private readonly RepeatedField<int> fighterUId_ = new RepeatedField<int>();

		// Token: 0x04006EF9 RID: 28409
		public const int NumFieldNumber = 3;

		// Token: 0x04006EFA RID: 28410
		private int num_;

		// Token: 0x04006EFB RID: 28411
		public const int EffectTypeFieldNumber = 5;

		// Token: 0x04006EFC RID: 28412
		private int effectType_;

		// Token: 0x04006EFD RID: 28413
		public const int OwnerUidFieldNumber = 7;

		// Token: 0x04006EFE RID: 28414
		private int ownerUid_;
	}
}
