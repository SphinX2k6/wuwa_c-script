using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000880 RID: 2176
	public sealed class KurotatoEndlessLevelInfo : IMessage<KurotatoEndlessLevelInfo>, IMessage, IEquatable<KurotatoEndlessLevelInfo>, IDeepCloneable<KurotatoEndlessLevelInfo>, IBufferMessage
	{
		// Token: 0x0600C1E3 RID: 49635 RVA: 0x001CC996 File Offset: 0x001CAB96
		[NullableContext(1)]
		public static KurotatoEndlessLevelInfo Create()
		{
			return new KurotatoEndlessLevelInfo();
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x0600C1E4 RID: 49636 RVA: 0x001CC99D File Offset: 0x001CAB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x0600C1E5 RID: 49637 RVA: 0x001CC9A0 File Offset: 0x001CABA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndlessLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600C1E6 RID: 49638 RVA: 0x001CC9A7 File Offset: 0x001CABA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndlessLevelInfo()
		{
		}

		// Token: 0x0600C1E7 RID: 49639 RVA: 0x001CC9BC File Offset: 0x001CABBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndlessLevelInfo(KurotatoEndlessLevelInfo other) : this()
		{
			this.finishWave_ = other.finishWave_;
			this.totalKillCount_ = other.totalKillCount_;
			this.passRoleIds_ = other.passRoleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1E8 RID: 49640 RVA: 0x001CCA09 File Offset: 0x001CAC09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndlessLevelInfo Clone()
		{
			return new KurotatoEndlessLevelInfo(this);
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x0600C1E9 RID: 49641 RVA: 0x001CCA11 File Offset: 0x001CAC11
		// (set) Token: 0x0600C1EA RID: 49642 RVA: 0x001CCA19 File Offset: 0x001CAC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FinishWave
		{
			get
			{
				return this.finishWave_;
			}
			set
			{
				this.finishWave_ = value;
			}
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x0600C1EB RID: 49643 RVA: 0x001CCA22 File Offset: 0x001CAC22
		// (set) Token: 0x0600C1EC RID: 49644 RVA: 0x001CCA2A File Offset: 0x001CAC2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalKillCount
		{
			get
			{
				return this.totalKillCount_;
			}
			set
			{
				this.totalKillCount_ = value;
			}
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x0600C1ED RID: 49645 RVA: 0x001CCA33 File Offset: 0x001CAC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PassRoleIds
		{
			get
			{
				return this.passRoleIds_;
			}
		}

		// Token: 0x0600C1EE RID: 49646 RVA: 0x001CCA3B File Offset: 0x001CAC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndlessLevelInfo);
		}

		// Token: 0x0600C1EF RID: 49647 RVA: 0x001CCA4C File Offset: 0x001CAC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndlessLevelInfo other)
		{
			return other != null && (other == this || (this.FinishWave == other.FinishWave && this.TotalKillCount == other.TotalKillCount && this.passRoleIds_.Equals(other.passRoleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C1F0 RID: 49648 RVA: 0x001CCAAC File Offset: 0x001CACAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FinishWave != 0)
			{
				num ^= this.FinishWave.GetHashCode();
			}
			if (this.TotalKillCount != 0)
			{
				num ^= this.TotalKillCount.GetHashCode();
			}
			num ^= this.passRoleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C1F1 RID: 49649 RVA: 0x001CCB12 File Offset: 0x001CAD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C1F2 RID: 49650 RVA: 0x001CCB1F File Offset: 0x001CAD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x001CCB28 File Offset: 0x001CAD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FinishWave != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FinishWave);
			}
			if (this.TotalKillCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalKillCount);
			}
			this.passRoleIds_.WriteTo(ref output, KurotatoEndlessLevelInfo._repeated_passRoleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1F4 RID: 49652 RVA: 0x001CCB94 File Offset: 0x001CAD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FinishWave != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FinishWave);
			}
			if (this.TotalKillCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalKillCount);
			}
			num += this.passRoleIds_.CalculateSize(KurotatoEndlessLevelInfo._repeated_passRoleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C1F5 RID: 49653 RVA: 0x001CCC00 File Offset: 0x001CAE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoEndlessLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FinishWave != 0)
			{
				this.FinishWave = other.FinishWave;
			}
			if (other.TotalKillCount != 0)
			{
				this.TotalKillCount = other.TotalKillCount;
			}
			this.passRoleIds_.Add(other.passRoleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1F6 RID: 49654 RVA: 0x001CCC61 File Offset: 0x001CAE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1F7 RID: 49655 RVA: 0x001CCC6C File Offset: 0x001CAE6C
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
						this.FinishWave = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TotalKillCount = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.passRoleIds_.AddEntriesFrom(ref input, KurotatoEndlessLevelInfo._repeated_passRoleIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400545B RID: 21595
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400545C RID: 21596
		public const int FinishWaveFieldNumber = 1;

		// Token: 0x0400545D RID: 21597
		private int finishWave_;

		// Token: 0x0400545E RID: 21598
		public const int TotalKillCountFieldNumber = 2;

		// Token: 0x0400545F RID: 21599
		private int totalKillCount_;

		// Token: 0x04005460 RID: 21600
		public const int PassRoleIdsFieldNumber = 3;

		// Token: 0x04005461 RID: 21601
		private static readonly FieldCodec<int> _repeated_passRoleIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005462 RID: 21602
		private readonly RepeatedField<int> passRoleIds_ = new RepeatedField<int>();
	}
}
