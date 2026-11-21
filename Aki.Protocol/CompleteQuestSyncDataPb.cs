using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CA RID: 714
	public sealed class CompleteQuestSyncDataPb : IMessage<CompleteQuestSyncDataPb>, IMessage, IEquatable<CompleteQuestSyncDataPb>, IDeepCloneable<CompleteQuestSyncDataPb>, IBufferMessage
	{
		// Token: 0x06004991 RID: 18833 RVA: 0x000B4479 File Offset: 0x000B2679
		[NullableContext(1)]
		public static CompleteQuestSyncDataPb Create()
		{
			return new CompleteQuestSyncDataPb();
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06004992 RID: 18834 RVA: 0x000B4480 File Offset: 0x000B2680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06004993 RID: 18835 RVA: 0x000B4483 File Offset: 0x000B2683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CompleteQuestSyncDataPb.Descriptor;
			}
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x000B448A File Offset: 0x000B268A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteQuestSyncDataPb()
		{
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x000B449D File Offset: 0x000B269D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteQuestSyncDataPb(CompleteQuestSyncDataPb other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x000B44C7 File Offset: 0x000B26C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteQuestSyncDataPb Clone()
		{
			return new CompleteQuestSyncDataPb(this);
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06004997 RID: 18839 RVA: 0x000B44CF File Offset: 0x000B26CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x000B44D7 File Offset: 0x000B26D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CompleteQuestSyncDataPb);
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x000B44E5 File Offset: 0x000B26E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CompleteQuestSyncDataPb other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x000B4518 File Offset: 0x000B2718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x000B454C File Offset: 0x000B274C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x000B4559 File Offset: 0x000B2759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x000B4562 File Offset: 0x000B2762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questId_.WriteTo(ref output, CompleteQuestSyncDataPb._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x000B458C File Offset: 0x000B278C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questId_.CalculateSize(CompleteQuestSyncDataPb._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x000B45C5 File Offset: 0x000B27C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CompleteQuestSyncDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.questId_.Add(other.questId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x000B45F3 File Offset: 0x000B27F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x000B45FC File Offset: 0x000B27FC
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questId_.AddEntriesFrom(ref input, CompleteQuestSyncDataPb._repeated_questId_codec);
				}
			}
		}

		// Token: 0x04003089 RID: 12425
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400308A RID: 12426
		public const int QuestIdFieldNumber = 1;

		// Token: 0x0400308B RID: 12427
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400308C RID: 12428
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
