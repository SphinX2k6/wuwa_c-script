using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001134 RID: 4404
	[NetMessage(EMessageId.RoverRogueEventNotify)]
	public sealed class RoverRogueEventNotify : IMessage<RoverRogueEventNotify>, IMessage, IEquatable<RoverRogueEventNotify>, IDeepCloneable<RoverRogueEventNotify>, IBufferMessage
	{
		// Token: 0x06017870 RID: 96368 RVA: 0x0036C423 File Offset: 0x0036A623
		[NullableContext(1)]
		public static RoverRogueEventNotify Create()
		{
			return new RoverRogueEventNotify();
		}

		// Token: 0x17004F13 RID: 20243
		// (get) Token: 0x06017871 RID: 96369 RVA: 0x0036C42A File Offset: 0x0036A62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F14 RID: 20244
		// (get) Token: 0x06017872 RID: 96370 RVA: 0x0036C42D File Offset: 0x0036A62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueEventNotify.Descriptor;
			}
		}

		// Token: 0x06017873 RID: 96371 RVA: 0x0036C434 File Offset: 0x0036A634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventNotify()
		{
		}

		// Token: 0x06017874 RID: 96372 RVA: 0x0036C447 File Offset: 0x0036A647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventNotify(RoverRogueEventNotify other) : this()
		{
			this.eventIncId_ = other.eventIncId_;
			this.choiceList_ = other.choiceList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017875 RID: 96373 RVA: 0x0036C47D File Offset: 0x0036A67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueEventNotify Clone()
		{
			return new RoverRogueEventNotify(this);
		}

		// Token: 0x17004F15 RID: 20245
		// (get) Token: 0x06017876 RID: 96374 RVA: 0x0036C485 File Offset: 0x0036A685
		// (set) Token: 0x06017877 RID: 96375 RVA: 0x0036C48D File Offset: 0x0036A68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventIncId
		{
			get
			{
				return this.eventIncId_;
			}
			set
			{
				this.eventIncId_ = value;
			}
		}

		// Token: 0x17004F16 RID: 20246
		// (get) Token: 0x06017878 RID: 96376 RVA: 0x0036C496 File Offset: 0x0036A696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChoiceList
		{
			get
			{
				return this.choiceList_;
			}
		}

		// Token: 0x06017879 RID: 96377 RVA: 0x0036C49E File Offset: 0x0036A69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueEventNotify);
		}

		// Token: 0x0601787A RID: 96378 RVA: 0x0036C4AC File Offset: 0x0036A6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueEventNotify other)
		{
			return other != null && (other == this || (this.EventIncId == other.EventIncId && this.choiceList_.Equals(other.choiceList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601787B RID: 96379 RVA: 0x0036C4FC File Offset: 0x0036A6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventIncId != 0)
			{
				num ^= this.EventIncId.GetHashCode();
			}
			num ^= this.choiceList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601787C RID: 96380 RVA: 0x0036C549 File Offset: 0x0036A749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601787D RID: 96381 RVA: 0x0036C556 File Offset: 0x0036A756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601787E RID: 96382 RVA: 0x0036C560 File Offset: 0x0036A760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EventIncId);
			}
			this.choiceList_.WriteTo(ref output, RoverRogueEventNotify._repeated_choiceList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601787F RID: 96383 RVA: 0x0036C5B0 File Offset: 0x0036A7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventIncId);
			}
			num += this.choiceList_.CalculateSize(RoverRogueEventNotify._repeated_choiceList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017880 RID: 96384 RVA: 0x0036C604 File Offset: 0x0036A804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueEventNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventIncId != 0)
			{
				this.EventIncId = other.EventIncId;
			}
			this.choiceList_.Add(other.choiceList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017881 RID: 96385 RVA: 0x0036C651 File Offset: 0x0036A851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017882 RID: 96386 RVA: 0x0036C65C File Offset: 0x0036A85C
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
				if (num != 8U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.choiceList_.AddEntriesFrom(ref input, RoverRogueEventNotify._repeated_choiceList_codec);
					}
				}
				else
				{
					this.EventIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008C67 RID: 35943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C68 RID: 35944
		public const int EventIncIdFieldNumber = 1;

		// Token: 0x04008C69 RID: 35945
		private int eventIncId_;

		// Token: 0x04008C6A RID: 35946
		public const int ChoiceListFieldNumber = 9;

		// Token: 0x04008C6B RID: 35947
		private static readonly FieldCodec<int> _repeated_choiceList_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04008C6C RID: 35948
		private readonly RepeatedField<int> choiceList_ = new RepeatedField<int>();
	}
}
