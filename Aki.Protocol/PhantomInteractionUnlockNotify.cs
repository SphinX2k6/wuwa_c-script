using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCC RID: 3276
	[NetMessage(EMessageId.PhantomInteractionUnlockNotify)]
	public sealed class PhantomInteractionUnlockNotify : IMessage<PhantomInteractionUnlockNotify>, IMessage, IEquatable<PhantomInteractionUnlockNotify>, IDeepCloneable<PhantomInteractionUnlockNotify>, IBufferMessage
	{
		// Token: 0x06011BFF RID: 72703 RVA: 0x002992E9 File Offset: 0x002974E9
		[NullableContext(1)]
		public static PhantomInteractionUnlockNotify Create()
		{
			return new PhantomInteractionUnlockNotify();
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x06011C00 RID: 72704 RVA: 0x002992F0 File Offset: 0x002974F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x06011C01 RID: 72705 RVA: 0x002992F3 File Offset: 0x002974F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06011C02 RID: 72706 RVA: 0x002992FA File Offset: 0x002974FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionUnlockNotify()
		{
		}

		// Token: 0x06011C03 RID: 72707 RVA: 0x00299318 File Offset: 0x00297518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionUnlockNotify(PhantomInteractionUnlockNotify other) : this()
		{
			this.unlockIllustratedPhantoms_ = other.unlockIllustratedPhantoms_.Clone();
			this.equipedMonsterIds_ = other.equipedMonsterIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C04 RID: 72708 RVA: 0x00299353 File Offset: 0x00297553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionUnlockNotify Clone()
		{
			return new PhantomInteractionUnlockNotify(this);
		}

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x06011C05 RID: 72709 RVA: 0x0029935B File Offset: 0x0029755B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UnlockIllustratedPhantom> UnlockIllustratedPhantoms
		{
			get
			{
				return this.unlockIllustratedPhantoms_;
			}
		}

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x06011C06 RID: 72710 RVA: 0x00299363 File Offset: 0x00297563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipedMonsterIds
		{
			get
			{
				return this.equipedMonsterIds_;
			}
		}

		// Token: 0x06011C07 RID: 72711 RVA: 0x0029936B File Offset: 0x0029756B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionUnlockNotify);
		}

		// Token: 0x06011C08 RID: 72712 RVA: 0x0029937C File Offset: 0x0029757C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockIllustratedPhantoms_.Equals(other.unlockIllustratedPhantoms_) && this.equipedMonsterIds_.Equals(other.equipedMonsterIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C09 RID: 72713 RVA: 0x002993D0 File Offset: 0x002975D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockIllustratedPhantoms_.GetHashCode();
			num ^= this.equipedMonsterIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C0A RID: 72714 RVA: 0x00299412 File Offset: 0x00297612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C0B RID: 72715 RVA: 0x0029941F File Offset: 0x0029761F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C0C RID: 72716 RVA: 0x00299428 File Offset: 0x00297628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equipedMonsterIds_.WriteTo(ref output, PhantomInteractionUnlockNotify._repeated_equipedMonsterIds_codec);
			this.unlockIllustratedPhantoms_.WriteTo(ref output, PhantomInteractionUnlockNotify._repeated_unlockIllustratedPhantoms_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C0D RID: 72717 RVA: 0x00299460 File Offset: 0x00297660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockIllustratedPhantoms_.CalculateSize(PhantomInteractionUnlockNotify._repeated_unlockIllustratedPhantoms_codec);
			num += this.equipedMonsterIds_.CalculateSize(PhantomInteractionUnlockNotify._repeated_equipedMonsterIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C0E RID: 72718 RVA: 0x002994AC File Offset: 0x002976AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomInteractionUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockIllustratedPhantoms_.Add(other.unlockIllustratedPhantoms_);
			this.equipedMonsterIds_.Add(other.equipedMonsterIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C0F RID: 72719 RVA: 0x002994EB File Offset: 0x002976EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C10 RID: 72720 RVA: 0x002994F4 File Offset: 0x002976F4
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
				if (num != 112U && num != 114U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.unlockIllustratedPhantoms_.AddEntriesFrom(ref input, PhantomInteractionUnlockNotify._repeated_unlockIllustratedPhantoms_codec);
					}
				}
				else
				{
					this.equipedMonsterIds_.AddEntriesFrom(ref input, PhantomInteractionUnlockNotify._repeated_equipedMonsterIds_codec);
				}
			}
		}

		// Token: 0x04006FE5 RID: 28645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FE6 RID: 28646
		public const int UnlockIllustratedPhantomsFieldNumber = 15;

		// Token: 0x04006FE7 RID: 28647
		private static readonly FieldCodec<UnlockIllustratedPhantom> _repeated_unlockIllustratedPhantoms_codec = FieldCodec.ForMessage<UnlockIllustratedPhantom>(122U, UnlockIllustratedPhantom.Parser);

		// Token: 0x04006FE8 RID: 28648
		private readonly RepeatedField<UnlockIllustratedPhantom> unlockIllustratedPhantoms_ = new RepeatedField<UnlockIllustratedPhantom>();

		// Token: 0x04006FE9 RID: 28649
		public const int EquipedMonsterIdsFieldNumber = 14;

		// Token: 0x04006FEA RID: 28650
		private static readonly FieldCodec<int> _repeated_equipedMonsterIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04006FEB RID: 28651
		private readonly RepeatedField<int> equipedMonsterIds_ = new RepeatedField<int>();
	}
}
