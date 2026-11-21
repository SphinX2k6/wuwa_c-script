using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063E RID: 1598
	[NetMessage(EMessageId.FriendDeletedNotify)]
	public sealed class FriendDeletedNotify : IMessage<FriendDeletedNotify>, IMessage, IEquatable<FriendDeletedNotify>, IDeepCloneable<FriendDeletedNotify>, IBufferMessage
	{
		// Token: 0x06009368 RID: 37736 RVA: 0x00164B51 File Offset: 0x00162D51
		[NullableContext(1)]
		public static FriendDeletedNotify Create()
		{
			return new FriendDeletedNotify();
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06009369 RID: 37737 RVA: 0x00164B58 File Offset: 0x00162D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x0600936A RID: 37738 RVA: 0x00164B5B File Offset: 0x00162D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendDeletedNotify.Descriptor;
			}
		}

		// Token: 0x0600936B RID: 37739 RVA: 0x00164B62 File Offset: 0x00162D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeletedNotify()
		{
		}

		// Token: 0x0600936C RID: 37740 RVA: 0x00164B6A File Offset: 0x00162D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeletedNotify(FriendDeletedNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600936D RID: 37741 RVA: 0x00164B8F File Offset: 0x00162D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeletedNotify Clone()
		{
			return new FriendDeletedNotify(this);
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x0600936E RID: 37742 RVA: 0x00164B97 File Offset: 0x00162D97
		// (set) Token: 0x0600936F RID: 37743 RVA: 0x00164B9F File Offset: 0x00162D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06009370 RID: 37744 RVA: 0x00164BA8 File Offset: 0x00162DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendDeletedNotify);
		}

		// Token: 0x06009371 RID: 37745 RVA: 0x00164BB6 File Offset: 0x00162DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendDeletedNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009372 RID: 37746 RVA: 0x00164BE4 File Offset: 0x00162DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009373 RID: 37747 RVA: 0x00164C23 File Offset: 0x00162E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009374 RID: 37748 RVA: 0x00164C30 File Offset: 0x00162E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009375 RID: 37749 RVA: 0x00164C39 File Offset: 0x00162E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x00164C6C File Offset: 0x00162E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009377 RID: 37751 RVA: 0x00164CAA File Offset: 0x00162EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendDeletedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009378 RID: 37752 RVA: 0x00164CDB File Offset: 0x00162EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009379 RID: 37753 RVA: 0x00164CE4 File Offset: 0x00162EE4
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004732 RID: 18226
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004733 RID: 18227
		public const int IdFieldNumber = 8;

		// Token: 0x04004734 RID: 18228
		private int id_;
	}
}
