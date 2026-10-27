using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000221 RID: 545
	public sealed class CalabashMsg : IMessage<CalabashMsg>, IMessage, IEquatable<CalabashMsg>, IDeepCloneable<CalabashMsg>, IBufferMessage
	{
		// Token: 0x06003B80 RID: 15232 RVA: 0x00093FD1 File Offset: 0x000921D1
		[NullableContext(1)]
		public static CalabashMsg Create()
		{
			return new CalabashMsg();
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06003B81 RID: 15233 RVA: 0x00093FD8 File Offset: 0x000921D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06003B82 RID: 15234 RVA: 0x00093FDB File Offset: 0x000921DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashMsg.Descriptor;
			}
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x00093FE2 File Offset: 0x000921E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsg()
		{
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x00094000 File Offset: 0x00092200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsg(CalabashMsg other) : this()
		{
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.unlockedLevels_ = other.unlockedLevels_.Clone();
			this.unlockedDevelopRewards_ = other.unlockedDevelopRewards_.Clone();
			this.identifyGuaranteeCount_ = other.identifyGuaranteeCount_;
			this.lowCostGuaranteeCount_ = other.lowCostGuaranteeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00094076 File Offset: 0x00092276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsg Clone()
		{
			return new CalabashMsg(this);
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06003B86 RID: 15238 RVA: 0x0009407E File Offset: 0x0009227E
		// (set) Token: 0x06003B87 RID: 15239 RVA: 0x00094086 File Offset: 0x00092286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x0009408F File Offset: 0x0009228F
		// (set) Token: 0x06003B89 RID: 15241 RVA: 0x00094097 File Offset: 0x00092297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06003B8A RID: 15242 RVA: 0x000940A0 File Offset: 0x000922A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedLevels
		{
			get
			{
				return this.unlockedLevels_;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06003B8B RID: 15243 RVA: 0x000940A8 File Offset: 0x000922A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CalabashDevelopInfo> UnlockedDevelopRewards
		{
			get
			{
				return this.unlockedDevelopRewards_;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06003B8C RID: 15244 RVA: 0x000940B0 File Offset: 0x000922B0
		// (set) Token: 0x06003B8D RID: 15245 RVA: 0x000940B8 File Offset: 0x000922B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IdentifyGuaranteeCount
		{
			get
			{
				return this.identifyGuaranteeCount_;
			}
			set
			{
				this.identifyGuaranteeCount_ = value;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06003B8E RID: 15246 RVA: 0x000940C1 File Offset: 0x000922C1
		// (set) Token: 0x06003B8F RID: 15247 RVA: 0x000940C9 File Offset: 0x000922C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LowCostGuaranteeCount
		{
			get
			{
				return this.lowCostGuaranteeCount_;
			}
			set
			{
				this.lowCostGuaranteeCount_ = value;
			}
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x000940D2 File Offset: 0x000922D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashMsg);
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x000940E0 File Offset: 0x000922E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashMsg other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.Exp == other.Exp && this.unlockedLevels_.Equals(other.unlockedLevels_) && this.unlockedDevelopRewards_.Equals(other.unlockedDevelopRewards_) && this.IdentifyGuaranteeCount == other.IdentifyGuaranteeCount && this.LowCostGuaranteeCount == other.LowCostGuaranteeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x00094174 File Offset: 0x00092374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			num ^= this.unlockedLevels_.GetHashCode();
			num ^= this.unlockedDevelopRewards_.GetHashCode();
			if (this.IdentifyGuaranteeCount != 0)
			{
				num ^= this.IdentifyGuaranteeCount.GetHashCode();
			}
			if (this.LowCostGuaranteeCount != 0)
			{
				num ^= this.LowCostGuaranteeCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x0009421A File Offset: 0x0009241A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x00094227 File Offset: 0x00092427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x00094230 File Offset: 0x00092430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Exp);
			}
			this.unlockedLevels_.WriteTo(ref output, CalabashMsg._repeated_unlockedLevels_codec);
			this.unlockedDevelopRewards_.WriteTo(ref output, CalabashMsg._repeated_unlockedDevelopRewards_codec);
			if (this.IdentifyGuaranteeCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IdentifyGuaranteeCount);
			}
			if (this.LowCostGuaranteeCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LowCostGuaranteeCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x000942E4 File Offset: 0x000924E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			num += this.unlockedLevels_.CalculateSize(CalabashMsg._repeated_unlockedLevels_codec);
			num += this.unlockedDevelopRewards_.CalculateSize(CalabashMsg._repeated_unlockedDevelopRewards_codec);
			if (this.IdentifyGuaranteeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IdentifyGuaranteeCount);
			}
			if (this.LowCostGuaranteeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LowCostGuaranteeCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x00094390 File Offset: 0x00092590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashMsg other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			this.unlockedLevels_.Add(other.unlockedLevels_);
			this.unlockedDevelopRewards_.Add(other.unlockedDevelopRewards_);
			if (other.IdentifyGuaranteeCount != 0)
			{
				this.IdentifyGuaranteeCount = other.IdentifyGuaranteeCount;
			}
			if (other.LowCostGuaranteeCount != 0)
			{
				this.LowCostGuaranteeCount = other.LowCostGuaranteeCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x0009442A File Offset: 0x0009262A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00094434 File Offset: 0x00092634
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
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_6C;
					}
				}
				else if (num <= 34U)
				{
					if (num == 26U)
					{
						goto IL_6C;
					}
					if (num == 34U)
					{
						this.unlockedDevelopRewards_.AddEntriesFrom(ref input, CalabashMsg._repeated_unlockedDevelopRewards_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.IdentifyGuaranteeCount = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.LowCostGuaranteeCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_6C:
				this.unlockedLevels_.AddEntriesFrom(ref input, CalabashMsg._repeated_unlockedLevels_codec);
			}
		}

		// Token: 0x04002C29 RID: 11305
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C2A RID: 11306
		public const int LevelFieldNumber = 1;

		// Token: 0x04002C2B RID: 11307
		private int level_;

		// Token: 0x04002C2C RID: 11308
		public const int ExpFieldNumber = 2;

		// Token: 0x04002C2D RID: 11309
		private int exp_;

		// Token: 0x04002C2E RID: 11310
		public const int UnlockedLevelsFieldNumber = 3;

		// Token: 0x04002C2F RID: 11311
		private static readonly FieldCodec<int> _repeated_unlockedLevels_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002C30 RID: 11312
		private readonly RepeatedField<int> unlockedLevels_ = new RepeatedField<int>();

		// Token: 0x04002C31 RID: 11313
		public const int UnlockedDevelopRewardsFieldNumber = 4;

		// Token: 0x04002C32 RID: 11314
		private static readonly FieldCodec<CalabashDevelopInfo> _repeated_unlockedDevelopRewards_codec = FieldCodec.ForMessage<CalabashDevelopInfo>(34U, CalabashDevelopInfo.Parser);

		// Token: 0x04002C33 RID: 11315
		private readonly RepeatedField<CalabashDevelopInfo> unlockedDevelopRewards_ = new RepeatedField<CalabashDevelopInfo>();

		// Token: 0x04002C34 RID: 11316
		public const int IdentifyGuaranteeCountFieldNumber = 5;

		// Token: 0x04002C35 RID: 11317
		private int identifyGuaranteeCount_;

		// Token: 0x04002C36 RID: 11318
		public const int LowCostGuaranteeCountFieldNumber = 6;

		// Token: 0x04002C37 RID: 11319
		private int lowCostGuaranteeCount_;
	}
}
