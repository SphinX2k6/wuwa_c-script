using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000226 RID: 550
	public sealed class CalabashMsg : IMessage<CalabashMsg>, IMessage, IEquatable<CalabashMsg>, IDeepCloneable<CalabashMsg>, IBufferMessage
	{
		// Token: 0x06003C25 RID: 15397 RVA: 0x00095BE9 File Offset: 0x00093DE9
		[NullableContext(1)]
		public static CalabashMsg Create()
		{
			return new CalabashMsg();
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x00095BF0 File Offset: 0x00093DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06003C27 RID: 15399 RVA: 0x00095BF3 File Offset: 0x00093DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashMsg.Descriptor;
			}
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00095BFA File Offset: 0x00093DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsg()
		{
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x00095C18 File Offset: 0x00093E18
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

		// Token: 0x06003C2A RID: 15402 RVA: 0x00095C8E File Offset: 0x00093E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashMsg Clone()
		{
			return new CalabashMsg(this);
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06003C2B RID: 15403 RVA: 0x00095C96 File Offset: 0x00093E96
		// (set) Token: 0x06003C2C RID: 15404 RVA: 0x00095C9E File Offset: 0x00093E9E
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

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06003C2D RID: 15405 RVA: 0x00095CA7 File Offset: 0x00093EA7
		// (set) Token: 0x06003C2E RID: 15406 RVA: 0x00095CAF File Offset: 0x00093EAF
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

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06003C2F RID: 15407 RVA: 0x00095CB8 File Offset: 0x00093EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedLevels
		{
			get
			{
				return this.unlockedLevels_;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x00095CC0 File Offset: 0x00093EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CalabashDevelopInfo> UnlockedDevelopRewards
		{
			get
			{
				return this.unlockedDevelopRewards_;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06003C31 RID: 15409 RVA: 0x00095CC8 File Offset: 0x00093EC8
		// (set) Token: 0x06003C32 RID: 15410 RVA: 0x00095CD0 File Offset: 0x00093ED0
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

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06003C33 RID: 15411 RVA: 0x00095CD9 File Offset: 0x00093ED9
		// (set) Token: 0x06003C34 RID: 15412 RVA: 0x00095CE1 File Offset: 0x00093EE1
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

		// Token: 0x06003C35 RID: 15413 RVA: 0x00095CEA File Offset: 0x00093EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashMsg);
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x00095CF8 File Offset: 0x00093EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashMsg other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.Exp == other.Exp && this.unlockedLevels_.Equals(other.unlockedLevels_) && this.unlockedDevelopRewards_.Equals(other.unlockedDevelopRewards_) && this.IdentifyGuaranteeCount == other.IdentifyGuaranteeCount && this.LowCostGuaranteeCount == other.LowCostGuaranteeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x00095D8C File Offset: 0x00093F8C
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

		// Token: 0x06003C38 RID: 15416 RVA: 0x00095E32 File Offset: 0x00094032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x00095E3F File Offset: 0x0009403F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x00095E48 File Offset: 0x00094048
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

		// Token: 0x06003C3B RID: 15419 RVA: 0x00095EFC File Offset: 0x000940FC
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

		// Token: 0x06003C3C RID: 15420 RVA: 0x00095FA8 File Offset: 0x000941A8
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

		// Token: 0x06003C3D RID: 15421 RVA: 0x00096042 File Offset: 0x00094242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x0009604C File Offset: 0x0009424C
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

		// Token: 0x04002CAB RID: 11435
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CAC RID: 11436
		public const int LevelFieldNumber = 1;

		// Token: 0x04002CAD RID: 11437
		private int level_;

		// Token: 0x04002CAE RID: 11438
		public const int ExpFieldNumber = 2;

		// Token: 0x04002CAF RID: 11439
		private int exp_;

		// Token: 0x04002CB0 RID: 11440
		public const int UnlockedLevelsFieldNumber = 3;

		// Token: 0x04002CB1 RID: 11441
		private static readonly FieldCodec<int> _repeated_unlockedLevels_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002CB2 RID: 11442
		private readonly RepeatedField<int> unlockedLevels_ = new RepeatedField<int>();

		// Token: 0x04002CB3 RID: 11443
		public const int UnlockedDevelopRewardsFieldNumber = 4;

		// Token: 0x04002CB4 RID: 11444
		private static readonly FieldCodec<CalabashDevelopInfo> _repeated_unlockedDevelopRewards_codec = FieldCodec.ForMessage<CalabashDevelopInfo>(34U, CalabashDevelopInfo.Parser);

		// Token: 0x04002CB5 RID: 11445
		private readonly RepeatedField<CalabashDevelopInfo> unlockedDevelopRewards_ = new RepeatedField<CalabashDevelopInfo>();

		// Token: 0x04002CB6 RID: 11446
		public const int IdentifyGuaranteeCountFieldNumber = 5;

		// Token: 0x04002CB7 RID: 11447
		private int identifyGuaranteeCount_;

		// Token: 0x04002CB8 RID: 11448
		public const int LowCostGuaranteeCountFieldNumber = 6;

		// Token: 0x04002CB9 RID: 11449
		private int lowCostGuaranteeCount_;
	}
}
