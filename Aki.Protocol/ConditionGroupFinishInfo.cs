using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D0 RID: 720
	public sealed class ConditionGroupFinishInfo : IMessage<ConditionGroupFinishInfo>, IMessage, IEquatable<ConditionGroupFinishInfo>, IDeepCloneable<ConditionGroupFinishInfo>, IBufferMessage
	{
		// Token: 0x06004A12 RID: 18962 RVA: 0x000B5865 File Offset: 0x000B3A65
		[NullableContext(1)]
		public static ConditionGroupFinishInfo Create()
		{
			return new ConditionGroupFinishInfo();
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06004A13 RID: 18963 RVA: 0x000B586C File Offset: 0x000B3A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConditionGroupFinishInfo> Parser
		{
			get
			{
				return ConditionGroupFinishInfo._parser;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06004A14 RID: 18964 RVA: 0x000B5873 File Offset: 0x000B3A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06004A15 RID: 18965 RVA: 0x000B5876 File Offset: 0x000B3A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionGroupFinishInfo.Descriptor;
			}
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x000B587D File Offset: 0x000B3A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupFinishInfo()
		{
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x000B5890 File Offset: 0x000B3A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupFinishInfo(ConditionGroupFinishInfo other) : this()
		{
			this.conditionGroupId_ = other.conditionGroupId_;
			this.finishConditions_ = other.finishConditions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x000B58C6 File Offset: 0x000B3AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupFinishInfo Clone()
		{
			return new ConditionGroupFinishInfo(this);
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06004A19 RID: 18969 RVA: 0x000B58CE File Offset: 0x000B3ACE
		// (set) Token: 0x06004A1A RID: 18970 RVA: 0x000B58D6 File Offset: 0x000B3AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionGroupId
		{
			get
			{
				return this.conditionGroupId_;
			}
			set
			{
				this.conditionGroupId_ = value;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06004A1B RID: 18971 RVA: 0x000B58DF File Offset: 0x000B3ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishConditions
		{
			get
			{
				return this.finishConditions_;
			}
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x000B58E7 File Offset: 0x000B3AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionGroupFinishInfo);
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x000B58F8 File Offset: 0x000B3AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionGroupFinishInfo other)
		{
			return other != null && (other == this || (this.ConditionGroupId == other.ConditionGroupId && this.finishConditions_.Equals(other.finishConditions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x000B5948 File Offset: 0x000B3B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConditionGroupId != 0)
			{
				num ^= this.ConditionGroupId.GetHashCode();
			}
			num ^= this.finishConditions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x000B5995 File Offset: 0x000B3B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x000B59A2 File Offset: 0x000B3BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x000B59AC File Offset: 0x000B3BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConditionGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConditionGroupId);
			}
			this.finishConditions_.WriteTo(ref output, ConditionGroupFinishInfo._repeated_finishConditions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x000B59FC File Offset: 0x000B3BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConditionGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionGroupId);
			}
			num += this.finishConditions_.CalculateSize(ConditionGroupFinishInfo._repeated_finishConditions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x000B5A50 File Offset: 0x000B3C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConditionGroupFinishInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConditionGroupId != 0)
			{
				this.ConditionGroupId = other.ConditionGroupId;
			}
			this.finishConditions_.Add(other.finishConditions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x000B5A9D File Offset: 0x000B3C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x000B5AA8 File Offset: 0x000B3CA8
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.finishConditions_.AddEntriesFrom(ref input, ConditionGroupFinishInfo._repeated_finishConditions_codec);
					}
				}
				else
				{
					this.ConditionGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040030B4 RID: 12468
		private static readonly MessageParser<ConditionGroupFinishInfo> _parser = new MessageParser<ConditionGroupFinishInfo>(() => new ConditionGroupFinishInfo());

		// Token: 0x040030B5 RID: 12469
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030B6 RID: 12470
		public const int ConditionGroupIdFieldNumber = 1;

		// Token: 0x040030B7 RID: 12471
		private int conditionGroupId_;

		// Token: 0x040030B8 RID: 12472
		public const int FinishConditionsFieldNumber = 2;

		// Token: 0x040030B9 RID: 12473
		private static readonly FieldCodec<int> _repeated_finishConditions_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040030BA RID: 12474
		private readonly RepeatedField<int> finishConditions_ = new RepeatedField<int>();
	}
}
