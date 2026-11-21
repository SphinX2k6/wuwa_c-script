using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DF RID: 223
	[NetMessage(EMessageId.AllApplyJoinNotify)]
	public sealed class AllApplyJoinNotify : IMessage<AllApplyJoinNotify>, IMessage, IEquatable<AllApplyJoinNotify>, IDeepCloneable<AllApplyJoinNotify>, IBufferMessage
	{
		// Token: 0x06002161 RID: 8545 RVA: 0x00059B26 File Offset: 0x00057D26
		[NullableContext(1)]
		public static AllApplyJoinNotify Create()
		{
			return new AllApplyJoinNotify();
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x00059B2D File Offset: 0x00057D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x00059B30 File Offset: 0x00057D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AllApplyJoinNotify.Descriptor;
			}
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00059B37 File Offset: 0x00057D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllApplyJoinNotify()
		{
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00059B4A File Offset: 0x00057D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllApplyJoinNotify(AllApplyJoinNotify other) : this()
		{
			this.applyList_ = other.applyList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00059B74 File Offset: 0x00057D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllApplyJoinNotify Clone()
		{
			return new AllApplyJoinNotify(this);
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x00059B7C File Offset: 0x00057D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ApplyJoinWorldNotify> ApplyList
		{
			get
			{
				return this.applyList_;
			}
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00059B84 File Offset: 0x00057D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AllApplyJoinNotify);
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00059B92 File Offset: 0x00057D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AllApplyJoinNotify other)
		{
			return other != null && (other == this || (this.applyList_.Equals(other.applyList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00059BC8 File Offset: 0x00057DC8
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

		// Token: 0x0600216B RID: 8555 RVA: 0x00059BFC File Offset: 0x00057DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00059C09 File Offset: 0x00057E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00059C12 File Offset: 0x00057E12
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

		// Token: 0x0600216E RID: 8558 RVA: 0x00059C3C File Offset: 0x00057E3C
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

		// Token: 0x0600216F RID: 8559 RVA: 0x00059C75 File Offset: 0x00057E75
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

		// Token: 0x06002170 RID: 8560 RVA: 0x00059CA3 File Offset: 0x00057EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00059CAC File Offset: 0x00057EAC
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.applyList_.AddEntriesFrom(ref input, AllApplyJoinNotify._repeated_applyList_codec);
				}
			}
		}

		// Token: 0x0400248B RID: 9355
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400248C RID: 9356
		public const int ApplyListFieldNumber = 8;

		// Token: 0x0400248D RID: 9357
		private static readonly FieldCodec<ApplyJoinWorldNotify> _repeated_applyList_codec = FieldCodec.ForMessage<ApplyJoinWorldNotify>(66U, ApplyJoinWorldNotify.Parser);

		// Token: 0x0400248E RID: 9358
		private readonly RepeatedField<ApplyJoinWorldNotify> applyList_ = new RepeatedField<ApplyJoinWorldNotify>();
	}
}
