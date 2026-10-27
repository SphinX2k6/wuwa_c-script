using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000034 RID: 52
	[NetMessage(EMessageId.AbyssPluginItemRemoveNotify)]
	public sealed class AbyssPluginItemRemoveNotify : IMessage<AbyssPluginItemRemoveNotify>, IMessage, IEquatable<AbyssPluginItemRemoveNotify>, IDeepCloneable<AbyssPluginItemRemoveNotify>, IBufferMessage
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x0003333D File Offset: 0x0003153D
		[NullableContext(1)]
		public static AbyssPluginItemRemoveNotify Create()
		{
			return new AbyssPluginItemRemoveNotify();
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00033344 File Offset: 0x00031544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00033347 File Offset: 0x00031547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginItemRemoveNotify.Descriptor;
			}
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0003334E File Offset: 0x0003154E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemRemoveNotify()
		{
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00033361 File Offset: 0x00031561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemRemoveNotify(AbyssPluginItemRemoveNotify other) : this()
		{
			this.incrIds_ = other.incrIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0003338B File Offset: 0x0003158B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginItemRemoveNotify Clone()
		{
			return new AbyssPluginItemRemoveNotify(this);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00033393 File Offset: 0x00031593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncrIds
		{
			get
			{
				return this.incrIds_;
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0003339B File Offset: 0x0003159B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginItemRemoveNotify);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000333A9 File Offset: 0x000315A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginItemRemoveNotify other)
		{
			return other != null && (other == this || (this.incrIds_.Equals(other.incrIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000333DC File Offset: 0x000315DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.incrIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00033410 File Offset: 0x00031610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0003341D File Offset: 0x0003161D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00033426 File Offset: 0x00031626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.incrIds_.WriteTo(ref output, AbyssPluginItemRemoveNotify._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00033450 File Offset: 0x00031650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.incrIds_.CalculateSize(AbyssPluginItemRemoveNotify._repeated_incrIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00033489 File Offset: 0x00031689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssPluginItemRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.incrIds_.Add(other.incrIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000334B7 File Offset: 0x000316B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000334C0 File Offset: 0x000316C0
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.incrIds_.AddEntriesFrom(ref input, AbyssPluginItemRemoveNotify._repeated_incrIds_codec);
				}
			}
		}

		// Token: 0x04001FDC RID: 8156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FDD RID: 8157
		public const int IncrIdsFieldNumber = 13;

		// Token: 0x04001FDE RID: 8158
		private static readonly FieldCodec<int> _repeated_incrIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04001FDF RID: 8159
		private readonly RepeatedField<int> incrIds_ = new RepeatedField<int>();
	}
}
