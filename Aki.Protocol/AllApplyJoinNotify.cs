using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DE RID: 222
	[NetMessage(EMessageId.AllApplyJoinNotify)]
	public sealed class AllApplyJoinNotify : IMessage<AllApplyJoinNotify>, IMessage, IEquatable<AllApplyJoinNotify>, IDeepCloneable<AllApplyJoinNotify>, IBufferMessage
	{
		// Token: 0x06002118 RID: 8472 RVA: 0x00058E72 File Offset: 0x00057072
		[NullableContext(1)]
		public static AllApplyJoinNotify Create()
		{
			return new AllApplyJoinNotify();
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x00058E79 File Offset: 0x00057079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x00058E7C File Offset: 0x0005707C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AllApplyJoinNotify.Descriptor;
			}
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00058E83 File Offset: 0x00057083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllApplyJoinNotify()
		{
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00058E96 File Offset: 0x00057096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllApplyJoinNotify(AllApplyJoinNotify other) : this()
		{
			this.applyList_ = other.applyList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00058EC0 File Offset: 0x000570C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllApplyJoinNotify Clone()
		{
			return new AllApplyJoinNotify(this);
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x00058EC8 File Offset: 0x000570C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ApplyJoinWorldNotify> ApplyList
		{
			get
			{
				return this.applyList_;
			}
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x00058ED0 File Offset: 0x000570D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AllApplyJoinNotify);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00058EDE File Offset: 0x000570DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AllApplyJoinNotify other)
		{
			return other != null && (other == this || (this.applyList_.Equals(other.applyList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00058F14 File Offset: 0x00057114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.applyList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00058F48 File Offset: 0x00057148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00058F55 File Offset: 0x00057155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00058F5E File Offset: 0x0005715E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.applyList_.WriteTo(ref output, AllApplyJoinNotify._repeated_applyList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00058F88 File Offset: 0x00057188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.applyList_.CalculateSize(AllApplyJoinNotify._repeated_applyList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00058FC1 File Offset: 0x000571C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AllApplyJoinNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.applyList_.Add(other.applyList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00058FEF File Offset: 0x000571EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00058FF8 File Offset: 0x000571F8
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.applyList_.AddEntriesFrom(ref input, AllApplyJoinNotify._repeated_applyList_codec);
				}
			}
		}

		// Token: 0x04002428 RID: 9256
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002429 RID: 9257
		public const int ApplyListFieldNumber = 14;

		// Token: 0x0400242A RID: 9258
		private static readonly FieldCodec<ApplyJoinWorldNotify> _repeated_applyList_codec = FieldCodec.ForMessage<ApplyJoinWorldNotify>(114U, ApplyJoinWorldNotify.Parser);

		// Token: 0x0400242B RID: 9259
		private readonly RepeatedField<ApplyJoinWorldNotify> applyList_ = new RepeatedField<ApplyJoinWorldNotify>();
	}
}
