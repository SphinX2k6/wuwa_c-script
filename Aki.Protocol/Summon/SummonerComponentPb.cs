using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x0200167A RID: 5754
	public sealed class SummonerComponentPb : IMessage<SummonerComponentPb>, IMessage, IEquatable<SummonerComponentPb>, IDeepCloneable<SummonerComponentPb>, IBufferMessage
	{
		// Token: 0x0601CB47 RID: 117575 RVA: 0x00424A47 File Offset: 0x00422C47
		[NullableContext(1)]
		public static SummonerComponentPb Create()
		{
			return new SummonerComponentPb();
		}

		// Token: 0x170060BE RID: 24766
		// (get) Token: 0x0601CB48 RID: 117576 RVA: 0x00424A4E File Offset: 0x00422C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060BF RID: 24767
		// (get) Token: 0x0601CB49 RID: 117577 RVA: 0x00424A51 File Offset: 0x00422C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonerComponentPb.Descriptor;
			}
		}

		// Token: 0x0601CB4A RID: 117578 RVA: 0x00424A58 File Offset: 0x00422C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonerComponentPb()
		{
		}

		// Token: 0x0601CB4B RID: 117579 RVA: 0x00424A60 File Offset: 0x00422C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonerComponentPb(SummonerComponentPb other) : this()
		{
			this.summonerId_ = other.summonerId_;
			this.summonCfgId_ = other.summonCfgId_;
			this.summonSkillId_ = other.summonSkillId_;
			this.playerId_ = other.playerId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB4C RID: 117580 RVA: 0x00424AC0 File Offset: 0x00422CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonerComponentPb Clone()
		{
			return new SummonerComponentPb(this);
		}

		// Token: 0x170060C0 RID: 24768
		// (get) Token: 0x0601CB4D RID: 117581 RVA: 0x00424AC8 File Offset: 0x00422CC8
		// (set) Token: 0x0601CB4E RID: 117582 RVA: 0x00424AD0 File Offset: 0x00422CD0
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

		// Token: 0x170060C1 RID: 24769
		// (get) Token: 0x0601CB4F RID: 117583 RVA: 0x00424AD9 File Offset: 0x00422CD9
		// (set) Token: 0x0601CB50 RID: 117584 RVA: 0x00424AE1 File Offset: 0x00422CE1
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

		// Token: 0x170060C2 RID: 24770
		// (get) Token: 0x0601CB51 RID: 117585 RVA: 0x00424AEA File Offset: 0x00422CEA
		// (set) Token: 0x0601CB52 RID: 117586 RVA: 0x00424AF2 File Offset: 0x00422CF2
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

		// Token: 0x170060C3 RID: 24771
		// (get) Token: 0x0601CB53 RID: 117587 RVA: 0x00424AFB File Offset: 0x00422CFB
		// (set) Token: 0x0601CB54 RID: 117588 RVA: 0x00424B03 File Offset: 0x00422D03
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

		// Token: 0x170060C4 RID: 24772
		// (get) Token: 0x0601CB55 RID: 117589 RVA: 0x00424B0C File Offset: 0x00422D0C
		// (set) Token: 0x0601CB56 RID: 117590 RVA: 0x00424B14 File Offset: 0x00422D14
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

		// Token: 0x0601CB57 RID: 117591 RVA: 0x00424B1D File Offset: 0x00422D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonerComponentPb);
		}

		// Token: 0x0601CB58 RID: 117592 RVA: 0x00424B2C File Offset: 0x00422D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonerComponentPb other)
		{
			return other != null && (other == this || (this.SummonerId == other.SummonerId && this.SummonCfgId == other.SummonCfgId && this.SummonSkillId == other.SummonSkillId && this.PlayerId == other.PlayerId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB59 RID: 117593 RVA: 0x00424BA8 File Offset: 0x00422DA8
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CB5A RID: 117594 RVA: 0x00424C51 File Offset: 0x00422E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB5B RID: 117595 RVA: 0x00424C5E File Offset: 0x00422E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB5C RID: 117596 RVA: 0x00424C68 File Offset: 0x00422E68
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB5D RID: 117597 RVA: 0x00424D14 File Offset: 0x00422F14
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CB5E RID: 117598 RVA: 0x00424DB4 File Offset: 0x00422FB4
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CB5F RID: 117599 RVA: 0x00424E40 File Offset: 0x00423040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB60 RID: 117600 RVA: 0x00424E4C File Offset: 0x0042304C
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
						this.SummonerId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.SummonCfgId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.SummonSkillId = input.ReadInt32();
						continue;
					}
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
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C1E3 RID: 49635
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C1E4 RID: 49636
		public const int SummonerIdFieldNumber = 1;

		// Token: 0x0400C1E5 RID: 49637
		private long summonerId_;

		// Token: 0x0400C1E6 RID: 49638
		public const int SummonCfgIdFieldNumber = 2;

		// Token: 0x0400C1E7 RID: 49639
		private int summonCfgId_;

		// Token: 0x0400C1E8 RID: 49640
		public const int SummonSkillIdFieldNumber = 3;

		// Token: 0x0400C1E9 RID: 49641
		private int summonSkillId_;

		// Token: 0x0400C1EA RID: 49642
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x0400C1EB RID: 49643
		private int playerId_;

		// Token: 0x0400C1EC RID: 49644
		public const int TypeFieldNumber = 5;

		// Token: 0x0400C1ED RID: 49645
		private ESummonType type_;
	}
}
