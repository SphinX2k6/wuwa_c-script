using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001092 RID: 4242
	[NetMessage(EMessageId.RoleQuestNewUnlockNotify)]
	public sealed class RoleQuestNewUnlockNotify : IMessage<RoleQuestNewUnlockNotify>, IMessage, IEquatable<RoleQuestNewUnlockNotify>, IDeepCloneable<RoleQuestNewUnlockNotify>, IBufferMessage
	{
		// Token: 0x06016AF3 RID: 92915 RVA: 0x0034C99D File Offset: 0x0034AB9D
		[NullableContext(1)]
		public static RoleQuestNewUnlockNotify Create()
		{
			return new RoleQuestNewUnlockNotify();
		}

		// Token: 0x17004C07 RID: 19463
		// (get) Token: 0x06016AF4 RID: 92916 RVA: 0x0034C9A4 File Offset: 0x0034ABA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C08 RID: 19464
		// (get) Token: 0x06016AF5 RID: 92917 RVA: 0x0034C9A7 File Offset: 0x0034ABA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestNewUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06016AF6 RID: 92918 RVA: 0x0034C9AE File Offset: 0x0034ABAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestNewUnlockNotify()
		{
		}

		// Token: 0x06016AF7 RID: 92919 RVA: 0x0034C9C1 File Offset: 0x0034ABC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestNewUnlockNotify(RoleQuestNewUnlockNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016AF8 RID: 92920 RVA: 0x0034C9EB File Offset: 0x0034ABEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestNewUnlockNotify Clone()
		{
			return new RoleQuestNewUnlockNotify(this);
		}

		// Token: 0x17004C09 RID: 19465
		// (get) Token: 0x06016AF9 RID: 92921 RVA: 0x0034C9F3 File Offset: 0x0034ABF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x06016AFA RID: 92922 RVA: 0x0034C9FB File Offset: 0x0034ABFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestNewUnlockNotify);
		}

		// Token: 0x06016AFB RID: 92923 RVA: 0x0034CA09 File Offset: 0x0034AC09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestNewUnlockNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016AFC RID: 92924 RVA: 0x0034CA3C File Offset: 0x0034AC3C
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

		// Token: 0x06016AFD RID: 92925 RVA: 0x0034CA70 File Offset: 0x0034AC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016AFE RID: 92926 RVA: 0x0034CA7D File Offset: 0x0034AC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016AFF RID: 92927 RVA: 0x0034CA86 File Offset: 0x0034AC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questIds_.WriteTo(ref output, RoleQuestNewUnlockNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B00 RID: 92928 RVA: 0x0034CAB0 File Offset: 0x0034ACB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questIds_.CalculateSize(RoleQuestNewUnlockNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016B01 RID: 92929 RVA: 0x0034CAE9 File Offset: 0x0034ACE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleQuestNewUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questIds_.Add(other.questIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016B02 RID: 92930 RVA: 0x0034CB17 File Offset: 0x0034AD17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B03 RID: 92931 RVA: 0x0034CB20 File Offset: 0x0034AD20
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
					this.questIds_.AddEntriesFrom(ref input, RoleQuestNewUnlockNotify._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x040087FA RID: 34810
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087FB RID: 34811
		public const int QuestIdsFieldNumber = 3;

		// Token: 0x040087FC RID: 34812
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040087FD RID: 34813
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
