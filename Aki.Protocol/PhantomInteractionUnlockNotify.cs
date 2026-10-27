using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDC RID: 3292
	[NetMessage(EMessageId.PhantomInteractionUnlockNotify)]
	public sealed class PhantomInteractionUnlockNotify : IMessage<PhantomInteractionUnlockNotify>, IMessage, IEquatable<PhantomInteractionUnlockNotify>, IDeepCloneable<PhantomInteractionUnlockNotify>, IBufferMessage
	{
		// Token: 0x06011CFB RID: 72955 RVA: 0x0029AF05 File Offset: 0x00299105
		[NullableContext(1)]
		public static PhantomInteractionUnlockNotify Create()
		{
			return new PhantomInteractionUnlockNotify();
		}

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x06011CFC RID: 72956 RVA: 0x0029AF0C File Offset: 0x0029910C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x06011CFD RID: 72957 RVA: 0x0029AF0F File Offset: 0x0029910F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06011CFE RID: 72958 RVA: 0x0029AF16 File Offset: 0x00299116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionUnlockNotify()
		{
		}

		// Token: 0x06011CFF RID: 72959 RVA: 0x0029AF34 File Offset: 0x00299134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionUnlockNotify(PhantomInteractionUnlockNotify other) : this()
		{
			this.unlockIllustratedPhantoms_ = other.unlockIllustratedPhantoms_.Clone();
			this.equipedMonsterIds_ = other.equipedMonsterIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D00 RID: 72960 RVA: 0x0029AF6F File Offset: 0x0029916F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionUnlockNotify Clone()
		{
			return new PhantomInteractionUnlockNotify(this);
		}

		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x06011D01 RID: 72961 RVA: 0x0029AF77 File Offset: 0x00299177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UnlockIllustratedPhantom> UnlockIllustratedPhantoms
		{
			get
			{
				return this.unlockIllustratedPhantoms_;
			}
		}

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x06011D02 RID: 72962 RVA: 0x0029AF7F File Offset: 0x0029917F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipedMonsterIds
		{
			get
			{
				return this.equipedMonsterIds_;
			}
		}

		// Token: 0x06011D03 RID: 72963 RVA: 0x0029AF87 File Offset: 0x00299187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionUnlockNotify);
		}

		// Token: 0x06011D04 RID: 72964 RVA: 0x0029AF98 File Offset: 0x00299198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockIllustratedPhantoms_.Equals(other.unlockIllustratedPhantoms_) && this.equipedMonsterIds_.Equals(other.equipedMonsterIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D05 RID: 72965 RVA: 0x0029AFEC File Offset: 0x002991EC
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

		// Token: 0x06011D06 RID: 72966 RVA: 0x0029B02E File Offset: 0x0029922E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D07 RID: 72967 RVA: 0x0029B03B File Offset: 0x0029923B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D08 RID: 72968 RVA: 0x0029B044 File Offset: 0x00299244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockIllustratedPhantoms_.WriteTo(ref output, PhantomInteractionUnlockNotify._repeated_unlockIllustratedPhantoms_codec);
			this.equipedMonsterIds_.WriteTo(ref output, PhantomInteractionUnlockNotify._repeated_equipedMonsterIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D09 RID: 72969 RVA: 0x0029B07C File Offset: 0x0029927C
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

		// Token: 0x06011D0A RID: 72970 RVA: 0x0029B0C8 File Offset: 0x002992C8
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

		// Token: 0x06011D0B RID: 72971 RVA: 0x0029B107 File Offset: 0x00299307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D0C RID: 72972 RVA: 0x0029B110 File Offset: 0x00299310
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
				if (num != 82U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.equipedMonsterIds_.AddEntriesFrom(ref input, PhantomInteractionUnlockNotify._repeated_equipedMonsterIds_codec);
					}
				}
				else
				{
					this.unlockIllustratedPhantoms_.AddEntriesFrom(ref input, PhantomInteractionUnlockNotify._repeated_unlockIllustratedPhantoms_codec);
				}
			}
		}

		// Token: 0x04006FCD RID: 28621
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FCE RID: 28622
		public const int UnlockIllustratedPhantomsFieldNumber = 10;

		// Token: 0x04006FCF RID: 28623
		private static readonly FieldCodec<UnlockIllustratedPhantom> _repeated_unlockIllustratedPhantoms_codec = FieldCodec.ForMessage<UnlockIllustratedPhantom>(82U, UnlockIllustratedPhantom.Parser);

		// Token: 0x04006FD0 RID: 28624
		private readonly RepeatedField<UnlockIllustratedPhantom> unlockIllustratedPhantoms_ = new RepeatedField<UnlockIllustratedPhantom>();

		// Token: 0x04006FD1 RID: 28625
		public const int EquipedMonsterIdsFieldNumber = 14;

		// Token: 0x04006FD2 RID: 28626
		private static readonly FieldCodec<int> _repeated_equipedMonsterIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04006FD3 RID: 28627
		private readonly RepeatedField<int> equipedMonsterIds_ = new RepeatedField<int>();
	}
}
