using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A7 RID: 1959
	[NetMessage(EMessageId.HostFogIdUnlockNotify)]
	public sealed class HostFogIdUnlockNotify : IMessage<HostFogIdUnlockNotify>, IMessage, IEquatable<HostFogIdUnlockNotify>, IDeepCloneable<HostFogIdUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600B0C7 RID: 45255 RVA: 0x001A7FB5 File Offset: 0x001A61B5
		[NullableContext(1)]
		public static HostFogIdUnlockNotify Create()
		{
			return new HostFogIdUnlockNotify();
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x0600B0C8 RID: 45256 RVA: 0x001A7FBC File Offset: 0x001A61BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x0600B0C9 RID: 45257 RVA: 0x001A7FBF File Offset: 0x001A61BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HostFogIdUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600B0CA RID: 45258 RVA: 0x001A7FC6 File Offset: 0x001A61C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostFogIdUnlockNotify()
		{
		}

		// Token: 0x0600B0CB RID: 45259 RVA: 0x001A7FCE File Offset: 0x001A61CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostFogIdUnlockNotify(HostFogIdUnlockNotify other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.hostFogId_ = other.hostFogId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0CC RID: 45260 RVA: 0x001A7FFF File Offset: 0x001A61FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostFogIdUnlockNotify Clone()
		{
			return new HostFogIdUnlockNotify(this);
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x0600B0CD RID: 45261 RVA: 0x001A8007 File Offset: 0x001A6207
		// (set) Token: 0x0600B0CE RID: 45262 RVA: 0x001A800F File Offset: 0x001A620F
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

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x0600B0CF RID: 45263 RVA: 0x001A8018 File Offset: 0x001A6218
		// (set) Token: 0x0600B0D0 RID: 45264 RVA: 0x001A8020 File Offset: 0x001A6220
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

		// Token: 0x0600B0D1 RID: 45265 RVA: 0x001A8029 File Offset: 0x001A6229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HostFogIdUnlockNotify);
		}

		// Token: 0x0600B0D2 RID: 45266 RVA: 0x001A8037 File Offset: 0x001A6237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HostFogIdUnlockNotify other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.HostFogId == other.HostFogId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0D3 RID: 45267 RVA: 0x001A8078 File Offset: 0x001A6278
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

		// Token: 0x0600B0D4 RID: 45268 RVA: 0x001A80D0 File Offset: 0x001A62D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B0D5 RID: 45269 RVA: 0x001A80DD File Offset: 0x001A62DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0D6 RID: 45270 RVA: 0x001A80E8 File Offset: 0x001A62E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.HostFogId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HostFogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0D7 RID: 45271 RVA: 0x001A8144 File Offset: 0x001A6344
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

		// Token: 0x0600B0D8 RID: 45272 RVA: 0x001A819C File Offset: 0x001A639C
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

		// Token: 0x0600B0D9 RID: 45273 RVA: 0x001A81EC File Offset: 0x001A63EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0DA RID: 45274 RVA: 0x001A81F8 File Offset: 0x001A63F8
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
					if (num != 56U)
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

		// Token: 0x04004FAA RID: 20394
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FAB RID: 20395
		public const int HostPlayerIdFieldNumber = 3;

		// Token: 0x04004FAC RID: 20396
		private int hostPlayerId_;

		// Token: 0x04004FAD RID: 20397
		public const int HostFogIdFieldNumber = 7;

		// Token: 0x04004FAE RID: 20398
		private int hostFogId_;
	}
}
