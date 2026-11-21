using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001041 RID: 4161
	[NetMessage(EMessageId.RogueWhiteCatLimitedUpdateNotify)]
	public sealed class RogueWhiteCatLimitedUpdateNotify : IMessage<RogueWhiteCatLimitedUpdateNotify>, IMessage, IEquatable<RogueWhiteCatLimitedUpdateNotify>, IDeepCloneable<RogueWhiteCatLimitedUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016439 RID: 91193 RVA: 0x0033CE71 File Offset: 0x0033B071
		[NullableContext(1)]
		public static RogueWhiteCatLimitedUpdateNotify Create()
		{
			return new RogueWhiteCatLimitedUpdateNotify();
		}

		// Token: 0x17004A7E RID: 19070
		// (get) Token: 0x0601643A RID: 91194 RVA: 0x0033CE78 File Offset: 0x0033B078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A7F RID: 19071
		// (get) Token: 0x0601643B RID: 91195 RVA: 0x0033CE7B File Offset: 0x0033B07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatLimitedUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601643C RID: 91196 RVA: 0x0033CE82 File Offset: 0x0033B082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedUpdateNotify()
		{
		}

		// Token: 0x0601643D RID: 91197 RVA: 0x0033CE95 File Offset: 0x0033B095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedUpdateNotify(RogueWhiteCatLimitedUpdateNotify other) : this()
		{
			this.rogueLimitedAwards_ = other.rogueLimitedAwards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601643E RID: 91198 RVA: 0x0033CEBF File Offset: 0x0033B0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedUpdateNotify Clone()
		{
			return new RogueWhiteCatLimitedUpdateNotify(this);
		}

		// Token: 0x17004A80 RID: 19072
		// (get) Token: 0x0601643F RID: 91199 RVA: 0x0033CEC7 File Offset: 0x0033B0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueLimitedAward> RogueLimitedAwards
		{
			get
			{
				return this.rogueLimitedAwards_;
			}
		}

		// Token: 0x06016440 RID: 91200 RVA: 0x0033CECF File Offset: 0x0033B0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatLimitedUpdateNotify);
		}

		// Token: 0x06016441 RID: 91201 RVA: 0x0033CEDD File Offset: 0x0033B0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatLimitedUpdateNotify other)
		{
			return other != null && (other == this || (this.rogueLimitedAwards_.Equals(other.rogueLimitedAwards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016442 RID: 91202 RVA: 0x0033CF10 File Offset: 0x0033B110
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

		// Token: 0x06016443 RID: 91203 RVA: 0x0033CF44 File Offset: 0x0033B144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016444 RID: 91204 RVA: 0x0033CF51 File Offset: 0x0033B151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016445 RID: 91205 RVA: 0x0033CF5A File Offset: 0x0033B15A
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

		// Token: 0x06016446 RID: 91206 RVA: 0x0033CF84 File Offset: 0x0033B184
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

		// Token: 0x06016447 RID: 91207 RVA: 0x0033CFBD File Offset: 0x0033B1BD
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

		// Token: 0x06016448 RID: 91208 RVA: 0x0033CFEB File Offset: 0x0033B1EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016449 RID: 91209 RVA: 0x0033CFF4 File Offset: 0x0033B1F4
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueLimitedAwards_.AddEntriesFrom(ref input, RogueWhiteCatLimitedUpdateNotify._repeated_rogueLimitedAwards_codec);
				}
			}
		}

		// Token: 0x040085B2 RID: 34226
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085B3 RID: 34227
		public const int RogueLimitedAwardsFieldNumber = 10;

		// Token: 0x040085B4 RID: 34228
		private static readonly FieldCodec<RogueLimitedAward> _repeated_rogueLimitedAwards_codec = FieldCodec.ForMessage<RogueLimitedAward>(82U, RogueLimitedAward.Parser);

		// Token: 0x040085B5 RID: 34229
		private readonly RepeatedField<RogueLimitedAward> rogueLimitedAwards_ = new RepeatedField<RogueLimitedAward>();
	}
}
