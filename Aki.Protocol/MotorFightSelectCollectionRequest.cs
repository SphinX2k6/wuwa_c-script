using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A55 RID: 2645
	[NetMessage(EMessageId.MotorFightSelectCollectionRequest)]
	public sealed class MotorFightSelectCollectionRequest : IMessage<MotorFightSelectCollectionRequest>, IMessage, IEquatable<MotorFightSelectCollectionRequest>, IDeepCloneable<MotorFightSelectCollectionRequest>, IBufferMessage
	{
		// Token: 0x0600E720 RID: 59168 RVA: 0x0021CCCD File Offset: 0x0021AECD
		[NullableContext(1)]
		public static MotorFightSelectCollectionRequest Create()
		{
			return new MotorFightSelectCollectionRequest();
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x0600E721 RID: 59169 RVA: 0x0021CCD4 File Offset: 0x0021AED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0600E722 RID: 59170 RVA: 0x0021CCD7 File Offset: 0x0021AED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSelectCollectionRequest.Descriptor;
			}
		}

		// Token: 0x0600E723 RID: 59171 RVA: 0x0021CCDE File Offset: 0x0021AEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionRequest()
		{
		}

		// Token: 0x0600E724 RID: 59172 RVA: 0x0021CCE8 File Offset: 0x0021AEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionRequest(MotorFightSelectCollectionRequest other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.bossId_ = other.bossId_;
			this.pos_ = other.pos_;
			this.playerHp_ = other.playerHp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E725 RID: 59173 RVA: 0x0021CD48 File Offset: 0x0021AF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionRequest Clone()
		{
			return new MotorFightSelectCollectionRequest(this);
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0600E726 RID: 59174 RVA: 0x0021CD50 File Offset: 0x0021AF50
		// (set) Token: 0x0600E727 RID: 59175 RVA: 0x0021CD58 File Offset: 0x0021AF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelIndex
		{
			get
			{
				return this.subLevelIndex_;
			}
			set
			{
				this.subLevelIndex_ = value;
			}
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x0600E728 RID: 59176 RVA: 0x0021CD61 File Offset: 0x0021AF61
		// (set) Token: 0x0600E729 RID: 59177 RVA: 0x0021CD69 File Offset: 0x0021AF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveGroupIndex
		{
			get
			{
				return this.waveGroupIndex_;
			}
			set
			{
				this.waveGroupIndex_ = value;
			}
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x0600E72A RID: 59178 RVA: 0x0021CD72 File Offset: 0x0021AF72
		// (set) Token: 0x0600E72B RID: 59179 RVA: 0x0021CD7A File Offset: 0x0021AF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossId
		{
			get
			{
				return this.bossId_;
			}
			set
			{
				this.bossId_ = value;
			}
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x0600E72C RID: 59180 RVA: 0x0021CD83 File Offset: 0x0021AF83
		// (set) Token: 0x0600E72D RID: 59181 RVA: 0x0021CD8B File Offset: 0x0021AF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectionPos Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x0600E72E RID: 59182 RVA: 0x0021CD94 File Offset: 0x0021AF94
		// (set) Token: 0x0600E72F RID: 59183 RVA: 0x0021CD9C File Offset: 0x0021AF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerHp
		{
			get
			{
				return this.playerHp_;
			}
			set
			{
				this.playerHp_ = value;
			}
		}

		// Token: 0x0600E730 RID: 59184 RVA: 0x0021CDA5 File Offset: 0x0021AFA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSelectCollectionRequest);
		}

		// Token: 0x0600E731 RID: 59185 RVA: 0x0021CDB4 File Offset: 0x0021AFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSelectCollectionRequest other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.BossId == other.BossId && this.Pos == other.Pos && this.PlayerHp == other.PlayerHp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E732 RID: 59186 RVA: 0x0021CE30 File Offset: 0x0021B030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelIndex != 0)
			{
				num ^= this.SubLevelIndex.GetHashCode();
			}
			if (this.WaveGroupIndex != 0)
			{
				num ^= this.WaveGroupIndex.GetHashCode();
			}
			if (this.BossId != 0)
			{
				num ^= this.BossId.GetHashCode();
			}
			if (this.Pos != MotorFightCollectionPos.First)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.PlayerHp != 0)
			{
				num ^= this.PlayerHp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E733 RID: 59187 RVA: 0x0021CED9 File Offset: 0x0021B0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E734 RID: 59188 RVA: 0x0021CEE6 File Offset: 0x0021B0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E735 RID: 59189 RVA: 0x0021CEF0 File Offset: 0x0021B0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerHp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerHp);
			}
			if (this.Pos != MotorFightCollectionPos.First)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Pos);
			}
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this.BossId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.BossId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E736 RID: 59190 RVA: 0x0021CFA0 File Offset: 0x0021B1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveGroupIndex);
			}
			if (this.BossId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossId);
			}
			if (this.Pos != MotorFightCollectionPos.First)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Pos);
			}
			if (this.PlayerHp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerHp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E737 RID: 59191 RVA: 0x0021D040 File Offset: 0x0021B240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSelectCollectionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelIndex != 0)
			{
				this.SubLevelIndex = other.SubLevelIndex;
			}
			if (other.WaveGroupIndex != 0)
			{
				this.WaveGroupIndex = other.WaveGroupIndex;
			}
			if (other.BossId != 0)
			{
				this.BossId = other.BossId;
			}
			if (other.Pos != MotorFightCollectionPos.First)
			{
				this.Pos = other.Pos;
			}
			if (other.PlayerHp != 0)
			{
				this.PlayerHp = other.PlayerHp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E738 RID: 59192 RVA: 0x0021D0CC File Offset: 0x0021B2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E739 RID: 59193 RVA: 0x0021D0D8 File Offset: 0x0021B2D8
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
					if (num == 16U)
					{
						this.PlayerHp = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Pos = (MotorFightCollectionPos)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.WaveGroupIndex = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.SubLevelIndex = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.BossId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005EA4 RID: 24228
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EA5 RID: 24229
		public const int SubLevelIndexFieldNumber = 10;

		// Token: 0x04005EA6 RID: 24230
		private int subLevelIndex_;

		// Token: 0x04005EA7 RID: 24231
		public const int WaveGroupIndexFieldNumber = 9;

		// Token: 0x04005EA8 RID: 24232
		private int waveGroupIndex_;

		// Token: 0x04005EA9 RID: 24233
		public const int BossIdFieldNumber = 13;

		// Token: 0x04005EAA RID: 24234
		private int bossId_;

		// Token: 0x04005EAB RID: 24235
		public const int PosFieldNumber = 3;

		// Token: 0x04005EAC RID: 24236
		private MotorFightCollectionPos pos_;

		// Token: 0x04005EAD RID: 24237
		public const int PlayerHpFieldNumber = 2;

		// Token: 0x04005EAE RID: 24238
		private int playerHp_;
	}
}
