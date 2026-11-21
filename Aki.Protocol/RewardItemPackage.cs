using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F26 RID: 3878
	public sealed class RewardItemPackage : IMessage<RewardItemPackage>, IMessage, IEquatable<RewardItemPackage>, IDeepCloneable<RewardItemPackage>, IBufferMessage
	{
		// Token: 0x06014C84 RID: 85124 RVA: 0x0030486B File Offset: 0x00302A6B
		[NullableContext(1)]
		public static RewardItemPackage Create()
		{
			return new RewardItemPackage();
		}

		// Token: 0x1700451E RID: 17694
		// (get) Token: 0x06014C85 RID: 85125 RVA: 0x00304872 File Offset: 0x00302A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RewardItemPackage> Parser
		{
			get
			{
				return RewardItemPackage._parser;
			}
		}

		// Token: 0x1700451F RID: 17695
		// (get) Token: 0x06014C86 RID: 85126 RVA: 0x00304879 File Offset: 0x00302A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004520 RID: 17696
		// (get) Token: 0x06014C87 RID: 85127 RVA: 0x0030487C File Offset: 0x00302A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RewardItemPackage.Descriptor;
			}
		}

		// Token: 0x06014C88 RID: 85128 RVA: 0x00304883 File Offset: 0x00302A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemPackage()
		{
		}

		// Token: 0x06014C89 RID: 85129 RVA: 0x00304898 File Offset: 0x00302A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemPackage(RewardItemPackage other) : this()
		{
			this.rewardItem_ = ((other.rewardItem_ != null) ? other.rewardItem_.Clone() : null);
			this.rewardItems_ = other.rewardItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C8A RID: 85130 RVA: 0x003048E9 File Offset: 0x00302AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemPackage Clone()
		{
			return new RewardItemPackage(this);
		}

		// Token: 0x17004521 RID: 17697
		// (get) Token: 0x06014C8B RID: 85131 RVA: 0x003048F1 File Offset: 0x00302AF1
		// (set) Token: 0x06014C8C RID: 85132 RVA: 0x003048F9 File Offset: 0x00302AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItem RewardItem
		{
			get
			{
				return this.rewardItem_;
			}
			set
			{
				this.rewardItem_ = value;
			}
		}

		// Token: 0x17004522 RID: 17698
		// (get) Token: 0x06014C8D RID: 85133 RVA: 0x00304902 File Offset: 0x00302B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItem> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x06014C8E RID: 85134 RVA: 0x0030490A File Offset: 0x00302B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RewardItemPackage);
		}

		// Token: 0x06014C8F RID: 85135 RVA: 0x00304918 File Offset: 0x00302B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RewardItemPackage other)
		{
			return other != null && (other == this || (object.Equals(this.RewardItem, other.RewardItem) && this.rewardItems_.Equals(other.rewardItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C90 RID: 85136 RVA: 0x0030496C File Offset: 0x00302B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rewardItem_ != null)
			{
				num ^= this.RewardItem.GetHashCode();
			}
			num ^= this.rewardItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014C91 RID: 85137 RVA: 0x003049B6 File Offset: 0x00302BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C92 RID: 85138 RVA: 0x003049C3 File Offset: 0x00302BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C93 RID: 85139 RVA: 0x003049CC File Offset: 0x00302BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardItem_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RewardItem);
			}
			this.rewardItems_.WriteTo(ref output, RewardItemPackage._repeated_rewardItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C94 RID: 85140 RVA: 0x00304A1C File Offset: 0x00302C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rewardItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardItem);
			}
			num += this.rewardItems_.CalculateSize(RewardItemPackage._repeated_rewardItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014C95 RID: 85141 RVA: 0x00304A70 File Offset: 0x00302C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RewardItemPackage other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rewardItem_ != null)
			{
				if (this.rewardItem_ == null)
				{
					this.RewardItem = new RewardItem();
				}
				this.RewardItem.MergeFrom(other.RewardItem);
			}
			this.rewardItems_.Add(other.rewardItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014C96 RID: 85142 RVA: 0x00304AD5 File Offset: 0x00302CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C97 RID: 85143 RVA: 0x00304AE0 File Offset: 0x00302CE0
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewardItems_.AddEntriesFrom(ref input, RewardItemPackage._repeated_rewardItems_codec);
					}
				}
				else
				{
					if (this.rewardItem_ == null)
					{
						this.RewardItem = new RewardItem();
					}
					input.ReadMessage(this.RewardItem);
				}
			}
		}

		// Token: 0x04007DE8 RID: 32232
		private static readonly MessageParser<RewardItemPackage> _parser = new MessageParser<RewardItemPackage>(() => new RewardItemPackage());

		// Token: 0x04007DE9 RID: 32233
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DEA RID: 32234
		public const int RewardItemFieldNumber = 1;

		// Token: 0x04007DEB RID: 32235
		private RewardItem rewardItem_;

		// Token: 0x04007DEC RID: 32236
		public const int RewardItemsFieldNumber = 2;

		// Token: 0x04007DED RID: 32237
		private static readonly FieldCodec<RewardItem> _repeated_rewardItems_codec = FieldCodec.ForMessage<RewardItem>(18U, RewardItem.Parser);

		// Token: 0x04007DEE RID: 32238
		private readonly RepeatedField<RewardItem> rewardItems_ = new RepeatedField<RewardItem>();
	}
}
