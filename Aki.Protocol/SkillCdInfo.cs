using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001236 RID: 4662
	public sealed class SkillCdInfo : IMessage<SkillCdInfo>, IMessage, IEquatable<SkillCdInfo>, IDeepCloneable<SkillCdInfo>, IBufferMessage
	{
		// Token: 0x06018D83 RID: 101763 RVA: 0x0039D7CE File Offset: 0x0039B9CE
		[NullableContext(1)]
		public static SkillCdInfo Create()
		{
			return new SkillCdInfo();
		}

		// Token: 0x170053C2 RID: 21442
		// (get) Token: 0x06018D84 RID: 101764 RVA: 0x0039D7D5 File Offset: 0x0039B9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkillCdInfo> Parser
		{
			get
			{
				return SkillCdInfo._parser;
			}
		}

		// Token: 0x170053C3 RID: 21443
		// (get) Token: 0x06018D85 RID: 101765 RVA: 0x0039D7DC File Offset: 0x0039B9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053C4 RID: 21444
		// (get) Token: 0x06018D86 RID: 101766 RVA: 0x0039D7DF File Offset: 0x0039B9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillCdInfo.Descriptor;
			}
		}

		// Token: 0x06018D87 RID: 101767 RVA: 0x0039D7E6 File Offset: 0x0039B9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdInfo()
		{
		}

		// Token: 0x06018D88 RID: 101768 RVA: 0x0039D7F9 File Offset: 0x0039B9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdInfo(SkillCdInfo other) : this()
		{
			this.skillId_ = other.skillId_;
			this.cdEndTimeList_ = other.cdEndTimeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D89 RID: 101769 RVA: 0x0039D82F File Offset: 0x0039BA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillCdInfo Clone()
		{
			return new SkillCdInfo(this);
		}

		// Token: 0x170053C5 RID: 21445
		// (get) Token: 0x06018D8A RID: 101770 RVA: 0x0039D837 File Offset: 0x0039BA37
		// (set) Token: 0x06018D8B RID: 101771 RVA: 0x0039D83F File Offset: 0x0039BA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x170053C6 RID: 21446
		// (get) Token: 0x06018D8C RID: 101772 RVA: 0x0039D848 File Offset: 0x0039BA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> CdEndTimeList
		{
			get
			{
				return this.cdEndTimeList_;
			}
		}

		// Token: 0x06018D8D RID: 101773 RVA: 0x0039D850 File Offset: 0x0039BA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillCdInfo);
		}

		// Token: 0x06018D8E RID: 101774 RVA: 0x0039D860 File Offset: 0x0039BA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillCdInfo other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.cdEndTimeList_.Equals(other.cdEndTimeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D8F RID: 101775 RVA: 0x0039D8B0 File Offset: 0x0039BAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			num ^= this.cdEndTimeList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D90 RID: 101776 RVA: 0x0039D8FD File Offset: 0x0039BAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D91 RID: 101777 RVA: 0x0039D90A File Offset: 0x0039BB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D92 RID: 101778 RVA: 0x0039D914 File Offset: 0x0039BB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SkillId);
			}
			this.cdEndTimeList_.WriteTo(ref output, SkillCdInfo._repeated_cdEndTimeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D93 RID: 101779 RVA: 0x0039D964 File Offset: 0x0039BB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			num += this.cdEndTimeList_.CalculateSize(SkillCdInfo._repeated_cdEndTimeList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D94 RID: 101780 RVA: 0x0039D9B8 File Offset: 0x0039BBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillCdInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			this.cdEndTimeList_.Add(other.cdEndTimeList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D95 RID: 101781 RVA: 0x0039DA05 File Offset: 0x0039BC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D96 RID: 101782 RVA: 0x0039DA10 File Offset: 0x0039BC10
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
						this.cdEndTimeList_.AddEntriesFrom(ref input, SkillCdInfo._repeated_cdEndTimeList_codec);
					}
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400928C RID: 37516
		private static readonly MessageParser<SkillCdInfo> _parser = new MessageParser<SkillCdInfo>(() => new SkillCdInfo());

		// Token: 0x0400928D RID: 37517
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400928E RID: 37518
		public const int SkillIdFieldNumber = 1;

		// Token: 0x0400928F RID: 37519
		private long skillId_;

		// Token: 0x04009290 RID: 37520
		public const int CdEndTimeListFieldNumber = 2;

		// Token: 0x04009291 RID: 37521
		private static readonly FieldCodec<long> _repeated_cdEndTimeList_codec = FieldCodec.ForInt64(18U);

		// Token: 0x04009292 RID: 37522
		private readonly RepeatedField<long> cdEndTimeList_ = new RepeatedField<long>();
	}
}
