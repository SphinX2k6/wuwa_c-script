using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010E RID: 270
	[NetMessage(EMessageId.AreaTerminalInfoNotify)]
	public sealed class AreaTerminalInfoNotify : IMessage<AreaTerminalInfoNotify>, IMessage, IEquatable<AreaTerminalInfoNotify>, IDeepCloneable<AreaTerminalInfoNotify>, IBufferMessage
	{
		// Token: 0x06002565 RID: 9573 RVA: 0x00063D29 File Offset: 0x00061F29
		[NullableContext(1)]
		public static AreaTerminalInfoNotify Create()
		{
			return new AreaTerminalInfoNotify();
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x00063D30 File Offset: 0x00061F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x00063D33 File Offset: 0x00061F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaTerminalInfoNotify.Descriptor;
			}
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x00063D3A File Offset: 0x00061F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalInfoNotify()
		{
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00063D64 File Offset: 0x00061F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalInfoNotify(AreaTerminalInfoNotify other) : this()
		{
			this.pinIds_ = other.pinIds_.Clone();
			this.areaTerminalFuncConditionInfos_ = other.areaTerminalFuncConditionInfos_.Clone();
			this.areaMapGroup_ = other.areaMapGroup_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00063DBB File Offset: 0x00061FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalInfoNotify Clone()
		{
			return new AreaTerminalInfoNotify(this);
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x00063DC3 File Offset: 0x00061FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PinIds
		{
			get
			{
				return this.pinIds_;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x00063DCB File Offset: 0x00061FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AreaTerminalFuncConditionInfo> AreaTerminalFuncConditionInfos
		{
			get
			{
				return this.areaTerminalFuncConditionInfos_;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x00063DD3 File Offset: 0x00061FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AreaMapGroup
		{
			get
			{
				return this.areaMapGroup_;
			}
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00063DDB File Offset: 0x00061FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaTerminalInfoNotify);
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00063DEC File Offset: 0x00061FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaTerminalInfoNotify other)
		{
			return other != null && (other == this || (this.pinIds_.Equals(other.pinIds_) && this.areaTerminalFuncConditionInfos_.Equals(other.areaTerminalFuncConditionInfos_) && this.areaMapGroup_.Equals(other.areaMapGroup_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00063E54 File Offset: 0x00062054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pinIds_.GetHashCode();
			num ^= this.areaTerminalFuncConditionInfos_.GetHashCode();
			num ^= this.areaMapGroup_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00063EA4 File Offset: 0x000620A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00063EB1 File Offset: 0x000620B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00063EBC File Offset: 0x000620BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.areaTerminalFuncConditionInfos_.WriteTo(ref output, AreaTerminalInfoNotify._repeated_areaTerminalFuncConditionInfos_codec);
			this.areaMapGroup_.WriteTo(ref output, AreaTerminalInfoNotify._repeated_areaMapGroup_codec);
			this.pinIds_.WriteTo(ref output, AreaTerminalInfoNotify._repeated_pinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00063F10 File Offset: 0x00062110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pinIds_.CalculateSize(AreaTerminalInfoNotify._repeated_pinIds_codec);
			num += this.areaTerminalFuncConditionInfos_.CalculateSize(AreaTerminalInfoNotify._repeated_areaTerminalFuncConditionInfos_codec);
			num += this.areaMapGroup_.CalculateSize(AreaTerminalInfoNotify._repeated_areaMapGroup_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x00063F70 File Offset: 0x00062170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AreaTerminalInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.pinIds_.Add(other.pinIds_);
			this.areaTerminalFuncConditionInfos_.Add(other.areaTerminalFuncConditionInfos_);
			this.areaMapGroup_.Add(other.areaMapGroup_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00063FCB File Offset: 0x000621CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x00063FD4 File Offset: 0x000621D4
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
				if (num <= 40U)
				{
					if (num == 26U)
					{
						this.areaTerminalFuncConditionInfos_.AddEntriesFrom(ref input, AreaTerminalInfoNotify._repeated_areaTerminalFuncConditionInfos_codec);
						continue;
					}
					if (num == 40U)
					{
						goto IL_50;
					}
				}
				else
				{
					if (num == 42U)
					{
						goto IL_50;
					}
					if (num == 64U || num == 66U)
					{
						this.pinIds_.AddEntriesFrom(ref input, AreaTerminalInfoNotify._repeated_pinIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_50:
				this.areaMapGroup_.AddEntriesFrom(ref input, AreaTerminalInfoNotify._repeated_areaMapGroup_codec);
			}
		}

		// Token: 0x040025C6 RID: 9670
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025C7 RID: 9671
		public const int PinIdsFieldNumber = 8;

		// Token: 0x040025C8 RID: 9672
		private static readonly FieldCodec<int> _repeated_pinIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040025C9 RID: 9673
		private readonly RepeatedField<int> pinIds_ = new RepeatedField<int>();

		// Token: 0x040025CA RID: 9674
		public const int AreaTerminalFuncConditionInfosFieldNumber = 3;

		// Token: 0x040025CB RID: 9675
		private static readonly FieldCodec<AreaTerminalFuncConditionInfo> _repeated_areaTerminalFuncConditionInfos_codec = FieldCodec.ForMessage<AreaTerminalFuncConditionInfo>(26U, AreaTerminalFuncConditionInfo.Parser);

		// Token: 0x040025CC RID: 9676
		private readonly RepeatedField<AreaTerminalFuncConditionInfo> areaTerminalFuncConditionInfos_ = new RepeatedField<AreaTerminalFuncConditionInfo>();

		// Token: 0x040025CD RID: 9677
		public const int AreaMapGroupFieldNumber = 5;

		// Token: 0x040025CE RID: 9678
		private static readonly FieldCodec<int> _repeated_areaMapGroup_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040025CF RID: 9679
		private readonly RepeatedField<int> areaMapGroup_ = new RepeatedField<int>();
	}
}
