using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C9 RID: 969
	[NetMessage(EMessageId.DestroyQuestsNotify)]
	public sealed class DestroyQuestsNotify : IMessage<DestroyQuestsNotify>, IMessage, IEquatable<DestroyQuestsNotify>, IDeepCloneable<DestroyQuestsNotify>, IBufferMessage
	{
		// Token: 0x06005E9D RID: 24221 RVA: 0x000E5221 File Offset: 0x000E3421
		[NullableContext(1)]
		public static DestroyQuestsNotify Create()
		{
			return new DestroyQuestsNotify();
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06005E9E RID: 24222 RVA: 0x000E5228 File Offset: 0x000E3428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06005E9F RID: 24223 RVA: 0x000E522B File Offset: 0x000E342B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyQuestsNotify.Descriptor;
			}
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x000E5232 File Offset: 0x000E3432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyQuestsNotify()
		{
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x000E5245 File Offset: 0x000E3445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyQuestsNotify(DestroyQuestsNotify other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x000E526F File Offset: 0x000E346F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyQuestsNotify Clone()
		{
			return new DestroyQuestsNotify(this);
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06005EA3 RID: 24227 RVA: 0x000E5277 File Offset: 0x000E3477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x000E527F File Offset: 0x000E347F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyQuestsNotify);
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x000E528D File Offset: 0x000E348D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyQuestsNotify other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x000E52C0 File Offset: 0x000E34C0
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

		// Token: 0x06005EA7 RID: 24231 RVA: 0x000E52F4 File Offset: 0x000E34F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x000E5301 File Offset: 0x000E3501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x000E530A File Offset: 0x000E350A
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

		// Token: 0x06005EAA RID: 24234 RVA: 0x000E5334 File Offset: 0x000E3534
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

		// Token: 0x06005EAB RID: 24235 RVA: 0x000E536D File Offset: 0x000E356D
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

		// Token: 0x06005EAC RID: 24236 RVA: 0x000E539B File Offset: 0x000E359B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x000E53A4 File Offset: 0x000E35A4
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
				if (num != 16U && num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questIds_.AddEntriesFrom(ref input, DestroyQuestsNotify._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x040036D5 RID: 14037
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036D6 RID: 14038
		public const int QuestIdsFieldNumber = 2;

		// Token: 0x040036D7 RID: 14039
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040036D8 RID: 14040
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
