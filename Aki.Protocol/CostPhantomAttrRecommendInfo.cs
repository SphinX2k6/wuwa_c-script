using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000312 RID: 786
	public sealed class CostPhantomAttrRecommendInfo : IMessage<CostPhantomAttrRecommendInfo>, IMessage, IEquatable<CostPhantomAttrRecommendInfo>, IDeepCloneable<CostPhantomAttrRecommendInfo>, IBufferMessage
	{
		// Token: 0x06004F5A RID: 20314 RVA: 0x000C0C97 File Offset: 0x000BEE97
		[NullableContext(1)]
		public static CostPhantomAttrRecommendInfo Create()
		{
			return new CostPhantomAttrRecommendInfo();
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x000C0C9E File Offset: 0x000BEE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CostPhantomAttrRecommendInfo> Parser
		{
			get
			{
				return CostPhantomAttrRecommendInfo._parser;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06004F5C RID: 20316 RVA: 0x000C0CA5 File Offset: 0x000BEEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06004F5D RID: 20317 RVA: 0x000C0CA8 File Offset: 0x000BEEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CostPhantomAttrRecommendInfo.Descriptor;
			}
		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x000C0CAF File Offset: 0x000BEEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostPhantomAttrRecommendInfo()
		{
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x000C0CD0 File Offset: 0x000BEED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostPhantomAttrRecommendInfo(CostPhantomAttrRecommendInfo other) : this()
		{
			this.cost_ = other.cost_;
			this.mainAttrRecommendInfos_ = other.mainAttrRecommendInfos_.Clone();
			this.viceAttrRecommendInfos_ = other.viceAttrRecommendInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x000C0D22 File Offset: 0x000BEF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CostPhantomAttrRecommendInfo Clone()
		{
			return new CostPhantomAttrRecommendInfo(this);
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06004F61 RID: 20321 RVA: 0x000C0D2A File Offset: 0x000BEF2A
		// (set) Token: 0x06004F62 RID: 20322 RVA: 0x000C0D32 File Offset: 0x000BEF32
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

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06004F63 RID: 20323 RVA: 0x000C0D3B File Offset: 0x000BEF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomAttrRecommendInfo> MainAttrRecommendInfos
		{
			get
			{
				return this.mainAttrRecommendInfos_;
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06004F64 RID: 20324 RVA: 0x000C0D43 File Offset: 0x000BEF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomAttrRecommendInfo> ViceAttrRecommendInfos
		{
			get
			{
				return this.viceAttrRecommendInfos_;
			}
		}

		// Token: 0x06004F65 RID: 20325 RVA: 0x000C0D4B File Offset: 0x000BEF4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CostPhantomAttrRecommendInfo);
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x000C0D5C File Offset: 0x000BEF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CostPhantomAttrRecommendInfo other)
		{
			return other != null && (other == this || (this.Cost == other.Cost && this.mainAttrRecommendInfos_.Equals(other.mainAttrRecommendInfos_) && this.viceAttrRecommendInfos_.Equals(other.viceAttrRecommendInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x000C0DC0 File Offset: 0x000BEFC0
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

		// Token: 0x06004F68 RID: 20328 RVA: 0x000C0E1B File Offset: 0x000BF01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x000C0E28 File Offset: 0x000BF028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x000C0E34 File Offset: 0x000BF034
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

		// Token: 0x06004F6B RID: 20331 RVA: 0x000C0E94 File Offset: 0x000BF094
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

		// Token: 0x06004F6C RID: 20332 RVA: 0x000C0EF8 File Offset: 0x000BF0F8
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

		// Token: 0x06004F6D RID: 20333 RVA: 0x000C0F56 File Offset: 0x000BF156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x000C0F60 File Offset: 0x000BF160
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

		// Token: 0x04003230 RID: 12848
		private static readonly MessageParser<CostPhantomAttrRecommendInfo> _parser = new MessageParser<CostPhantomAttrRecommendInfo>(() => new CostPhantomAttrRecommendInfo());

		// Token: 0x04003231 RID: 12849
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003232 RID: 12850
		public const int CostFieldNumber = 1;

		// Token: 0x04003233 RID: 12851
		private int cost_;

		// Token: 0x04003234 RID: 12852
		public const int MainAttrRecommendInfosFieldNumber = 2;

		// Token: 0x04003235 RID: 12853
		private static readonly FieldCodec<PhantomAttrRecommendInfo> _repeated_mainAttrRecommendInfos_codec = FieldCodec.ForMessage<PhantomAttrRecommendInfo>(18U, PhantomAttrRecommendInfo.Parser);

		// Token: 0x04003236 RID: 12854
		private readonly RepeatedField<PhantomAttrRecommendInfo> mainAttrRecommendInfos_ = new RepeatedField<PhantomAttrRecommendInfo>();

		// Token: 0x04003237 RID: 12855
		public const int ViceAttrRecommendInfosFieldNumber = 3;

		// Token: 0x04003238 RID: 12856
		private static readonly FieldCodec<PhantomAttrRecommendInfo> _repeated_viceAttrRecommendInfos_codec = FieldCodec.ForMessage<PhantomAttrRecommendInfo>(26U, PhantomAttrRecommendInfo.Parser);

		// Token: 0x04003239 RID: 12857
		private readonly RepeatedField<PhantomAttrRecommendInfo> viceAttrRecommendInfos_ = new RepeatedField<PhantomAttrRecommendInfo>();
	}
}
