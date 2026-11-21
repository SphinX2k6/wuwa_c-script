using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074D RID: 1869
	[NetMessage(EMessageId.HonamiStoryAddWeaponNotify)]
	public sealed class HonamiStoryAddWeaponNotify : IMessage<HonamiStoryAddWeaponNotify>, IMessage, IEquatable<HonamiStoryAddWeaponNotify>, IDeepCloneable<HonamiStoryAddWeaponNotify>, IBufferMessage
	{
		// Token: 0x0600A9A7 RID: 43431 RVA: 0x0019902B File Offset: 0x0019722B
		[NullableContext(1)]
		public static HonamiStoryAddWeaponNotify Create()
		{
			return new HonamiStoryAddWeaponNotify();
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x0600A9A8 RID: 43432 RVA: 0x00199032 File Offset: 0x00197232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x0600A9A9 RID: 43433 RVA: 0x00199035 File Offset: 0x00197235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAddWeaponNotify.Descriptor;
			}
		}

		// Token: 0x0600A9AA RID: 43434 RVA: 0x0019903C File Offset: 0x0019723C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAddWeaponNotify()
		{
		}

		// Token: 0x0600A9AB RID: 43435 RVA: 0x0019904F File Offset: 0x0019724F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAddWeaponNotify(HonamiStoryAddWeaponNotify other) : this()
		{
			this.weaponIds_ = other.weaponIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9AC RID: 43436 RVA: 0x00199079 File Offset: 0x00197279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAddWeaponNotify Clone()
		{
			return new HonamiStoryAddWeaponNotify(this);
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x0600A9AD RID: 43437 RVA: 0x00199081 File Offset: 0x00197281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeaponIds
		{
			get
			{
				return this.weaponIds_;
			}
		}

		// Token: 0x0600A9AE RID: 43438 RVA: 0x00199089 File Offset: 0x00197289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAddWeaponNotify);
		}

		// Token: 0x0600A9AF RID: 43439 RVA: 0x00199097 File Offset: 0x00197297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAddWeaponNotify other)
		{
			return other != null && (other == this || (this.weaponIds_.Equals(other.weaponIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9B0 RID: 43440 RVA: 0x001990CC File Offset: 0x001972CC
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

		// Token: 0x0600A9B1 RID: 43441 RVA: 0x00199100 File Offset: 0x00197300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A9B2 RID: 43442 RVA: 0x0019910D File Offset: 0x0019730D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9B3 RID: 43443 RVA: 0x00199116 File Offset: 0x00197316
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

		// Token: 0x0600A9B4 RID: 43444 RVA: 0x00199140 File Offset: 0x00197340
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

		// Token: 0x0600A9B5 RID: 43445 RVA: 0x00199179 File Offset: 0x00197379
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

		// Token: 0x0600A9B6 RID: 43446 RVA: 0x001991A7 File Offset: 0x001973A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9B7 RID: 43447 RVA: 0x001991B0 File Offset: 0x001973B0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.weaponIds_.AddEntriesFrom(ref input, HonamiStoryAddWeaponNotify._repeated_weaponIds_codec);
				}
			}
		}

		// Token: 0x04004DB2 RID: 19890
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DB3 RID: 19891
		public const int WeaponIdsFieldNumber = 1;

		// Token: 0x04004DB4 RID: 19892
		private static readonly FieldCodec<int> _repeated_weaponIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04004DB5 RID: 19893
		private readonly RepeatedField<int> weaponIds_ = new RepeatedField<int>();
	}
}
