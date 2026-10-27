using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D2 RID: 210
	[NetMessage(EMessageId.AdviceUpdateNotify)]
	public sealed class AdviceUpdateNotify : IMessage<AdviceUpdateNotify>, IMessage, IEquatable<AdviceUpdateNotify>, IDeepCloneable<AdviceUpdateNotify>, IBufferMessage
	{
		// Token: 0x06002024 RID: 8228 RVA: 0x00056DF9 File Offset: 0x00054FF9
		[NullableContext(1)]
		public static AdviceUpdateNotify Create()
		{
			return new AdviceUpdateNotify();
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x00056E00 File Offset: 0x00055000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x00056E03 File Offset: 0x00055003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00056E0A File Offset: 0x0005500A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceUpdateNotify()
		{
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00056E1D File Offset: 0x0005501D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceUpdateNotify(AdviceUpdateNotify other) : this()
		{
			this.upVoteIds_ = other.upVoteIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00056E47 File Offset: 0x00055047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceUpdateNotify Clone()
		{
			return new AdviceUpdateNotify(this);
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x00056E4F File Offset: 0x0005504F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> UpVoteIds
		{
			get
			{
				return this.upVoteIds_;
			}
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00056E57 File Offset: 0x00055057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceUpdateNotify);
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00056E65 File Offset: 0x00055065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceUpdateNotify other)
		{
			return other != null && (other == this || (this.upVoteIds_.Equals(other.upVoteIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00056E98 File Offset: 0x00055098
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

		// Token: 0x0600202E RID: 8238 RVA: 0x00056ECC File Offset: 0x000550CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00056ED9 File Offset: 0x000550D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00056EE2 File Offset: 0x000550E2
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

		// Token: 0x06002031 RID: 8241 RVA: 0x00056F0C File Offset: 0x0005510C
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

		// Token: 0x06002032 RID: 8242 RVA: 0x00056F45 File Offset: 0x00055145
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

		// Token: 0x06002033 RID: 8243 RVA: 0x00056F73 File Offset: 0x00055173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00056F7C File Offset: 0x0005517C
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.upVoteIds_.AddEntriesFrom(ref input, AdviceUpdateNotify._repeated_upVoteIds_codec);
				}
			}
		}

		// Token: 0x040023E4 RID: 9188
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023E5 RID: 9189
		public const int UpVoteIdsFieldNumber = 12;

		// Token: 0x040023E6 RID: 9190
		private static readonly FieldCodec<long> _repeated_upVoteIds_codec = FieldCodec.ForInt64(98U);

		// Token: 0x040023E7 RID: 9191
		private readonly RepeatedField<long> upVoteIds_ = new RepeatedField<long>();
	}
}
