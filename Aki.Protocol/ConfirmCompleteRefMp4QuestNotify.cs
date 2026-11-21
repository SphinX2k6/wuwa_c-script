using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D7 RID: 727
	[NetMessage(EMessageId.ConfirmCompleteRefMp4QuestNotify)]
	public sealed class ConfirmCompleteRefMp4QuestNotify : IMessage<ConfirmCompleteRefMp4QuestNotify>, IMessage, IEquatable<ConfirmCompleteRefMp4QuestNotify>, IDeepCloneable<ConfirmCompleteRefMp4QuestNotify>, IBufferMessage
	{
		// Token: 0x06004AAB RID: 19115 RVA: 0x000B6D8A File Offset: 0x000B4F8A
		[NullableContext(1)]
		public static ConfirmCompleteRefMp4QuestNotify Create()
		{
			return new ConfirmCompleteRefMp4QuestNotify();
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06004AAC RID: 19116 RVA: 0x000B6D91 File Offset: 0x000B4F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06004AAD RID: 19117 RVA: 0x000B6D94 File Offset: 0x000B4F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConfirmCompleteRefMp4QuestNotify.Descriptor;
			}
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x000B6D9B File Offset: 0x000B4F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmCompleteRefMp4QuestNotify()
		{
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x000B6DAE File Offset: 0x000B4FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmCompleteRefMp4QuestNotify(ConfirmCompleteRefMp4QuestNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x000B6DD8 File Offset: 0x000B4FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmCompleteRefMp4QuestNotify Clone()
		{
			return new ConfirmCompleteRefMp4QuestNotify(this);
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06004AB1 RID: 19121 RVA: 0x000B6DE0 File Offset: 0x000B4FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x000B6DE8 File Offset: 0x000B4FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConfirmCompleteRefMp4QuestNotify);
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x000B6DF6 File Offset: 0x000B4FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConfirmCompleteRefMp4QuestNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x000B6E2C File Offset: 0x000B502C
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

		// Token: 0x06004AB5 RID: 19125 RVA: 0x000B6E60 File Offset: 0x000B5060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x000B6E6D File Offset: 0x000B506D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x000B6E76 File Offset: 0x000B5076
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

		// Token: 0x06004AB8 RID: 19128 RVA: 0x000B6EA0 File Offset: 0x000B50A0
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

		// Token: 0x06004AB9 RID: 19129 RVA: 0x000B6ED9 File Offset: 0x000B50D9
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

		// Token: 0x06004ABA RID: 19130 RVA: 0x000B6F07 File Offset: 0x000B5107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x000B6F10 File Offset: 0x000B5110
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questIds_.AddEntriesFrom(ref input, ConfirmCompleteRefMp4QuestNotify._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x040030E7 RID: 12519
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030E8 RID: 12520
		public const int QuestIdsFieldNumber = 6;

		// Token: 0x040030E9 RID: 12521
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x040030EA RID: 12522
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
