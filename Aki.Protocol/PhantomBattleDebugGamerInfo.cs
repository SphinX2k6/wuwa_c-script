using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C68 RID: 3176
	public sealed class PhantomBattleDebugGamerInfo : IMessage<PhantomBattleDebugGamerInfo>, IMessage, IEquatable<PhantomBattleDebugGamerInfo>, IDeepCloneable<PhantomBattleDebugGamerInfo>, IBufferMessage
	{
		// Token: 0x060113D9 RID: 70617 RVA: 0x00286AF8 File Offset: 0x00284CF8
		[NullableContext(1)]
		public static PhantomBattleDebugGamerInfo Create()
		{
			return new PhantomBattleDebugGamerInfo();
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x060113DA RID: 70618 RVA: 0x00286AFF File Offset: 0x00284CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleDebugGamerInfo> Parser
		{
			get
			{
				return PhantomBattleDebugGamerInfo._parser;
			}
		}

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x060113DB RID: 70619 RVA: 0x00286B06 File Offset: 0x00284D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x060113DC RID: 70620 RVA: 0x00286B09 File Offset: 0x00284D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugGamerInfo.Descriptor;
			}
		}

		// Token: 0x060113DD RID: 70621 RVA: 0x00286B10 File Offset: 0x00284D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugGamerInfo()
		{
		}

		// Token: 0x060113DE RID: 70622 RVA: 0x00286B50 File Offset: 0x00284D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugGamerInfo(PhantomBattleDebugGamerInfo other) : this()
		{
			this.gamerIndex_ = other.gamerIndex_;
			this.phantomBattleDebugFighterInfos_ = other.phantomBattleDebugFighterInfos_.Clone();
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.libraryCardInfos_ = other.libraryCardInfos_.Clone();
			this.phantomBattleHandDebugCardInfos_ = other.phantomBattleHandDebugCardInfos_.Clone();
			this.libraryDebugCardInfos_ = other.libraryDebugCardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060113DF RID: 70623 RVA: 0x00286BD5 File Offset: 0x00284DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugGamerInfo Clone()
		{
			return new PhantomBattleDebugGamerInfo(this);
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x060113E0 RID: 70624 RVA: 0x00286BDD File Offset: 0x00284DDD
		// (set) Token: 0x060113E1 RID: 70625 RVA: 0x00286BE5 File Offset: 0x00284DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamerIndex
		{
			get
			{
				return this.gamerIndex_;
			}
			set
			{
				this.gamerIndex_ = value;
			}
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x060113E2 RID: 70626 RVA: 0x00286BEE File Offset: 0x00284DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleDebugFighterInfo> PhantomBattleDebugFighterInfos
		{
			get
			{
				return this.phantomBattleDebugFighterInfos_;
			}
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x060113E3 RID: 70627 RVA: 0x00286BF6 File Offset: 0x00284DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x060113E4 RID: 70628 RVA: 0x00286BFE File Offset: 0x00284DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> LibraryCardInfos
		{
			get
			{
				return this.libraryCardInfos_;
			}
		}

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x060113E5 RID: 70629 RVA: 0x00286C06 File Offset: 0x00284E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleDebugCardInfo> PhantomBattleHandDebugCardInfos
		{
			get
			{
				return this.phantomBattleHandDebugCardInfos_;
			}
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x060113E6 RID: 70630 RVA: 0x00286C0E File Offset: 0x00284E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleDebugCardInfo> LibraryDebugCardInfos
		{
			get
			{
				return this.libraryDebugCardInfos_;
			}
		}

		// Token: 0x060113E7 RID: 70631 RVA: 0x00286C16 File Offset: 0x00284E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugGamerInfo);
		}

		// Token: 0x060113E8 RID: 70632 RVA: 0x00286C24 File Offset: 0x00284E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugGamerInfo other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.phantomBattleDebugFighterInfos_.Equals(other.phantomBattleDebugFighterInfos_) && this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.libraryCardInfos_.Equals(other.libraryCardInfos_) && this.phantomBattleHandDebugCardInfos_.Equals(other.phantomBattleHandDebugCardInfos_) && this.libraryDebugCardInfos_.Equals(other.libraryDebugCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060113E9 RID: 70633 RVA: 0x00286CC8 File Offset: 0x00284EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamerIndex != 0)
			{
				num ^= this.GamerIndex.GetHashCode();
			}
			num ^= this.phantomBattleDebugFighterInfos_.GetHashCode();
			num ^= this.phantomBattleHandCardInfos_.GetHashCode();
			num ^= this.libraryCardInfos_.GetHashCode();
			num ^= this.phantomBattleHandDebugCardInfos_.GetHashCode();
			num ^= this.libraryDebugCardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060113EA RID: 70634 RVA: 0x00286D4D File Offset: 0x00284F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060113EB RID: 70635 RVA: 0x00286D5A File Offset: 0x00284F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060113EC RID: 70636 RVA: 0x00286D64 File Offset: 0x00284F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamerIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GamerIndex);
			}
			this.phantomBattleDebugFighterInfos_.WriteTo(ref output, PhantomBattleDebugGamerInfo._repeated_phantomBattleDebugFighterInfos_codec);
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleDebugGamerInfo._repeated_phantomBattleHandCardInfos_codec);
			this.libraryCardInfos_.WriteTo(ref output, PhantomBattleDebugGamerInfo._repeated_libraryCardInfos_codec);
			this.phantomBattleHandDebugCardInfos_.WriteTo(ref output, PhantomBattleDebugGamerInfo._repeated_phantomBattleHandDebugCardInfos_codec);
			this.libraryDebugCardInfos_.WriteTo(ref output, PhantomBattleDebugGamerInfo._repeated_libraryDebugCardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060113ED RID: 70637 RVA: 0x00286DF8 File Offset: 0x00284FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamerIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamerIndex);
			}
			num += this.phantomBattleDebugFighterInfos_.CalculateSize(PhantomBattleDebugGamerInfo._repeated_phantomBattleDebugFighterInfos_codec);
			num += this.phantomBattleHandCardInfos_.CalculateSize(PhantomBattleDebugGamerInfo._repeated_phantomBattleHandCardInfos_codec);
			num += this.libraryCardInfos_.CalculateSize(PhantomBattleDebugGamerInfo._repeated_libraryCardInfos_codec);
			num += this.phantomBattleHandDebugCardInfos_.CalculateSize(PhantomBattleDebugGamerInfo._repeated_phantomBattleHandDebugCardInfos_codec);
			num += this.libraryDebugCardInfos_.CalculateSize(PhantomBattleDebugGamerInfo._repeated_libraryDebugCardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060113EE RID: 70638 RVA: 0x00286E98 File Offset: 0x00285098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDebugGamerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamerIndex != 0)
			{
				this.GamerIndex = other.GamerIndex;
			}
			this.phantomBattleDebugFighterInfos_.Add(other.phantomBattleDebugFighterInfos_);
			this.phantomBattleHandCardInfos_.Add(other.phantomBattleHandCardInfos_);
			this.libraryCardInfos_.Add(other.libraryCardInfos_);
			this.phantomBattleHandDebugCardInfos_.Add(other.phantomBattleHandDebugCardInfos_);
			this.libraryDebugCardInfos_.Add(other.libraryDebugCardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060113EF RID: 70639 RVA: 0x00286F29 File Offset: 0x00285129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060113F0 RID: 70640 RVA: 0x00286F34 File Offset: 0x00285134
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.GamerIndex = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.phantomBattleDebugFighterInfos_.AddEntriesFrom(ref input, PhantomBattleDebugGamerInfo._repeated_phantomBattleDebugFighterInfos_codec);
						continue;
					}
					if (num == 26U)
					{
						this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleDebugGamerInfo._repeated_phantomBattleHandCardInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.libraryCardInfos_.AddEntriesFrom(ref input, PhantomBattleDebugGamerInfo._repeated_libraryCardInfos_codec);
						continue;
					}
					if (num == 42U)
					{
						this.phantomBattleHandDebugCardInfos_.AddEntriesFrom(ref input, PhantomBattleDebugGamerInfo._repeated_phantomBattleHandDebugCardInfos_codec);
						continue;
					}
					if (num == 50U)
					{
						this.libraryDebugCardInfos_.AddEntriesFrom(ref input, PhantomBattleDebugGamerInfo._repeated_libraryDebugCardInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006D77 RID: 28023
		private static readonly MessageParser<PhantomBattleDebugGamerInfo> _parser = new MessageParser<PhantomBattleDebugGamerInfo>(() => new PhantomBattleDebugGamerInfo());

		// Token: 0x04006D78 RID: 28024
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D79 RID: 28025
		public const int GamerIndexFieldNumber = 1;

		// Token: 0x04006D7A RID: 28026
		private int gamerIndex_;

		// Token: 0x04006D7B RID: 28027
		public const int PhantomBattleDebugFighterInfosFieldNumber = 2;

		// Token: 0x04006D7C RID: 28028
		private static readonly FieldCodec<PhantomBattleDebugFighterInfo> _repeated_phantomBattleDebugFighterInfos_codec = FieldCodec.ForMessage<PhantomBattleDebugFighterInfo>(18U, PhantomBattleDebugFighterInfo.Parser);

		// Token: 0x04006D7D RID: 28029
		private readonly RepeatedField<PhantomBattleDebugFighterInfo> phantomBattleDebugFighterInfos_ = new RepeatedField<PhantomBattleDebugFighterInfo>();

		// Token: 0x04006D7E RID: 28030
		public const int PhantomBattleHandCardInfosFieldNumber = 3;

		// Token: 0x04006D7F RID: 28031
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(26U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D80 RID: 28032
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D81 RID: 28033
		public const int LibraryCardInfosFieldNumber = 4;

		// Token: 0x04006D82 RID: 28034
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_libraryCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(34U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D83 RID: 28035
		private readonly RepeatedField<PhantomBattleHandCardInfo> libraryCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D84 RID: 28036
		public const int PhantomBattleHandDebugCardInfosFieldNumber = 5;

		// Token: 0x04006D85 RID: 28037
		private static readonly FieldCodec<PhantomBattleDebugCardInfo> _repeated_phantomBattleHandDebugCardInfos_codec = FieldCodec.ForMessage<PhantomBattleDebugCardInfo>(42U, PhantomBattleDebugCardInfo.Parser);

		// Token: 0x04006D86 RID: 28038
		private readonly RepeatedField<PhantomBattleDebugCardInfo> phantomBattleHandDebugCardInfos_ = new RepeatedField<PhantomBattleDebugCardInfo>();

		// Token: 0x04006D87 RID: 28039
		public const int LibraryDebugCardInfosFieldNumber = 6;

		// Token: 0x04006D88 RID: 28040
		private static readonly FieldCodec<PhantomBattleDebugCardInfo> _repeated_libraryDebugCardInfos_codec = FieldCodec.ForMessage<PhantomBattleDebugCardInfo>(50U, PhantomBattleDebugCardInfo.Parser);

		// Token: 0x04006D89 RID: 28041
		private readonly RepeatedField<PhantomBattleDebugCardInfo> libraryDebugCardInfos_ = new RepeatedField<PhantomBattleDebugCardInfo>();
	}
}
