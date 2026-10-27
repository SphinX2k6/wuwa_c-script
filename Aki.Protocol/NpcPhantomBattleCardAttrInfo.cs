using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B69 RID: 2921
	public sealed class NpcPhantomBattleCardAttrInfo : IMessage<NpcPhantomBattleCardAttrInfo>, IMessage, IEquatable<NpcPhantomBattleCardAttrInfo>, IDeepCloneable<NpcPhantomBattleCardAttrInfo>, IBufferMessage
	{
		// Token: 0x0600FD0E RID: 64782 RVA: 0x0024D8A7 File Offset: 0x0024BAA7
		[NullableContext(1)]
		public static NpcPhantomBattleCardAttrInfo Create()
		{
			return new NpcPhantomBattleCardAttrInfo();
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600FD0F RID: 64783 RVA: 0x0024D8AE File Offset: 0x0024BAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600FD10 RID: 64784 RVA: 0x0024D8B1 File Offset: 0x0024BAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleCardAttrInfo.Descriptor;
			}
		}

		// Token: 0x0600FD11 RID: 64785 RVA: 0x0024D8B8 File Offset: 0x0024BAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardAttrInfo()
		{
		}

		// Token: 0x0600FD12 RID: 64786 RVA: 0x0024D8CB File Offset: 0x0024BACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardAttrInfo(NpcPhantomBattleCardAttrInfo other) : this()
		{
			this.cardFighterUId_ = other.cardFighterUId_;
			this.battleStatus_ = other.battleStatus_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FD13 RID: 64787 RVA: 0x0024D901 File Offset: 0x0024BB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardAttrInfo Clone()
		{
			return new NpcPhantomBattleCardAttrInfo(this);
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0600FD14 RID: 64788 RVA: 0x0024D909 File Offset: 0x0024BB09
		// (set) Token: 0x0600FD15 RID: 64789 RVA: 0x0024D911 File Offset: 0x0024BB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardFighterUId
		{
			get
			{
				return this.cardFighterUId_;
			}
			set
			{
				this.cardFighterUId_ = value;
			}
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0600FD16 RID: 64790 RVA: 0x0024D91A File Offset: 0x0024BB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleStatus
		{
			get
			{
				return this.battleStatus_;
			}
		}

		// Token: 0x0600FD17 RID: 64791 RVA: 0x0024D922 File Offset: 0x0024BB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleCardAttrInfo);
		}

		// Token: 0x0600FD18 RID: 64792 RVA: 0x0024D930 File Offset: 0x0024BB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleCardAttrInfo other)
		{
			return other != null && (other == this || (this.CardFighterUId == other.CardFighterUId && this.BattleStatus.Equals(other.BattleStatus) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD19 RID: 64793 RVA: 0x0024D980 File Offset: 0x0024BB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardFighterUId != 0)
			{
				num ^= this.CardFighterUId.GetHashCode();
			}
			num ^= this.BattleStatus.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FD1A RID: 64794 RVA: 0x0024D9CD File Offset: 0x0024BBCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD1B RID: 64795 RVA: 0x0024D9DA File Offset: 0x0024BBDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD1C RID: 64796 RVA: 0x0024D9E4 File Offset: 0x0024BBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardFighterUId);
			}
			this.battleStatus_.WriteTo(ref output, NpcPhantomBattleCardAttrInfo._map_battleStatus_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FD1D RID: 64797 RVA: 0x0024DA34 File Offset: 0x0024BC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardFighterUId);
			}
			num += this.battleStatus_.CalculateSize(NpcPhantomBattleCardAttrInfo._map_battleStatus_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FD1E RID: 64798 RVA: 0x0024DA88 File Offset: 0x0024BC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleCardAttrInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardFighterUId != 0)
			{
				this.CardFighterUId = other.CardFighterUId;
			}
			this.battleStatus_.MergeFrom(other.battleStatus_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FD1F RID: 64799 RVA: 0x0024DAD5 File Offset: 0x0024BCD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD20 RID: 64800 RVA: 0x0024DAE0 File Offset: 0x0024BCE0
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.battleStatus_.AddEntriesFrom(ref input, NpcPhantomBattleCardAttrInfo._map_battleStatus_codec);
					}
				}
				else
				{
					this.CardFighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040064F0 RID: 25840
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064F1 RID: 25841
		public const int CardFighterUIdFieldNumber = 1;

		// Token: 0x040064F2 RID: 25842
		private int cardFighterUId_;

		// Token: 0x040064F3 RID: 25843
		public const int BattleStatusFieldNumber = 2;

		// Token: 0x040064F4 RID: 25844
		private static readonly MapField<int, int>.Codec _map_battleStatus_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040064F5 RID: 25845
		private readonly MapField<int, int> battleStatus_ = new MapField<int, int>();
	}
}
