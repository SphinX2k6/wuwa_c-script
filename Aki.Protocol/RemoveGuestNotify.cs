using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EEC RID: 3820
	[NetMessage(EMessageId.RemoveGuestNotify)]
	public sealed class RemoveGuestNotify : IMessage<RemoveGuestNotify>, IMessage, IEquatable<RemoveGuestNotify>, IDeepCloneable<RemoveGuestNotify>, IBufferMessage
	{
		// Token: 0x060147F3 RID: 83955 RVA: 0x002FB040 File Offset: 0x002F9240
		[NullableContext(1)]
		public static RemoveGuestNotify Create()
		{
			return new RemoveGuestNotify();
		}

		// Token: 0x17004431 RID: 17457
		// (get) Token: 0x060147F4 RID: 83956 RVA: 0x002FB047 File Offset: 0x002F9247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004432 RID: 17458
		// (get) Token: 0x060147F5 RID: 83957 RVA: 0x002FB04A File Offset: 0x002F924A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveGuestNotify.Descriptor;
			}
		}

		// Token: 0x060147F6 RID: 83958 RVA: 0x002FB051 File Offset: 0x002F9251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGuestNotify()
		{
		}

		// Token: 0x060147F7 RID: 83959 RVA: 0x002FB059 File Offset: 0x002F9259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGuestNotify(RemoveGuestNotify other) : this()
		{
			this.guestId_ = other.guestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060147F8 RID: 83960 RVA: 0x002FB07E File Offset: 0x002F927E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGuestNotify Clone()
		{
			return new RemoveGuestNotify(this);
		}

		// Token: 0x17004433 RID: 17459
		// (get) Token: 0x060147F9 RID: 83961 RVA: 0x002FB086 File Offset: 0x002F9286
		// (set) Token: 0x060147FA RID: 83962 RVA: 0x002FB08E File Offset: 0x002F928E
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

		// Token: 0x060147FB RID: 83963 RVA: 0x002FB097 File Offset: 0x002F9297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveGuestNotify);
		}

		// Token: 0x060147FC RID: 83964 RVA: 0x002FB0A5 File Offset: 0x002F92A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveGuestNotify other)
		{
			return other != null && (other == this || (this.GuestId == other.GuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060147FD RID: 83965 RVA: 0x002FB0D4 File Offset: 0x002F92D4
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

		// Token: 0x060147FE RID: 83966 RVA: 0x002FB113 File Offset: 0x002F9313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060147FF RID: 83967 RVA: 0x002FB120 File Offset: 0x002F9320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014800 RID: 83968 RVA: 0x002FB129 File Offset: 0x002F9329
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

		// Token: 0x06014801 RID: 83969 RVA: 0x002FB15C File Offset: 0x002F935C
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

		// Token: 0x06014802 RID: 83970 RVA: 0x002FB19A File Offset: 0x002F939A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveGuestNotify other)
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

		// Token: 0x06014803 RID: 83971 RVA: 0x002FB1CB File Offset: 0x002F93CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014804 RID: 83972 RVA: 0x002FB1D4 File Offset: 0x002F93D4
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

		// Token: 0x04007CBA RID: 31930
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CBB RID: 31931
		public const int GuestIdFieldNumber = 11;

		// Token: 0x04007CBC RID: 31932
		private int guestId_;
	}
}
