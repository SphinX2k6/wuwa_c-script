using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E0C RID: 3596
	[NetMessage(EMessageId.QuestChangeTraceNotify)]
	public sealed class QuestChangeTraceNotify : IMessage<QuestChangeTraceNotify>, IMessage, IEquatable<QuestChangeTraceNotify>, IDeepCloneable<QuestChangeTraceNotify>, IBufferMessage
	{
		// Token: 0x0601353D RID: 79165 RVA: 0x002D01A7 File Offset: 0x002CE3A7
		[NullableContext(1)]
		public static QuestChangeTraceNotify Create()
		{
			return new QuestChangeTraceNotify();
		}

		// Token: 0x1700401B RID: 16411
		// (get) Token: 0x0601353E RID: 79166 RVA: 0x002D01AE File Offset: 0x002CE3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700401C RID: 16412
		// (get) Token: 0x0601353F RID: 79167 RVA: 0x002D01B1 File Offset: 0x002CE3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestChangeTraceNotify.Descriptor;
			}
		}

		// Token: 0x06013540 RID: 79168 RVA: 0x002D01B8 File Offset: 0x002CE3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestChangeTraceNotify()
		{
		}

		// Token: 0x06013541 RID: 79169 RVA: 0x002D01CB File Offset: 0x002CE3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestChangeTraceNotify(QuestChangeTraceNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013542 RID: 79170 RVA: 0x002D01F5 File Offset: 0x002CE3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestChangeTraceNotify Clone()
		{
			return new QuestChangeTraceNotify(this);
		}

		// Token: 0x1700401D RID: 16413
		// (get) Token: 0x06013543 RID: 79171 RVA: 0x002D01FD File Offset: 0x002CE3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x06013544 RID: 79172 RVA: 0x002D0205 File Offset: 0x002CE405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestChangeTraceNotify);
		}

		// Token: 0x06013545 RID: 79173 RVA: 0x002D0213 File Offset: 0x002CE413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestChangeTraceNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013546 RID: 79174 RVA: 0x002D0248 File Offset: 0x002CE448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013547 RID: 79175 RVA: 0x002D027C File Offset: 0x002CE47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013548 RID: 79176 RVA: 0x002D0289 File Offset: 0x002CE489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013549 RID: 79177 RVA: 0x002D0292 File Offset: 0x002CE492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questIds_.WriteTo(ref output, QuestChangeTraceNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601354A RID: 79178 RVA: 0x002D02BC File Offset: 0x002CE4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questIds_.CalculateSize(QuestChangeTraceNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601354B RID: 79179 RVA: 0x002D02F5 File Offset: 0x002CE4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestChangeTraceNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questIds_.Add(other.questIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601354C RID: 79180 RVA: 0x002D0323 File Offset: 0x002CE523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601354D RID: 79181 RVA: 0x002D032C File Offset: 0x002CE52C
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questIds_.AddEntriesFrom(ref input, QuestChangeTraceNotify._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x040076BC RID: 30396
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076BD RID: 30397
		public const int QuestIdsFieldNumber = 10;

		// Token: 0x040076BE RID: 30398
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040076BF RID: 30399
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
