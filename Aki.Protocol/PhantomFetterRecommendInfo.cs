using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC1 RID: 3265
	public sealed class PhantomFetterRecommendInfo : IMessage<PhantomFetterRecommendInfo>, IMessage, IEquatable<PhantomFetterRecommendInfo>, IDeepCloneable<PhantomFetterRecommendInfo>, IBufferMessage
	{
		// Token: 0x06011B28 RID: 72488 RVA: 0x002976FB File Offset: 0x002958FB
		[NullableContext(1)]
		public static PhantomFetterRecommendInfo Create()
		{
			return new PhantomFetterRecommendInfo();
		}

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x06011B29 RID: 72489 RVA: 0x00297702 File Offset: 0x00295902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomFetterRecommendInfo> Parser
		{
			get
			{
				return PhantomFetterRecommendInfo._parser;
			}
		}

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x06011B2A RID: 72490 RVA: 0x00297709 File Offset: 0x00295909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x06011B2B RID: 72491 RVA: 0x0029770C File Offset: 0x0029590C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomFetterRecommendInfo.Descriptor;
			}
		}

		// Token: 0x06011B2C RID: 72492 RVA: 0x00297713 File Offset: 0x00295913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendInfo()
		{
		}

		// Token: 0x06011B2D RID: 72493 RVA: 0x0029773C File Offset: 0x0029593C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendInfo(PhantomFetterRecommendInfo other) : this()
		{
			this.usage_ = other.usage_;
			this.phantomFetterGroupInfos_ = other.phantomFetterGroupInfos_.Clone();
			this.costCombinationInfos_ = other.costCombinationInfos_.Clone();
			this.mainPhantomRecommendInfos_ = other.mainPhantomRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B2E RID: 72494 RVA: 0x0029779F File Offset: 0x0029599F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterRecommendInfo Clone()
		{
			return new PhantomFetterRecommendInfo(this);
		}

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x06011B2F RID: 72495 RVA: 0x002977A7 File Offset: 0x002959A7
		// (set) Token: 0x06011B30 RID: 72496 RVA: 0x002977AF File Offset: 0x002959AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Usage
		{
			get
			{
				return this.usage_;
			}
			set
			{
				this.usage_ = value;
			}
		}

		// Token: 0x17003AA4 RID: 15012
		// (get) Token: 0x06011B31 RID: 72497 RVA: 0x002977B8 File Offset: 0x002959B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomFetterGroupInfo> PhantomFetterGroupInfos
		{
			get
			{
				return this.phantomFetterGroupInfos_;
			}
		}

		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x06011B32 RID: 72498 RVA: 0x002977C0 File Offset: 0x002959C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CostCombinationInfo> CostCombinationInfos
		{
			get
			{
				return this.costCombinationInfos_;
			}
		}

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x06011B33 RID: 72499 RVA: 0x002977C8 File Offset: 0x002959C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MainPhantomRecommendInfo> MainPhantomRecommendInfos
		{
			get
			{
				return this.mainPhantomRecommendInfos_;
			}
		}

		// Token: 0x06011B34 RID: 72500 RVA: 0x002977D0 File Offset: 0x002959D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomFetterRecommendInfo);
		}

		// Token: 0x06011B35 RID: 72501 RVA: 0x002977E0 File Offset: 0x002959E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomFetterRecommendInfo other)
		{
			return other != null && (other == this || (this.Usage == other.Usage && this.phantomFetterGroupInfos_.Equals(other.phantomFetterGroupInfos_) && this.costCombinationInfos_.Equals(other.costCombinationInfos_) && this.mainPhantomRecommendInfos_.Equals(other.mainPhantomRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B36 RID: 72502 RVA: 0x00297858 File Offset: 0x00295A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Usage != 0)
			{
				num ^= this.Usage.GetHashCode();
			}
			num ^= this.phantomFetterGroupInfos_.GetHashCode();
			num ^= this.costCombinationInfos_.GetHashCode();
			num ^= this.mainPhantomRecommendInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011B37 RID: 72503 RVA: 0x002978C1 File Offset: 0x00295AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B38 RID: 72504 RVA: 0x002978CE File Offset: 0x00295ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B39 RID: 72505 RVA: 0x002978D8 File Offset: 0x00295AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Usage != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Usage);
			}
			this.phantomFetterGroupInfos_.WriteTo(ref output, PhantomFetterRecommendInfo._repeated_phantomFetterGroupInfos_codec);
			this.costCombinationInfos_.WriteTo(ref output, PhantomFetterRecommendInfo._repeated_costCombinationInfos_codec);
			this.mainPhantomRecommendInfos_.WriteTo(ref output, PhantomFetterRecommendInfo._repeated_mainPhantomRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B3A RID: 72506 RVA: 0x00297948 File Offset: 0x00295B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Usage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Usage);
			}
			num += this.phantomFetterGroupInfos_.CalculateSize(PhantomFetterRecommendInfo._repeated_phantomFetterGroupInfos_codec);
			num += this.costCombinationInfos_.CalculateSize(PhantomFetterRecommendInfo._repeated_costCombinationInfos_codec);
			num += this.mainPhantomRecommendInfos_.CalculateSize(PhantomFetterRecommendInfo._repeated_mainPhantomRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011B3B RID: 72507 RVA: 0x002979C0 File Offset: 0x00295BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomFetterRecommendInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Usage != 0)
			{
				this.Usage = other.Usage;
			}
			this.phantomFetterGroupInfos_.Add(other.phantomFetterGroupInfos_);
			this.costCombinationInfos_.Add(other.costCombinationInfos_);
			this.mainPhantomRecommendInfos_.Add(other.mainPhantomRecommendInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011B3C RID: 72508 RVA: 0x00297A2F File Offset: 0x00295C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B3D RID: 72509 RVA: 0x00297A38 File Offset: 0x00295C38
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
				if (num <= 26U)
				{
					if (num == 16U)
					{
						this.Usage = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.phantomFetterGroupInfos_.AddEntriesFrom(ref input, PhantomFetterRecommendInfo._repeated_phantomFetterGroupInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.costCombinationInfos_.AddEntriesFrom(ref input, PhantomFetterRecommendInfo._repeated_costCombinationInfos_codec);
						continue;
					}
					if (num == 42U)
					{
						this.mainPhantomRecommendInfos_.AddEntriesFrom(ref input, PhantomFetterRecommendInfo._repeated_mainPhantomRecommendInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006FAA RID: 28586
		private static readonly MessageParser<PhantomFetterRecommendInfo> _parser = new MessageParser<PhantomFetterRecommendInfo>(() => new PhantomFetterRecommendInfo());

		// Token: 0x04006FAB RID: 28587
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FAC RID: 28588
		public const int UsageFieldNumber = 2;

		// Token: 0x04006FAD RID: 28589
		private int usage_;

		// Token: 0x04006FAE RID: 28590
		public const int PhantomFetterGroupInfosFieldNumber = 3;

		// Token: 0x04006FAF RID: 28591
		private static readonly FieldCodec<PhantomFetterGroupInfo> _repeated_phantomFetterGroupInfos_codec = FieldCodec.ForMessage<PhantomFetterGroupInfo>(26U, PhantomFetterGroupInfo.Parser);

		// Token: 0x04006FB0 RID: 28592
		private readonly RepeatedField<PhantomFetterGroupInfo> phantomFetterGroupInfos_ = new RepeatedField<PhantomFetterGroupInfo>();

		// Token: 0x04006FB1 RID: 28593
		public const int CostCombinationInfosFieldNumber = 4;

		// Token: 0x04006FB2 RID: 28594
		private static readonly FieldCodec<CostCombinationInfo> _repeated_costCombinationInfos_codec = FieldCodec.ForMessage<CostCombinationInfo>(34U, CostCombinationInfo.Parser);

		// Token: 0x04006FB3 RID: 28595
		private readonly RepeatedField<CostCombinationInfo> costCombinationInfos_ = new RepeatedField<CostCombinationInfo>();

		// Token: 0x04006FB4 RID: 28596
		public const int MainPhantomRecommendInfosFieldNumber = 5;

		// Token: 0x04006FB5 RID: 28597
		private static readonly FieldCodec<MainPhantomRecommendInfo> _repeated_mainPhantomRecommendInfos_codec = FieldCodec.ForMessage<MainPhantomRecommendInfo>(42U, MainPhantomRecommendInfo.Parser);

		// Token: 0x04006FB6 RID: 28598
		private readonly RepeatedField<MainPhantomRecommendInfo> mainPhantomRecommendInfos_ = new RepeatedField<MainPhantomRecommendInfo>();
	}
}
