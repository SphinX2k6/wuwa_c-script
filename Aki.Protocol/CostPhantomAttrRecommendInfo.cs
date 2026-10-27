using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030B RID: 779
	public sealed class CostPhantomAttrRecommendInfo : IMessage<CostPhantomAttrRecommendInfo>, IMessage, IEquatable<CostPhantomAttrRecommendInfo>, IDeepCloneable<CostPhantomAttrRecommendInfo>, IBufferMessage
	{
		// Token: 0x06004E81 RID: 20097 RVA: 0x000BE8AB File Offset: 0x000BCAAB
		[NullableContext(1)]
		public static CostPhantomAttrRecommendInfo Create()
		{
			return new CostPhantomAttrRecommendInfo();
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06004E82 RID: 20098 RVA: 0x000BE8B2 File Offset: 0x000BCAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CostPhantomAttrRecommendInfo> Parser
		{
			get
			{
				return CostPhantomAttrRecommendInfo._parser;
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06004E83 RID: 20099 RVA: 0x000BE8B9 File Offset: 0x000BCAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06004E84 RID: 20100 RVA: 0x000BE8BC File Offset: 0x000BCABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CostPhantomAttrRecommendInfo.Descriptor;
			}
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x000BE8C3 File Offset: 0x000BCAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostPhantomAttrRecommendInfo()
		{
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x000BE8E4 File Offset: 0x000BCAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostPhantomAttrRecommendInfo(CostPhantomAttrRecommendInfo other) : this()
		{
			this.cost_ = other.cost_;
			this.mainAttrRecommendInfos_ = other.mainAttrRecommendInfos_.Clone();
			this.viceAttrRecommendInfos_ = other.viceAttrRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x000BE936 File Offset: 0x000BCB36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostPhantomAttrRecommendInfo Clone()
		{
			return new CostPhantomAttrRecommendInfo(this);
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06004E88 RID: 20104 RVA: 0x000BE93E File Offset: 0x000BCB3E
		// (set) Token: 0x06004E89 RID: 20105 RVA: 0x000BE946 File Offset: 0x000BCB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Cost
		{
			get
			{
				return this.cost_;
			}
			set
			{
				this.cost_ = value;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06004E8A RID: 20106 RVA: 0x000BE94F File Offset: 0x000BCB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomAttrRecommendInfo> MainAttrRecommendInfos
		{
			get
			{
				return this.mainAttrRecommendInfos_;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06004E8B RID: 20107 RVA: 0x000BE957 File Offset: 0x000BCB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomAttrRecommendInfo> ViceAttrRecommendInfos
		{
			get
			{
				return this.viceAttrRecommendInfos_;
			}
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x000BE95F File Offset: 0x000BCB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CostPhantomAttrRecommendInfo);
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x000BE970 File Offset: 0x000BCB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CostPhantomAttrRecommendInfo other)
		{
			return other != null && (other == this || (this.Cost == other.Cost && this.mainAttrRecommendInfos_.Equals(other.mainAttrRecommendInfos_) && this.viceAttrRecommendInfos_.Equals(other.viceAttrRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E8E RID: 20110 RVA: 0x000BE9D4 File Offset: 0x000BCBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Cost != 0)
			{
				num ^= this.Cost.GetHashCode();
			}
			num ^= this.mainAttrRecommendInfos_.GetHashCode();
			num ^= this.viceAttrRecommendInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E8F RID: 20111 RVA: 0x000BEA2F File Offset: 0x000BCC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E90 RID: 20112 RVA: 0x000BEA3C File Offset: 0x000BCC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x000BEA48 File Offset: 0x000BCC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Cost != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Cost);
			}
			this.mainAttrRecommendInfos_.WriteTo(ref output, CostPhantomAttrRecommendInfo._repeated_mainAttrRecommendInfos_codec);
			this.viceAttrRecommendInfos_.WriteTo(ref output, CostPhantomAttrRecommendInfo._repeated_viceAttrRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x000BEAA8 File Offset: 0x000BCCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Cost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Cost);
			}
			num += this.mainAttrRecommendInfos_.CalculateSize(CostPhantomAttrRecommendInfo._repeated_mainAttrRecommendInfos_codec);
			num += this.viceAttrRecommendInfos_.CalculateSize(CostPhantomAttrRecommendInfo._repeated_viceAttrRecommendInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x000BEB0C File Offset: 0x000BCD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CostPhantomAttrRecommendInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Cost != 0)
			{
				this.Cost = other.Cost;
			}
			this.mainAttrRecommendInfos_.Add(other.mainAttrRecommendInfos_);
			this.viceAttrRecommendInfos_.Add(other.viceAttrRecommendInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x000BEB6A File Offset: 0x000BCD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x000BEB74 File Offset: 0x000BCD74
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.viceAttrRecommendInfos_.AddEntriesFrom(ref input, CostPhantomAttrRecommendInfo._repeated_viceAttrRecommendInfos_codec);
						}
					}
					else
					{
						this.mainAttrRecommendInfos_.AddEntriesFrom(ref input, CostPhantomAttrRecommendInfo._repeated_mainAttrRecommendInfos_codec);
					}
				}
				else
				{
					this.Cost = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003199 RID: 12697
		private static readonly MessageParser<CostPhantomAttrRecommendInfo> _parser = new MessageParser<CostPhantomAttrRecommendInfo>(() => new CostPhantomAttrRecommendInfo());

		// Token: 0x0400319A RID: 12698
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400319B RID: 12699
		public const int CostFieldNumber = 1;

		// Token: 0x0400319C RID: 12700
		private int cost_;

		// Token: 0x0400319D RID: 12701
		public const int MainAttrRecommendInfosFieldNumber = 2;

		// Token: 0x0400319E RID: 12702
		private static readonly FieldCodec<PhantomAttrRecommendInfo> _repeated_mainAttrRecommendInfos_codec = FieldCodec.ForMessage<PhantomAttrRecommendInfo>(18U, PhantomAttrRecommendInfo.Parser);

		// Token: 0x0400319F RID: 12703
		private readonly RepeatedField<PhantomAttrRecommendInfo> mainAttrRecommendInfos_ = new RepeatedField<PhantomAttrRecommendInfo>();

		// Token: 0x040031A0 RID: 12704
		public const int ViceAttrRecommendInfosFieldNumber = 3;

		// Token: 0x040031A1 RID: 12705
		private static readonly FieldCodec<PhantomAttrRecommendInfo> _repeated_viceAttrRecommendInfos_codec = FieldCodec.ForMessage<PhantomAttrRecommendInfo>(26U, PhantomAttrRecommendInfo.Parser);

		// Token: 0x040031A2 RID: 12706
		private readonly RepeatedField<PhantomAttrRecommendInfo> viceAttrRecommendInfos_ = new RepeatedField<PhantomAttrRecommendInfo>();
	}
}
