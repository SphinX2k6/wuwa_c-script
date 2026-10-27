using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6E RID: 3438
	public sealed class PinballWeapons : IMessage<PinballWeapons>, IMessage, IEquatable<PinballWeapons>, IDeepCloneable<PinballWeapons>, IBufferMessage
	{
		// Token: 0x06012892 RID: 75922 RVA: 0x002B4309 File Offset: 0x002B2509
		[NullableContext(1)]
		public static PinballWeapons Create()
		{
			return new PinballWeapons();
		}

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x06012893 RID: 75923 RVA: 0x002B4310 File Offset: 0x002B2510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x06012894 RID: 75924 RVA: 0x002B4313 File Offset: 0x002B2513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeapons.Descriptor;
			}
		}

		// Token: 0x06012895 RID: 75925 RVA: 0x002B431A File Offset: 0x002B251A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapons()
		{
		}

		// Token: 0x06012896 RID: 75926 RVA: 0x002B432D File Offset: 0x002B252D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapons(PinballWeapons other) : this()
		{
			this.pinballWeaponList_ = other.pinballWeaponList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012897 RID: 75927 RVA: 0x002B4357 File Offset: 0x002B2557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapons Clone()
		{
			return new PinballWeapons(this);
		}

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x06012898 RID: 75928 RVA: 0x002B435F File Offset: 0x002B255F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballWeapon> PinballWeaponList
		{
			get
			{
				return this.pinballWeaponList_;
			}
		}

		// Token: 0x06012899 RID: 75929 RVA: 0x002B4367 File Offset: 0x002B2567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeapons);
		}

		// Token: 0x0601289A RID: 75930 RVA: 0x002B4375 File Offset: 0x002B2575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeapons other)
		{
			return other != null && (other == this || (this.pinballWeaponList_.Equals(other.pinballWeaponList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601289B RID: 75931 RVA: 0x002B43A8 File Offset: 0x002B25A8
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

		// Token: 0x0601289C RID: 75932 RVA: 0x002B43DC File Offset: 0x002B25DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601289D RID: 75933 RVA: 0x002B43E9 File Offset: 0x002B25E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601289E RID: 75934 RVA: 0x002B43F2 File Offset: 0x002B25F2
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

		// Token: 0x0601289F RID: 75935 RVA: 0x002B441C File Offset: 0x002B261C
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

		// Token: 0x060128A0 RID: 75936 RVA: 0x002B4455 File Offset: 0x002B2655
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

		// Token: 0x060128A1 RID: 75937 RVA: 0x002B4483 File Offset: 0x002B2683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060128A2 RID: 75938 RVA: 0x002B448C File Offset: 0x002B268C
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

		// Token: 0x04007326 RID: 29478
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007327 RID: 29479
		public const int PinballWeaponListFieldNumber = 1;

		// Token: 0x04007328 RID: 29480
		private static readonly FieldCodec<PinballWeapon> _repeated_pinballWeaponList_codec = FieldCodec.ForMessage<PinballWeapon>(10U, PinballWeapon.Parser);

		// Token: 0x04007329 RID: 29481
		private readonly RepeatedField<PinballWeapon> pinballWeaponList_ = new RepeatedField<PinballWeapon>();
	}
}
