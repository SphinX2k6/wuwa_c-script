using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053D RID: 1341
	[NetMessage(EMessageId.FishingEntrustHandInRequest)]
	public sealed class FishingEntrustHandInRequest : IMessage<FishingEntrustHandInRequest>, IMessage, IEquatable<FishingEntrustHandInRequest>, IDeepCloneable<FishingEntrustHandInRequest>, IBufferMessage
	{
		// Token: 0x06007DD5 RID: 32213 RVA: 0x00131141 File Offset: 0x0012F341
		[NullableContext(1)]
		public static FishingEntrustHandInRequest Create()
		{
			return new FishingEntrustHandInRequest();
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06007DD6 RID: 32214 RVA: 0x00131148 File Offset: 0x0012F348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06007DD7 RID: 32215 RVA: 0x0013114B File Offset: 0x0012F34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustHandInRequest.Descriptor;
			}
		}

		// Token: 0x06007DD8 RID: 32216 RVA: 0x00131152 File Offset: 0x0012F352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInRequest()
		{
		}

		// Token: 0x06007DD9 RID: 32217 RVA: 0x00131165 File Offset: 0x0012F365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInRequest(FishingEntrustHandInRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this.handInItem_ = other.handInItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DDA RID: 32218 RVA: 0x0013119B File Offset: 0x0012F39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInRequest Clone()
		{
			return new FishingEntrustHandInRequest(this);
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06007DDB RID: 32219 RVA: 0x001311A3 File Offset: 0x0012F3A3
		// (set) Token: 0x06007DDC RID: 32220 RVA: 0x001311AB File Offset: 0x0012F3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustId
		{
			get
			{
				return this.entrustId_;
			}
			set
			{
				this.entrustId_ = value;
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06007DDD RID: 32221 RVA: 0x001311B4 File Offset: 0x0012F3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingHandInItem> HandInItem
		{
			get
			{
				return this.handInItem_;
			}
		}

		// Token: 0x06007DDE RID: 32222 RVA: 0x001311BC File Offset: 0x0012F3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustHandInRequest);
		}

		// Token: 0x06007DDF RID: 32223 RVA: 0x001311CC File Offset: 0x0012F3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustHandInRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && this.handInItem_.Equals(other.handInItem_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DE0 RID: 32224 RVA: 0x0013121C File Offset: 0x0012F41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			num ^= this.handInItem_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x00131269 File Offset: 0x0012F469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007DE2 RID: 32226 RVA: 0x00131276 File Offset: 0x0012F476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DE3 RID: 32227 RVA: 0x00131280 File Offset: 0x0012F480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.handInItem_.WriteTo(ref output, FishingEntrustHandInRequest._repeated_handInItem_codec);
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DE4 RID: 32228 RVA: 0x001312D0 File Offset: 0x0012F4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			num += this.handInItem_.CalculateSize(FishingEntrustHandInRequest._repeated_handInItem_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x00131324 File Offset: 0x0012F524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustHandInRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			this.handInItem_.Add(other.handInItem_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007DE6 RID: 32230 RVA: 0x00131371 File Offset: 0x0012F571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DE7 RID: 32231 RVA: 0x0013137C File Offset: 0x0012F57C
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
				if (num != 58U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntrustId = input.ReadInt32();
					}
				}
				else
				{
					this.handInItem_.AddEntriesFrom(ref input, FishingEntrustHandInRequest._repeated_handInItem_codec);
				}
			}
		}

		// Token: 0x0400404B RID: 16459
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400404C RID: 16460
		public const int EntrustIdFieldNumber = 10;

		// Token: 0x0400404D RID: 16461
		private int entrustId_;

		// Token: 0x0400404E RID: 16462
		public const int HandInItemFieldNumber = 7;

		// Token: 0x0400404F RID: 16463
		private static readonly FieldCodec<FishingHandInItem> _repeated_handInItem_codec = FieldCodec.ForMessage<FishingHandInItem>(58U, FishingHandInItem.Parser);

		// Token: 0x04004050 RID: 16464
		private readonly RepeatedField<FishingHandInItem> handInItem_ = new RepeatedField<FishingHandInItem>();
	}
}
