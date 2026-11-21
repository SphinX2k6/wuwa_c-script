using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8A RID: 3978
	[NetMessage(EMessageId.RoguelikeEventGainNotify)]
	public sealed class RoguelikeEventGainNotify : IMessage<RoguelikeEventGainNotify>, IMessage, IEquatable<RoguelikeEventGainNotify>, IDeepCloneable<RoguelikeEventGainNotify>, IBufferMessage
	{
		// Token: 0x060154DD RID: 87261 RVA: 0x003181B3 File Offset: 0x003163B3
		[NullableContext(1)]
		public static RoguelikeEventGainNotify Create()
		{
			return new RoguelikeEventGainNotify();
		}

		// Token: 0x17004705 RID: 18181
		// (get) Token: 0x060154DE RID: 87262 RVA: 0x003181BA File Offset: 0x003163BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004706 RID: 18182
		// (get) Token: 0x060154DF RID: 87263 RVA: 0x003181BD File Offset: 0x003163BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeEventGainNotify.Descriptor;
			}
		}

		// Token: 0x060154E0 RID: 87264 RVA: 0x003181C4 File Offset: 0x003163C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeEventGainNotify()
		{
		}

		// Token: 0x060154E1 RID: 87265 RVA: 0x003181E2 File Offset: 0x003163E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeEventGainNotify(RoguelikeEventGainNotify other) : this()
		{
			this.rogueGainEntryList_ = other.rogueGainEntryList_.Clone();
			this.rogueGainEntryList2_ = other.rogueGainEntryList2_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060154E2 RID: 87266 RVA: 0x0031821D File Offset: 0x0031641D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeEventGainNotify Clone()
		{
			return new RoguelikeEventGainNotify(this);
		}

		// Token: 0x17004707 RID: 18183
		// (get) Token: 0x060154E3 RID: 87267 RVA: 0x00318225 File Offset: 0x00316425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> RogueGainEntryList
		{
			get
			{
				return this.rogueGainEntryList_;
			}
		}

		// Token: 0x17004708 RID: 18184
		// (get) Token: 0x060154E4 RID: 87268 RVA: 0x0031822D File Offset: 0x0031642D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> RogueGainEntryList2
		{
			get
			{
				return this.rogueGainEntryList2_;
			}
		}

		// Token: 0x060154E5 RID: 87269 RVA: 0x00318235 File Offset: 0x00316435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeEventGainNotify);
		}

		// Token: 0x060154E6 RID: 87270 RVA: 0x00318244 File Offset: 0x00316444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeEventGainNotify other)
		{
			return other != null && (other == this || (this.rogueGainEntryList_.Equals(other.rogueGainEntryList_) && this.rogueGainEntryList2_.Equals(other.rogueGainEntryList2_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060154E7 RID: 87271 RVA: 0x00318298 File Offset: 0x00316498
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

		// Token: 0x060154E8 RID: 87272 RVA: 0x003182DA File Offset: 0x003164DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060154E9 RID: 87273 RVA: 0x003182E7 File Offset: 0x003164E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060154EA RID: 87274 RVA: 0x003182F0 File Offset: 0x003164F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueGainEntryList_.WriteTo(ref output, RoguelikeEventGainNotify._repeated_rogueGainEntryList_codec);
			this.rogueGainEntryList2_.WriteTo(ref output, RoguelikeEventGainNotify._repeated_rogueGainEntryList2_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060154EB RID: 87275 RVA: 0x00318328 File Offset: 0x00316528
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

		// Token: 0x060154EC RID: 87276 RVA: 0x00318374 File Offset: 0x00316574
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

		// Token: 0x060154ED RID: 87277 RVA: 0x003183B3 File Offset: 0x003165B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060154EE RID: 87278 RVA: 0x003183BC File Offset: 0x003165BC
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
				if (num != 18U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rogueGainEntryList2_.AddEntriesFrom(ref input, RoguelikeEventGainNotify._repeated_rogueGainEntryList2_codec);
					}
				}
				else
				{
					this.rogueGainEntryList_.AddEntriesFrom(ref input, RoguelikeEventGainNotify._repeated_rogueGainEntryList_codec);
				}
			}
		}

		// Token: 0x040080AC RID: 32940
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080AD RID: 32941
		public const int RogueGainEntryListFieldNumber = 2;

		// Token: 0x040080AE RID: 32942
		private static readonly FieldCodec<RogueGainEntry> _repeated_rogueGainEntryList_codec = FieldCodec.ForMessage<RogueGainEntry>(18U, RogueGainEntry.Parser);

		// Token: 0x040080AF RID: 32943
		private readonly RepeatedField<RogueGainEntry> rogueGainEntryList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x040080B0 RID: 32944
		public const int RogueGainEntryList2FieldNumber = 8;

		// Token: 0x040080B1 RID: 32945
		private static readonly FieldCodec<RogueGainEntry> _repeated_rogueGainEntryList2_codec = FieldCodec.ForMessage<RogueGainEntry>(66U, RogueGainEntry.Parser);

		// Token: 0x040080B2 RID: 32946
		private readonly RepeatedField<RogueGainEntry> rogueGainEntryList2_ = new RepeatedField<RogueGainEntry>();
	}
}
