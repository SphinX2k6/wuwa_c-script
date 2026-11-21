using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001571 RID: 5489
	[NetMessage(EMessageId.WeaponSkinUpdateNotify)]
	public sealed class WeaponSkinUpdateNotify : IMessage<WeaponSkinUpdateNotify>, IMessage, IEquatable<WeaponSkinUpdateNotify>, IDeepCloneable<WeaponSkinUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601D115 RID: 119061 RVA: 0x00435D20 File Offset: 0x00433F20
		[NullableContext(1)]
		public static WeaponSkinUpdateNotify Create()
		{
			return new WeaponSkinUpdateNotify();
		}

		// Token: 0x1700625B RID: 25179
		// (get) Token: 0x0601D116 RID: 119062 RVA: 0x00435D27 File Offset: 0x00433F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700625C RID: 25180
		// (get) Token: 0x0601D117 RID: 119063 RVA: 0x00435D2A File Offset: 0x00433F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponSkinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601D118 RID: 119064 RVA: 0x00435D31 File Offset: 0x00433F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUpdateNotify()
		{
		}

		// Token: 0x0601D119 RID: 119065 RVA: 0x00435D44 File Offset: 0x00433F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUpdateNotify(WeaponSkinUpdateNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D11A RID: 119066 RVA: 0x00435D6E File Offset: 0x00433F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUpdateNotify Clone()
		{
			return new WeaponSkinUpdateNotify(this);
		}

		// Token: 0x1700625D RID: 25181
		// (get) Token: 0x0601D11B RID: 119067 RVA: 0x00435D76 File Offset: 0x00433F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x0601D11C RID: 119068 RVA: 0x00435D7E File Offset: 0x00433F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponSkinUpdateNotify);
		}

		// Token: 0x0601D11D RID: 119069 RVA: 0x00435D8C File Offset: 0x00433F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponSkinUpdateNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D11E RID: 119070 RVA: 0x00435DC0 File Offset: 0x00433FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D11F RID: 119071 RVA: 0x00435DF4 File Offset: 0x00433FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D120 RID: 119072 RVA: 0x00435E01 File Offset: 0x00434001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D121 RID: 119073 RVA: 0x00435E0A File Offset: 0x0043400A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, WeaponSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D122 RID: 119074 RVA: 0x00435E34 File Offset: 0x00434034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(WeaponSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D123 RID: 119075 RVA: 0x00435E6D File Offset: 0x0043406D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponSkinUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D124 RID: 119076 RVA: 0x00435E9B File Offset: 0x0043409B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D125 RID: 119077 RVA: 0x00435EA4 File Offset: 0x004340A4
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, WeaponSkinUpdateNotify._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x0400A6F9 RID: 42745
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6FA RID: 42746
		public const int SkinIdsFieldNumber = 7;

		// Token: 0x0400A6FB RID: 42747
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x0400A6FC RID: 42748
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}
