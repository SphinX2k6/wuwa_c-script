using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001475 RID: 5237
	[NetMessage(EMessageId.TutorialInfoResponse)]
	public sealed class TutorialInfoResponse : IMessage<TutorialInfoResponse>, IMessage, IEquatable<TutorialInfoResponse>, IDeepCloneable<TutorialInfoResponse>, IBufferMessage
	{
		// Token: 0x0601BB8E RID: 113550 RVA: 0x00402ED2 File Offset: 0x004010D2
		[NullableContext(1)]
		public static TutorialInfoResponse Create()
		{
			return new TutorialInfoResponse();
		}

		// Token: 0x17005D7B RID: 23931
		// (get) Token: 0x0601BB8F RID: 113551 RVA: 0x00402ED9 File Offset: 0x004010D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D7C RID: 23932
		// (get) Token: 0x0601BB90 RID: 113552 RVA: 0x00402EDC File Offset: 0x004010DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601BB91 RID: 113553 RVA: 0x00402EE3 File Offset: 0x004010E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoResponse()
		{
		}

		// Token: 0x0601BB92 RID: 113554 RVA: 0x00402EF6 File Offset: 0x004010F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoResponse(TutorialInfoResponse other) : this()
		{
			this.unLockList_ = other.unLockList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB93 RID: 113555 RVA: 0x00402F20 File Offset: 0x00401120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoResponse Clone()
		{
			return new TutorialInfoResponse(this);
		}

		// Token: 0x17005D7D RID: 23933
		// (get) Token: 0x0601BB94 RID: 113556 RVA: 0x00402F28 File Offset: 0x00401128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TutorialInfo> UnLockList
		{
			get
			{
				return this.unLockList_;
			}
		}

		// Token: 0x0601BB95 RID: 113557 RVA: 0x00402F30 File Offset: 0x00401130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialInfoResponse);
		}

		// Token: 0x0601BB96 RID: 113558 RVA: 0x00402F3E File Offset: 0x0040113E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialInfoResponse other)
		{
			return other != null && (other == this || (this.unLockList_.Equals(other.unLockList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB97 RID: 113559 RVA: 0x00402F74 File Offset: 0x00401174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unLockList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BB98 RID: 113560 RVA: 0x00402FA8 File Offset: 0x004011A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB99 RID: 113561 RVA: 0x00402FB5 File Offset: 0x004011B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB9A RID: 113562 RVA: 0x00402FBE File Offset: 0x004011BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unLockList_.WriteTo(ref output, TutorialInfoResponse._repeated_unLockList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB9B RID: 113563 RVA: 0x00402FE8 File Offset: 0x004011E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unLockList_.CalculateSize(TutorialInfoResponse._repeated_unLockList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BB9C RID: 113564 RVA: 0x00403021 File Offset: 0x00401221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.unLockList_.Add(other.unLockList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BB9D RID: 113565 RVA: 0x0040304F File Offset: 0x0040124F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB9E RID: 113566 RVA: 0x00403058 File Offset: 0x00401258
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unLockList_.AddEntriesFrom(ref input, TutorialInfoResponse._repeated_unLockList_codec);
				}
			}
		}

		// Token: 0x04009FA8 RID: 40872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FA9 RID: 40873
		public const int UnLockListFieldNumber = 12;

		// Token: 0x04009FAA RID: 40874
		private static readonly FieldCodec<TutorialInfo> _repeated_unLockList_codec = FieldCodec.ForMessage<TutorialInfo>(98U, TutorialInfo.Parser);

		// Token: 0x04009FAB RID: 40875
		private readonly RepeatedField<TutorialInfo> unLockList_ = new RepeatedField<TutorialInfo>();
	}
}
