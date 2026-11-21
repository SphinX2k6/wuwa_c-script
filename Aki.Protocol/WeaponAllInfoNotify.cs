using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200155F RID: 5471
	[NetMessage(EMessageId.WeaponAllInfoNotify)]
	public sealed class WeaponAllInfoNotify : IMessage<WeaponAllInfoNotify>, IMessage, IEquatable<WeaponAllInfoNotify>, IDeepCloneable<WeaponAllInfoNotify>, IBufferMessage
	{
		// Token: 0x0601CF9C RID: 118684 RVA: 0x004329BC File Offset: 0x00430BBC
		[NullableContext(1)]
		public static WeaponAllInfoNotify Create()
		{
			return new WeaponAllInfoNotify();
		}

		// Token: 0x1700620A RID: 25098
		// (get) Token: 0x0601CF9D RID: 118685 RVA: 0x004329C3 File Offset: 0x00430BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700620B RID: 25099
		// (get) Token: 0x0601CF9E RID: 118686 RVA: 0x004329C6 File Offset: 0x00430BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponAllInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601CF9F RID: 118687 RVA: 0x004329CD File Offset: 0x00430BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAllInfoNotify()
		{
		}

		// Token: 0x0601CFA0 RID: 118688 RVA: 0x004329E0 File Offset: 0x00430BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAllInfoNotify(WeaponAllInfoNotify other) : this()
		{
			this.allWeapon_ = other.allWeapon_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CFA1 RID: 118689 RVA: 0x00432A0A File Offset: 0x00430C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAllInfoNotify Clone()
		{
			return new WeaponAllInfoNotify(this);
		}

		// Token: 0x1700620C RID: 25100
		// (get) Token: 0x0601CFA2 RID: 118690 RVA: 0x00432A12 File Offset: 0x00430C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneWeaponItemInfo> AllWeapon
		{
			get
			{
				return this.allWeapon_;
			}
		}

		// Token: 0x0601CFA3 RID: 118691 RVA: 0x00432A1A File Offset: 0x00430C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponAllInfoNotify);
		}

		// Token: 0x0601CFA4 RID: 118692 RVA: 0x00432A28 File Offset: 0x00430C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponAllInfoNotify other)
		{
			return other != null && (other == this || (this.allWeapon_.Equals(other.allWeapon_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CFA5 RID: 118693 RVA: 0x00432A5C File Offset: 0x00430C5C
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

		// Token: 0x0601CFA6 RID: 118694 RVA: 0x00432A90 File Offset: 0x00430C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CFA7 RID: 118695 RVA: 0x00432A9D File Offset: 0x00430C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CFA8 RID: 118696 RVA: 0x00432AA6 File Offset: 0x00430CA6
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

		// Token: 0x0601CFA9 RID: 118697 RVA: 0x00432AD0 File Offset: 0x00430CD0
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

		// Token: 0x0601CFAA RID: 118698 RVA: 0x00432B09 File Offset: 0x00430D09
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

		// Token: 0x0601CFAB RID: 118699 RVA: 0x00432B37 File Offset: 0x00430D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CFAC RID: 118700 RVA: 0x00432B40 File Offset: 0x00430D40
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
					this.allWeapon_.AddEntriesFrom(ref input, WeaponAllInfoNotify._repeated_allWeapon_codec);
				}
			}
		}

		// Token: 0x0400A687 RID: 42631
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A688 RID: 42632
		public const int AllWeaponFieldNumber = 1;

		// Token: 0x0400A689 RID: 42633
		private static readonly FieldCodec<OneWeaponItemInfo> _repeated_allWeapon_codec = FieldCodec.ForMessage<OneWeaponItemInfo>(10U, OneWeaponItemInfo.Parser);

		// Token: 0x0400A68A RID: 42634
		private readonly RepeatedField<OneWeaponItemInfo> allWeapon_ = new RepeatedField<OneWeaponItemInfo>();
	}
}
