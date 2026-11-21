using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082C RID: 2092
	[NetMessage(EMessageId.InviteRechallengeNotify)]
	public sealed class InviteRechallengeNotify : IMessage<InviteRechallengeNotify>, IMessage, IEquatable<InviteRechallengeNotify>, IDeepCloneable<InviteRechallengeNotify>, IBufferMessage
	{
		// Token: 0x0600BB42 RID: 47938 RVA: 0x001BE3E6 File Offset: 0x001BC5E6
		[NullableContext(1)]
		public static InviteRechallengeNotify Create()
		{
			return new InviteRechallengeNotify();
		}

		// Token: 0x170025CD RID: 9677
		// (get) Token: 0x0600BB43 RID: 47939 RVA: 0x001BE3ED File Offset: 0x001BC5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x0600BB44 RID: 47940 RVA: 0x001BE3F0 File Offset: 0x001BC5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InviteRechallengeNotify.Descriptor;
			}
		}

		// Token: 0x0600BB45 RID: 47941 RVA: 0x001BE3F7 File Offset: 0x001BC5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeNotify()
		{
		}

		// Token: 0x0600BB46 RID: 47942 RVA: 0x001BE3FF File Offset: 0x001BC5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeNotify(InviteRechallengeNotify other) : this()
		{
			this.inviterPlayerId_ = other.inviterPlayerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB47 RID: 47943 RVA: 0x001BE424 File Offset: 0x001BC624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeNotify Clone()
		{
			return new InviteRechallengeNotify(this);
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x0600BB48 RID: 47944 RVA: 0x001BE42C File Offset: 0x001BC62C
		// (set) Token: 0x0600BB49 RID: 47945 RVA: 0x001BE434 File Offset: 0x001BC634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InviterPlayerId
		{
			get
			{
				return this.inviterPlayerId_;
			}
			set
			{
				this.inviterPlayerId_ = value;
			}
		}

		// Token: 0x0600BB4A RID: 47946 RVA: 0x001BE43D File Offset: 0x001BC63D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InviteRechallengeNotify);
		}

		// Token: 0x0600BB4B RID: 47947 RVA: 0x001BE44B File Offset: 0x001BC64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InviteRechallengeNotify other)
		{
			return other != null && (other == this || (this.InviterPlayerId == other.InviterPlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB4C RID: 47948 RVA: 0x001BE47C File Offset: 0x001BC67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InviterPlayerId != 0)
			{
				num ^= this.InviterPlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB4D RID: 47949 RVA: 0x001BE4BB File Offset: 0x001BC6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB4E RID: 47950 RVA: 0x001BE4C8 File Offset: 0x001BC6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB4F RID: 47951 RVA: 0x001BE4D1 File Offset: 0x001BC6D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InviterPlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.InviterPlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB50 RID: 47952 RVA: 0x001BE504 File Offset: 0x001BC704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InviterPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InviterPlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB51 RID: 47953 RVA: 0x001BE542 File Offset: 0x001BC742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InviteRechallengeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InviterPlayerId != 0)
			{
				this.InviterPlayerId = other.InviterPlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB52 RID: 47954 RVA: 0x001BE573 File Offset: 0x001BC773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB53 RID: 47955 RVA: 0x001BE57C File Offset: 0x001BC77C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InviterPlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400528F RID: 21135
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005290 RID: 21136
		public const int InviterPlayerIdFieldNumber = 13;

		// Token: 0x04005291 RID: 21137
		private int inviterPlayerId_;
	}
}
