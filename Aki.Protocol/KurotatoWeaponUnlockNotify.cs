using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CF RID: 2255
	[NetMessage(EMessageId.KurotatoWeaponUnlockNotify)]
	public sealed class KurotatoWeaponUnlockNotify : IMessage<KurotatoWeaponUnlockNotify>, IMessage, IEquatable<KurotatoWeaponUnlockNotify>, IDeepCloneable<KurotatoWeaponUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600C7FE RID: 51198 RVA: 0x001D9574 File Offset: 0x001D7774
		[NullableContext(1)]
		public static KurotatoWeaponUnlockNotify Create()
		{
			return new KurotatoWeaponUnlockNotify();
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x0600C7FF RID: 51199 RVA: 0x001D957B File Offset: 0x001D777B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x0600C800 RID: 51200 RVA: 0x001D957E File Offset: 0x001D777E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoWeaponUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600C801 RID: 51201 RVA: 0x001D9585 File Offset: 0x001D7785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUnlockNotify()
		{
		}

		// Token: 0x0600C802 RID: 51202 RVA: 0x001D9598 File Offset: 0x001D7798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUnlockNotify(KurotatoWeaponUnlockNotify other) : this()
		{
			this.unlockWeapons_ = other.unlockWeapons_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C803 RID: 51203 RVA: 0x001D95C2 File Offset: 0x001D77C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUnlockNotify Clone()
		{
			return new KurotatoWeaponUnlockNotify(this);
		}

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x0600C804 RID: 51204 RVA: 0x001D95CA File Offset: 0x001D77CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeapons
		{
			get
			{
				return this.unlockWeapons_;
			}
		}

		// Token: 0x0600C805 RID: 51205 RVA: 0x001D95D2 File Offset: 0x001D77D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoWeaponUnlockNotify);
		}

		// Token: 0x0600C806 RID: 51206 RVA: 0x001D95E0 File Offset: 0x001D77E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoWeaponUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockWeapons_.Equals(other.unlockWeapons_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C807 RID: 51207 RVA: 0x001D9614 File Offset: 0x001D7814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockWeapons_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C808 RID: 51208 RVA: 0x001D9648 File Offset: 0x001D7848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C809 RID: 51209 RVA: 0x001D9655 File Offset: 0x001D7855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C80A RID: 51210 RVA: 0x001D965E File Offset: 0x001D785E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockWeapons_.WriteTo(ref output, KurotatoWeaponUnlockNotify._repeated_unlockWeapons_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C80B RID: 51211 RVA: 0x001D9688 File Offset: 0x001D7888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockWeapons_.CalculateSize(KurotatoWeaponUnlockNotify._repeated_unlockWeapons_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C80C RID: 51212 RVA: 0x001D96C1 File Offset: 0x001D78C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoWeaponUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockWeapons_.Add(other.unlockWeapons_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C80D RID: 51213 RVA: 0x001D96EF File Offset: 0x001D78EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C80E RID: 51214 RVA: 0x001D96F8 File Offset: 0x001D78F8
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockWeapons_.AddEntriesFrom(ref input, KurotatoWeaponUnlockNotify._repeated_unlockWeapons_codec);
				}
			}
		}

		// Token: 0x040055E4 RID: 21988
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055E5 RID: 21989
		public const int UnlockWeaponsFieldNumber = 8;

		// Token: 0x040055E6 RID: 21990
		private static readonly FieldCodec<int> _repeated_unlockWeapons_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040055E7 RID: 21991
		private readonly RepeatedField<int> unlockWeapons_ = new RepeatedField<int>();
	}
}
