using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137A RID: 4986
	[NetMessage(EMessageId.SynthesisInfoResponse)]
	public sealed class SynthesisInfoResponse : IMessage<SynthesisInfoResponse>, IMessage, IEquatable<SynthesisInfoResponse>, IDeepCloneable<SynthesisInfoResponse>, IBufferMessage
	{
		// Token: 0x0601A8C2 RID: 108738 RVA: 0x003DE0F6 File Offset: 0x003DC2F6
		[NullableContext(1)]
		public static SynthesisInfoResponse Create()
		{
			return new SynthesisInfoResponse();
		}

		// Token: 0x170059DD RID: 23005
		// (get) Token: 0x0601A8C3 RID: 108739 RVA: 0x003DE0FD File Offset: 0x003DC2FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059DE RID: 23006
		// (get) Token: 0x0601A8C4 RID: 108740 RVA: 0x003DE100 File Offset: 0x003DC300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601A8C5 RID: 108741 RVA: 0x003DE107 File Offset: 0x003DC307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoResponse()
		{
		}

		// Token: 0x0601A8C6 RID: 108742 RVA: 0x003DE128 File Offset: 0x003DC328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoResponse(SynthesisInfoResponse other) : this()
		{
			this.code_ = other.code_;
			this.synthesisInfoList_ = other.synthesisInfoList_.Clone();
			this.synthesisConfigs_ = other.synthesisConfigs_.Clone();
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this.limitRefreshTime_ = other.limitRefreshTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A8C7 RID: 108743 RVA: 0x003DE1A2 File Offset: 0x003DC3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoResponse Clone()
		{
			return new SynthesisInfoResponse(this);
		}

		// Token: 0x170059DF RID: 23007
		// (get) Token: 0x0601A8C8 RID: 108744 RVA: 0x003DE1AA File Offset: 0x003DC3AA
		// (set) Token: 0x0601A8C9 RID: 108745 RVA: 0x003DE1B2 File Offset: 0x003DC3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x170059E0 RID: 23008
		// (get) Token: 0x0601A8CA RID: 108746 RVA: 0x003DE1BB File Offset: 0x003DC3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneSynthesisInfo> SynthesisInfoList
		{
			get
			{
				return this.synthesisInfoList_;
			}
		}

		// Token: 0x170059E1 RID: 23009
		// (get) Token: 0x0601A8CB RID: 108747 RVA: 0x003DE1C3 File Offset: 0x003DC3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneSynthesisConfig> SynthesisConfigs
		{
			get
			{
				return this.synthesisConfigs_;
			}
		}

		// Token: 0x170059E2 RID: 23010
		// (get) Token: 0x0601A8CC RID: 108748 RVA: 0x003DE1CB File Offset: 0x003DC3CB
		// (set) Token: 0x0601A8CD RID: 108749 RVA: 0x003DE1D3 File Offset: 0x003DC3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelInfo LevelInfo
		{
			get
			{
				return this.levelInfo_;
			}
			set
			{
				this.levelInfo_ = value;
			}
		}

		// Token: 0x170059E3 RID: 23011
		// (get) Token: 0x0601A8CE RID: 108750 RVA: 0x003DE1DC File Offset: 0x003DC3DC
		// (set) Token: 0x0601A8CF RID: 108751 RVA: 0x003DE1E4 File Offset: 0x003DC3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitRefreshTime
		{
			get
			{
				return this.limitRefreshTime_;
			}
			set
			{
				this.limitRefreshTime_ = value;
			}
		}

		// Token: 0x0601A8D0 RID: 108752 RVA: 0x003DE1ED File Offset: 0x003DC3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisInfoResponse);
		}

		// Token: 0x0601A8D1 RID: 108753 RVA: 0x003DE1FC File Offset: 0x003DC3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisInfoResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.synthesisInfoList_.Equals(other.synthesisInfoList_) && this.synthesisConfigs_.Equals(other.synthesisConfigs_) && object.Equals(this.LevelInfo, other.LevelInfo) && this.LimitRefreshTime == other.LimitRefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A8D2 RID: 108754 RVA: 0x003DE284 File Offset: 0x003DC484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.synthesisInfoList_.GetHashCode();
			num ^= this.synthesisConfigs_.GetHashCode();
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this.LimitRefreshTime != 0L)
			{
				num ^= this.LimitRefreshTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A8D3 RID: 108755 RVA: 0x003DE314 File Offset: 0x003DC514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A8D4 RID: 108756 RVA: 0x003DE321 File Offset: 0x003DC521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A8D5 RID: 108757 RVA: 0x003DE32C File Offset: 0x003DC52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.LevelInfo);
			}
			if (this.LimitRefreshTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.LimitRefreshTime);
			}
			this.synthesisConfigs_.WriteTo(ref output, SynthesisInfoResponse._repeated_synthesisConfigs_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			this.synthesisInfoList_.WriteTo(ref output, SynthesisInfoResponse._repeated_synthesisInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A8D6 RID: 108758 RVA: 0x003DE3C4 File Offset: 0x003DC5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.synthesisInfoList_.CalculateSize(SynthesisInfoResponse._repeated_synthesisInfoList_codec);
			num += this.synthesisConfigs_.CalculateSize(SynthesisInfoResponse._repeated_synthesisConfigs_codec);
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this.LimitRefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitRefreshTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A8D7 RID: 108759 RVA: 0x003DE458 File Offset: 0x003DC658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.synthesisInfoList_.Add(other.synthesisInfoList_);
			this.synthesisConfigs_.Add(other.synthesisConfigs_);
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new SynthesisLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
			}
			if (other.LimitRefreshTime != 0L)
			{
				this.LimitRefreshTime = other.LimitRefreshTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A8D8 RID: 108760 RVA: 0x003DE4F6 File Offset: 0x003DC6F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A8D9 RID: 108761 RVA: 0x003DE500 File Offset: 0x003DC700
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
				if (num <= 48U)
				{
					if (num == 42U)
					{
						if (this.levelInfo_ == null)
						{
							this.LevelInfo = new SynthesisLevelInfo();
						}
						input.ReadMessage(this.LevelInfo);
						continue;
					}
					if (num == 48U)
					{
						this.LimitRefreshTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.synthesisConfigs_.AddEntriesFrom(ref input, SynthesisInfoResponse._repeated_synthesisConfigs_codec);
						continue;
					}
					if (num == 72U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 90U)
					{
						this.synthesisInfoList_.AddEntriesFrom(ref input, SynthesisInfoResponse._repeated_synthesisInfoList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009B95 RID: 39829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B96 RID: 39830
		public const int CodeFieldNumber = 9;

		// Token: 0x04009B97 RID: 39831
		private ErrorCode code_;

		// Token: 0x04009B98 RID: 39832
		public const int SynthesisInfoListFieldNumber = 11;

		// Token: 0x04009B99 RID: 39833
		private static readonly FieldCodec<OneSynthesisInfo> _repeated_synthesisInfoList_codec = FieldCodec.ForMessage<OneSynthesisInfo>(90U, OneSynthesisInfo.Parser);

		// Token: 0x04009B9A RID: 39834
		private readonly RepeatedField<OneSynthesisInfo> synthesisInfoList_ = new RepeatedField<OneSynthesisInfo>();

		// Token: 0x04009B9B RID: 39835
		public const int SynthesisConfigsFieldNumber = 8;

		// Token: 0x04009B9C RID: 39836
		private static readonly FieldCodec<OneSynthesisConfig> _repeated_synthesisConfigs_codec = FieldCodec.ForMessage<OneSynthesisConfig>(66U, OneSynthesisConfig.Parser);

		// Token: 0x04009B9D RID: 39837
		private readonly RepeatedField<OneSynthesisConfig> synthesisConfigs_ = new RepeatedField<OneSynthesisConfig>();

		// Token: 0x04009B9E RID: 39838
		public const int LevelInfoFieldNumber = 5;

		// Token: 0x04009B9F RID: 39839
		private SynthesisLevelInfo levelInfo_;

		// Token: 0x04009BA0 RID: 39840
		public const int LimitRefreshTimeFieldNumber = 6;

		// Token: 0x04009BA1 RID: 39841
		private long limitRefreshTime_;
	}
}
