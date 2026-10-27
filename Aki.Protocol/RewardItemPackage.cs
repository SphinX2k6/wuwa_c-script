using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F36 RID: 3894
	public sealed class RewardItemPackage : IMessage<RewardItemPackage>, IMessage, IEquatable<RewardItemPackage>, IDeepCloneable<RewardItemPackage>, IBufferMessage
	{
		// Token: 0x06014D69 RID: 85353 RVA: 0x00305F27 File Offset: 0x00304127
		[NullableContext(1)]
		public static RewardItemPackage Create()
		{
			return new RewardItemPackage();
		}

		// Token: 0x17004548 RID: 17736
		// (get) Token: 0x06014D6A RID: 85354 RVA: 0x00305F2E File Offset: 0x0030412E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RewardItemPackage> Parser
		{
			get
			{
				return RewardItemPackage._parser;
			}
		}

		// Token: 0x17004549 RID: 17737
		// (get) Token: 0x06014D6B RID: 85355 RVA: 0x00305F35 File Offset: 0x00304135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700454A RID: 17738
		// (get) Token: 0x06014D6C RID: 85356 RVA: 0x00305F38 File Offset: 0x00304138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RewardItemPackage.Descriptor;
			}
		}

		// Token: 0x06014D6D RID: 85357 RVA: 0x00305F3F File Offset: 0x0030413F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemPackage()
		{
		}

		// Token: 0x06014D6E RID: 85358 RVA: 0x00305F54 File Offset: 0x00304154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemPackage(RewardItemPackage other) : this()
		{
			this.rewardItem_ = ((other.rewardItem_ != null) ? other.rewardItem_.Clone() : null);
			this.rewardItems_ = other.rewardItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D6F RID: 85359 RVA: 0x00305FA5 File Offset: 0x003041A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemPackage Clone()
		{
			return new RewardItemPackage(this);
		}

		// Token: 0x1700454B RID: 17739
		// (get) Token: 0x06014D70 RID: 85360 RVA: 0x00305FAD File Offset: 0x003041AD
		// (set) Token: 0x06014D71 RID: 85361 RVA: 0x00305FB5 File Offset: 0x003041B5
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

		// Token: 0x1700454C RID: 17740
		// (get) Token: 0x06014D72 RID: 85362 RVA: 0x00305FBE File Offset: 0x003041BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItem> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x06014D73 RID: 85363 RVA: 0x00305FC6 File Offset: 0x003041C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RewardItemPackage);
		}

		// Token: 0x06014D74 RID: 85364 RVA: 0x00305FD4 File Offset: 0x003041D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RewardItemPackage other)
		{
			return other != null && (other == this || (object.Equals(this.RewardItem, other.RewardItem) && this.rewardItems_.Equals(other.rewardItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D75 RID: 85365 RVA: 0x00306028 File Offset: 0x00304228
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

		// Token: 0x06014D76 RID: 85366 RVA: 0x00306072 File Offset: 0x00304272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D77 RID: 85367 RVA: 0x0030607F File Offset: 0x0030427F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D78 RID: 85368 RVA: 0x00306088 File Offset: 0x00304288
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

		// Token: 0x06014D79 RID: 85369 RVA: 0x003060D8 File Offset: 0x003042D8
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

		// Token: 0x06014D7A RID: 85370 RVA: 0x0030612C File Offset: 0x0030432C
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

		// Token: 0x06014D7B RID: 85371 RVA: 0x00306191 File Offset: 0x00304391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D7C RID: 85372 RVA: 0x0030619C File Offset: 0x0030439C
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

		// Token: 0x04007DBE RID: 32190
		private static readonly MessageParser<RewardItemPackage> _parser = new MessageParser<RewardItemPackage>(() => new RewardItemPackage());

		// Token: 0x04007DBF RID: 32191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DC0 RID: 32192
		public const int RewardItemFieldNumber = 1;

		// Token: 0x04007DC1 RID: 32193
		private RewardItem rewardItem_;

		// Token: 0x04007DC2 RID: 32194
		public const int RewardItemsFieldNumber = 2;

		// Token: 0x04007DC3 RID: 32195
		private static readonly FieldCodec<RewardItem> _repeated_rewardItems_codec = FieldCodec.ForMessage<RewardItem>(18U, RewardItem.Parser);

		// Token: 0x04007DC4 RID: 32196
		private readonly RepeatedField<RewardItem> rewardItems_ = new RepeatedField<RewardItem>();
	}
}
