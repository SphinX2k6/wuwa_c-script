using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DE RID: 1758
	[NetMessage(EMessageId.GiantItemUnlockNotify)]
	public sealed class GiantItemUnlockNotify : IMessage<GiantItemUnlockNotify>, IMessage, IEquatable<GiantItemUnlockNotify>, IDeepCloneable<GiantItemUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600A078 RID: 41080 RVA: 0x00184955 File Offset: 0x00182B55
		[NullableContext(1)]
		public static GiantItemUnlockNotify Create()
		{
			return new GiantItemUnlockNotify();
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x0600A079 RID: 41081 RVA: 0x0018495C File Offset: 0x00182B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x0600A07A RID: 41082 RVA: 0x0018495F File Offset: 0x00182B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantItemUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600A07B RID: 41083 RVA: 0x00184966 File Offset: 0x00182B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemUnlockNotify()
		{
		}

		// Token: 0x0600A07C RID: 41084 RVA: 0x00184979 File Offset: 0x00182B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemUnlockNotify(GiantItemUnlockNotify other) : this()
		{
			this.unlockItemIds_ = other.unlockItemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A07D RID: 41085 RVA: 0x001849A3 File Offset: 0x00182BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantItemUnlockNotify Clone()
		{
			return new GiantItemUnlockNotify(this);
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x0600A07E RID: 41086 RVA: 0x001849AB File Offset: 0x00182BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItemIds
		{
			get
			{
				return this.unlockItemIds_;
			}
		}

		// Token: 0x0600A07F RID: 41087 RVA: 0x001849B3 File Offset: 0x00182BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantItemUnlockNotify);
		}

		// Token: 0x0600A080 RID: 41088 RVA: 0x001849C1 File Offset: 0x00182BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantItemUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockItemIds_.Equals(other.unlockItemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A081 RID: 41089 RVA: 0x001849F4 File Offset: 0x00182BF4
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

		// Token: 0x0600A082 RID: 41090 RVA: 0x00184A28 File Offset: 0x00182C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A083 RID: 41091 RVA: 0x00184A35 File Offset: 0x00182C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A084 RID: 41092 RVA: 0x00184A3E File Offset: 0x00182C3E
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

		// Token: 0x0600A085 RID: 41093 RVA: 0x00184A68 File Offset: 0x00182C68
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

		// Token: 0x0600A086 RID: 41094 RVA: 0x00184AA1 File Offset: 0x00182CA1
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

		// Token: 0x0600A087 RID: 41095 RVA: 0x00184ACF File Offset: 0x00182CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A088 RID: 41096 RVA: 0x00184AD8 File Offset: 0x00182CD8
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockItemIds_.AddEntriesFrom(ref input, GiantItemUnlockNotify._repeated_unlockItemIds_codec);
				}
			}
		}

		// Token: 0x04004AB4 RID: 19124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AB5 RID: 19125
		public const int UnlockItemIdsFieldNumber = 6;

		// Token: 0x04004AB6 RID: 19126
		private static readonly FieldCodec<int> _repeated_unlockItemIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04004AB7 RID: 19127
		private readonly RepeatedField<int> unlockItemIds_ = new RepeatedField<int>();
	}
}
