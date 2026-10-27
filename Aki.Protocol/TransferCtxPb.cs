using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F5 RID: 5109
	public sealed class TransferCtxPb : IMessage<TransferCtxPb>, IMessage, IEquatable<TransferCtxPb>, IDeepCloneable<TransferCtxPb>, IBufferMessage
	{
		// Token: 0x0601B125 RID: 110885 RVA: 0x003EB7F4 File Offset: 0x003E99F4
		[NullableContext(1)]
		public static TransferCtxPb Create()
		{
			return new TransferCtxPb();
		}

		// Token: 0x17005B39 RID: 23353
		// (get) Token: 0x0601B126 RID: 110886 RVA: 0x003EB7FB File Offset: 0x003E99FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B3A RID: 23354
		// (get) Token: 0x0601B127 RID: 110887 RVA: 0x003EB7FE File Offset: 0x003E99FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransferCtxPb.Descriptor;
			}
		}

		// Token: 0x0601B128 RID: 110888 RVA: 0x003EB805 File Offset: 0x003E9A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferCtxPb()
		{
		}

		// Token: 0x0601B129 RID: 110889 RVA: 0x003EB80D File Offset: 0x003E9A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferCtxPb(TransferCtxPb other) : this()
		{
			this.teleportId_ = other.teleportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B12A RID: 110890 RVA: 0x003EB832 File Offset: 0x003E9A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferCtxPb Clone()
		{
			return new TransferCtxPb(this);
		}

		// Token: 0x17005B3B RID: 23355
		// (get) Token: 0x0601B12B RID: 110891 RVA: 0x003EB83A File Offset: 0x003E9A3A
		// (set) Token: 0x0601B12C RID: 110892 RVA: 0x003EB842 File Offset: 0x003E9A42
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

		// Token: 0x0601B12D RID: 110893 RVA: 0x003EB84B File Offset: 0x003E9A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransferCtxPb);
		}

		// Token: 0x0601B12E RID: 110894 RVA: 0x003EB859 File Offset: 0x003E9A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransferCtxPb other)
		{
			return other != null && (other == this || (this.TeleportId == other.TeleportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B12F RID: 110895 RVA: 0x003EB888 File Offset: 0x003E9A88
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

		// Token: 0x0601B130 RID: 110896 RVA: 0x003EB8C7 File Offset: 0x003E9AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B131 RID: 110897 RVA: 0x003EB8D4 File Offset: 0x003E9AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B132 RID: 110898 RVA: 0x003EB8DD File Offset: 0x003E9ADD
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

		// Token: 0x0601B133 RID: 110899 RVA: 0x003EB910 File Offset: 0x003E9B10
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

		// Token: 0x0601B134 RID: 110900 RVA: 0x003EB94E File Offset: 0x003E9B4E
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

		// Token: 0x0601B135 RID: 110901 RVA: 0x003EB97F File Offset: 0x003E9B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B136 RID: 110902 RVA: 0x003EB988 File Offset: 0x003E9B88
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

		// Token: 0x04009C9C RID: 40092
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C9D RID: 40093
		public const int TeleportIdFieldNumber = 1;

		// Token: 0x04009C9E RID: 40094
		private int teleportId_;
	}
}
