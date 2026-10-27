using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C0 RID: 4800
	public sealed class SurvivorsChallengeInfo : IMessage<SurvivorsChallengeInfo>, IMessage, IEquatable<SurvivorsChallengeInfo>, IDeepCloneable<SurvivorsChallengeInfo>, IBufferMessage
	{
		// Token: 0x060198A9 RID: 104617 RVA: 0x003B6665 File Offset: 0x003B4865
		[NullableContext(1)]
		public static SurvivorsChallengeInfo Create()
		{
			return new SurvivorsChallengeInfo();
		}

		// Token: 0x17005626 RID: 22054
		// (get) Token: 0x060198AA RID: 104618 RVA: 0x003B666C File Offset: 0x003B486C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SurvivorsChallengeInfo> Parser
		{
			get
			{
				return SurvivorsChallengeInfo._parser;
			}
		}

		// Token: 0x17005627 RID: 22055
		// (get) Token: 0x060198AB RID: 104619 RVA: 0x003B6673 File Offset: 0x003B4873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005628 RID: 22056
		// (get) Token: 0x060198AC RID: 104620 RVA: 0x003B6676 File Offset: 0x003B4876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsChallengeInfo.Descriptor;
			}
		}

		// Token: 0x060198AD RID: 104621 RVA: 0x003B667D File Offset: 0x003B487D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsChallengeInfo()
		{
		}

		// Token: 0x060198AE RID: 104622 RVA: 0x003B6688 File Offset: 0x003B4888
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

		// Token: 0x060198AF RID: 104623 RVA: 0x003B66FC File Offset: 0x003B48FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsChallengeInfo Clone()
		{
			return new SurvivorsChallengeInfo(this);
		}

		// Token: 0x17005629 RID: 22057
		// (get) Token: 0x060198B0 RID: 104624 RVA: 0x003B6704 File Offset: 0x003B4904
		// (set) Token: 0x060198B1 RID: 104625 RVA: 0x003B670C File Offset: 0x003B490C
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

		// Token: 0x1700562A RID: 22058
		// (get) Token: 0x060198B2 RID: 104626 RVA: 0x003B6715 File Offset: 0x003B4915
		// (set) Token: 0x060198B3 RID: 104627 RVA: 0x003B671D File Offset: 0x003B491D
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

		// Token: 0x1700562B RID: 22059
		// (get) Token: 0x060198B4 RID: 104628 RVA: 0x003B6726 File Offset: 0x003B4926
		// (set) Token: 0x060198B5 RID: 104629 RVA: 0x003B672E File Offset: 0x003B492E
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

		// Token: 0x1700562C RID: 22060
		// (get) Token: 0x060198B6 RID: 104630 RVA: 0x003B6737 File Offset: 0x003B4937
		// (set) Token: 0x060198B7 RID: 104631 RVA: 0x003B673F File Offset: 0x003B493F
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

		// Token: 0x060198B8 RID: 104632 RVA: 0x003B6748 File Offset: 0x003B4948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsChallengeInfo);
		}

		// Token: 0x060198B9 RID: 104633 RVA: 0x003B6758 File Offset: 0x003B4958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsChallengeInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.OpenTime == other.OpenTime && object.Equals(this.NormalModeInfos, other.NormalModeInfos) && object.Equals(this.InfiniteModeInfos, other.InfiniteModeInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060198BA RID: 104634 RVA: 0x003B67CC File Offset: 0x003B49CC
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

		// Token: 0x060198BB RID: 104635 RVA: 0x003B6850 File Offset: 0x003B4A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060198BC RID: 104636 RVA: 0x003B685D File Offset: 0x003B4A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060198BD RID: 104637 RVA: 0x003B6868 File Offset: 0x003B4A68
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

		// Token: 0x060198BE RID: 104638 RVA: 0x003B68F8 File Offset: 0x003B4AF8
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

		// Token: 0x060198BF RID: 104639 RVA: 0x003B6980 File Offset: 0x003B4B80
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

		// Token: 0x060198C0 RID: 104640 RVA: 0x003B6A28 File Offset: 0x003B4C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060198C1 RID: 104641 RVA: 0x003B6A34 File Offset: 0x003B4C34
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

		// Token: 0x040095DC RID: 38364
		private static readonly MessageParser<SurvivorsChallengeInfo> _parser = new MessageParser<SurvivorsChallengeInfo>(() => new SurvivorsChallengeInfo());

		// Token: 0x040095DD RID: 38365
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095DE RID: 38366
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040095DF RID: 38367
		private int levelId_;

		// Token: 0x040095E0 RID: 38368
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x040095E1 RID: 38369
		private long openTime_;

		// Token: 0x040095E2 RID: 38370
		public const int NormalModeInfosFieldNumber = 3;

		// Token: 0x040095E3 RID: 38371
		private ModeInfo normalModeInfos_;

		// Token: 0x040095E4 RID: 38372
		public const int InfiniteModeInfosFieldNumber = 4;

		// Token: 0x040095E5 RID: 38373
		private ModeInfo infiniteModeInfos_;
	}
}
