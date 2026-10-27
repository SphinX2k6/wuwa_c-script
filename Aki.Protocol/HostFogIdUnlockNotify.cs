using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BB RID: 1979
	[NetMessage(EMessageId.HostFogIdUnlockNotify)]
	public sealed class HostFogIdUnlockNotify : IMessage<HostFogIdUnlockNotify>, IMessage, IEquatable<HostFogIdUnlockNotify>, IDeepCloneable<HostFogIdUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600B21D RID: 45597 RVA: 0x001AA9E5 File Offset: 0x001A8BE5
		[NullableContext(1)]
		public static HostFogIdUnlockNotify Create()
		{
			return new HostFogIdUnlockNotify();
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x0600B21E RID: 45598 RVA: 0x001AA9EC File Offset: 0x001A8BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x0600B21F RID: 45599 RVA: 0x001AA9EF File Offset: 0x001A8BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HostFogIdUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600B220 RID: 45600 RVA: 0x001AA9F6 File Offset: 0x001A8BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostFogIdUnlockNotify()
		{
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x001AA9FE File Offset: 0x001A8BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostFogIdUnlockNotify(HostFogIdUnlockNotify other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.hostFogId_ = other.hostFogId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B222 RID: 45602 RVA: 0x001AAA2F File Offset: 0x001A8C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostFogIdUnlockNotify Clone()
		{
			return new HostFogIdUnlockNotify(this);
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x0600B223 RID: 45603 RVA: 0x001AAA37 File Offset: 0x001A8C37
		// (set) Token: 0x0600B224 RID: 45604 RVA: 0x001AAA3F File Offset: 0x001A8C3F
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

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x0600B225 RID: 45605 RVA: 0x001AAA48 File Offset: 0x001A8C48
		// (set) Token: 0x0600B226 RID: 45606 RVA: 0x001AAA50 File Offset: 0x001A8C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostFogId
		{
			get
			{
				return this.hostFogId_;
			}
			set
			{
				this.hostFogId_ = value;
			}
		}

		// Token: 0x0600B227 RID: 45607 RVA: 0x001AAA59 File Offset: 0x001A8C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HostFogIdUnlockNotify);
		}

		// Token: 0x0600B228 RID: 45608 RVA: 0x001AAA67 File Offset: 0x001A8C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HostFogIdUnlockNotify other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.HostFogId == other.HostFogId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B229 RID: 45609 RVA: 0x001AAAA8 File Offset: 0x001A8CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.HostFogId != 0)
			{
				num ^= this.HostFogId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B22A RID: 45610 RVA: 0x001AAB00 File Offset: 0x001A8D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B22B RID: 45611 RVA: 0x001AAB0D File Offset: 0x001A8D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B22C RID: 45612 RVA: 0x001AAB18 File Offset: 0x001A8D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.HostFogId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.HostFogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B22D RID: 45613 RVA: 0x001AAB74 File Offset: 0x001A8D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.HostFogId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostFogId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B22E RID: 45614 RVA: 0x001AABCC File Offset: 0x001A8DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HostFogIdUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.HostFogId != 0)
			{
				this.HostFogId = other.HostFogId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B22F RID: 45615 RVA: 0x001AAC1C File Offset: 0x001A8E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B230 RID: 45616 RVA: 0x001AAC28 File Offset: 0x001A8E28
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HostFogId = input.ReadInt32();
					}
				}
				else
				{
					this.HostPlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004FB1 RID: 20401
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FB2 RID: 20402
		public const int HostPlayerIdFieldNumber = 2;

		// Token: 0x04004FB3 RID: 20403
		private int hostPlayerId_;

		// Token: 0x04004FB4 RID: 20404
		public const int HostFogIdFieldNumber = 15;

		// Token: 0x04004FB5 RID: 20405
		private int hostFogId_;
	}
}
