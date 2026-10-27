using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001201 RID: 4609
	public sealed class ShortMessageInfo : IMessage<ShortMessageInfo>, IMessage, IEquatable<ShortMessageInfo>, IDeepCloneable<ShortMessageInfo>, IBufferMessage
	{
		// Token: 0x06018915 RID: 100629 RVA: 0x003927E1 File Offset: 0x003909E1
		[NullableContext(1)]
		public static ShortMessageInfo Create()
		{
			return new ShortMessageInfo();
		}

		// Token: 0x170052BF RID: 21183
		// (get) Token: 0x06018916 RID: 100630 RVA: 0x003927E8 File Offset: 0x003909E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortMessageInfo> Parser
		{
			get
			{
				return ShortMessageInfo._parser;
			}
		}

		// Token: 0x170052C0 RID: 21184
		// (get) Token: 0x06018917 RID: 100631 RVA: 0x003927EF File Offset: 0x003909EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052C1 RID: 21185
		// (get) Token: 0x06018918 RID: 100632 RVA: 0x003927F2 File Offset: 0x003909F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageInfo.Descriptor;
			}
		}

		// Token: 0x06018919 RID: 100633 RVA: 0x003927F9 File Offset: 0x003909F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfo()
		{
		}

		// Token: 0x0601891A RID: 100634 RVA: 0x0039280C File Offset: 0x00390A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfo(ShortMessageInfo other) : this()
		{
			this.configId_ = other.configId_;
			this.lastConfigId_ = other.lastConfigId_;
			this.isRead_ = other.isRead_;
			this.isReceived_ = other.isReceived_;
			this.options_ = other.options_.Clone();
			this.unlockTime_ = other.unlockTime_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601891B RID: 100635 RVA: 0x00392889 File Offset: 0x00390A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfo Clone()
		{
			return new ShortMessageInfo(this);
		}

		// Token: 0x170052C2 RID: 21186
		// (get) Token: 0x0601891C RID: 100636 RVA: 0x00392891 File Offset: 0x00390A91
		// (set) Token: 0x0601891D RID: 100637 RVA: 0x00392899 File Offset: 0x00390A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x170052C3 RID: 21187
		// (get) Token: 0x0601891E RID: 100638 RVA: 0x003928A2 File Offset: 0x00390AA2
		// (set) Token: 0x0601891F RID: 100639 RVA: 0x003928AA File Offset: 0x00390AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastConfigId
		{
			get
			{
				return this.lastConfigId_;
			}
			set
			{
				this.lastConfigId_ = value;
			}
		}

		// Token: 0x170052C4 RID: 21188
		// (get) Token: 0x06018920 RID: 100640 RVA: 0x003928B3 File Offset: 0x00390AB3
		// (set) Token: 0x06018921 RID: 100641 RVA: 0x003928BB File Offset: 0x00390ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRead
		{
			get
			{
				return this.isRead_;
			}
			set
			{
				this.isRead_ = value;
			}
		}

		// Token: 0x170052C5 RID: 21189
		// (get) Token: 0x06018922 RID: 100642 RVA: 0x003928C4 File Offset: 0x00390AC4
		// (set) Token: 0x06018923 RID: 100643 RVA: 0x003928CC File Offset: 0x00390ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReceived
		{
			get
			{
				return this.isReceived_;
			}
			set
			{
				this.isReceived_ = value;
			}
		}

		// Token: 0x170052C6 RID: 21190
		// (get) Token: 0x06018924 RID: 100644 RVA: 0x003928D5 File Offset: 0x00390AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Options
		{
			get
			{
				return this.options_;
			}
		}

		// Token: 0x170052C7 RID: 21191
		// (get) Token: 0x06018925 RID: 100645 RVA: 0x003928DD File Offset: 0x00390ADD
		// (set) Token: 0x06018926 RID: 100646 RVA: 0x003928E5 File Offset: 0x00390AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x170052C8 RID: 21192
		// (get) Token: 0x06018927 RID: 100647 RVA: 0x003928EE File Offset: 0x00390AEE
		// (set) Token: 0x06018928 RID: 100648 RVA: 0x003928F6 File Offset: 0x00390AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x06018929 RID: 100649 RVA: 0x003928FF File Offset: 0x00390AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageInfo);
		}

		// Token: 0x0601892A RID: 100650 RVA: 0x00392910 File Offset: 0x00390B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageInfo other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.LastConfigId == other.LastConfigId && this.IsRead == other.IsRead && this.IsReceived == other.IsReceived && this.Options.Equals(other.Options) && this.UnlockTime == other.UnlockTime && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601892B RID: 100651 RVA: 0x003929B0 File Offset: 0x00390BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.LastConfigId != 0)
			{
				num ^= this.LastConfigId.GetHashCode();
			}
			if (this.IsRead)
			{
				num ^= this.IsRead.GetHashCode();
			}
			if (this.IsReceived)
			{
				num ^= this.IsReceived.GetHashCode();
			}
			num ^= this.Options.GetHashCode();
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601892C RID: 100652 RVA: 0x00392A7A File Offset: 0x00390C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601892D RID: 100653 RVA: 0x00392A87 File Offset: 0x00390C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601892E RID: 100654 RVA: 0x00392A90 File Offset: 0x00390C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.LastConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LastConfigId);
			}
			if (this.IsRead)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsRead);
			}
			if (this.IsReceived)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsReceived);
			}
			this.options_.WriteTo(ref output, ShortMessageInfo._map_options_codec);
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601892F RID: 100655 RVA: 0x00392B6C File Offset: 0x00390D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.LastConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastConfigId);
			}
			if (this.IsRead)
			{
				num += 2;
			}
			if (this.IsReceived)
			{
				num += 2;
			}
			num += this.options_.CalculateSize(ShortMessageInfo._map_options_codec);
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018930 RID: 100656 RVA: 0x00392C14 File Offset: 0x00390E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.LastConfigId != 0)
			{
				this.LastConfigId = other.LastConfigId;
			}
			if (other.IsRead)
			{
				this.IsRead = other.IsRead;
			}
			if (other.IsReceived)
			{
				this.IsReceived = other.IsReceived;
			}
			this.options_.MergeFrom(other.options_);
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018931 RID: 100657 RVA: 0x00392CC5 File Offset: 0x00390EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018932 RID: 100658 RVA: 0x00392CD0 File Offset: 0x00390ED0
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LastConfigId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.IsRead = input.ReadBool();
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 32U)
					{
						this.IsReceived = input.ReadBool();
						continue;
					}
					if (num == 42U)
					{
						this.options_.AddEntriesFrom(ref input, ShortMessageInfo._map_options_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.IsFinish = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009126 RID: 37158
		private static readonly MessageParser<ShortMessageInfo> _parser = new MessageParser<ShortMessageInfo>(() => new ShortMessageInfo());

		// Token: 0x04009127 RID: 37159
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009128 RID: 37160
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04009129 RID: 37161
		private int configId_;

		// Token: 0x0400912A RID: 37162
		public const int LastConfigIdFieldNumber = 2;

		// Token: 0x0400912B RID: 37163
		private int lastConfigId_;

		// Token: 0x0400912C RID: 37164
		public const int IsReadFieldNumber = 3;

		// Token: 0x0400912D RID: 37165
		private bool isRead_;

		// Token: 0x0400912E RID: 37166
		public const int IsReceivedFieldNumber = 4;

		// Token: 0x0400912F RID: 37167
		private bool isReceived_;

		// Token: 0x04009130 RID: 37168
		public const int OptionsFieldNumber = 5;

		// Token: 0x04009131 RID: 37169
		private static readonly MapField<int, int>.Codec _map_options_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04009132 RID: 37170
		private readonly MapField<int, int> options_ = new MapField<int, int>();

		// Token: 0x04009133 RID: 37171
		public const int UnlockTimeFieldNumber = 6;

		// Token: 0x04009134 RID: 37172
		private long unlockTime_;

		// Token: 0x04009135 RID: 37173
		public const int IsFinishFieldNumber = 7;

		// Token: 0x04009136 RID: 37174
		private bool isFinish_;
	}
}
