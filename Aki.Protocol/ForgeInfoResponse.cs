using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060C RID: 1548
	[NetMessage(EMessageId.ForgeInfoResponse)]
	public sealed class ForgeInfoResponse : IMessage<ForgeInfoResponse>, IMessage, IEquatable<ForgeInfoResponse>, IDeepCloneable<ForgeInfoResponse>, IBufferMessage
	{
		// Token: 0x06008F53 RID: 36691 RVA: 0x0015B6DE File Offset: 0x001598DE
		[NullableContext(1)]
		public static ForgeInfoResponse Create()
		{
			return new ForgeInfoResponse();
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06008F54 RID: 36692 RVA: 0x0015B6E5 File Offset: 0x001598E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06008F55 RID: 36693 RVA: 0x0015B6E8 File Offset: 0x001598E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeInfoResponse.Descriptor;
			}
		}

		// Token: 0x06008F56 RID: 36694 RVA: 0x0015B6EF File Offset: 0x001598EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeInfoResponse()
		{
		}

		// Token: 0x06008F57 RID: 36695 RVA: 0x0015B710 File Offset: 0x00159910
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

		// Token: 0x06008F58 RID: 36696 RVA: 0x0015B76E File Offset: 0x0015996E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeInfoResponse Clone()
		{
			return new ForgeInfoResponse(this);
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06008F59 RID: 36697 RVA: 0x0015B776 File Offset: 0x00159976
		// (set) Token: 0x06008F5A RID: 36698 RVA: 0x0015B77E File Offset: 0x0015997E
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

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06008F5B RID: 36699 RVA: 0x0015B787 File Offset: 0x00159987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneForgeInfo> ForgeInfoList
		{
			get
			{
				return this.forgeInfoList_;
			}
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06008F5C RID: 36700 RVA: 0x0015B78F File Offset: 0x0015998F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneForgeConfig> ForgeConfigs
		{
			get
			{
				return this.forgeConfigs_;
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06008F5D RID: 36701 RVA: 0x0015B797 File Offset: 0x00159997
		// (set) Token: 0x06008F5E RID: 36702 RVA: 0x0015B79F File Offset: 0x0015999F
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

		// Token: 0x06008F5F RID: 36703 RVA: 0x0015B7A8 File Offset: 0x001599A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeInfoResponse);
		}

		// Token: 0x06008F60 RID: 36704 RVA: 0x0015B7B8 File Offset: 0x001599B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeInfoResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.forgeInfoList_.Equals(other.forgeInfoList_) && this.forgeConfigs_.Equals(other.forgeConfigs_) && this.LimitRefreshTime == other.LimitRefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F61 RID: 36705 RVA: 0x0015B82C File Offset: 0x00159A2C
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

		// Token: 0x06008F62 RID: 36706 RVA: 0x0015B8A6 File Offset: 0x00159AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x0015B8B3 File Offset: 0x00159AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x0015B8BC File Offset: 0x00159ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LimitRefreshTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.LimitRefreshTime);
			}
			this.forgeConfigs_.WriteTo(ref output, ForgeInfoResponse._repeated_forgeConfigs_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			this.forgeInfoList_.WriteTo(ref output, ForgeInfoResponse._repeated_forgeInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F65 RID: 36709 RVA: 0x0015B938 File Offset: 0x00159B38
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

		// Token: 0x06008F66 RID: 36710 RVA: 0x0015B9B4 File Offset: 0x00159BB4
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

		// Token: 0x06008F67 RID: 36711 RVA: 0x0015BA26 File Offset: 0x00159C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F68 RID: 36712 RVA: 0x0015BA30 File Offset: 0x00159C30
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
				if (num <= 42U)
				{
					if (num == 16U)
					{
						this.LimitRefreshTime = input.ReadInt64();
						continue;
					}
					if (num == 42U)
					{
						this.forgeConfigs_.AddEntriesFrom(ref input, ForgeInfoResponse._repeated_forgeConfigs_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 106U)
					{
						this.forgeInfoList_.AddEntriesFrom(ref input, ForgeInfoResponse._repeated_forgeInfoList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045F2 RID: 17906
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045F3 RID: 17907
		public const int CodeFieldNumber = 7;

		// Token: 0x040045F4 RID: 17908
		private ErrorCode code_;

		// Token: 0x040045F5 RID: 17909
		public const int ForgeInfoListFieldNumber = 13;

		// Token: 0x040045F6 RID: 17910
		private static readonly FieldCodec<OneForgeInfo> _repeated_forgeInfoList_codec = FieldCodec.ForMessage<OneForgeInfo>(106U, OneForgeInfo.Parser);

		// Token: 0x040045F7 RID: 17911
		private readonly RepeatedField<OneForgeInfo> forgeInfoList_ = new RepeatedField<OneForgeInfo>();

		// Token: 0x040045F8 RID: 17912
		public const int ForgeConfigsFieldNumber = 5;

		// Token: 0x040045F9 RID: 17913
		private static readonly FieldCodec<OneForgeConfig> _repeated_forgeConfigs_codec = FieldCodec.ForMessage<OneForgeConfig>(42U, OneForgeConfig.Parser);

		// Token: 0x040045FA RID: 17914
		private readonly RepeatedField<OneForgeConfig> forgeConfigs_ = new RepeatedField<OneForgeConfig>();

		// Token: 0x040045FB RID: 17915
		public const int LimitRefreshTimeFieldNumber = 2;

		// Token: 0x040045FC RID: 17916
		private long limitRefreshTime_;
	}
}
