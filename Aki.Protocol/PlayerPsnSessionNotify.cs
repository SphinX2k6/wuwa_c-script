using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D94 RID: 3476
	[NetMessage(EMessageId.PlayerPsnSessionNotify)]
	public sealed class PlayerPsnSessionNotify : IMessage<PlayerPsnSessionNotify>, IMessage, IEquatable<PlayerPsnSessionNotify>, IDeepCloneable<PlayerPsnSessionNotify>, IBufferMessage
	{
		// Token: 0x06012C10 RID: 76816 RVA: 0x002BCBBB File Offset: 0x002BADBB
		[NullableContext(1)]
		public static PlayerPsnSessionNotify Create()
		{
			return new PlayerPsnSessionNotify();
		}

		// Token: 0x17003E36 RID: 15926
		// (get) Token: 0x06012C11 RID: 76817 RVA: 0x002BCBC2 File Offset: 0x002BADC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x06012C12 RID: 76818 RVA: 0x002BCBC5 File Offset: 0x002BADC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerPsnSessionNotify.Descriptor;
			}
		}

		// Token: 0x06012C13 RID: 76819 RVA: 0x002BCBCC File Offset: 0x002BADCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnSessionNotify()
		{
		}

		// Token: 0x06012C14 RID: 76820 RVA: 0x002BCBDF File Offset: 0x002BADDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnSessionNotify(PlayerPsnSessionNotify other) : this()
		{
			this.psnSessionId_ = other.psnSessionId_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012C15 RID: 76821 RVA: 0x002BCC10 File Offset: 0x002BAE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnSessionNotify Clone()
		{
			return new PlayerPsnSessionNotify(this);
		}

		// Token: 0x17003E38 RID: 15928
		// (get) Token: 0x06012C16 RID: 76822 RVA: 0x002BCC18 File Offset: 0x002BAE18
		// (set) Token: 0x06012C17 RID: 76823 RVA: 0x002BCC20 File Offset: 0x002BAE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnSessionId
		{
			get
			{
				return this.psnSessionId_;
			}
			set
			{
				this.psnSessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x06012C18 RID: 76824 RVA: 0x002BCC33 File Offset: 0x002BAE33
		// (set) Token: 0x06012C19 RID: 76825 RVA: 0x002BCC3B File Offset: 0x002BAE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06012C1A RID: 76826 RVA: 0x002BCC44 File Offset: 0x002BAE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerPsnSessionNotify);
		}

		// Token: 0x06012C1B RID: 76827 RVA: 0x002BCC54 File Offset: 0x002BAE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerPsnSessionNotify other)
		{
			return other != null && (other == this || (!(this.PsnSessionId != other.PsnSessionId) && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012C1C RID: 76828 RVA: 0x002BCCA4 File Offset: 0x002BAEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PsnSessionId.Length != 0)
			{
				num ^= this.PsnSessionId.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012C1D RID: 76829 RVA: 0x002BCCFE File Offset: 0x002BAEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012C1E RID: 76830 RVA: 0x002BCD0B File Offset: 0x002BAF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012C1F RID: 76831 RVA: 0x002BCD14 File Offset: 0x002BAF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.PsnSessionId.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.PsnSessionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012C20 RID: 76832 RVA: 0x002BCD74 File Offset: 0x002BAF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PsnSessionId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PsnSessionId);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012C21 RID: 76833 RVA: 0x002BCDD0 File Offset: 0x002BAFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerPsnSessionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PsnSessionId.Length != 0)
			{
				this.PsnSessionId = other.PsnSessionId;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012C22 RID: 76834 RVA: 0x002BCE25 File Offset: 0x002BB025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012C23 RID: 76835 RVA: 0x002BCE30 File Offset: 0x002BB030
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
				if (num != 24U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PsnSessionId = input.ReadString();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007493 RID: 29843
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007494 RID: 29844
		public const int PsnSessionIdFieldNumber = 10;

		// Token: 0x04007495 RID: 29845
		private string psnSessionId_ = "";

		// Token: 0x04007496 RID: 29846
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04007497 RID: 29847
		private int playerId_;
	}
}
