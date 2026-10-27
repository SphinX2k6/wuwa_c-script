using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E9 RID: 5353
	[NetMessage(EMessageId.WeaponAllInfoNotify)]
	public sealed class WeaponAllInfoNotify : IMessage<WeaponAllInfoNotify>, IMessage, IEquatable<WeaponAllInfoNotify>, IDeepCloneable<WeaponAllInfoNotify>, IBufferMessage
	{
		// Token: 0x0601C4D5 RID: 115925 RVA: 0x00416F00 File Offset: 0x00415100
		[NullableContext(1)]
		public static WeaponAllInfoNotify Create()
		{
			return new WeaponAllInfoNotify();
		}

		// Token: 0x17005F69 RID: 24425
		// (get) Token: 0x0601C4D6 RID: 115926 RVA: 0x00416F07 File Offset: 0x00415107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F6A RID: 24426
		// (get) Token: 0x0601C4D7 RID: 115927 RVA: 0x00416F0A File Offset: 0x0041510A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponAllInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601C4D8 RID: 115928 RVA: 0x00416F11 File Offset: 0x00415111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAllInfoNotify()
		{
		}

		// Token: 0x0601C4D9 RID: 115929 RVA: 0x00416F24 File Offset: 0x00415124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAllInfoNotify(WeaponAllInfoNotify other) : this()
		{
			this.allWeapon_ = other.allWeapon_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C4DA RID: 115930 RVA: 0x00416F4E File Offset: 0x0041514E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAllInfoNotify Clone()
		{
			return new WeaponAllInfoNotify(this);
		}

		// Token: 0x17005F6B RID: 24427
		// (get) Token: 0x0601C4DB RID: 115931 RVA: 0x00416F56 File Offset: 0x00415156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneWeaponItemInfo> AllWeapon
		{
			get
			{
				return this.allWeapon_;
			}
		}

		// Token: 0x0601C4DC RID: 115932 RVA: 0x00416F5E File Offset: 0x0041515E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponAllInfoNotify);
		}

		// Token: 0x0601C4DD RID: 115933 RVA: 0x00416F6C File Offset: 0x0041516C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponAllInfoNotify other)
		{
			return other != null && (other == this || (this.allWeapon_.Equals(other.allWeapon_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C4DE RID: 115934 RVA: 0x00416FA0 File Offset: 0x004151A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.allWeapon_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C4DF RID: 115935 RVA: 0x00416FD4 File Offset: 0x004151D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C4E0 RID: 115936 RVA: 0x00416FE1 File Offset: 0x004151E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C4E1 RID: 115937 RVA: 0x00416FEA File Offset: 0x004151EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.allWeapon_.WriteTo(ref output, WeaponAllInfoNotify._repeated_allWeapon_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C4E2 RID: 115938 RVA: 0x00417014 File Offset: 0x00415214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.allWeapon_.CalculateSize(WeaponAllInfoNotify._repeated_allWeapon_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C4E3 RID: 115939 RVA: 0x0041704D File Offset: 0x0041524D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponAllInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.allWeapon_.Add(other.allWeapon_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C4E4 RID: 115940 RVA: 0x0041707B File Offset: 0x0041527B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C4E5 RID: 115941 RVA: 0x00417084 File Offset: 0x00415284
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.allWeapon_.AddEntriesFrom(ref input, WeaponAllInfoNotify._repeated_allWeapon_codec);
				}
			}
		}

		// Token: 0x0400A22E RID: 41518
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A22F RID: 41519
		public const int AllWeaponFieldNumber = 11;

		// Token: 0x0400A230 RID: 41520
		private static readonly FieldCodec<OneWeaponItemInfo> _repeated_allWeapon_codec = FieldCodec.ForMessage<OneWeaponItemInfo>(90U, OneWeaponItemInfo.Parser);

		// Token: 0x0400A231 RID: 41521
		private readonly RepeatedField<OneWeaponItemInfo> allWeapon_ = new RepeatedField<OneWeaponItemInfo>();
	}
}
