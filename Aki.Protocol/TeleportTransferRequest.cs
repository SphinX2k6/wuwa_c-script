using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001341 RID: 4929
	[NetMessage(EMessageId.TeleportTransferRequest)]
	public sealed class TeleportTransferRequest : IMessage<TeleportTransferRequest>, IMessage, IEquatable<TeleportTransferRequest>, IDeepCloneable<TeleportTransferRequest>, IBufferMessage
	{
		// Token: 0x0601A2EF RID: 107247 RVA: 0x003CD799 File Offset: 0x003CB999
		[NullableContext(1)]
		public static TeleportTransferRequest Create()
		{
			return new TeleportTransferRequest();
		}

		// Token: 0x1700584D RID: 22605
		// (get) Token: 0x0601A2F0 RID: 107248 RVA: 0x003CD7A0 File Offset: 0x003CB9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700584E RID: 22606
		// (get) Token: 0x0601A2F1 RID: 107249 RVA: 0x003CD7A3 File Offset: 0x003CB9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportTransferRequest.Descriptor;
			}
		}

		// Token: 0x0601A2F2 RID: 107250 RVA: 0x003CD7AA File Offset: 0x003CB9AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportTransferRequest()
		{
		}

		// Token: 0x0601A2F3 RID: 107251 RVA: 0x003CD7B2 File Offset: 0x003CB9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportTransferRequest(TeleportTransferRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A2F4 RID: 107252 RVA: 0x003CD7D7 File Offset: 0x003CB9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportTransferRequest Clone()
		{
			return new TeleportTransferRequest(this);
		}

		// Token: 0x1700584F RID: 22607
		// (get) Token: 0x0601A2F5 RID: 107253 RVA: 0x003CD7DF File Offset: 0x003CB9DF
		// (set) Token: 0x0601A2F6 RID: 107254 RVA: 0x003CD7E7 File Offset: 0x003CB9E7
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

		// Token: 0x0601A2F7 RID: 107255 RVA: 0x003CD7F0 File Offset: 0x003CB9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportTransferRequest);
		}

		// Token: 0x0601A2F8 RID: 107256 RVA: 0x003CD7FE File Offset: 0x003CB9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportTransferRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A2F9 RID: 107257 RVA: 0x003CD82C File Offset: 0x003CBA2C
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

		// Token: 0x0601A2FA RID: 107258 RVA: 0x003CD86B File Offset: 0x003CBA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A2FB RID: 107259 RVA: 0x003CD878 File Offset: 0x003CBA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A2FC RID: 107260 RVA: 0x003CD881 File Offset: 0x003CBA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A2FD RID: 107261 RVA: 0x003CD8B4 File Offset: 0x003CBAB4
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

		// Token: 0x0601A2FE RID: 107262 RVA: 0x003CD8F2 File Offset: 0x003CBAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportTransferRequest other)
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

		// Token: 0x0601A2FF RID: 107263 RVA: 0x003CD923 File Offset: 0x003CBB23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A300 RID: 107264 RVA: 0x003CD92C File Offset: 0x003CBB2C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040098BA RID: 39098
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098BB RID: 39099
		public const int IdFieldNumber = 4;

		// Token: 0x040098BC RID: 39100
		private int id_;
	}
}
