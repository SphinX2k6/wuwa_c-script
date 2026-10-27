using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A56 RID: 2646
	[NetMessage(EMessageId.MotorFightRefreshCollectionRequest)]
	public sealed class MotorFightRefreshCollectionRequest : IMessage<MotorFightRefreshCollectionRequest>, IMessage, IEquatable<MotorFightRefreshCollectionRequest>, IDeepCloneable<MotorFightRefreshCollectionRequest>, IBufferMessage
	{
		// Token: 0x0600E6D5 RID: 59093 RVA: 0x0021B863 File Offset: 0x00219A63
		[NullableContext(1)]
		public static MotorFightRefreshCollectionRequest Create()
		{
			return new MotorFightRefreshCollectionRequest();
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x0600E6D6 RID: 59094 RVA: 0x0021B86A File Offset: 0x00219A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x0600E6D7 RID: 59095 RVA: 0x0021B86D File Offset: 0x00219A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshCollectionRequest.Descriptor;
			}
		}

		// Token: 0x0600E6D8 RID: 59096 RVA: 0x0021B874 File Offset: 0x00219A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionRequest()
		{
		}

		// Token: 0x0600E6D9 RID: 59097 RVA: 0x0021B87C File Offset: 0x00219A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionRequest(MotorFightRefreshCollectionRequest other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.bossId_ = other.bossId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E6DA RID: 59098 RVA: 0x0021B8B9 File Offset: 0x00219AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshCollectionRequest Clone()
		{
			return new MotorFightRefreshCollectionRequest(this);
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x0600E6DB RID: 59099 RVA: 0x0021B8C1 File Offset: 0x00219AC1
		// (set) Token: 0x0600E6DC RID: 59100 RVA: 0x0021B8C9 File Offset: 0x00219AC9
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

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x0600E6DD RID: 59101 RVA: 0x0021B8D2 File Offset: 0x00219AD2
		// (set) Token: 0x0600E6DE RID: 59102 RVA: 0x0021B8DA File Offset: 0x00219ADA
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

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x0600E6DF RID: 59103 RVA: 0x0021B8E3 File Offset: 0x00219AE3
		// (set) Token: 0x0600E6E0 RID: 59104 RVA: 0x0021B8EB File Offset: 0x00219AEB
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

		// Token: 0x0600E6E1 RID: 59105 RVA: 0x0021B8F4 File Offset: 0x00219AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshCollectionRequest);
		}

		// Token: 0x0600E6E2 RID: 59106 RVA: 0x0021B904 File Offset: 0x00219B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshCollectionRequest other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.BossId == other.BossId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6E3 RID: 59107 RVA: 0x0021B960 File Offset: 0x00219B60
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

		// Token: 0x0600E6E4 RID: 59108 RVA: 0x0021B9D1 File Offset: 0x00219BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E6E5 RID: 59109 RVA: 0x0021B9DE File Offset: 0x00219BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6E6 RID: 59110 RVA: 0x0021B9E8 File Offset: 0x00219BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this.BossId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.BossId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E6E7 RID: 59111 RVA: 0x0021BA60 File Offset: 0x00219C60
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

		// Token: 0x0600E6E8 RID: 59112 RVA: 0x0021BAD0 File Offset: 0x00219CD0
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

		// Token: 0x0600E6E9 RID: 59113 RVA: 0x0021BB34 File Offset: 0x00219D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6EA RID: 59114 RVA: 0x0021BB40 File Offset: 0x00219D40
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
				if (num != 24U)
				{
					if (num != 40U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.WaveGroupIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E1B RID: 24091
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E1C RID: 24092
		public const int SubLevelIndexFieldNumber = 5;

		// Token: 0x04005E1D RID: 24093
		private int subLevelIndex_;

		// Token: 0x04005E1E RID: 24094
		public const int WaveGroupIndexFieldNumber = 3;

		// Token: 0x04005E1F RID: 24095
		private int waveGroupIndex_;

		// Token: 0x04005E20 RID: 24096
		public const int BossIdFieldNumber = 10;

		// Token: 0x04005E21 RID: 24097
		private int bossId_;
	}
}
