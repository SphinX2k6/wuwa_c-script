using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000321 RID: 801
	public sealed class CrystalMonsterInfoPb : IMessage<CrystalMonsterInfoPb>, IMessage, IEquatable<CrystalMonsterInfoPb>, IDeepCloneable<CrystalMonsterInfoPb>, IBufferMessage
	{
		// Token: 0x060050E6 RID: 20710 RVA: 0x000C595F File Offset: 0x000C3B5F
		[NullableContext(1)]
		public static CrystalMonsterInfoPb Create()
		{
			return new CrystalMonsterInfoPb();
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x060050E7 RID: 20711 RVA: 0x000C5966 File Offset: 0x000C3B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CrystalMonsterInfoPb> Parser
		{
			get
			{
				return CrystalMonsterInfoPb._parser;
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x060050E8 RID: 20712 RVA: 0x000C596D File Offset: 0x000C3B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x060050E9 RID: 20713 RVA: 0x000C5970 File Offset: 0x000C3B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CrystalMonsterInfoPb.Descriptor;
			}
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x000C5977 File Offset: 0x000C3B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterInfoPb()
		{
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x000C598A File Offset: 0x000C3B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterInfoPb(CrystalMonsterInfoPb other) : this()
		{
			this.slotInfoList_ = other.slotInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x000C59B4 File Offset: 0x000C3BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterInfoPb Clone()
		{
			return new CrystalMonsterInfoPb(this);
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x060050ED RID: 20717 RVA: 0x000C59BC File Offset: 0x000C3BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CrystalMonsterSlotInfo> SlotInfoList
		{
			get
			{
				return this.slotInfoList_;
			}
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x000C59C4 File Offset: 0x000C3BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CrystalMonsterInfoPb);
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x000C59D2 File Offset: 0x000C3BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CrystalMonsterInfoPb other)
		{
			return other != null && (other == this || (this.slotInfoList_.Equals(other.slotInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x000C5A08 File Offset: 0x000C3C08
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

		// Token: 0x060050F1 RID: 20721 RVA: 0x000C5A3C File Offset: 0x000C3C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x000C5A49 File Offset: 0x000C3C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x000C5A52 File Offset: 0x000C3C52
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

		// Token: 0x060050F4 RID: 20724 RVA: 0x000C5A7C File Offset: 0x000C3C7C
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

		// Token: 0x060050F5 RID: 20725 RVA: 0x000C5AB5 File Offset: 0x000C3CB5
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

		// Token: 0x060050F6 RID: 20726 RVA: 0x000C5AE3 File Offset: 0x000C3CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x000C5AEC File Offset: 0x000C3CEC
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

		// Token: 0x040032DF RID: 13023
		private static readonly MessageParser<CrystalMonsterInfoPb> _parser = new MessageParser<CrystalMonsterInfoPb>(() => new CrystalMonsterInfoPb());

		// Token: 0x040032E0 RID: 13024
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032E1 RID: 13025
		public const int SlotInfoListFieldNumber = 1;

		// Token: 0x040032E2 RID: 13026
		private static readonly FieldCodec<CrystalMonsterSlotInfo> _repeated_slotInfoList_codec = FieldCodec.ForMessage<CrystalMonsterSlotInfo>(10U, CrystalMonsterSlotInfo.Parser);

		// Token: 0x040032E3 RID: 13027
		private readonly RepeatedField<CrystalMonsterSlotInfo> slotInfoList_ = new RepeatedField<CrystalMonsterSlotInfo>();
	}
}
