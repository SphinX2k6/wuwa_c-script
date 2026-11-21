using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D8 RID: 728
	[NetMessage(EMessageId.ConfirmQuestResourceRequest)]
	public sealed class ConfirmQuestResourceRequest : IMessage<ConfirmQuestResourceRequest>, IMessage, IEquatable<ConfirmQuestResourceRequest>, IDeepCloneable<ConfirmQuestResourceRequest>, IBufferMessage
	{
		// Token: 0x06004ABD RID: 19133 RVA: 0x000B6F6D File Offset: 0x000B516D
		[NullableContext(1)]
		public static ConfirmQuestResourceRequest Create()
		{
			return new ConfirmQuestResourceRequest();
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06004ABE RID: 19134 RVA: 0x000B6F74 File Offset: 0x000B5174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06004ABF RID: 19135 RVA: 0x000B6F77 File Offset: 0x000B5177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConfirmQuestResourceRequest.Descriptor;
			}
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x000B6F7E File Offset: 0x000B517E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceRequest()
		{
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x000B6F91 File Offset: 0x000B5191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceRequest(ConfirmQuestResourceRequest other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x000B6FBB File Offset: 0x000B51BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceRequest Clone()
		{
			return new ConfirmQuestResourceRequest(this);
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x000B6FC3 File Offset: 0x000B51C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x000B6FCB File Offset: 0x000B51CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConfirmQuestResourceRequest);
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x000B6FD9 File Offset: 0x000B51D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConfirmQuestResourceRequest other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x000B700C File Offset: 0x000B520C
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

		// Token: 0x06004AC7 RID: 19143 RVA: 0x000B7040 File Offset: 0x000B5240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x000B704D File Offset: 0x000B524D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x000B7056 File Offset: 0x000B5256
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

		// Token: 0x06004ACA RID: 19146 RVA: 0x000B7080 File Offset: 0x000B5280
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

		// Token: 0x06004ACB RID: 19147 RVA: 0x000B70B9 File Offset: 0x000B52B9
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

		// Token: 0x06004ACC RID: 19148 RVA: 0x000B70E7 File Offset: 0x000B52E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x000B70F0 File Offset: 0x000B52F0
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questIds_.AddEntriesFrom(ref input, ConfirmQuestResourceRequest._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x040030EB RID: 12523
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030EC RID: 12524
		public const int QuestIdsFieldNumber = 15;

		// Token: 0x040030ED RID: 12525
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040030EE RID: 12526
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
