using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D0 RID: 720
	[NetMessage(EMessageId.ConfirmCompleteRefMp4QuestNotify)]
	public sealed class ConfirmCompleteRefMp4QuestNotify : IMessage<ConfirmCompleteRefMp4QuestNotify>, IMessage, IEquatable<ConfirmCompleteRefMp4QuestNotify>, IDeepCloneable<ConfirmCompleteRefMp4QuestNotify>, IBufferMessage
	{
		// Token: 0x060049D2 RID: 18898 RVA: 0x000B49A2 File Offset: 0x000B2BA2
		[NullableContext(1)]
		public static ConfirmCompleteRefMp4QuestNotify Create()
		{
			return new ConfirmCompleteRefMp4QuestNotify();
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060049D3 RID: 18899 RVA: 0x000B49A9 File Offset: 0x000B2BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060049D4 RID: 18900 RVA: 0x000B49AC File Offset: 0x000B2BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConfirmCompleteRefMp4QuestNotify.Descriptor;
			}
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x000B49B3 File Offset: 0x000B2BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmCompleteRefMp4QuestNotify()
		{
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x000B49C6 File Offset: 0x000B2BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmCompleteRefMp4QuestNotify(ConfirmCompleteRefMp4QuestNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x000B49F0 File Offset: 0x000B2BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmCompleteRefMp4QuestNotify Clone()
		{
			return new ConfirmCompleteRefMp4QuestNotify(this);
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060049D8 RID: 18904 RVA: 0x000B49F8 File Offset: 0x000B2BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x000B4A00 File Offset: 0x000B2C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConfirmCompleteRefMp4QuestNotify);
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x000B4A0E File Offset: 0x000B2C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConfirmCompleteRefMp4QuestNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x000B4A44 File Offset: 0x000B2C44
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

		// Token: 0x060049DC RID: 18908 RVA: 0x000B4A78 File Offset: 0x000B2C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x000B4A85 File Offset: 0x000B2C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x000B4A8E File Offset: 0x000B2C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questIds_.WriteTo(ref output, ConfirmCompleteRefMp4QuestNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x000B4AB8 File Offset: 0x000B2CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questIds_.CalculateSize(ConfirmCompleteRefMp4QuestNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x000B4AF1 File Offset: 0x000B2CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConfirmCompleteRefMp4QuestNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questIds_.Add(other.questIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x000B4B1F File Offset: 0x000B2D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x000B4B28 File Offset: 0x000B2D28
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
					this.questIds_.AddEntriesFrom(ref input, ConfirmCompleteRefMp4QuestNotify._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x04003050 RID: 12368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003051 RID: 12369
		public const int QuestIdsFieldNumber = 3;

		// Token: 0x04003052 RID: 12370
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04003053 RID: 12371
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
