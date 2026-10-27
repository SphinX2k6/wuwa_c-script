using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089E RID: 2206
	[NetMessage(EMessageId.KurotatoItemUnlockNotify)]
	public sealed class KurotatoItemUnlockNotify : IMessage<KurotatoItemUnlockNotify>, IMessage, IEquatable<KurotatoItemUnlockNotify>, IDeepCloneable<KurotatoItemUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600C40C RID: 50188 RVA: 0x001D102F File Offset: 0x001CF22F
		[NullableContext(1)]
		public static KurotatoItemUnlockNotify Create()
		{
			return new KurotatoItemUnlockNotify();
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x0600C40D RID: 50189 RVA: 0x001D1036 File Offset: 0x001CF236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x0600C40E RID: 50190 RVA: 0x001D1039 File Offset: 0x001CF239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600C40F RID: 50191 RVA: 0x001D1040 File Offset: 0x001CF240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUnlockNotify()
		{
		}

		// Token: 0x0600C410 RID: 50192 RVA: 0x001D1053 File Offset: 0x001CF253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUnlockNotify(KurotatoItemUnlockNotify other) : this()
		{
			this.unlockItems_ = other.unlockItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C411 RID: 50193 RVA: 0x001D107D File Offset: 0x001CF27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUnlockNotify Clone()
		{
			return new KurotatoItemUnlockNotify(this);
		}

		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x0600C412 RID: 50194 RVA: 0x001D1085 File Offset: 0x001CF285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItems
		{
			get
			{
				return this.unlockItems_;
			}
		}

		// Token: 0x0600C413 RID: 50195 RVA: 0x001D108D File Offset: 0x001CF28D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemUnlockNotify);
		}

		// Token: 0x0600C414 RID: 50196 RVA: 0x001D109B File Offset: 0x001CF29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockItems_.Equals(other.unlockItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C415 RID: 50197 RVA: 0x001D10D0 File Offset: 0x001CF2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C416 RID: 50198 RVA: 0x001D1104 File Offset: 0x001CF304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C417 RID: 50199 RVA: 0x001D1111 File Offset: 0x001CF311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C418 RID: 50200 RVA: 0x001D111A File Offset: 0x001CF31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockItems_.WriteTo(ref output, KurotatoItemUnlockNotify._repeated_unlockItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C419 RID: 50201 RVA: 0x001D1144 File Offset: 0x001CF344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockItems_.CalculateSize(KurotatoItemUnlockNotify._repeated_unlockItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C41A RID: 50202 RVA: 0x001D117D File Offset: 0x001CF37D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoItemUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockItems_.Add(other.unlockItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C41B RID: 50203 RVA: 0x001D11AB File Offset: 0x001CF3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C41C RID: 50204 RVA: 0x001D11B4 File Offset: 0x001CF3B4
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockItems_.AddEntriesFrom(ref input, KurotatoItemUnlockNotify._repeated_unlockItems_codec);
				}
			}
		}

		// Token: 0x040054A0 RID: 21664
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054A1 RID: 21665
		public const int UnlockItemsFieldNumber = 5;

		// Token: 0x040054A2 RID: 21666
		private static readonly FieldCodec<int> _repeated_unlockItems_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040054A3 RID: 21667
		private readonly RepeatedField<int> unlockItems_ = new RepeatedField<int>();
	}
}
