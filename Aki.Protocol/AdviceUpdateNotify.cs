using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D3 RID: 211
	[NetMessage(EMessageId.AdviceUpdateNotify)]
	public sealed class AdviceUpdateNotify : IMessage<AdviceUpdateNotify>, IMessage, IEquatable<AdviceUpdateNotify>, IDeepCloneable<AdviceUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600206D RID: 8301 RVA: 0x00057AAD File Offset: 0x00055CAD
		[NullableContext(1)]
		public static AdviceUpdateNotify Create()
		{
			return new AdviceUpdateNotify();
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x00057AB4 File Offset: 0x00055CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x00057AB7 File Offset: 0x00055CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x00057ABE File Offset: 0x00055CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceUpdateNotify()
		{
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x00057AD1 File Offset: 0x00055CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceUpdateNotify(AdviceUpdateNotify other) : this()
		{
			this.upVoteIds_ = other.upVoteIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00057AFB File Offset: 0x00055CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceUpdateNotify Clone()
		{
			return new AdviceUpdateNotify(this);
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x00057B03 File Offset: 0x00055D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> UpVoteIds
		{
			get
			{
				return this.upVoteIds_;
			}
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x00057B0B File Offset: 0x00055D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceUpdateNotify);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00057B19 File Offset: 0x00055D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceUpdateNotify other)
		{
			return other != null && (other == this || (this.upVoteIds_.Equals(other.upVoteIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x00057B4C File Offset: 0x00055D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.upVoteIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x00057B80 File Offset: 0x00055D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00057B8D File Offset: 0x00055D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x00057B96 File Offset: 0x00055D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.upVoteIds_.WriteTo(ref output, AdviceUpdateNotify._repeated_upVoteIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00057BC0 File Offset: 0x00055DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.upVoteIds_.CalculateSize(AdviceUpdateNotify._repeated_upVoteIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00057BF9 File Offset: 0x00055DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.upVoteIds_.Add(other.upVoteIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00057C27 File Offset: 0x00055E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00057C30 File Offset: 0x00055E30
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
					this.upVoteIds_.AddEntriesFrom(ref input, AdviceUpdateNotify._repeated_upVoteIds_codec);
				}
			}
		}

		// Token: 0x04002447 RID: 9287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002448 RID: 9288
		public const int UpVoteIdsFieldNumber = 14;

		// Token: 0x04002449 RID: 9289
		private static readonly FieldCodec<long> _repeated_upVoteIds_codec = FieldCodec.ForInt64(114U);

		// Token: 0x0400244A RID: 9290
		private readonly RepeatedField<long> upVoteIds_ = new RepeatedField<long>();
	}
}
