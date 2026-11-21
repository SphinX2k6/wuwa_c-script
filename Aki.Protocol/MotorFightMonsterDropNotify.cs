using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A39 RID: 2617
	[NetMessage(EMessageId.MotorFightMonsterDropNotify)]
	public sealed class MotorFightMonsterDropNotify : IMessage<MotorFightMonsterDropNotify>, IMessage, IEquatable<MotorFightMonsterDropNotify>, IDeepCloneable<MotorFightMonsterDropNotify>, IBufferMessage
	{
		// Token: 0x0600E4CB RID: 58571 RVA: 0x00217779 File Offset: 0x00215979
		[NullableContext(1)]
		public static MotorFightMonsterDropNotify Create()
		{
			return new MotorFightMonsterDropNotify();
		}

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x0600E4CC RID: 58572 RVA: 0x00217780 File Offset: 0x00215980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x0600E4CD RID: 58573 RVA: 0x00217783 File Offset: 0x00215983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightMonsterDropNotify.Descriptor;
			}
		}

		// Token: 0x0600E4CE RID: 58574 RVA: 0x0021778A File Offset: 0x0021598A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightMonsterDropNotify()
		{
		}

		// Token: 0x0600E4CF RID: 58575 RVA: 0x00217794 File Offset: 0x00215994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightMonsterDropNotify(MotorFightMonsterDropNotify other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.monsterId_ = other.monsterId_;
			this.buffGateId_ = other.buffGateId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4D0 RID: 58576 RVA: 0x002177E8 File Offset: 0x002159E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightMonsterDropNotify Clone()
		{
			return new MotorFightMonsterDropNotify(this);
		}

		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x0600E4D1 RID: 58577 RVA: 0x002177F0 File Offset: 0x002159F0
		// (set) Token: 0x0600E4D2 RID: 58578 RVA: 0x002177F8 File Offset: 0x002159F8
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

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x0600E4D3 RID: 58579 RVA: 0x00217801 File Offset: 0x00215A01
		// (set) Token: 0x0600E4D4 RID: 58580 RVA: 0x00217809 File Offset: 0x00215A09
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

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x0600E4D5 RID: 58581 RVA: 0x00217812 File Offset: 0x00215A12
		// (set) Token: 0x0600E4D6 RID: 58582 RVA: 0x0021781A File Offset: 0x00215A1A
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

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x0600E4D7 RID: 58583 RVA: 0x00217823 File Offset: 0x00215A23
		// (set) Token: 0x0600E4D8 RID: 58584 RVA: 0x0021782B File Offset: 0x00215A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffGateId
		{
			get
			{
				return this.buffGateId_;
			}
			set
			{
				this.buffGateId_ = value;
			}
		}

		// Token: 0x0600E4D9 RID: 58585 RVA: 0x00217834 File Offset: 0x00215A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightMonsterDropNotify);
		}

		// Token: 0x0600E4DA RID: 58586 RVA: 0x00217844 File Offset: 0x00215A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightMonsterDropNotify other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.MonsterId == other.MonsterId && this.BuffGateId == other.BuffGateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4DB RID: 58587 RVA: 0x002178B0 File Offset: 0x00215AB0
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
			if (this.MonsterId != 0)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.BuffGateId != 0)
			{
				num ^= this.BuffGateId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E4DC RID: 58588 RVA: 0x0021793A File Offset: 0x00215B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E4DD RID: 58589 RVA: 0x00217947 File Offset: 0x00215B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E4DE RID: 58590 RVA: 0x00217950 File Offset: 0x00215B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MonsterId);
			}
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this.BuffGateId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.BuffGateId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E4DF RID: 58591 RVA: 0x002179E4 File Offset: 0x00215BE4
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
			if (this.MonsterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterId);
			}
			if (this.BuffGateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffGateId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E4E0 RID: 58592 RVA: 0x00217A6C File Offset: 0x00215C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightMonsterDropNotify other)
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
			if (other.MonsterId != 0)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.BuffGateId != 0)
			{
				this.BuffGateId = other.BuffGateId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E4E1 RID: 58593 RVA: 0x00217AE4 File Offset: 0x00215CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E4E2 RID: 58594 RVA: 0x00217AF0 File Offset: 0x00215CF0
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
				if (num <= 88U)
				{
					if (num == 32U)
					{
						this.MonsterId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.SubLevelIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.WaveGroupIndex = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.BuffGateId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005DE8 RID: 24040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DE9 RID: 24041
		public const int SubLevelIndexFieldNumber = 11;

		// Token: 0x04005DEA RID: 24042
		private int subLevelIndex_;

		// Token: 0x04005DEB RID: 24043
		public const int WaveGroupIndexFieldNumber = 14;

		// Token: 0x04005DEC RID: 24044
		private int waveGroupIndex_;

		// Token: 0x04005DED RID: 24045
		public const int MonsterIdFieldNumber = 4;

		// Token: 0x04005DEE RID: 24046
		private int monsterId_;

		// Token: 0x04005DEF RID: 24047
		public const int BuffGateIdFieldNumber = 15;

		// Token: 0x04005DF0 RID: 24048
		private int buffGateId_;
	}
}
