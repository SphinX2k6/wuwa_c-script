using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132F RID: 4911
	public sealed class SurvivorsChallengeInfo : IMessage<SurvivorsChallengeInfo>, IMessage, IEquatable<SurvivorsChallengeInfo>, IDeepCloneable<SurvivorsChallengeInfo>, IBufferMessage
	{
		// Token: 0x0601A2DF RID: 107231 RVA: 0x003D0DA1 File Offset: 0x003CEFA1
		[NullableContext(1)]
		public static SurvivorsChallengeInfo Create()
		{
			return new SurvivorsChallengeInfo();
		}

		// Token: 0x170058A7 RID: 22695
		// (get) Token: 0x0601A2E0 RID: 107232 RVA: 0x003D0DA8 File Offset: 0x003CEFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SurvivorsChallengeInfo> Parser
		{
			get
			{
				return SurvivorsChallengeInfo._parser;
			}
		}

		// Token: 0x170058A8 RID: 22696
		// (get) Token: 0x0601A2E1 RID: 107233 RVA: 0x003D0DAF File Offset: 0x003CEFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058A9 RID: 22697
		// (get) Token: 0x0601A2E2 RID: 107234 RVA: 0x003D0DB2 File Offset: 0x003CEFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsChallengeInfo.Descriptor;
			}
		}

		// Token: 0x0601A2E3 RID: 107235 RVA: 0x003D0DB9 File Offset: 0x003CEFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsChallengeInfo()
		{
		}

		// Token: 0x0601A2E4 RID: 107236 RVA: 0x003D0DC4 File Offset: 0x003CEFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsChallengeInfo(SurvivorsChallengeInfo other) : this()
		{
			this.levelId_ = other.levelId_;
			this.openTime_ = other.openTime_;
			this.normalModeInfos_ = ((other.normalModeInfos_ != null) ? other.normalModeInfos_.Clone() : null);
			this.infiniteModeInfos_ = ((other.infiniteModeInfos_ != null) ? other.infiniteModeInfos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A2E5 RID: 107237 RVA: 0x003D0E38 File Offset: 0x003CF038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsChallengeInfo Clone()
		{
			return new SurvivorsChallengeInfo(this);
		}

		// Token: 0x170058AA RID: 22698
		// (get) Token: 0x0601A2E6 RID: 107238 RVA: 0x003D0E40 File Offset: 0x003CF040
		// (set) Token: 0x0601A2E7 RID: 107239 RVA: 0x003D0E48 File Offset: 0x003CF048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170058AB RID: 22699
		// (get) Token: 0x0601A2E8 RID: 107240 RVA: 0x003D0E51 File Offset: 0x003CF051
		// (set) Token: 0x0601A2E9 RID: 107241 RVA: 0x003D0E59 File Offset: 0x003CF059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpenTime
		{
			get
			{
				return this.openTime_;
			}
			set
			{
				this.openTime_ = value;
			}
		}

		// Token: 0x170058AC RID: 22700
		// (get) Token: 0x0601A2EA RID: 107242 RVA: 0x003D0E62 File Offset: 0x003CF062
		// (set) Token: 0x0601A2EB RID: 107243 RVA: 0x003D0E6A File Offset: 0x003CF06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModeInfo NormalModeInfos
		{
			get
			{
				return this.normalModeInfos_;
			}
			set
			{
				this.normalModeInfos_ = value;
			}
		}

		// Token: 0x170058AD RID: 22701
		// (get) Token: 0x0601A2EC RID: 107244 RVA: 0x003D0E73 File Offset: 0x003CF073
		// (set) Token: 0x0601A2ED RID: 107245 RVA: 0x003D0E7B File Offset: 0x003CF07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModeInfo InfiniteModeInfos
		{
			get
			{
				return this.infiniteModeInfos_;
			}
			set
			{
				this.infiniteModeInfos_ = value;
			}
		}

		// Token: 0x0601A2EE RID: 107246 RVA: 0x003D0E84 File Offset: 0x003CF084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsChallengeInfo);
		}

		// Token: 0x0601A2EF RID: 107247 RVA: 0x003D0E94 File Offset: 0x003CF094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsChallengeInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.OpenTime == other.OpenTime && object.Equals(this.NormalModeInfos, other.NormalModeInfos) && object.Equals(this.InfiniteModeInfos, other.InfiniteModeInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A2F0 RID: 107248 RVA: 0x003D0F08 File Offset: 0x003CF108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.OpenTime != 0L)
			{
				num ^= this.OpenTime.GetHashCode();
			}
			if (this.normalModeInfos_ != null)
			{
				num ^= this.NormalModeInfos.GetHashCode();
			}
			if (this.infiniteModeInfos_ != null)
			{
				num ^= this.InfiniteModeInfos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A2F1 RID: 107249 RVA: 0x003D0F8C File Offset: 0x003CF18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A2F2 RID: 107250 RVA: 0x003D0F99 File Offset: 0x003CF199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A2F3 RID: 107251 RVA: 0x003D0FA4 File Offset: 0x003CF1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.OpenTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.OpenTime);
			}
			if (this.normalModeInfos_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.NormalModeInfos);
			}
			if (this.infiniteModeInfos_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.InfiniteModeInfos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A2F4 RID: 107252 RVA: 0x003D1034 File Offset: 0x003CF234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.OpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenTime);
			}
			if (this.normalModeInfos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NormalModeInfos);
			}
			if (this.infiniteModeInfos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InfiniteModeInfos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A2F5 RID: 107253 RVA: 0x003D10BC File Offset: 0x003CF2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.OpenTime != 0L)
			{
				this.OpenTime = other.OpenTime;
			}
			if (other.normalModeInfos_ != null)
			{
				if (this.normalModeInfos_ == null)
				{
					this.NormalModeInfos = new ModeInfo();
				}
				this.NormalModeInfos.MergeFrom(other.NormalModeInfos);
			}
			if (other.infiniteModeInfos_ != null)
			{
				if (this.infiniteModeInfos_ == null)
				{
					this.InfiniteModeInfos = new ModeInfo();
				}
				this.InfiniteModeInfos.MergeFrom(other.InfiniteModeInfos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A2F6 RID: 107254 RVA: 0x003D1164 File Offset: 0x003CF364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A2F7 RID: 107255 RVA: 0x003D1170 File Offset: 0x003CF370
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
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.OpenTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.normalModeInfos_ == null)
						{
							this.NormalModeInfos = new ModeInfo();
						}
						input.ReadMessage(this.NormalModeInfos);
						continue;
					}
					if (num == 34U)
					{
						if (this.infiniteModeInfos_ == null)
						{
							this.InfiniteModeInfos = new ModeInfo();
						}
						input.ReadMessage(this.InfiniteModeInfos);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009A06 RID: 39430
		private static readonly MessageParser<SurvivorsChallengeInfo> _parser = new MessageParser<SurvivorsChallengeInfo>(() => new SurvivorsChallengeInfo());

		// Token: 0x04009A07 RID: 39431
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A08 RID: 39432
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04009A09 RID: 39433
		private int levelId_;

		// Token: 0x04009A0A RID: 39434
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x04009A0B RID: 39435
		private long openTime_;

		// Token: 0x04009A0C RID: 39436
		public const int NormalModeInfosFieldNumber = 3;

		// Token: 0x04009A0D RID: 39437
		private ModeInfo normalModeInfos_;

		// Token: 0x04009A0E RID: 39438
		public const int InfiniteModeInfosFieldNumber = 4;

		// Token: 0x04009A0F RID: 39439
		private ModeInfo infiniteModeInfos_;
	}
}
