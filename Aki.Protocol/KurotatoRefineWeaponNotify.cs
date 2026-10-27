using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AF RID: 2223
	[NetMessage(EMessageId.KurotatoRefineWeaponNotify)]
	public sealed class KurotatoRefineWeaponNotify : IMessage<KurotatoRefineWeaponNotify>, IMessage, IEquatable<KurotatoRefineWeaponNotify>, IDeepCloneable<KurotatoRefineWeaponNotify>, IBufferMessage
	{
		// Token: 0x0600C555 RID: 50517 RVA: 0x001D379D File Offset: 0x001D199D
		[NullableContext(1)]
		public static KurotatoRefineWeaponNotify Create()
		{
			return new KurotatoRefineWeaponNotify();
		}

		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x0600C556 RID: 50518 RVA: 0x001D37A4 File Offset: 0x001D19A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x0600C557 RID: 50519 RVA: 0x001D37A7 File Offset: 0x001D19A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRefineWeaponNotify.Descriptor;
			}
		}

		// Token: 0x0600C558 RID: 50520 RVA: 0x001D37AE File Offset: 0x001D19AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponNotify()
		{
		}

		// Token: 0x0600C559 RID: 50521 RVA: 0x001D37C1 File Offset: 0x001D19C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponNotify(KurotatoRefineWeaponNotify other) : this()
		{
			this.refinedWeaponIncIds_ = other.refinedWeaponIncIds_.Clone();
			this.newWeaponIncId_ = other.newWeaponIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C55A RID: 50522 RVA: 0x001D37F7 File Offset: 0x001D19F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponNotify Clone()
		{
			return new KurotatoRefineWeaponNotify(this);
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x0600C55B RID: 50523 RVA: 0x001D37FF File Offset: 0x001D19FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RefinedWeaponIncIds
		{
			get
			{
				return this.refinedWeaponIncIds_;
			}
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x0600C55C RID: 50524 RVA: 0x001D3807 File Offset: 0x001D1A07
		// (set) Token: 0x0600C55D RID: 50525 RVA: 0x001D380F File Offset: 0x001D1A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewWeaponIncId
		{
			get
			{
				return this.newWeaponIncId_;
			}
			set
			{
				this.newWeaponIncId_ = value;
			}
		}

		// Token: 0x0600C55E RID: 50526 RVA: 0x001D3818 File Offset: 0x001D1A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRefineWeaponNotify);
		}

		// Token: 0x0600C55F RID: 50527 RVA: 0x001D3828 File Offset: 0x001D1A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRefineWeaponNotify other)
		{
			return other != null && (other == this || (this.refinedWeaponIncIds_.Equals(other.refinedWeaponIncIds_) && this.NewWeaponIncId == other.NewWeaponIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C560 RID: 50528 RVA: 0x001D3878 File Offset: 0x001D1A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.refinedWeaponIncIds_.GetHashCode();
			if (this.NewWeaponIncId != 0)
			{
				num ^= this.NewWeaponIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C561 RID: 50529 RVA: 0x001D38C5 File Offset: 0x001D1AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C562 RID: 50530 RVA: 0x001D38D2 File Offset: 0x001D1AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C563 RID: 50531 RVA: 0x001D38DC File Offset: 0x001D1ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.refinedWeaponIncIds_.WriteTo(ref output, KurotatoRefineWeaponNotify._repeated_refinedWeaponIncIds_codec);
			if (this.NewWeaponIncId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.NewWeaponIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C564 RID: 50532 RVA: 0x001D392C File Offset: 0x001D1B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.refinedWeaponIncIds_.CalculateSize(KurotatoRefineWeaponNotify._repeated_refinedWeaponIncIds_codec);
			if (this.NewWeaponIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewWeaponIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C565 RID: 50533 RVA: 0x001D3980 File Offset: 0x001D1B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoRefineWeaponNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.refinedWeaponIncIds_.Add(other.refinedWeaponIncIds_);
			if (other.NewWeaponIncId != 0)
			{
				this.NewWeaponIncId = other.NewWeaponIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C566 RID: 50534 RVA: 0x001D39CD File Offset: 0x001D1BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C567 RID: 50535 RVA: 0x001D39D8 File Offset: 0x001D1BD8
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
				if (num != 32U && num != 34U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NewWeaponIncId = input.ReadInt32();
					}
				}
				else
				{
					this.refinedWeaponIncIds_.AddEntriesFrom(ref input, KurotatoRefineWeaponNotify._repeated_refinedWeaponIncIds_codec);
				}
			}
		}

		// Token: 0x040054EF RID: 21743
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054F0 RID: 21744
		public const int RefinedWeaponIncIdsFieldNumber = 4;

		// Token: 0x040054F1 RID: 21745
		private static readonly FieldCodec<int> _repeated_refinedWeaponIncIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040054F2 RID: 21746
		private readonly RepeatedField<int> refinedWeaponIncIds_ = new RepeatedField<int>();

		// Token: 0x040054F3 RID: 21747
		public const int NewWeaponIncIdFieldNumber = 15;

		// Token: 0x040054F4 RID: 21748
		private int newWeaponIncId_;
	}
}
