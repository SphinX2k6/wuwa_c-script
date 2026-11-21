using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200156F RID: 5487
	[NetMessage(EMessageId.WeaponSkinAddNotify)]
	public sealed class WeaponSkinAddNotify : IMessage<WeaponSkinAddNotify>, IMessage, IEquatable<WeaponSkinAddNotify>, IDeepCloneable<WeaponSkinAddNotify>, IBufferMessage
	{
		// Token: 0x0601D0ED RID: 119021 RVA: 0x004357E8 File Offset: 0x004339E8
		[NullableContext(1)]
		public static WeaponSkinAddNotify Create()
		{
			return new WeaponSkinAddNotify();
		}

		// Token: 0x17006253 RID: 25171
		// (get) Token: 0x0601D0EE RID: 119022 RVA: 0x004357EF File Offset: 0x004339EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006254 RID: 25172
		// (get) Token: 0x0601D0EF RID: 119023 RVA: 0x004357F2 File Offset: 0x004339F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponSkinAddNotify.Descriptor;
			}
		}

		// Token: 0x0601D0F0 RID: 119024 RVA: 0x004357F9 File Offset: 0x004339F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinAddNotify()
		{
		}

		// Token: 0x0601D0F1 RID: 119025 RVA: 0x0043580C File Offset: 0x00433A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinAddNotify(WeaponSkinAddNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this.isLogin_ = other.isLogin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D0F2 RID: 119026 RVA: 0x00435842 File Offset: 0x00433A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinAddNotify Clone()
		{
			return new WeaponSkinAddNotify(this);
		}

		// Token: 0x17006255 RID: 25173
		// (get) Token: 0x0601D0F3 RID: 119027 RVA: 0x0043584A File Offset: 0x00433A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x17006256 RID: 25174
		// (get) Token: 0x0601D0F4 RID: 119028 RVA: 0x00435852 File Offset: 0x00433A52
		// (set) Token: 0x0601D0F5 RID: 119029 RVA: 0x0043585A File Offset: 0x00433A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLogin
		{
			get
			{
				return this.isLogin_;
			}
			set
			{
				this.isLogin_ = value;
			}
		}

		// Token: 0x0601D0F6 RID: 119030 RVA: 0x00435863 File Offset: 0x00433A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponSkinAddNotify);
		}

		// Token: 0x0601D0F7 RID: 119031 RVA: 0x00435874 File Offset: 0x00433A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponSkinAddNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && this.IsLogin == other.IsLogin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D0F8 RID: 119032 RVA: 0x004358C4 File Offset: 0x00433AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinIds_.GetHashCode();
			if (this.IsLogin)
			{
				num ^= this.IsLogin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D0F9 RID: 119033 RVA: 0x00435911 File Offset: 0x00433B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D0FA RID: 119034 RVA: 0x0043591E File Offset: 0x00433B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D0FB RID: 119035 RVA: 0x00435928 File Offset: 0x00433B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, WeaponSkinAddNotify._repeated_skinIds_codec);
			if (this.IsLogin)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsLogin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D0FC RID: 119036 RVA: 0x00435978 File Offset: 0x00433B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(WeaponSkinAddNotify._repeated_skinIds_codec);
			if (this.IsLogin)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D0FD RID: 119037 RVA: 0x004359C0 File Offset: 0x00433BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponSkinAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			if (other.IsLogin)
			{
				this.IsLogin = other.IsLogin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D0FE RID: 119038 RVA: 0x00435A0D File Offset: 0x00433C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D0FF RID: 119039 RVA: 0x00435A18 File Offset: 0x00433C18
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
				if (num != 8U && num != 10U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsLogin = input.ReadBool();
					}
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, WeaponSkinAddNotify._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x0400A6EE RID: 42734
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6EF RID: 42735
		public const int SkinIdsFieldNumber = 1;

		// Token: 0x0400A6F0 RID: 42736
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400A6F1 RID: 42737
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();

		// Token: 0x0400A6F2 RID: 42738
		public const int IsLoginFieldNumber = 11;

		// Token: 0x0400A6F3 RID: 42739
		private bool isLogin_;
	}
}
