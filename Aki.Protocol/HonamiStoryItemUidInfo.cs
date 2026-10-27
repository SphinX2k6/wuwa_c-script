using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000783 RID: 1923
	public sealed class HonamiStoryItemUidInfo : IMessage<HonamiStoryItemUidInfo>, IMessage, IEquatable<HonamiStoryItemUidInfo>, IDeepCloneable<HonamiStoryItemUidInfo>, IBufferMessage
	{
		// Token: 0x0600ADC4 RID: 44484 RVA: 0x001A1C4B File Offset: 0x0019FE4B
		[NullableContext(1)]
		public static HonamiStoryItemUidInfo Create()
		{
			return new HonamiStoryItemUidInfo();
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x0600ADC5 RID: 44485 RVA: 0x001A1C52 File Offset: 0x0019FE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryItemUidInfo> Parser
		{
			get
			{
				return HonamiStoryItemUidInfo._parser;
			}
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x0600ADC6 RID: 44486 RVA: 0x001A1C59 File Offset: 0x0019FE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x0600ADC7 RID: 44487 RVA: 0x001A1C5C File Offset: 0x0019FE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemUidInfo.Descriptor;
			}
		}

		// Token: 0x0600ADC8 RID: 44488 RVA: 0x001A1C63 File Offset: 0x0019FE63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemUidInfo()
		{
		}

		// Token: 0x0600ADC9 RID: 44489 RVA: 0x001A1C76 File Offset: 0x0019FE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemUidInfo(HonamiStoryItemUidInfo other) : this()
		{
			this.itemUId_ = other.itemUId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADCA RID: 44490 RVA: 0x001A1CA0 File Offset: 0x0019FEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemUidInfo Clone()
		{
			return new HonamiStoryItemUidInfo(this);
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x0600ADCB RID: 44491 RVA: 0x001A1CA8 File Offset: 0x0019FEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemUId
		{
			get
			{
				return this.itemUId_;
			}
		}

		// Token: 0x0600ADCC RID: 44492 RVA: 0x001A1CB0 File Offset: 0x0019FEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemUidInfo);
		}

		// Token: 0x0600ADCD RID: 44493 RVA: 0x001A1CBE File Offset: 0x0019FEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemUidInfo other)
		{
			return other != null && (other == this || (this.itemUId_.Equals(other.itemUId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ADCE RID: 44494 RVA: 0x001A1CF4 File Offset: 0x0019FEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemUId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADCF RID: 44495 RVA: 0x001A1D28 File Offset: 0x0019FF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ADD0 RID: 44496 RVA: 0x001A1D35 File Offset: 0x0019FF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADD1 RID: 44497 RVA: 0x001A1D3E File Offset: 0x0019FF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemUId_.WriteTo(ref output, HonamiStoryItemUidInfo._repeated_itemUId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADD2 RID: 44498 RVA: 0x001A1D68 File Offset: 0x0019FF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemUId_.CalculateSize(HonamiStoryItemUidInfo._repeated_itemUId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADD3 RID: 44499 RVA: 0x001A1DA1 File Offset: 0x0019FFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryItemUidInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.itemUId_.Add(other.itemUId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ADD4 RID: 44500 RVA: 0x001A1DCF File Offset: 0x0019FFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADD5 RID: 44501 RVA: 0x001A1DD8 File Offset: 0x0019FFD8
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemUId_.AddEntriesFrom(ref input, HonamiStoryItemUidInfo._repeated_itemUId_codec);
				}
			}
		}

		// Token: 0x04004E8F RID: 20111
		private static readonly MessageParser<HonamiStoryItemUidInfo> _parser = new MessageParser<HonamiStoryItemUidInfo>(() => new HonamiStoryItemUidInfo());

		// Token: 0x04004E90 RID: 20112
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E91 RID: 20113
		public const int ItemUIdFieldNumber = 2;

		// Token: 0x04004E92 RID: 20114
		private static readonly FieldCodec<int> _repeated_itemUId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004E93 RID: 20115
		private readonly RepeatedField<int> itemUId_ = new RepeatedField<int>();
	}
}
