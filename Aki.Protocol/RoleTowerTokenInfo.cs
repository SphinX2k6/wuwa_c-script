using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FC RID: 4348
	public sealed class RoleTowerTokenInfo : IMessage<RoleTowerTokenInfo>, IMessage, IEquatable<RoleTowerTokenInfo>, IDeepCloneable<RoleTowerTokenInfo>, IBufferMessage
	{
		// Token: 0x060173EA RID: 95210 RVA: 0x0036218F File Offset: 0x0036038F
		[NullableContext(1)]
		public static RoleTowerTokenInfo Create()
		{
			return new RoleTowerTokenInfo();
		}

		// Token: 0x17004E18 RID: 19992
		// (get) Token: 0x060173EB RID: 95211 RVA: 0x00362196 File Offset: 0x00360396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerTokenInfo> Parser
		{
			get
			{
				return RoleTowerTokenInfo._parser;
			}
		}

		// Token: 0x17004E19 RID: 19993
		// (get) Token: 0x060173EC RID: 95212 RVA: 0x0036219D File Offset: 0x0036039D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E1A RID: 19994
		// (get) Token: 0x060173ED RID: 95213 RVA: 0x003621A0 File Offset: 0x003603A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerTokenInfo.Descriptor;
			}
		}

		// Token: 0x060173EE RID: 95214 RVA: 0x003621A7 File Offset: 0x003603A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenInfo()
		{
		}

		// Token: 0x060173EF RID: 95215 RVA: 0x003621B0 File Offset: 0x003603B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenInfo(RoleTowerTokenInfo other) : this()
		{
			this.tokenId_ = other.tokenId_;
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.isRecommend_ = other.isRecommend_;
			this.remainUseCount_ = other.remainUseCount_;
			this.cdEndTimeMs_ = other.cdEndTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060173F0 RID: 95216 RVA: 0x0036221C File Offset: 0x0036041C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenInfo Clone()
		{
			return new RoleTowerTokenInfo(this);
		}

		// Token: 0x17004E1B RID: 19995
		// (get) Token: 0x060173F1 RID: 95217 RVA: 0x00362224 File Offset: 0x00360424
		// (set) Token: 0x060173F2 RID: 95218 RVA: 0x0036222C File Offset: 0x0036042C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TokenId
		{
			get
			{
				return this.tokenId_;
			}
			set
			{
				this.tokenId_ = value;
			}
		}

		// Token: 0x17004E1C RID: 19996
		// (get) Token: 0x060173F3 RID: 95219 RVA: 0x00362235 File Offset: 0x00360435
		// (set) Token: 0x060173F4 RID: 95220 RVA: 0x0036223D File Offset: 0x0036043D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17004E1D RID: 19997
		// (get) Token: 0x060173F5 RID: 95221 RVA: 0x00362246 File Offset: 0x00360446
		// (set) Token: 0x060173F6 RID: 95222 RVA: 0x0036224E File Offset: 0x0036044E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17004E1E RID: 19998
		// (get) Token: 0x060173F7 RID: 95223 RVA: 0x00362257 File Offset: 0x00360457
		// (set) Token: 0x060173F8 RID: 95224 RVA: 0x0036225F File Offset: 0x0036045F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRecommend
		{
			get
			{
				return this.isRecommend_;
			}
			set
			{
				this.isRecommend_ = value;
			}
		}

		// Token: 0x17004E1F RID: 19999
		// (get) Token: 0x060173F9 RID: 95225 RVA: 0x00362268 File Offset: 0x00360468
		// (set) Token: 0x060173FA RID: 95226 RVA: 0x00362270 File Offset: 0x00360470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainUseCount
		{
			get
			{
				return this.remainUseCount_;
			}
			set
			{
				this.remainUseCount_ = value;
			}
		}

		// Token: 0x17004E20 RID: 20000
		// (get) Token: 0x060173FB RID: 95227 RVA: 0x00362279 File Offset: 0x00360479
		// (set) Token: 0x060173FC RID: 95228 RVA: 0x00362281 File Offset: 0x00360481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CdEndTimeMs
		{
			get
			{
				return this.cdEndTimeMs_;
			}
			set
			{
				this.cdEndTimeMs_ = value;
			}
		}

		// Token: 0x060173FD RID: 95229 RVA: 0x0036228A File Offset: 0x0036048A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerTokenInfo);
		}

		// Token: 0x060173FE RID: 95230 RVA: 0x00362298 File Offset: 0x00360498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerTokenInfo other)
		{
			return other != null && (other == this || (this.TokenId == other.TokenId && this.ItemId == other.ItemId && this.Count == other.Count && this.IsRecommend == other.IsRecommend && this.RemainUseCount == other.RemainUseCount && this.CdEndTimeMs == other.CdEndTimeMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060173FF RID: 95231 RVA: 0x00362324 File Offset: 0x00360524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TokenId != 0)
			{
				num ^= this.TokenId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.IsRecommend)
			{
				num ^= this.IsRecommend.GetHashCode();
			}
			if (this.RemainUseCount != 0)
			{
				num ^= this.RemainUseCount.GetHashCode();
			}
			if (this.CdEndTimeMs != 0L)
			{
				num ^= this.CdEndTimeMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017400 RID: 95232 RVA: 0x003623E0 File Offset: 0x003605E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017401 RID: 95233 RVA: 0x003623ED File Offset: 0x003605ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017402 RID: 95234 RVA: 0x003623F8 File Offset: 0x003605F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TokenId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TokenId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Count);
			}
			if (this.IsRecommend)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsRecommend);
			}
			if (this.RemainUseCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RemainUseCount);
			}
			if (this.CdEndTimeMs != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.CdEndTimeMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017403 RID: 95235 RVA: 0x003624C0 File Offset: 0x003606C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TokenId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TokenId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.IsRecommend)
			{
				num += 2;
			}
			if (this.RemainUseCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainUseCount);
			}
			if (this.CdEndTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CdEndTimeMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017404 RID: 95236 RVA: 0x0036256C File Offset: 0x0036076C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerTokenInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TokenId != 0)
			{
				this.TokenId = other.TokenId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.IsRecommend)
			{
				this.IsRecommend = other.IsRecommend;
			}
			if (other.RemainUseCount != 0)
			{
				this.RemainUseCount = other.RemainUseCount;
			}
			if (other.CdEndTimeMs != 0L)
			{
				this.CdEndTimeMs = other.CdEndTimeMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017405 RID: 95237 RVA: 0x0036260C File Offset: 0x0036080C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017406 RID: 95238 RVA: 0x00362618 File Offset: 0x00360818
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.TokenId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.IsRecommend = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.RemainUseCount = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.CdEndTimeMs = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008B03 RID: 35587
		private static readonly MessageParser<RoleTowerTokenInfo> _parser = new MessageParser<RoleTowerTokenInfo>(() => new RoleTowerTokenInfo());

		// Token: 0x04008B04 RID: 35588
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B05 RID: 35589
		public const int TokenIdFieldNumber = 1;

		// Token: 0x04008B06 RID: 35590
		private int tokenId_;

		// Token: 0x04008B07 RID: 35591
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04008B08 RID: 35592
		private int itemId_;

		// Token: 0x04008B09 RID: 35593
		public const int CountFieldNumber = 3;

		// Token: 0x04008B0A RID: 35594
		private int count_;

		// Token: 0x04008B0B RID: 35595
		public const int IsRecommendFieldNumber = 8;

		// Token: 0x04008B0C RID: 35596
		private bool isRecommend_;

		// Token: 0x04008B0D RID: 35597
		public const int RemainUseCountFieldNumber = 9;

		// Token: 0x04008B0E RID: 35598
		private int remainUseCount_;

		// Token: 0x04008B0F RID: 35599
		public const int CdEndTimeMsFieldNumber = 10;

		// Token: 0x04008B10 RID: 35600
		private long cdEndTimeMs_;
	}
}
