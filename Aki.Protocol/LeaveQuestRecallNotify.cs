using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DF RID: 2271
	[NetMessage(EMessageId.LeaveQuestRecallNotify)]
	public sealed class LeaveQuestRecallNotify : IMessage<LeaveQuestRecallNotify>, IMessage, IEquatable<LeaveQuestRecallNotify>, IDeepCloneable<LeaveQuestRecallNotify>, IBufferMessage
	{
		// Token: 0x0600C92A RID: 51498 RVA: 0x001DB861 File Offset: 0x001D9A61
		[NullableContext(1)]
		public static LeaveQuestRecallNotify Create()
		{
			return new LeaveQuestRecallNotify();
		}

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x0600C92B RID: 51499 RVA: 0x001DB868 File Offset: 0x001D9A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x0600C92C RID: 51500 RVA: 0x001DB86B File Offset: 0x001D9A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveQuestRecallNotify.Descriptor;
			}
		}

		// Token: 0x0600C92D RID: 51501 RVA: 0x001DB872 File Offset: 0x001D9A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveQuestRecallNotify()
		{
		}

		// Token: 0x0600C92E RID: 51502 RVA: 0x001DB885 File Offset: 0x001D9A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveQuestRecallNotify(LeaveQuestRecallNotify other) : this()
		{
			this.destroyRecallQuestIds_ = other.destroyRecallQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C92F RID: 51503 RVA: 0x001DB8AF File Offset: 0x001D9AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveQuestRecallNotify Clone()
		{
			return new LeaveQuestRecallNotify(this);
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x0600C930 RID: 51504 RVA: 0x001DB8B7 File Offset: 0x001D9AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DestroyRecallQuestIds
		{
			get
			{
				return this.destroyRecallQuestIds_;
			}
		}

		// Token: 0x0600C931 RID: 51505 RVA: 0x001DB8BF File Offset: 0x001D9ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveQuestRecallNotify);
		}

		// Token: 0x0600C932 RID: 51506 RVA: 0x001DB8CD File Offset: 0x001D9ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveQuestRecallNotify other)
		{
			return other != null && (other == this || (this.destroyRecallQuestIds_.Equals(other.destroyRecallQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C933 RID: 51507 RVA: 0x001DB900 File Offset: 0x001D9B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.destroyRecallQuestIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C934 RID: 51508 RVA: 0x001DB934 File Offset: 0x001D9B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C935 RID: 51509 RVA: 0x001DB941 File Offset: 0x001D9B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C936 RID: 51510 RVA: 0x001DB94A File Offset: 0x001D9B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.destroyRecallQuestIds_.WriteTo(ref output, LeaveQuestRecallNotify._repeated_destroyRecallQuestIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C937 RID: 51511 RVA: 0x001DB974 File Offset: 0x001D9B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.destroyRecallQuestIds_.CalculateSize(LeaveQuestRecallNotify._repeated_destroyRecallQuestIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C938 RID: 51512 RVA: 0x001DB9AD File Offset: 0x001D9BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveQuestRecallNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.destroyRecallQuestIds_.Add(other.destroyRecallQuestIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C939 RID: 51513 RVA: 0x001DB9DB File Offset: 0x001D9BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C93A RID: 51514 RVA: 0x001DB9E4 File Offset: 0x001D9BE4
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.destroyRecallQuestIds_.AddEntriesFrom(ref input, LeaveQuestRecallNotify._repeated_destroyRecallQuestIds_codec);
				}
			}
		}

		// Token: 0x04005622 RID: 22050
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005623 RID: 22051
		public const int DestroyRecallQuestIdsFieldNumber = 4;

		// Token: 0x04005624 RID: 22052
		private static readonly FieldCodec<int> _repeated_destroyRecallQuestIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04005625 RID: 22053
		private readonly RepeatedField<int> destroyRecallQuestIds_ = new RepeatedField<int>();
	}
}
