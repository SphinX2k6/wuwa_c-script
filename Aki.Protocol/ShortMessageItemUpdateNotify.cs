using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001240 RID: 4672
	[NetMessage(EMessageId.ShortMessageItemUpdateNotify)]
	public sealed class ShortMessageItemUpdateNotify : IMessage<ShortMessageItemUpdateNotify>, IMessage, IEquatable<ShortMessageItemUpdateNotify>, IDeepCloneable<ShortMessageItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018F3F RID: 102207 RVA: 0x003A36B2 File Offset: 0x003A18B2
		[NullableContext(1)]
		public static ShortMessageItemUpdateNotify Create()
		{
			return new ShortMessageItemUpdateNotify();
		}

		// Token: 0x17005455 RID: 21589
		// (get) Token: 0x06018F40 RID: 102208 RVA: 0x003A36B9 File Offset: 0x003A18B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005456 RID: 21590
		// (get) Token: 0x06018F41 RID: 102209 RVA: 0x003A36BC File Offset: 0x003A18BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018F42 RID: 102210 RVA: 0x003A36C3 File Offset: 0x003A18C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageItemUpdateNotify()
		{
		}

		// Token: 0x06018F43 RID: 102211 RVA: 0x003A36F8 File Offset: 0x003A18F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageItemUpdateNotify(ShortMessageItemUpdateNotify other) : this()
		{
			this.bubbleIds_ = other.bubbleIds_.Clone();
			this.chatBgIds_ = other.chatBgIds_.Clone();
			this.chatThemeIds_ = other.chatThemeIds_.Clone();
			this.chatCharmIds_ = other.chatCharmIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F44 RID: 102212 RVA: 0x003A3760 File Offset: 0x003A1960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageItemUpdateNotify Clone()
		{
			return new ShortMessageItemUpdateNotify(this);
		}

		// Token: 0x17005457 RID: 21591
		// (get) Token: 0x06018F45 RID: 102213 RVA: 0x003A3768 File Offset: 0x003A1968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BubbleIds
		{
			get
			{
				return this.bubbleIds_;
			}
		}

		// Token: 0x17005458 RID: 21592
		// (get) Token: 0x06018F46 RID: 102214 RVA: 0x003A3770 File Offset: 0x003A1970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatBgIds
		{
			get
			{
				return this.chatBgIds_;
			}
		}

		// Token: 0x17005459 RID: 21593
		// (get) Token: 0x06018F47 RID: 102215 RVA: 0x003A3778 File Offset: 0x003A1978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatThemeIds
		{
			get
			{
				return this.chatThemeIds_;
			}
		}

		// Token: 0x1700545A RID: 21594
		// (get) Token: 0x06018F48 RID: 102216 RVA: 0x003A3780 File Offset: 0x003A1980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatCharmIds
		{
			get
			{
				return this.chatCharmIds_;
			}
		}

		// Token: 0x06018F49 RID: 102217 RVA: 0x003A3788 File Offset: 0x003A1988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageItemUpdateNotify);
		}

		// Token: 0x06018F4A RID: 102218 RVA: 0x003A3798 File Offset: 0x003A1998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageItemUpdateNotify other)
		{
			return other != null && (other == this || (this.bubbleIds_.Equals(other.bubbleIds_) && this.chatBgIds_.Equals(other.chatBgIds_) && this.chatThemeIds_.Equals(other.chatThemeIds_) && this.chatCharmIds_.Equals(other.chatCharmIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F4B RID: 102219 RVA: 0x003A3818 File Offset: 0x003A1A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bubbleIds_.GetHashCode();
			num ^= this.chatBgIds_.GetHashCode();
			num ^= this.chatThemeIds_.GetHashCode();
			num ^= this.chatCharmIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018F4C RID: 102220 RVA: 0x003A3876 File Offset: 0x003A1A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F4D RID: 102221 RVA: 0x003A3883 File Offset: 0x003A1A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F4E RID: 102222 RVA: 0x003A388C File Offset: 0x003A1A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chatCharmIds_.WriteTo(ref output, ShortMessageItemUpdateNotify._repeated_chatCharmIds_codec);
			this.chatThemeIds_.WriteTo(ref output, ShortMessageItemUpdateNotify._repeated_chatThemeIds_codec);
			this.bubbleIds_.WriteTo(ref output, ShortMessageItemUpdateNotify._repeated_bubbleIds_codec);
			this.chatBgIds_.WriteTo(ref output, ShortMessageItemUpdateNotify._repeated_chatBgIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F4F RID: 102223 RVA: 0x003A38F4 File Offset: 0x003A1AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bubbleIds_.CalculateSize(ShortMessageItemUpdateNotify._repeated_bubbleIds_codec);
			num += this.chatBgIds_.CalculateSize(ShortMessageItemUpdateNotify._repeated_chatBgIds_codec);
			num += this.chatThemeIds_.CalculateSize(ShortMessageItemUpdateNotify._repeated_chatThemeIds_codec);
			num += this.chatCharmIds_.CalculateSize(ShortMessageItemUpdateNotify._repeated_chatCharmIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F50 RID: 102224 RVA: 0x003A3968 File Offset: 0x003A1B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.bubbleIds_.Add(other.bubbleIds_);
			this.chatBgIds_.Add(other.chatBgIds_);
			this.chatThemeIds_.Add(other.chatThemeIds_);
			this.chatCharmIds_.Add(other.chatCharmIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F51 RID: 102225 RVA: 0x003A39D4 File Offset: 0x003A1BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F52 RID: 102226 RVA: 0x003A39E0 File Offset: 0x003A1BE0
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
				if (num <= 26U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.chatCharmIds_.AddEntriesFrom(ref input, ShortMessageItemUpdateNotify._repeated_chatCharmIds_codec);
							continue;
						}
					}
					else if (num == 24U || num == 26U)
					{
						this.chatThemeIds_.AddEntriesFrom(ref input, ShortMessageItemUpdateNotify._repeated_chatThemeIds_codec);
						continue;
					}
				}
				else if (num <= 90U)
				{
					if (num == 88U || num == 90U)
					{
						this.bubbleIds_.AddEntriesFrom(ref input, ShortMessageItemUpdateNotify._repeated_bubbleIds_codec);
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.chatBgIds_.AddEntriesFrom(ref input, ShortMessageItemUpdateNotify._repeated_chatBgIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009406 RID: 37894
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009407 RID: 37895
		public const int BubbleIdsFieldNumber = 11;

		// Token: 0x04009408 RID: 37896
		private static readonly FieldCodec<int> _repeated_bubbleIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04009409 RID: 37897
		private readonly RepeatedField<int> bubbleIds_ = new RepeatedField<int>();

		// Token: 0x0400940A RID: 37898
		public const int ChatBgIdsFieldNumber = 15;

		// Token: 0x0400940B RID: 37899
		private static readonly FieldCodec<int> _repeated_chatBgIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400940C RID: 37900
		private readonly RepeatedField<int> chatBgIds_ = new RepeatedField<int>();

		// Token: 0x0400940D RID: 37901
		public const int ChatThemeIdsFieldNumber = 3;

		// Token: 0x0400940E RID: 37902
		private static readonly FieldCodec<int> _repeated_chatThemeIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400940F RID: 37903
		private readonly RepeatedField<int> chatThemeIds_ = new RepeatedField<int>();

		// Token: 0x04009410 RID: 37904
		public const int ChatCharmIdsFieldNumber = 1;

		// Token: 0x04009411 RID: 37905
		private static readonly FieldCodec<int> _repeated_chatCharmIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009412 RID: 37906
		private readonly RepeatedField<int> chatCharmIds_ = new RepeatedField<int>();
	}
}
