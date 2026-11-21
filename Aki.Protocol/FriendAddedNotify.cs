using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000634 RID: 1588
	[NetMessage(EMessageId.FriendAddedNotify)]
	public sealed class FriendAddedNotify : IMessage<FriendAddedNotify>, IMessage, IEquatable<FriendAddedNotify>, IDeepCloneable<FriendAddedNotify>, IBufferMessage
	{
		// Token: 0x060092A9 RID: 37545 RVA: 0x00163372 File Offset: 0x00161572
		[NullableContext(1)]
		public static FriendAddedNotify Create()
		{
			return new FriendAddedNotify();
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x060092AA RID: 37546 RVA: 0x00163379 File Offset: 0x00161579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x060092AB RID: 37547 RVA: 0x0016337C File Offset: 0x0016157C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendAddedNotify.Descriptor;
			}
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x00163383 File Offset: 0x00161583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAddedNotify()
		{
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x0016338B File Offset: 0x0016158B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAddedNotify(FriendAddedNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x001633C0 File Offset: 0x001615C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAddedNotify Clone()
		{
			return new FriendAddedNotify(this);
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x060092AF RID: 37551 RVA: 0x001633C8 File Offset: 0x001615C8
		// (set) Token: 0x060092B0 RID: 37552 RVA: 0x001633D0 File Offset: 0x001615D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x001633D9 File Offset: 0x001615D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendAddedNotify);
		}

		// Token: 0x060092B2 RID: 37554 RVA: 0x001633E7 File Offset: 0x001615E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendAddedNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x0016341C File Offset: 0x0016161C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092B4 RID: 37556 RVA: 0x00163458 File Offset: 0x00161658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x00163465 File Offset: 0x00161665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092B6 RID: 37558 RVA: 0x0016346E File Offset: 0x0016166E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092B7 RID: 37559 RVA: 0x001634A0 File Offset: 0x001616A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092B8 RID: 37560 RVA: 0x001634E0 File Offset: 0x001616E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendAddedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new FriendInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060092B9 RID: 37561 RVA: 0x00163534 File Offset: 0x00161734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092BA RID: 37562 RVA: 0x00163540 File Offset: 0x00161740
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new FriendInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04004705 RID: 18181
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004706 RID: 18182
		public const int InfoFieldNumber = 14;

		// Token: 0x04004707 RID: 18183
		private FriendInfo info_;
	}
}
