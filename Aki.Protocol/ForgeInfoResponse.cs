using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000620 RID: 1568
	[NetMessage(EMessageId.ForgeInfoResponse)]
	public sealed class ForgeInfoResponse : IMessage<ForgeInfoResponse>, IMessage, IEquatable<ForgeInfoResponse>, IDeepCloneable<ForgeInfoResponse>, IBufferMessage
	{
		// Token: 0x060090A9 RID: 37033 RVA: 0x0015E112 File Offset: 0x0015C312
		[NullableContext(1)]
		public static ForgeInfoResponse Create()
		{
			return new ForgeInfoResponse();
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x060090AA RID: 37034 RVA: 0x0015E119 File Offset: 0x0015C319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x060090AB RID: 37035 RVA: 0x0015E11C File Offset: 0x0015C31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeInfoResponse.Descriptor;
			}
		}

		// Token: 0x060090AC RID: 37036 RVA: 0x0015E123 File Offset: 0x0015C323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeInfoResponse()
		{
		}

		// Token: 0x060090AD RID: 37037 RVA: 0x0015E144 File Offset: 0x0015C344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeInfoResponse(ForgeInfoResponse other) : this()
		{
			this.code_ = other.code_;
			this.forgeInfoList_ = other.forgeInfoList_.Clone();
			this.forgeConfigs_ = other.forgeConfigs_.Clone();
			this.limitRefreshTime_ = other.limitRefreshTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060090AE RID: 37038 RVA: 0x0015E1A2 File Offset: 0x0015C3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeInfoResponse Clone()
		{
			return new ForgeInfoResponse(this);
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x060090AF RID: 37039 RVA: 0x0015E1AA File Offset: 0x0015C3AA
		// (set) Token: 0x060090B0 RID: 37040 RVA: 0x0015E1B2 File Offset: 0x0015C3B2
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

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x060090B1 RID: 37041 RVA: 0x0015E1BB File Offset: 0x0015C3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneForgeInfo> ForgeInfoList
		{
			get
			{
				return this.forgeInfoList_;
			}
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x060090B2 RID: 37042 RVA: 0x0015E1C3 File Offset: 0x0015C3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneForgeConfig> ForgeConfigs
		{
			get
			{
				return this.forgeConfigs_;
			}
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x060090B3 RID: 37043 RVA: 0x0015E1CB File Offset: 0x0015C3CB
		// (set) Token: 0x060090B4 RID: 37044 RVA: 0x0015E1D3 File Offset: 0x0015C3D3
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

		// Token: 0x060090B5 RID: 37045 RVA: 0x0015E1DC File Offset: 0x0015C3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeInfoResponse);
		}

		// Token: 0x060090B6 RID: 37046 RVA: 0x0015E1EC File Offset: 0x0015C3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeInfoResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.forgeInfoList_.Equals(other.forgeInfoList_) && this.forgeConfigs_.Equals(other.forgeConfigs_) && this.LimitRefreshTime == other.LimitRefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060090B7 RID: 37047 RVA: 0x0015E260 File Offset: 0x0015C460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.forgeInfoList_.GetHashCode();
			num ^= this.forgeConfigs_.GetHashCode();
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

		// Token: 0x060090B8 RID: 37048 RVA: 0x0015E2DA File Offset: 0x0015C4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060090B9 RID: 37049 RVA: 0x0015E2E7 File Offset: 0x0015C4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090BA RID: 37050 RVA: 0x0015E2F0 File Offset: 0x0015C4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.forgeInfoList_.WriteTo(ref output, ForgeInfoResponse._repeated_forgeInfoList_codec);
			if (this.LimitRefreshTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.LimitRefreshTime);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
			}
			this.forgeConfigs_.WriteTo(ref output, ForgeInfoResponse._repeated_forgeConfigs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090BB RID: 37051 RVA: 0x0015E36C File Offset: 0x0015C56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.forgeInfoList_.CalculateSize(ForgeInfoResponse._repeated_forgeInfoList_codec);
			num += this.forgeConfigs_.CalculateSize(ForgeInfoResponse._repeated_forgeConfigs_codec);
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

		// Token: 0x060090BC RID: 37052 RVA: 0x0015E3E8 File Offset: 0x0015C5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ForgeInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.forgeInfoList_.Add(other.forgeInfoList_);
			this.forgeConfigs_.Add(other.forgeConfigs_);
			if (other.LimitRefreshTime != 0L)
			{
				this.LimitRefreshTime = other.LimitRefreshTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060090BD RID: 37053 RVA: 0x0015E45A File Offset: 0x0015C65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090BE RID: 37054 RVA: 0x0015E464 File Offset: 0x0015C664
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
				if (num <= 40U)
				{
					if (num == 18U)
					{
						this.forgeInfoList_.AddEntriesFrom(ref input, ForgeInfoResponse._repeated_forgeInfoList_codec);
						continue;
					}
					if (num == 40U)
					{
						this.LimitRefreshTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 114U)
					{
						this.forgeConfigs_.AddEntriesFrom(ref input, ForgeInfoResponse._repeated_forgeConfigs_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045F9 RID: 17913
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045FA RID: 17914
		public const int CodeFieldNumber = 10;

		// Token: 0x040045FB RID: 17915
		private ErrorCode code_;

		// Token: 0x040045FC RID: 17916
		public const int ForgeInfoListFieldNumber = 2;

		// Token: 0x040045FD RID: 17917
		private static readonly FieldCodec<OneForgeInfo> _repeated_forgeInfoList_codec = FieldCodec.ForMessage<OneForgeInfo>(18U, OneForgeInfo.Parser);

		// Token: 0x040045FE RID: 17918
		private readonly RepeatedField<OneForgeInfo> forgeInfoList_ = new RepeatedField<OneForgeInfo>();

		// Token: 0x040045FF RID: 17919
		public const int ForgeConfigsFieldNumber = 14;

		// Token: 0x04004600 RID: 17920
		private static readonly FieldCodec<OneForgeConfig> _repeated_forgeConfigs_codec = FieldCodec.ForMessage<OneForgeConfig>(114U, OneForgeConfig.Parser);

		// Token: 0x04004601 RID: 17921
		private readonly RepeatedField<OneForgeConfig> forgeConfigs_ = new RepeatedField<OneForgeConfig>();

		// Token: 0x04004602 RID: 17922
		public const int LimitRefreshTimeFieldNumber = 5;

		// Token: 0x04004603 RID: 17923
		private long limitRefreshTime_;
	}
}
