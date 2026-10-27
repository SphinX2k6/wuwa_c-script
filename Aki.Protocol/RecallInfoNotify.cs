using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA9 RID: 3753
	[NetMessage(EMessageId.RecallInfoNotify)]
	public sealed class RecallInfoNotify : IMessage<RecallInfoNotify>, IMessage, IEquatable<RecallInfoNotify>, IDeepCloneable<RecallInfoNotify>, IBufferMessage
	{
		// Token: 0x06014242 RID: 82498 RVA: 0x002EE45A File Offset: 0x002EC65A
		[NullableContext(1)]
		public static RecallInfoNotify Create()
		{
			return new RecallInfoNotify();
		}

		// Token: 0x170042FD RID: 17149
		// (get) Token: 0x06014243 RID: 82499 RVA: 0x002EE461 File Offset: 0x002EC661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042FE RID: 17150
		// (get) Token: 0x06014244 RID: 82500 RVA: 0x002EE464 File Offset: 0x002EC664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallInfoNotify.Descriptor;
			}
		}

		// Token: 0x06014245 RID: 82501 RVA: 0x002EE46B File Offset: 0x002EC66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfoNotify()
		{
		}

		// Token: 0x06014246 RID: 82502 RVA: 0x002EE489 File Offset: 0x002EC689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfoNotify(RecallInfoNotify other) : this()
		{
			this.recallInfos_ = other.recallInfos_.Clone();
			this.recallIds_ = other.recallIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014247 RID: 82503 RVA: 0x002EE4C4 File Offset: 0x002EC6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallInfoNotify Clone()
		{
			return new RecallInfoNotify(this);
		}

		// Token: 0x170042FF RID: 17151
		// (get) Token: 0x06014248 RID: 82504 RVA: 0x002EE4CC File Offset: 0x002EC6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecallInfo> RecallInfos
		{
			get
			{
				return this.recallInfos_;
			}
		}

		// Token: 0x17004300 RID: 17152
		// (get) Token: 0x06014249 RID: 82505 RVA: 0x002EE4D4 File Offset: 0x002EC6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RecallIds
		{
			get
			{
				return this.recallIds_;
			}
		}

		// Token: 0x0601424A RID: 82506 RVA: 0x002EE4DC File Offset: 0x002EC6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallInfoNotify);
		}

		// Token: 0x0601424B RID: 82507 RVA: 0x002EE4EC File Offset: 0x002EC6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallInfoNotify other)
		{
			return other != null && (other == this || (this.recallInfos_.Equals(other.recallInfos_) && this.recallIds_.Equals(other.recallIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601424C RID: 82508 RVA: 0x002EE540 File Offset: 0x002EC740
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

		// Token: 0x0601424D RID: 82509 RVA: 0x002EE582 File Offset: 0x002EC782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601424E RID: 82510 RVA: 0x002EE58F File Offset: 0x002EC78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601424F RID: 82511 RVA: 0x002EE598 File Offset: 0x002EC798
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

		// Token: 0x06014250 RID: 82512 RVA: 0x002EE5D0 File Offset: 0x002EC7D0
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

		// Token: 0x06014251 RID: 82513 RVA: 0x002EE61C File Offset: 0x002EC81C
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

		// Token: 0x06014252 RID: 82514 RVA: 0x002EE65B File Offset: 0x002EC85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014253 RID: 82515 RVA: 0x002EE664 File Offset: 0x002EC864
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
				if (num != 72U && num != 74U)
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

		// Token: 0x04007AAF RID: 31407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AB0 RID: 31408
		public const int RecallInfosFieldNumber = 11;

		// Token: 0x04007AB1 RID: 31409
		private static readonly FieldCodec<RecallInfo> _repeated_recallInfos_codec = FieldCodec.ForMessage<RecallInfo>(90U, RecallInfo.Parser);

		// Token: 0x04007AB2 RID: 31410
		private readonly RepeatedField<RecallInfo> recallInfos_ = new RepeatedField<RecallInfo>();

		// Token: 0x04007AB3 RID: 31411
		public const int RecallIdsFieldNumber = 9;

		// Token: 0x04007AB4 RID: 31412
		private static readonly FieldCodec<int> _repeated_recallIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04007AB5 RID: 31413
		private readonly RepeatedField<int> recallIds_ = new RepeatedField<int>();
	}
}
