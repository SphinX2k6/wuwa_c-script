using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001488 RID: 5256
	public sealed class UnlockIllustratedPhantom : IMessage<UnlockIllustratedPhantom>, IMessage, IEquatable<UnlockIllustratedPhantom>, IDeepCloneable<UnlockIllustratedPhantom>, IBufferMessage
	{
		// Token: 0x0601BCFC RID: 113916 RVA: 0x00405BCD File Offset: 0x00403DCD
		[NullableContext(1)]
		public static UnlockIllustratedPhantom Create()
		{
			return new UnlockIllustratedPhantom();
		}

		// Token: 0x17005DC1 RID: 24001
		// (get) Token: 0x0601BCFD RID: 113917 RVA: 0x00405BD4 File Offset: 0x00403DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockIllustratedPhantom> Parser
		{
			get
			{
				return UnlockIllustratedPhantom._parser;
			}
		}

		// Token: 0x17005DC2 RID: 24002
		// (get) Token: 0x0601BCFE RID: 113918 RVA: 0x00405BDB File Offset: 0x00403DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DC3 RID: 24003
		// (get) Token: 0x0601BCFF RID: 113919 RVA: 0x00405BDE File Offset: 0x00403DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockIllustratedPhantom.Descriptor;
			}
		}

		// Token: 0x0601BD00 RID: 113920 RVA: 0x00405BE5 File Offset: 0x00403DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockIllustratedPhantom()
		{
		}

		// Token: 0x0601BD01 RID: 113921 RVA: 0x00405BF8 File Offset: 0x00403DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockIllustratedPhantom(UnlockIllustratedPhantom other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.skinIds_ = other.skinIds_.Clone();
			this.equpiedSkin_ = other.equpiedSkin_;
			this.isSpecial_ = other.isSpecial_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD02 RID: 113922 RVA: 0x00405C51 File Offset: 0x00403E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockIllustratedPhantom Clone()
		{
			return new UnlockIllustratedPhantom(this);
		}

		// Token: 0x17005DC4 RID: 24004
		// (get) Token: 0x0601BD03 RID: 113923 RVA: 0x00405C59 File Offset: 0x00403E59
		// (set) Token: 0x0601BD04 RID: 113924 RVA: 0x00405C61 File Offset: 0x00403E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17005DC5 RID: 24005
		// (get) Token: 0x0601BD05 RID: 113925 RVA: 0x00405C6A File Offset: 0x00403E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x17005DC6 RID: 24006
		// (get) Token: 0x0601BD06 RID: 113926 RVA: 0x00405C72 File Offset: 0x00403E72
		// (set) Token: 0x0601BD07 RID: 113927 RVA: 0x00405C7A File Offset: 0x00403E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EqupiedSkin
		{
			get
			{
				return this.equpiedSkin_;
			}
			set
			{
				this.equpiedSkin_ = value;
			}
		}

		// Token: 0x17005DC7 RID: 24007
		// (get) Token: 0x0601BD08 RID: 113928 RVA: 0x00405C83 File Offset: 0x00403E83
		// (set) Token: 0x0601BD09 RID: 113929 RVA: 0x00405C8B File Offset: 0x00403E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSpecial
		{
			get
			{
				return this.isSpecial_;
			}
			set
			{
				this.isSpecial_ = value;
			}
		}

		// Token: 0x0601BD0A RID: 113930 RVA: 0x00405C94 File Offset: 0x00403E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockIllustratedPhantom);
		}

		// Token: 0x0601BD0B RID: 113931 RVA: 0x00405CA4 File Offset: 0x00403EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockIllustratedPhantom other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.skinIds_.Equals(other.skinIds_) && this.EqupiedSkin == other.EqupiedSkin && this.IsSpecial == other.IsSpecial && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD0C RID: 113932 RVA: 0x00405D14 File Offset: 0x00403F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			num ^= this.skinIds_.GetHashCode();
			if (this.EqupiedSkin != 0)
			{
				num ^= this.EqupiedSkin.GetHashCode();
			}
			if (this.IsSpecial)
			{
				num ^= this.IsSpecial.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BD0D RID: 113933 RVA: 0x00405D93 File Offset: 0x00403F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD0E RID: 113934 RVA: 0x00405DA0 File Offset: 0x00403FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD0F RID: 113935 RVA: 0x00405DAC File Offset: 0x00403FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MonsterId);
			}
			this.skinIds_.WriteTo(ref output, UnlockIllustratedPhantom._repeated_skinIds_codec);
			if (this.EqupiedSkin != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EqupiedSkin);
			}
			if (this.IsSpecial)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSpecial);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BD10 RID: 113936 RVA: 0x00405E34 File Offset: 0x00404034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterId);
			}
			num += this.skinIds_.CalculateSize(UnlockIllustratedPhantom._repeated_skinIds_codec);
			if (this.EqupiedSkin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EqupiedSkin);
			}
			if (this.IsSpecial)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BD11 RID: 113937 RVA: 0x00405EAC File Offset: 0x004040AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockIllustratedPhantom other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0)
			{
				this.MonsterId = other.MonsterId;
			}
			this.skinIds_.Add(other.skinIds_);
			if (other.EqupiedSkin != 0)
			{
				this.EqupiedSkin = other.EqupiedSkin;
			}
			if (other.IsSpecial)
			{
				this.IsSpecial = other.IsSpecial;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BD12 RID: 113938 RVA: 0x00405F21 File Offset: 0x00404121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD13 RID: 113939 RVA: 0x00405F2C File Offset: 0x0040412C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.MonsterId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 24U)
					{
						this.EqupiedSkin = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsSpecial = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.skinIds_.AddEntriesFrom(ref input, UnlockIllustratedPhantom._repeated_skinIds_codec);
			}
		}

		// Token: 0x0400A002 RID: 40962
		private static readonly MessageParser<UnlockIllustratedPhantom> _parser = new MessageParser<UnlockIllustratedPhantom>(() => new UnlockIllustratedPhantom());

		// Token: 0x0400A003 RID: 40963
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A004 RID: 40964
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x0400A005 RID: 40965
		private int monsterId_;

		// Token: 0x0400A006 RID: 40966
		public const int SkinIdsFieldNumber = 2;

		// Token: 0x0400A007 RID: 40967
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400A008 RID: 40968
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();

		// Token: 0x0400A009 RID: 40969
		public const int EqupiedSkinFieldNumber = 3;

		// Token: 0x0400A00A RID: 40970
		private int equpiedSkin_;

		// Token: 0x0400A00B RID: 40971
		public const int IsSpecialFieldNumber = 4;

		// Token: 0x0400A00C RID: 40972
		private bool isSpecial_;
	}
}
