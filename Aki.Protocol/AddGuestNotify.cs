using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A5 RID: 165
	[NetMessage(EMessageId.AddGuestNotify)]
	public sealed class AddGuestNotify : IMessage<AddGuestNotify>, IMessage, IEquatable<AddGuestNotify>, IDeepCloneable<AddGuestNotify>, IBufferMessage
	{
		// Token: 0x06001CA5 RID: 7333 RVA: 0x0004F48D File Offset: 0x0004D68D
		[NullableContext(1)]
		public static AddGuestNotify Create()
		{
			return new AddGuestNotify();
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0004F494 File Offset: 0x0004D694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x0004F497 File Offset: 0x0004D697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddGuestNotify.Descriptor;
			}
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0004F49E File Offset: 0x0004D69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddGuestNotify()
		{
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x0004F4A6 File Offset: 0x0004D6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddGuestNotify(AddGuestNotify other) : this()
		{
			this.guestId_ = other.guestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x0004F4CB File Offset: 0x0004D6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddGuestNotify Clone()
		{
			return new AddGuestNotify(this);
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x0004F4D3 File Offset: 0x0004D6D3
		// (set) Token: 0x06001CAC RID: 7340 RVA: 0x0004F4DB File Offset: 0x0004D6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GuestId
		{
			get
			{
				return this.guestId_;
			}
			set
			{
				this.guestId_ = value;
			}
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0004F4E4 File Offset: 0x0004D6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddGuestNotify);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0004F4F2 File Offset: 0x0004D6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddGuestNotify other)
		{
			return other != null && (other == this || (this.GuestId == other.GuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0004F520 File Offset: 0x0004D720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GuestId != 0)
			{
				num ^= this.GuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0004F55F File Offset: 0x0004D75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0004F56C File Offset: 0x0004D76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x0004F575 File Offset: 0x0004D775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GuestId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.GuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0004F5A8 File Offset: 0x0004D7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0004F5E6 File Offset: 0x0004D7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddGuestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GuestId != 0)
			{
				this.GuestId = other.GuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0004F617 File Offset: 0x0004D817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0004F620 File Offset: 0x0004D820
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040022EB RID: 8939
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022EC RID: 8940
		public const int GuestIdFieldNumber = 8;

		// Token: 0x040022ED RID: 8941
		private int guestId_;
	}
}
