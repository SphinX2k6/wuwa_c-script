using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5E RID: 3422
	public sealed class PinballWeapons : IMessage<PinballWeapons>, IMessage, IEquatable<PinballWeapons>, IDeepCloneable<PinballWeapons>, IBufferMessage
	{
		// Token: 0x06012796 RID: 75670 RVA: 0x002B26F1 File Offset: 0x002B08F1
		[NullableContext(1)]
		public static PinballWeapons Create()
		{
			return new PinballWeapons();
		}

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x06012797 RID: 75671 RVA: 0x002B26F8 File Offset: 0x002B08F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x06012798 RID: 75672 RVA: 0x002B26FB File Offset: 0x002B08FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeapons.Descriptor;
			}
		}

		// Token: 0x06012799 RID: 75673 RVA: 0x002B2702 File Offset: 0x002B0902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapons()
		{
		}

		// Token: 0x0601279A RID: 75674 RVA: 0x002B2715 File Offset: 0x002B0915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapons(PinballWeapons other) : this()
		{
			this.pinballWeaponList_ = other.pinballWeaponList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601279B RID: 75675 RVA: 0x002B273F File Offset: 0x002B093F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapons Clone()
		{
			return new PinballWeapons(this);
		}

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x0601279C RID: 75676 RVA: 0x002B2747 File Offset: 0x002B0947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballWeapon> PinballWeaponList
		{
			get
			{
				return this.pinballWeaponList_;
			}
		}

		// Token: 0x0601279D RID: 75677 RVA: 0x002B274F File Offset: 0x002B094F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeapons);
		}

		// Token: 0x0601279E RID: 75678 RVA: 0x002B275D File Offset: 0x002B095D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeapons other)
		{
			return other != null && (other == this || (this.pinballWeaponList_.Equals(other.pinballWeaponList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601279F RID: 75679 RVA: 0x002B2790 File Offset: 0x002B0990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pinballWeaponList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060127A0 RID: 75680 RVA: 0x002B27C4 File Offset: 0x002B09C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060127A1 RID: 75681 RVA: 0x002B27D1 File Offset: 0x002B09D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060127A2 RID: 75682 RVA: 0x002B27DA File Offset: 0x002B09DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pinballWeaponList_.WriteTo(ref output, PinballWeapons._repeated_pinballWeaponList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060127A3 RID: 75683 RVA: 0x002B2804 File Offset: 0x002B0A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pinballWeaponList_.CalculateSize(PinballWeapons._repeated_pinballWeaponList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060127A4 RID: 75684 RVA: 0x002B283D File Offset: 0x002B0A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballWeapons other)
		{
			if (other == null)
			{
				return;
			}
			this.pinballWeaponList_.Add(other.pinballWeaponList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060127A5 RID: 75685 RVA: 0x002B286B File Offset: 0x002B0A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060127A6 RID: 75686 RVA: 0x002B2874 File Offset: 0x002B0A74
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.pinballWeaponList_.AddEntriesFrom(ref input, PinballWeapons._repeated_pinballWeaponList_codec);
				}
			}
		}

		// Token: 0x0400733E RID: 29502
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400733F RID: 29503
		public const int PinballWeaponListFieldNumber = 1;

		// Token: 0x04007340 RID: 29504
		private static readonly FieldCodec<PinballWeapon> _repeated_pinballWeaponList_codec = FieldCodec.ForMessage<PinballWeapon>(10U, PinballWeapon.Parser);

		// Token: 0x04007341 RID: 29505
		private readonly RepeatedField<PinballWeapon> pinballWeaponList_ = new RepeatedField<PinballWeapon>();
	}
}
