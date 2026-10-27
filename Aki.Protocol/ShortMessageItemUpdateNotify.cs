using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001204 RID: 4612
	[NetMessage(EMessageId.ShortMessageItemUpdateNotify)]
	public sealed class ShortMessageItemUpdateNotify : IMessage<ShortMessageItemUpdateNotify>, IMessage, IEquatable<ShortMessageItemUpdateNotify>, IDeepCloneable<ShortMessageItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018965 RID: 100709 RVA: 0x00393812 File Offset: 0x00391A12
		[NullableContext(1)]
		public static ShortMessageItemUpdateNotify Create()
		{
			return new ShortMessageItemUpdateNotify();
		}

		// Token: 0x170052D8 RID: 21208
		// (get) Token: 0x06018966 RID: 100710 RVA: 0x00393819 File Offset: 0x00391A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052D9 RID: 21209
		// (get) Token: 0x06018967 RID: 100711 RVA: 0x0039381C File Offset: 0x00391A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018968 RID: 100712 RVA: 0x00393823 File Offset: 0x00391A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageItemUpdateNotify()
		{
		}

		// Token: 0x06018969 RID: 100713 RVA: 0x00393858 File Offset: 0x00391A58
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

		// Token: 0x0601896A RID: 100714 RVA: 0x003938C0 File Offset: 0x00391AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageItemUpdateNotify Clone()
		{
			return new ShortMessageItemUpdateNotify(this);
		}

		// Token: 0x170052DA RID: 21210
		// (get) Token: 0x0601896B RID: 100715 RVA: 0x003938C8 File Offset: 0x00391AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BubbleIds
		{
			get
			{
				return this.bubbleIds_;
			}
		}

		// Token: 0x170052DB RID: 21211
		// (get) Token: 0x0601896C RID: 100716 RVA: 0x003938D0 File Offset: 0x00391AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatBgIds
		{
			get
			{
				return this.chatBgIds_;
			}
		}

		// Token: 0x170052DC RID: 21212
		// (get) Token: 0x0601896D RID: 100717 RVA: 0x003938D8 File Offset: 0x00391AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatThemeIds
		{
			get
			{
				return this.chatThemeIds_;
			}
		}

		// Token: 0x170052DD RID: 21213
		// (get) Token: 0x0601896E RID: 100718 RVA: 0x003938E0 File Offset: 0x00391AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChatCharmIds
		{
			get
			{
				return this.chatCharmIds_;
			}
		}

		// Token: 0x0601896F RID: 100719 RVA: 0x003938E8 File Offset: 0x00391AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageItemUpdateNotify);
		}

		// Token: 0x06018970 RID: 100720 RVA: 0x003938F8 File Offset: 0x00391AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageItemUpdateNotify other)
		{
			return other != null && (other == this || (this.bubbleIds_.Equals(other.bubbleIds_) && this.chatBgIds_.Equals(other.chatBgIds_) && this.chatThemeIds_.Equals(other.chatThemeIds_) && this.chatCharmIds_.Equals(other.chatCharmIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018971 RID: 100721 RVA: 0x00393978 File Offset: 0x00391B78
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

		// Token: 0x06018972 RID: 100722 RVA: 0x003939D6 File Offset: 0x00391BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018973 RID: 100723 RVA: 0x003939E3 File Offset: 0x00391BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018974 RID: 100724 RVA: 0x003939EC File Offset: 0x00391BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chatThemeIds_.WriteTo(ref output, ShortMessageItemUpdateNotify._repeated_chatThemeIds_codec);
			this.chatCharmIds_.WriteTo(ref output, ShortMessageItemUpdateNotify._repeated_chatCharmIds_codec);
			this.chatBgIds_.WriteTo(ref output, ShortMessageItemUpdateNotify._repeated_chatBgIds_codec);
			this.bubbleIds_.WriteTo(ref output, ShortMessageItemUpdateNotify._repeated_bubbleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018975 RID: 100725 RVA: 0x00393A54 File Offset: 0x00391C54
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

		// Token: 0x06018976 RID: 100726 RVA: 0x00393AC8 File Offset: 0x00391CC8
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

		// Token: 0x06018977 RID: 100727 RVA: 0x00393B34 File Offset: 0x00391D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018978 RID: 100728 RVA: 0x00393B40 File Offset: 0x00391D40
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
				if (num <= 98U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.chatThemeIds_.AddEntriesFrom(ref input, ShortMessageItemUpdateNotify._repeated_chatThemeIds_codec);
							continue;
						}
					}
					else if (num == 96U || num == 98U)
					{
						this.chatCharmIds_.AddEntriesFrom(ref input, ShortMessageItemUpdateNotify._repeated_chatCharmIds_codec);
						continue;
					}
				}
				else if (num <= 106U)
				{
					if (num == 104U || num == 106U)
					{
						this.chatBgIds_.AddEntriesFrom(ref input, ShortMessageItemUpdateNotify._repeated_chatBgIds_codec);
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.bubbleIds_.AddEntriesFrom(ref input, ShortMessageItemUpdateNotify._repeated_bubbleIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009155 RID: 37205
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009156 RID: 37206
		public const int BubbleIdsFieldNumber = 15;

		// Token: 0x04009157 RID: 37207
		private static readonly FieldCodec<int> _repeated_bubbleIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04009158 RID: 37208
		private readonly RepeatedField<int> bubbleIds_ = new RepeatedField<int>();

		// Token: 0x04009159 RID: 37209
		public const int ChatBgIdsFieldNumber = 13;

		// Token: 0x0400915A RID: 37210
		private static readonly FieldCodec<int> _repeated_chatBgIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x0400915B RID: 37211
		private readonly RepeatedField<int> chatBgIds_ = new RepeatedField<int>();

		// Token: 0x0400915C RID: 37212
		public const int ChatThemeIdsFieldNumber = 1;

		// Token: 0x0400915D RID: 37213
		private static readonly FieldCodec<int> _repeated_chatThemeIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400915E RID: 37214
		private readonly RepeatedField<int> chatThemeIds_ = new RepeatedField<int>();

		// Token: 0x0400915F RID: 37215
		public const int ChatCharmIdsFieldNumber = 12;

		// Token: 0x04009160 RID: 37216
		private static readonly FieldCodec<int> _repeated_chatCharmIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04009161 RID: 37217
		private readonly RepeatedField<int> chatCharmIds_ = new RepeatedField<int>();
	}
}
