using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9A RID: 3994
	[NetMessage(EMessageId.RoguelikeEventGainNotify)]
	public sealed class RoguelikeEventGainNotify : IMessage<RoguelikeEventGainNotify>, IMessage, IEquatable<RoguelikeEventGainNotify>, IDeepCloneable<RoguelikeEventGainNotify>, IBufferMessage
	{
		// Token: 0x060155C2 RID: 87490 RVA: 0x0031985B File Offset: 0x00317A5B
		[NullableContext(1)]
		public static RoguelikeEventGainNotify Create()
		{
			return new RoguelikeEventGainNotify();
		}

		// Token: 0x1700472F RID: 18223
		// (get) Token: 0x060155C3 RID: 87491 RVA: 0x00319862 File Offset: 0x00317A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004730 RID: 18224
		// (get) Token: 0x060155C4 RID: 87492 RVA: 0x00319865 File Offset: 0x00317A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeEventGainNotify.Descriptor;
			}
		}

		// Token: 0x060155C5 RID: 87493 RVA: 0x0031986C File Offset: 0x00317A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeEventGainNotify()
		{
		}

		// Token: 0x060155C6 RID: 87494 RVA: 0x0031988A File Offset: 0x00317A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeEventGainNotify(RoguelikeEventGainNotify other) : this()
		{
			this.rogueGainEntryList_ = other.rogueGainEntryList_.Clone();
			this.rogueGainEntryList2_ = other.rogueGainEntryList2_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060155C7 RID: 87495 RVA: 0x003198C5 File Offset: 0x00317AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeEventGainNotify Clone()
		{
			return new RoguelikeEventGainNotify(this);
		}

		// Token: 0x17004731 RID: 18225
		// (get) Token: 0x060155C8 RID: 87496 RVA: 0x003198CD File Offset: 0x00317ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> RogueGainEntryList
		{
			get
			{
				return this.rogueGainEntryList_;
			}
		}

		// Token: 0x17004732 RID: 18226
		// (get) Token: 0x060155C9 RID: 87497 RVA: 0x003198D5 File Offset: 0x00317AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> RogueGainEntryList2
		{
			get
			{
				return this.rogueGainEntryList2_;
			}
		}

		// Token: 0x060155CA RID: 87498 RVA: 0x003198DD File Offset: 0x00317ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeEventGainNotify);
		}

		// Token: 0x060155CB RID: 87499 RVA: 0x003198EC File Offset: 0x00317AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeEventGainNotify other)
		{
			return other != null && (other == this || (this.rogueGainEntryList_.Equals(other.rogueGainEntryList_) && this.rogueGainEntryList2_.Equals(other.rogueGainEntryList2_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060155CC RID: 87500 RVA: 0x00319940 File Offset: 0x00317B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueGainEntryList_.GetHashCode();
			num ^= this.rogueGainEntryList2_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060155CD RID: 87501 RVA: 0x00319982 File Offset: 0x00317B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060155CE RID: 87502 RVA: 0x0031998F File Offset: 0x00317B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060155CF RID: 87503 RVA: 0x00319998 File Offset: 0x00317B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueGainEntryList2_.WriteTo(ref output, RoguelikeEventGainNotify._repeated_rogueGainEntryList2_codec);
			this.rogueGainEntryList_.WriteTo(ref output, RoguelikeEventGainNotify._repeated_rogueGainEntryList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060155D0 RID: 87504 RVA: 0x003199D0 File Offset: 0x00317BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueGainEntryList_.CalculateSize(RoguelikeEventGainNotify._repeated_rogueGainEntryList_codec);
			num += this.rogueGainEntryList2_.CalculateSize(RoguelikeEventGainNotify._repeated_rogueGainEntryList2_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060155D1 RID: 87505 RVA: 0x00319A1C File Offset: 0x00317C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeEventGainNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueGainEntryList_.Add(other.rogueGainEntryList_);
			this.rogueGainEntryList2_.Add(other.rogueGainEntryList2_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060155D2 RID: 87506 RVA: 0x00319A5B File Offset: 0x00317C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060155D3 RID: 87507 RVA: 0x00319A64 File Offset: 0x00317C64
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
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rogueGainEntryList_.AddEntriesFrom(ref input, RoguelikeEventGainNotify._repeated_rogueGainEntryList_codec);
					}
				}
				else
				{
					this.rogueGainEntryList2_.AddEntriesFrom(ref input, RoguelikeEventGainNotify._repeated_rogueGainEntryList2_codec);
				}
			}
		}

		// Token: 0x04008082 RID: 32898
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008083 RID: 32899
		public const int RogueGainEntryListFieldNumber = 3;

		// Token: 0x04008084 RID: 32900
		private static readonly FieldCodec<RogueGainEntry> _repeated_rogueGainEntryList_codec = FieldCodec.ForMessage<RogueGainEntry>(26U, RogueGainEntry.Parser);

		// Token: 0x04008085 RID: 32901
		private readonly RepeatedField<RogueGainEntry> rogueGainEntryList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x04008086 RID: 32902
		public const int RogueGainEntryList2FieldNumber = 1;

		// Token: 0x04008087 RID: 32903
		private static readonly FieldCodec<RogueGainEntry> _repeated_rogueGainEntryList2_codec = FieldCodec.ForMessage<RogueGainEntry>(10U, RogueGainEntry.Parser);

		// Token: 0x04008088 RID: 32904
		private readonly RepeatedField<RogueGainEntry> rogueGainEntryList2_ = new RepeatedField<RogueGainEntry>();
	}
}
