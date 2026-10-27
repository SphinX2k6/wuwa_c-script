using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BC RID: 1980
	[NetMessage(EMessageId.HostTeleportUnlockNotify)]
	public sealed class HostTeleportUnlockNotify : IMessage<HostTeleportUnlockNotify>, IMessage, IEquatable<HostTeleportUnlockNotify>, IDeepCloneable<HostTeleportUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600B231 RID: 45617 RVA: 0x001AAC80 File Offset: 0x001A8E80
		[NullableContext(1)]
		public static HostTeleportUnlockNotify Create()
		{
			return new HostTeleportUnlockNotify();
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600B232 RID: 45618 RVA: 0x001AAC87 File Offset: 0x001A8E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x0600B233 RID: 45619 RVA: 0x001AAC8A File Offset: 0x001A8E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HostTeleportUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x001AAC91 File Offset: 0x001A8E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostTeleportUnlockNotify()
		{
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x001AAC99 File Offset: 0x001A8E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostTeleportUnlockNotify(HostTeleportUnlockNotify other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.hostTeleportId_ = other.hostTeleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B236 RID: 45622 RVA: 0x001AACCA File Offset: 0x001A8ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostTeleportUnlockNotify Clone()
		{
			return new HostTeleportUnlockNotify(this);
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x0600B237 RID: 45623 RVA: 0x001AACD2 File Offset: 0x001A8ED2
		// (set) Token: 0x0600B238 RID: 45624 RVA: 0x001AACDA File Offset: 0x001A8EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x0600B239 RID: 45625 RVA: 0x001AACE3 File Offset: 0x001A8EE3
		// (set) Token: 0x0600B23A RID: 45626 RVA: 0x001AACEB File Offset: 0x001A8EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostTeleportId
		{
			get
			{
				return this.hostTeleportId_;
			}
			set
			{
				this.hostTeleportId_ = value;
			}
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x001AACF4 File Offset: 0x001A8EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HostTeleportUnlockNotify);
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x001AAD02 File Offset: 0x001A8F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HostTeleportUnlockNotify other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.HostTeleportId == other.HostTeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x001AAD40 File Offset: 0x001A8F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.HostTeleportId != 0)
			{
				num ^= this.HostTeleportId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x001AAD98 File Offset: 0x001A8F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B23F RID: 45631 RVA: 0x001AADA5 File Offset: 0x001A8FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B240 RID: 45632 RVA: 0x001AADB0 File Offset: 0x001A8FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.HostTeleportId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HostTeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x001AAE0C File Offset: 0x001A900C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.HostTeleportId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostTeleportId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B242 RID: 45634 RVA: 0x001AAE64 File Offset: 0x001A9064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HostTeleportUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.HostTeleportId != 0)
			{
				this.HostTeleportId = other.HostTeleportId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B243 RID: 45635 RVA: 0x001AAEB4 File Offset: 0x001A90B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B244 RID: 45636 RVA: 0x001AAEC0 File Offset: 0x001A90C0
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HostTeleportId = input.ReadInt32();
					}
				}
				else
				{
					this.HostPlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004FB6 RID: 20406
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FB7 RID: 20407
		public const int HostPlayerIdFieldNumber = 3;

		// Token: 0x04004FB8 RID: 20408
		private int hostPlayerId_;

		// Token: 0x04004FB9 RID: 20409
		public const int HostTeleportIdFieldNumber = 9;

		// Token: 0x04004FBA RID: 20410
		private int hostTeleportId_;
	}
}
