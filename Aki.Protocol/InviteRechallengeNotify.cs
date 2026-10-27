using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000840 RID: 2112
	[NetMessage(EMessageId.InviteRechallengeNotify)]
	public sealed class InviteRechallengeNotify : IMessage<InviteRechallengeNotify>, IMessage, IEquatable<InviteRechallengeNotify>, IDeepCloneable<InviteRechallengeNotify>, IBufferMessage
	{
		// Token: 0x0600BC98 RID: 48280 RVA: 0x001C0E1F File Offset: 0x001BF01F
		[NullableContext(1)]
		public static InviteRechallengeNotify Create()
		{
			return new InviteRechallengeNotify();
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x0600BC99 RID: 48281 RVA: 0x001C0E26 File Offset: 0x001BF026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x0600BC9A RID: 48282 RVA: 0x001C0E29 File Offset: 0x001BF029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InviteRechallengeNotify.Descriptor;
			}
		}

		// Token: 0x0600BC9B RID: 48283 RVA: 0x001C0E30 File Offset: 0x001BF030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeNotify()
		{
		}

		// Token: 0x0600BC9C RID: 48284 RVA: 0x001C0E38 File Offset: 0x001BF038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeNotify(InviteRechallengeNotify other) : this()
		{
			this.inviterPlayerId_ = other.inviterPlayerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC9D RID: 48285 RVA: 0x001C0E5D File Offset: 0x001BF05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeNotify Clone()
		{
			return new InviteRechallengeNotify(this);
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x0600BC9E RID: 48286 RVA: 0x001C0E65 File Offset: 0x001BF065
		// (set) Token: 0x0600BC9F RID: 48287 RVA: 0x001C0E6D File Offset: 0x001BF06D
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

		// Token: 0x0600BCA0 RID: 48288 RVA: 0x001C0E76 File Offset: 0x001BF076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InviteRechallengeNotify);
		}

		// Token: 0x0600BCA1 RID: 48289 RVA: 0x001C0E84 File Offset: 0x001BF084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InviteRechallengeNotify other)
		{
			return other != null && (other == this || (this.InviterPlayerId == other.InviterPlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCA2 RID: 48290 RVA: 0x001C0EB4 File Offset: 0x001BF0B4
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

		// Token: 0x0600BCA3 RID: 48291 RVA: 0x001C0EF3 File Offset: 0x001BF0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BCA4 RID: 48292 RVA: 0x001C0F00 File Offset: 0x001BF100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCA5 RID: 48293 RVA: 0x001C0F09 File Offset: 0x001BF109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InviterPlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InviterPlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BCA6 RID: 48294 RVA: 0x001C0F3C File Offset: 0x001BF13C
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

		// Token: 0x0600BCA7 RID: 48295 RVA: 0x001C0F7A File Offset: 0x001BF17A
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

		// Token: 0x0600BCA8 RID: 48296 RVA: 0x001C0FAB File Offset: 0x001BF1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCA9 RID: 48297 RVA: 0x001C0FB4 File Offset: 0x001BF1B4
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InviterPlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005296 RID: 21142
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005297 RID: 21143
		public const int InviterPlayerIdFieldNumber = 2;

		// Token: 0x04005298 RID: 21144
		private int inviterPlayerId_;
	}
}
