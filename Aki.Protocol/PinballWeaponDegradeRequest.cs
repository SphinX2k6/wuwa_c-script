using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6C RID: 3436
	[NetMessage(EMessageId.PinballWeaponDegradeRequest)]
	public sealed class PinballWeaponDegradeRequest : IMessage<PinballWeaponDegradeRequest>, IMessage, IEquatable<PinballWeaponDegradeRequest>, IDeepCloneable<PinballWeaponDegradeRequest>, IBufferMessage
	{
		// Token: 0x0601286E RID: 75886 RVA: 0x002B3F46 File Offset: 0x002B2146
		[NullableContext(1)]
		public static PinballWeaponDegradeRequest Create()
		{
			return new PinballWeaponDegradeRequest();
		}

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x0601286F RID: 75887 RVA: 0x002B3F4D File Offset: 0x002B214D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x06012870 RID: 75888 RVA: 0x002B3F50 File Offset: 0x002B2150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeaponDegradeRequest.Descriptor;
			}
		}

		// Token: 0x06012871 RID: 75889 RVA: 0x002B3F57 File Offset: 0x002B2157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeRequest()
		{
		}

		// Token: 0x06012872 RID: 75890 RVA: 0x002B3F6A File Offset: 0x002B216A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeRequest(PinballWeaponDegradeRequest other) : this()
		{
			this.weaponIncIds_ = other.weaponIncIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012873 RID: 75891 RVA: 0x002B3F94 File Offset: 0x002B2194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponDegradeRequest Clone()
		{
			return new PinballWeaponDegradeRequest(this);
		}

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x06012874 RID: 75892 RVA: 0x002B3F9C File Offset: 0x002B219C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeaponIncIds
		{
			get
			{
				return this.weaponIncIds_;
			}
		}

		// Token: 0x06012875 RID: 75893 RVA: 0x002B3FA4 File Offset: 0x002B21A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeaponDegradeRequest);
		}

		// Token: 0x06012876 RID: 75894 RVA: 0x002B3FB2 File Offset: 0x002B21B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeaponDegradeRequest other)
		{
			return other != null && (other == this || (this.weaponIncIds_.Equals(other.weaponIncIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012877 RID: 75895 RVA: 0x002B3FE8 File Offset: 0x002B21E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.weaponIncIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012878 RID: 75896 RVA: 0x002B401C File Offset: 0x002B221C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012879 RID: 75897 RVA: 0x002B4029 File Offset: 0x002B2229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601287A RID: 75898 RVA: 0x002B4032 File Offset: 0x002B2232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weaponIncIds_.WriteTo(ref output, PinballWeaponDegradeRequest._repeated_weaponIncIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601287B RID: 75899 RVA: 0x002B405C File Offset: 0x002B225C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.weaponIncIds_.CalculateSize(PinballWeaponDegradeRequest._repeated_weaponIncIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601287C RID: 75900 RVA: 0x002B4095 File Offset: 0x002B2295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballWeaponDegradeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.weaponIncIds_.Add(other.weaponIncIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601287D RID: 75901 RVA: 0x002B40C3 File Offset: 0x002B22C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601287E RID: 75902 RVA: 0x002B40CC File Offset: 0x002B22CC
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.weaponIncIds_.AddEntriesFrom(ref input, PinballWeaponDegradeRequest._repeated_weaponIncIds_codec);
				}
			}
		}

		// Token: 0x0400731F RID: 29471
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007320 RID: 29472
		public const int WeaponIncIdsFieldNumber = 11;

		// Token: 0x04007321 RID: 29473
		private static readonly FieldCodec<int> _repeated_weaponIncIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04007322 RID: 29474
		private readonly RepeatedField<int> weaponIncIds_ = new RepeatedField<int>();
	}
}
