using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E0 RID: 2272
	[NetMessage(EMessageId.KurotatoWeaponUnlockNotify)]
	public sealed class KurotatoWeaponUnlockNotify : IMessage<KurotatoWeaponUnlockNotify>, IMessage, IEquatable<KurotatoWeaponUnlockNotify>, IDeepCloneable<KurotatoWeaponUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600C91A RID: 51482 RVA: 0x001DB850 File Offset: 0x001D9A50
		[NullableContext(1)]
		public static KurotatoWeaponUnlockNotify Create()
		{
			return new KurotatoWeaponUnlockNotify();
		}

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x0600C91B RID: 51483 RVA: 0x001DB857 File Offset: 0x001D9A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x0600C91C RID: 51484 RVA: 0x001DB85A File Offset: 0x001D9A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoWeaponUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600C91D RID: 51485 RVA: 0x001DB861 File Offset: 0x001D9A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUnlockNotify()
		{
		}

		// Token: 0x0600C91E RID: 51486 RVA: 0x001DB874 File Offset: 0x001D9A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUnlockNotify(KurotatoWeaponUnlockNotify other) : this()
		{
			this.unlockWeapons_ = other.unlockWeapons_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C91F RID: 51487 RVA: 0x001DB89E File Offset: 0x001D9A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponUnlockNotify Clone()
		{
			return new KurotatoWeaponUnlockNotify(this);
		}

		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x0600C920 RID: 51488 RVA: 0x001DB8A6 File Offset: 0x001D9AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeapons
		{
			get
			{
				return this.unlockWeapons_;
			}
		}

		// Token: 0x0600C921 RID: 51489 RVA: 0x001DB8AE File Offset: 0x001D9AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoWeaponUnlockNotify);
		}

		// Token: 0x0600C922 RID: 51490 RVA: 0x001DB8BC File Offset: 0x001D9ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoWeaponUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockWeapons_.Equals(other.unlockWeapons_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C923 RID: 51491 RVA: 0x001DB8F0 File Offset: 0x001D9AF0
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

		// Token: 0x0600C924 RID: 51492 RVA: 0x001DB924 File Offset: 0x001D9B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C925 RID: 51493 RVA: 0x001DB931 File Offset: 0x001D9B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C926 RID: 51494 RVA: 0x001DB93A File Offset: 0x001D9B3A
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

		// Token: 0x0600C927 RID: 51495 RVA: 0x001DB964 File Offset: 0x001D9B64
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

		// Token: 0x0600C928 RID: 51496 RVA: 0x001DB99D File Offset: 0x001D9B9D
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

		// Token: 0x0600C929 RID: 51497 RVA: 0x001DB9CB File Offset: 0x001D9BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C92A RID: 51498 RVA: 0x001DB9D4 File Offset: 0x001D9BD4
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
					this.unlockWeapons_.AddEntriesFrom(ref input, KurotatoWeaponUnlockNotify._repeated_unlockWeapons_codec);
				}
			}
		}

		// Token: 0x040055DD RID: 21981
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055DE RID: 21982
		public const int UnlockWeaponsFieldNumber = 9;

		// Token: 0x040055DF RID: 21983
		private static readonly FieldCodec<int> _repeated_unlockWeapons_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040055E0 RID: 21984
		private readonly RepeatedField<int> unlockWeapons_ = new RepeatedField<int>();
	}
}
