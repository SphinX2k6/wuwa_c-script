using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C1 RID: 449
	public sealed class BossPilingActivityInfo : IMessage<BossPilingActivityInfo>, IMessage, IEquatable<BossPilingActivityInfo>, IDeepCloneable<BossPilingActivityInfo>, IBufferMessage
	{
		// Token: 0x060033B0 RID: 13232 RVA: 0x00082B13 File Offset: 0x00080D13
		[NullableContext(1)]
		public static BossPilingActivityInfo Create()
		{
			return new BossPilingActivityInfo();
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060033B1 RID: 13233 RVA: 0x00082B1A File Offset: 0x00080D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060033B2 RID: 13234 RVA: 0x00082B1D File Offset: 0x00080D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingActivityInfo.Descriptor;
			}
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x00082B24 File Offset: 0x00080D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingActivityInfo()
		{
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x00082B42 File Offset: 0x00080D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingActivityInfo(BossPilingActivityInfo other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.bossPilingLevelInfos_ = other.bossPilingLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x00082B7D File Offset: 0x00080D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingActivityInfo Clone()
		{
			return new BossPilingActivityInfo(this);
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060033B6 RID: 13238 RVA: 0x00082B85 File Offset: 0x00080D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x00082B8D File Offset: 0x00080D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossPilingLevelInfo> BossPilingLevelInfos
		{
			get
			{
				return this.bossPilingLevelInfos_;
			}
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x00082B95 File Offset: 0x00080D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingActivityInfo);
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x00082BA4 File Offset: 0x00080DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingActivityInfo other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && this.bossPilingLevelInfos_.Equals(other.bossPilingLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x00082BF8 File Offset: 0x00080DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.conditionTasks_.GetHashCode();
			num ^= this.bossPilingLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x00082C3A File Offset: 0x00080E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00082C47 File Offset: 0x00080E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00082C50 File Offset: 0x00080E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, BossPilingActivityInfo._repeated_conditionTasks_codec);
			this.bossPilingLevelInfos_.WriteTo(ref output, BossPilingActivityInfo._repeated_bossPilingLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00082C88 File Offset: 0x00080E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(BossPilingActivityInfo._repeated_conditionTasks_codec);
			num += this.bossPilingLevelInfos_.CalculateSize(BossPilingActivityInfo._repeated_bossPilingLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00082CD4 File Offset: 0x00080ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this.bossPilingLevelInfos_.Add(other.bossPilingLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00082D13 File Offset: 0x00080F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00082D1C File Offset: 0x00080F1C
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.bossPilingLevelInfos_.AddEntriesFrom(ref input, BossPilingActivityInfo._repeated_bossPilingLevelInfos_codec);
					}
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, BossPilingActivityInfo._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x040029CC RID: 10700
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029CD RID: 10701
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x040029CE RID: 10702
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x040029CF RID: 10703
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x040029D0 RID: 10704
		public const int BossPilingLevelInfosFieldNumber = 2;

		// Token: 0x040029D1 RID: 10705
		private static readonly FieldCodec<BossPilingLevelInfo> _repeated_bossPilingLevelInfos_codec = FieldCodec.ForMessage<BossPilingLevelInfo>(18U, BossPilingLevelInfo.Parser);

		// Token: 0x040029D2 RID: 10706
		private readonly RepeatedField<BossPilingLevelInfo> bossPilingLevelInfos_ = new RepeatedField<BossPilingLevelInfo>();
	}
}
