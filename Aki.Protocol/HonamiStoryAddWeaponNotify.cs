using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000761 RID: 1889
	[NetMessage(EMessageId.HonamiStoryAddWeaponNotify)]
	public sealed class HonamiStoryAddWeaponNotify : IMessage<HonamiStoryAddWeaponNotify>, IMessage, IEquatable<HonamiStoryAddWeaponNotify>, IDeepCloneable<HonamiStoryAddWeaponNotify>, IBufferMessage
	{
		// Token: 0x0600AAFD RID: 43773 RVA: 0x0019BA53 File Offset: 0x00199C53
		[NullableContext(1)]
		public static HonamiStoryAddWeaponNotify Create()
		{
			return new HonamiStoryAddWeaponNotify();
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x0600AAFE RID: 43774 RVA: 0x0019BA5A File Offset: 0x00199C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x0600AAFF RID: 43775 RVA: 0x0019BA5D File Offset: 0x00199C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAddWeaponNotify.Descriptor;
			}
		}

		// Token: 0x0600AB00 RID: 43776 RVA: 0x0019BA64 File Offset: 0x00199C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAddWeaponNotify()
		{
		}

		// Token: 0x0600AB01 RID: 43777 RVA: 0x0019BA77 File Offset: 0x00199C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAddWeaponNotify(HonamiStoryAddWeaponNotify other) : this()
		{
			this.weaponIds_ = other.weaponIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB02 RID: 43778 RVA: 0x0019BAA1 File Offset: 0x00199CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAddWeaponNotify Clone()
		{
			return new HonamiStoryAddWeaponNotify(this);
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x0600AB03 RID: 43779 RVA: 0x0019BAA9 File Offset: 0x00199CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeaponIds
		{
			get
			{
				return this.weaponIds_;
			}
		}

		// Token: 0x0600AB04 RID: 43780 RVA: 0x0019BAB1 File Offset: 0x00199CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAddWeaponNotify);
		}

		// Token: 0x0600AB05 RID: 43781 RVA: 0x0019BABF File Offset: 0x00199CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAddWeaponNotify other)
		{
			return other != null && (other == this || (this.weaponIds_.Equals(other.weaponIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x0019BAF4 File Offset: 0x00199CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.weaponIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB07 RID: 43783 RVA: 0x0019BB28 File Offset: 0x00199D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB08 RID: 43784 RVA: 0x0019BB35 File Offset: 0x00199D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB09 RID: 43785 RVA: 0x0019BB3E File Offset: 0x00199D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weaponIds_.WriteTo(ref output, HonamiStoryAddWeaponNotify._repeated_weaponIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB0A RID: 43786 RVA: 0x0019BB68 File Offset: 0x00199D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.weaponIds_.CalculateSize(HonamiStoryAddWeaponNotify._repeated_weaponIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB0B RID: 43787 RVA: 0x0019BBA1 File Offset: 0x00199DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAddWeaponNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.weaponIds_.Add(other.weaponIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB0C RID: 43788 RVA: 0x0019BBCF File Offset: 0x00199DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB0D RID: 43789 RVA: 0x0019BBD8 File Offset: 0x00199DD8
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
					this.weaponIds_.AddEntriesFrom(ref input, HonamiStoryAddWeaponNotify._repeated_weaponIds_codec);
				}
			}
		}

		// Token: 0x04004DB9 RID: 19897
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DBA RID: 19898
		public const int WeaponIdsFieldNumber = 6;

		// Token: 0x04004DBB RID: 19899
		private static readonly FieldCodec<int> _repeated_weaponIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04004DBC RID: 19900
		private readonly RepeatedField<int> weaponIds_ = new RepeatedField<int>();
	}
}
