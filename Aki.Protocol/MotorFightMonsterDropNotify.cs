using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4A RID: 2634
	[NetMessage(EMessageId.MotorFightMonsterDropNotify)]
	public sealed class MotorFightMonsterDropNotify : IMessage<MotorFightMonsterDropNotify>, IMessage, IEquatable<MotorFightMonsterDropNotify>, IDeepCloneable<MotorFightMonsterDropNotify>, IBufferMessage
	{
		// Token: 0x0600E5E5 RID: 58853 RVA: 0x0021996D File Offset: 0x00217B6D
		[NullableContext(1)]
		public static MotorFightMonsterDropNotify Create()
		{
			return new MotorFightMonsterDropNotify();
		}

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x0600E5E6 RID: 58854 RVA: 0x00219974 File Offset: 0x00217B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x0600E5E7 RID: 58855 RVA: 0x00219977 File Offset: 0x00217B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightMonsterDropNotify.Descriptor;
			}
		}

		// Token: 0x0600E5E8 RID: 58856 RVA: 0x0021997E File Offset: 0x00217B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightMonsterDropNotify()
		{
		}

		// Token: 0x0600E5E9 RID: 58857 RVA: 0x00219988 File Offset: 0x00217B88
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

		// Token: 0x0600E5EA RID: 58858 RVA: 0x002199DC File Offset: 0x00217BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightMonsterDropNotify Clone()
		{
			return new MotorFightMonsterDropNotify(this);
		}

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x0600E5EB RID: 58859 RVA: 0x002199E4 File Offset: 0x00217BE4
		// (set) Token: 0x0600E5EC RID: 58860 RVA: 0x002199EC File Offset: 0x00217BEC
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

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x0600E5ED RID: 58861 RVA: 0x002199F5 File Offset: 0x00217BF5
		// (set) Token: 0x0600E5EE RID: 58862 RVA: 0x002199FD File Offset: 0x00217BFD
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

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x0600E5EF RID: 58863 RVA: 0x00219A06 File Offset: 0x00217C06
		// (set) Token: 0x0600E5F0 RID: 58864 RVA: 0x00219A0E File Offset: 0x00217C0E
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

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x0600E5F1 RID: 58865 RVA: 0x00219A17 File Offset: 0x00217C17
		// (set) Token: 0x0600E5F2 RID: 58866 RVA: 0x00219A1F File Offset: 0x00217C1F
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

		// Token: 0x0600E5F3 RID: 58867 RVA: 0x00219A28 File Offset: 0x00217C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightMonsterDropNotify);
		}

		// Token: 0x0600E5F4 RID: 58868 RVA: 0x00219A38 File Offset: 0x00217C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightMonsterDropNotify other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.MonsterId == other.MonsterId && this.BuffGateId == other.BuffGateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5F5 RID: 58869 RVA: 0x00219AA4 File Offset: 0x00217CA4
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

		// Token: 0x0600E5F6 RID: 58870 RVA: 0x00219B2E File Offset: 0x00217D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E5F7 RID: 58871 RVA: 0x00219B3B File Offset: 0x00217D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5F8 RID: 58872 RVA: 0x00219B44 File Offset: 0x00217D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this.MonsterId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MonsterId);
			}
			if (this.BuffGateId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.BuffGateId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5F9 RID: 58873 RVA: 0x00219BD8 File Offset: 0x00217DD8
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

		// Token: 0x0600E5FA RID: 58874 RVA: 0x00219C60 File Offset: 0x00217E60
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

		// Token: 0x0600E5FB RID: 58875 RVA: 0x00219CD8 File Offset: 0x00217ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5FC RID: 58876 RVA: 0x00219CE4 File Offset: 0x00217EE4
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
				if (num <= 80U)
				{
					if (num == 40U)
					{
						this.SubLevelIndex = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.WaveGroupIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.MonsterId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.BuffGateId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005DDF RID: 24031
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DE0 RID: 24032
		public const int SubLevelIndexFieldNumber = 5;

		// Token: 0x04005DE1 RID: 24033
		private int subLevelIndex_;

		// Token: 0x04005DE2 RID: 24034
		public const int WaveGroupIndexFieldNumber = 10;

		// Token: 0x04005DE3 RID: 24035
		private int waveGroupIndex_;

		// Token: 0x04005DE4 RID: 24036
		public const int MonsterIdFieldNumber = 11;

		// Token: 0x04005DE5 RID: 24037
		private int monsterId_;

		// Token: 0x04005DE6 RID: 24038
		public const int BuffGateIdFieldNumber = 13;

		// Token: 0x04005DE7 RID: 24039
		private int buffGateId_;
	}
}
