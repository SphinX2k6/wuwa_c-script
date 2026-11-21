using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000110 RID: 272
	[NetMessage(EMessageId.AreaTerminalInfoNotify)]
	public sealed class AreaTerminalInfoNotify : IMessage<AreaTerminalInfoNotify>, IMessage, IEquatable<AreaTerminalInfoNotify>, IDeepCloneable<AreaTerminalInfoNotify>, IBufferMessage
	{
		// Token: 0x060025C4 RID: 9668 RVA: 0x00064D4D File Offset: 0x00062F4D
		[NullableContext(1)]
		public static AreaTerminalInfoNotify Create()
		{
			return new AreaTerminalInfoNotify();
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x00064D54 File Offset: 0x00062F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060025C6 RID: 9670 RVA: 0x00064D57 File Offset: 0x00062F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaTerminalInfoNotify.Descriptor;
			}
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00064D5E File Offset: 0x00062F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalInfoNotify()
		{
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00064D88 File Offset: 0x00062F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalInfoNotify(AreaTerminalInfoNotify other) : this()
		{
			this.pinIds_ = other.pinIds_.Clone();
			this.areaTerminalFuncConditionInfos_ = other.areaTerminalFuncConditionInfos_.Clone();
			this.areaMapGroup_ = other.areaMapGroup_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00064DDF File Offset: 0x00062FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalInfoNotify Clone()
		{
			return new AreaTerminalInfoNotify(this);
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x00064DE7 File Offset: 0x00062FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PinIds
		{
			get
			{
				return this.pinIds_;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060025CB RID: 9675 RVA: 0x00064DEF File Offset: 0x00062FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AreaTerminalFuncConditionInfo> AreaTerminalFuncConditionInfos
		{
			get
			{
				return this.areaTerminalFuncConditionInfos_;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x00064DF7 File Offset: 0x00062FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AreaMapGroup
		{
			get
			{
				return this.areaMapGroup_;
			}
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00064DFF File Offset: 0x00062FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaTerminalInfoNotify);
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00064E10 File Offset: 0x00063010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaTerminalInfoNotify other)
		{
			return other != null && (other == this || (this.pinIds_.Equals(other.pinIds_) && this.areaTerminalFuncConditionInfos_.Equals(other.areaTerminalFuncConditionInfos_) && this.areaMapGroup_.Equals(other.areaMapGroup_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x00064E78 File Offset: 0x00063078
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

		// Token: 0x060025D0 RID: 9680 RVA: 0x00064EC8 File Offset: 0x000630C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00064ED5 File Offset: 0x000630D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00064EE0 File Offset: 0x000630E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.areaTerminalFuncConditionInfos_.WriteTo(ref output, AreaTerminalInfoNotify._repeated_areaTerminalFuncConditionInfos_codec);
			this.pinIds_.WriteTo(ref output, AreaTerminalInfoNotify._repeated_pinIds_codec);
			this.areaMapGroup_.WriteTo(ref output, AreaTerminalInfoNotify._repeated_areaMapGroup_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00064F34 File Offset: 0x00063134
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

		// Token: 0x060025D4 RID: 9684 RVA: 0x00064F94 File Offset: 0x00063194
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

		// Token: 0x060025D5 RID: 9685 RVA: 0x00064FEF File Offset: 0x000631EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00064FF8 File Offset: 0x000631F8
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
				if (num <= 88U)
				{
					if (num == 58U)
					{
						this.areaTerminalFuncConditionInfos_.AddEntriesFrom(ref input, AreaTerminalInfoNotify._repeated_areaTerminalFuncConditionInfos_codec);
						continue;
					}
					if (num == 88U)
					{
						goto IL_50;
					}
				}
				else
				{
					if (num == 90U)
					{
						goto IL_50;
					}
					if (num == 120U || num == 122U)
					{
						this.areaMapGroup_.AddEntriesFrom(ref input, AreaTerminalInfoNotify._repeated_areaMapGroup_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_50:
				this.pinIds_.AddEntriesFrom(ref input, AreaTerminalInfoNotify._repeated_pinIds_codec);
			}
		}

		// Token: 0x04002631 RID: 9777
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002632 RID: 9778
		public const int PinIdsFieldNumber = 11;

		// Token: 0x04002633 RID: 9779
		private static readonly FieldCodec<int> _repeated_pinIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04002634 RID: 9780
		private readonly RepeatedField<int> pinIds_ = new RepeatedField<int>();

		// Token: 0x04002635 RID: 9781
		public const int AreaTerminalFuncConditionInfosFieldNumber = 7;

		// Token: 0x04002636 RID: 9782
		private static readonly FieldCodec<AreaTerminalFuncConditionInfo> _repeated_areaTerminalFuncConditionInfos_codec = FieldCodec.ForMessage<AreaTerminalFuncConditionInfo>(58U, AreaTerminalFuncConditionInfo.Parser);

		// Token: 0x04002637 RID: 9783
		private readonly RepeatedField<AreaTerminalFuncConditionInfo> areaTerminalFuncConditionInfos_ = new RepeatedField<AreaTerminalFuncConditionInfo>();

		// Token: 0x04002638 RID: 9784
		public const int AreaMapGroupFieldNumber = 15;

		// Token: 0x04002639 RID: 9785
		private static readonly FieldCodec<int> _repeated_areaMapGroup_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400263A RID: 9786
		private readonly RepeatedField<int> areaMapGroup_ = new RepeatedField<int>();
	}
}
