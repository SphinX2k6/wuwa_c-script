using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A8 RID: 1960
	[NetMessage(EMessageId.HostTeleportUnlockNotify)]
	public sealed class HostTeleportUnlockNotify : IMessage<HostTeleportUnlockNotify>, IMessage, IEquatable<HostTeleportUnlockNotify>, IDeepCloneable<HostTeleportUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600B0DB RID: 45275 RVA: 0x001A8250 File Offset: 0x001A6450
		[NullableContext(1)]
		public static HostTeleportUnlockNotify Create()
		{
			return new HostTeleportUnlockNotify();
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x0600B0DC RID: 45276 RVA: 0x001A8257 File Offset: 0x001A6457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x0600B0DD RID: 45277 RVA: 0x001A825A File Offset: 0x001A645A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HostTeleportUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600B0DE RID: 45278 RVA: 0x001A8261 File Offset: 0x001A6461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostTeleportUnlockNotify()
		{
		}

		// Token: 0x0600B0DF RID: 45279 RVA: 0x001A8269 File Offset: 0x001A6469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostTeleportUnlockNotify(HostTeleportUnlockNotify other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.hostTeleportId_ = other.hostTeleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0E0 RID: 45280 RVA: 0x001A829A File Offset: 0x001A649A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HostTeleportUnlockNotify Clone()
		{
			return new HostTeleportUnlockNotify(this);
		}

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x0600B0E1 RID: 45281 RVA: 0x001A82A2 File Offset: 0x001A64A2
		// (set) Token: 0x0600B0E2 RID: 45282 RVA: 0x001A82AA File Offset: 0x001A64AA
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

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x0600B0E3 RID: 45283 RVA: 0x001A82B3 File Offset: 0x001A64B3
		// (set) Token: 0x0600B0E4 RID: 45284 RVA: 0x001A82BB File Offset: 0x001A64BB
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

		// Token: 0x0600B0E5 RID: 45285 RVA: 0x001A82C4 File Offset: 0x001A64C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HostTeleportUnlockNotify);
		}

		// Token: 0x0600B0E6 RID: 45286 RVA: 0x001A82D2 File Offset: 0x001A64D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HostTeleportUnlockNotify other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.HostTeleportId == other.HostTeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0E7 RID: 45287 RVA: 0x001A8310 File Offset: 0x001A6510
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

		// Token: 0x0600B0E8 RID: 45288 RVA: 0x001A8368 File Offset: 0x001A6568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B0E9 RID: 45289 RVA: 0x001A8375 File Offset: 0x001A6575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0EA RID: 45290 RVA: 0x001A8380 File Offset: 0x001A6580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.HostTeleportId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.HostTeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0EB RID: 45291 RVA: 0x001A83DC File Offset: 0x001A65DC
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

		// Token: 0x0600B0EC RID: 45292 RVA: 0x001A8434 File Offset: 0x001A6634
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

		// Token: 0x0600B0ED RID: 45293 RVA: 0x001A8484 File Offset: 0x001A6684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0EE RID: 45294 RVA: 0x001A8490 File Offset: 0x001A6690
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
				if (num != 32U)
				{
					if (num != 88U)
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

		// Token: 0x04004FAF RID: 20399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FB0 RID: 20400
		public const int HostPlayerIdFieldNumber = 4;

		// Token: 0x04004FB1 RID: 20401
		private int hostPlayerId_;

		// Token: 0x04004FB2 RID: 20402
		public const int HostTeleportIdFieldNumber = 11;

		// Token: 0x04004FB3 RID: 20403
		private int hostTeleportId_;
	}
}
