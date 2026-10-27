using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130D RID: 4877
	[NetMessage(EMessageId.SynthesisInfoResponse)]
	public sealed class SynthesisInfoResponse : IMessage<SynthesisInfoResponse>, IMessage, IEquatable<SynthesisInfoResponse>, IDeepCloneable<SynthesisInfoResponse>, IBufferMessage
	{
		// Token: 0x06019EB2 RID: 106162 RVA: 0x003C3E3A File Offset: 0x003C203A
		[NullableContext(1)]
		public static SynthesisInfoResponse Create()
		{
			return new SynthesisInfoResponse();
		}

		// Token: 0x17005763 RID: 22371
		// (get) Token: 0x06019EB3 RID: 106163 RVA: 0x003C3E41 File Offset: 0x003C2041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005764 RID: 22372
		// (get) Token: 0x06019EB4 RID: 106164 RVA: 0x003C3E44 File Offset: 0x003C2044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisInfoResponse.Descriptor;
			}
		}

		// Token: 0x06019EB5 RID: 106165 RVA: 0x003C3E4B File Offset: 0x003C204B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoResponse()
		{
		}

		// Token: 0x06019EB6 RID: 106166 RVA: 0x003C3E6C File Offset: 0x003C206C
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

		// Token: 0x06019EB7 RID: 106167 RVA: 0x003C3EE6 File Offset: 0x003C20E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisInfoResponse Clone()
		{
			return new SynthesisInfoResponse(this);
		}

		// Token: 0x17005765 RID: 22373
		// (get) Token: 0x06019EB8 RID: 106168 RVA: 0x003C3EEE File Offset: 0x003C20EE
		// (set) Token: 0x06019EB9 RID: 106169 RVA: 0x003C3EF6 File Offset: 0x003C20F6
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

		// Token: 0x17005766 RID: 22374
		// (get) Token: 0x06019EBA RID: 106170 RVA: 0x003C3EFF File Offset: 0x003C20FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneSynthesisInfo> SynthesisInfoList
		{
			get
			{
				return this.synthesisInfoList_;
			}
		}

		// Token: 0x17005767 RID: 22375
		// (get) Token: 0x06019EBB RID: 106171 RVA: 0x003C3F07 File Offset: 0x003C2107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneSynthesisConfig> SynthesisConfigs
		{
			get
			{
				return this.synthesisConfigs_;
			}
		}

		// Token: 0x17005768 RID: 22376
		// (get) Token: 0x06019EBC RID: 106172 RVA: 0x003C3F0F File Offset: 0x003C210F
		// (set) Token: 0x06019EBD RID: 106173 RVA: 0x003C3F17 File Offset: 0x003C2117
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

		// Token: 0x17005769 RID: 22377
		// (get) Token: 0x06019EBE RID: 106174 RVA: 0x003C3F20 File Offset: 0x003C2120
		// (set) Token: 0x06019EBF RID: 106175 RVA: 0x003C3F28 File Offset: 0x003C2128
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

		// Token: 0x06019EC0 RID: 106176 RVA: 0x003C3F31 File Offset: 0x003C2131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisInfoResponse);
		}

		// Token: 0x06019EC1 RID: 106177 RVA: 0x003C3F40 File Offset: 0x003C2140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisInfoResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.synthesisInfoList_.Equals(other.synthesisInfoList_) && this.synthesisConfigs_.Equals(other.synthesisConfigs_) && object.Equals(this.LevelInfo, other.LevelInfo) && this.LimitRefreshTime == other.LimitRefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019EC2 RID: 106178 RVA: 0x003C3FC8 File Offset: 0x003C21C8
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

		// Token: 0x06019EC3 RID: 106179 RVA: 0x003C4058 File Offset: 0x003C2258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019EC4 RID: 106180 RVA: 0x003C4065 File Offset: 0x003C2265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019EC5 RID: 106181 RVA: 0x003C4070 File Offset: 0x003C2270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			this.synthesisConfigs_.WriteTo(ref output, SynthesisInfoResponse._repeated_synthesisConfigs_codec);
			this.synthesisInfoList_.WriteTo(ref output, SynthesisInfoResponse._repeated_synthesisInfoList_codec);
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.LevelInfo);
			}
			if (this.LimitRefreshTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.LimitRefreshTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019EC6 RID: 106182 RVA: 0x003C4108 File Offset: 0x003C2308
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

		// Token: 0x06019EC7 RID: 106183 RVA: 0x003C419C File Offset: 0x003C239C
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

		// Token: 0x06019EC8 RID: 106184 RVA: 0x003C423A File Offset: 0x003C243A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019EC9 RID: 106185 RVA: 0x003C4244 File Offset: 0x003C2444
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
				if (num <= 50U)
				{
					if (num == 16U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 50U)
					{
						this.synthesisConfigs_.AddEntriesFrom(ref input, SynthesisInfoResponse._repeated_synthesisConfigs_codec);
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.synthesisInfoList_.AddEntriesFrom(ref input, SynthesisInfoResponse._repeated_synthesisInfoList_codec);
						continue;
					}
					if (num == 106U)
					{
						if (this.levelInfo_ == null)
						{
							this.LevelInfo = new SynthesisLevelInfo();
						}
						input.ReadMessage(this.LevelInfo);
						continue;
					}
					if (num == 120U)
					{
						this.LimitRefreshTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009773 RID: 38771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009774 RID: 38772
		public const int CodeFieldNumber = 2;

		// Token: 0x04009775 RID: 38773
		private ErrorCode code_;

		// Token: 0x04009776 RID: 38774
		public const int SynthesisInfoListFieldNumber = 7;

		// Token: 0x04009777 RID: 38775
		private static readonly FieldCodec<OneSynthesisInfo> _repeated_synthesisInfoList_codec = FieldCodec.ForMessage<OneSynthesisInfo>(58U, OneSynthesisInfo.Parser);

		// Token: 0x04009778 RID: 38776
		private readonly RepeatedField<OneSynthesisInfo> synthesisInfoList_ = new RepeatedField<OneSynthesisInfo>();

		// Token: 0x04009779 RID: 38777
		public const int SynthesisConfigsFieldNumber = 6;

		// Token: 0x0400977A RID: 38778
		private static readonly FieldCodec<OneSynthesisConfig> _repeated_synthesisConfigs_codec = FieldCodec.ForMessage<OneSynthesisConfig>(50U, OneSynthesisConfig.Parser);

		// Token: 0x0400977B RID: 38779
		private readonly RepeatedField<OneSynthesisConfig> synthesisConfigs_ = new RepeatedField<OneSynthesisConfig>();

		// Token: 0x0400977C RID: 38780
		public const int LevelInfoFieldNumber = 13;

		// Token: 0x0400977D RID: 38781
		private SynthesisLevelInfo levelInfo_;

		// Token: 0x0400977E RID: 38782
		public const int LimitRefreshTimeFieldNumber = 15;

		// Token: 0x0400977F RID: 38783
		private long limitRefreshTime_;
	}
}
