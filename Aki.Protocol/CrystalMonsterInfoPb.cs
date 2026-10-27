using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031A RID: 794
	public sealed class CrystalMonsterInfoPb : IMessage<CrystalMonsterInfoPb>, IMessage, IEquatable<CrystalMonsterInfoPb>, IDeepCloneable<CrystalMonsterInfoPb>, IBufferMessage
	{
		// Token: 0x0600500D RID: 20493 RVA: 0x000C3570 File Offset: 0x000C1770
		[NullableContext(1)]
		public static CrystalMonsterInfoPb Create()
		{
			return new CrystalMonsterInfoPb();
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x0600500E RID: 20494 RVA: 0x000C3577 File Offset: 0x000C1777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CrystalMonsterInfoPb> Parser
		{
			get
			{
				return CrystalMonsterInfoPb._parser;
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x0600500F RID: 20495 RVA: 0x000C357E File Offset: 0x000C177E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06005010 RID: 20496 RVA: 0x000C3581 File Offset: 0x000C1781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CrystalMonsterInfoPb.Descriptor;
			}
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x000C3588 File Offset: 0x000C1788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterInfoPb()
		{
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x000C359B File Offset: 0x000C179B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterInfoPb(CrystalMonsterInfoPb other) : this()
		{
			this.slotInfoList_ = other.slotInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x000C35C5 File Offset: 0x000C17C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterInfoPb Clone()
		{
			return new CrystalMonsterInfoPb(this);
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06005014 RID: 20500 RVA: 0x000C35CD File Offset: 0x000C17CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CrystalMonsterSlotInfo> SlotInfoList
		{
			get
			{
				return this.slotInfoList_;
			}
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x000C35D5 File Offset: 0x000C17D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CrystalMonsterInfoPb);
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x000C35E3 File Offset: 0x000C17E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CrystalMonsterInfoPb other)
		{
			return other != null && (other == this || (this.slotInfoList_.Equals(other.slotInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x000C3618 File Offset: 0x000C1818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.slotInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x000C364C File Offset: 0x000C184C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x000C3659 File Offset: 0x000C1859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x000C3662 File Offset: 0x000C1862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slotInfoList_.WriteTo(ref output, CrystalMonsterInfoPb._repeated_slotInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x000C368C File Offset: 0x000C188C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.slotInfoList_.CalculateSize(CrystalMonsterInfoPb._repeated_slotInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x000C36C5 File Offset: 0x000C18C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CrystalMonsterInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			this.slotInfoList_.Add(other.slotInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x000C36F3 File Offset: 0x000C18F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x000C36FC File Offset: 0x000C18FC
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
					this.slotInfoList_.AddEntriesFrom(ref input, CrystalMonsterInfoPb._repeated_slotInfoList_codec);
				}
			}
		}

		// Token: 0x04003248 RID: 12872
		private static readonly MessageParser<CrystalMonsterInfoPb> _parser = new MessageParser<CrystalMonsterInfoPb>(() => new CrystalMonsterInfoPb());

		// Token: 0x04003249 RID: 12873
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400324A RID: 12874
		public const int SlotInfoListFieldNumber = 1;

		// Token: 0x0400324B RID: 12875
		private static readonly FieldCodec<CrystalMonsterSlotInfo> _repeated_slotInfoList_codec = FieldCodec.ForMessage<CrystalMonsterSlotInfo>(10U, CrystalMonsterSlotInfo.Parser);

		// Token: 0x0400324C RID: 12876
		private readonly RepeatedField<CrystalMonsterSlotInfo> slotInfoList_ = new RepeatedField<CrystalMonsterSlotInfo>();
	}
}
