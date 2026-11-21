using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001468 RID: 5224
	public sealed class TransferCtxPb : IMessage<TransferCtxPb>, IMessage, IEquatable<TransferCtxPb>, IDeepCloneable<TransferCtxPb>, IBufferMessage
	{
		// Token: 0x0601BBB0 RID: 113584 RVA: 0x00406AC8 File Offset: 0x00404CC8
		[NullableContext(1)]
		public static TransferCtxPb Create()
		{
			return new TransferCtxPb();
		}

		// Token: 0x17005DCE RID: 24014
		// (get) Token: 0x0601BBB1 RID: 113585 RVA: 0x00406ACF File Offset: 0x00404CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DCF RID: 24015
		// (get) Token: 0x0601BBB2 RID: 113586 RVA: 0x00406AD2 File Offset: 0x00404CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransferCtxPb.Descriptor;
			}
		}

		// Token: 0x0601BBB3 RID: 113587 RVA: 0x00406AD9 File Offset: 0x00404CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferCtxPb()
		{
		}

		// Token: 0x0601BBB4 RID: 113588 RVA: 0x00406AE1 File Offset: 0x00404CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferCtxPb(TransferCtxPb other) : this()
		{
			this.teleportId_ = other.teleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BBB5 RID: 113589 RVA: 0x00406B06 File Offset: 0x00404D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferCtxPb Clone()
		{
			return new TransferCtxPb(this);
		}

		// Token: 0x17005DD0 RID: 24016
		// (get) Token: 0x0601BBB6 RID: 113590 RVA: 0x00406B0E File Offset: 0x00404D0E
		// (set) Token: 0x0601BBB7 RID: 113591 RVA: 0x00406B16 File Offset: 0x00404D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TeleportId
		{
			get
			{
				return this.teleportId_;
			}
			set
			{
				this.teleportId_ = value;
			}
		}

		// Token: 0x0601BBB8 RID: 113592 RVA: 0x00406B1F File Offset: 0x00404D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransferCtxPb);
		}

		// Token: 0x0601BBB9 RID: 113593 RVA: 0x00406B2D File Offset: 0x00404D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransferCtxPb other)
		{
			return other != null && (other == this || (this.TeleportId == other.TeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BBBA RID: 113594 RVA: 0x00406B5C File Offset: 0x00404D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TeleportId != 0)
			{
				num ^= this.TeleportId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BBBB RID: 113595 RVA: 0x00406B9B File Offset: 0x00404D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BBBC RID: 113596 RVA: 0x00406BA8 File Offset: 0x00404DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BBBD RID: 113597 RVA: 0x00406BB1 File Offset: 0x00404DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TeleportId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BBBE RID: 113598 RVA: 0x00406BE4 File Offset: 0x00404DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TeleportId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TeleportId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BBBF RID: 113599 RVA: 0x00406C22 File Offset: 0x00404E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransferCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TeleportId != 0)
			{
				this.TeleportId = other.TeleportId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BBC0 RID: 113600 RVA: 0x00406C53 File Offset: 0x00404E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BBC1 RID: 113601 RVA: 0x00406C5C File Offset: 0x00404E5C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TeleportId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A0E3 RID: 41187
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0E4 RID: 41188
		public const int TeleportIdFieldNumber = 1;

		// Token: 0x0400A0E5 RID: 41189
		private int teleportId_;
	}
}
