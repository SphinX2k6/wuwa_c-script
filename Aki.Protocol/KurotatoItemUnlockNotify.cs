using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088D RID: 2189
	[NetMessage(EMessageId.KurotatoItemUnlockNotify)]
	public sealed class KurotatoItemUnlockNotify : IMessage<KurotatoItemUnlockNotify>, IMessage, IEquatable<KurotatoItemUnlockNotify>, IDeepCloneable<KurotatoItemUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600C2F0 RID: 49904 RVA: 0x001CED4B File Offset: 0x001CCF4B
		[NullableContext(1)]
		public static KurotatoItemUnlockNotify Create()
		{
			return new KurotatoItemUnlockNotify();
		}

		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x0600C2F1 RID: 49905 RVA: 0x001CED52 File Offset: 0x001CCF52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x0600C2F2 RID: 49906 RVA: 0x001CED55 File Offset: 0x001CCF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600C2F3 RID: 49907 RVA: 0x001CED5C File Offset: 0x001CCF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUnlockNotify()
		{
		}

		// Token: 0x0600C2F4 RID: 49908 RVA: 0x001CED6F File Offset: 0x001CCF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUnlockNotify(KurotatoItemUnlockNotify other) : this()
		{
			this.unlockItems_ = other.unlockItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2F5 RID: 49909 RVA: 0x001CED99 File Offset: 0x001CCF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUnlockNotify Clone()
		{
			return new KurotatoItemUnlockNotify(this);
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x0600C2F6 RID: 49910 RVA: 0x001CEDA1 File Offset: 0x001CCFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItems
		{
			get
			{
				return this.unlockItems_;
			}
		}

		// Token: 0x0600C2F7 RID: 49911 RVA: 0x001CEDA9 File Offset: 0x001CCFA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemUnlockNotify);
		}

		// Token: 0x0600C2F8 RID: 49912 RVA: 0x001CEDB7 File Offset: 0x001CCFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockItems_.Equals(other.unlockItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C2F9 RID: 49913 RVA: 0x001CEDEC File Offset: 0x001CCFEC
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

		// Token: 0x0600C2FA RID: 49914 RVA: 0x001CEE20 File Offset: 0x001CD020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C2FB RID: 49915 RVA: 0x001CEE2D File Offset: 0x001CD02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2FC RID: 49916 RVA: 0x001CEE36 File Offset: 0x001CD036
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

		// Token: 0x0600C2FD RID: 49917 RVA: 0x001CEE60 File Offset: 0x001CD060
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

		// Token: 0x0600C2FE RID: 49918 RVA: 0x001CEE99 File Offset: 0x001CD099
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

		// Token: 0x0600C2FF RID: 49919 RVA: 0x001CEEC7 File Offset: 0x001CD0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C300 RID: 49920 RVA: 0x001CEED0 File Offset: 0x001CD0D0
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockItems_.AddEntriesFrom(ref input, KurotatoItemUnlockNotify._repeated_unlockItems_codec);
				}
			}
		}

		// Token: 0x040054A7 RID: 21671
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054A8 RID: 21672
		public const int UnlockItemsFieldNumber = 9;

		// Token: 0x040054A9 RID: 21673
		private static readonly FieldCodec<int> _repeated_unlockItems_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040054AA RID: 21674
		private readonly RepeatedField<int> unlockItems_ = new RepeatedField<int>();
	}
}
