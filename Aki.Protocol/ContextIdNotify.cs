using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002ED RID: 749
	[NetMessage(EMessageId.ContextIdNotify)]
	public sealed class ContextIdNotify : IMessage<ContextIdNotify>, IMessage, IEquatable<ContextIdNotify>, IDeepCloneable<ContextIdNotify>, IBufferMessage
	{
		// Token: 0x06004C0B RID: 19467 RVA: 0x000B9295 File Offset: 0x000B7495
		[NullableContext(1)]
		public static ContextIdNotify Create()
		{
			return new ContextIdNotify();
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06004C0C RID: 19468 RVA: 0x000B929C File Offset: 0x000B749C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06004C0D RID: 19469 RVA: 0x000B929F File Offset: 0x000B749F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContextIdNotify.Descriptor;
			}
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x000B92A6 File Offset: 0x000B74A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContextIdNotify()
		{
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x000B92AE File Offset: 0x000B74AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContextIdNotify(ContextIdNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x000B92D3 File Offset: 0x000B74D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContextIdNotify Clone()
		{
			return new ContextIdNotify(this);
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x000B92DB File Offset: 0x000B74DB
		// (set) Token: 0x06004C12 RID: 19474 RVA: 0x000B92E3 File Offset: 0x000B74E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x06004C13 RID: 19475 RVA: 0x000B92EC File Offset: 0x000B74EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContextIdNotify);
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x000B92FA File Offset: 0x000B74FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ContextIdNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x000B9328 File Offset: 0x000B7528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x000B9367 File Offset: 0x000B7567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x000B9374 File Offset: 0x000B7574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x000B937D File Offset: 0x000B757D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x000B93B0 File Offset: 0x000B75B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x000B93EE File Offset: 0x000B75EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ContextIdNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x000B941F File Offset: 0x000B761F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x000B9428 File Offset: 0x000B7628
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x040030DF RID: 12511
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030E0 RID: 12512
		public const int IdFieldNumber = 14;

		// Token: 0x040030E1 RID: 12513
		private long id_;
	}
}
