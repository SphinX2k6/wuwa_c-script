using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B59 RID: 2905
	public sealed class NpcPhantomBattleCardAttrInfo : IMessage<NpcPhantomBattleCardAttrInfo>, IMessage, IEquatable<NpcPhantomBattleCardAttrInfo>, IDeepCloneable<NpcPhantomBattleCardAttrInfo>, IBufferMessage
	{
		// Token: 0x0600FC0A RID: 64522 RVA: 0x0024B9D7 File Offset: 0x00249BD7
		[NullableContext(1)]
		public static NpcPhantomBattleCardAttrInfo Create()
		{
			return new NpcPhantomBattleCardAttrInfo();
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600FC0B RID: 64523 RVA: 0x0024B9DE File Offset: 0x00249BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600FC0C RID: 64524 RVA: 0x0024B9E1 File Offset: 0x00249BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleCardAttrInfo.Descriptor;
			}
		}

		// Token: 0x0600FC0D RID: 64525 RVA: 0x0024B9E8 File Offset: 0x00249BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardAttrInfo()
		{
		}

		// Token: 0x0600FC0E RID: 64526 RVA: 0x0024B9FB File Offset: 0x00249BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardAttrInfo(NpcPhantomBattleCardAttrInfo other) : this()
		{
			this.cardFighterUId_ = other.cardFighterUId_;
			this.battleStatus_ = other.battleStatus_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC0F RID: 64527 RVA: 0x0024BA31 File Offset: 0x00249C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardAttrInfo Clone()
		{
			return new NpcPhantomBattleCardAttrInfo(this);
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600FC10 RID: 64528 RVA: 0x0024BA39 File Offset: 0x00249C39
		// (set) Token: 0x0600FC11 RID: 64529 RVA: 0x0024BA41 File Offset: 0x00249C41
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

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600FC12 RID: 64530 RVA: 0x0024BA4A File Offset: 0x00249C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleStatus
		{
			get
			{
				return this.battleStatus_;
			}
		}

		// Token: 0x0600FC13 RID: 64531 RVA: 0x0024BA52 File Offset: 0x00249C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleCardAttrInfo);
		}

		// Token: 0x0600FC14 RID: 64532 RVA: 0x0024BA60 File Offset: 0x00249C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleCardAttrInfo other)
		{
			return other != null && (other == this || (this.CardFighterUId == other.CardFighterUId && this.BattleStatus.Equals(other.BattleStatus) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC15 RID: 64533 RVA: 0x0024BAB0 File Offset: 0x00249CB0
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

		// Token: 0x0600FC16 RID: 64534 RVA: 0x0024BAFD File Offset: 0x00249CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC17 RID: 64535 RVA: 0x0024BB0A File Offset: 0x00249D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC18 RID: 64536 RVA: 0x0024BB14 File Offset: 0x00249D14
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

		// Token: 0x0600FC19 RID: 64537 RVA: 0x0024BB64 File Offset: 0x00249D64
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

		// Token: 0x0600FC1A RID: 64538 RVA: 0x0024BBB8 File Offset: 0x00249DB8
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

		// Token: 0x0600FC1B RID: 64539 RVA: 0x0024BC05 File Offset: 0x00249E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC1C RID: 64540 RVA: 0x0024BC10 File Offset: 0x00249E10
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

		// Token: 0x04006500 RID: 25856
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006501 RID: 25857
		public const int CardFighterUIdFieldNumber = 1;

		// Token: 0x04006502 RID: 25858
		private int cardFighterUId_;

		// Token: 0x04006503 RID: 25859
		public const int BattleStatusFieldNumber = 2;

		// Token: 0x04006504 RID: 25860
		private static readonly MapField<int, int>.Codec _map_battleStatus_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04006505 RID: 25861
		private readonly MapField<int, int> battleStatus_ = new MapField<int, int>();
	}
}
