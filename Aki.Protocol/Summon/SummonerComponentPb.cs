using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x020016F6 RID: 5878
	public sealed class SummonerComponentPb : IMessage<SummonerComponentPb>, IMessage, IEquatable<SummonerComponentPb>, IDeepCloneable<SummonerComponentPb>, IBufferMessage
	{
		// Token: 0x0601D612 RID: 120338 RVA: 0x00440667 File Offset: 0x0043E867
		[NullableContext(1)]
		public static SummonerComponentPb Create()
		{
			return new SummonerComponentPb();
		}

		// Token: 0x17006361 RID: 25441
		// (get) Token: 0x0601D613 RID: 120339 RVA: 0x0044066E File Offset: 0x0043E86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006362 RID: 25442
		// (get) Token: 0x0601D614 RID: 120340 RVA: 0x00440671 File Offset: 0x0043E871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonerComponentPb.Descriptor;
			}
		}

		// Token: 0x0601D615 RID: 120341 RVA: 0x00440678 File Offset: 0x0043E878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonerComponentPb()
		{
		}

		// Token: 0x0601D616 RID: 120342 RVA: 0x00440680 File Offset: 0x0043E880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonerComponentPb(SummonerComponentPb other) : this()
		{
			this.summonerId_ = other.summonerId_;
			this.summonCfgId_ = other.summonCfgId_;
			this.summonSkillId_ = other.summonSkillId_;
			this.playerId_ = other.playerId_;
			this.type_ = other.type_;
			this.avatarCfgId_ = other.avatarCfgId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D617 RID: 120343 RVA: 0x004406EC File Offset: 0x0043E8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonerComponentPb Clone()
		{
			return new SummonerComponentPb(this);
		}

		// Token: 0x17006363 RID: 25443
		// (get) Token: 0x0601D618 RID: 120344 RVA: 0x004406F4 File Offset: 0x0043E8F4
		// (set) Token: 0x0601D619 RID: 120345 RVA: 0x004406FC File Offset: 0x0043E8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonerId
		{
			get
			{
				return this.summonerId_;
			}
			set
			{
				this.summonerId_ = value;
			}
		}

		// Token: 0x17006364 RID: 25444
		// (get) Token: 0x0601D61A RID: 120346 RVA: 0x00440705 File Offset: 0x0043E905
		// (set) Token: 0x0601D61B RID: 120347 RVA: 0x0044070D File Offset: 0x0043E90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SummonCfgId
		{
			get
			{
				return this.summonCfgId_;
			}
			set
			{
				this.summonCfgId_ = value;
			}
		}

		// Token: 0x17006365 RID: 25445
		// (get) Token: 0x0601D61C RID: 120348 RVA: 0x00440716 File Offset: 0x0043E916
		// (set) Token: 0x0601D61D RID: 120349 RVA: 0x0044071E File Offset: 0x0043E91E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SummonSkillId
		{
			get
			{
				return this.summonSkillId_;
			}
			set
			{
				this.summonSkillId_ = value;
			}
		}

		// Token: 0x17006366 RID: 25446
		// (get) Token: 0x0601D61E RID: 120350 RVA: 0x00440727 File Offset: 0x0043E927
		// (set) Token: 0x0601D61F RID: 120351 RVA: 0x0044072F File Offset: 0x0043E92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17006367 RID: 25447
		// (get) Token: 0x0601D620 RID: 120352 RVA: 0x00440738 File Offset: 0x0043E938
		// (set) Token: 0x0601D621 RID: 120353 RVA: 0x00440740 File Offset: 0x0043E940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ESummonType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17006368 RID: 25448
		// (get) Token: 0x0601D622 RID: 120354 RVA: 0x00440749 File Offset: 0x0043E949
		// (set) Token: 0x0601D623 RID: 120355 RVA: 0x00440751 File Offset: 0x0043E951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AvatarCfgId
		{
			get
			{
				return this.avatarCfgId_;
			}
			set
			{
				this.avatarCfgId_ = value;
			}
		}

		// Token: 0x0601D624 RID: 120356 RVA: 0x0044075A File Offset: 0x0043E95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonerComponentPb);
		}

		// Token: 0x0601D625 RID: 120357 RVA: 0x00440768 File Offset: 0x0043E968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonerComponentPb other)
		{
			return other != null && (other == this || (this.SummonerId == other.SummonerId && this.SummonCfgId == other.SummonCfgId && this.SummonSkillId == other.SummonSkillId && this.PlayerId == other.PlayerId && this.Type == other.Type && this.AvatarCfgId == other.AvatarCfgId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D626 RID: 120358 RVA: 0x004407F4 File Offset: 0x0043E9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonerId != 0L)
			{
				num ^= this.SummonerId.GetHashCode();
			}
			if (this.SummonCfgId != 0)
			{
				num ^= this.SummonCfgId.GetHashCode();
			}
			if (this.SummonSkillId != 0)
			{
				num ^= this.SummonSkillId.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Type != ESummonType.Default)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.AvatarCfgId != 0)
			{
				num ^= this.AvatarCfgId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D627 RID: 120359 RVA: 0x004408B6 File Offset: 0x0043EAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D628 RID: 120360 RVA: 0x004408C3 File Offset: 0x0043EAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D629 RID: 120361 RVA: 0x004408CC File Offset: 0x0043EACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonerId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SummonerId);
			}
			if (this.SummonCfgId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SummonCfgId);
			}
			if (this.SummonSkillId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SummonSkillId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Type != ESummonType.Default)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Type);
			}
			if (this.AvatarCfgId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.AvatarCfgId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D62A RID: 120362 RVA: 0x00440994 File Offset: 0x0043EB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonerId);
			}
			if (this.SummonCfgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SummonCfgId);
			}
			if (this.SummonSkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SummonSkillId);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Type != ESummonType.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.AvatarCfgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AvatarCfgId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D62B RID: 120363 RVA: 0x00440A4C File Offset: 0x0043EC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonerComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonerId != 0L)
			{
				this.SummonerId = other.SummonerId;
			}
			if (other.SummonCfgId != 0)
			{
				this.SummonCfgId = other.SummonCfgId;
			}
			if (other.SummonSkillId != 0)
			{
				this.SummonSkillId = other.SummonSkillId;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Type != ESummonType.Default)
			{
				this.Type = other.Type;
			}
			if (other.AvatarCfgId != 0)
			{
				this.AvatarCfgId = other.AvatarCfgId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D62C RID: 120364 RVA: 0x00440AEC File Offset: 0x0043ECEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D62D RID: 120365 RVA: 0x00440AF8 File Offset: 0x0043ECF8
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.SummonerId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.SummonCfgId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.SummonSkillId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Type = (ESummonType)input.ReadEnum();
						continue;
					}
					if (num == 48U)
					{
						this.AvatarCfgId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C70C RID: 50956
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C70D RID: 50957
		public const int SummonerIdFieldNumber = 1;

		// Token: 0x0400C70E RID: 50958
		private long summonerId_;

		// Token: 0x0400C70F RID: 50959
		public const int SummonCfgIdFieldNumber = 2;

		// Token: 0x0400C710 RID: 50960
		private int summonCfgId_;

		// Token: 0x0400C711 RID: 50961
		public const int SummonSkillIdFieldNumber = 3;

		// Token: 0x0400C712 RID: 50962
		private int summonSkillId_;

		// Token: 0x0400C713 RID: 50963
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x0400C714 RID: 50964
		private int playerId_;

		// Token: 0x0400C715 RID: 50965
		public const int TypeFieldNumber = 5;

		// Token: 0x0400C716 RID: 50966
		private ESummonType type_;

		// Token: 0x0400C717 RID: 50967
		public const int AvatarCfgIdFieldNumber = 6;

		// Token: 0x0400C718 RID: 50968
		private int avatarCfgId_;
	}
}
