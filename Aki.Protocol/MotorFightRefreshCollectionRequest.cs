using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A45 RID: 2629
	[NetMessage(EMessageId.MotorFightRefreshCollectionRequest)]
	public sealed class MotorFightRefreshCollectionRequest : IMessage<MotorFightRefreshCollectionRequest>, IMessage, IEquatable<MotorFightRefreshCollectionRequest>, IDeepCloneable<MotorFightRefreshCollectionRequest>, IBufferMessage
	{
		// Token: 0x0600E5BB RID: 58811 RVA: 0x0021966F File Offset: 0x0021786F
		[NullableContext(1)]
		public static MotorFightRefreshCollectionRequest Create()
		{
			return new MotorFightRefreshCollectionRequest();
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x0600E5BC RID: 58812 RVA: 0x00219676 File Offset: 0x00217876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x0600E5BD RID: 58813 RVA: 0x00219679 File Offset: 0x00217879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshCollectionRequest.Descriptor;
			}
		}

		// Token: 0x0600E5BE RID: 58814 RVA: 0x00219680 File Offset: 0x00217880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionRequest()
		{
		}

		// Token: 0x0600E5BF RID: 58815 RVA: 0x00219688 File Offset: 0x00217888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionRequest(MotorFightRefreshCollectionRequest other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.bossId_ = other.bossId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5C0 RID: 58816 RVA: 0x002196C5 File Offset: 0x002178C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionRequest Clone()
		{
			return new MotorFightRefreshCollectionRequest(this);
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x0600E5C1 RID: 58817 RVA: 0x002196CD File Offset: 0x002178CD
		// (set) Token: 0x0600E5C2 RID: 58818 RVA: 0x002196D5 File Offset: 0x002178D5
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

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x0600E5C3 RID: 58819 RVA: 0x002196DE File Offset: 0x002178DE
		// (set) Token: 0x0600E5C4 RID: 58820 RVA: 0x002196E6 File Offset: 0x002178E6
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

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x0600E5C5 RID: 58821 RVA: 0x002196EF File Offset: 0x002178EF
		// (set) Token: 0x0600E5C6 RID: 58822 RVA: 0x002196F7 File Offset: 0x002178F7
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

		// Token: 0x0600E5C7 RID: 58823 RVA: 0x00219700 File Offset: 0x00217900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshCollectionRequest);
		}

		// Token: 0x0600E5C8 RID: 58824 RVA: 0x00219710 File Offset: 0x00217910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshCollectionRequest other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.BossId == other.BossId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5C9 RID: 58825 RVA: 0x0021976C File Offset: 0x0021796C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E5CA RID: 58826 RVA: 0x002197DD File Offset: 0x002179DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E5CB RID: 58827 RVA: 0x002197EA File Offset: 0x002179EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5CC RID: 58828 RVA: 0x002197F4 File Offset: 0x002179F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this.BossId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.BossId);
			}
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5CD RID: 58829 RVA: 0x0021986C File Offset: 0x00217A6C
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E5CE RID: 58830 RVA: 0x002198DC File Offset: 0x00217ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRefreshCollectionRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E5CF RID: 58831 RVA: 0x00219940 File Offset: 0x00217B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5D0 RID: 58832 RVA: 0x0021994C File Offset: 0x00217B4C
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
				if (num != 16U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.WaveGroupIndex = input.ReadInt32();
						}
					}
					else
					{
						this.BossId = input.ReadInt32();
					}
				}
				else
				{
					this.SubLevelIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E24 RID: 24100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E25 RID: 24101
		public const int SubLevelIndexFieldNumber = 2;

		// Token: 0x04005E26 RID: 24102
		private int subLevelIndex_;

		// Token: 0x04005E27 RID: 24103
		public const int WaveGroupIndexFieldNumber = 14;

		// Token: 0x04005E28 RID: 24104
		private int waveGroupIndex_;

		// Token: 0x04005E29 RID: 24105
		public const int BossIdFieldNumber = 12;

		// Token: 0x04005E2A RID: 24106
		private int bossId_;
	}
}
