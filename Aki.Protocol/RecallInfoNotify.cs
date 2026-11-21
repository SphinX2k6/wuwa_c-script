using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E99 RID: 3737
	[NetMessage(EMessageId.RecallInfoNotify)]
	public sealed class RecallInfoNotify : IMessage<RecallInfoNotify>, IMessage, IEquatable<RecallInfoNotify>, IDeepCloneable<RecallInfoNotify>, IBufferMessage
	{
		// Token: 0x0601415D RID: 82269 RVA: 0x002ECDAE File Offset: 0x002EAFAE
		[NullableContext(1)]
		public static RecallInfoNotify Create()
		{
			return new RecallInfoNotify();
		}

		// Token: 0x170042D3 RID: 17107
		// (get) Token: 0x0601415E RID: 82270 RVA: 0x002ECDB5 File Offset: 0x002EAFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042D4 RID: 17108
		// (get) Token: 0x0601415F RID: 82271 RVA: 0x002ECDB8 File Offset: 0x002EAFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallInfoNotify.Descriptor;
			}
		}

		// Token: 0x06014160 RID: 82272 RVA: 0x002ECDBF File Offset: 0x002EAFBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfoNotify()
		{
		}

		// Token: 0x06014161 RID: 82273 RVA: 0x002ECDDD File Offset: 0x002EAFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfoNotify(RecallInfoNotify other) : this()
		{
			this.recallInfos_ = other.recallInfos_.Clone();
			this.recallIds_ = other.recallIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014162 RID: 82274 RVA: 0x002ECE18 File Offset: 0x002EB018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfoNotify Clone()
		{
			return new RecallInfoNotify(this);
		}

		// Token: 0x170042D5 RID: 17109
		// (get) Token: 0x06014163 RID: 82275 RVA: 0x002ECE20 File Offset: 0x002EB020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecallInfo> RecallInfos
		{
			get
			{
				return this.recallInfos_;
			}
		}

		// Token: 0x170042D6 RID: 17110
		// (get) Token: 0x06014164 RID: 82276 RVA: 0x002ECE28 File Offset: 0x002EB028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RecallIds
		{
			get
			{
				return this.recallIds_;
			}
		}

		// Token: 0x06014165 RID: 82277 RVA: 0x002ECE30 File Offset: 0x002EB030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallInfoNotify);
		}

		// Token: 0x06014166 RID: 82278 RVA: 0x002ECE40 File Offset: 0x002EB040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallInfoNotify other)
		{
			return other != null && (other == this || (this.recallInfos_.Equals(other.recallInfos_) && this.recallIds_.Equals(other.recallIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014167 RID: 82279 RVA: 0x002ECE94 File Offset: 0x002EB094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.recallInfos_.GetHashCode();
			num ^= this.recallIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014168 RID: 82280 RVA: 0x002ECED6 File Offset: 0x002EB0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014169 RID: 82281 RVA: 0x002ECEE3 File Offset: 0x002EB0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601416A RID: 82282 RVA: 0x002ECEEC File Offset: 0x002EB0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recallIds_.WriteTo(ref output, RecallInfoNotify._repeated_recallIds_codec);
			this.recallInfos_.WriteTo(ref output, RecallInfoNotify._repeated_recallInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601416B RID: 82283 RVA: 0x002ECF24 File Offset: 0x002EB124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.recallInfos_.CalculateSize(RecallInfoNotify._repeated_recallInfos_codec);
			num += this.recallIds_.CalculateSize(RecallInfoNotify._repeated_recallIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601416C RID: 82284 RVA: 0x002ECF70 File Offset: 0x002EB170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.recallInfos_.Add(other.recallInfos_);
			this.recallIds_.Add(other.recallIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601416D RID: 82285 RVA: 0x002ECFAF File Offset: 0x002EB1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601416E RID: 82286 RVA: 0x002ECFB8 File Offset: 0x002EB1B8
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
				if (num != 56U && num != 58U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.recallInfos_.AddEntriesFrom(ref input, RecallInfoNotify._repeated_recallInfos_codec);
					}
				}
				else
				{
					this.recallIds_.AddEntriesFrom(ref input, RecallInfoNotify._repeated_recallIds_codec);
				}
			}
		}

		// Token: 0x04007AD9 RID: 31449
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007ADA RID: 31450
		public const int RecallInfosFieldNumber = 11;

		// Token: 0x04007ADB RID: 31451
		private static readonly FieldCodec<RecallInfo> _repeated_recallInfos_codec = FieldCodec.ForMessage<RecallInfo>(90U, RecallInfo.Parser);

		// Token: 0x04007ADC RID: 31452
		private readonly RepeatedField<RecallInfo> recallInfos_ = new RepeatedField<RecallInfo>();

		// Token: 0x04007ADD RID: 31453
		public const int RecallIdsFieldNumber = 7;

		// Token: 0x04007ADE RID: 31454
		private static readonly FieldCodec<int> _repeated_recallIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04007ADF RID: 31455
		private readonly RepeatedField<int> recallIds_ = new RepeatedField<int>();
	}
}
