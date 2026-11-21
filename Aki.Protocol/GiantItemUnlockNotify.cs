using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CA RID: 1738
	[NetMessage(EMessageId.GiantItemUnlockNotify)]
	public sealed class GiantItemUnlockNotify : IMessage<GiantItemUnlockNotify>, IMessage, IEquatable<GiantItemUnlockNotify>, IDeepCloneable<GiantItemUnlockNotify>, IBufferMessage
	{
		// Token: 0x06009F22 RID: 40738 RVA: 0x00181F21 File Offset: 0x00180121
		[NullableContext(1)]
		public static GiantItemUnlockNotify Create()
		{
			return new GiantItemUnlockNotify();
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x06009F23 RID: 40739 RVA: 0x00181F28 File Offset: 0x00180128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06009F24 RID: 40740 RVA: 0x00181F2B File Offset: 0x0018012B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantItemUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06009F25 RID: 40741 RVA: 0x00181F32 File Offset: 0x00180132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemUnlockNotify()
		{
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x00181F45 File Offset: 0x00180145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemUnlockNotify(GiantItemUnlockNotify other) : this()
		{
			this.unlockItemIds_ = other.unlockItemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F27 RID: 40743 RVA: 0x00181F6F File Offset: 0x0018016F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemUnlockNotify Clone()
		{
			return new GiantItemUnlockNotify(this);
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06009F28 RID: 40744 RVA: 0x00181F77 File Offset: 0x00180177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItemIds
		{
			get
			{
				return this.unlockItemIds_;
			}
		}

		// Token: 0x06009F29 RID: 40745 RVA: 0x00181F7F File Offset: 0x0018017F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantItemUnlockNotify);
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x00181F8D File Offset: 0x0018018D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantItemUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockItemIds_.Equals(other.unlockItemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F2B RID: 40747 RVA: 0x00181FC0 File Offset: 0x001801C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockItemIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x00181FF4 File Offset: 0x001801F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F2D RID: 40749 RVA: 0x00182001 File Offset: 0x00180201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F2E RID: 40750 RVA: 0x0018200A File Offset: 0x0018020A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockItemIds_.WriteTo(ref output, GiantItemUnlockNotify._repeated_unlockItemIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F2F RID: 40751 RVA: 0x00182034 File Offset: 0x00180234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockItemIds_.CalculateSize(GiantItemUnlockNotify._repeated_unlockItemIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F30 RID: 40752 RVA: 0x0018206D File Offset: 0x0018026D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantItemUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockItemIds_.Add(other.unlockItemIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F31 RID: 40753 RVA: 0x0018209B File Offset: 0x0018029B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F32 RID: 40754 RVA: 0x001820A4 File Offset: 0x001802A4
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockItemIds_.AddEntriesFrom(ref input, GiantItemUnlockNotify._repeated_unlockItemIds_codec);
				}
			}
		}

		// Token: 0x04004AAD RID: 19117
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AAE RID: 19118
		public const int UnlockItemIdsFieldNumber = 10;

		// Token: 0x04004AAF RID: 19119
		private static readonly FieldCodec<int> _repeated_unlockItemIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04004AB0 RID: 19120
		private readonly RepeatedField<int> unlockItemIds_ = new RepeatedField<int>();
	}
}
