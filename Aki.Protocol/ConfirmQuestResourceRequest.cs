using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D1 RID: 721
	[NetMessage(EMessageId.ConfirmQuestResourceRequest)]
	public sealed class ConfirmQuestResourceRequest : IMessage<ConfirmQuestResourceRequest>, IMessage, IEquatable<ConfirmQuestResourceRequest>, IDeepCloneable<ConfirmQuestResourceRequest>, IBufferMessage
	{
		// Token: 0x060049E4 RID: 18916 RVA: 0x000B4B85 File Offset: 0x000B2D85
		[NullableContext(1)]
		public static ConfirmQuestResourceRequest Create()
		{
			return new ConfirmQuestResourceRequest();
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060049E5 RID: 18917 RVA: 0x000B4B8C File Offset: 0x000B2D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060049E6 RID: 18918 RVA: 0x000B4B8F File Offset: 0x000B2D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConfirmQuestResourceRequest.Descriptor;
			}
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x000B4B96 File Offset: 0x000B2D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceRequest()
		{
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x000B4BA9 File Offset: 0x000B2DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceRequest(ConfirmQuestResourceRequest other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x000B4BD3 File Offset: 0x000B2DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceRequest Clone()
		{
			return new ConfirmQuestResourceRequest(this);
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x000B4BDB File Offset: 0x000B2DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x000B4BE3 File Offset: 0x000B2DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConfirmQuestResourceRequest);
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x000B4BF1 File Offset: 0x000B2DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConfirmQuestResourceRequest other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x000B4C24 File Offset: 0x000B2E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x000B4C58 File Offset: 0x000B2E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x000B4C65 File Offset: 0x000B2E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x000B4C6E File Offset: 0x000B2E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questIds_.WriteTo(ref output, ConfirmQuestResourceRequest._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x000B4C98 File Offset: 0x000B2E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questIds_.CalculateSize(ConfirmQuestResourceRequest._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x000B4CD1 File Offset: 0x000B2ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConfirmQuestResourceRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.questIds_.Add(other.questIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x000B4CFF File Offset: 0x000B2EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x000B4D08 File Offset: 0x000B2F08
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questIds_.AddEntriesFrom(ref input, ConfirmQuestResourceRequest._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x04003054 RID: 12372
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003055 RID: 12373
		public const int QuestIdsFieldNumber = 14;

		// Token: 0x04003056 RID: 12374
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04003057 RID: 12375
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
