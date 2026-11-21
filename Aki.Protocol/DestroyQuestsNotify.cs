using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B2 RID: 946
	[NetMessage(EMessageId.DestroyQuestsNotify)]
	public sealed class DestroyQuestsNotify : IMessage<DestroyQuestsNotify>, IMessage, IEquatable<DestroyQuestsNotify>, IDeepCloneable<DestroyQuestsNotify>, IBufferMessage
	{
		// Token: 0x06005D0D RID: 23821 RVA: 0x000E209D File Offset: 0x000E029D
		[NullableContext(1)]
		public static DestroyQuestsNotify Create()
		{
			return new DestroyQuestsNotify();
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06005D0E RID: 23822 RVA: 0x000E20A4 File Offset: 0x000E02A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06005D0F RID: 23823 RVA: 0x000E20A7 File Offset: 0x000E02A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyQuestsNotify.Descriptor;
			}
		}

		// Token: 0x06005D10 RID: 23824 RVA: 0x000E20AE File Offset: 0x000E02AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyQuestsNotify()
		{
		}

		// Token: 0x06005D11 RID: 23825 RVA: 0x000E20C1 File Offset: 0x000E02C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyQuestsNotify(DestroyQuestsNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D12 RID: 23826 RVA: 0x000E20EB File Offset: 0x000E02EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyQuestsNotify Clone()
		{
			return new DestroyQuestsNotify(this);
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06005D13 RID: 23827 RVA: 0x000E20F3 File Offset: 0x000E02F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x06005D14 RID: 23828 RVA: 0x000E20FB File Offset: 0x000E02FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyQuestsNotify);
		}

		// Token: 0x06005D15 RID: 23829 RVA: 0x000E2109 File Offset: 0x000E0309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyQuestsNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D16 RID: 23830 RVA: 0x000E213C File Offset: 0x000E033C
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

		// Token: 0x06005D17 RID: 23831 RVA: 0x000E2170 File Offset: 0x000E0370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x000E217D File Offset: 0x000E037D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x000E2186 File Offset: 0x000E0386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questIds_.WriteTo(ref output, DestroyQuestsNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x000E21B0 File Offset: 0x000E03B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questIds_.CalculateSize(DestroyQuestsNotify._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D1B RID: 23835 RVA: 0x000E21E9 File Offset: 0x000E03E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DestroyQuestsNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questIds_.Add(other.questIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D1C RID: 23836 RVA: 0x000E2217 File Offset: 0x000E0417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x000E2220 File Offset: 0x000E0420
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questIds_.AddEntriesFrom(ref input, DestroyQuestsNotify._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x040036C2 RID: 14018
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036C3 RID: 14019
		public const int QuestIdsFieldNumber = 12;

		// Token: 0x040036C4 RID: 14020
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040036C5 RID: 14021
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
