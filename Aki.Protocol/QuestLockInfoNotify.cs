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
	[NetMessage(EMessageId.QuestLockInfoNotify)]
	public sealed class QuestLockInfoNotify : IMessage<QuestLockInfoNotify>, IMessage, IEquatable<QuestLockInfoNotify>, IDeepCloneable<QuestLockInfoNotify>, IBufferMessage
	{
		// Token: 0x06013594 RID: 79252 RVA: 0x002D1116 File Offset: 0x002CF316
		[NullableContext(1)]
		public static QuestLockInfoNotify Create()
		{
			return new QuestLockInfoNotify();
		}

		// Token: 0x1700402F RID: 16431
		// (get) Token: 0x06013595 RID: 79253 RVA: 0x002D111D File Offset: 0x002CF31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004030 RID: 16432
		// (get) Token: 0x06013596 RID: 79254 RVA: 0x002D1120 File Offset: 0x002CF320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestLockInfoNotify.Descriptor;
			}
		}

		// Token: 0x06013597 RID: 79255 RVA: 0x002D1127 File Offset: 0x002CF327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfoNotify()
		{
		}

		// Token: 0x06013598 RID: 79256 RVA: 0x002D113A File Offset: 0x002CF33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfoNotify(QuestLockInfoNotify other) : this()
		{
			this.questLockInfos_ = other.questLockInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013599 RID: 79257 RVA: 0x002D1164 File Offset: 0x002CF364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestLockInfoNotify Clone()
		{
			return new QuestLockInfoNotify(this);
		}

		// Token: 0x17004031 RID: 16433
		// (get) Token: 0x0601359A RID: 79258 RVA: 0x002D116C File Offset: 0x002CF36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestLockInfo> QuestLockInfos
		{
			get
			{
				return this.questLockInfos_;
			}
		}

		// Token: 0x0601359B RID: 79259 RVA: 0x002D1174 File Offset: 0x002CF374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestLockInfoNotify);
		}

		// Token: 0x0601359C RID: 79260 RVA: 0x002D1182 File Offset: 0x002CF382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestLockInfoNotify other)
		{
			return other != null && (other == this || (this.questLockInfos_.Equals(other.questLockInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601359D RID: 79261 RVA: 0x002D11B8 File Offset: 0x002CF3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questLockInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601359E RID: 79262 RVA: 0x002D11EC File Offset: 0x002CF3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601359F RID: 79263 RVA: 0x002D11F9 File Offset: 0x002CF3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060135A0 RID: 79264 RVA: 0x002D1202 File Offset: 0x002CF402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questLockInfos_.WriteTo(ref output, QuestLockInfoNotify._repeated_questLockInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060135A1 RID: 79265 RVA: 0x002D122C File Offset: 0x002CF42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questLockInfos_.CalculateSize(QuestLockInfoNotify._repeated_questLockInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060135A2 RID: 79266 RVA: 0x002D1265 File Offset: 0x002CF465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestLockInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questLockInfos_.Add(other.questLockInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060135A3 RID: 79267 RVA: 0x002D1293 File Offset: 0x002CF493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060135A4 RID: 79268 RVA: 0x002D129C File Offset: 0x002CF49C
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questLockInfos_.AddEntriesFrom(ref input, QuestLockInfoNotify._repeated_questLockInfos_codec);
				}
			}
		}

		// Token: 0x04007734 RID: 30516
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007735 RID: 30517
		public const int QuestLockInfosFieldNumber = 14;

		// Token: 0x04007736 RID: 30518
		private static readonly FieldCodec<QuestLockInfo> _repeated_questLockInfos_codec = FieldCodec.ForMessage<QuestLockInfo>(114U, QuestLockInfo.Parser);

		// Token: 0x04007737 RID: 30519
		private readonly RepeatedField<QuestLockInfo> questLockInfos_ = new RepeatedField<QuestLockInfo>();
	}
}
