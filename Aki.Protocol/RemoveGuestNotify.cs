using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFC RID: 3836
	[NetMessage(EMessageId.RemoveGuestNotify)]
	public sealed class RemoveGuestNotify : IMessage<RemoveGuestNotify>, IMessage, IEquatable<RemoveGuestNotify>, IDeepCloneable<RemoveGuestNotify>, IBufferMessage
	{
		// Token: 0x060148D8 RID: 84184 RVA: 0x002FC6FC File Offset: 0x002FA8FC
		[NullableContext(1)]
		public static RemoveGuestNotify Create()
		{
			return new RemoveGuestNotify();
		}

		// Token: 0x1700445B RID: 17499
		// (get) Token: 0x060148D9 RID: 84185 RVA: 0x002FC703 File Offset: 0x002FA903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700445C RID: 17500
		// (get) Token: 0x060148DA RID: 84186 RVA: 0x002FC706 File Offset: 0x002FA906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveGuestNotify.Descriptor;
			}
		}

		// Token: 0x060148DB RID: 84187 RVA: 0x002FC70D File Offset: 0x002FA90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGuestNotify()
		{
		}

		// Token: 0x060148DC RID: 84188 RVA: 0x002FC715 File Offset: 0x002FA915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGuestNotify(RemoveGuestNotify other) : this()
		{
			this.guestId_ = other.guestId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060148DD RID: 84189 RVA: 0x002FC73A File Offset: 0x002FA93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGuestNotify Clone()
		{
			return new RemoveGuestNotify(this);
		}

		// Token: 0x1700445D RID: 17501
		// (get) Token: 0x060148DE RID: 84190 RVA: 0x002FC742 File Offset: 0x002FA942
		// (set) Token: 0x060148DF RID: 84191 RVA: 0x002FC74A File Offset: 0x002FA94A
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

		// Token: 0x060148E0 RID: 84192 RVA: 0x002FC753 File Offset: 0x002FA953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveGuestNotify);
		}

		// Token: 0x060148E1 RID: 84193 RVA: 0x002FC761 File Offset: 0x002FA961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveGuestNotify other)
		{
			return other != null && (other == this || (this.GuestId == other.GuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060148E2 RID: 84194 RVA: 0x002FC790 File Offset: 0x002FA990
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

		// Token: 0x060148E3 RID: 84195 RVA: 0x002FC7CF File Offset: 0x002FA9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060148E4 RID: 84196 RVA: 0x002FC7DC File Offset: 0x002FA9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060148E5 RID: 84197 RVA: 0x002FC7E5 File Offset: 0x002FA9E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GuestId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060148E6 RID: 84198 RVA: 0x002FC818 File Offset: 0x002FAA18
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

		// Token: 0x060148E7 RID: 84199 RVA: 0x002FC856 File Offset: 0x002FAA56
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

		// Token: 0x060148E8 RID: 84200 RVA: 0x002FC887 File Offset: 0x002FAA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060148E9 RID: 84201 RVA: 0x002FC890 File Offset: 0x002FAA90
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007C90 RID: 31888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C91 RID: 31889
		public const int GuestIdFieldNumber = 5;

		// Token: 0x04007C92 RID: 31890
		private int guestId_;
	}
}
