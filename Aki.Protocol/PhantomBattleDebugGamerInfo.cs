using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C78 RID: 3192
	public sealed class PhantomBattleDebugGamerInfo : IMessage<PhantomBattleDebugGamerInfo>, IMessage, IEquatable<PhantomBattleDebugGamerInfo>, IDeepCloneable<PhantomBattleDebugGamerInfo>, IBufferMessage
	{
		// Token: 0x060114D9 RID: 70873 RVA: 0x00288868 File Offset: 0x00286A68
		[NullableContext(1)]
		public static PhantomBattleDebugGamerInfo Create()
		{
			return new PhantomBattleDebugGamerInfo();
		}

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x060114DA RID: 70874 RVA: 0x0028886F File Offset: 0x00286A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleDebugGamerInfo> Parser
		{
			get
			{
				return PhantomBattleDebugGamerInfo._parser;
			}
		}

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x060114DB RID: 70875 RVA: 0x00288876 File Offset: 0x00286A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x060114DC RID: 70876 RVA: 0x00288879 File Offset: 0x00286A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugGamerInfo.Descriptor;
			}
		}

		// Token: 0x060114DD RID: 70877 RVA: 0x00288880 File Offset: 0x00286A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugGamerInfo()
		{
		}

		// Token: 0x060114DE RID: 70878 RVA: 0x002888C0 File Offset: 0x00286AC0
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

		// Token: 0x060114DF RID: 70879 RVA: 0x00288945 File Offset: 0x00286B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugGamerInfo Clone()
		{
			return new PhantomBattleDebugGamerInfo(this);
		}

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x060114E0 RID: 70880 RVA: 0x0028894D File Offset: 0x00286B4D
		// (set) Token: 0x060114E1 RID: 70881 RVA: 0x00288955 File Offset: 0x00286B55
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

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x060114E2 RID: 70882 RVA: 0x0028895E File Offset: 0x00286B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleDebugFighterInfo> PhantomBattleDebugFighterInfos
		{
			get
			{
				return this.phantomBattleDebugFighterInfos_;
			}
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x060114E3 RID: 70883 RVA: 0x00288966 File Offset: 0x00286B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x060114E4 RID: 70884 RVA: 0x0028896E File Offset: 0x00286B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> LibraryCardInfos
		{
			get
			{
				return this.libraryCardInfos_;
			}
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x060114E5 RID: 70885 RVA: 0x00288976 File Offset: 0x00286B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleDebugCardInfo> PhantomBattleHandDebugCardInfos
		{
			get
			{
				return this.phantomBattleHandDebugCardInfos_;
			}
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x060114E6 RID: 70886 RVA: 0x0028897E File Offset: 0x00286B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleDebugCardInfo> LibraryDebugCardInfos
		{
			get
			{
				return this.libraryDebugCardInfos_;
			}
		}

		// Token: 0x060114E7 RID: 70887 RVA: 0x00288986 File Offset: 0x00286B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugGamerInfo);
		}

		// Token: 0x060114E8 RID: 70888 RVA: 0x00288994 File Offset: 0x00286B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugGamerInfo other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.phantomBattleDebugFighterInfos_.Equals(other.phantomBattleDebugFighterInfos_) && this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.libraryCardInfos_.Equals(other.libraryCardInfos_) && this.phantomBattleHandDebugCardInfos_.Equals(other.phantomBattleHandDebugCardInfos_) && this.libraryDebugCardInfos_.Equals(other.libraryDebugCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060114E9 RID: 70889 RVA: 0x00288A38 File Offset: 0x00286C38
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

		// Token: 0x060114EA RID: 70890 RVA: 0x00288ABD File Offset: 0x00286CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060114EB RID: 70891 RVA: 0x00288ACA File Offset: 0x00286CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060114EC RID: 70892 RVA: 0x00288AD4 File Offset: 0x00286CD4
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

		// Token: 0x060114ED RID: 70893 RVA: 0x00288B68 File Offset: 0x00286D68
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

		// Token: 0x060114EE RID: 70894 RVA: 0x00288C08 File Offset: 0x00286E08
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

		// Token: 0x060114EF RID: 70895 RVA: 0x00288C99 File Offset: 0x00286E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060114F0 RID: 70896 RVA: 0x00288CA4 File Offset: 0x00286EA4
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

		// Token: 0x04006D63 RID: 28003
		private static readonly MessageParser<PhantomBattleDebugGamerInfo> _parser = new MessageParser<PhantomBattleDebugGamerInfo>(() => new PhantomBattleDebugGamerInfo());

		// Token: 0x04006D64 RID: 28004
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D65 RID: 28005
		public const int GamerIndexFieldNumber = 1;

		// Token: 0x04006D66 RID: 28006
		private int gamerIndex_;

		// Token: 0x04006D67 RID: 28007
		public const int PhantomBattleDebugFighterInfosFieldNumber = 2;

		// Token: 0x04006D68 RID: 28008
		private static readonly FieldCodec<PhantomBattleDebugFighterInfo> _repeated_phantomBattleDebugFighterInfos_codec = FieldCodec.ForMessage<PhantomBattleDebugFighterInfo>(18U, PhantomBattleDebugFighterInfo.Parser);

		// Token: 0x04006D69 RID: 28009
		private readonly RepeatedField<PhantomBattleDebugFighterInfo> phantomBattleDebugFighterInfos_ = new RepeatedField<PhantomBattleDebugFighterInfo>();

		// Token: 0x04006D6A RID: 28010
		public const int PhantomBattleHandCardInfosFieldNumber = 3;

		// Token: 0x04006D6B RID: 28011
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(26U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D6C RID: 28012
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D6D RID: 28013
		public const int LibraryCardInfosFieldNumber = 4;

		// Token: 0x04006D6E RID: 28014
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_libraryCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(34U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D6F RID: 28015
		private readonly RepeatedField<PhantomBattleHandCardInfo> libraryCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D70 RID: 28016
		public const int PhantomBattleHandDebugCardInfosFieldNumber = 5;

		// Token: 0x04006D71 RID: 28017
		private static readonly FieldCodec<PhantomBattleDebugCardInfo> _repeated_phantomBattleHandDebugCardInfos_codec = FieldCodec.ForMessage<PhantomBattleDebugCardInfo>(42U, PhantomBattleDebugCardInfo.Parser);

		// Token: 0x04006D72 RID: 28018
		private readonly RepeatedField<PhantomBattleDebugCardInfo> phantomBattleHandDebugCardInfos_ = new RepeatedField<PhantomBattleDebugCardInfo>();

		// Token: 0x04006D73 RID: 28019
		public const int LibraryDebugCardInfosFieldNumber = 6;

		// Token: 0x04006D74 RID: 28020
		private static readonly FieldCodec<PhantomBattleDebugCardInfo> _repeated_libraryDebugCardInfos_codec = FieldCodec.ForMessage<PhantomBattleDebugCardInfo>(50U, PhantomBattleDebugCardInfo.Parser);

		// Token: 0x04006D75 RID: 28021
		private readonly RepeatedField<PhantomBattleDebugCardInfo> libraryDebugCardInfos_ = new RepeatedField<PhantomBattleDebugCardInfo>();
	}
}
