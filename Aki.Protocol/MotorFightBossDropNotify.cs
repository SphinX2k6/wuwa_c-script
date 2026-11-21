using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A28 RID: 2600
	[NetMessage(EMessageId.MotorFightBossDropNotify)]
	public sealed class MotorFightBossDropNotify : IMessage<MotorFightBossDropNotify>, IMessage, IEquatable<MotorFightBossDropNotify>, IDeepCloneable<MotorFightBossDropNotify>, IBufferMessage
	{
		// Token: 0x0600E367 RID: 58215 RVA: 0x00214881 File Offset: 0x00212A81
		[NullableContext(1)]
		public static MotorFightBossDropNotify Create()
		{
			return new MotorFightBossDropNotify();
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0600E368 RID: 58216 RVA: 0x00214888 File Offset: 0x00212A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x0600E369 RID: 58217 RVA: 0x0021488B File Offset: 0x00212A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightBossDropNotify.Descriptor;
			}
		}

		// Token: 0x0600E36A RID: 58218 RVA: 0x00214892 File Offset: 0x00212A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossDropNotify()
		{
		}

		// Token: 0x0600E36B RID: 58219 RVA: 0x002148A8 File Offset: 0x00212AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossDropNotify(MotorFightBossDropNotify other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.bossId_ = other.bossId_;
			this.drops_ = other.drops_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E36C RID: 58220 RVA: 0x00214901 File Offset: 0x00212B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossDropNotify Clone()
		{
			return new MotorFightBossDropNotify(this);
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x0600E36D RID: 58221 RVA: 0x00214909 File Offset: 0x00212B09
		// (set) Token: 0x0600E36E RID: 58222 RVA: 0x00214911 File Offset: 0x00212B11
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

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x0600E36F RID: 58223 RVA: 0x0021491A File Offset: 0x00212B1A
		// (set) Token: 0x0600E370 RID: 58224 RVA: 0x00214922 File Offset: 0x00212B22
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

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x0600E371 RID: 58225 RVA: 0x0021492B File Offset: 0x00212B2B
		// (set) Token: 0x0600E372 RID: 58226 RVA: 0x00214933 File Offset: 0x00212B33
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

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x0600E373 RID: 58227 RVA: 0x0021493C File Offset: 0x00212B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightCollectionDrop> Drops
		{
			get
			{
				return this.drops_;
			}
		}

		// Token: 0x0600E374 RID: 58228 RVA: 0x00214944 File Offset: 0x00212B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightBossDropNotify);
		}

		// Token: 0x0600E375 RID: 58229 RVA: 0x00214954 File Offset: 0x00212B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightBossDropNotify other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.BossId == other.BossId && this.drops_.Equals(other.drops_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E376 RID: 58230 RVA: 0x002149C4 File Offset: 0x00212BC4
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
			num ^= this.drops_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E377 RID: 58231 RVA: 0x00214A43 File Offset: 0x00212C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E378 RID: 58232 RVA: 0x00214A50 File Offset: 0x00212C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E379 RID: 58233 RVA: 0x00214A5C File Offset: 0x00212C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.WaveGroupIndex);
			}
			this.drops_.WriteTo(ref output, MotorFightBossDropNotify._repeated_drops_codec);
			if (this.BossId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.BossId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E37A RID: 58234 RVA: 0x00214AE4 File Offset: 0x00212CE4
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
			num += this.drops_.CalculateSize(MotorFightBossDropNotify._repeated_drops_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E37B RID: 58235 RVA: 0x00214B68 File Offset: 0x00212D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightBossDropNotify other)
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
			this.drops_.Add(other.drops_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E37C RID: 58236 RVA: 0x00214BDD File Offset: 0x00212DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E37D RID: 58237 RVA: 0x00214BE8 File Offset: 0x00212DE8
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
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.SubLevelIndex = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.WaveGroupIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.drops_.AddEntriesFrom(ref input, MotorFightBossDropNotify._repeated_drops_codec);
						continue;
					}
					if (num == 72U)
					{
						this.BossId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005D85 RID: 23941
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D86 RID: 23942
		public const int SubLevelIndexFieldNumber = 2;

		// Token: 0x04005D87 RID: 23943
		private int subLevelIndex_;

		// Token: 0x04005D88 RID: 23944
		public const int WaveGroupIndexFieldNumber = 4;

		// Token: 0x04005D89 RID: 23945
		private int waveGroupIndex_;

		// Token: 0x04005D8A RID: 23946
		public const int BossIdFieldNumber = 9;

		// Token: 0x04005D8B RID: 23947
		private int bossId_;

		// Token: 0x04005D8C RID: 23948
		public const int DropsFieldNumber = 8;

		// Token: 0x04005D8D RID: 23949
		private static readonly FieldCodec<MotorFightCollectionDrop> _repeated_drops_codec = FieldCodec.ForMessage<MotorFightCollectionDrop>(66U, MotorFightCollectionDrop.Parser);

		// Token: 0x04005D8E RID: 23950
		private readonly RepeatedField<MotorFightCollectionDrop> drops_ = new RepeatedField<MotorFightCollectionDrop>();
	}
}
