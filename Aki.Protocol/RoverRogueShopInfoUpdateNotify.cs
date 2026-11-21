using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115E RID: 4446
	[NetMessage(EMessageId.RoverRogueShopInfoUpdateNotify)]
	public sealed class RoverRogueShopInfoUpdateNotify : IMessage<RoverRogueShopInfoUpdateNotify>, IMessage, IEquatable<RoverRogueShopInfoUpdateNotify>, IDeepCloneable<RoverRogueShopInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06017C2F RID: 97327 RVA: 0x00375C16 File Offset: 0x00373E16
		[NullableContext(1)]
		public static RoverRogueShopInfoUpdateNotify Create()
		{
			return new RoverRogueShopInfoUpdateNotify();
		}

		// Token: 0x17004FFF RID: 20479
		// (get) Token: 0x06017C30 RID: 97328 RVA: 0x00375C1D File Offset: 0x00373E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005000 RID: 20480
		// (get) Token: 0x06017C31 RID: 97329 RVA: 0x00375C20 File Offset: 0x00373E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06017C32 RID: 97330 RVA: 0x00375C27 File Offset: 0x00373E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopInfoUpdateNotify()
		{
		}

		// Token: 0x06017C33 RID: 97331 RVA: 0x00375C2F File Offset: 0x00373E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopInfoUpdateNotify(RoverRogueShopInfoUpdateNotify other) : this()
		{
			this.snapshot_ = ((other.snapshot_ != null) ? other.snapshot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C34 RID: 97332 RVA: 0x00375C64 File Offset: 0x00373E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopInfoUpdateNotify Clone()
		{
			return new RoverRogueShopInfoUpdateNotify(this);
		}

		// Token: 0x17005001 RID: 20481
		// (get) Token: 0x06017C35 RID: 97333 RVA: 0x00375C6C File Offset: 0x00373E6C
		// (set) Token: 0x06017C36 RID: 97334 RVA: 0x00375C74 File Offset: 0x00373E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopSnapshot Snapshot
		{
			get
			{
				return this.snapshot_;
			}
			set
			{
				this.snapshot_ = value;
			}
		}

		// Token: 0x06017C37 RID: 97335 RVA: 0x00375C7D File Offset: 0x00373E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopInfoUpdateNotify);
		}

		// Token: 0x06017C38 RID: 97336 RVA: 0x00375C8B File Offset: 0x00373E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Snapshot, other.Snapshot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C39 RID: 97337 RVA: 0x00375CC0 File Offset: 0x00373EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.snapshot_ != null)
			{
				num ^= this.Snapshot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017C3A RID: 97338 RVA: 0x00375CFC File Offset: 0x00373EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C3B RID: 97339 RVA: 0x00375D09 File Offset: 0x00373F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C3C RID: 97340 RVA: 0x00375D12 File Offset: 0x00373F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.snapshot_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Snapshot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017C3D RID: 97341 RVA: 0x00375D44 File Offset: 0x00373F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.snapshot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Snapshot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017C3E RID: 97342 RVA: 0x00375D84 File Offset: 0x00373F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.snapshot_ != null)
			{
				if (this.snapshot_ == null)
				{
					this.Snapshot = new RoverRogueShopSnapshot();
				}
				this.Snapshot.MergeFrom(other.Snapshot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017C3F RID: 97343 RVA: 0x00375DD8 File Offset: 0x00373FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C40 RID: 97344 RVA: 0x00375DE4 File Offset: 0x00373FE4
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.snapshot_ == null)
					{
						this.Snapshot = new RoverRogueShopSnapshot();
					}
					input.ReadMessage(this.Snapshot);
				}
			}
		}

		// Token: 0x04008DD4 RID: 36308
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DD5 RID: 36309
		public const int SnapshotFieldNumber = 11;

		// Token: 0x04008DD6 RID: 36310
		private RoverRogueShopSnapshot snapshot_;
	}
}
