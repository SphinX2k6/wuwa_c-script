using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063F RID: 1599
	[NetMessage(EMessageId.FriendDeleteRequest)]
	public sealed class FriendDeleteRequest : IMessage<FriendDeleteRequest>, IMessage, IEquatable<FriendDeleteRequest>, IDeepCloneable<FriendDeleteRequest>, IBufferMessage
	{
		// Token: 0x0600937A RID: 37754 RVA: 0x00164D29 File Offset: 0x00162F29
		[NullableContext(1)]
		public static FriendDeleteRequest Create()
		{
			return new FriendDeleteRequest();
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x0600937B RID: 37755 RVA: 0x00164D30 File Offset: 0x00162F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x0600937C RID: 37756 RVA: 0x00164D33 File Offset: 0x00162F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendDeleteRequest.Descriptor;
			}
		}

		// Token: 0x0600937D RID: 37757 RVA: 0x00164D3A File Offset: 0x00162F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteRequest()
		{
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x00164D42 File Offset: 0x00162F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteRequest(FriendDeleteRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600937F RID: 37759 RVA: 0x00164D67 File Offset: 0x00162F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteRequest Clone()
		{
			return new FriendDeleteRequest(this);
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06009380 RID: 37760 RVA: 0x00164D6F File Offset: 0x00162F6F
		// (set) Token: 0x06009381 RID: 37761 RVA: 0x00164D77 File Offset: 0x00162F77
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

		// Token: 0x06009382 RID: 37762 RVA: 0x00164D80 File Offset: 0x00162F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendDeleteRequest);
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x00164D8E File Offset: 0x00162F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendDeleteRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009384 RID: 37764 RVA: 0x00164DBC File Offset: 0x00162FBC
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

		// Token: 0x06009385 RID: 37765 RVA: 0x00164DFB File Offset: 0x00162FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x00164E08 File Offset: 0x00163008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x00164E11 File Offset: 0x00163011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009388 RID: 37768 RVA: 0x00164E44 File Offset: 0x00163044
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

		// Token: 0x06009389 RID: 37769 RVA: 0x00164E82 File Offset: 0x00163082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendDeleteRequest other)
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

		// Token: 0x0600938A RID: 37770 RVA: 0x00164EB3 File Offset: 0x001630B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x00164EBC File Offset: 0x001630BC
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004735 RID: 18229
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004736 RID: 18230
		public const int IdFieldNumber = 11;

		// Token: 0x04004737 RID: 18231
		private int id_;
	}
}
