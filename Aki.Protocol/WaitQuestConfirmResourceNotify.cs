using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E7 RID: 5351
	[NetMessage(EMessageId.WaitQuestConfirmResourceNotify)]
	public sealed class WaitQuestConfirmResourceNotify : IMessage<WaitQuestConfirmResourceNotify>, IMessage, IEquatable<WaitQuestConfirmResourceNotify>, IDeepCloneable<WaitQuestConfirmResourceNotify>, IBufferMessage
	{
		// Token: 0x0601C4B1 RID: 115889 RVA: 0x00416AF9 File Offset: 0x00414CF9
		[NullableContext(1)]
		public static WaitQuestConfirmResourceNotify Create()
		{
			return new WaitQuestConfirmResourceNotify();
		}

		// Token: 0x17005F63 RID: 24419
		// (get) Token: 0x0601C4B2 RID: 115890 RVA: 0x00416B00 File Offset: 0x00414D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F64 RID: 24420
		// (get) Token: 0x0601C4B3 RID: 115891 RVA: 0x00416B03 File Offset: 0x00414D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WaitQuestConfirmResourceNotify.Descriptor;
			}
		}

		// Token: 0x0601C4B4 RID: 115892 RVA: 0x00416B0A File Offset: 0x00414D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaitQuestConfirmResourceNotify()
		{
		}

		// Token: 0x0601C4B5 RID: 115893 RVA: 0x00416B1D File Offset: 0x00414D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaitQuestConfirmResourceNotify(WaitQuestConfirmResourceNotify other) : this()
		{
			this.lackResourceQuestIds_ = other.lackResourceQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C4B6 RID: 115894 RVA: 0x00416B47 File Offset: 0x00414D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaitQuestConfirmResourceNotify Clone()
		{
			return new WaitQuestConfirmResourceNotify(this);
		}

		// Token: 0x17005F65 RID: 24421
		// (get) Token: 0x0601C4B7 RID: 115895 RVA: 0x00416B4F File Offset: 0x00414D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LackResourceQuestIds
		{
			get
			{
				return this.lackResourceQuestIds_;
			}
		}

		// Token: 0x0601C4B8 RID: 115896 RVA: 0x00416B57 File Offset: 0x00414D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WaitQuestConfirmResourceNotify);
		}

		// Token: 0x0601C4B9 RID: 115897 RVA: 0x00416B65 File Offset: 0x00414D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WaitQuestConfirmResourceNotify other)
		{
			return other != null && (other == this || (this.lackResourceQuestIds_.Equals(other.lackResourceQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C4BA RID: 115898 RVA: 0x00416B98 File Offset: 0x00414D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lackResourceQuestIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C4BB RID: 115899 RVA: 0x00416BCC File Offset: 0x00414DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C4BC RID: 115900 RVA: 0x00416BD9 File Offset: 0x00414DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C4BD RID: 115901 RVA: 0x00416BE2 File Offset: 0x00414DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lackResourceQuestIds_.WriteTo(ref output, WaitQuestConfirmResourceNotify._repeated_lackResourceQuestIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C4BE RID: 115902 RVA: 0x00416C0C File Offset: 0x00414E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lackResourceQuestIds_.CalculateSize(WaitQuestConfirmResourceNotify._repeated_lackResourceQuestIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C4BF RID: 115903 RVA: 0x00416C45 File Offset: 0x00414E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WaitQuestConfirmResourceNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.lackResourceQuestIds_.Add(other.lackResourceQuestIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C4C0 RID: 115904 RVA: 0x00416C73 File Offset: 0x00414E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C4C1 RID: 115905 RVA: 0x00416C7C File Offset: 0x00414E7C
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.lackResourceQuestIds_.AddEntriesFrom(ref input, WaitQuestConfirmResourceNotify._repeated_lackResourceQuestIds_codec);
				}
			}
		}

		// Token: 0x0400A227 RID: 41511
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A228 RID: 41512
		public const int LackResourceQuestIdsFieldNumber = 3;

		// Token: 0x0400A229 RID: 41513
		private static readonly FieldCodec<int> _repeated_lackResourceQuestIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400A22A RID: 41514
		private readonly RepeatedField<int> lackResourceQuestIds_ = new RepeatedField<int>();
	}
}
