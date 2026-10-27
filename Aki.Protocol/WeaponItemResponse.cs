using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F2 RID: 5362
	[NetMessage(EMessageId.WeaponItemResponse)]
	public sealed class WeaponItemResponse : IMessage<WeaponItemResponse>, IMessage, IEquatable<WeaponItemResponse>, IDeepCloneable<WeaponItemResponse>, IBufferMessage
	{
		// Token: 0x0601C597 RID: 116119 RVA: 0x0041893E File Offset: 0x00416B3E
		[NullableContext(1)]
		public static WeaponItemResponse Create()
		{
			return new WeaponItemResponse();
		}

		// Token: 0x17005F94 RID: 24468
		// (get) Token: 0x0601C598 RID: 116120 RVA: 0x00418945 File Offset: 0x00416B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F95 RID: 24469
		// (get) Token: 0x0601C599 RID: 116121 RVA: 0x00418948 File Offset: 0x00416B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponItemResponse.Descriptor;
			}
		}

		// Token: 0x0601C59A RID: 116122 RVA: 0x0041894F File Offset: 0x00416B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemResponse()
		{
		}

		// Token: 0x0601C59B RID: 116123 RVA: 0x00418962 File Offset: 0x00416B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemResponse(WeaponItemResponse other) : this()
		{
			this.weaponItemList_ = other.weaponItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C59C RID: 116124 RVA: 0x0041898C File Offset: 0x00416B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemResponse Clone()
		{
			return new WeaponItemResponse(this);
		}

		// Token: 0x17005F96 RID: 24470
		// (get) Token: 0x0601C59D RID: 116125 RVA: 0x00418994 File Offset: 0x00416B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeaponItem> WeaponItemList
		{
			get
			{
				return this.weaponItemList_;
			}
		}

		// Token: 0x0601C59E RID: 116126 RVA: 0x0041899C File Offset: 0x00416B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponItemResponse);
		}

		// Token: 0x0601C59F RID: 116127 RVA: 0x004189AA File Offset: 0x00416BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponItemResponse other)
		{
			return other != null && (other == this || (this.weaponItemList_.Equals(other.weaponItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C5A0 RID: 116128 RVA: 0x004189E0 File Offset: 0x00416BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.weaponItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C5A1 RID: 116129 RVA: 0x00418A14 File Offset: 0x00416C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C5A2 RID: 116130 RVA: 0x00418A21 File Offset: 0x00416C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C5A3 RID: 116131 RVA: 0x00418A2A File Offset: 0x00416C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weaponItemList_.WriteTo(ref output, WeaponItemResponse._repeated_weaponItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C5A4 RID: 116132 RVA: 0x00418A54 File Offset: 0x00416C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.weaponItemList_.CalculateSize(WeaponItemResponse._repeated_weaponItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C5A5 RID: 116133 RVA: 0x00418A8D File Offset: 0x00416C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.weaponItemList_.Add(other.weaponItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C5A6 RID: 116134 RVA: 0x00418ABB File Offset: 0x00416CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C5A7 RID: 116135 RVA: 0x00418AC4 File Offset: 0x00416CC4
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.weaponItemList_.AddEntriesFrom(ref input, WeaponItemResponse._repeated_weaponItemList_codec);
				}
			}
		}

		// Token: 0x0400A269 RID: 41577
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A26A RID: 41578
		public const int WeaponItemListFieldNumber = 6;

		// Token: 0x0400A26B RID: 41579
		private static readonly FieldCodec<WeaponItem> _repeated_weaponItemList_codec = FieldCodec.ForMessage<WeaponItem>(50U, WeaponItem.Parser);

		// Token: 0x0400A26C RID: 41580
		private readonly RepeatedField<WeaponItem> weaponItemList_ = new RepeatedField<WeaponItem>();
	}
}
