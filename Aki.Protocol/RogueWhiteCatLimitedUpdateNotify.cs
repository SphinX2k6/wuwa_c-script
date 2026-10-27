using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001051 RID: 4177
	[NetMessage(EMessageId.RogueWhiteCatLimitedUpdateNotify)]
	public sealed class RogueWhiteCatLimitedUpdateNotify : IMessage<RogueWhiteCatLimitedUpdateNotify>, IMessage, IEquatable<RogueWhiteCatLimitedUpdateNotify>, IDeepCloneable<RogueWhiteCatLimitedUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601651E RID: 91422 RVA: 0x0033E53D File Offset: 0x0033C73D
		[NullableContext(1)]
		public static RogueWhiteCatLimitedUpdateNotify Create()
		{
			return new RogueWhiteCatLimitedUpdateNotify();
		}

		// Token: 0x17004AA8 RID: 19112
		// (get) Token: 0x0601651F RID: 91423 RVA: 0x0033E544 File Offset: 0x0033C744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AA9 RID: 19113
		// (get) Token: 0x06016520 RID: 91424 RVA: 0x0033E547 File Offset: 0x0033C747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatLimitedUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016521 RID: 91425 RVA: 0x0033E54E File Offset: 0x0033C74E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedUpdateNotify()
		{
		}

		// Token: 0x06016522 RID: 91426 RVA: 0x0033E561 File Offset: 0x0033C761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedUpdateNotify(RogueWhiteCatLimitedUpdateNotify other) : this()
		{
			this.rogueLimitedAwards_ = other.rogueLimitedAwards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016523 RID: 91427 RVA: 0x0033E58B File Offset: 0x0033C78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedUpdateNotify Clone()
		{
			return new RogueWhiteCatLimitedUpdateNotify(this);
		}

		// Token: 0x17004AAA RID: 19114
		// (get) Token: 0x06016524 RID: 91428 RVA: 0x0033E593 File Offset: 0x0033C793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueLimitedAward> RogueLimitedAwards
		{
			get
			{
				return this.rogueLimitedAwards_;
			}
		}

		// Token: 0x06016525 RID: 91429 RVA: 0x0033E59B File Offset: 0x0033C79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatLimitedUpdateNotify);
		}

		// Token: 0x06016526 RID: 91430 RVA: 0x0033E5A9 File Offset: 0x0033C7A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatLimitedUpdateNotify other)
		{
			return other != null && (other == this || (this.rogueLimitedAwards_.Equals(other.rogueLimitedAwards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016527 RID: 91431 RVA: 0x0033E5DC File Offset: 0x0033C7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueLimitedAwards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016528 RID: 91432 RVA: 0x0033E610 File Offset: 0x0033C810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016529 RID: 91433 RVA: 0x0033E61D File Offset: 0x0033C81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601652A RID: 91434 RVA: 0x0033E626 File Offset: 0x0033C826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueLimitedAwards_.WriteTo(ref output, RogueWhiteCatLimitedUpdateNotify._repeated_rogueLimitedAwards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601652B RID: 91435 RVA: 0x0033E650 File Offset: 0x0033C850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueLimitedAwards_.CalculateSize(RogueWhiteCatLimitedUpdateNotify._repeated_rogueLimitedAwards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601652C RID: 91436 RVA: 0x0033E689 File Offset: 0x0033C889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWhiteCatLimitedUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueLimitedAwards_.Add(other.rogueLimitedAwards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601652D RID: 91437 RVA: 0x0033E6B7 File Offset: 0x0033C8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601652E RID: 91438 RVA: 0x0033E6C0 File Offset: 0x0033C8C0
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueLimitedAwards_.AddEntriesFrom(ref input, RogueWhiteCatLimitedUpdateNotify._repeated_rogueLimitedAwards_codec);
				}
			}
		}

		// Token: 0x04008588 RID: 34184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008589 RID: 34185
		public const int RogueLimitedAwardsFieldNumber = 3;

		// Token: 0x0400858A RID: 34186
		private static readonly FieldCodec<RogueLimitedAward> _repeated_rogueLimitedAwards_codec = FieldCodec.ForMessage<RogueLimitedAward>(26U, RogueLimitedAward.Parser);

		// Token: 0x0400858B RID: 34187
		private readonly RepeatedField<RogueLimitedAward> rogueLimitedAwards_ = new RepeatedField<RogueLimitedAward>();
	}
}
