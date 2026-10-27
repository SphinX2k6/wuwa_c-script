using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F9 RID: 5369
	[NetMessage(EMessageId.WeaponSkinAddNotify)]
	public sealed class WeaponSkinAddNotify : IMessage<WeaponSkinAddNotify>, IMessage, IEquatable<WeaponSkinAddNotify>, IDeepCloneable<WeaponSkinAddNotify>, IBufferMessage
	{
		// Token: 0x0601C626 RID: 116262 RVA: 0x00419D28 File Offset: 0x00417F28
		[NullableContext(1)]
		public static WeaponSkinAddNotify Create()
		{
			return new WeaponSkinAddNotify();
		}

		// Token: 0x17005FB2 RID: 24498
		// (get) Token: 0x0601C627 RID: 116263 RVA: 0x00419D2F File Offset: 0x00417F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FB3 RID: 24499
		// (get) Token: 0x0601C628 RID: 116264 RVA: 0x00419D32 File Offset: 0x00417F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponSkinAddNotify.Descriptor;
			}
		}

		// Token: 0x0601C629 RID: 116265 RVA: 0x00419D39 File Offset: 0x00417F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinAddNotify()
		{
		}

		// Token: 0x0601C62A RID: 116266 RVA: 0x00419D4C File Offset: 0x00417F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinAddNotify(WeaponSkinAddNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this.isLogin_ = other.isLogin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C62B RID: 116267 RVA: 0x00419D82 File Offset: 0x00417F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinAddNotify Clone()
		{
			return new WeaponSkinAddNotify(this);
		}

		// Token: 0x17005FB4 RID: 24500
		// (get) Token: 0x0601C62C RID: 116268 RVA: 0x00419D8A File Offset: 0x00417F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x17005FB5 RID: 24501
		// (get) Token: 0x0601C62D RID: 116269 RVA: 0x00419D92 File Offset: 0x00417F92
		// (set) Token: 0x0601C62E RID: 116270 RVA: 0x00419D9A File Offset: 0x00417F9A
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

		// Token: 0x0601C62F RID: 116271 RVA: 0x00419DA3 File Offset: 0x00417FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponSkinAddNotify);
		}

		// Token: 0x0601C630 RID: 116272 RVA: 0x00419DB4 File Offset: 0x00417FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponSkinAddNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && this.IsLogin == other.IsLogin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C631 RID: 116273 RVA: 0x00419E04 File Offset: 0x00418004
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

		// Token: 0x0601C632 RID: 116274 RVA: 0x00419E51 File Offset: 0x00418051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C633 RID: 116275 RVA: 0x00419E5E File Offset: 0x0041805E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C634 RID: 116276 RVA: 0x00419E68 File Offset: 0x00418068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsLogin)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsLogin);
			}
			this.skinIds_.WriteTo(ref output, WeaponSkinAddNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C635 RID: 116277 RVA: 0x00419EB8 File Offset: 0x004180B8
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

		// Token: 0x0601C636 RID: 116278 RVA: 0x00419F00 File Offset: 0x00418100
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

		// Token: 0x0601C637 RID: 116279 RVA: 0x00419F4D File Offset: 0x0041814D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C638 RID: 116280 RVA: 0x00419F58 File Offset: 0x00418158
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
				if (num != 16U)
				{
					if (num != 48U && num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.skinIds_.AddEntriesFrom(ref input, WeaponSkinAddNotify._repeated_skinIds_codec);
					}
				}
				else
				{
					this.IsLogin = input.ReadBool();
				}
			}
		}

		// Token: 0x0400A295 RID: 41621
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A296 RID: 41622
		public const int SkinIdsFieldNumber = 6;

		// Token: 0x0400A297 RID: 41623
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400A298 RID: 41624
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();

		// Token: 0x0400A299 RID: 41625
		public const int IsLoginFieldNumber = 2;

		// Token: 0x0400A29A RID: 41626
		private bool isLogin_;
	}
}
