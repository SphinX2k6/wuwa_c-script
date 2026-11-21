using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A6 RID: 166
	[NetMessage(EMessageId.AddGuestNotify)]
	public sealed class AddGuestNotify : IMessage<AddGuestNotify>, IMessage, IEquatable<AddGuestNotify>, IDeepCloneable<AddGuestNotify>, IBufferMessage
	{
		// Token: 0x06001CEC RID: 7404 RVA: 0x0005009D File Offset: 0x0004E29D
		[NullableContext(1)]
		public static AddGuestNotify Create()
		{
			return new AddGuestNotify();
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x000500A4 File Offset: 0x0004E2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x000500A7 File Offset: 0x0004E2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddGuestNotify.Descriptor;
			}
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x000500AE File Offset: 0x0004E2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddGuestNotify()
		{
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x000500B6 File Offset: 0x0004E2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddGuestNotify(AddGuestNotify other) : this()
		{
			this.guestId_ = other.guestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000500DB File Offset: 0x0004E2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddGuestNotify Clone()
		{
			return new AddGuestNotify(this);
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x000500E3 File Offset: 0x0004E2E3
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x000500EB File Offset: 0x0004E2EB
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

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000500F4 File Offset: 0x0004E2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddGuestNotify);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00050102 File Offset: 0x0004E302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddGuestNotify other)
		{
			return other != null && (other == this || (this.GuestId == other.GuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00050130 File Offset: 0x0004E330
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

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0005016F File Offset: 0x0004E36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0005017C File Offset: 0x0004E37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00050185 File Offset: 0x0004E385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GuestId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.GuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x000501B8 File Offset: 0x0004E3B8
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

		// Token: 0x06001CFB RID: 7419 RVA: 0x000501F6 File Offset: 0x0004E3F6
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

		// Token: 0x06001CFC RID: 7420 RVA: 0x00050227 File Offset: 0x0004E427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00050230 File Offset: 0x0004E430
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400234C RID: 9036
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400234D RID: 9037
		public const int GuestIdFieldNumber = 11;

		// Token: 0x0400234E RID: 9038
		private int guestId_;
	}
}
